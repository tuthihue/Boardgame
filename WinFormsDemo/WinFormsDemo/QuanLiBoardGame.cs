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
        MySqlConnection conn;
        MySqlCommandBuilder cmd;
        MySqlDataAdapter adap;
        DataTable mytable;
        public QuanLiBoardGame()
        {
            InitializeComponent();
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
            ThongTinAdmin TT = new ThongTinAdmin();
            TT.ShowDialog();

        }

        private void thôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
