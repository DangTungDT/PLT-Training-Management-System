namespace GUI.Forms
{
    partial class FormAddSemester
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
            pnTop = new Panel();
            lblTitle = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblName = new Label();
            txtName = new TextBox();
            lblYear = new Label();
            cbYear = new ComboBox();
            lblStartDate = new Label();
            dtpStartDate = new DateTimePicker();
            lblEndDate = new Label();
            dtpEndDate = new DateTimePicker();
            lblSchool = new Label();
            cbSchool = new ComboBox();
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
            pnTop.Size = new Size(500, 80);
            pnTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(500, 80);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Tạo Học Kỳ Mới";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblName, 0, 0);
            tableLayoutPanel1.Controls.Add(txtName, 0, 1);
            tableLayoutPanel1.Controls.Add(lblYear, 0, 2);
            tableLayoutPanel1.Controls.Add(cbYear, 0, 3);
            tableLayoutPanel1.Controls.Add(lblStartDate, 0, 4);
            tableLayoutPanel1.Controls.Add(dtpStartDate, 0, 5);
            tableLayoutPanel1.Controls.Add(lblEndDate, 0, 6);
            tableLayoutPanel1.Controls.Add(dtpEndDate, 0, 7);
            tableLayoutPanel1.Controls.Add(lblSchool, 0, 8);
            tableLayoutPanel1.Controls.Add(cbSchool, 0, 9);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 80);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(30, 20, 30, 20);
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(500, 390);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10F);
            lblName.Location = new Point(33, 20);
            lblName.Name = "lblName";
            lblName.Padding = new Padding(0, 5, 0, 0);
            lblName.Size = new Size(136, 28);
            lblName.TabIndex = 0;
            lblName.Text = "Nhập tên học kỳ";
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Fill;
            txtName.Font = new Font("Segoe UI", 11F);
            txtName.Location = new Point(33, 53);
            txtName.Name = "txtName";
            txtName.Size = new Size(434, 32);
            txtName.TabIndex = 1;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI", 10F);
            lblYear.Location = new Point(33, 90);
            lblYear.Name = "lblYear";
            lblYear.Padding = new Padding(0, 5, 0, 0);
            lblYear.Size = new Size(90, 28);
            lblYear.TabIndex = 2;
            lblYear.Text = "Chọn năm";
            // 
            // cbYear
            // 
            cbYear.Dock = DockStyle.Fill;
            cbYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cbYear.Font = new Font("Segoe UI", 11F);
            cbYear.FormattingEnabled = true;
            cbYear.Location = new Point(33, 123);
            cbYear.Name = "cbYear";
            cbYear.Size = new Size(434, 33);
            cbYear.TabIndex = 3;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("Segoe UI", 10F);
            lblStartDate.Location = new Point(33, 160);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Padding = new Padding(0, 5, 0, 0);
            lblStartDate.Size = new Size(114, 28);
            lblStartDate.TabIndex = 4;
            lblStartDate.Text = "Ngày bắt đầu";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Dock = DockStyle.Fill;
            dtpStartDate.Font = new Font("Segoe UI", 11F);
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(33, 193);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(434, 32);
            dtpStartDate.TabIndex = 5;
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new Font("Segoe UI", 10F);
            lblEndDate.Location = new Point(33, 230);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Padding = new Padding(0, 5, 0, 0);
            lblEndDate.Size = new Size(117, 28);
            lblEndDate.TabIndex = 6;
            lblEndDate.Text = "Ngày kết thúc";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Dock = DockStyle.Fill;
            dtpEndDate.Font = new Font("Segoe UI", 11F);
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(33, 263);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(434, 32);
            dtpEndDate.TabIndex = 7;
            // 
            // lblSchool
            // 
            lblSchool.AutoSize = true;
            lblSchool.Font = new Font("Segoe UI", 10F);
            lblSchool.Location = new Point(33, 300);
            lblSchool.Name = "lblSchool";
            lblSchool.Padding = new Padding(0, 5, 0, 0);
            lblSchool.Size = new Size(108, 28);
            lblSchool.TabIndex = 8;
            lblSchool.Text = "Chọn trường";
            // 
            // cbSchool
            // 
            cbSchool.Dock = DockStyle.Fill;
            cbSchool.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSchool.Font = new Font("Segoe UI", 11F);
            cbSchool.FormattingEnabled = true;
            cbSchool.Location = new Point(33, 333);
            cbSchool.Name = "cbSchool";
            cbSchool.Size = new Size(434, 33);
            cbSchool.TabIndex = 9;
            // 
            // pnBottom
            // 
            pnBottom.Controls.Add(btnClose);
            pnBottom.Controls.Add(btnAdd);
            pnBottom.Dock = DockStyle.Bottom;
            pnBottom.Location = new Point(0, 470);
            pnBottom.Name = "pnBottom";
            pnBottom.Padding = new Padding(30, 10, 30, 10);
            pnBottom.Size = new Size(500, 70);
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
            btnAdd.Location = new Point(350, 10);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 50);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // FormAddSemester
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 540);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pnBottom);
            Controls.Add(pnTop);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAddSemester";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm Học Kỳ";
            Load += FormAddSemester_Load;
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
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblSchool;
        private System.Windows.Forms.ComboBox cbSchool;
        private System.Windows.Forms.Panel pnBottom;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
    }
}