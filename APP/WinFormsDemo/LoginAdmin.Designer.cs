namespace WinFormsDemo
{
    partial class LoginAdmin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            username = new Label();
            account = new TextBox();
            password = new TextBox();
            pass = new Label();
            Login = new Button();
            notifyIcon1 = new NotifyIcon(components);
            imageList1 = new ImageList(components);
            pageSetupDialog1 = new PageSetupDialog();
            Exit = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // username
            // 
            username.AutoSize = true;
            username.BackColor = Color.Transparent;
            username.Location = new Point(278, 350);
            username.Name = "username";
            username.Size = new Size(107, 20);
            username.TabIndex = 0;
            username.Text = "Tên đăng nhập";
            username.Click += label1_Click;
            // 
            // account
            // 
            account.Location = new Point(423, 350);
            account.Name = "account";
            account.Size = new Size(221, 27);
            account.TabIndex = 1;
            account.TextChanged += textBox1_TextChanged;
            // 
            // password
            // 
            password.Location = new Point(423, 412);
            password.Name = "password";
            password.Size = new Size(221, 27);
            password.TabIndex = 3;
            password.UseSystemPasswordChar = true;
            password.TextChanged += textBox2_TextChanged;
            // 
            // pass
            // 
            pass.AutoSize = true;
            pass.BackColor = Color.Transparent;
            pass.Location = new Point(298, 412);
            pass.Name = "pass";
            pass.Size = new Size(70, 20);
            pass.TabIndex = 2;
            pass.Text = "Mật khẩu";
            pass.Click += label2_Click;
            // 
            // Login
            // 
            Login.BackColor = Color.RoyalBlue;
            Login.ForeColor = SystemColors.ControlLightLight;
            Login.Location = new Point(423, 466);
            Login.Name = "Login";
            Login.Size = new Size(94, 29);
            Login.TabIndex = 5;
            Login.Text = "Đăng nhập";
            Login.UseVisualStyleBackColor = false;
            Login.Click += button1_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // Exit
            // 
            Exit.BackColor = Color.RoyalBlue;
            Exit.ForeColor = SystemColors.ControlLightLight;
            Exit.Location = new Point(536, 466);
            Exit.Name = "Exit";
            Exit.Size = new Size(125, 29);
            Exit.TabIndex = 7;
            Exit.Text = "Thoát";
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += button2_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.login_preview_rev_1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(421, 136);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(223, 208);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // LoginAdmin
            // 
            AcceptButton = Login;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImage = Properties.Resources.login_background;
            BackgroundImageLayout = ImageLayout.Zoom;
            CancelButton = Exit;
            ClientSize = new Size(1069, 640);
            Controls.Add(Exit);
            Controls.Add(Login);
            Controls.Add(username);
            Controls.Add(password);
            Controls.Add(pass);
            Controls.Add(account);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "LoginAdmin";
            Text = "Cổng thông tin đào tạo";
            FormClosing += Page1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label username;
        private Label pass;
        private Button Login;
        private NotifyIcon notifyIcon1;
        private ImageList imageList1;
        private PageSetupDialog pageSetupDialog1;
        private Button Exit;
        private PictureBox pictureBox1;
        public TextBox account;
        public TextBox password;
    }
}