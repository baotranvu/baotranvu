using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ServerLib;
using System.Data.SQLite;
using DevExpress.XtraBars.Navigation;
using ExtendClass;

namespace ServerUI
{
    public partial class serverUI : DevExpress.XtraEditors.XtraForm
    {
        ServerSocket serverSocket = new ServerSocket();
        bool isInit = false;
        ClientList<Client> clients;
        public serverUI()
        {
           
            InitializeComponent();
            this.Load += new EventHandler(Form_Load);
            ShutDown_btn.ElementClick += new NavElementClickEventHandler(Disconnect);
            FormClosing += new FormClosingEventHandler(Form_close);
            Start_btn.ElementClick += new NavElementClickEventHandler(Form_Load);
            Close_btn.ElementClick += new NavElementClickEventHandler(Form_close);
            clients = serverSocket.ClientsList;
            clients.ClientAddedHandler += new EventHandler(ClientConnect);
            CheckForIllegalCrossThreadCalls = false;
            

        }
        private void Form_Load(object sender, EventArgs e)
        {
            if (isInit==false)
            {
                serverSocket.Init();
                serverSocket.UpdateLog("Opend server.", log_box, e);
                isInit = true;
            }
            else
            {
                XtraMessageBox.Show("Server already opended!");
                
            }
            serverSocket.UpdateLog(serverSocket.Log, log_box, e);
            
            
            

        }
        private void Disconnect(object sender, NavElementEventArgs e)
        {
            serverSocket.Disconnect(sender, e);
            serverSocket.UpdateStatus("Shut down", Status, e);
            serverSocket.UpdateLog("Server shut down", log_box, e);
            isInit = false;
        }
        private void Form_close(object sender, EventArgs e)
        {

            Dispose();
            Close();

        }
        private void ClientConnect(object sender,EventArgs e)
        {
            client_grid.DataSource = clients;
            
        }
    }
}