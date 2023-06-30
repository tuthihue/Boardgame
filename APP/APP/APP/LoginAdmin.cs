using System;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace APP
{
    public partial class LoginAdmin : Form
    {
        static MySqlConnection conn = null;
        public string Account_Admin;
        public LoginAdmin()
        {
            InitializeComponent();
            Connection();
        }
        static void Connection()
        {

            string connstr = "server=127.0.0.1;uid=root;pwd=;database=boardgame";
            try
            {
                conn = new MySqlConnection(connstr);
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }

        private void Login_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
        }

        private void username_Click(object sender, EventArgs e)
        {
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
        }

        private void pass_Click(object sender, EventArgs e)
        {
        }

        private void account_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}