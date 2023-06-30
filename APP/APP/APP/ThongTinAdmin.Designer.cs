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
            insert = new TabPage();
            delete = new TabPage();
            update = new TabPage();
            label2 = new Label();
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
            tabControl.SuspendLayout();
            info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TTAdmin).BeginInit();
            insert.SuspendLayout();
            AddAdmin.SuspendLayout();
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
            // insert
            // 
            insert.BackgroundImage = (Image)resources.GetObject("insert.BackgroundImage");
            insert.BackgroundImageLayout = ImageLayout.Stretch;
            insert.Controls.Add(label2);
            insert.Controls.Add(AddAdmin);
            insert.Location = new Point(4, 29);
            insert.Name = "insert";
            insert.Padding = new Padding(3);
            insert.Size = new Size(1033, 623);
            insert.TabIndex = 1;
            insert.Text = "Thêm quản trị viên";
            insert.UseVisualStyleBackColor = true;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(198, 64);
            label2.Name = "label2";
            label2.Size = new Size(299, 41);
            label2.TabIndex = 10;
            label2.Text = "Thêm Quản trị viên";
            // 
            // AddAdmin
            // 
            AddAdmin.BackColor = Color.White;
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
            AddAdmin.Location = new Point(198, 116);
            AddAdmin.Name = "AddAdmin";
            AddAdmin.Size = new Size(636, 443);
            AddAdmin.TabIndex = 9;
            // 
            // them
            // 
            them.BackColor = Color.LightBlue;
            them.Location = new Point(404, 348);
            them.Name = "them";
            them.Size = new Size(97, 38);
            them.TabIndex = 10;
            them.Text = "Thêm";
            them.UseVisualStyleBackColor = false;
            them.Click += them_Click;
            // 
            // tkemail
            // 
            tkemail.BackColor = SystemColors.ControlLight;
            tkemail.Location = new Point(229, 289);
            tkemail.Name = "tkemail";
            tkemail.Size = new Size(268, 27);
            tkemail.TabIndex = 9;
            // 
            // email
            // 
            email.AutoSize = true;
            email.Location = new Point(109, 289);
            email.Name = "email";
            email.Size = new Size(46, 20);
            email.TabIndex = 8;
            email.Text = "Email";
            // 
            // sodienthoai
            // 
            sodienthoai.BackColor = SystemColors.ControlLight;
            sodienthoai.Location = new Point(229, 230);
            sodienthoai.Name = "sodienthoai";
            sodienthoai.Size = new Size(268, 27);
            sodienthoai.TabIndex = 7;
            // 
            // sdt
            // 
            sdt.AutoSize = true;
            sdt.Location = new Point(109, 230);
            sdt.Name = "sdt";
            sdt.Size = new Size(97, 20);
            sdt.TabIndex = 6;
            sdt.Text = "Số điện thoại";
            // 
            // password
            // 
            password.BackColor = SystemColors.ControlLight;
            password.Location = new Point(229, 170);
            password.Name = "password";
            password.Size = new Size(268, 27);
            password.TabIndex = 5;
            // 
            // pass
            // 
            pass.AutoSize = true;
            pass.Location = new Point(109, 170);
            pass.Name = "pass";
            pass.Size = new Size(70, 20);
            pass.TabIndex = 4;
            pass.Text = "mật khẩu";
            // 
            // hovaten
            // 
            hovaten.BackColor = SystemColors.ControlLight;
            hovaten.Location = new Point(229, 111);
            hovaten.Name = "hovaten";
            hovaten.Size = new Size(268, 27);
            hovaten.TabIndex = 3;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(109, 111);
            name.Name = "name";
            name.Size = new Size(73, 20);
            name.TabIndex = 2;
            name.Text = "Họ và tên";
            // 
            // username
            // 
            username.BackColor = SystemColors.ControlLight;
            username.Location = new Point(229, 51);
            username.Name = "username";
            username.Size = new Size(268, 27);
            username.TabIndex = 1;
            // 
            // uname
            // 
            uname.AutoSize = true;
            uname.Location = new Point(109, 55);
            uname.Name = "uname";
            uname.Size = new Size(78, 20);
            uname.TabIndex = 0;
            uname.Text = "UserName";
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
            insert.ResumeLayout(false);
            insert.PerformLayout();
            AddAdmin.ResumeLayout(false);
            AddAdmin.PerformLayout();
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
        private Label label2;
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
    }
}