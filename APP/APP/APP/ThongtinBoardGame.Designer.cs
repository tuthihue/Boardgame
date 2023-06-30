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
            delBG = new TabPage();
            updateBG = new TabPage();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            delSp = new Button();
            label6 = new Label();
            masp = new TextBox();
            tabControl1.SuspendLayout();
            TTSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TTBoardGame).BeginInit();
            addBG.SuspendLayout();
            AddAdmin.SuspendLayout();
            delBG.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(TTSP);
            tabControl1.Controls.Add(addBG);
            tabControl1.Controls.Add(delBG);
            tabControl1.Controls.Add(updateBG);
            tabControl1.Location = new Point(2, 6);
            tabControl1.Margin = new Padding(6);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(2331, 1378);
            tabControl1.TabIndex = 5;
            // 
            // TTSP
            // 
            TTSP.Controls.Add(label1);
            TTSP.Controls.Add(label14);
            TTSP.Controls.Add(TTBoardGame);
            TTSP.Location = new Point(10, 55);
            TTSP.Margin = new Padding(6);
            TTSP.Name = "TTSP";
            TTSP.Padding = new Padding(6);
            TTSP.Size = new Size(2311, 1313);
            TTSP.TabIndex = 0;
            TTSP.Text = "Thông tin BoardGame";
            TTSP.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.Location = new Point(0, 0);
            label14.Name = "label14";
            label14.Size = new Size(100, 23);
            label14.TabIndex = 0;
            // 
            // TTBoardGame
            // 
            TTBoardGame.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            TTBoardGame.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            TTBoardGame.BackgroundColor = SystemColors.ButtonHighlight;
            TTBoardGame.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TTBoardGame.Location = new Point(17, 137);
            TTBoardGame.Margin = new Padding(6);
            TTBoardGame.Name = "TTBoardGame";
            TTBoardGame.ReadOnly = true;
            TTBoardGame.RowHeadersWidth = 51;
            TTBoardGame.RowTemplate.Height = 29;
            TTBoardGame.Size = new Size(2261, 1167);
            TTBoardGame.TabIndex = 8;
            // 
            // addBG
            // 
            addBG.Controls.Add(label4);
            addBG.Controls.Add(AddAdmin);
            addBG.Location = new Point(10, 55);
            addBG.Margin = new Padding(6);
            addBG.Name = "addBG";
            addBG.Padding = new Padding(6);
            addBG.Size = new Size(2311, 1313);
            addBG.TabIndex = 1;
            addBG.Text = "Thêm BoardGame";
            addBG.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.HotTrack;
            label4.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.Cornsilk;
            label4.Location = new Point(0, 6);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(508, 72);
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
            AddAdmin.Location = new Point(362, 191);
            AddAdmin.Margin = new Padding(6);
            AddAdmin.Name = "AddAdmin";
            AddAdmin.Size = new Size(1192, 820);
            AddAdmin.TabIndex = 11;
            // 
            // Mota
            // 
            Mota.Location = new Point(249, 618);
            Mota.Margin = new Padding(6);
            Mota.Name = "Mota";
            Mota.Size = new Size(499, 43);
            Mota.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(88, 618);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(87, 37);
            label5.TabIndex = 11;
            label5.Text = "Mô tả";
            // 
            // them
            // 
            them.BackColor = Color.Green;
            them.Location = new Point(656, 712);
            them.Margin = new Padding(6);
            them.Name = "them";
            them.Size = new Size(182, 70);
            them.TabIndex = 10;
            them.Text = "Thêm";
            them.UseVisualStyleBackColor = false;
            them.Click += them_Click;
            // 
            // SL
            // 
            SL.Location = new Point(249, 512);
            SL.Margin = new Padding(6);
            SL.Name = "SL";
            SL.Size = new Size(499, 43);
            SL.TabIndex = 9;
            // 
            // email
            // 
            email.AutoSize = true;
            email.Location = new Point(47, 512);
            email.Margin = new Padding(6, 0, 6, 0);
            email.Name = "email";
            email.Size = new Size(124, 37);
            email.TabIndex = 8;
            email.Text = "Số lượng";
            // 
            // Theloai
            // 
            Theloai.Location = new Point(249, 403);
            Theloai.Margin = new Padding(6);
            Theloai.Name = "Theloai";
            Theloai.Size = new Size(499, 43);
            Theloai.TabIndex = 7;
            // 
            // sdt
            // 
            sdt.AutoSize = true;
            sdt.Location = new Point(47, 409);
            sdt.Margin = new Padding(6, 0, 6, 0);
            sdt.Name = "sdt";
            sdt.Size = new Size(117, 37);
            sdt.TabIndex = 6;
            sdt.Text = "Thể Loại";
            // 
            // Gia
            // 
            Gia.Location = new Point(249, 292);
            Gia.Margin = new Padding(6);
            Gia.Name = "Gia";
            Gia.Size = new Size(499, 43);
            Gia.TabIndex = 5;
            // 
            // pass
            // 
            pass.AutoSize = true;
            pass.Location = new Point(88, 292);
            pass.Margin = new Padding(6, 0, 6, 0);
            pass.Name = "pass";
            pass.Size = new Size(57, 37);
            pass.TabIndex = 4;
            pass.Text = "Giá";
            // 
            // TenBG
            // 
            TenBG.Location = new Point(249, 183);
            TenBG.Margin = new Padding(6);
            TenBG.Name = "TenBG";
            TenBG.Size = new Size(499, 43);
            TenBG.TabIndex = 3;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(26, 183);
            name.Margin = new Padding(6, 0, 6, 0);
            name.Name = "name";
            name.Size = new Size(204, 37);
            name.TabIndex = 2;
            name.Text = "Tên BoardGame";
            // 
            // MaBG
            // 
            MaBG.Location = new Point(249, 78);
            MaBG.Margin = new Padding(6);
            MaBG.Name = "MaBG";
            MaBG.Size = new Size(499, 43);
            MaBG.TabIndex = 1;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(26, 78);
            label.Margin = new Padding(6, 0, 6, 0);
            label.Name = "label";
            label.Size = new Size(202, 37);
            label.TabIndex = 0;
            label.Text = "Mã BoardGame";
            // 
            // delBG
            // 
            delBG.Controls.Add(label3);
            delBG.Controls.Add(label2);
            delBG.Controls.Add(panel1);
            delBG.Location = new Point(10, 55);
            delBG.Margin = new Padding(6);
            delBG.Name = "delBG";
            delBG.Padding = new Padding(6);
            delBG.Size = new Size(2311, 1313);
            delBG.TabIndex = 2;
            delBG.Text = "Xóa BoardGame";
            delBG.UseVisualStyleBackColor = true;
            // 
            // updateBG
            // 
            updateBG.Location = new Point(10, 55);
            updateBG.Margin = new Padding(6);
            updateBG.Name = "updateBG";
            updateBG.Padding = new Padding(6);
            updateBG.Size = new Size(2311, 1313);
            updateBG.TabIndex = 3;
            updateBG.Text = "Sửa BoardGame";
            updateBG.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.HotTrack;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Cornsilk;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(345, 72);
            label1.TabIndex = 13;
            label1.Text = "BoardGame";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.HotTrack;
            label3.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Cornsilk;
            label3.Location = new Point(0, 6);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(465, 72);
            label3.TabIndex = 10;
            label3.Text = "Xóa BoardGame";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(354, 300);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(773, 37);
            label2.TabIndex = 9;
            label2.Text = "Nhập Mã BoardGame cần xóa (Mã BoardGame là mã sản phẩm)";
            // 
            // panel1
            // 
            panel1.Controls.Add(delSp);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(masp);
            panel1.Location = new Point(354, 342);
            panel1.Margin = new Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1305, 548);
            panel1.TabIndex = 8;
            // 
            // delSp
            // 
            delSp.Location = new Point(731, 313);
            delSp.Margin = new Padding(6);
            delSp.Name = "delSp";
            delSp.Size = new Size(204, 87);
            delSp.TabIndex = 2;
            delSp.Text = "Xóa";
            delSp.UseVisualStyleBackColor = true;
            delSp.Click += delSp_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(109, 122);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(202, 37);
            label6.TabIndex = 0;
            label6.Text = "Mã BoardGame";
            // 
            // masp
            // 
            masp.Location = new Point(371, 122);
            masp.Margin = new Padding(6);
            masp.Name = "masp";
            masp.Size = new Size(561, 43);
            masp.TabIndex = 1;
            // 
            // ThongtinBoardGame
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2436, 1611);
            Controls.Add(tabControl1);
            Margin = new Padding(6);
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
            delBG.ResumeLayout(false);
            delBG.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Label label1;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Button delSp;
        private Label label6;
        private TextBox masp;
    }
}