namespace GUI.UserControls
{
    partial class UcMenuHeaderBook
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            btnAddBook = new Button();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAddBook);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(615, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(311, 64);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(359, 64);
            panel2.TabIndex = 2;
            // 
            // btnAddBook
            // 
            btnAddBook.FlatStyle = FlatStyle.Flat;
            btnAddBook.Location = new Point(139, 14);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(169, 34);
            btnAddBook.TabIndex = 0;
            btnAddBook.Text = "Thêm sách mới";
            btnAddBook.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(13, 15);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(322, 27);
            textBox1.TabIndex = 0;
            // 
            // UcMenuHeaderBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UcMenuHeaderBook";
            Size = new Size(926, 64);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnAddBook;
        private TextBox textBox1;
    }
}
