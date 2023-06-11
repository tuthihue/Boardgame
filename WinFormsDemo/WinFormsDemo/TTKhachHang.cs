using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsDemo
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
            finally
            {
                conn.Close();
            }
        }
        private void label5_Click(object sender, EventArgs e)
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
            MessageBox.Show("Thêm Khách hàng thành công!");
            conn.Close();
            username.Text = "";
            hovaten.Text = "";
            password.Text = "";
            sodienthoai.Text = "";
            tkemail.Text = "";
        }

        private void delSp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa tài khoản của khách hàng này ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                string account = tentk.Text;
                conn.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("delete from customers where UserName =@account ", conn);
                mySqlCommand.Parameters.AddWithValue("@account", account);
                mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("xóa thành công thành công!");
                conn.Close();
                tentk.Text = "";

            }
            else
            {
                MessageBox.Show("Hủy Thành Công!");
            }
        }

        private void suaBG_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sửa tài khoản của khách hàng này ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                string user = account.Text;
                string passwd = matkhau.Text;
                string hoten = hovten.Text;
                string phone = phonenb.Text;
                string mail = tkmail.Text;
                conn.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("UPDATE customers SET HOTEN=@hoten,PassWord=@passwd,sdt=@phone,email=@mail where UserName=@user", conn);
                mySqlCommand.Parameters.AddWithValue("@user", user);
                mySqlCommand.Parameters.AddWithValue("@hoten", hoten);
                mySqlCommand.Parameters.AddWithValue("@passwd", passwd);
                mySqlCommand.Parameters.AddWithValue("@phone", phone);
                mySqlCommand.Parameters.AddWithValue("@mail", mail);
                mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Sửa Thông Tin khách hàng thành công!");
                account.Text = "";
                hovten.Text = "";
                matkhau.Text = "";
                phonenb.Text = "";
                tkmail.Text = "";
                conn.Close();


            }
            else
            {
                MessageBox.Show("Hủy Thành Công!");
            }
        }
    }
}
