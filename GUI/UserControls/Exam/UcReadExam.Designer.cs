using Guna.UI2.WinForms;

namespace GUI.UserControls.Exam
{
    partial class UcReadExam
    {
        private System.ComponentModel.IContainer components = null;

        #region Dispose
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }
        #endregion

        #region Designer fields

        private Panel panelHeader;
        private Panel panelHeaderLeft;
        private FlowLayoutPanel panelHeaderRight;

        private Guna2Button btnBack;
        private Guna2Button btnEdit;
        private Guna2Button btnDelete;
        private Guna2Button btnPublish;

        private Label lblTitle;
        private Label lblSubTitle;

        private Panel panelContent;

        private Panel panelExamInfo;
        private Label lblExamName;
        private Label lblExamMeta;
        private Label lblStatus;

        private TableLayoutPanel tlpStatistic;
        private Panel panelStatQuestion;
        private Panel panelStatScore;
        private Panel panelStatTime;
        private Panel panelStatAttempt;

        private Panel panelTabHeader;
        private Label lblTabOverview;
        private Label lblTabQuestion;

        private TableLayoutPanel tlpTabContent;

        #endregion

        #region Component Designer generated code

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
            panelHeader = new Panel();
            panelHeaderRight = new FlowLayoutPanel();
            btnEdit = new Guna2Button();
            btnDelete = new Guna2Button();
            btnPublish = new Guna2Button();
            panelHeaderLeft = new Panel();
            lblSubTitle = new Label();
            lblTitle = new Label();
            btnBack = new Guna2Button();
            panelContent = new Panel();
            tlpTabContent = new TableLayoutPanel();
            panelTabHeader = new Panel();
            lblTabQuestion = new Label();
            lblTabOverview = new Label();
            tlpStatistic = new TableLayoutPanel();
            panelStatQuestion = new Panel();
            panelStatScore = new Panel();
            panelStatTime = new Panel();
            panelStatAttempt = new Panel();
            panelExamInfo = new Panel();
            lblStatus = new Label();
            lblExamMeta = new Label();
            lblExamName = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label9 = new Label();
            label11 = new Label();
            label13 = new Label();
            label2 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label16 = new Label();
            label17 = new Label();
            label6 = new Label();
            label8 = new Label();
            panelHeader.SuspendLayout();
            panelHeaderRight.SuspendLayout();
            panelHeaderLeft.SuspendLayout();
            panelContent.SuspendLayout();
            tlpTabContent.SuspendLayout();
            panelTabHeader.SuspendLayout();
            tlpStatistic.SuspendLayout();
            panelExamInfo.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(panelHeaderRight);
            panelHeader.Controls.Add(panelHeaderLeft);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Padding = new Padding(16, 8, 16, 8);
            panelHeader.Size = new Size(1076, 60);
            panelHeader.TabIndex = 1;
            // 
            // panelHeaderRight
            // 
            panelHeaderRight.AutoSize = true;
            panelHeaderRight.Controls.Add(btnEdit);
            panelHeaderRight.Controls.Add(btnDelete);
            panelHeaderRight.Controls.Add(btnPublish);
            panelHeaderRight.Dock = DockStyle.Right;
            panelHeaderRight.Location = new Point(502, 8);
            panelHeaderRight.Name = "panelHeaderRight";
            panelHeaderRight.Size = new Size(558, 44);
            panelHeaderRight.TabIndex = 0;
            panelHeaderRight.WrapContents = false;
            // 
            // btnEdit
            // 
            btnEdit.BorderColor = Color.FromArgb(209, 213, 219);
            btnEdit.BorderRadius = 8;
            btnEdit.BorderThickness = 1;
            btnEdit.CustomizableEdges = customizableEdges1;
            btnEdit.FillColor = Color.White;
            btnEdit.Font = new Font("Segoe UI", 9F);
            btnEdit.ForeColor = Color.Black;
            btnEdit.Location = new Point(3, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnEdit.Size = new Size(180, 45);
            btnEdit.TabIndex = 0;
            btnEdit.Text = "Chỉnh sửa";
            // 
            // btnDelete
            // 
            btnDelete.BorderRadius = 8;
            btnDelete.CustomizableEdges = customizableEdges3;
            btnDelete.FillColor = Color.FromArgb(239, 68, 68);
            btnDelete.Font = new Font("Segoe UI", 9F);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(189, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnDelete.Size = new Size(180, 45);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Xóa";
            // 
            // btnPublish
            // 
            btnPublish.BorderRadius = 8;
            btnPublish.CustomizableEdges = customizableEdges5;
            btnPublish.FillColor = Color.FromArgb(34, 197, 94);
            btnPublish.Font = new Font("Segoe UI", 9F);
            btnPublish.ForeColor = Color.White;
            btnPublish.Location = new Point(375, 3);
            btnPublish.Name = "btnPublish";
            btnPublish.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnPublish.Size = new Size(180, 45);
            btnPublish.TabIndex = 2;
            btnPublish.Text = "Xuất bản";
            // 
            // panelHeaderLeft
            // 
            panelHeaderLeft.Controls.Add(lblSubTitle);
            panelHeaderLeft.Controls.Add(lblTitle);
            panelHeaderLeft.Controls.Add(btnBack);
            panelHeaderLeft.Dock = DockStyle.Left;
            panelHeaderLeft.Location = new Point(16, 8);
            panelHeaderLeft.Name = "panelHeaderLeft";
            panelHeaderLeft.Size = new Size(500, 44);
            panelHeaderLeft.TabIndex = 1;
            // 
            // lblSubTitle
            // 
            lblSubTitle.Dock = DockStyle.Top;
            lblSubTitle.ForeColor = Color.Gray;
            lblSubTitle.Location = new Point(40, 23);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new Size(460, 23);
            lblSubTitle.TabIndex = 0;
            lblSubTitle.Text = "Xem và quản lý thông tin đề thi";
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTitle.Location = new Point(40, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(460, 23);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Chi tiết đề thi";
            // 
            // btnBack
            // 
            btnBack.BorderRadius = 6;
            btnBack.CustomizableEdges = customizableEdges7;
            btnBack.Dock = DockStyle.Left;
            btnBack.FillColor = Color.Transparent;
            btnBack.Font = new Font("Segoe UI", 9F);
            btnBack.ForeColor = Color.Black;
            btnBack.Location = new Point(0, 0);
            btnBack.Name = "btnBack";
            btnBack.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnBack.Size = new Size(40, 44);
            btnBack.TabIndex = 2;
            btnBack.Text = "←";
            btnBack.Click += btnBack_Click;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(245, 247, 250);
            panelContent.Controls.Add(tlpTabContent);
            panelContent.Controls.Add(panelTabHeader);
            panelContent.Controls.Add(tlpStatistic);
            panelContent.Controls.Add(panelExamInfo);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 60);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(24);
            panelContent.Size = new Size(1076, 687);
            panelContent.TabIndex = 0;
            // 
            // tlpTabContent
            // 
            tlpTabContent.ColumnCount = 2;
            tlpTabContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tlpTabContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlpTabContent.Controls.Add(tableLayoutPanel2, 1, 0);
            tlpTabContent.Controls.Add(tableLayoutPanel1, 0, 0);
            tlpTabContent.Dock = DockStyle.Fill;
            tlpTabContent.Location = new Point(24, 274);
            tlpTabContent.Name = "tlpTabContent";
            tlpTabContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpTabContent.Size = new Size(1028, 389);
            tlpTabContent.TabIndex = 0;
            tlpTabContent.Paint += tlpTabContent_Paint;
            // 
            // panelTabHeader
            // 
            panelTabHeader.Controls.Add(lblTabQuestion);
            panelTabHeader.Controls.Add(lblTabOverview);
            panelTabHeader.Dock = DockStyle.Top;
            panelTabHeader.Location = new Point(24, 234);
            panelTabHeader.Name = "panelTabHeader";
            panelTabHeader.Size = new Size(1028, 40);
            panelTabHeader.TabIndex = 1;
            // 
            // lblTabQuestion
            // 
            lblTabQuestion.Dock = DockStyle.Left;
            lblTabQuestion.Location = new Point(100, 0);
            lblTabQuestion.Name = "lblTabQuestion";
            lblTabQuestion.Padding = new Padding(10);
            lblTabQuestion.Size = new Size(100, 40);
            lblTabQuestion.TabIndex = 0;
            lblTabQuestion.Text = "Câu hỏi (5)";
            // 
            // lblTabOverview
            // 
            lblTabOverview.Dock = DockStyle.Left;
            lblTabOverview.ForeColor = Color.FromArgb(59, 130, 246);
            lblTabOverview.Location = new Point(0, 0);
            lblTabOverview.Name = "lblTabOverview";
            lblTabOverview.Padding = new Padding(10);
            lblTabOverview.Size = new Size(100, 40);
            lblTabOverview.TabIndex = 1;
            lblTabOverview.Text = "Tổng quan";
            // 
            // tlpStatistic
            // 
            tlpStatistic.ColumnCount = 4;
            tlpStatistic.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpStatistic.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpStatistic.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpStatistic.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpStatistic.Controls.Add(panelStatQuestion, 0, 0);
            tlpStatistic.Controls.Add(panelStatScore, 1, 0);
            tlpStatistic.Controls.Add(panelStatTime, 2, 0);
            tlpStatistic.Controls.Add(panelStatAttempt, 3, 0);
            tlpStatistic.Dock = DockStyle.Top;
            tlpStatistic.Location = new Point(24, 144);
            tlpStatistic.Name = "tlpStatistic";
            tlpStatistic.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpStatistic.Size = new Size(1028, 90);
            tlpStatistic.TabIndex = 2;
            // 
            // panelStatQuestion
            // 
            panelStatQuestion.BackColor = Color.White;
            panelStatQuestion.Location = new Point(3, 3);
            panelStatQuestion.Name = "panelStatQuestion";
            panelStatQuestion.Size = new Size(200, 84);
            panelStatQuestion.TabIndex = 0;
            // 
            // panelStatScore
            // 
            panelStatScore.BackColor = Color.White;
            panelStatScore.Location = new Point(260, 3);
            panelStatScore.Name = "panelStatScore";
            panelStatScore.Size = new Size(200, 84);
            panelStatScore.TabIndex = 1;
            // 
            // panelStatTime
            // 
            panelStatTime.BackColor = Color.White;
            panelStatTime.Location = new Point(517, 3);
            panelStatTime.Name = "panelStatTime";
            panelStatTime.Size = new Size(200, 84);
            panelStatTime.TabIndex = 2;
            // 
            // panelStatAttempt
            // 
            panelStatAttempt.BackColor = Color.White;
            panelStatAttempt.Location = new Point(774, 3);
            panelStatAttempt.Name = "panelStatAttempt";
            panelStatAttempt.Size = new Size(200, 84);
            panelStatAttempt.TabIndex = 3;
            // 
            // panelExamInfo
            // 
            panelExamInfo.BackColor = Color.White;
            panelExamInfo.BorderStyle = BorderStyle.FixedSingle;
            panelExamInfo.Controls.Add(lblStatus);
            panelExamInfo.Controls.Add(lblExamMeta);
            panelExamInfo.Controls.Add(lblExamName);
            panelExamInfo.Dock = DockStyle.Top;
            panelExamInfo.Location = new Point(24, 24);
            panelExamInfo.Name = "panelExamInfo";
            panelExamInfo.Padding = new Padding(20);
            panelExamInfo.Size = new Size(1028, 120);
            panelExamInfo.TabIndex = 3;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.FromArgb(253, 230, 138);
            lblStatus.Location = new Point(0, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Padding = new Padding(6);
            lblStatus.Size = new Size(83, 32);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Bản nháp";
            // 
            // lblExamMeta
            // 
            lblExamMeta.Dock = DockStyle.Top;
            lblExamMeta.ForeColor = Color.Gray;
            lblExamMeta.Location = new Point(20, 43);
            lblExamMeta.Name = "lblExamMeta";
            lblExamMeta.Size = new Size(986, 23);
            lblExamMeta.TabIndex = 1;
            lblExamMeta.Text = "ID: DT001  •  Ngày tạo: 2024-01-15";
            // 
            // lblExamName
            // 
            lblExamName.Dock = DockStyle.Top;
            lblExamName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblExamName.Location = new Point(20, 20);
            lblExamName.Name = "lblExamName";
            lblExamName.Size = new Size(986, 23);
            lblExamName.TabIndex = 2;
            lblExamName.Text = "Kiểm tra giữa kỳ - Cơ sở dữ liệu";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label13, 0, 6);
            tableLayoutPanel1.Controls.Add(label11, 0, 5);
            tableLayoutPanel1.Controls.Add(label9, 0, 4);
            tableLayoutPanel1.Controls.Add(label7, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.Size = new Size(610, 383);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 0;
            label1.Text = "Thông tin chi tiết";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 50);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 2;
            label3.Text = "MÔN HỌC";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(308, 50);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 3;
            label4.Text = "TRƯỜNG";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 80);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 4;
            label5.Text = "label5";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 115);
            label7.Name = "label7";
            label7.Size = new Size(26, 20);
            label7.TabIndex = 6;
            label7.Text = "LA";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 145);
            label9.Name = "label9";
            label9.Size = new Size(50, 20);
            label9.TabIndex = 8;
            label9.Text = "label9";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 180);
            label11.Name = "label11";
            label11.Size = new Size(90, 20);
            label11.TabIndex = 10;
            label11.Text = "LOẠI ĐỀ THI";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(3, 210);
            label13.Name = "label13";
            label13.Size = new Size(58, 20);
            label13.TabIndex = 12;
            label13.Text = "label13";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(308, 80);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 13;
            label2.Text = "label2";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(label16, 0, 1);
            tableLayoutPanel2.Controls.Add(label17, 0, 0);
            tableLayoutPanel2.Controls.Add(label6, 0, 2);
            tableLayoutPanel2.Controls.Add(label8, 0, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(619, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(406, 383);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(3, 50);
            label16.Name = "label16";
            label16.Size = new Size(79, 20);
            label16.TabIndex = 2;
            label16.Text = "MÔN HỌC";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(3, 0);
            label17.Name = "label17";
            label17.Size = new Size(90, 20);
            label17.TabIndex = 0;
            label17.Text = "Mô tả đề thi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 191);
            label6.Name = "label6";
            label6.Size = new Size(138, 20);
            label6.TabIndex = 0;
            label6.Text = "Hướng dẫn làm bài";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 241);
            label8.Name = "label8";
            label8.Size = new Size(79, 20);
            label8.TabIndex = 2;
            label8.Text = "MÔN HỌC";
            // 
            // UcReadExam
            // 
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            Name = "UcReadExam";
            Size = new Size(1076, 747);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelHeaderRight.ResumeLayout(false);
            panelHeaderLeft.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            tlpTabContent.ResumeLayout(false);
            panelTabHeader.ResumeLayout(false);
            tlpStatistic.ResumeLayout(false);
            panelExamInfo.ResumeLayout(false);
            panelExamInfo.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label13;
        private Label label11;
        private Label label9;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label16;
        private Label label17;
        private Label label6;
        private Label label8;
    }
}
