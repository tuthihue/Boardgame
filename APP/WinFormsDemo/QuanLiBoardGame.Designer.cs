namespace WinFormsDemo
{
    partial class QuanLiBoardGame
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
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            adminToolStripMenuItem = new ToolStripMenuItem();
            thôngTinTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            đổiMậtKhẩuToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            thôngTinKháchHàngToolStripMenuItem = new ToolStripMenuItem();
            thôngTinQuảnTrịViênToolStripMenuItem = new ToolStripMenuItem();
            thôngTinSảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
            thôngTinThuêBoardGameToolStripMenuItem = new ToolStripMenuItem();
            thôngTinTrảBoardGameToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.HotTrack;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Cornsilk;
            label1.Location = new Point(419, 48);
            label1.Name = "label1";
            label1.Size = new Size(551, 41);
            label1.TabIndex = 6;
            label1.Text = "Trang Quản Lý cho thuê BoardGame\r\n";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, thôngTinKháchHàngToolStripMenuItem, thôngTinQuảnTrịViênToolStripMenuItem, thôngTinSảnPhẩmToolStripMenuItem, thôngTinThuêBoardGameToolStripMenuItem, thôngTinTrảBoardGameToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1459, 28);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinTàiKhoảnToolStripMenuItem, đổiMậtKhẩuToolStripMenuItem, đăngXuấtToolStripMenuItem });
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(67, 24);
            adminToolStripMenuItem.Text = "Admin";
            adminToolStripMenuItem.Click += adminToolStripMenuItem_Click;
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            thôngTinTàiKhoảnToolStripMenuItem.Size = new Size(220, 26);
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            thôngTinTàiKhoảnToolStripMenuItem.Click += thôngTinTàiKhoảnToolStripMenuItem_Click;
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            đổiMậtKhẩuToolStripMenuItem.Size = new Size(220, 26);
            đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            đổiMậtKhẩuToolStripMenuItem.Click += đổiMậtKhẩuToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(220, 26);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // thôngTinKháchHàngToolStripMenuItem
            // 
            thôngTinKháchHàngToolStripMenuItem.Name = "thôngTinKháchHàngToolStripMenuItem";
            thôngTinKháchHàngToolStripMenuItem.Size = new Size(165, 24);
            thôngTinKháchHàngToolStripMenuItem.Text = "Thông tin khách hàng";
            thôngTinKháchHàngToolStripMenuItem.Click += thôngTinKháchHàngToolStripMenuItem_Click;
            // 
            // thôngTinQuảnTrịViênToolStripMenuItem
            // 
            thôngTinQuảnTrịViênToolStripMenuItem.Name = "thôngTinQuảnTrịViênToolStripMenuItem";
            thôngTinQuảnTrịViênToolStripMenuItem.Size = new Size(172, 24);
            thôngTinQuảnTrịViênToolStripMenuItem.Text = "Thông tin quản trị viên";
            thôngTinQuảnTrịViênToolStripMenuItem.Click += thôngTinQuảnTrịViênToolStripMenuItem_Click;
            // 
            // thôngTinSảnPhẩmToolStripMenuItem
            // 
            thôngTinSảnPhẩmToolStripMenuItem.Name = "thôngTinSảnPhẩmToolStripMenuItem";
            thôngTinSảnPhẩmToolStripMenuItem.Size = new Size(154, 24);
            thôngTinSảnPhẩmToolStripMenuItem.Text = "Thông tin sản phẩm";
            thôngTinSảnPhẩmToolStripMenuItem.Click += thôngTinSảnPhẩmToolStripMenuItem_Click;
            // 
            // thôngTinThuêBoardGameToolStripMenuItem
            // 
            thôngTinThuêBoardGameToolStripMenuItem.Name = "thôngTinThuêBoardGameToolStripMenuItem";
            thôngTinThuêBoardGameToolStripMenuItem.Size = new Size(202, 24);
            thôngTinThuêBoardGameToolStripMenuItem.Text = "Thông tin thuê BoardGame";
            thôngTinThuêBoardGameToolStripMenuItem.Click += thôngTinThuêBoardGameToolStripMenuItem_Click;
            // 
            // thôngTinTrảBoardGameToolStripMenuItem
            // 
            thôngTinTrảBoardGameToolStripMenuItem.Name = "thôngTinTrảBoardGameToolStripMenuItem";
            thôngTinTrảBoardGameToolStripMenuItem.Size = new Size(191, 24);
            thôngTinTrảBoardGameToolStripMenuItem.Text = "Thông tin trả BoardGame";
            thôngTinTrảBoardGameToolStripMenuItem.Click += thôngTinTrảBoardGameToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(72, 118);
            panel1.Name = "panel1";
            panel1.Size = new Size(1300, 546);
            panel1.TabIndex = 14;
            panel1.Paint += panel1_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(848, 100);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 3;
            label5.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(542, 100);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 2;
            label4.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(251, 100);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 1;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(542, 30);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 0;
            label2.Text = "label2";
            // 
            // QuanLiBoardGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1459, 832);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ControlText;
            MainMenuStrip = menuStrip1;
            Name = "QuanLiBoardGame";
            Text = "QuanLyBoardGame";
            Load += QuanLyBoardGame_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem thôngTinKháchHàngToolStripMenuItem;
        private ToolStripMenuItem thôngTinQuảnTrịViênToolStripMenuItem;
        private ToolStripMenuItem thôngTinSảnPhẩmToolStripMenuItem;
        private ToolStripMenuItem thôngTinThuêBoardGameToolStripMenuItem;
        private ToolStripMenuItem thôngTinTrảBoardGameToolStripMenuItem;
        private Panel panel1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label5;
    }
}