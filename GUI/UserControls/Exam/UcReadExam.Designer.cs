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

        private TableLayoutPanel tlpStatistic;
        private Panel panelStatQuestion;
        private Panel panelStatScore;
        private Panel panelStatTime;
        private Panel panelStatAttempt;

        private Panel panelTabHeader;
        private Label lblTabOverview;
        private Label lblTabQuestion;

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
            tlpValueExam = new TableLayoutPanel();
            pnlRightFill = new Panel();
            flpFiles = new FlowLayoutPanel();
            panel3 = new Panel();
            panel4 = new Panel();
            lbTotalFilesSize = new Label();
            label2 = new Label();
            pnlAttachHeader = new Panel();
            lblTotalFiles = new Label();
            lblAttachLeft = new Label();
            tlpTabContent = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label16 = new Label();
            label17 = new Label();
            label6 = new Label();
            label8 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            lbTypeExam = new Label();
            label11 = new Label();
            lbClass = new Label();
            label7 = new Label();
            lbSubject = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            lbSchool = new Label();
            flpQuestion = new FlowLayoutPanel();
            panelTabHeader = new Panel();
            lblTabQuestion = new Label();
            lblTabOverview = new Label();
            tlpStatistic = new TableLayoutPanel();
            panelStatQuestion = new Panel();
            label12 = new Label();
            lbTotalQuestion = new Label();
            pictureBox1 = new PictureBox();
            panelStatScore = new Panel();
            label15 = new Label();
            lbTotalSocre = new Label();
            pictureBox2 = new PictureBox();
            panelStatTime = new Panel();
            label19 = new Label();
            lbTime = new Label();
            pictureBox3 = new PictureBox();
            panelStatAttempt = new Panel();
            label21 = new Label();
            lbLuocThi = new Label();
            pictureBox4 = new PictureBox();
            panelExamInfo = new Panel();
            label22 = new Label();
            panel1 = new Panel();
            lblExamMeta = new Label();
            lblExamName = new Label();
            panelHeader.SuspendLayout();
            panelHeaderRight.SuspendLayout();
            panelHeaderLeft.SuspendLayout();
            panelContent.SuspendLayout();
            tlpValueExam.SuspendLayout();
            pnlRightFill.SuspendLayout();
            panel4.SuspendLayout();
            pnlAttachHeader.SuspendLayout();
            tlpTabContent.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panelTabHeader.SuspendLayout();
            tlpStatistic.SuspendLayout();
            panelStatQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelStatScore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelStatTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panelStatAttempt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panelExamInfo.SuspendLayout();
            panel1.SuspendLayout();
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
            panelHeaderRight.Location = new Point(742, 8);
            panelHeaderRight.Name = "panelHeaderRight";
            panelHeaderRight.Size = new Size(318, 44);
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
            btnEdit.Size = new Size(100, 38);
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
            btnDelete.Location = new Point(109, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnDelete.Size = new Size(100, 38);
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
            btnPublish.Location = new Point(215, 3);
            btnPublish.Name = "btnPublish";
            btnPublish.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnPublish.Size = new Size(100, 38);
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
            btnBack.BorderThickness = 1;
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
            panelContent.BackgroundImage = Properties.Resources.Cardmoi_PLT_Trang;
            panelContent.BackgroundImageLayout = ImageLayout.Zoom;
            panelContent.Controls.Add(tlpValueExam);
            panelContent.Controls.Add(flpQuestion);
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
            // tlpValueExam
            // 
            tlpValueExam.BackColor = Color.Transparent;
            tlpValueExam.ColumnCount = 2;
            tlpValueExam.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tlpValueExam.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlpValueExam.Controls.Add(pnlRightFill, 1, 0);
            tlpValueExam.Controls.Add(tlpTabContent, 0, 0);
            tlpValueExam.Dock = DockStyle.Fill;
            tlpValueExam.Location = new Point(24, 274);
            tlpValueExam.Name = "tlpValueExam";
            tlpValueExam.RowCount = 1;
            tlpValueExam.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpValueExam.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpValueExam.Size = new Size(1028, 389);
            tlpValueExam.TabIndex = 2;
            // 
            // pnlRightFill
            // 
            pnlRightFill.BackColor = Color.Transparent;
            pnlRightFill.BorderStyle = BorderStyle.FixedSingle;
            pnlRightFill.Controls.Add(flpFiles);
            pnlRightFill.Controls.Add(panel3);
            pnlRightFill.Controls.Add(panel4);
            pnlRightFill.Controls.Add(pnlAttachHeader);
            pnlRightFill.Dock = DockStyle.Fill;
            pnlRightFill.Location = new Point(619, 3);
            pnlRightFill.Name = "pnlRightFill";
            pnlRightFill.Size = new Size(406, 383);
            pnlRightFill.TabIndex = 5;
            // 
            // flpFiles
            // 
            flpFiles.AutoScroll = true;
            flpFiles.Dock = DockStyle.Fill;
            flpFiles.FlowDirection = FlowDirection.TopDown;
            flpFiles.Location = new Point(0, 32);
            flpFiles.Name = "flpFiles";
            flpFiles.Size = new Size(404, 213);
            flpFiles.TabIndex = 4;
            flpFiles.WrapContents = false;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 245);
            panel3.Name = "panel3";
            panel3.Size = new Size(404, 1);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Controls.Add(lbTotalFilesSize);
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 246);
            panel4.Name = "panel4";
            panel4.Size = new Size(404, 135);
            panel4.TabIndex = 2;
            // 
            // lbTotalFilesSize
            // 
            lbTotalFilesSize.AutoSize = true;
            lbTotalFilesSize.Dock = DockStyle.Right;
            lbTotalFilesSize.Location = new Point(354, 0);
            lbTotalFilesSize.Name = "lbTotalFilesSize";
            lbTotalFilesSize.Size = new Size(50, 20);
            lbTotalFilesSize.TabIndex = 1;
            lbTotalFilesSize.Text = "label7";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 0;
            label2.Text = "Tổng dung lượng:";
            // 
            // pnlAttachHeader
            // 
            pnlAttachHeader.BackColor = Color.Transparent;
            pnlAttachHeader.Controls.Add(lblTotalFiles);
            pnlAttachHeader.Controls.Add(lblAttachLeft);
            pnlAttachHeader.Dock = DockStyle.Top;
            pnlAttachHeader.Location = new Point(0, 0);
            pnlAttachHeader.Name = "pnlAttachHeader";
            pnlAttachHeader.Size = new Size(404, 32);
            pnlAttachHeader.TabIndex = 1;
            // 
            // lblTotalFiles
            // 
            lblTotalFiles.Dock = DockStyle.Right;
            lblTotalFiles.Location = new Point(304, 0);
            lblTotalFiles.Name = "lblTotalFiles";
            lblTotalFiles.Padding = new Padding(0, 8, 20, 0);
            lblTotalFiles.Size = new Size(100, 32);
            lblTotalFiles.TabIndex = 0;
            lblTotalFiles.Text = "3 tệp";
            // 
            // lblAttachLeft
            // 
            lblAttachLeft.Dock = DockStyle.Left;
            lblAttachLeft.Location = new Point(0, 0);
            lblAttachLeft.Name = "lblAttachLeft";
            lblAttachLeft.Padding = new Padding(20, 8, 0, 0);
            lblAttachLeft.Size = new Size(186, 32);
            lblAttachLeft.TabIndex = 1;
            lblAttachLeft.Text = "Tệp đính kèm";
            // 
            // tlpTabContent
            // 
            tlpTabContent.ColumnCount = 2;
            tlpTabContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tlpTabContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlpTabContent.Controls.Add(tableLayoutPanel2, 1, 0);
            tlpTabContent.Controls.Add(tableLayoutPanel1, 0, 0);
            tlpTabContent.Dock = DockStyle.Fill;
            tlpTabContent.Location = new Point(3, 3);
            tlpTabContent.Name = "tlpTabContent";
            tlpTabContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpTabContent.Size = new Size(610, 383);
            tlpTabContent.TabIndex = 1;
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
            tableLayoutPanel2.Location = new Point(369, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(238, 377);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Dock = DockStyle.Fill;
            label16.ForeColor = Color.DimGray;
            label16.Location = new Point(3, 50);
            label16.Name = "label16";
            label16.Size = new Size(232, 138);
            label16.TabIndex = 2;
            label16.Text = "MÔN HỌC";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label17.Location = new Point(3, 0);
            label17.Name = "label17";
            label17.Size = new Size(146, 31);
            label17.TabIndex = 0;
            label17.Text = "Mô tả đề thi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label6.Location = new Point(3, 188);
            label6.Name = "label6";
            label6.Size = new Size(220, 31);
            label6.TabIndex = 0;
            label6.Text = "Hướng dẫn làm bài";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(3, 238);
            label8.Name = "label8";
            label8.Size = new Size(232, 139);
            label8.TabIndex = 2;
            label8.Text = "MÔN HỌC";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lbTypeExam, 0, 6);
            tableLayoutPanel1.Controls.Add(label11, 0, 5);
            tableLayoutPanel1.Controls.Add(lbClass, 0, 4);
            tableLayoutPanel1.Controls.Add(label7, 0, 3);
            tableLayoutPanel1.Controls.Add(lbSubject, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(lbSchool, 1, 2);
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
            tableLayoutPanel1.Size = new Size(360, 377);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // lbTypeExam
            // 
            lbTypeExam.AutoSize = true;
            lbTypeExam.ForeColor = Color.Black;
            lbTypeExam.Location = new Point(3, 210);
            lbTypeExam.Name = "lbTypeExam";
            lbTypeExam.Size = new Size(58, 20);
            lbTypeExam.TabIndex = 12;
            lbTypeExam.Text = "label13";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.DimGray;
            label11.Location = new Point(3, 180);
            label11.Name = "label11";
            label11.Size = new Size(90, 20);
            label11.TabIndex = 10;
            label11.Text = "LOẠI ĐỀ THI";
            // 
            // lbClass
            // 
            lbClass.AutoSize = true;
            lbClass.ForeColor = Color.Black;
            lbClass.Location = new Point(3, 145);
            lbClass.Name = "lbClass";
            lbClass.Size = new Size(50, 20);
            lbClass.TabIndex = 8;
            lbClass.Text = "label9";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(3, 115);
            label7.Name = "label7";
            label7.Size = new Size(34, 20);
            label7.TabIndex = 6;
            label7.Text = "Lớp";
            // 
            // lbSubject
            // 
            lbSubject.AutoSize = true;
            lbSubject.ForeColor = Color.Black;
            lbSubject.Location = new Point(3, 80);
            lbSubject.Name = "lbSubject";
            lbSubject.Size = new Size(50, 20);
            lbSubject.TabIndex = 4;
            lbSubject.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(183, 50);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 3;
            label4.Text = "TRƯỜNG";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(3, 50);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 2;
            label3.Text = "MÔN HỌC";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(163, 50);
            label1.TabIndex = 0;
            label1.Text = "Thông tin chi tiết";
            // 
            // lbSchool
            // 
            lbSchool.AutoSize = true;
            lbSchool.ForeColor = Color.Black;
            lbSchool.Location = new Point(183, 80);
            lbSchool.Name = "lbSchool";
            lbSchool.Size = new Size(50, 20);
            lbSchool.TabIndex = 13;
            lbSchool.Text = "label2";
            // 
            // flpQuestion
            // 
            flpQuestion.AutoScroll = true;
            flpQuestion.BackColor = Color.Transparent;
            flpQuestion.Dock = DockStyle.Fill;
            flpQuestion.FlowDirection = FlowDirection.TopDown;
            flpQuestion.Location = new Point(24, 274);
            flpQuestion.Margin = new Padding(0);
            flpQuestion.Name = "flpQuestion";
            flpQuestion.Padding = new Padding(20);
            flpQuestion.Size = new Size(1028, 389);
            flpQuestion.TabIndex = 3;
            flpQuestion.WrapContents = false;
            // 
            // panelTabHeader
            // 
            panelTabHeader.BackColor = Color.Transparent;
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
            lblTabQuestion.Size = new Size(118, 40);
            lblTabQuestion.TabIndex = 0;
            lblTabQuestion.Text = "Các câu hỏi";
            lblTabQuestion.Click += lblTabQuestion_Click;
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
            lblTabOverview.Click += lblTabOverview_Click;
            // 
            // tlpStatistic
            // 
            tlpStatistic.BackColor = Color.Transparent;
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
            panelStatQuestion.BorderStyle = BorderStyle.FixedSingle;
            panelStatQuestion.Controls.Add(label12);
            panelStatQuestion.Controls.Add(lbTotalQuestion);
            panelStatQuestion.Controls.Add(pictureBox1);
            panelStatQuestion.Location = new Point(3, 3);
            panelStatQuestion.Name = "panelStatQuestion";
            panelStatQuestion.Size = new Size(200, 84);
            panelStatQuestion.TabIndex = 0;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.DimGray;
            label12.Location = new Point(84, 49);
            label12.Name = "label12";
            label12.Size = new Size(59, 20);
            label12.TabIndex = 1;
            label12.Text = "Câu hỏi";
            // 
            // lbTotalQuestion
            // 
            lbTotalQuestion.AutoSize = true;
            lbTotalQuestion.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lbTotalQuestion.Location = new Point(84, 18);
            lbTotalQuestion.Name = "lbTotalQuestion";
            lbTotalQuestion.Size = new Size(92, 31);
            lbTotalQuestion.TabIndex = 1;
            lbTotalQuestion.Text = "label10";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.homework;
            pictureBox1.Location = new Point(18, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelStatScore
            // 
            panelStatScore.BackColor = Color.White;
            panelStatScore.BorderStyle = BorderStyle.FixedSingle;
            panelStatScore.Controls.Add(label15);
            panelStatScore.Controls.Add(lbTotalSocre);
            panelStatScore.Controls.Add(pictureBox2);
            panelStatScore.Location = new Point(260, 3);
            panelStatScore.Name = "panelStatScore";
            panelStatScore.Size = new Size(200, 84);
            panelStatScore.TabIndex = 1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.DimGray;
            label15.Location = new Point(101, 49);
            label15.Name = "label15";
            label15.Size = new Size(81, 20);
            label15.TabIndex = 1;
            label15.Text = "Tổng điểm";
            // 
            // lbTotalSocre
            // 
            lbTotalSocre.AutoSize = true;
            lbTotalSocre.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lbTotalSocre.Location = new Point(101, 19);
            lbTotalSocre.Name = "lbTotalSocre";
            lbTotalSocre.Size = new Size(92, 31);
            lbTotalSocre.TabIndex = 1;
            lbTotalSocre.Text = "label10";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.idea;
            pictureBox2.Location = new Point(28, 19);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panelStatTime
            // 
            panelStatTime.BackColor = Color.White;
            panelStatTime.BorderStyle = BorderStyle.FixedSingle;
            panelStatTime.Controls.Add(label19);
            panelStatTime.Controls.Add(lbTime);
            panelStatTime.Controls.Add(pictureBox3);
            panelStatTime.Location = new Point(517, 3);
            panelStatTime.Name = "panelStatTime";
            panelStatTime.Size = new Size(200, 84);
            panelStatTime.TabIndex = 2;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = Color.DimGray;
            label19.Location = new Point(102, 49);
            label19.Name = "label19";
            label19.Size = new Size(38, 20);
            label19.TabIndex = 1;
            label19.Text = "Phút";
            // 
            // lbTime
            // 
            lbTime.AutoSize = true;
            lbTime.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lbTime.Location = new Point(102, 19);
            lbTime.Name = "lbTime";
            lbTime.Size = new Size(92, 31);
            lbTime.TabIndex = 1;
            lbTime.Text = "label10";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.clock;
            pictureBox3.Location = new Point(34, 19);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // panelStatAttempt
            // 
            panelStatAttempt.BackColor = Color.White;
            panelStatAttempt.BorderStyle = BorderStyle.FixedSingle;
            panelStatAttempt.Controls.Add(label21);
            panelStatAttempt.Controls.Add(lbLuocThi);
            panelStatAttempt.Controls.Add(pictureBox4);
            panelStatAttempt.Location = new Point(774, 3);
            panelStatAttempt.Name = "panelStatAttempt";
            panelStatAttempt.Size = new Size(200, 84);
            panelStatAttempt.TabIndex = 3;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.ForeColor = Color.DimGray;
            label21.Location = new Point(93, 49);
            label21.Name = "label21";
            label21.Size = new Size(62, 20);
            label21.TabIndex = 1;
            label21.Text = "Lược thi";
            // 
            // lbLuocThi
            // 
            lbLuocThi.AutoSize = true;
            lbLuocThi.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lbLuocThi.Location = new Point(93, 19);
            lbLuocThi.Name = "lbLuocThi";
            lbLuocThi.Size = new Size(92, 31);
            lbLuocThi.TabIndex = 1;
            lbLuocThi.Text = "label10";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.login;
            pictureBox4.Location = new Point(22, 19);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(50, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // panelExamInfo
            // 
            panelExamInfo.BackColor = Color.White;
            panelExamInfo.BorderStyle = BorderStyle.FixedSingle;
            panelExamInfo.Controls.Add(label22);
            panelExamInfo.Controls.Add(panel1);
            panelExamInfo.Dock = DockStyle.Top;
            panelExamInfo.Location = new Point(24, 24);
            panelExamInfo.Name = "panelExamInfo";
            panelExamInfo.Padding = new Padding(20);
            panelExamInfo.Size = new Size(1028, 120);
            panelExamInfo.TabIndex = 3;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.FromArgb(255, 192, 128);
            label22.Dock = DockStyle.Right;
            label22.Location = new Point(948, 20);
            label22.Name = "label22";
            label22.Size = new Size(58, 20);
            label22.TabIndex = 1;
            label22.Text = "label22";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblExamMeta);
            panel1.Controls.Add(lblExamName);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(20, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(516, 78);
            panel1.TabIndex = 0;
            // 
            // lblExamMeta
            // 
            lblExamMeta.Dock = DockStyle.Top;
            lblExamMeta.ForeColor = Color.Gray;
            lblExamMeta.Location = new Point(0, 37);
            lblExamMeta.Name = "lblExamMeta";
            lblExamMeta.Size = new Size(516, 23);
            lblExamMeta.TabIndex = 3;
            lblExamMeta.Text = "ID: DT001  •  Ngày tạo: 2024-01-15";
            // 
            // lblExamName
            // 
            lblExamName.Dock = DockStyle.Top;
            lblExamName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblExamName.Location = new Point(0, 0);
            lblExamName.Name = "lblExamName";
            lblExamName.Size = new Size(516, 37);
            lblExamName.TabIndex = 4;
            lblExamName.Text = "Kiểm tra giữa kỳ - Cơ sở dữ liệu";
            // 
            // UcReadExam
            // 
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            Name = "UcReadExam";
            Size = new Size(1076, 747);
            Load += UcReadExam_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelHeaderRight.ResumeLayout(false);
            panelHeaderLeft.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            tlpValueExam.ResumeLayout(false);
            pnlRightFill.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            pnlAttachHeader.ResumeLayout(false);
            tlpTabContent.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panelTabHeader.ResumeLayout(false);
            tlpStatistic.ResumeLayout(false);
            panelStatQuestion.ResumeLayout(false);
            panelStatQuestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelStatScore.ResumeLayout(false);
            panelStatScore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelStatTime.ResumeLayout(false);
            panelStatTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panelStatAttempt.ResumeLayout(false);
            panelStatAttempt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panelExamInfo.ResumeLayout(false);
            panelExamInfo.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label12;
        private Label label15;
        private Label lbTotalSocre;
        private Label label19;
        private Label lbTime;
        private Label label21;
        private Label lbLuocThi;
        private Label lbTotalQuestion;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Panel panel1;
        private Label label22;
        private Label lblExamMeta;
        private Label lblExamName;
        private TableLayoutPanel tlpTabContent;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label16;
        private Label label17;
        private Label label6;
        private Label label8;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lbTypeExam;
        private Label label11;
        private Label lbClass;
        private Label label7;
        private Label lbSubject;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label lbSchool;
        private FlowLayoutPanel flpQuestion;
        private Panel pnlRightFill;
        private FlowLayoutPanel flpFiles;
        private Panel panel3;
        private Panel panel4;
        private Label lbTotalFilesSize;
        private Label label2;
        private Panel pnlAttachHeader;
        private Label lblTotalFiles;
        private Label lblAttachLeft;
        private TableLayoutPanel tlpValueExam;
    }
}
