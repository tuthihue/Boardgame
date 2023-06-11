using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace WinFormsDemo
{
    public partial class QuanLiBoardGame : Form
    {
        static MySqlConnection conn;

        public QuanLiBoardGame()
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
            TTAcount TTacc = new TTAcount();
            TTacc.ShowDialog();

        }

        private void thôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TTKhachHang tt = new TTKhachHang();
            conn.Open();
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
            ThongtinBoardGame tt=new ThongtinBoardGame();
            conn.Open();
            MySqlCommand mySqlComman = new MySqlCommand("select * from boardgame", conn);
            MySqlDataReader reader = mySqlComman.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            tt.TTBoardGame.DataSource = dt;

            tt.ShowDialog();
            conn.Close();
        }
    }
}
