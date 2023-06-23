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
using MySql.Data.MySqlClient;
namespace WinFormsDemo
{
    public partial class QuanLiBoardGame : Form
    {
        static MySqlConnection conn;
        public string Admin;
        public string slkh = "0";
        public string ds = "0";
        public string slgame = "0";
        public string HoVaTen = "0";
        public QuanLiBoardGame(string Account_Admin)
        {
            InitializeComponent();
            Connection();
            Admin = Account_Admin;
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

        private void QuanLyBoardGame_Load(object sender, EventArgs e)
        {
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoiMatKhau change = new DoiMatKhau();
            change.ShowDialog();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TTAcount TTacc = new TTAcount(Admin);
            TTacc.ShowDialog();

        }

        private void thôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TTKhachHang tt = new TTKhachHang();
            conn.Open();
            MySqlCommand insertCommand1 = new MySqlCommand("insert into customers select user_login,display_name,user_pass,0,user_email from wp_users where user_login not in(select username from customers)", conn);
            insertCommand1.ExecuteNonQuery();
            MySqlCommand mySqlComman = new MySqlCommand("select * from customers", conn);
            MySqlDataReader reader = mySqlComman.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            tt.TTCustomers.DataSource = dt;
            tt.ShowDialog();
            conn.Close();
        }

        private void thôngTinQuảnTrịViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinAdmin tt = new ThongTinAdmin();
            conn.Open();
            MySqlCommand mySqlComman = new MySqlCommand("select * from admins", conn);
            MySqlDataReader reader = mySqlComman.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            tt.TTAdmin.DataSource = dt;
            tt.ShowDialog();
            conn.Close();
        }

        private void thôngTinSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongtinBoardGame tt = new ThongtinBoardGame();
            conn.Open();
            MySqlCommand mySqlComman = new MySqlCommand("select * from boardgame", conn);
            MySqlDataReader reader = mySqlComman.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            tt.TTBoardGame.DataSource = dt;

            tt.ShowDialog();
            conn.Close();
        }

        private void thôngTinTrảBoardGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TraBoardGame TTTra = new TraBoardGame();
            TTTra.ShowDialog();
        }

        private void thôngTinThuêBoardGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThueBoardGame TTThue = new ThueBoardGame();
            TTThue.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DateTime selectedDate1 = dateTimePicker1.Value;
            string date1 = selectedDate1.ToString("yyyy-MM-dd");
            DateTime selectedDate2 = dateTimePicker2.Value;
            string date2 = selectedDate2.ToString("yyyy-MM-dd");
            
            


        }

        private void TKSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime selectedDate1 = dateTimePicker1.Value;
            string date1 = selectedDate1.ToString("yyyy-MM-dd");
            DateTime selectedDate2 = dateTimePicker2.Value;
            string date2 = selectedDate2.ToString("yyyy-MM-dd");
            if (conn.State != System.Data.ConnectionState.Closed)
            {
                conn.Close();
            }
            conn.Open();
            MySqlCommand insertCommand1 = new MySqlCommand("insert into order_game select order_id, customer_id,date(date_created) as date_created,sum(product_gross_revenue) as tongtien,count(order_id) as soluong from wp_wc_order_product_lookup where date_created between @date1 and @date2 and wp_wc_order_product_lookup.order_id not in (select order_id from order_game) group by order_id,customer_id, date(date_created)", conn);
            insertCommand1.Parameters.AddWithValue("@date1", date1);
            insertCommand1.Parameters.AddWithValue("@date2", date2);
            insertCommand1.ExecuteNonQuery();
            MySqlCommand insertCommand2 = new MySqlCommand("INSERT into thue select order_id,display_name,date_created,tongtien from order_game o join wp_users c on o.customer_id=c.id where date_created between @date1 and @date2 and order_id not in (select ID_thue from thue);", conn);
            insertCommand2.Parameters.AddWithValue("@date1", date1);
            insertCommand2.Parameters.AddWithValue("@date2", date2);
            insertCommand2.ExecuteNonQuery();
            conn.Close();
            conn.Open();
            MySqlCommand mySqlComman = new MySqlCommand("select count(*) as soluong from wp_users where date(user_registered) between @date1 and @date2 ", conn);
            mySqlComman.Parameters.AddWithValue("@date1", date1);
            mySqlComman.Parameters.AddWithValue("@date2", date2);
            MySqlDataReader Reader = mySqlComman.ExecuteReader();
            while (Reader.Read())
            {
                slkh = Reader.GetString("soluong");
            }
            Reader.Close();
            MySqlCommand mySqlComman1 = new MySqlCommand("select sum(tongtien) as dt from thue where ngaythue between @date1 and @date2 ", conn);
            mySqlComman1.Parameters.AddWithValue("@date1", date1);
            mySqlComman1.Parameters.AddWithValue("@date2", date2);
            MySqlDataReader Reader1 = mySqlComman1.ExecuteReader();
            while (Reader1.Read())
            {
                ds = Reader1.GetString("dt");
            }
            Reader1.Close();
            MySqlCommand mySqlComman2 = new MySqlCommand("select sum(soluong) as slg from order_game where date_created between @date1 and @date2 ", conn);
            mySqlComman2.Parameters.AddWithValue("@date1", date1);
            mySqlComman2.Parameters.AddWithValue("@date2", date2);
            MySqlDataReader Reader2 = mySqlComman2.ExecuteReader();
            while (Reader2.Read())
            {
                slgame = Reader2.GetString("slg");
            }
            Reader2.Close();
            MySqlCommand mySqlComman3 = new MySqlCommand("select hoten from admins where username=@Admin ", conn);
            mySqlComman3.Parameters.AddWithValue("@Admin", Admin);
            MySqlDataReader Reader3 = mySqlComman3.ExecuteReader();
            while (Reader3.Read())
            {
                HoVaTen = Reader3.GetString("hoten");
            }
            Reader3.Close();
            conn.Close();
            conn.Open();
            MySqlCommand Command1 = new MySqlCommand("WITH temp AS (SELECT t.USERNAME, HOTEN, sdt, SUM(tongtien) AS DoanhSo FROM thue t JOIN customers c ON t.username = c.username WHERE ngaythue BETWEEN @date1 AND @date2 GROUP BY t.username, hoten, sdt ORDER BY SUM(tongtien) DESC LIMIT 3) select USERNAME,HOTEN,sdt,concat(DoanhSo,'000') as DoanhSo from temp", conn);
            Command1.Parameters.AddWithValue("@date1", date1);
            Command1.Parameters.AddWithValue("@date2", date2);
            MySqlDataReader reader = Command1.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            TKSP.DataSource = dt;
            conn.Close();
            string date3 = selectedDate1.ToString("dd-MM-yyyy");
            string date4 = selectedDate2.ToString("dd-MM-yyyy");
            label2.Text = "Tính từ ngày " + date3 + " tới ngày " + date4;
            label3.Text = "Có tổng " + slkh + " đăng kí tài khoản trên website";
            label4.Text = "Doanh thu thu được là: " + ds + "000 VNĐ" + "";
            label5.Text = "Có tổng " + slgame + " game được thuê";
            label6.Text = "Xin chào quản trị viên " + HoVaTen + ",";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
