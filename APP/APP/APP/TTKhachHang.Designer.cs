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
            AddAdmin = new Panel();
            them = new Button();
            tkemail = new TextBox();
            email = new Label();
            sodienthoai = new TextBox();
            sdt = new Label();
            password = new TextBox();
            pass = new Label();
            hovaten = new TextBox();
            name = new Label();
            username = new TextBox();
            uname = new Label();
            label4 = new Label();
            delKH = new TabPage();
            updateKH = new TabPage();
            panel3 = new Panel();
            tkmail = new TextBox();
            suaBG = new Button();
            label2 = new Label();
            phonenb = new TextBox();
            label15 = new Label();
            matkhau = new TextBox();
            label16 = new Label();
            hovten = new TextBox();
            label17 = new Label();
            account = new TextBox();
            label18 = new Label();
            label13 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            delSp = new Button();
            label1 = new Label();
            tentk = new TextBox();
            TTKH.SuspendLayout();
            TTSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TTCustomers).BeginInit();
            addKH.SuspendLayout();
            AddAdmin.SuspendLayout();
            delKH.SuspendLayout();
            updateKH.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TTKH
            // 
            TTKH.Controls.Add(TTSP);
            TTKH.Controls.Add(addKH);
            TTKH.Controls.Add(delKH);
            TTKH.Controls.Add(updateKH);
            TTKH.Location = new Point(2, 2);
            TTKH.Margin = new Padding(6, 6, 6, 6);
            TTKH.Name = "TTKH";
            TTKH.SelectedIndex = 0;
            TTKH.Size = new Size(2331, 1378);
            TTKH.TabIndex = 6;
            // 
            // TTSP
            // 
            TTSP.Controls.Add(label14);
            TTSP.Controls.Add(TTCustomers);
            TTSP.Location = new Point(10, 55);
            TTSP.Margin = new Padding(6, 6, 6, 6);
            TTSP.Name = "TTSP";
            TTSP.Padding = new Padding(6, 6, 6, 6);
            TTSP.Size = new Size(2311, 1313);
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
            label14.Location = new Point(22, 17);
            label14.Margin = new Padding(6, 0, 6, 0);
            label14.Name = "label14";
            label14.Size = new Size(630, 72);
            label14.TabIndex = 9;
            label14.Text = "Thông Tin Khách hàng";
            // 
            // TTCustomers
            // 
            TTCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            TTCustomers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            TTCustomers.BackgroundColor = SystemColors.ButtonHighlight;
            TTCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TTCustomers.Location = new Point(242, 137);
            TTCustomers.Margin = new Padding(6, 6, 6, 6);
            TTCustomers.Name = "TTCustomers";
            TTCustomers.ReadOnly = true;
            TTCustomers.RowHeadersWidth = 51;
            TTCustomers.RowTemplate.Height = 29;
            TTCustomers.Size = new Size(1483, 908);
            TTCustomers.TabIndex = 8;
            TTCustomers.CellContentClick += TTCustomers_CellContentClick;
            // 
            // addKH
            // 
            addKH.Controls.Add(AddAdmin);
            addKH.Controls.Add(label4);
            addKH.Location = new Point(10, 55);
            addKH.Margin = new Padding(6, 6, 6, 6);
            addKH.Name = "addKH";
            addKH.Padding = new Padding(6, 6, 6, 6);
            addKH.Size = new Size(2311, 1313);
            addKH.TabIndex = 1;
            addKH.Text = "Thêm Khách hàng";
            addKH.UseVisualStyleBackColor = true;
            // 
            // AddAdmin
            // 
            AddAdmin.Controls.Add(them);
            AddAdmin.Controls.Add(tkemail);
            AddAdmin.Controls.Add(email);
            AddAdmin.Controls.Add(sodienthoai);
            AddAdmin.Controls.Add(sdt);
            AddAdmin.Controls.Add(password);
            AddAdmin.Controls.Add(pass);
            AddAdmin.Controls.Add(hovaten);
            AddAdmin.Controls.Add(name);
            AddAdmin.Controls.Add(username);
            AddAdmin.Controls.Add(uname);
            AddAdmin.Location = new Point(446, 207);
            AddAdmin.Margin = new Padding(6, 6, 6, 6);
            AddAdmin.Name = "AddAdmin";
            AddAdmin.Size = new Size(1192, 820);
            AddAdmin.TabIndex = 13;
            // 
            // them
            // 
            them.BackColor = Color.Green;
            them.Location = new Point(649, 649);
            them.Margin = new Padding(6, 6, 6, 6);
            them.Name = "them";
            them.Size = new Size(182, 70);
            them.TabIndex = 10;
            them.Text = "Thêm";
            them.UseVisualStyleBackColor = false;
            them.Click += them_Click;
            // 
            // tkemail
            // 
            tkemail.Location = new Point(249, 512);
            tkemail.Margin = new Padding(6, 6, 6, 6);
            tkemail.Name = "tkemail";
            tkemail.Size = new Size(499, 43);
            tkemail.TabIndex = 9;
            // 
            // email
            // 
            email.AutoSize = true;
            email.Location = new Point(112, 512);
            email.Margin = new Padding(6, 0, 6, 0);
            email.Name = "email";
            email.Size = new Size(82, 37);
            email.TabIndex = 8;
            email.Text = "Email";
            // 
            // sodienthoai
            // 
            sodienthoai.Location = new Point(249, 403);
            sodienthoai.Margin = new Padding(6, 6, 6, 6);
            sodienthoai.Name = "sodienthoai";
            sodienthoai.Size = new Size(499, 43);
            sodienthoai.TabIndex = 7;
            // 
            // sdt
            // 
            sdt.AutoSize = true;
            sdt.Location = new Point(24, 403);
            sdt.Margin = new Padding(6, 0, 6, 0);
            sdt.Name = "sdt";
            sdt.Size = new Size(174, 37);
            sdt.TabIndex = 6;
            sdt.Text = "Số điện thoại";
            // 
            // password
            // 
            password.Location = new Point(249, 292);
            password.Margin = new Padding(6, 6, 6, 6);
            password.Name = "password";
            password.Size = new Size(499, 43);
            password.TabIndex = 5;
            // 
            // pass
            // 
            pass.AutoSize = true;
            pass.Location = new Point(60, 292);
            pass.Margin = new Padding(6, 0, 6, 0);
            pass.Name = "pass";
            pass.Size = new Size(127, 37);
            pass.TabIndex = 4;
            pass.Text = "mật khẩu";
            // 
            // hovaten
            // 
            hovaten.Location = new Point(249, 183);
            hovaten.Margin = new Padding(6, 6, 6, 6);
            hovaten.Name = "hovaten";
            hovaten.Size = new Size(499, 43);
            hovaten.TabIndex = 3;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(60, 183);
            name.Margin = new Padding(6, 0, 6, 0);
            name.Name = "name";
            name.Size = new Size(131, 37);
            name.TabIndex = 2;
            name.Text = "Họ và tên";
            // 
            // username
            // 
            username.Location = new Point(249, 78);
            username.Margin = new Padding(6, 6, 6, 6);
            username.Name = "username";
            username.Size = new Size(499, 43);
            username.TabIndex = 1;
            // 
            // uname
            // 
            uname.AutoSize = true;
            uname.Location = new Point(60, 78);
            uname.Margin = new Padding(6, 0, 6, 0);
            uname.Name = "uname";
            uname.Size = new Size(141, 37);
            uname.TabIndex = 0;
            uname.Text = "UserName";
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
            label4.Size = new Size(786, 72);
            label4.TabIndex = 12;
            label4.Text = "Thêm Tài khoản khách hàng";
            // 
            // delKH
            // 
            delKH.Controls.Add(label5);
            delKH.Controls.Add(label3);
            delKH.Controls.Add(panel1);
            delKH.Location = new Point(10, 55);
            delKH.Margin = new Padding(6, 6, 6, 6);
            delKH.Name = "delKH";
            delKH.Padding = new Padding(6, 6, 6, 6);
            delKH.Size = new Size(2311, 1313);
            delKH.TabIndex = 2;
            delKH.Text = "Xóa Khách hàng";
            delKH.UseVisualStyleBackColor = true;
            // 
            // updateKH
            // 
            updateKH.Controls.Add(panel3);
            updateKH.Controls.Add(label13);
            updateKH.Controls.Add(label6);
            updateKH.Location = new Point(10, 55);
            updateKH.Margin = new Padding(6, 6, 6, 6);
            updateKH.Name = "updateKH";
            updateKH.Padding = new Padding(6, 6, 6, 6);
            updateKH.Size = new Size(2311, 1313);
            updateKH.TabIndex = 3;
            updateKH.Text = "Sửa Thông tin khách hàng";
            updateKH.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(tkmail);
            panel3.Controls.Add(suaBG);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(phonenb);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(matkhau);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(hovten);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(account);
            panel3.Controls.Add(label18);
            panel3.Location = new Point(536, 220);
            panel3.Margin = new Padding(6, 6, 6, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(1192, 820);
            panel3.TabIndex = 17;
            // 
            // tkmail
            // 
            tkmail.Location = new Point(249, 512);
            tkmail.Margin = new Padding(6, 6, 6, 6);
            tkmail.Name = "tkmail";
            tkmail.Size = new Size(499, 43);
            tkmail.TabIndex = 9;
            // 
            // suaBG
            // 
            suaBG.BackColor = Color.Green;
            suaBG.Location = new Point(570, 659);
            suaBG.Margin = new Padding(6, 6, 6, 6);
            suaBG.Name = "suaBG";
            suaBG.Size = new Size(182, 70);
            suaBG.TabIndex = 10;
            suaBG.Text = "Sửa";
            suaBG.UseVisualStyleBackColor = false;
            suaBG.Click += suaBG_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 512);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 37);
            label2.TabIndex = 8;
            label2.Text = "Email";
            // 
            // phonenb
            // 
            phonenb.Location = new Point(249, 403);
            phonenb.Margin = new Padding(6, 6, 6, 6);
            phonenb.Name = "phonenb";
            phonenb.Size = new Size(499, 43);
            phonenb.TabIndex = 7;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(24, 403);
            label15.Margin = new Padding(6, 0, 6, 0);
            label15.Name = "label15";
            label15.Size = new Size(174, 37);
            label15.TabIndex = 6;
            label15.Text = "Số điện thoại";
            // 
            // matkhau
            // 
            matkhau.Location = new Point(249, 292);
            matkhau.Margin = new Padding(6, 6, 6, 6);
            matkhau.Name = "matkhau";
            matkhau.Size = new Size(499, 43);
            matkhau.TabIndex = 5;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(60, 292);
            label16.Margin = new Padding(6, 0, 6, 0);
            label16.Name = "label16";
            label16.Size = new Size(127, 37);
            label16.TabIndex = 4;
            label16.Text = "mật khẩu";
            // 
            // hovten
            // 
            hovten.Location = new Point(249, 183);
            hovten.Margin = new Padding(6, 6, 6, 6);
            hovten.Name = "hovten";
            hovten.Size = new Size(499, 43);
            hovten.TabIndex = 3;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(60, 183);
            label17.Margin = new Padding(6, 0, 6, 0);
            label17.Name = "label17";
            label17.Size = new Size(131, 37);
            label17.TabIndex = 2;
            label17.Text = "Họ và tên";
            // 
            // account
            // 
            account.Location = new Point(249, 78);
            account.Margin = new Padding(6, 6, 6, 6);
            account.Name = "account";
            account.Size = new Size(499, 43);
            account.TabIndex = 1;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(60, 78);
            label18.Margin = new Padding(6, 0, 6, 0);
            label18.Name = "label18";
            label18.Size = new Size(141, 37);
            label18.TabIndex = 0;
            label18.Text = "UserName";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(255, 178);
            label13.Margin = new Padding(6, 0, 6, 0);
            label13.Name = "label13";
            label13.Size = new Size(1353, 37);
            label13.TabIndex = 16;
            label13.Text = "Nhập đầy đủ các thông tin cần sửa, những thông tin không sửa vui lòng nhập như cũ (UserName không thay đổi)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.HotTrack;
            label6.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.Cornsilk;
            label6.Location = new Point(0, 6);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(722, 72);
            label6.TabIndex = 15;
            label6.Text = "Sửa thông tin Khách hàng\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(349, 295);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(339, 37);
            label5.TabIndex = 14;
            label5.Text = "Nhập tên Username để xóa";
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
            label3.Size = new Size(743, 72);
            label3.TabIndex = 13;
            label3.Text = "Xóa Tài khoản khách hàng";
            // 
            // panel1
            // 
            panel1.Controls.Add(delSp);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tentk);
            panel1.Location = new Point(349, 337);
            panel1.Margin = new Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1305, 548);
            panel1.TabIndex = 12;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 122);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(141, 37);
            label1.TabIndex = 0;
            label1.Text = "UserName";
            // 
            // tentk
            // 
            tentk.Location = new Point(371, 122);
            tentk.Margin = new Padding(6);
            tentk.Name = "tentk";
            tentk.Size = new Size(561, 43);
            tentk.TabIndex = 1;
            // 
            // TTKhachHang
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2535, 1439);
            Controls.Add(TTKH);
            Margin = new Padding(6, 6, 6, 6);
            Name = "TTKhachHang";
            Text = "TTKhachHang";
            TTKH.ResumeLayout(false);
            TTSP.ResumeLayout(false);
            TTSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TTCustomers).EndInit();
            addKH.ResumeLayout(false);
            addKH.PerformLayout();
            AddAdmin.ResumeLayout(false);
            AddAdmin.PerformLayout();
            delKH.ResumeLayout(false);
            delKH.PerformLayout();
            updateKH.ResumeLayout(false);
            updateKH.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}