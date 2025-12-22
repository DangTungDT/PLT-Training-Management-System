namespace GUI.UserControls.Book
{
    partial class ucFileOfBook
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            btnDelete = new Guna.UI2.WinForms.Guna2Button();
            btnDownload = new Guna.UI2.WinForms.Guna2Button();
            lblFileInfo = new Label();
            lblFileName = new Label();
            picIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIcon).BeginInit();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BorderColor = Color.FromArgb(229, 231, 235);
            pnlMain.BorderRadius = 8;
            pnlMain.BorderThickness = 1;
            pnlMain.Controls.Add(btnDelete);
            pnlMain.Controls.Add(btnDownload);
            pnlMain.Controls.Add(lblFileInfo);
            pnlMain.Controls.Add(lblFileName);
            pnlMain.Controls.Add(picIcon);
            pnlMain.CustomizableEdges = customizableEdges7;
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.FillColor = Color.White;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Margin = new Padding(4, 5, 4, 5);
            pnlMain.Name = "pnlMain";
            pnlMain.ShadowDecoration.CustomizableEdges = customizableEdges8;
            pnlMain.Size = new Size(960, 123);
            pnlMain.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.BackColor = Color.White;
            btnDelete.BorderRadius = 5;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.CustomizableEdges = customizableEdges1;
            btnDelete.FillColor = Color.Transparent;
            btnDelete.Font = new Font("Segoe UI", 12F);
            btnDelete.ForeColor = Color.FromArgb(107, 114, 128);
            btnDelete.HoverState.FillColor = Color.FromArgb(254, 226, 226);
            btnDelete.HoverState.ForeColor = Color.FromArgb(220, 38, 38);
            btnDelete.Image = Properties.Resources.delete;
            btnDelete.Location = new Point(880, 34);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnDelete.Size = new Size(47, 54);
            btnDelete.TabIndex = 4;
            btnDelete.TextOffset = new Point(0, -1);
            btnDelete.Click += btnDelete_Click;
            // 
            // btnDownload
            // 
            btnDownload.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDownload.BackColor = Color.White;
            btnDownload.BorderRadius = 5;
            btnDownload.Cursor = Cursors.Hand;
            btnDownload.CustomizableEdges = customizableEdges3;
            btnDownload.FillColor = Color.Transparent;
            btnDownload.Font = new Font("Segoe UI", 12F);
            btnDownload.ForeColor = Color.FromArgb(107, 114, 128);
            btnDownload.HoverState.FillColor = Color.FromArgb(243, 244, 246);
            btnDownload.Image = Properties.Resources.downloads;
            btnDownload.Location = new Point(827, 34);
            btnDownload.Margin = new Padding(4, 5, 4, 5);
            btnDownload.Name = "btnDownload";
            btnDownload.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnDownload.Size = new Size(47, 54);
            btnDownload.TabIndex = 3;
            btnDownload.TextOffset = new Point(0, 2);
            // 
            // lblFileInfo
            // 
            lblFileInfo.AutoSize = true;
            lblFileInfo.BackColor = Color.White;
            lblFileInfo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFileInfo.ForeColor = Color.FromArgb(107, 114, 128);
            lblFileInfo.Location = new Point(100, 69);
            lblFileInfo.Margin = new Padding(4, 0, 4, 0);
            lblFileInfo.Name = "lblFileInfo";
            lblFileInfo.Size = new Size(208, 20);
            lblFileInfo.TabIndex = 2;
            lblFileInfo.Text = "15.2 MB  •  PDF  •  15/03/2024";
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.BackColor = Color.White;
            lblFileName.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFileName.ForeColor = Color.FromArgb(17, 24, 39);
            lblFileName.Location = new Point(100, 31);
            lblFileName.Margin = new Padding(4, 0, 4, 0);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(211, 23);
            lblFileName.TabIndex = 1;
            lblFileName.Text = "Co-so-du-lieu-Oracle.pdf";
            lblFileName.DoubleClick += lblFileName_DoubleClick;
            // 
            // picIcon
            // 
            picIcon.BorderRadius = 5;
            picIcon.CustomizableEdges = customizableEdges5;
            picIcon.FillColor = Color.FromArgb(254, 242, 242);
            picIcon.ImageRotate = 0F;
            picIcon.Location = new Point(27, 31);
            picIcon.Margin = new Padding(4, 5, 4, 5);
            picIcon.Name = "picIcon";
            picIcon.ShadowDecoration.CustomizableEdges = customizableEdges6;
            picIcon.Size = new Size(53, 62);
            picIcon.SizeMode = PictureBoxSizeMode.CenterImage;
            picIcon.TabIndex = 0;
            picIcon.TabStop = false;
            // 
            // ucFileOfBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pnlMain);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(960, 123);
            Name = "ucFileOfBook";
            Size = new Size(960, 123);
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picIcon).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        public Guna.UI2.WinForms.Guna2PictureBox picIcon;
        public System.Windows.Forms.Label lblFileName;
        public System.Windows.Forms.Label lblFileInfo;
        public Guna.UI2.WinForms.Guna2Button btnDownload;
        public Guna.UI2.WinForms.Guna2Button btnDelete;
    }
}