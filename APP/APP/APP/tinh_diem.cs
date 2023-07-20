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
using System.Data;
namespace APP
{
    public partial class tinh_diem : Form
    {
        private DataGridView pointDataGridView;
        private Label label1;
        private TextBox searchBar;
        static MySqlConnection conn;
        public tinh_diem()
        {
            InitializeComponent();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tinh_diem_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            string query = "SELECT * FROM `tich_diem`";
            MySqlCommand mySqlCommand = new MySqlCommand(query);
            mySqlCommand.Connection = conn;
            MySqlDataAdapter adapter= new MySqlDataAdapter(mySqlCommand);
            adapter.SelectCommand= mySqlCommand;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dt;
            pointDataGridView.DataSource = dt;
        }


        //Phần dưới trình duyệt tự tạo 
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tinh_diem));
            this.pointDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pointDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pointDataGridView
            // 
            this.pointDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pointDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pointDataGridView.Location = new System.Drawing.Point(32, 79);
            this.pointDataGridView.Name = "pointDataGridView";
            this.pointDataGridView.RowTemplate.Height = 25;
            this.pointDataGridView.Size = new System.Drawing.Size(547, 368);
            this.pointDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(59, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "THÔNG TIN ĐIỂM TÍCH LŨY KHÁCH HÀNG";
            // 
            // searchBar
            // 
            this.searchBar.Location = new System.Drawing.Point(32, 465);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(313, 23);
            this.searchBar.TabIndex = 2;
            this.searchBar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tinh_diem
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(620, 512);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pointDataGridView);
            this.Name = "tinh_diem";
            ((System.ComponentModel.ISupportInitialize)(this.pointDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
