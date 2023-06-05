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
    public partial class XoaSP : Form
    {
        static MySqlConnection conn;
        public XoaSP()
        {
            InitializeComponent();
            Connection();
        }
        static void Connection()
        {
            string connstr = "server=127.0.0.1;uid=root;pwd=122606;database=quanlyboardgame";
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

        private void masp_Click(object sender, EventArgs e)
        {
        }

        private void del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa sản phẩm ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                string Masp = masp.Text;
                conn.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("delete from boardgame where MASP=@masp ", conn);
                mySqlCommand.Parameters.AddWithValue("@masp", Masp);
                MessageBox.Show("xóa thành công thành công!");
            }
            else
            {
                MessageBox.Show("Hủy Thành Công!");
            }
           
        }
    }
}
