namespace GUI.Forms
{
    partial class FormAddSchool
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
            lblShortName = new Label();
            txtShortName = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
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
            lblTitle.Text = "Tạo Trường Học Mới";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblName, 0, 0);
            tableLayoutPanel1.Controls.Add(txtName, 0, 1);
            tableLayoutPanel1.Controls.Add(lblShortName, 0, 2);
            tableLayoutPanel1.Controls.Add(txtShortName, 0, 3);
            tableLayoutPanel1.Controls.Add(lblAddress, 0, 4);
            tableLayoutPanel1.Controls.Add(txtAddress, 0, 5);
            tableLayoutPanel1.Controls.Add(lblEmail, 0, 6);
            tableLayoutPanel1.Controls.Add(txtEmail, 0, 7);
            tableLayoutPanel1.Controls.Add(lblPhone, 0, 8);
            tableLayoutPanel1.Controls.Add(txtPhone, 0, 9);
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
            lblName.Size = new Size(139, 28);
            lblName.TabIndex = 0;
            lblName.Text = "Nhập tên trường";
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
            // lblShortName
            // 
            lblShortName.AutoSize = true;
            lblShortName.Font = new Font("Segoe UI", 10F);
            lblShortName.Location = new Point(33, 90);
            lblShortName.Name = "lblShortName";
            lblShortName.Padding = new Padding(0, 5, 0, 0);
            lblShortName.Size = new Size(140, 28);
            lblShortName.TabIndex = 2;
            lblShortName.Text = "Nhập tên viết tắt";
            // 
            // txtShortName
            // 
            txtShortName.Dock = DockStyle.Fill;
            txtShortName.Font = new Font("Segoe UI", 11F);
            txtShortName.Location = new Point(33, 123);
            txtShortName.Name = "txtShortName";
            txtShortName.Size = new Size(434, 32);
            txtShortName.TabIndex = 3;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 10F);
            lblAddress.Location = new Point(33, 160);
            lblAddress.Name = "lblAddress";
            lblAddress.Padding = new Padding(0, 5, 0, 0);
            lblAddress.Size = new Size(107, 28);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Nhập địa chỉ";
            // 
            // txtAddress
            // 
            txtAddress.Dock = DockStyle.Fill;
            txtAddress.Font = new Font("Segoe UI", 11F);
            txtAddress.Location = new Point(33, 193);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(434, 32);
            txtAddress.TabIndex = 5;
            txtAddress.TextChanged += txtAddress_TextChanged;
            txtAddress.KeyPress += txtAddress_KeyPress;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.Location = new Point(33, 230);
            lblEmail.Name = "lblEmail";
            lblEmail.Padding = new Padding(0, 5, 0, 0);
            lblEmail.Size = new Size(98, 28);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Nhập Email";
            // 
            // txtEmail
            // 
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.Location = new Point(33, 263);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(434, 32);
            txtEmail.TabIndex = 7;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 10F);
            lblPhone.Location = new Point(33, 300);
            lblPhone.Name = "lblPhone";
            lblPhone.Padding = new Padding(0, 5, 0, 0);
            lblPhone.Size = new Size(156, 28);
            lblPhone.TabIndex = 8;
            lblPhone.Text = "Nhập số điện thoại";
            // 
            // txtPhone
            // 
            txtPhone.Dock = DockStyle.Fill;
            txtPhone.Font = new Font("Segoe UI", 11F);
            txtPhone.Location = new Point(33, 333);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(434, 32);
            txtPhone.TabIndex = 9;
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
            // FormAddSchool
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
            Name = "FormAddSchool";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm Trường Học";
            Load += FormAddSchool_Load;
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
        private System.Windows.Forms.Label lblShortName;
        private System.Windows.Forms.TextBox txtShortName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Panel pnBottom;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
    }
}