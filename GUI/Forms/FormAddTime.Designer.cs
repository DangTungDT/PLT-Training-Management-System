namespace GUI.Forms
{
    partial class FormAddTime
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            cbEndTime = new Guna.UI2.WinForms.Guna2ComboBox();
            label2 = new Label();
            panel1 = new Panel();
            panel39 = new Panel();
            btnAdd = new Guna.UI2.WinForms.Guna2Button();
            panel38 = new Panel();
            btnClose = new Guna.UI2.WinForms.Guna2Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            cbStartTime = new Guna.UI2.WinForms.Guna2ComboBox();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel1.SuspendLayout();
            panel39.SuspendLayout();
            panel38.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(352, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(cbEndTime, 0, 1);
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 197);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(346, 188);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // cbEndTime
            // 
            cbEndTime.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbEndTime.BackColor = Color.Transparent;
            cbEndTime.BorderRadius = 10;
            cbEndTime.CustomizableEdges = customizableEdges1;
            cbEndTime.DrawMode = DrawMode.OwnerDrawFixed;
            cbEndTime.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEndTime.FillColor = Color.FromArgb(217, 217, 217);
            cbEndTime.FocusedColor = Color.FromArgb(94, 148, 255);
            cbEndTime.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbEndTime.Font = new Font("Times New Roman", 12F);
            cbEndTime.ForeColor = Color.Black;
            cbEndTime.ItemHeight = 30;
            cbEndTime.Location = new Point(3, 34);
            cbEndTime.Name = "cbEndTime";
            cbEndTime.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cbEndTime.Size = new Size(340, 36);
            cbEndTime.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(340, 31);
            label2.TabIndex = 0;
            label2.Text = "Thời gian kết thúc";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel39);
            panel1.Controls.Add(panel38);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 391);
            panel1.Name = "panel1";
            panel1.Size = new Size(346, 56);
            panel1.TabIndex = 2;
            // 
            // panel39
            // 
            panel39.Controls.Add(btnAdd);
            panel39.Dock = DockStyle.Right;
            panel39.Location = new Point(172, 0);
            panel39.Name = "panel39";
            panel39.Size = new Size(174, 56);
            panel39.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Transparent;
            btnAdd.BorderRadius = 10;
            btnAdd.CustomizableEdges = customizableEdges3;
            btnAdd.DisabledState.BorderColor = Color.DarkGray;
            btnAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdd.Font = new Font("Segoe UI", 9F);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(14, 7);
            btnAdd.Name = "btnAdd";
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAdd.Size = new Size(138, 40);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Xác nhận";
            btnAdd.Click += btnAdd_Click;
            // 
            // panel38
            // 
            panel38.Controls.Add(btnClose);
            panel38.Dock = DockStyle.Left;
            panel38.Location = new Point(0, 0);
            panel38.Name = "panel38";
            panel38.Size = new Size(180, 56);
            panel38.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.BorderRadius = 10;
            btnClose.BorderThickness = 1;
            btnClose.CustomizableEdges = customizableEdges5;
            btnClose.DisabledState.BorderColor = Color.DarkGray;
            btnClose.DisabledState.CustomBorderColor = Color.DarkGray;
            btnClose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnClose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnClose.FillColor = Color.White;
            btnClose.Font = new Font("Segoe UI", 9F);
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(9, 7);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnClose.Size = new Size(138, 40);
            btnClose.TabIndex = 4;
            btnClose.Text = "Huỷ";
            btnClose.Click += btnClose_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(cbStartTime, 0, 1);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(346, 188);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // cbStartTime
            // 
            cbStartTime.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbStartTime.BackColor = Color.Transparent;
            cbStartTime.BorderRadius = 10;
            cbStartTime.CustomizableEdges = customizableEdges7;
            cbStartTime.DrawMode = DrawMode.OwnerDrawFixed;
            cbStartTime.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStartTime.FillColor = Color.FromArgb(217, 217, 217);
            cbStartTime.FocusedColor = Color.FromArgb(94, 148, 255);
            cbStartTime.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbStartTime.Font = new Font("Times New Roman", 12F);
            cbStartTime.ForeColor = Color.Black;
            cbStartTime.ItemHeight = 30;
            cbStartTime.Location = new Point(3, 34);
            cbStartTime.Name = "cbStartTime";
            cbStartTime.ShadowDecoration.CustomizableEdges = customizableEdges8;
            cbStartTime.Size = new Size(340, 36);
            cbStartTime.TabIndex = 8;
            cbStartTime.SelectedIndexChanged += cbStartTime_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(340, 31);
            label1.TabIndex = 0;
            label1.Text = "Thời gian bắt đầu";
            // 
            // FormAddTime
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "FormAddTime";
            Text = "FormAddTime";
            Load += FormAddTime_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel39.ResumeLayout(false);
            panel38.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel39;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Panel panel38;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel3;
        private Guna.UI2.WinForms.Guna2ComboBox cbEndTime;
        private Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cbStartTime;
    }
}