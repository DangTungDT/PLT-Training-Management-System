namespace GUI.UserControls.Book
{
    partial class UcMenuHeaderReadFile
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
            btnBlack = new Guna.UI2.WinForms.Guna2Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBlack
            // 
            btnBlack.CustomizableEdges = customizableEdges1;
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
            btnBlack.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnBlack.Size = new Size(150, 64);
            btnBlack.TabIndex = 0;
            btnBlack.Text = "Quay lại";
            btnBlack.TextAlign = HorizontalAlignment.Left;
            btnBlack.Click += btnBlack_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnBlack);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(293, 64);
            panel1.TabIndex = 1;
            // 
            // UcMenuHeaderReadFile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Name = "UcMenuHeaderReadFile";
            Size = new Size(926, 64);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnBlack;
        private Panel panel1;
    }
}
