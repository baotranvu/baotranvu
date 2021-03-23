using System;
using System.Net;
using System.Net.Sockets;
using ExtendClass;
using Interfaces;
using DevExpress.XtraEditors;
using Enums;
using System.Windows.Forms;

namespace ClientLib
{
    public class ClientSocket : IClientSocket
    {
        #region Constant
        const int PORT_NUM = 8085;
        #endregion

        #region Private Members
        //Cient socket
        private Socket clientSocket;

        //Client Name
        private string name;

        //Server Endpoint
        private EndPoint epServer;

        //Data stream
        private byte[] dataStream;

        //Ip enpoint
        private IPEndPoint server;

        //Display message
        private delegate void DisplayMessageDelegate(string msg,object sender,EventArgs e);
        private DisplayMessageDelegate displayMessageDelegate = null;

        private bool isLogedin;
        private bool isRegistered;
        private string logMess;
        private IPAddress serverIP;
        #endregion

        #region Methods
        #region Contructor
        public IPAddress ServerIP
        {
            get { return serverIP; }
            set { serverIP = value; }
        }
        public bool IsLogedin
        {
            get { return isLogedin; }
            set { isLogedin = value; }
        }
        public bool IsRegistered
        {
            get { return isRegistered; }
            set { isRegistered = value; }
        }

        public string LogMess
        {
            get { return logMess; }
            set { logMess = value; }
        }

        #endregion
        
        public void Disconnet()
        {
            try
            {
                if (this.clientSocket != null)
                {
                    // Initialise a packet object to store the data to be sent
                    Packet sendData = new Packet();
                    sendData.dataIdentifier = DataIdentifier.LogOut;
                    sendData.Sender = this.name;
                    sendData.Message = null;

                    // Get packet as byte array
                    byte[] byteData = sendData.GetDataStream();

                    // Send packet to the server
                    this.clientSocket.SendTo(byteData, 0, byteData.Length, SocketFlags.None, epServer);

                    // Close the socket
                    this.clientSocket.Close();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Close error!");
            }
        }
        

        public void ReceiveCallback(IAsyncResult iar)
        {
            try
            {
                clientSocket.EndReceive(iar);

                // Initialise a packet object to store the received data
                Packet receivedData = new Packet(dataStream);
               switch(receivedData.dataIdentifier)
                {
                    case DataIdentifier.LogIn:
                        isLogedin = true;
                        break;
                    case DataIdentifier.Register:
                        isRegistered = true;  
                        break;
                    default:
                        break;
                }
                logMess = string.Format("{0}:{1}", receivedData.Sender, receivedData.Message);
                this.dataStream = new byte[1024];
                // Continue listening for broadcasts
                clientSocket.BeginReceiveFrom(this.dataStream, 0, this.dataStream.Length, SocketFlags.None, ref epServer, new AsyncCallback(ReceiveCallback), null);


            }
            catch (ObjectDisposedException x)
            {
                XtraMessageBox.Show(string.Format("Invalid data:{0}", x.Message));
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(string.Format("Receive error:{0}",ex.Message));
                
            }
            
        }
        public void Init()
        {
            try
            {
                clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                server = new IPEndPoint(serverIP, PORT_NUM);
                epServer = (EndPoint)server;
                XtraMessageBox.Show(string.Format("Connected to:{0}",server.ToString()));
              
            }
            catch(Exception e)
            {
                XtraMessageBox.Show(string.Format("Can not connect to server!, Error:{0}",e.Message));
              
            }

        }
        public void Send(string mess,string recv)
        {
    
            try
            {
                if(clientSocket == null)
                { Init(); }
                
                displayMessageDelegate = new DisplayMessageDelegate(DisplayMessage);
                Packet sendData = new Packet();
                sendData.dataIdentifier = DataIdentifier.Message;
                sendData.Sender = name;
                sendData.Receiver = recv;
                sendData.Message = mess;
                logMess = string.Format("{0}:{1}", name, mess);
                byte[] data = sendData.GetDataStream();
                clientSocket.BeginSendTo(data, 0, data.Length, SocketFlags.None, epServer, new AsyncCallback(SendCallback), null);
                dataStream = new byte[1024];

                // Begin listening for broadcasts
                clientSocket.BeginReceiveFrom(this.dataStream, 0, this.dataStream.Length, SocketFlags.None, ref epServer, new AsyncCallback(ReceiveCallback), null);
            }catch(Exception e)
            {
                XtraMessageBox.Show(e.Message);
            }

        }

        public void SendCallback(IAsyncResult iar)
        {
           try
            {
                clientSocket.EndSend(iar);
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(string.Format("Sending Error:{0}", ex.Message));
            }
        }

        public void Login(string user, string pass)
        {
            try
            {
                if (clientSocket == null)
                { Init(); }

                Packet login = new Packet();
                login.Sender = user;
                name = user;
                login.Message = pass;
                login.dataIdentifier = DataIdentifier.LogIn;
                this.clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                IPEndPoint server = new IPEndPoint(IPAddress.Parse("127.0.0.1"), PORT_NUM);
                epServer = (EndPoint)server;
                byte[] data = login.GetDataStream();
                clientSocket.BeginSendTo(data, 0, data.Length, SocketFlags.None, epServer, new AsyncCallback(SendCallback), null);
                dataStream = new byte[1024];

                // Begin listening for broadcasts
                clientSocket.BeginReceiveFrom(this.dataStream, 0, this.dataStream.Length, SocketFlags.None, ref epServer, new AsyncCallback(ReceiveCallback), null);
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(string.Format("Login Error:{0}",ex.Message));
            }
        }

      
        public void Register(string user, string pass)
        {
            try
            {
                if (clientSocket == null)
                { Init(); } 
                Packet register = new Packet();
                register.Sender = user;
                register.Message = pass;
                register.dataIdentifier = DataIdentifier.Register;
                epServer = (EndPoint)server;
                byte[] data = register.GetDataStream();
                clientSocket.BeginSendTo(data, 0, data.Length, SocketFlags.None, epServer, new AsyncCallback(SendCallback), null);
                dataStream = new byte[1024];

                clientSocket.BeginReceiveFrom(this.dataStream, 0, this.dataStream.Length, SocketFlags.None, ref epServer, new AsyncCallback(ReceiveCallback), null);

            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(string.Format("Register error:{0}",ex.Message));
            }
           
        }
        public void DisplayMessage(string mess, object sender, EventArgs e)
        {
            ListBox list = (ListBox)sender;
            list.Items.Add(string.Format("{0}: {1}", DateTime.Now.ToString(), mess));
        }
        public void DisplayForm(object sender)
        {
            if(isLogedin||isRegistered)
            XtraMessageBox.Show("Success!");
            Form form = (Form)sender;
            form.ShowDialog();
        }
        public void CloseForm(object sender)
        {
          
            Form form = (Form)sender;
            form.Hide();
            form.Close();
        }
        #endregion
    }
}
