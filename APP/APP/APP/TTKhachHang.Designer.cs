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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TTKhachHang));
            this.TTKH = new System.Windows.Forms.TabControl();
            this.TTSP = new System.Windows.Forms.TabPage();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TTCustomers = new System.Windows.Forms.DataGridView();
            this.addKH = new System.Windows.Forms.TabPage();
            this.AddAdmin = new System.Windows.Forms.Panel();
            this.them = new System.Windows.Forms.Button();
            this.tkemail = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.sodienthoai = new System.Windows.Forms.TextBox();
            this.sdt = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.Label();
            this.hovaten = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.uname = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.delKH = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.delSp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tentk = new System.Windows.Forms.TextBox();
            this.updateKH = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tkmail = new System.Windows.Forms.TextBox();
            this.suaBG = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.phonenb = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.matkhau = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.hovten = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.account = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TTKH.SuspendLayout();
            this.TTSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TTCustomers)).BeginInit();
            this.addKH.SuspendLayout();
            this.AddAdmin.SuspendLayout();
            this.delKH.SuspendLayout();
            this.panel1.SuspendLayout();
            this.updateKH.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TTKH
            // 
            this.TTKH.Controls.Add(this.TTSP);
            this.TTKH.Controls.Add(this.addKH);
            this.TTKH.Controls.Add(this.delKH);
            this.TTKH.Controls.Add(this.updateKH);
            this.TTKH.Location = new System.Drawing.Point(1, 1);
            this.TTKH.Name = "TTKH";
            this.TTKH.SelectedIndex = 0;
            this.TTKH.Size = new System.Drawing.Size(1243, 745);
            this.TTKH.TabIndex = 6;
            // 
            // TTSP
            // 
            this.TTSP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TTSP.BackgroundImage")));
            this.TTSP.Controls.Add(this.searchButton);
            this.TTSP.Controls.Add(this.searchBar);
            this.TTSP.Controls.Add(this.label14);
            this.TTSP.Controls.Add(this.TTCustomers);
            this.TTSP.Location = new System.Drawing.Point(4, 29);
            this.TTSP.Name = "TTSP";
            this.TTSP.Padding = new System.Windows.Forms.Padding(3);
            this.TTSP.Size = new System.Drawing.Size(1235, 712);
            this.TTSP.TabIndex = 0;
            this.TTSP.Text = "Thông tin khách hàng";
            this.TTSP.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.LightBlue;
            this.searchButton.Location = new System.Drawing.Point(865, 607);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(94, 50);
            this.searchButton.TabIndex = 11;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // searchBar
            // 
            this.searchBar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBar.Location = new System.Drawing.Point(257, 615);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(488, 31);
            this.searchBar.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Segoe UI Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.Cornsilk;
            this.label14.Location = new System.Drawing.Point(36, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(405, 51);
            this.label14.TabIndex = 9;
            this.label14.Text = "Thông Tin Khách hàng";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // TTCustomers
            // 
            this.TTCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TTCustomers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TTCustomers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TTCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TTCustomers.Location = new System.Drawing.Point(36, 73);
            this.TTCustomers.Name = "TTCustomers";
            this.TTCustomers.ReadOnly = true;
            this.TTCustomers.RowHeadersWidth = 51;
            this.TTCustomers.RowTemplate.Height = 29;
            this.TTCustomers.Size = new System.Drawing.Size(1158, 491);
            this.TTCustomers.TabIndex = 8;
            // 
            // addKH
            // 
            this.addKH.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addKH.BackgroundImage")));
            this.addKH.Controls.Add(this.AddAdmin);
            this.addKH.Controls.Add(this.label4);
            this.addKH.Location = new System.Drawing.Point(4, 29);
            this.addKH.Name = "addKH";
            this.addKH.Padding = new System.Windows.Forms.Padding(3);
            this.addKH.Size = new System.Drawing.Size(1235, 712);
            this.addKH.TabIndex = 1;
            this.addKH.Text = "Thêm Khách hàng";
            this.addKH.UseVisualStyleBackColor = true;
            this.addKH.Click += new System.EventHandler(this.addKH_Click);
            // 
            // AddAdmin
            // 
            this.AddAdmin.Controls.Add(this.them);
            this.AddAdmin.Controls.Add(this.tkemail);
            this.AddAdmin.Controls.Add(this.email);
            this.AddAdmin.Controls.Add(this.sodienthoai);
            this.AddAdmin.Controls.Add(this.sdt);
            this.AddAdmin.Controls.Add(this.password);
            this.AddAdmin.Controls.Add(this.pass);
            this.AddAdmin.Controls.Add(this.hovaten);
            this.AddAdmin.Controls.Add(this.name);
            this.AddAdmin.Controls.Add(this.username);
            this.AddAdmin.Controls.Add(this.uname);
            this.AddAdmin.Location = new System.Drawing.Point(238, 112);
            this.AddAdmin.Name = "AddAdmin";
            this.AddAdmin.Size = new System.Drawing.Size(636, 443);
            this.AddAdmin.TabIndex = 13;
            // 
            // them
            // 
            this.them.BackColor = System.Drawing.Color.Green;
            this.them.Location = new System.Drawing.Point(346, 351);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(97, 38);
            this.them.TabIndex = 10;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = false;
            // 
            // tkemail
            // 
            this.tkemail.Location = new System.Drawing.Point(133, 277);
            this.tkemail.Name = "tkemail";
            this.tkemail.Size = new System.Drawing.Size(268, 27);
            this.tkemail.TabIndex = 9;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(60, 277);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(46, 20);
            this.email.TabIndex = 8;
            this.email.Text = "Email";
            // 
            // sodienthoai
            // 
            this.sodienthoai.Location = new System.Drawing.Point(133, 218);
            this.sodienthoai.Name = "sodienthoai";
            this.sodienthoai.Size = new System.Drawing.Size(268, 27);
            this.sodienthoai.TabIndex = 7;
            // 
            // sdt
            // 
            this.sdt.AutoSize = true;
            this.sdt.Location = new System.Drawing.Point(13, 218);
            this.sdt.Name = "sdt";
            this.sdt.Size = new System.Drawing.Size(97, 20);
            this.sdt.TabIndex = 6;
            this.sdt.Text = "Số điện thoại";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(133, 158);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(268, 27);
            this.password.TabIndex = 5;
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Location = new System.Drawing.Point(32, 158);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(70, 20);
            this.pass.TabIndex = 4;
            this.pass.Text = "mật khẩu";
            // 
            // hovaten
            // 
            this.hovaten.Location = new System.Drawing.Point(133, 99);
            this.hovaten.Name = "hovaten";
            this.hovaten.Size = new System.Drawing.Size(268, 27);
            this.hovaten.TabIndex = 3;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(32, 99);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(73, 20);
            this.name.TabIndex = 2;
            this.name.Text = "Họ và tên";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(133, 42);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(268, 27);
            this.username.TabIndex = 1;
            // 
            // uname
            // 
            this.uname.AutoSize = true;
            this.uname.Location = new System.Drawing.Point(32, 42);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(78, 20);
            this.uname.TabIndex = 0;
            this.uname.Text = "UserName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Cornsilk;
            this.label4.Location = new System.Drawing.Point(238, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(436, 41);
            this.label4.TabIndex = 12;
            this.label4.Text = "Thêm Tài khoản khách hàng";
            // 
            // delKH
            // 
            this.delKH.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delKH.BackgroundImage")));
            this.delKH.Controls.Add(this.label5);
            this.delKH.Controls.Add(this.label3);
            this.delKH.Controls.Add(this.panel1);
            this.delKH.Location = new System.Drawing.Point(4, 29);
            this.delKH.Name = "delKH";
            this.delKH.Padding = new System.Windows.Forms.Padding(3);
            this.delKH.Size = new System.Drawing.Size(1235, 712);
            this.delKH.TabIndex = 2;
            this.delKH.Text = "Xóa Khách hàng";
            this.delKH.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(186, 481);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nhập tên Username để xóa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(186, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(412, 41);
            this.label3.TabIndex = 13;
            this.label3.Text = "Xóa Tài khoản khách hàng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.delSp);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tentk);
            this.panel1.Location = new System.Drawing.Point(186, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 296);
            this.panel1.TabIndex = 12;
            // 
            // delSp
            // 
            this.delSp.Location = new System.Drawing.Point(390, 169);
            this.delSp.Name = "delSp";
            this.delSp.Size = new System.Drawing.Size(109, 47);
            this.delSp.TabIndex = 2;
            this.delSp.Text = "Xóa";
            this.delSp.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(58, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName";
            // 
            // tentk
            // 
            this.tentk.Location = new System.Drawing.Point(198, 66);
            this.tentk.Name = "tentk";
            this.tentk.Size = new System.Drawing.Size(301, 27);
            this.tentk.TabIndex = 1;
            // 
            // updateKH
            // 
            this.updateKH.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateKH.BackgroundImage")));
            this.updateKH.Controls.Add(this.panel3);
            this.updateKH.Controls.Add(this.label13);
            this.updateKH.Controls.Add(this.label6);
            this.updateKH.Location = new System.Drawing.Point(4, 29);
            this.updateKH.Name = "updateKH";
            this.updateKH.Padding = new System.Windows.Forms.Padding(3);
            this.updateKH.Size = new System.Drawing.Size(1235, 712);
            this.updateKH.TabIndex = 3;
            this.updateKH.Text = "Sửa Thông tin khách hàng";
            this.updateKH.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tkmail);
            this.panel3.Controls.Add(this.suaBG);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.phonenb);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.matkhau);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.hovten);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.account);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Location = new System.Drawing.Point(286, 119);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(636, 443);
            this.panel3.TabIndex = 17;
            // 
            // tkmail
            // 
            this.tkmail.Location = new System.Drawing.Point(133, 277);
            this.tkmail.Name = "tkmail";
            this.tkmail.Size = new System.Drawing.Size(268, 27);
            this.tkmail.TabIndex = 9;
            // 
            // suaBG
            // 
            this.suaBG.BackColor = System.Drawing.Color.Green;
            this.suaBG.Location = new System.Drawing.Point(304, 356);
            this.suaBG.Name = "suaBG";
            this.suaBG.Size = new System.Drawing.Size(97, 38);
            this.suaBG.TabIndex = 10;
            this.suaBG.Text = "Sửa";
            this.suaBG.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Email";
            // 
            // phonenb
            // 
            this.phonenb.Location = new System.Drawing.Point(133, 218);
            this.phonenb.Name = "phonenb";
            this.phonenb.Size = new System.Drawing.Size(268, 27);
            this.phonenb.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 218);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 20);
            this.label15.TabIndex = 6;
            this.label15.Text = "Số điện thoại";
            // 
            // matkhau
            // 
            this.matkhau.Location = new System.Drawing.Point(133, 158);
            this.matkhau.Name = "matkhau";
            this.matkhau.Size = new System.Drawing.Size(268, 27);
            this.matkhau.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(32, 158);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 20);
            this.label16.TabIndex = 4;
            this.label16.Text = "mật khẩu";
            // 
            // hovten
            // 
            this.hovten.Location = new System.Drawing.Point(133, 99);
            this.hovten.Name = "hovten";
            this.hovten.Size = new System.Drawing.Size(268, 27);
            this.hovten.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(32, 99);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 20);
            this.label17.TabIndex = 2;
            this.label17.Text = "Họ và tên";
            // 
            // account
            // 
            this.account.Location = new System.Drawing.Point(133, 42);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(268, 27);
            this.account.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(32, 42);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 20);
            this.label18.TabIndex = 0;
            this.label18.Text = "UserName";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(286, 565);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(751, 20);
            this.label13.TabIndex = 16;
            this.label13.Text = "Nhập đầy đủ các thông tin cần sửa, những thông tin không sửa vui lòng nhập như cũ" +
    " (UserName không thay đổi)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Cornsilk;
            this.label6.Location = new System.Drawing.Point(286, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(401, 41);
            this.label6.TabIndex = 15;
            this.label6.Text = "Sửa thông tin Khách hàng\r\n";
            // 
            // TTKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 778);
            this.Controls.Add(this.TTKH);
            this.Name = "TTKhachHang";
            this.Text = "TTKhachHang";
            this.TTKH.ResumeLayout(false);
            this.TTSP.ResumeLayout(false);
            this.TTSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TTCustomers)).EndInit();
            this.addKH.ResumeLayout(false);
            this.addKH.PerformLayout();
            this.AddAdmin.ResumeLayout(false);
            this.AddAdmin.PerformLayout();
            this.delKH.ResumeLayout(false);
            this.delKH.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.updateKH.ResumeLayout(false);
            this.updateKH.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl TTKH;
        private TabPage TTSP;
        private Label label14;
        public DataGridView TTCustomers;
        private TabPage addKH;
        private TabPage delKH;
        private TabPage updateKH;
        private Panel AddAdmin;
        private Button them;
        private TextBox tkemail;
        private Label email;
        private TextBox sodienthoai;
        private Label sdt;
        private TextBox password;
        private Label pass;
        private TextBox hovaten;
        private Label name;
        private TextBox username;
        private Label uname;
        private Label label4;
        private Panel panel3;
        private TextBox tkmail;
        private Button suaBG;
        private Label label2;
        private TextBox phonenb;
        private Label label15;
        private TextBox matkhau;
        private Label label16;
        private TextBox hovten;
        private Label label17;
        private TextBox account;
        private Label label18;
        private Label label13;
        private Label label6;
        private Label label5;
        private Label label3;
        private Panel panel1;
        private Button delSp;
        private Label label1;
        private TextBox tentk;
        private Button searchButton;
        private TextBox searchBar;
    }
}