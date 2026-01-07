using static Guna.UI2.WinForms.Suite.Descriptions;
using static System.Net.Mime.MediaTypeNames;

namespace GUI.Forms
{
    partial class FormDatabaseConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Label lblInstance;
        private System.Windows.Forms.Label lblAuth;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtInstance;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;

        private System.Windows.Forms.RadioButton rbWindowsAuth;
        private System.Windows.Forms.RadioButton rbSqlAuth;

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblServer = new Label();
            lblInstance = new Label();
            lblAuth = new Label();
            lblUser = new Label();
            lblPassword = new Label();
            txtInstance = new TextBox();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            rbWindowsAuth = new RadioButton();
            rbSqlAuth = new RadioButton();
            btnSave = new Button();
            btnCancel = new Button();
            cbServerName = new ComboBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitle.Location = new Point(23, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(226, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Cấu hình Cơ sở dữ liệu";
            // 
            // lblServer
            // 
            lblServer.AutoSize = true;
            lblServer.Location = new Point(23, 73);
            lblServer.Name = "lblServer";
            lblServer.Size = new Size(91, 20);
            lblServer.TabIndex = 1;
            lblServer.Text = "Server name";
            // 
            // lblInstance
            // 
            lblInstance.AutoSize = true;
            lblInstance.Location = new Point(23, 120);
            lblInstance.Name = "lblInstance";
            lblInstance.Size = new Size(121, 20);
            lblInstance.TabIndex = 3;
            lblInstance.Text = "Instance (nếu có)";
            // 
            // lblAuth
            // 
            lblAuth.AutoSize = true;
            lblAuth.Location = new Point(23, 167);
            lblAuth.Name = "lblAuth";
            lblAuth.Size = new Size(66, 20);
            lblAuth.TabIndex = 5;
            lblAuth.Text = "Xác thực";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(23, 247);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(38, 20);
            lblUser.TabIndex = 8;
            lblUser.Text = "User";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(23, 293);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 10;
            lblPassword.Text = "Password";
            // 
            // txtInstance
            // 
            txtInstance.Location = new Point(171, 116);
            txtInstance.Margin = new Padding(3, 4, 3, 4);
            txtInstance.Name = "txtInstance";
            txtInstance.Size = new Size(262, 27);
            txtInstance.TabIndex = 4;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(171, 243);
            txtUser.Margin = new Padding(3, 4, 3, 4);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(262, 27);
            txtUser.TabIndex = 9;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(171, 289);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(262, 27);
            txtPassword.TabIndex = 11;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // rbWindowsAuth
            // 
            rbWindowsAuth.AutoSize = true;
            rbWindowsAuth.Location = new Point(171, 164);
            rbWindowsAuth.Margin = new Padding(3, 4, 3, 4);
            rbWindowsAuth.Name = "rbWindowsAuth";
            rbWindowsAuth.Size = new Size(192, 24);
            rbWindowsAuth.TabIndex = 6;
            rbWindowsAuth.Text = "Windows Authentication";
            // 
            // rbSqlAuth
            // 
            rbSqlAuth.AutoSize = true;
            rbSqlAuth.Location = new Point(171, 197);
            rbSqlAuth.Margin = new Padding(3, 4, 3, 4);
            rbSqlAuth.Name = "rbSqlAuth";
            rbSqlAuth.Size = new Size(202, 24);
            rbSqlAuth.TabIndex = 7;
            rbSqlAuth.Text = "SQL Server Authentication";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(171, 347);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(114, 40);
            btnSave.TabIndex = 12;
            btnSave.Text = "Lưu";
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(320, 347);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(114, 40);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Hủy";
            btnCancel.Click += btnCancel_Click;
            // 
            // cbServerName
            // 
            cbServerName.FormattingEnabled = true;
            cbServerName.Location = new Point(171, 70);
            cbServerName.Name = "cbServerName";
            cbServerName.Size = new Size(263, 28);
            cbServerName.TabIndex = 14;
            // 
            // FormDatabaseConfig
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 427);
            Controls.Add(cbServerName);
            Controls.Add(lblTitle);
            Controls.Add(lblServer);
            Controls.Add(lblInstance);
            Controls.Add(txtInstance);
            Controls.Add(lblAuth);
            Controls.Add(rbWindowsAuth);
            Controls.Add(rbSqlAuth);
            Controls.Add(lblUser);
            Controls.Add(txtUser);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDatabaseConfig";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Database Configuration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbServerName;
    }
}
