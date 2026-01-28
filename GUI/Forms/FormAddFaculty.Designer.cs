namespace GUI.Forms
{
    partial class FormAddFaculty
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
            lblSchool = new Label();
            cbSchool = new ComboBox();
            lblName = new Label();
            txtName = new TextBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
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
            lblTitle.Text = "Tạo Khoa Mới";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblSchool, 0, 0);
            tableLayoutPanel1.Controls.Add(cbSchool, 0, 1);
            tableLayoutPanel1.Controls.Add(lblName, 0, 2);
            tableLayoutPanel1.Controls.Add(txtName, 0, 3);
            tableLayoutPanel1.Controls.Add(lblDescription, 0, 4);
            tableLayoutPanel1.Controls.Add(txtDescription, 0, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 80);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(30, 20, 30, 20);
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.Size = new Size(500, 290);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // lblSchool
            // 
            lblSchool.AutoSize = true;
            lblSchool.Font = new Font("Segoe UI", 10F);
            lblSchool.Location = new Point(33, 20);
            lblSchool.Name = "lblSchool";
            lblSchool.Padding = new Padding(0, 5, 0, 0);
            lblSchool.Size = new Size(141, 28);
            lblSchool.TabIndex = 0;
            lblSchool.Text = "Chọn trường học";
            // 
            // cbSchool
            // 
            cbSchool.Dock = DockStyle.Fill;
            cbSchool.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSchool.Font = new Font("Segoe UI", 11F);
            cbSchool.FormattingEnabled = true;
            cbSchool.Location = new Point(33, 53);
            cbSchool.Name = "cbSchool";
            cbSchool.Size = new Size(434, 33);
            cbSchool.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10F);
            lblName.Location = new Point(33, 90);
            lblName.Name = "lblName";
            lblName.Padding = new Padding(0, 5, 0, 0);
            lblName.Size = new Size(124, 28);
            lblName.TabIndex = 2;
            lblName.Text = "Nhập tên khoa";
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Fill;
            txtName.Font = new Font("Segoe UI", 11F);
            txtName.Location = new Point(33, 123);
            txtName.Name = "txtName";
            txtName.Size = new Size(434, 32);
            txtName.TabIndex = 3;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 10F);
            lblDescription.Location = new Point(33, 160);
            lblDescription.Name = "lblDescription";
            lblDescription.Padding = new Padding(0, 5, 0, 0);
            lblDescription.Size = new Size(136, 28);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Mô tả (Optional)";
            // 
            // txtDescription
            // 
            txtDescription.Dock = DockStyle.Fill;
            txtDescription.Font = new Font("Segoe UI", 11F);
            txtDescription.Location = new Point(33, 193);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(434, 74);
            txtDescription.TabIndex = 5;
            txtDescription.TextChanged += txtDescription_TextChanged;
            txtDescription.KeyPress += txtDescription_KeyPress;
            // 
            // pnBottom
            // 
            pnBottom.Controls.Add(btnClose);
            pnBottom.Controls.Add(btnAdd);
            pnBottom.Dock = DockStyle.Bottom;
            pnBottom.Location = new Point(0, 370);
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
            // FormAddFaculty
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 440);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pnBottom);
            Controls.Add(pnTop);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAddFaculty";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm Khoa";
            Load += FormAddFaculty_Load;
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
        private System.Windows.Forms.Label lblSchool;
        private System.Windows.Forms.ComboBox cbSchool;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Panel pnBottom;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
    }
}