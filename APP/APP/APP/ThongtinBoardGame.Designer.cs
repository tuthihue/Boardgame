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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongtinBoardGame));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TTSP = new System.Windows.Forms.TabPage();
            this.refreshButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TTBoardGame = new System.Windows.Forms.DataGridView();
            this.addBG = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.AddAdmin = new System.Windows.Forms.Panel();
            this.Mota = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.them = new System.Windows.Forms.Button();
            this.SL = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.Theloai = new System.Windows.Forms.TextBox();
            this.sdt = new System.Windows.Forms.Label();
            this.Gia = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.Label();
            this.TenBG = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.MaBG = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.delBG = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.delSp = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.masp = new System.Windows.Forms.TextBox();
            this.updateBG = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Mota1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.suaBG = new System.Windows.Forms.Button();
            this.SL1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Theloai1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Gia1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TenBG1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.MaBG1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.TTSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TTBoardGame)).BeginInit();
            this.addBG.SuspendLayout();
            this.AddAdmin.SuspendLayout();
            this.delBG.SuspendLayout();
            this.panel1.SuspendLayout();
            this.updateBG.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TTSP);
            this.tabControl1.Controls.Add(this.addBG);
            this.tabControl1.Controls.Add(this.delBG);
            this.tabControl1.Controls.Add(this.updateBG);
            this.tabControl1.Location = new System.Drawing.Point(1, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1243, 741);
            this.tabControl1.TabIndex = 5;
            // 
            // TTSP
            // 
            this.TTSP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TTSP.BackgroundImage")));
            this.TTSP.Controls.Add(this.refreshButton);
            this.TTSP.Controls.Add(this.searchButton);
            this.TTSP.Controls.Add(this.searchBar);
            this.TTSP.Controls.Add(this.label1);
            this.TTSP.Controls.Add(this.label14);
            this.TTSP.Controls.Add(this.TTBoardGame);
            this.TTSP.Location = new System.Drawing.Point(4, 29);
            this.TTSP.Name = "TTSP";
            this.TTSP.Padding = new System.Windows.Forms.Padding(3);
            this.TTSP.Size = new System.Drawing.Size(1235, 708);
            this.TTSP.TabIndex = 0;
            this.TTSP.Text = "Thông tin BoardGame";
            this.TTSP.UseVisualStyleBackColor = true;
            this.TTSP.Click += new System.EventHandler(this.TTSP_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.LightBlue;
            this.refreshButton.Location = new System.Drawing.Point(1059, 632);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(94, 53);
            this.refreshButton.TabIndex = 16;
            this.refreshButton.Text = "Làm mới";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.LightBlue;
            this.searchButton.Location = new System.Drawing.Point(866, 635);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(94, 50);
            this.searchButton.TabIndex = 15;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchBar
            // 
            this.searchBar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBar.Location = new System.Drawing.Point(247, 643);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(541, 31);
            this.searchBar.TabIndex = 14;
            this.searchBar.Text = "Hãy nhập thông tin BoardGame cần tìm";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(13, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 46);
            this.label1.TabIndex = 13;
            this.label1.Text = "BoardGame";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(0, 0);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 0;
            // 
            // TTBoardGame
            // 
            this.TTBoardGame.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TTBoardGame.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TTBoardGame.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TTBoardGame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TTBoardGame.Location = new System.Drawing.Point(13, 95);
            this.TTBoardGame.Name = "TTBoardGame";
            this.TTBoardGame.ReadOnly = true;
            this.TTBoardGame.RowHeadersWidth = 51;
            this.TTBoardGame.RowTemplate.Height = 29;
            this.TTBoardGame.Size = new System.Drawing.Size(1206, 511);
            this.TTBoardGame.TabIndex = 8;
            // 
            // addBG
            // 
            this.addBG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addBG.BackgroundImage")));
            this.addBG.Controls.Add(this.label4);
            this.addBG.Controls.Add(this.AddAdmin);
            this.addBG.Location = new System.Drawing.Point(4, 29);
            this.addBG.Name = "addBG";
            this.addBG.Padding = new System.Windows.Forms.Padding(3);
            this.addBG.Size = new System.Drawing.Size(1235, 708);
            this.addBG.TabIndex = 1;
            this.addBG.Text = "Thêm BoardGame";
            this.addBG.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Cyan;
            this.label4.Location = new System.Drawing.Point(193, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 41);
            this.label4.TabIndex = 12;
            this.label4.Text = "Thêm BoardGame";
            // 
            // AddAdmin
            // 
            this.AddAdmin.Controls.Add(this.Mota);
            this.AddAdmin.Controls.Add(this.label5);
            this.AddAdmin.Controls.Add(this.them);
            this.AddAdmin.Controls.Add(this.SL);
            this.AddAdmin.Controls.Add(this.email);
            this.AddAdmin.Controls.Add(this.Theloai);
            this.AddAdmin.Controls.Add(this.sdt);
            this.AddAdmin.Controls.Add(this.Gia);
            this.AddAdmin.Controls.Add(this.pass);
            this.AddAdmin.Controls.Add(this.TenBG);
            this.AddAdmin.Controls.Add(this.name);
            this.AddAdmin.Controls.Add(this.MaBG);
            this.AddAdmin.Controls.Add(this.label);
            this.AddAdmin.Location = new System.Drawing.Point(193, 103);
            this.AddAdmin.Name = "AddAdmin";
            this.AddAdmin.Size = new System.Drawing.Size(636, 443);
            this.AddAdmin.TabIndex = 11;
            // 
            // Mota
            // 
            this.Mota.Location = new System.Drawing.Point(133, 334);
            this.Mota.Name = "Mota";
            this.Mota.Size = new System.Drawing.Size(268, 27);
            this.Mota.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label5.Location = new System.Drawing.Point(47, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mô tả";
            // 
            // them
            // 
            this.them.BackColor = System.Drawing.Color.Green;
            this.them.Location = new System.Drawing.Point(350, 385);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(97, 38);
            this.them.TabIndex = 10;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = false;
            // 
            // SL
            // 
            this.SL.Location = new System.Drawing.Point(133, 277);
            this.SL.Name = "SL";
            this.SL.Size = new System.Drawing.Size(268, 27);
            this.SL.TabIndex = 9;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.email.Location = new System.Drawing.Point(25, 277);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(69, 20);
            this.email.TabIndex = 8;
            this.email.Text = "Số lượng";
            // 
            // Theloai
            // 
            this.Theloai.Location = new System.Drawing.Point(133, 218);
            this.Theloai.Name = "Theloai";
            this.Theloai.Size = new System.Drawing.Size(268, 27);
            this.Theloai.TabIndex = 7;
            // 
            // sdt
            // 
            this.sdt.AutoSize = true;
            this.sdt.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.sdt.Location = new System.Drawing.Point(25, 221);
            this.sdt.Name = "sdt";
            this.sdt.Size = new System.Drawing.Size(65, 20);
            this.sdt.TabIndex = 6;
            this.sdt.Text = "Thể Loại";
            // 
            // Gia
            // 
            this.Gia.Location = new System.Drawing.Point(133, 158);
            this.Gia.Name = "Gia";
            this.Gia.Size = new System.Drawing.Size(268, 27);
            this.Gia.TabIndex = 5;
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.pass.Location = new System.Drawing.Point(47, 158);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(31, 20);
            this.pass.TabIndex = 4;
            this.pass.Text = "Giá";
            // 
            // TenBG
            // 
            this.TenBG.Location = new System.Drawing.Point(133, 99);
            this.TenBG.Name = "TenBG";
            this.TenBG.Size = new System.Drawing.Size(268, 27);
            this.TenBG.TabIndex = 3;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.name.Location = new System.Drawing.Point(14, 99);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(115, 20);
            this.name.TabIndex = 2;
            this.name.Text = "Tên BoardGame";
            // 
            // MaBG
            // 
            this.MaBG.Location = new System.Drawing.Point(133, 42);
            this.MaBG.Name = "MaBG";
            this.MaBG.Size = new System.Drawing.Size(268, 27);
            this.MaBG.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label.Location = new System.Drawing.Point(14, 42);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(113, 20);
            this.label.TabIndex = 0;
            this.label.Text = "Mã BoardGame";
            // 
            // delBG
            // 
            this.delBG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delBG.BackgroundImage")));
            this.delBG.Controls.Add(this.label3);
            this.delBG.Controls.Add(this.label2);
            this.delBG.Controls.Add(this.panel1);
            this.delBG.Location = new System.Drawing.Point(4, 29);
            this.delBG.Name = "delBG";
            this.delBG.Padding = new System.Windows.Forms.Padding(3);
            this.delBG.Size = new System.Drawing.Size(1235, 708);
            this.delBG.TabIndex = 2;
            this.delBG.Text = "Xóa BoardGame";
            this.delBG.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(189, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 41);
            this.label3.TabIndex = 10;
            this.label3.Text = "Xóa BoardGame";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Turquoise;
            this.label2.Location = new System.Drawing.Point(189, 484);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(435, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nhập Mã BoardGame cần xóa (Mã BoardGame là mã sản phẩm)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.delSp);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.masp);
            this.panel1.Location = new System.Drawing.Point(189, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 296);
            this.panel1.TabIndex = 8;
            // 
            // delSp
            // 
            this.delSp.BackColor = System.Drawing.Color.LightBlue;
            this.delSp.Location = new System.Drawing.Point(390, 169);
            this.delSp.Name = "delSp";
            this.delSp.Size = new System.Drawing.Size(109, 47);
            this.delSp.TabIndex = 2;
            this.delSp.Text = "Xóa";
            this.delSp.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Turquoise;
            this.label6.Location = new System.Drawing.Point(58, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã BoardGame";
            // 
            // masp
            // 
            this.masp.Location = new System.Drawing.Point(198, 66);
            this.masp.Name = "masp";
            this.masp.Size = new System.Drawing.Size(301, 27);
            this.masp.TabIndex = 1;
            // 
            // updateBG
            // 
            this.updateBG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateBG.BackgroundImage")));
            this.updateBG.Controls.Add(this.label13);
            this.updateBG.Controls.Add(this.label7);
            this.updateBG.Controls.Add(this.panel2);
            this.updateBG.Location = new System.Drawing.Point(4, 29);
            this.updateBG.Name = "updateBG";
            this.updateBG.Padding = new System.Windows.Forms.Padding(3);
            this.updateBG.Size = new System.Drawing.Size(1235, 708);
            this.updateBG.TabIndex = 3;
            this.updateBG.Text = "Sửa BoardGame";
            this.updateBG.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.DarkCyan;
            this.label13.Location = new System.Drawing.Point(193, 549);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(786, 20);
            this.label13.TabIndex = 16;
            this.label13.Text = "Nhập đầy đủ các thông tin cần sửa, những thông tin không sửa vui lòng nhập như cũ" +
    " (Mã BoardGame không thay đổi)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.PaleGreen;
            this.label7.Location = new System.Drawing.Point(193, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(257, 41);
            this.label7.TabIndex = 15;
            this.label7.Text = "Sửa BoardGame";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Mota1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.suaBG);
            this.panel2.Controls.Add(this.SL1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.Theloai1);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.Gia1);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.TenBG1);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.MaBG1);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Location = new System.Drawing.Point(193, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(636, 443);
            this.panel2.TabIndex = 14;
            // 
            // Mota1
            // 
            this.Mota1.Location = new System.Drawing.Point(133, 334);
            this.Mota1.Name = "Mota1";
            this.Mota1.Size = new System.Drawing.Size(268, 27);
            this.Mota1.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkCyan;
            this.label8.Location = new System.Drawing.Point(47, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Mô tả";
            // 
            // suaBG
            // 
            this.suaBG.BackColor = System.Drawing.Color.Green;
            this.suaBG.Location = new System.Drawing.Point(350, 385);
            this.suaBG.Name = "suaBG";
            this.suaBG.Size = new System.Drawing.Size(97, 38);
            this.suaBG.TabIndex = 10;
            this.suaBG.Text = "Sửa";
            this.suaBG.UseVisualStyleBackColor = false;
            // 
            // SL1
            // 
            this.SL1.Location = new System.Drawing.Point(133, 277);
            this.SL1.Name = "SL1";
            this.SL1.Size = new System.Drawing.Size(268, 27);
            this.SL1.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DarkCyan;
            this.label9.Location = new System.Drawing.Point(25, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Số lượng";
            // 
            // Theloai1
            // 
            this.Theloai1.Location = new System.Drawing.Point(133, 218);
            this.Theloai1.Name = "Theloai1";
            this.Theloai1.Size = new System.Drawing.Size(268, 27);
            this.Theloai1.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DarkCyan;
            this.label10.Location = new System.Drawing.Point(25, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Thể Loại";
            // 
            // Gia1
            // 
            this.Gia1.Location = new System.Drawing.Point(133, 158);
            this.Gia1.Name = "Gia1";
            this.Gia1.Size = new System.Drawing.Size(268, 27);
            this.Gia1.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.DarkCyan;
            this.label11.Location = new System.Drawing.Point(47, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "Giá";
            // 
            // TenBG1
            // 
            this.TenBG1.Location = new System.Drawing.Point(133, 99);
            this.TenBG1.Name = "TenBG1";
            this.TenBG1.Size = new System.Drawing.Size(268, 27);
            this.TenBG1.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.DarkCyan;
            this.label12.Location = new System.Drawing.Point(14, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Tên BoardGame";
            // 
            // MaBG1
            // 
            this.MaBG1.Location = new System.Drawing.Point(133, 42);
            this.MaBG1.Name = "MaBG1";
            this.MaBG1.Size = new System.Drawing.Size(268, 27);
            this.MaBG1.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.DarkCyan;
            this.label15.Location = new System.Drawing.Point(14, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "Mã BoardGame";
            // 
            // ThongtinBoardGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 755);
            this.Controls.Add(this.tabControl1);
            this.Name = "ThongtinBoardGame";
            this.Text = "ThongtinBoardGame";
            this.tabControl1.ResumeLayout(false);
            this.TTSP.ResumeLayout(false);
            this.TTSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TTBoardGame)).EndInit();
            this.addBG.ResumeLayout(false);
            this.addBG.PerformLayout();
            this.AddAdmin.ResumeLayout(false);
            this.AddAdmin.PerformLayout();
            this.delBG.ResumeLayout(false);
            this.delBG.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.updateBG.ResumeLayout(false);
            this.updateBG.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

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
        private Label label13;
        private Label label7;
        private Panel panel2;
        private TextBox Mota1;
        private Label label8;
        private Button suaBG;
        private TextBox SL1;
        private Label label9;
        private TextBox Theloai1;
        private Label label10;
        private TextBox Gia1;
        private Label label11;
        private TextBox TenBG1;
        private Label label12;
        private TextBox MaBG1;
        private Label label15;
        private Button searchButton;
        private TextBox searchBar;
        private Button refreshButton;
    }
}