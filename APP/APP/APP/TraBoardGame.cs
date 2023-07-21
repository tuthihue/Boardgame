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

        private void button2_Click_1(object sender, EventArgs e)
        {
            string idthue = mahd.Text;
            DateTime selectedDate1 = dateTimePicker1.Value;
            string date1 = selectedDate1.ToString("yyyy-MM-dd");
            conn.Open();
            MySqlCommand mySqlComman2 = new MySqlCommand("select count(*) as slg from thue where ID_thue=@idthue", conn);
            mySqlComman2.Parameters.AddWithValue("@idthue", idthue);
            string slgame = "";
            MySqlDataReader Reader2 = mySqlComman2.ExecuteReader();
            while (Reader2.Read())
            {
                slgame = Reader2.GetString("slg");
            }
            Reader2.Close();
            conn.Close();

            if (string.IsNullOrEmpty(mahd.Text))
            {
                MessageBox.Show("Mã hóa đơn không được để trống !");
            }
            else if (slgame == "0")
            {
                MessageBox.Show("Mã hóa đơn không tồn tại (Mã hóa đơn là ID thuê của khách hàng) !");
            }
            else
            {
                conn.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("insert into tragame(ID_THUE,ngaytra) values(@mahd,@date)", conn);
                MySqlCommand mySqlCommand2 = new MySqlCommand("delete from thue where ID_THUE=@mahd ", conn);
                MySqlCommand mySqlCommand3 = new MySqlCommand("delete from thuegame where ID_THUE=@mahd ", conn);
                mySqlCommand.Parameters.AddWithValue("@mahd", idthue);
                mySqlCommand2.Parameters.AddWithValue("@mahd", idthue);
                mySqlCommand3.Parameters.AddWithValue("@mahd", idthue);
                mySqlCommand.Parameters.AddWithValue("@date", date1);
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand2.ExecuteNonQuery();
                mySqlCommand3.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!");
                conn.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void mahd_TextChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string searchValue = searchBar.Text.ToString();
            search(searchValue);
        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {

        }
        public void search(string searchValue)
        {
            string query = "SELECT * FROM `tragame`" +
                " WHERE CONCAT(`ID_TRA`, `ID_THUE`, `NGAYTRA`) like '%" + searchValue + "%'";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            TTTraBoardGame.DataSource = table;
        }

        private void refreshButton_Click_1(object sender, EventArgs e)
        {
            search("");
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            search("");
        }

    }
}
