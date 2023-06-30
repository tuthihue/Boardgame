namespace APP
{
    partial class ThongTinAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTinAdmin));
            tabControl = new TabControl();
            info = new TabPage();
            label1 = new Label();
            TTAdmin = new DataGridView();
            delete = new TabPage();
            update = new TabPage();
            insert = new TabPage();
            tabControl.SuspendLayout();
            info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TTAdmin).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(info);
            tabControl.Controls.Add(insert);
            tabControl.Controls.Add(delete);
            tabControl.Controls.Add(update);
            tabControl.Location = new Point(2, 1);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1041, 656);
            tabControl.TabIndex = 9;
            tabControl.TabStop = false;
            // 
            // info
            // 
            info.BackgroundImage = (Image)resources.GetObject("info.BackgroundImage");
            info.BackgroundImageLayout = ImageLayout.Stretch;
            info.Controls.Add(label1);
            info.Controls.Add(TTAdmin);
            info.Location = new Point(4, 29);
            info.Name = "info";
            info.Padding = new Padding(3);
            info.Size = new Size(1033, 623);
            info.TabIndex = 0;
            info.Text = "Thông Tin quản trị viên";
            info.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(129, 35);
            label1.Name = "label1";
            label1.Size = new Size(359, 41);
            label1.TabIndex = 7;
            label1.Text = "Thông tin Quản trị viên";
            // 
            // TTAdmin
            // 
            TTAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            TTAdmin.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            TTAdmin.BackgroundColor = SystemColors.ButtonHighlight;
            TTAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TTAdmin.Location = new Point(126, 74);
            TTAdmin.Name = "TTAdmin";
            TTAdmin.ReadOnly = true;
            TTAdmin.RowHeadersWidth = 51;
            TTAdmin.RowTemplate.Height = 29;
            TTAdmin.Size = new Size(791, 491);
            TTAdmin.TabIndex = 3;
            // 
            // delete
            // 
            delete.BackgroundImage = (Image)resources.GetObject("delete.BackgroundImage");
            delete.BackgroundImageLayout = ImageLayout.Stretch;
            delete.Location = new Point(4, 29);
            delete.Name = "delete";
            delete.Padding = new Padding(3);
            delete.Size = new Size(1033, 623);
            delete.TabIndex = 2;
            delete.Text = "Xóa quản trị viên";
            delete.UseVisualStyleBackColor = true;
            // 
            // update
            // 
            update.BackgroundImage = (Image)resources.GetObject("update.BackgroundImage");
            update.BackgroundImageLayout = ImageLayout.Stretch;
            update.Location = new Point(4, 29);
            update.Name = "update";
            update.Padding = new Padding(3);
            update.Size = new Size(1033, 623);
            update.TabIndex = 3;
            update.Text = "Sửa quản trị viên";
            update.UseVisualStyleBackColor = true;
            // 
            // insert
            // 
            insert.BackgroundImage = (Image)resources.GetObject("insert.BackgroundImage");
            insert.BackgroundImageLayout = ImageLayout.Stretch;
            insert.Location = new Point(4, 29);
            insert.Name = "insert";
            insert.Padding = new Padding(3);
            insert.Size = new Size(1033, 623);
            insert.TabIndex = 1;
            insert.Text = "Thêm quản trị viên";
            insert.UseVisualStyleBackColor = true;
            // 
            // ThongTinAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1338, 734);
            Controls.Add(tabControl);
            Name = "ThongTinAdmin";
            Text = "ThongTinAdmin";
            tabControl.ResumeLayout(false);
            info.ResumeLayout(false);
            info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TTAdmin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage info;
        private Label label1;
        public DataGridView TTAdmin;
        private TabPage insert;
        private TabPage delete;
        private TabPage update;
    }
}