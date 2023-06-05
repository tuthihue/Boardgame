namespace WinFormsDemo
{
    partial class XoaSP
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
            masp = new Label();
            textBox1 = new TextBox();
            del = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(495, 50);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 0;
            label1.Text = "Xóa sản phẩm";
            // 
            // masp
            // 
            masp.AutoSize = true;
            masp.Location = new Point(211, 114);
            masp.Name = "masp";
            masp.Size = new Size(98, 20);
            masp.TabIndex = 1;
            masp.Text = "Mã sản phẩm";
            masp.Click += masp_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(363, 114);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(384, 27);
            textBox1.TabIndex = 2;
            // 
            // del
            // 
            del.Location = new Point(600, 195);
            del.Name = "del";
            del.Size = new Size(152, 48);
            del.TabIndex = 3;
            del.Text = "Xóa";
            del.UseVisualStyleBackColor = true;
            del.Click += del_Click;
            // 
            // XoaSP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 749);
            Controls.Add(del);
            Controls.Add(textBox1);
            Controls.Add(masp);
            Controls.Add(label1);
            Name = "XoaSP";
            Text = "XoaSP";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label masp;
        private TextBox textBox1;
        private Button del;
    }
}