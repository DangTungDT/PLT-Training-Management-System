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
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            picIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblFileName = new Label();
            lblFileInfo = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnDelete = new Guna.UI2.WinForms.Guna2Button();
            btnDownload = new Guna.UI2.WinForms.Guna2Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            pnlMain.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIcon).BeginInit();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BorderColor = Color.FromArgb(229, 231, 235);
            pnlMain.BorderRadius = 8;
            pnlMain.BorderThickness = 1;
            pnlMain.Controls.Add(tableLayoutPanel2);
            pnlMain.Controls.Add(tableLayoutPanel1);
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
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Controls.Add(panel2, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(731, 123);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(94, 117);
            panel1.TabIndex = 0;
            // 
            // picIcon
            // 
            picIcon.BorderRadius = 5;
            picIcon.CustomizableEdges = customizableEdges1;
            picIcon.Dock = DockStyle.Fill;
            picIcon.FillColor = Color.FromArgb(254, 242, 242);
            picIcon.ImageRotate = 0F;
            picIcon.Location = new Point(21, 33);
            picIcon.Margin = new Padding(4, 5, 4, 5);
            picIcon.Name = "picIcon";
            picIcon.ShadowDecoration.CustomizableEdges = customizableEdges2;
            picIcon.Size = new Size(52, 50);
            picIcon.SizeMode = PictureBoxSizeMode.CenterImage;
            picIcon.TabIndex = 0;
            picIcon.TabStop = false;
            picIcon.Click += picIcon_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(103, 3);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(625, 117);
            panel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lblFileName);
            flowLayoutPanel1.Controls.Add(lblFileInfo);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(10, 10);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(605, 97);
            flowLayoutPanel1.TabIndex = 3;
            flowLayoutPanel1.WrapContents = false;
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.BackColor = Color.White;
            lblFileName.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFileName.ForeColor = Color.FromArgb(17, 24, 39);
            lblFileName.Location = new Point(4, 4);
            lblFileName.Margin = new Padding(4);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(211, 23);
            lblFileName.TabIndex = 1;
            lblFileName.Text = "Co-so-du-lieu-Oracle.pdf";
            lblFileName.DoubleClick += lblFileName_DoubleClick;
            // 
            // lblFileInfo
            // 
            lblFileInfo.AutoSize = true;
            lblFileInfo.BackColor = Color.White;
            lblFileInfo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFileInfo.ForeColor = Color.FromArgb(107, 114, 128);
            lblFileInfo.Location = new Point(4, 35);
            lblFileInfo.Margin = new Padding(4);
            lblFileInfo.Name = "lblFileInfo";
            lblFileInfo.Size = new Size(208, 20);
            lblFileInfo.TabIndex = 2;
            lblFileInfo.Text = "15.2 MB  •  PDF  •  15/03/2024";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnDelete, 1, 0);
            tableLayoutPanel1.Controls.Add(btnDownload, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Right;
            tableLayoutPanel1.Location = new Point(731, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(229, 123);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.BorderRadius = 5;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.CustomizableEdges = customizableEdges3;
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.FillColor = Color.Transparent;
            btnDelete.Font = new Font("Segoe UI", 12F);
            btnDelete.ForeColor = Color.FromArgb(107, 114, 128);
            btnDelete.HoverState.FillColor = Color.FromArgb(254, 226, 226);
            btnDelete.HoverState.ForeColor = Color.FromArgb(220, 38, 38);
            btnDelete.Image = Properties.Resources.delete;
            btnDelete.Location = new Point(118, 5);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnDelete.Size = new Size(107, 113);
            btnDelete.TabIndex = 4;
            btnDelete.TextOffset = new Point(0, -1);
            btnDelete.Click += btnDelete_Click;
            // 
            // btnDownload
            // 
            btnDownload.BackColor = Color.White;
            btnDownload.BorderRadius = 5;
            btnDownload.Cursor = Cursors.Hand;
            btnDownload.CustomizableEdges = customizableEdges5;
            btnDownload.Dock = DockStyle.Fill;
            btnDownload.FillColor = Color.Transparent;
            btnDownload.Font = new Font("Segoe UI", 12F);
            btnDownload.ForeColor = Color.FromArgb(107, 114, 128);
            btnDownload.HoverState.FillColor = Color.FromArgb(243, 244, 246);
            btnDownload.Image = Properties.Resources.downloads;
            btnDownload.Location = new Point(4, 5);
            btnDownload.Margin = new Padding(4, 5, 4, 5);
            btnDownload.Name = "btnDownload";
            btnDownload.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnDownload.Size = new Size(106, 113);
            btnDownload.TabIndex = 3;
            btnDownload.TextOffset = new Point(0, 2);
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(picIcon, 1, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(94, 117);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // ucFileOfBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pnlMain);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(452, 123);
            Name = "ucFileOfBook";
            Size = new Size(960, 123);
            pnlMain.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picIcon).EndInit();
            panel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        public Guna.UI2.WinForms.Guna2PictureBox picIcon;
        public System.Windows.Forms.Label lblFileName;
        public System.Windows.Forms.Label lblFileInfo;
        public Guna.UI2.WinForms.Guna2Button btnDownload;
        public Guna.UI2.WinForms.Guna2Button btnDelete;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
    }
}