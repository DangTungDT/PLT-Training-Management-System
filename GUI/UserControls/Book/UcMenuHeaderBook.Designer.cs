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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            btnAddBook = new Guna.UI2.WinForms.Guna2Button();
            panel2 = new Panel();
            btnFindBook = new Guna.UI2.WinForms.Guna2Button();
            txtFindBook = new Guna.UI2.WinForms.Guna2TextBox();
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
            // btnAddBook
            // 
            btnAddBook.BorderRadius = 10;
            btnAddBook.CustomizableEdges = customizableEdges1;
            btnAddBook.DisabledState.BorderColor = Color.DarkGray;
            btnAddBook.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddBook.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddBook.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddBook.FillColor = Color.FromArgb(76, 175, 80);
            btnAddBook.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddBook.ForeColor = Color.White;
            btnAddBook.Image = Properties.Resources.add;
            btnAddBook.ImageAlign = HorizontalAlignment.Left;
            btnAddBook.ImageSize = new Size(24, 24);
            btnAddBook.Location = new Point(85, 10);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAddBook.Size = new Size(207, 43);
            btnAddBook.TabIndex = 0;
            btnAddBook.TabStop = false;
            btnAddBook.Text = "Thêm sách mới";
            btnAddBook.TextAlign = HorizontalAlignment.Left;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnFindBook);
            panel2.Controls.Add(txtFindBook);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(596, 64);
            panel2.TabIndex = 2;
            // 
            // btnFindBook
            // 
            btnFindBook.BorderRadius = 10;
            btnFindBook.CustomizableEdges = customizableEdges3;
            btnFindBook.DisabledState.BorderColor = Color.DarkGray;
            btnFindBook.DisabledState.CustomBorderColor = Color.DarkGray;
            btnFindBook.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnFindBook.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnFindBook.FillColor = Color.FromArgb(60, 131, 246);
            btnFindBook.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFindBook.ForeColor = Color.White;
            btnFindBook.Image = Properties.Resources.add;
            btnFindBook.ImageAlign = HorizontalAlignment.Left;
            btnFindBook.ImageSize = new Size(24, 24);
            btnFindBook.Location = new Point(392, 11);
            btnFindBook.Name = "btnFindBook";
            btnFindBook.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnFindBook.Size = new Size(138, 43);
            btnFindBook.TabIndex = 0;
            btnFindBook.TabStop = false;
            btnFindBook.Text = "Tìm kiếm";
            btnFindBook.TextAlign = HorizontalAlignment.Left;
            btnFindBook.Click += btnFindBook_Click;
            // 
            // txtFindBook
            // 
            txtFindBook.BorderColor = Color.FromArgb(248, 250, 252);
            txtFindBook.BorderRadius = 10;
            txtFindBook.CustomizableEdges = customizableEdges5;
            txtFindBook.DefaultText = "";
            txtFindBook.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtFindBook.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtFindBook.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtFindBook.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtFindBook.FillColor = Color.FromArgb(248, 250, 252);
            txtFindBook.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtFindBook.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFindBook.ForeColor = Color.Black;
            txtFindBook.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtFindBook.IconLeft = Properties.Resources.magnifyingGlass;
            txtFindBook.IconLeftSize = new Size(24, 24);
            txtFindBook.Location = new Point(19, 11);
            txtFindBook.Margin = new Padding(4);
            txtFindBook.Name = "txtFindBook";
            txtFindBook.PlaceholderForeColor = Color.FromArgb(64, 64, 64);
            txtFindBook.PlaceholderText = "Tìm kiếm sách theo tên sách, tác giả";
            txtFindBook.SelectedText = "";
            txtFindBook.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtFindBook.Size = new Size(355, 42);
            txtFindBook.TabIndex = 0;
            txtFindBook.TabStop = false;
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
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnAddBook;
        private Guna.UI2.WinForms.Guna2TextBox txtFindBook;
        private Guna.UI2.WinForms.Guna2Button btnFindBook;
    }
}
