using System;
using System.Net;
using System.Collections.Generic;
using System.Net.Sockets;
using Interfaces;
using ExtendClass;
using System.Collections;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using System.Drawing;
using System.Data.SQLite;
using System.Text;
using Enums;

namespace ServerLib
{
    public class ServerSocket : IServerSocket
    {
        #region Constant
        //port number
        const int PORT_NUM = 8085;
        #endregion

        
        #region Private Members
        // Server Socket
        private Socket serverSocket;
        //log info
        private string log;
        //Data stream
        private byte[] dataStream;

        //List of clients
        private ArrayList clientList;

        // Status delegate
        private delegate void UpdateStatusDelegate(string satus,object sender,EventArgs e);
        private UpdateStatusDelegate updateStatus;

        //Log delegate
        private delegate void UpdateLogDelegate(string log, object sender, EventArgs e);
        private UpdateLogDelegate updateLog;

        //Connection
        private Connection conn;
        private SQLiteConnection sqlite_conn;

        //Struct to store client info
        private struct Client
        {
            public EndPoint endPoint;
            public string name;
            public string password;
        }
        #endregion

        #region Constructor
        public ArrayList ClientList
        {
            get { return clientList; }
            set { clientList = value; }
        }
        
        public void Init()
        {
            try
            {
                log = "Listening";
                conn = new Connection();
                sqlite_conn = conn.CreateConnect();
                clientList = new ArrayList();
                dataStream = new byte[1024];
                updateStatus = new UpdateStatusDelegate(UpdateStatus);
                updateLog = new UpdateLogDelegate(UpdateLog);
                serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                IPEndPoint server = new IPEndPoint(IPAddress.Any, PORT_NUM);
                serverSocket.Bind(server);
                IPEndPoint clients = new IPEndPoint(IPAddress.Any, 0);
                EndPoint epSender = (EndPoint)clients;
                
                serverSocket.BeginReceiveFrom(dataStream, 0, dataStream.Length, SocketFlags.None, ref epSender, new AsyncCallback(ReceiveCallback), epSender);
            }
            catch(Exception e)
            {
                XtraMessageBox.Show(string.Format("Error:{0}",e.Message));
                log = string.Format("Error:{0}", e.Message);
                serverSocket.Close();
            }

        }
        public string Log
        {
            get { return log; }
            set { log = value; }
        }
        #endregion
        #region Methods
        public void Disconnect(object sender, EventArgs e)
        {
            XtraMessageBoxArgs args = new XtraMessageBoxArgs();
            args.Showing += Args_Showing;
            args.Buttons = new DialogResult[] { DialogResult.OK, DialogResult.Cancel };
            args.Text = "Đóng server ?";
            DialogResult result = XtraMessageBox.Show(args);
            if (result == DialogResult.OK)
                serverSocket.Close();
           
        }

        

        public void ReceiveCallback(IAsyncResult iar)
        {
            try
            {
                byte[] data = new byte[1024];
                Packet recvData = new Packet(dataStream);
                Packet sendData = new Packet();
                IPEndPoint clients = new IPEndPoint(IPAddress.Any, 0);
                EndPoint epSender = (EndPoint)clients;
                serverSocket.EndReceiveFrom(iar,ref epSender);
                sendData.dataIdentifier = recvData.dataIdentifier;
                sendData.Sender = recvData.Sender;
                switch(recvData.dataIdentifier)
                {
                    case DataIdentifier.Register:
                        Client register = new Client();
                        register.endPoint = (EndPoint)epSender;
                        Packet RegPacket = new Packet(dataStream);
                        register.name = RegPacket.Sender;
                        register.password = RegPacket.Message;
                        bool isReg = conn.Register(register.name,register.password);
                        if(isReg)
                        {
                          
                            Packet reg = new Packet();
                            
                            reg.Sender = register.name;
                            reg.Receiver = null;
                            reg.dataIdentifier = DataIdentifier.Register;
                            byte[] RegResponse = reg.GetDataStream();
                            serverSocket.BeginSendTo(RegResponse, 0, RegResponse.Length, SocketFlags.None, register.endPoint, new AsyncCallback(SendCallback), register.endPoint);
                        }
                        break;

                    case DataIdentifier.Message:
                        sendData.Message = string.Format("{0}: {1}",recvData.Sender,recvData.Message);
                        break;

                    case DataIdentifier.LogIn:
                        Client client = new Client();
                        client.endPoint = (EndPoint)epSender;
                        Packet login = new Packet(dataStream);
                        client.name = login.Sender;
                        client.password = login.Message;
                        bool isValid = conn.CheckLogin(client.name,client.password);
                        if(isValid)
                        {
                            this.clientList.Add(client);
                            sendData.Message = string.Format("-- {0} is online --", client.name);
                            log = string.Format("-- {0} is online --", client.name);
                            Packet pack = new Packet();
                            pack.dataIdentifier = DataIdentifier.LogIn;
                            pack.Sender = sendData.Sender;
                            pack.Message = null;
                            byte[] response = pack.GetDataStream();
                            serverSocket.BeginSendTo(response, 0, response.Length, SocketFlags.None, client.endPoint, new AsyncCallback(SendCallback),client.endPoint);
                        }
                        break;

                    case DataIdentifier.LogOut:
                        // Remove current client from list
                        foreach (Client c in this.clientList)
                        {
                            if (c.endPoint.Equals(epSender))
                            {
                                this.clientList.Remove(c);
                                break;
                            }
                        }
                        sendData.Message = string.Format("-- {0} has gone offline --", recvData.Sender);
                        log = string.Format("-- {0} has gone offline --", recvData.Sender);
                        break;
                        
                }
                data = sendData.GetDataStream();

                foreach (Client client in this.clientList)
                {
                    if (client.endPoint != epSender || sendData.dataIdentifier != DataIdentifier.LogIn)
                    {
                        // Broadcast to all logged on users
                        serverSocket.BeginSendTo(data, 0, data.Length, SocketFlags.None, client.endPoint, new AsyncCallback(SendCallback), client.endPoint);
                    }
                }
                // Listen for more connections again...
                serverSocket.BeginReceiveFrom(this.dataStream, 0, this.dataStream.Length, SocketFlags.None, ref epSender, new AsyncCallback(ReceiveCallback), epSender);

                
                
            }
            catch(Exception e)
            {
                XtraMessageBox.Show(string.Format("Can not receive data:{0}",e.Message));
                serverSocket.Close();
                
            }
        }

        public void SendCallback(IAsyncResult iar)
        {
            try
            {
                serverSocket.EndSend(iar);
                
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Send data error!");
                serverSocket.Close();
            }
        }
        #endregion

        #region Other Methods
        private void Args_Showing(object sender, XtraMessageShowingArgs e)
        {
            e.Form.Text = "Thông báo";
            e.Buttons[DialogResult.OK].Text = "Đồng ý";
            e.Buttons[DialogResult.Cancel].Text = "Hủy";
            e.Form.ForeColor = Color.Red;
            e.Form.BackColor = Color.AliceBlue;

        }
        public void UpdateStatus(string status,object sender,EventArgs e)
        {
            TextEdit textEdit = (TextEdit)sender;
            
            textEdit.Text = status;
        }
        public void UpdateLog(string log, object sender,EventArgs e)
        {
            ListBox list = (ListBox)sender;
            list.Items.Add(string.Format("{0}: {1}",DateTime.Now.ToString(),log));
        }
        #endregion










    }
}
