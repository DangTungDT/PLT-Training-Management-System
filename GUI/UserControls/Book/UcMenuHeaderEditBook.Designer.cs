namespace GUI.UserControls.Book
{
    partial class UcMenuHeaderEditBook
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnEditBook = new Guna.UI2.WinForms.Guna2Button();
            panel1 = new Panel();
            panel2 = new Panel();
            btnBlack = new Guna.UI2.WinForms.Guna2Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnEditBook
            // 
            btnEditBook.BorderRadius = 10;
            btnEditBook.CustomizableEdges = customizableEdges1;
            btnEditBook.DisabledState.BorderColor = Color.DarkGray;
            btnEditBook.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEditBook.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEditBook.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEditBook.FillColor = Color.FromArgb(60, 131, 246);
            btnEditBook.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditBook.ForeColor = Color.White;
            btnEditBook.ImageAlign = HorizontalAlignment.Left;
            btnEditBook.ImageSize = new Size(24, 24);
            btnEditBook.Location = new Point(85, 10);
            btnEditBook.Name = "btnEditBook";
            btnEditBook.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnEditBook.Size = new Size(207, 43);
            btnEditBook.TabIndex = 0;
            btnEditBook.TabStop = false;
            btnEditBook.Text = "Sửa thông tin";
            btnEditBook.Click += btnEditBook_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnEditBook);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(615, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(311, 64);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnBlack);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(293, 64);
            panel2.TabIndex = 5;
            // 
            // btnBlack
            // 
            btnBlack.CustomizableEdges = customizableEdges3;
            btnBlack.DisabledState.BorderColor = Color.DarkGray;
            btnBlack.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBlack.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBlack.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBlack.Dock = DockStyle.Left;
            btnBlack.FillColor = Color.White;
            btnBlack.Font = new Font("Segoe UI", 9F);
            btnBlack.ForeColor = Color.FromArgb(104, 116, 135);
            btnBlack.Image = Properties.Resources.leftArrow;
            btnBlack.ImageAlign = HorizontalAlignment.Left;
            btnBlack.Location = new Point(0, 0);
            btnBlack.Name = "btnBlack";
            btnBlack.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnBlack.Size = new Size(150, 64);
            btnBlack.TabIndex = 0;
            btnBlack.Text = "Quay lại";
            btnBlack.TextAlign = HorizontalAlignment.Left;
            btnBlack.Click += btnBlack_Click;
            // 
            // UcMenuHeaderEditBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UcMenuHeaderEditBook";
            Size = new Size(926, 64);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnEditBook;
        private Panel panel1;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnBlack;
    }
}
