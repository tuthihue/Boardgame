namespace APP
{
    partial class TTKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TTKH = new TabControl();
            TTSP = new TabPage();
            label14 = new Label();
            TTCustomers = new DataGridView();
            addKH = new TabPage();
            delKH = new TabPage();
            updateKH = new TabPage();
            TTKH.SuspendLayout();
            TTSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TTCustomers).BeginInit();
            SuspendLayout();
            // 
            // TTKH
            // 
            TTKH.Controls.Add(TTSP);
            TTKH.Controls.Add(addKH);
            TTKH.Controls.Add(delKH);
            TTKH.Controls.Add(updateKH);
            TTKH.Location = new Point(1, 1);
            TTKH.Name = "TTKH";
            TTKH.SelectedIndex = 0;
            TTKH.Size = new Size(1243, 745);
            TTKH.TabIndex = 6;
            // 
            // TTSP
            // 
            TTSP.Controls.Add(label14);
            TTSP.Controls.Add(TTCustomers);
            TTSP.Location = new Point(4, 29);
            TTSP.Name = "TTSP";
            TTSP.Padding = new Padding(3);
            TTSP.Size = new Size(1235, 712);
            TTSP.TabIndex = 0;
            TTSP.Text = "Thông tin khách hàng";
            TTSP.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = SystemColors.HotTrack;
            label14.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label14.ForeColor = Color.Cornsilk;
            label14.Location = new Point(12, 9);
            label14.Name = "label14";
            label14.Size = new Size(351, 41);
            label14.TabIndex = 9;
            label14.Text = "Thông Tin Khách hàng";
            // 
            // TTCustomers
            // 
            TTCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            TTCustomers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            TTCustomers.BackgroundColor = SystemColors.ButtonHighlight;
            TTCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TTCustomers.Location = new Point(129, 74);
            TTCustomers.Name = "TTCustomers";
            TTCustomers.ReadOnly = true;
            TTCustomers.RowHeadersWidth = 51;
            TTCustomers.RowTemplate.Height = 29;
            TTCustomers.Size = new Size(791, 491);
            TTCustomers.TabIndex = 8;
            TTCustomers.CellContentClick += TTCustomers_CellContentClick;
            // 
            // addKH
            // 
            addKH.Location = new Point(4, 29);
            addKH.Name = "addKH";
            addKH.Padding = new Padding(3);
            addKH.Size = new Size(1235, 712);
            addKH.TabIndex = 1;
            addKH.Text = "Thêm Khách hàng";
            addKH.UseVisualStyleBackColor = true;
            // 
            // delKH
            // 
            delKH.Location = new Point(4, 29);
            delKH.Name = "delKH";
            delKH.Padding = new Padding(3);
            delKH.Size = new Size(1235, 712);
            delKH.TabIndex = 2;
            delKH.Text = "Xóa Khách hàng";
            delKH.UseVisualStyleBackColor = true;
            // 
            // updateKH
            // 
            updateKH.Location = new Point(4, 29);
            updateKH.Name = "updateKH";
            updateKH.Padding = new Padding(3);
            updateKH.Size = new Size(1235, 712);
            updateKH.TabIndex = 3;
            updateKH.Text = "Sửa Thông tin khách hàng";
            updateKH.UseVisualStyleBackColor = true;
            // 
            // TTKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1352, 778);
            Controls.Add(TTKH);
            Name = "TTKhachHang";
            Text = "TTKhachHang";
            TTKH.ResumeLayout(false);
            TTSP.ResumeLayout(false);
            TTSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TTCustomers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TTKH;
        private TabPage TTSP;
        private Label label14;
        public DataGridView TTCustomers;
        private TabPage addKH;
        private TabPage delKH;
        private TabPage updateKH;
    }
}