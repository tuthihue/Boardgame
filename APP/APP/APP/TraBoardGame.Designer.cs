namespace APP
{
    partial class TraBoardGame
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
            tabPage1 = new TabPage();
            button1 = new Button();
            label14 = new Label();
            TTTraBoardGame = new DataGridView();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TTTraBoardGame).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(2, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1122, 765);
            tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(TTTraBoardGame);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1114, 732);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Thông Tin Trả BoardGame";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(835, 609);
            button1.Name = "button1";
            button1.Size = new Size(135, 37);
            button1.TabIndex = 15;
            button1.Text = "Làm mới";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = SystemColors.HotTrack;
            label14.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label14.ForeColor = Color.Cornsilk;
            label14.Location = new Point(2, 4);
            label14.Name = "label14";
            label14.Size = new Size(408, 41);
            label14.TabIndex = 14;
            label14.Text = "Thông Tin Trả BoardGame";
            // 
            // TTTraBoardGame
            // 
            TTTraBoardGame.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            TTTraBoardGame.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            TTTraBoardGame.BackgroundColor = SystemColors.ButtonHighlight;
            TTTraBoardGame.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TTTraBoardGame.Location = new Point(186, 73);
            TTTraBoardGame.Name = "TTTraBoardGame";
            TTTraBoardGame.ReadOnly = true;
            TTTraBoardGame.RowHeadersWidth = 51;
            TTTraBoardGame.RowTemplate.Height = 29;
            TTTraBoardGame.Size = new Size(791, 491);
            TTTraBoardGame.TabIndex = 13;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1114, 732);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Cập nhật thông tin trả BoardGame";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // TraBoardGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 808);
            Controls.Add(tabControl1);
            Name = "TraBoardGame";
            Text = "TraBoardGame";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TTTraBoardGame).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button button1;
        private Label label14;
        public DataGridView TTTraBoardGame;
        private TabPage tabPage2;
    }
}