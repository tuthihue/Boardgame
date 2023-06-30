namespace APP
{
    partial class ThongtinBoardGame
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
            TTSP = new TabPage();
            label14 = new Label();
            TTBoardGame = new DataGridView();
            addBG = new TabPage();
            delBG = new TabPage();
            updateBG = new TabPage();
            tabControl1.SuspendLayout();
            TTSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TTBoardGame).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(TTSP);
            tabControl1.Controls.Add(addBG);
            tabControl1.Controls.Add(delBG);
            tabControl1.Controls.Add(updateBG);
            tabControl1.Location = new Point(1, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1243, 745);
            tabControl1.TabIndex = 5;
            // 
            // TTSP
            // 
            TTSP.Controls.Add(label14);
            TTSP.Controls.Add(TTBoardGame);
            TTSP.Location = new Point(4, 29);
            TTSP.Name = "TTSP";
            TTSP.Padding = new Padding(3);
            TTSP.Size = new Size(1235, 712);
            TTSP.TabIndex = 0;
            TTSP.Text = "Thông tin BoardGame";
            TTSP.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = SystemColors.HotTrack;
            label14.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label14.ForeColor = Color.Cornsilk;
            label14.Location = new Point(9, 6);
            label14.Name = "label14";
            label14.Size = new Size(350, 41);
            label14.TabIndex = 9;
            label14.Text = "Thông Tin BoardGame";
            // 
            // TTBoardGame
            // 
            TTBoardGame.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            TTBoardGame.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            TTBoardGame.BackgroundColor = SystemColors.ButtonHighlight;
            TTBoardGame.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TTBoardGame.Location = new Point(9, 74);
            TTBoardGame.Name = "TTBoardGame";
            TTBoardGame.ReadOnly = true;
            TTBoardGame.RowHeadersWidth = 51;
            TTBoardGame.RowTemplate.Height = 29;
            TTBoardGame.Size = new Size(1206, 631);
            TTBoardGame.TabIndex = 8;
            // 
            // addBG
            // 
            addBG.Location = new Point(4, 29);
            addBG.Name = "addBG";
            addBG.Padding = new Padding(3);
            addBG.Size = new Size(1235, 712);
            addBG.TabIndex = 1;
            addBG.Text = "Thêm BoardGame";
            addBG.UseVisualStyleBackColor = true;
            // 
            // delBG
            // 
            delBG.Location = new Point(4, 29);
            delBG.Name = "delBG";
            delBG.Padding = new Padding(3);
            delBG.Size = new Size(1235, 712);
            delBG.TabIndex = 2;
            delBG.Text = "Xóa BoardGame";
            delBG.UseVisualStyleBackColor = true;
            // 
            // updateBG
            // 
            updateBG.Location = new Point(4, 29);
            updateBG.Name = "updateBG";
            updateBG.Padding = new Padding(3);
            updateBG.Size = new Size(1235, 712);
            updateBG.TabIndex = 3;
            updateBG.Text = "Sửa BoardGame";
            updateBG.UseVisualStyleBackColor = true;
            // 
            // ThongtinBoardGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1299, 871);
            Controls.Add(tabControl1);
            Name = "ThongtinBoardGame";
            Text = "ThongtinBoardGame";
            tabControl1.ResumeLayout(false);
            TTSP.ResumeLayout(false);
            TTSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TTBoardGame).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage TTSP;
        private Label label14;
        public DataGridView TTBoardGame;
        private TabPage addBG;
        private TabPage delBG;
        private TabPage updateBG;
    }
}