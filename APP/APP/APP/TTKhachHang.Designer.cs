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
            TTKH.SuspendLayout();
            TTSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TTCustomers).BeginInit();
            addKH.SuspendLayout();
            AddAdmin.SuspendLayout();
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
            addKH.Controls.Add(AddAdmin);
            addKH.Controls.Add(label4);
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
            AddAdmin.Location = new Point(238, 112);
            AddAdmin.Name = "AddAdmin";
            AddAdmin.Size = new Size(636, 443);
            AddAdmin.TabIndex = 13;
            // 
            // them
            // 
            them.BackColor = Color.Green;
            them.Location = new Point(346, 351);
            them.Name = "them";
            them.Size = new Size(97, 38);
            them.TabIndex = 10;
            them.Text = "Thêm";
            them.UseVisualStyleBackColor = false;
            them.Click += them_Click;
            // 
            // tkemail
            // 
            tkemail.Location = new Point(133, 277);
            tkemail.Name = "tkemail";
            tkemail.Size = new Size(268, 27);
            tkemail.TabIndex = 9;
            // 
            // email
            // 
            email.AutoSize = true;
            email.Location = new Point(60, 277);
            email.Name = "email";
            email.Size = new Size(46, 20);
            email.TabIndex = 8;
            email.Text = "Email";
            // 
            // sodienthoai
            // 
            sodienthoai.Location = new Point(133, 218);
            sodienthoai.Name = "sodienthoai";
            sodienthoai.Size = new Size(268, 27);
            sodienthoai.TabIndex = 7;
            // 
            // sdt
            // 
            sdt.AutoSize = true;
            sdt.Location = new Point(13, 218);
            sdt.Name = "sdt";
            sdt.Size = new Size(97, 20);
            sdt.TabIndex = 6;
            sdt.Text = "Số điện thoại";
            // 
            // password
            // 
            password.Location = new Point(133, 158);
            password.Name = "password";
            password.Size = new Size(268, 27);
            password.TabIndex = 5;
            // 
            // pass
            // 
            pass.AutoSize = true;
            pass.Location = new Point(32, 158);
            pass.Name = "pass";
            pass.Size = new Size(70, 20);
            pass.TabIndex = 4;
            pass.Text = "mật khẩu";
            // 
            // hovaten
            // 
            hovaten.Location = new Point(133, 99);
            hovaten.Name = "hovaten";
            hovaten.Size = new Size(268, 27);
            hovaten.TabIndex = 3;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(32, 99);
            name.Name = "name";
            name.Size = new Size(73, 20);
            name.TabIndex = 2;
            name.Text = "Họ và tên";
            // 
            // username
            // 
            username.Location = new Point(133, 42);
            username.Name = "username";
            username.Size = new Size(268, 27);
            username.TabIndex = 1;
            // 
            // uname
            // 
            uname.AutoSize = true;
            uname.Location = new Point(32, 42);
            uname.Name = "uname";
            uname.Size = new Size(78, 20);
            uname.TabIndex = 0;
            uname.Text = "UserName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.HotTrack;
            label4.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.Cornsilk;
            label4.Location = new Point(0, 3);
            label4.Name = "label4";
            label4.Size = new Size(436, 41);
            label4.TabIndex = 12;
            label4.Text = "Thêm Tài khoản khách hàng";
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
            addKH.ResumeLayout(false);
            addKH.PerformLayout();
            AddAdmin.ResumeLayout(false);
            AddAdmin.PerformLayout();
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
    }
}