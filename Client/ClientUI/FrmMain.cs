using NeoSmart.Unicode;
using System;
using ClientLib;

namespace ClientUI
{
    public partial class FrmMain : DevExpress.XtraEditors.XtraForm
    {
        ClientSocket socket = new ClientSocket();
        public FrmMain()
        {
            
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            SendButton.Click += new EventHandler(Send_btn_Click);
        }
        private void Send_btn_Click(object sender,EventArgs e)
        {
            if (InputEdit.Text != string.Empty)
            {
               // socket.Send(InputEdit.Text,null);
                socket.DisplayMessage(socket.LogMess,Chat_box,e);
                InputEdit.Clear();
            }

        }

        private void SearchEdit_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
