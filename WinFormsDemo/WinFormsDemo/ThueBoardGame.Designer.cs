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
            ((System.ComponentModel.ISupportInitialize)TTThueBoardGame).BeginInit();
            SuspendLayout();
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = SystemColors.HotTrack;
            label14.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label14.ForeColor = Color.Cornsilk;
            label14.Location = new Point(0, -3);
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
            TTThueBoardGame.Location = new Point(187, 69);
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
            button1.Location = new Point(836, 605);
            button1.Name = "button1";
            button1.Size = new Size(135, 37);
            button1.TabIndex = 12;
            button1.Text = "Làm mới";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ThueBoardGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 740);
            Controls.Add(button1);
            Controls.Add(label14);
            Controls.Add(TTThueBoardGame);
            Name = "ThueBoardGame";
            Text = "ThueBoardGame";
            ((System.ComponentModel.ISupportInitialize)TTThueBoardGame).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label14;
        public DataGridView TTThueBoardGame;
        private Button button1;
    }
}