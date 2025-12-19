namespace GUI.UserControls.Book
{
    partial class UcInputFileBook
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvFileBook = new DataGridView();
            panel1 = new Panel();
            pnUploadFile = new Guna.UI2.WinForms.Guna2Panel();
            btnChooseFile = new Guna.UI2.WinForms.Guna2Button();
            picUpload = new Guna.UI2.WinForms.Guna2PictureBox();
            lblNote = new Label();
            lblTitle = new Label();
            label2 = new Label();
            label1 = new Label();
            colName = new DataGridViewTextBoxColumn();
            colSizeFile = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvFileBook).BeginInit();
            panel1.SuspendLayout();
            pnUploadFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUpload).BeginInit();
            SuspendLayout();
            // 
            // dgvFileBook
            // 
            dgvFileBook.AllowUserToAddRows = false;
            dgvFileBook.AllowUserToResizeColumns = false;
            dgvFileBook.AllowUserToResizeRows = false;
            dgvFileBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFileBook.BackgroundColor = Color.White;
            dgvFileBook.BorderStyle = BorderStyle.None;
            dgvFileBook.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvFileBook.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvFileBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFileBook.Columns.AddRange(new DataGridViewColumn[] { colName, colSizeFile });
            dgvFileBook.Dock = DockStyle.Fill;
            dgvFileBook.Location = new Point(0, 301);
            dgvFileBook.MultiSelect = false;
            dgvFileBook.Name = "dgvFileBook";
            dgvFileBook.ReadOnly = true;
            dgvFileBook.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvFileBook.RowHeadersVisible = false;
            dgvFileBook.RowHeadersWidth = 51;
            dgvFileBook.Size = new Size(1036, 149);
            dgvFileBook.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(pnUploadFile);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1036, 301);
            panel1.TabIndex = 3;
            // 
            // pnUploadFile
            // 
            pnUploadFile.AllowDrop = true;
            pnUploadFile.BorderColor = Color.FromArgb(226, 230, 233);
            pnUploadFile.BorderRadius = 12;
            pnUploadFile.BorderThickness = 2;
            pnUploadFile.Controls.Add(btnChooseFile);
            pnUploadFile.Controls.Add(picUpload);
            pnUploadFile.Controls.Add(lblNote);
            pnUploadFile.Controls.Add(lblTitle);
            pnUploadFile.CustomizableEdges = customizableEdges17;
            pnUploadFile.Location = new Point(30, 60);
            pnUploadFile.Name = "pnUploadFile";
            pnUploadFile.ShadowDecoration.CustomizableEdges = customizableEdges18;
            pnUploadFile.Size = new Size(976, 216);
            pnUploadFile.TabIndex = 4;
            pnUploadFile.DragDrop += pnUploadFile_DragDrop;
            pnUploadFile.DragEnter += pnUploadFile_DragEnter;
            // 
            // btnChooseFile
            // 
            btnChooseFile.BorderRadius = 8;
            btnChooseFile.CustomizableEdges = customizableEdges13;
            btnChooseFile.FillColor = Color.FromArgb(59, 130, 246);
            btnChooseFile.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnChooseFile.ForeColor = Color.White;
            btnChooseFile.Location = new Point(420, 117);
            btnChooseFile.Margin = new Padding(3, 4, 3, 4);
            btnChooseFile.Name = "btnChooseFile";
            btnChooseFile.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnChooseFile.Size = new Size(137, 48);
            btnChooseFile.TabIndex = 2;
            btnChooseFile.Text = "Chọn tệp tin";
            btnChooseFile.Click += btnChooseFile_Click;
            // 
            // picUpload
            // 
            picUpload.CustomizableEdges = customizableEdges15;
            picUpload.Image = Properties.Resources.downArrow;
            picUpload.ImageRotate = 0F;
            picUpload.Location = new Point(465, 21);
            picUpload.Margin = new Padding(3, 4, 3, 4);
            picUpload.Name = "picUpload";
            picUpload.ShadowDecoration.CustomizableEdges = customizableEdges16;
            picUpload.Size = new Size(46, 53);
            picUpload.SizeMode = PictureBoxSizeMode.Zoom;
            picUpload.TabIndex = 0;
            picUpload.TabStop = false;
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.BackColor = Color.Transparent;
            lblNote.Font = new Font("Segoe UI", 9F);
            lblNote.ForeColor = Color.Gray;
            lblNote.Location = new Point(319, 175);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(339, 20);
            lblNote.TabIndex = 3;
            lblNote.Text = "Hỗ trợ: PDF, DOC, DOCX, ZIP, RAR (Tối đa 500MB)";
            lblNote.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(60, 60, 60);
            lblTitle.Location = new Point(369, 84);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(239, 23);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Kéo thả tệp tin vào đây hoặc";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 20);
            label2.Name = "label2";
            label2.Size = new Size(15, 20);
            label2.TabIndex = 4;
            label2.Text = "*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 20);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 3;
            label1.Text = "Tài liệu đính kèm";
            // 
            // colName
            // 
            colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colName.HeaderText = "Tên tệp tin";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colSizeFile
            // 
            colSizeFile.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colSizeFile.HeaderText = "Kích thước";
            colSizeFile.MinimumWidth = 6;
            colSizeFile.Name = "colSizeFile";
            colSizeFile.ReadOnly = true;
            colSizeFile.Width = 175;
            // 
            // UcInputFileBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dgvFileBook);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UcInputFileBook";
            Size = new Size(1036, 450);
            ((System.ComponentModel.ISupportInitialize)dgvFileBook).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnUploadFile.ResumeLayout(false);
            pnUploadFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUpload).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvFileBook;
        private Panel panel1;
        private Label label2;
        private Label lblNote;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button btnChooseFile;
        private Label lblTitle;
        private Guna.UI2.WinForms.Guna2PictureBox picUpload;
        private Guna.UI2.WinForms.Guna2Panel pnUploadFile;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colSizeFile;
    }
}
