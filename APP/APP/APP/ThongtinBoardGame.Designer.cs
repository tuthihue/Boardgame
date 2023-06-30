namespace APP
{
    partial class ThongtinBoardGame
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
            tabControl1 = new TabControl();
            TTSP = new TabPage();
            label14 = new Label();
            TTBoardGame = new DataGridView();
            addBG = new TabPage();
            delBG = new TabPage();
            updateBG = new TabPage();
            label4 = new Label();
            AddAdmin = new Panel();
            Mota = new TextBox();
            label5 = new Label();
            them = new Button();
            SL = new TextBox();
            email = new Label();
            Theloai = new TextBox();
            sdt = new Label();
            Gia = new TextBox();
            pass = new Label();
            TenBG = new TextBox();
            name = new Label();
            MaBG = new TextBox();
            label = new Label();
            tabControl1.SuspendLayout();
            TTSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TTBoardGame).BeginInit();
            addBG.SuspendLayout();
            AddAdmin.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(TTSP);
            tabControl1.Controls.Add(addBG);
            tabControl1.Controls.Add(delBG);
            tabControl1.Controls.Add(updateBG);
            tabControl1.Location = new Point(1, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1243, 745);
            tabControl1.TabIndex = 5;
            // 
            // TTSP
            // 
            TTSP.Controls.Add(label14);
            TTSP.Controls.Add(TTBoardGame);
            TTSP.Location = new Point(4, 29);
            TTSP.Name = "TTSP";
            TTSP.Padding = new Padding(3);
            TTSP.Size = new Size(1235, 712);
            TTSP.TabIndex = 0;
            TTSP.Text = "Thông tin BoardGame";
            TTSP.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = SystemColors.HotTrack;
            label14.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label14.ForeColor = Color.Cornsilk;
            label14.Location = new Point(9, 6);
            label14.Name = "label14";
            label14.Size = new Size(350, 41);
            label14.TabIndex = 9;
            label14.Text = "Thông Tin BoardGame";
            // 
            // TTBoardGame
            // 
            TTBoardGame.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            TTBoardGame.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            TTBoardGame.BackgroundColor = SystemColors.ButtonHighlight;
            TTBoardGame.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TTBoardGame.Location = new Point(9, 74);
            TTBoardGame.Name = "TTBoardGame";
            TTBoardGame.ReadOnly = true;
            TTBoardGame.RowHeadersWidth = 51;
            TTBoardGame.RowTemplate.Height = 29;
            TTBoardGame.Size = new Size(1206, 631);
            TTBoardGame.TabIndex = 8;
            // 
            // addBG
            // 
            addBG.Controls.Add(label4);
            addBG.Controls.Add(AddAdmin);
            addBG.Location = new Point(4, 29);
            addBG.Name = "addBG";
            addBG.Padding = new Padding(3);
            addBG.Size = new Size(1235, 712);
            addBG.TabIndex = 1;
            addBG.Text = "Thêm BoardGame";
            addBG.UseVisualStyleBackColor = true;
            // 
            // delBG
            // 
            delBG.Location = new Point(4, 29);
            delBG.Name = "delBG";
            delBG.Padding = new Padding(3);
            delBG.Size = new Size(1235, 712);
            delBG.TabIndex = 2;
            delBG.Text = "Xóa BoardGame";
            delBG.UseVisualStyleBackColor = true;
            // 
            // updateBG
            // 
            updateBG.Location = new Point(4, 29);
            updateBG.Name = "updateBG";
            updateBG.Padding = new Padding(3);
            updateBG.Size = new Size(1235, 712);
            updateBG.TabIndex = 3;
            updateBG.Text = "Sửa BoardGame";
            updateBG.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.HotTrack;
            label4.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.Cornsilk;
            label4.Location = new Point(0, 3);
            label4.Name = "label4";
            label4.Size = new Size(283, 41);
            label4.TabIndex = 12;
            label4.Text = "Thêm BoardGame";
            // 
            // AddAdmin
            // 
            AddAdmin.Controls.Add(Mota);
            AddAdmin.Controls.Add(label5);
            AddAdmin.Controls.Add(them);
            AddAdmin.Controls.Add(SL);
            AddAdmin.Controls.Add(email);
            AddAdmin.Controls.Add(Theloai);
            AddAdmin.Controls.Add(sdt);
            AddAdmin.Controls.Add(Gia);
            AddAdmin.Controls.Add(pass);
            AddAdmin.Controls.Add(TenBG);
            AddAdmin.Controls.Add(name);
            AddAdmin.Controls.Add(MaBG);
            AddAdmin.Controls.Add(label);
            AddAdmin.Location = new Point(193, 103);
            AddAdmin.Name = "AddAdmin";
            AddAdmin.Size = new Size(636, 443);
            AddAdmin.TabIndex = 11;
            // 
            // Mota
            // 
            Mota.Location = new Point(133, 334);
            Mota.Name = "Mota";
            Mota.Size = new Size(268, 27);
            Mota.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 334);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 11;
            label5.Text = "Mô tả";
            // 
            // them
            // 
            them.BackColor = Color.Green;
            them.Location = new Point(350, 385);
            them.Name = "them";
            them.Size = new Size(97, 38);
            them.TabIndex = 10;
            them.Text = "Thêm";
            them.UseVisualStyleBackColor = false;
            them.Click += them_Click;
            // 
            // SL
            // 
            SL.Location = new Point(133, 277);
            SL.Name = "SL";
            SL.Size = new Size(268, 27);
            SL.TabIndex = 9;
            // 
            // email
            // 
            email.AutoSize = true;
            email.Location = new Point(25, 277);
            email.Name = "email";
            email.Size = new Size(69, 20);
            email.TabIndex = 8;
            email.Text = "Số lượng";
            // 
            // Theloai
            // 
            Theloai.Location = new Point(133, 218);
            Theloai.Name = "Theloai";
            Theloai.Size = new Size(268, 27);
            Theloai.TabIndex = 7;
            // 
            // sdt
            // 
            sdt.AutoSize = true;
            sdt.Location = new Point(25, 221);
            sdt.Name = "sdt";
            sdt.Size = new Size(65, 20);
            sdt.TabIndex = 6;
            sdt.Text = "Thể Loại";
            // 
            // Gia
            // 
            Gia.Location = new Point(133, 158);
            Gia.Name = "Gia";
            Gia.Size = new Size(268, 27);
            Gia.TabIndex = 5;
            // 
            // pass
            // 
            pass.AutoSize = true;
            pass.Location = new Point(47, 158);
            pass.Name = "pass";
            pass.Size = new Size(31, 20);
            pass.TabIndex = 4;
            pass.Text = "Giá";
            // 
            // TenBG
            // 
            TenBG.Location = new Point(133, 99);
            TenBG.Name = "TenBG";
            TenBG.Size = new Size(268, 27);
            TenBG.TabIndex = 3;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(14, 99);
            name.Name = "name";
            name.Size = new Size(115, 20);
            name.TabIndex = 2;
            name.Text = "Tên BoardGame";
            // 
            // MaBG
            // 
            MaBG.Location = new Point(133, 42);
            MaBG.Name = "MaBG";
            MaBG.Size = new Size(268, 27);
            MaBG.TabIndex = 1;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(14, 42);
            label.Name = "label";
            label.Size = new Size(113, 20);
            label.TabIndex = 0;
            label.Text = "Mã BoardGame";
            // 
            // ThongtinBoardGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1299, 871);
            Controls.Add(tabControl1);
            Name = "ThongtinBoardGame";
            Text = "ThongtinBoardGame";
            tabControl1.ResumeLayout(false);
            TTSP.ResumeLayout(false);
            TTSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TTBoardGame).EndInit();
            addBG.ResumeLayout(false);
            addBG.PerformLayout();
            AddAdmin.ResumeLayout(false);
            AddAdmin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage TTSP;
        private Label label14;
        public DataGridView TTBoardGame;
        private TabPage addBG;
        private TabPage delBG;
        private TabPage updateBG;
        private Label label4;
        private Panel AddAdmin;
        private TextBox Mota;
        private Label label5;
        private Button them;
        private TextBox SL;
        private Label email;
        private TextBox Theloai;
        private Label sdt;
        private TextBox Gia;
        private Label pass;
        private TextBox TenBG;
        private Label name;
        private TextBox MaBG;
        private Label label;
    }
}