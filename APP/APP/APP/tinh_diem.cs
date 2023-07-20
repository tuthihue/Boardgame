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
        private Button searchButton;
        private Button refreshButton;
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

        public void search(string searcValue)
        {
            string query = "SELECT * FROM `tich_diem`" +
                " WHERE CONCAT(`Id_diem`, `USERNAME`, `diem`, `score_used`) like '%" + searcValue + "%'";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            pointDataGridView.DataSource = table;
        }

        //Phần dưới trình duyệt tự tạo 
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tinh_diem));
            this.pointDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
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
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchButton.Location = new System.Drawing.Point(385, 464);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 36);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.refreshButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.refreshButton.Location = new System.Drawing.Point(506, 464);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 36);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "LÀM MỚI";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // tinh_diem
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(620, 512);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.searchButton);
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchValue = searchBar.Text.ToString();
            search(searchValue);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            search("");
        }
    }
}
