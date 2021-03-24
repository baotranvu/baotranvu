using System;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using System.Data.SQLite;


namespace ServerLib
{
    public class Connection
    {
        public SQLiteConnection sqlite_conn;
        private const string batch = @".\sqlite\Database.db";
        public SQLiteConnection CreateConnect()
        {

            // Create a new database connection:

            string sql =string.Format("URI=file:{0}",System.IO.Path.GetFullPath(batch));
            sqlite_conn = new SQLiteConnection(sql);
            //sqlite_conn = new SQLiteConnection("Data Source = Database.db; Version = 3; New =False; Compress= true ");
         // Open the connection:
         try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(string.Format("Unexpected error! Error:{0}",ex));
                sqlite_conn.Close();
                Application.Exit();
            }
            return sqlite_conn;
        }
        public bool Register(string user,string pass)
        {
            bool reg= false;
            SQLiteCommand sqlite_cmd;
            try
            {
                string cmd = string.Format("INSERT INTO USER (UserName,Password) VALUES ('{0}','{1}');", user, pass);
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = cmd;
                int value = sqlite_cmd.ExecuteNonQuery();
                if (value != 0)
                {
                    reg = true;
                }
                else
                {
                    reg = false;
                }
                return reg;
            }catch(Exception e)
            {
                XtraMessageBox.Show(string.Format("Can not Register, try again! Error:{0}",e.Message));
                return false;
            }

        }
        public bool CheckLogin(string user,string pass)
        {
            try
            {
                bool IsValid = false;
                SQLiteDataReader sqlite_reader;
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = string.Format("SELECT UserName,Password FROM USER WHERE UserName='{0}' AND Password='{1}'", user, pass);
                sqlite_reader = sqlite_cmd.ExecuteReader();
                if (sqlite_reader.HasRows)
                {
                    
                    IsValid = true;
                }
                else
                {
                    IsValid = false;
                }
                return IsValid;
            }
            catch(Exception e )
            {
                XtraMessageBox.Show("Can not check valid account!");
                return false;
            }
        }
        
        
    }
}
