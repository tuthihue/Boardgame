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

namespace WinFormsDemo
{
    public partial class ThueBoardGame : Form
    {
        static MySqlConnection conn;
        public ThueBoardGame()
        {
            InitializeComponent();
            Connection();
        }
        static void Connection()
        {
            string connstr = "server=127.0.0.1;uid=root;pwd=;database=qlboardgame";
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

        private void TTThueBoardGame_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand insertCommand1 = new MySqlCommand("insert into order_game select order_id, customer_id,date(date_created) as date_created,sum(product_gross_revenue) as tongtien,count(order_id) as soluong from wp_wc_order_product_lookup where wp_wc_order_product_lookup.order_id not in (select order_id from order_game)\r\ngroup by order_id,customer_id, date(date_created)", conn);
            insertCommand1.ExecuteNonQuery();
            MySqlCommand insertCommand2 = new MySqlCommand("INSERT into thue select order_id,display_name,date_created,tongtien from order_game o join wp_users c on o.customer_id=c.id where order_id not in (select ID_thue from thue);", conn);
            insertCommand2.ExecuteNonQuery();
            MySqlCommand mySqlComman = new MySqlCommand("select ID_THUE,USERNAME,NGAYTHUE,concat(TONGTIEN,'.000') as TONGTIEN from THUE", conn);
            MySqlDataReader reader = mySqlComman.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            TTThueBoardGame.DataSource = dt;
            conn.Close();
        }
    }
}
