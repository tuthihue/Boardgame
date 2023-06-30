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
    public partial class TraBoardGame : Form
    {
        static MySqlConnection conn;
        public TraBoardGame()
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
        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand mySqlComman = new MySqlCommand("select * from tragame", conn);
            MySqlDataReader reader = mySqlComman.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            TTTraBoardGame.DataSource = dt;
            conn.Close();
        }
    }
}
