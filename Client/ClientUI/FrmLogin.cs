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
using ExtendClass;
using System.Net;
using ClientLib;

namespace ClientUI
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        public static ClientSocket socket = new ClientSocket();
        public string svIP;
        public FrmLogin()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            if (svIP != string.Empty)
            { IP.Text = svIP; }
            Register_btn.Click += new EventHandler(Register_btn_Click);
            SignIn_btn.Click += new EventHandler(Login_btn_Click);
            Connect_btn.Click += new EventHandler(Connect_btn_click);
     
        }
        private void Register_btn_Click(object sender,EventArgs e)
        {
           
            if (IP.Text != string.Empty)
            { 
                this.Hide();
                new FrmRegister().ShowDialog();
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("server IP is empty");
            }


        }
        private void Connect_btn_click(object sendr,EventArgs e)
        {
            svIP = IP.Text;
            socket.ServerIP = IPAddress.Parse(IP.Text); 
            socket.Init();
        }
        private void Login_btn_Click(object sender,EventArgs e)
        {
           

            if (IP.Text != string.Empty)
            {

               
                string user = User_txt.Text;
                string pass = Pass_txt.Text;
                socket.Login(user, pass);
                socket.CloseForm(this);
                socket.DisplayForm(new FrmMenu());
            }
            else
            {
                XtraMessageBox.Show("server IP is empty");
            }
           
               
            
        }



    }
    
}