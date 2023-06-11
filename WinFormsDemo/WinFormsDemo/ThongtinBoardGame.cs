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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsDemo
{
    public partial class ThongtinBoardGame : Form
    {
        static MySqlConnection conn;
        public ThongtinBoardGame()
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



        private void addBG_Click(object sender, EventArgs e)
        {

        }

        private void delBG_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void delSp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa sản phẩm BoardGame này ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                string Masp = masp.Text;
                conn.Open();

                MySqlCommand mySqlCommand = new MySqlCommand("delete from boardgame where MASP=@masp ", conn);
                mySqlCommand.Parameters.AddWithValue("@masp", Masp);
                mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("xóa BoardGame thành công!");
                conn.Close();
                masp.Text = "";
            }
            else
            {
                MessageBox.Show("Hủy Thành Công!");
            }
        }

        private void AddAdmin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void them_Click(object sender, EventArgs e)
        {
            string masp = MaBG.Text;
            string tensp = TenBG.Text;
            string gia = Gia.Text;
            string TL = Theloai.Text;
            string Soluong = SL.Text;
            string mt = Mota.Text;
            conn.Open();
            MySqlCommand mySqlCommand = new MySqlCommand("insert into boardgame values(@masp,@tensp,@gia,@TL,@soluong,@mt) ", conn);
            mySqlCommand.Parameters.AddWithValue("@masp", masp);
            mySqlCommand.Parameters.AddWithValue("@tensp", tensp);
            mySqlCommand.Parameters.AddWithValue("@gia", gia);
            mySqlCommand.Parameters.AddWithValue("@TL", TL);
            mySqlCommand.Parameters.AddWithValue("@Soluong", Soluong);
            mySqlCommand.Parameters.AddWithValue("@mt", mt);
            mySqlCommand.ExecuteNonQuery();
            MessageBox.Show("Thêm BoardGame thành công!");
            conn.Close();
            MaBG.Text = "";
            TenBG.Text = "";
            Gia.Text = "";
            Theloai.Text = "";
            SL.Text = "";
            Mota.Text = "";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void suaBG_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sửa sản phẩm BoardGame này ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                string masp = MaBG1.Text;
                string tensp = TenBG1.Text;
                string gia = Gia1.Text;
                string TL = Theloai1.Text;
                string Soluong = SL1.Text;
                string mt = Mota1.Text;
                conn.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("update boardgame set TENSP=@tensp,GIA=@gia,THELOAI=@TL,SOLUONG=@Soluong,MOTA=@mt where MASP=@masp ", conn);
                mySqlCommand.Parameters.AddWithValue("@masp", masp);
                mySqlCommand.Parameters.AddWithValue("@tensp", tensp);
                mySqlCommand.Parameters.AddWithValue("@gia", gia);
                mySqlCommand.Parameters.AddWithValue("@TL", TL);
                mySqlCommand.Parameters.AddWithValue("@Soluong", Soluong);
                mySqlCommand.Parameters.AddWithValue("@mt", mt);
                mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("sửa BoardGame thành công!");
                conn.Close();
                MaBG.Text = "";
                TenBG.Text = "";
                Gia.Text = "";
                Theloai.Text = "";
                SL.Text = "";
                Mota.Text = "";
            }
            else
            {
                MessageBox.Show("Hủy thành công !");
            }
        }

        private void TTAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {
        }
    }
}
