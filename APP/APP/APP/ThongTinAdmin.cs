using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP
{
    public partial class ThongTinAdmin : Form
    {
        static MySqlConnection conn;
        public ThongTinAdmin()
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
            finally
            {
                conn.Close();
            }
        }

        private void them_Click(object sender, EventArgs e)
        {
            string user = username.Text;
            string passwd = password.Text;
            string hoten = hovaten.Text;
            string phone = sodienthoai.Text;
            string mail = tkemail.Text;
            conn.Open();
            MySqlCommand mySqlCommand = new MySqlCommand("insert into admins(UserName,HOTEN,PassWord,sdt,email) values(@user, @hoten, @passwd, @phone, @mail) ", conn);
            mySqlCommand.Parameters.AddWithValue("@user", user);
            mySqlCommand.Parameters.AddWithValue("@hoten", hoten);
            mySqlCommand.Parameters.AddWithValue("@passwd", passwd);
            mySqlCommand.Parameters.AddWithValue("@phone", phone);
            mySqlCommand.Parameters.AddWithValue("@mail", mail);
            mySqlCommand.ExecuteNonQuery();
            MessageBox.Show("Thêm Quản trị viên thành công!");
            conn.Close();
            username.Text = "";
            hovaten.Text = "";
            password.Text = "";
            sodienthoai.Text = "";
            tkemail.Text = "";

        }
    }
}
