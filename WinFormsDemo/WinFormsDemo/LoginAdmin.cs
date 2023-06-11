using System;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsDemo
{
    public partial class LoginAdmin : Form
    {
        static MySqlConnection conn = null;
        public LoginAdmin()
        {
            InitializeComponent();
            Connection();

        }
        static void Connection()
        {
          
            string connstr = "server=127.0.0.1;uid=root;pwd=;database=quanlyboardgame";
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
        void LoginValidation()
        {
            string uname = account.Text;
            string pass = password.Text;

            try
            {
                conn.Open();
                MySqlCommand mySqlComman = new MySqlCommand("select * from admins", conn);
                MySqlDataReader Reader = mySqlComman.ExecuteReader();
                while (Reader.Read())
                {
                    if (uname.Equals(Reader.GetString("USERNAME")) && pass.Equals(Reader.GetString("PassWord")))
                    {
                        QuanLiBoardGame ql = new QuanLiBoardGame();
                        this.Hide();
                        ql.ShowDialog();
                        this.Show();
                        conn.Close();
                        return;
                    }
                    else 
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu sai!");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                return;
            }
            finally
            {
                conn.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            LoginValidation();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoginAdmin page = new();
            page.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Page1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}