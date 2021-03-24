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
using ClientLib;


namespace ClientUI
{
    public partial class FrmRegister : DevExpress.XtraEditors.XtraForm
    {
        ClientSocket socket = FrmLogin.socket;
        
        public FrmRegister()
        {
            
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            Register_btn.Click += new EventHandler(Register_btn_Click);
            
            
            
        }
        private void Register_btn_Click(object sender,EventArgs e)
        {
            if(Pass_txt.Text.Equals(Confirm_txt.Text))
            {
                string user = User_txt.Text;
                string pass = Pass_txt.Text;
                socket.Register(user, pass);
                socket.CloseForm(this);
                socket.DisplayForm(new FrmLogin());
            }
            

        }
        
       
        
    }
}