namespace WinFormsDemo
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
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            delSp = new Button();
            label1 = new Label();
            masp = new TextBox();
            updateBG = new TabPage();
            label13 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            Mota1 = new TextBox();
            label7 = new Label();
            suaBG = new Button();
            SL1 = new TextBox();
            label8 = new Label();
            Theloai1 = new TextBox();
            label9 = new Label();
            Gia1 = new TextBox();
            label10 = new Label();
            TenBG1 = new TextBox();
            label11 = new Label();
            MaBG1 = new TextBox();
            label12 = new Label();
            label14 = new Label();
            TTBoardGame = new DataGridView();
            tabControl1.SuspendLayout();
            TTSP.SuspendLayout();
            addBG.SuspendLayout();
            AddAdmin.SuspendLayout();
            delBG.SuspendLayout();
            panel1.SuspendLayout();
            updateBG.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TTBoardGame).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(TTSP);
            tabControl1.Controls.Add(addBG);
            tabControl1.Controls.Add(delBG);
            tabControl1.Controls.Add(updateBG);
            tabControl1.Location = new Point(-1, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1243, 745);
            tabControl1.TabIndex = 4;
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
            addBG.Click += addBG_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.HotTrack;
            label4.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.Cornsilk;
            label4.Location = new Point(3, 3);
            label4.Name = "label4";
            label4.Size = new Size(283, 41);
            label4.TabIndex = 10;
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
            AddAdmin.Location = new Point(196, 103);
            AddAdmin.Name = "AddAdmin";
            AddAdmin.Size = new Size(636, 443);
            AddAdmin.TabIndex = 9;
            AddAdmin.Paint += AddAdmin_Paint;
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
            // delBG
            // 
            delBG.Controls.Add(label3);
            delBG.Controls.Add(label2);
            delBG.Controls.Add(panel1);
            delBG.Location = new Point(4, 29);
            delBG.Name = "delBG";
            delBG.Padding = new Padding(3);
            delBG.Size = new Size(1235, 712);
            delBG.TabIndex = 2;
            delBG.Text = "Xóa BoardGame";
            delBG.UseVisualStyleBackColor = true;
            delBG.Click += delBG_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.HotTrack;
            label3.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Cornsilk;
            label3.Location = new Point(3, 3);
            label3.Name = "label3";
            label3.Size = new Size(259, 41);
            label3.TabIndex = 7;
            label3.Text = "Xóa BoardGame";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(192, 162);
            label2.Name = "label2";
            label2.Size = new Size(435, 20);
            label2.TabIndex = 4;
            label2.Text = "Nhập Mã BoardGame cần xóa (Mã BoardGame là mã sản phẩm)";
            // 
            // panel1
            // 
            panel1.Controls.Add(delSp);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(masp);
            panel1.Location = new Point(192, 185);
            panel1.Name = "panel1";
            panel1.Size = new Size(696, 296);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // delSp
            // 
            delSp.Location = new Point(390, 169);
            delSp.Name = "delSp";
            delSp.Size = new Size(109, 47);
            delSp.TabIndex = 2;
            delSp.Text = "Xóa";
            delSp.UseVisualStyleBackColor = true;
            delSp.Click += delSp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 66);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã BoardGame";
            // 
            // masp
            // 
            masp.Location = new Point(198, 66);
            masp.Name = "masp";
            masp.Size = new Size(301, 27);
            masp.TabIndex = 1;
            // 
            // updateBG
            // 
            updateBG.Controls.Add(label13);
            updateBG.Controls.Add(label6);
            updateBG.Controls.Add(panel2);
            updateBG.Location = new Point(4, 29);
            updateBG.Name = "updateBG";
            updateBG.Padding = new Padding(3);
            updateBG.Size = new Size(1235, 712);
            updateBG.TabIndex = 3;
            updateBG.Text = "Sửa BoardGame";
            updateBG.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(46, 80);
            label13.Name = "label13";
            label13.Size = new Size(786, 20);
            label13.TabIndex = 13;
            label13.Text = "Nhập đầy đủ các thông tin cần sửa, những thông tin không sửa vui lòng nhập như cũ (Mã BoardGame không thay đổi)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.HotTrack;
            label6.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.Cornsilk;
            label6.Location = new Point(3, 3);
            label6.Name = "label6";
            label6.Size = new Size(257, 41);
            label6.TabIndex = 12;
            label6.Text = "Sửa BoardGame";
            // 
            // panel2
            // 
            panel2.Controls.Add(Mota1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(suaBG);
            panel2.Controls.Add(SL1);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(Theloai1);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(Gia1);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(TenBG1);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(MaBG1);
            panel2.Controls.Add(label12);
            panel2.Location = new Point(196, 103);
            panel2.Name = "panel2";
            panel2.Size = new Size(636, 443);
            panel2.TabIndex = 11;
            // 
            // Mota1
            // 
            Mota1.Location = new Point(133, 334);
            Mota1.Name = "Mota1";
            Mota1.Size = new Size(268, 27);
            Mota1.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(47, 334);
            label7.Name = "label7";
            label7.Size = new Size(48, 20);
            label7.TabIndex = 11;
            label7.Text = "Mô tả";
            // 
            // suaBG
            // 
            suaBG.BackColor = Color.Green;
            suaBG.Location = new Point(350, 385);
            suaBG.Name = "suaBG";
            suaBG.Size = new Size(97, 38);
            suaBG.TabIndex = 10;
            suaBG.Text = "Sửa";
            suaBG.UseVisualStyleBackColor = false;
            suaBG.Click += suaBG_Click;
            // 
            // SL1
            // 
            SL1.Location = new Point(133, 277);
            SL1.Name = "SL1";
            SL1.Size = new Size(268, 27);
            SL1.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 277);
            label8.Name = "label8";
            label8.Size = new Size(69, 20);
            label8.TabIndex = 8;
            label8.Text = "Số lượng";
            // 
            // Theloai1
            // 
            Theloai1.Location = new Point(133, 218);
            Theloai1.Name = "Theloai1";
            Theloai1.Size = new Size(268, 27);
            Theloai1.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(25, 221);
            label9.Name = "label9";
            label9.Size = new Size(65, 20);
            label9.TabIndex = 6;
            label9.Text = "Thể Loại";
            // 
            // Gia1
            // 
            Gia1.Location = new Point(133, 158);
            Gia1.Name = "Gia1";
            Gia1.Size = new Size(268, 27);
            Gia1.TabIndex = 5;
            Gia1.TextChanged += textBox4_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(47, 158);
            label10.Name = "label10";
            label10.Size = new Size(31, 20);
            label10.TabIndex = 4;
            label10.Text = "Giá";
            // 
            // TenBG1
            // 
            TenBG1.Location = new Point(133, 99);
            TenBG1.Name = "TenBG1";
            TenBG1.Size = new Size(268, 27);
            TenBG1.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(14, 99);
            label11.Name = "label11";
            label11.Size = new Size(115, 20);
            label11.TabIndex = 2;
            label11.Text = "Tên BoardGame";
            // 
            // MaBG1
            // 
            MaBG1.Location = new Point(133, 42);
            MaBG1.Name = "MaBG1";
            MaBG1.Size = new Size(268, 27);
            MaBG1.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(14, 42);
            label12.Name = "label12";
            label12.Size = new Size(113, 20);
            label12.TabIndex = 0;
            label12.Text = "Mã BoardGame";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = SystemColors.HotTrack;
            label14.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label14.ForeColor = Color.Cornsilk;
            label14.Location = new Point(6, 3);
            label14.Name = "label14";
            label14.Size = new Size(350, 41);
            label14.TabIndex = 9;
            label14.Text = "Thông Tin BoardGame";
            label14.Click += label14_Click;
            // 
            // TTBoardGame
            // 
            TTBoardGame.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            TTBoardGame.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            TTBoardGame.BackgroundColor = SystemColors.ButtonHighlight;
            TTBoardGame.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TTBoardGame.Location = new Point(129, 74);
            TTBoardGame.Name = "TTBoardGame";
            TTBoardGame.ReadOnly = true;
            TTBoardGame.RowHeadersWidth = 51;
            TTBoardGame.RowTemplate.Height = 29;
            TTBoardGame.Size = new Size(791, 491);
            TTBoardGame.TabIndex = 8;
            TTBoardGame.CellContentClick += TTAdmin_CellContentClick;
            // 
            // ThongtinBoardGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 749);
            Controls.Add(tabControl1);
            Name = "ThongtinBoardGame";
            Text = "XoaSP";
            tabControl1.ResumeLayout(false);
            TTSP.ResumeLayout(false);
            TTSP.PerformLayout();
            addBG.ResumeLayout(false);
            addBG.PerformLayout();
            AddAdmin.ResumeLayout(false);
            AddAdmin.PerformLayout();
            delBG.ResumeLayout(false);
            delBG.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            updateBG.ResumeLayout(false);
            updateBG.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TTBoardGame).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage TTSP;
        private TabPage addBG;
        private TabPage delBG;
        private TabPage updateBG;
        private Panel panel1;
        private Button delSp;
        private Label label1;
        private TextBox masp;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel AddAdmin;
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
        private TextBox Mota;
        private Label label5;
        private Label label6;
        private Panel panel2;
        private TextBox Mota1;
        private Label label7;
        private Button suaBG;
        private TextBox SL1;
        private Label label8;
        private TextBox Theloai1;
        private Label label9;
        private TextBox Gia1;
        private Label label10;
        private TextBox TenBG1;
        private Label label11;
        private TextBox MaBG1;
        private Label label12;
        private Label label13;
        private Label label14;
        public DataGridView TTBoardGame;
    }
}