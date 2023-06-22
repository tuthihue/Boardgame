namespace WinFormsDemo
{
    partial class ThueBoardGame
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
            label14 = new Label();
            TTThueBoardGame = new DataGridView();
            button1 = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            TTSPThue = new DataGridView();
            label1 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)TTThueBoardGame).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TTSPThue).BeginInit();
            SuspendLayout();
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = SystemColors.HotTrack;
            label14.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label14.ForeColor = Color.Cornsilk;
            label14.Location = new Point(0, 3);
            label14.Name = "label14";
            label14.Size = new Size(431, 41);
            label14.TabIndex = 11;
            label14.Text = "Thông Tin Thuê BoardGame";
            // 
            // TTThueBoardGame
            // 
            TTThueBoardGame.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            TTThueBoardGame.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            TTThueBoardGame.BackgroundColor = SystemColors.ButtonHighlight;
            TTThueBoardGame.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TTThueBoardGame.Location = new Point(172, 106);
            TTThueBoardGame.Name = "TTThueBoardGame";
            TTThueBoardGame.ReadOnly = true;
            TTThueBoardGame.RowHeadersWidth = 51;
            TTThueBoardGame.RowTemplate.Height = 29;
            TTThueBoardGame.Size = new Size(791, 491);
            TTThueBoardGame.TabIndex = 10;
            TTThueBoardGame.CellContentClick += TTThueBoardGame_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(881, 628);
            button1.Name = "button1";
            button1.Size = new Size(135, 37);
            button1.TabIndex = 12;
            button1.Text = "Làm mới";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(1, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1194, 727);
            tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(TTThueBoardGame);
            tabPage1.Controls.Add(button1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1186, 694);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Thông tin thuê BoardGame";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(TTSPThue);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1186, 694);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Thông tin sản phẩm thuê";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // TTSPThue
            // 
            TTSPThue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            TTSPThue.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            TTSPThue.BackgroundColor = SystemColors.ButtonHighlight;
            TTSPThue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TTSPThue.Location = new Point(153, 95);
            TTSPThue.Name = "TTSPThue";
            TTSPThue.ReadOnly = true;
            TTSPThue.RowHeadersWidth = 51;
            TTSPThue.RowTemplate.Height = 29;
            TTSPThue.Size = new Size(791, 491);
            TTSPThue.TabIndex = 9;
            TTSPThue.CellContentClick += TTSPThue_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.HotTrack;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Cornsilk;
            label1.Location = new Point(0, 3);
            label1.Name = "label1";
            label1.Size = new Size(524, 41);
            label1.TabIndex = 12;
            label1.Text = "Thông Tin BoardGame Được Thuê ";
            // 
            // button2
            // 
            button2.Location = new Point(809, 611);
            button2.Name = "button2";
            button2.Size = new Size(135, 37);
            button2.TabIndex = 13;
            button2.Text = "Làm mới";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ThueBoardGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 740);
            Controls.Add(tabControl1);
            Name = "ThueBoardGame";
            Text = "ThueBoardGame";
            ((System.ComponentModel.ISupportInitialize)TTThueBoardGame).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TTSPThue).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label14;
        public DataGridView TTThueBoardGame;
        private Button button1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        public DataGridView TTSPThue;
        private Button button2;
    }
}