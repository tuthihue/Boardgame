namespace App
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
            Exit = new Button();
            Login = new Button();
            username = new Label();
            password = new TextBox();
            pass = new Label();
            account = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Exit
            // 
            Exit.BackColor = Color.RoyalBlue;
            Exit.ForeColor = SystemColors.ControlLightLight;
            Exit.Location = new Point(695, 494);
            Exit.Name = "Exit";
            Exit.Size = new Size(125, 73);
            Exit.TabIndex = 14;
            Exit.Text = "Thoát";
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // Login
            // 
            Login.BackColor = Color.RoyalBlue;
            Login.ForeColor = SystemColors.ControlLightLight;
            Login.Location = new Point(455, 494);
            Login.Name = "Login";
            Login.Size = new Size(166, 73);
            Login.TabIndex = 13;
            Login.Text = "Đăng nhập";
            Login.UseVisualStyleBackColor = false;
            Login.Click += Login_Click;
            // 
            // username
            // 
            username.AutoSize = true;
            username.BackColor = Color.Transparent;
            username.Location = new Point(235, 351);
            username.Name = "username";
            username.Size = new Size(107, 20);
            username.TabIndex = 9;
            username.Text = "Tên đăng nhập";
            // 
            // password
            // 
            password.Location = new Point(455, 413);
            password.Name = "password";
            password.Size = new Size(365, 27);
            password.TabIndex = 12;
            password.UseSystemPasswordChar = true;
            // 
            // pass
            // 
            pass.AutoSize = true;
            pass.BackColor = Color.Transparent;
            pass.Location = new Point(235, 413);
            pass.Name = "pass";
            pass.Size = new Size(70, 20);
            pass.TabIndex = 11;
            pass.Text = "Mật khẩu";
            // 
            // account
            // 
            account.Location = new Point(455, 351);
            account.Name = "account";
            account.Size = new Size(365, 27);
            account.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(506, 90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(223, 208);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // LoginAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 657);
            Controls.Add(Exit);
            Controls.Add(Login);
            Controls.Add(username);
            Controls.Add(password);
            Controls.Add(pass);
            Controls.Add(account);
            Controls.Add(pictureBox1);
            Name = "LoginAdmin";
            Text = "Form1";
            Load += LoginAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Exit;
        private Button Login;
        private Label username;
        public TextBox password;
        private Label pass;
        public TextBox account;
        private PictureBox pictureBox1;
    }
}