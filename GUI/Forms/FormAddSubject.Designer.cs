namespace GUI.Forms
{
    partial class FormAddSubject
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnTop = new Panel();
            lblTitle = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblShortName = new Label();
            txtShortName = new TextBox();
            lblStartDate = new Label();
            dtpStartDate = new DateTimePicker();
            lblEndDate = new Label();
            dtpEndDate = new DateTimePicker();
            lblDescription = new Label();
            txtDescription = new TextBox();
            lblCategory = new Label();
            cbCategory = new ComboBox();
            lblSemester = new Label();
            cbSemester = new ComboBox();
            pnBottom = new Panel();
            btnClose = new Button();
            btnAdd = new Button();
            pnTop.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pnBottom.SuspendLayout();
            SuspendLayout();
            // 
            // pnTop
            // 
            pnTop.BackColor = Color.FromArgb(94, 148, 255);
            pnTop.Controls.Add(lblTitle);
            pnTop.Dock = DockStyle.Top;
            pnTop.Location = new Point(0, 0);
            pnTop.Name = "pnTop";
            pnTop.Size = new Size(520, 80);
            pnTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(520, 80);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Thêm Môn Học (Course)";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblFullName, 0, 0);
            tableLayoutPanel1.Controls.Add(txtFullName, 0, 1);
            tableLayoutPanel1.Controls.Add(lblShortName, 0, 2);
            tableLayoutPanel1.Controls.Add(txtShortName, 0, 3);
            tableLayoutPanel1.Controls.Add(lblStartDate, 0, 4);
            tableLayoutPanel1.Controls.Add(dtpStartDate, 0, 5);
            tableLayoutPanel1.Controls.Add(lblEndDate, 0, 6);
            tableLayoutPanel1.Controls.Add(dtpEndDate, 0, 7);
            tableLayoutPanel1.Controls.Add(lblDescription, 0, 8);
            tableLayoutPanel1.Controls.Add(txtDescription, 0, 9);
            tableLayoutPanel1.Controls.Add(lblCategory, 0, 10);
            tableLayoutPanel1.Controls.Add(cbCategory, 0, 11);
            tableLayoutPanel1.Controls.Add(lblSemester, 0, 12);
            tableLayoutPanel1.Controls.Add(cbSemester, 0, 13);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 80);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(30, 20, 30, 20);
            tableLayoutPanel1.RowCount = 14;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.Size = new Size(520, 520);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 10F);
            lblFullName.Location = new Point(33, 20);
            lblFullName.Name = "lblFullName";
            lblFullName.Padding = new Padding(0, 5, 0, 0);
            lblFullName.Size = new Size(109, 26);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "Tên môn học";
            // 
            // txtFullName
            // 
            txtFullName.Dock = DockStyle.Fill;
            txtFullName.Font = new Font("Segoe UI", 11F);
            txtFullName.Location = new Point(33, 49);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(454, 32);
            txtFullName.TabIndex = 1;
            // 
            // lblShortName
            // 
            lblShortName.AutoSize = true;
            lblShortName.Font = new Font("Segoe UI", 10F);
            lblShortName.Location = new Point(33, 82);
            lblShortName.Name = "lblShortName";
            lblShortName.Padding = new Padding(0, 5, 0, 0);
            lblShortName.Size = new Size(98, 26);
            lblShortName.TabIndex = 2;
            lblShortName.Text = "Tên rút gọn";
            // 
            // txtShortName
            // 
            txtShortName.Dock = DockStyle.Fill;
            txtShortName.Font = new Font("Segoe UI", 11F);
            txtShortName.Location = new Point(33, 111);
            txtShortName.Name = "txtShortName";
            txtShortName.Size = new Size(454, 32);
            txtShortName.TabIndex = 3;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("Segoe UI", 10F);
            lblStartDate.Location = new Point(33, 144);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Padding = new Padding(0, 5, 0, 0);
            lblStartDate.Size = new Size(114, 26);
            lblStartDate.TabIndex = 4;
            lblStartDate.Text = "Ngày bắt đầu";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Dock = DockStyle.Fill;
            dtpStartDate.Font = new Font("Segoe UI", 11F);
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(33, 173);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(454, 32);
            dtpStartDate.TabIndex = 5;
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new Font("Segoe UI", 10F);
            lblEndDate.Location = new Point(33, 206);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Padding = new Padding(0, 5, 0, 0);
            lblEndDate.Size = new Size(117, 26);
            lblEndDate.TabIndex = 6;
            lblEndDate.Text = "Ngày kết thúc";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Dock = DockStyle.Fill;
            dtpEndDate.Font = new Font("Segoe UI", 11F);
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(33, 235);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(454, 32);
            dtpEndDate.TabIndex = 7;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 10F);
            lblDescription.Location = new Point(33, 268);
            lblDescription.Name = "lblDescription";
            lblDescription.Padding = new Padding(0, 5, 0, 0);
            lblDescription.Size = new Size(55, 26);
            lblDescription.TabIndex = 8;
            lblDescription.Text = "Mô tả";
            // 
            // txtDescription
            // 
            txtDescription.Dock = DockStyle.Fill;
            txtDescription.Font = new Font("Segoe UI", 11F);
            txtDescription.Location = new Point(33, 297);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(454, 54);
            txtDescription.TabIndex = 9;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 10F);
            lblCategory.Location = new Point(33, 354);
            lblCategory.Name = "lblCategory";
            lblCategory.Padding = new Padding(0, 5, 0, 0);
            lblCategory.Size = new Size(101, 26);
            lblCategory.TabIndex = 10;
            lblCategory.Text = "Chọn nhóm";
            // 
            // cbCategory
            // 
            cbCategory.Dock = DockStyle.Fill;
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.Font = new Font("Segoe UI", 11F);
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(33, 383);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(454, 33);
            cbCategory.TabIndex = 11;
            // 
            // lblSemester
            // 
            lblSemester.AutoSize = true;
            lblSemester.Font = new Font("Segoe UI", 10F);
            lblSemester.Location = new Point(33, 416);
            lblSemester.Name = "lblSemester";
            lblSemester.Padding = new Padding(0, 5, 0, 0);
            lblSemester.Size = new Size(105, 26);
            lblSemester.TabIndex = 12;
            lblSemester.Text = "Chọn học kỳ";
            // 
            // cbSemester
            // 
            cbSemester.Dock = DockStyle.Fill;
            cbSemester.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSemester.Font = new Font("Segoe UI", 11F);
            cbSemester.FormattingEnabled = true;
            cbSemester.Location = new Point(33, 445);
            cbSemester.Name = "cbSemester";
            cbSemester.Size = new Size(454, 33);
            cbSemester.TabIndex = 13;
            // 
            // pnBottom
            // 
            pnBottom.Controls.Add(btnClose);
            pnBottom.Controls.Add(btnAdd);
            pnBottom.Dock = DockStyle.Bottom;
            pnBottom.Location = new Point(0, 600);
            pnBottom.Name = "pnBottom";
            pnBottom.Padding = new Padding(30, 10, 30, 10);
            pnBottom.Size = new Size(520, 70);
            pnBottom.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Gray;
            btnClose.Dock = DockStyle.Left;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(30, 10);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(120, 50);
            btnClose.TabIndex = 1;
            btnClose.Text = "Thoát";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(94, 148, 255);
            btnAdd.Dock = DockStyle.Right;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(370, 10);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 50);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // FormAddSubject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 670);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pnBottom);
            Controls.Add(pnTop);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAddSubject";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm Môn Học";
            Load += FormAddSubject_Load;
            pnTop.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            pnBottom.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblShortName;
        private System.Windows.Forms.TextBox txtShortName;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.ComboBox cbSemester;
        private System.Windows.Forms.Panel pnBottom;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
    }
}