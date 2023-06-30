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
namespace APP
{
    public partial class QuanLiBoardGame : Form
    {
        static MySqlConnection conn;
        public string Admin;
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
        private void QuanLiBoardGame_Load(object sender, EventArgs e)
        {

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
    }
}
