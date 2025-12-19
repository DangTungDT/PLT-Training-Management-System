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
            btnEditBook = new Guna.UI2.WinForms.Guna2Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
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
            btnEditBook.Text = "Sửa thông tin";
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
            // UcMenuHeaderEditBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UcMenuHeaderEditBook";
            Size = new Size(926, 64);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnEditBook;
        private Panel panel1;
    }
}
