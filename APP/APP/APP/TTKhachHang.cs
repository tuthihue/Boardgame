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
    public partial class TTKhachHang : Form
    {
        static MySqlConnection conn;
        public TTKhachHang()
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

        private void TTCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void them_Click(object sender, EventArgs e)
        {
            string user = username.Text;
            string passwd = password.Text;
            string hoten = hovaten.Text;
            string phone = sodienthoai.Text;
            string mail = tkemail.Text;
            conn.Open();
            MySqlCommand mySqlCommand = new MySqlCommand("insert into Customers(UserName,HOTEN,PassWord,sdt,email) values(@user, @hoten, @passwd, @phone, @mail) ", conn);
            mySqlCommand.Parameters.AddWithValue("@user", user);
            mySqlCommand.Parameters.AddWithValue("@hoten", hoten);
            mySqlCommand.Parameters.AddWithValue("@passwd", passwd);
            mySqlCommand.Parameters.AddWithValue("@phone", phone);
            mySqlCommand.Parameters.AddWithValue("@mail", mail);
            mySqlCommand.ExecuteNonQuery();
            DateTime currentDate = DateTime.Now;

            string formattedDate = currentDate.ToString("yyyy-MM-dd");

            MySqlCommand mySqlCommand1 = new MySqlCommand("insert into wp_users(User_login,display_name,user_nicename,user_Pass,user_email,user_registered) values(@user, @hoten, @user,@passwd, @mail,@date) ", conn);
            mySqlCommand1.Parameters.AddWithValue("@user", user);
            mySqlCommand1.Parameters.AddWithValue("@hoten", hoten);
            mySqlCommand1.Parameters.AddWithValue("@passwd", passwd);
            mySqlCommand1.Parameters.AddWithValue("@mail", mail);
            mySqlCommand1.Parameters.AddWithValue("@date", formattedDate);
            mySqlCommand1.ExecuteNonQuery();
            MessageBox.Show("Thêm Khách hàng thành công!");
            conn.Close();
            username.Text = "";
            hovaten.Text = "";
            password.Text = "";
            sodienthoai.Text = "";
            tkemail.Text = "";
        }
    }
}
