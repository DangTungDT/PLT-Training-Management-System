namespace GUI.UserControls.Book
{
    partial class UcReadBook
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlTop = new Panel();
            picTop = new PictureBox();
            lblTitle = new Label();
            lblSubTitle = new Label();
            pnlMain = new Panel();
            pnlRight = new Panel();
            pnDataBook = new Panel();
            panel4 = new Panel();
            lbDescribe = new Label();
            label8 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label9 = new Label();
            lbISBN = new Label();
            lbAuthor = new Label();
            lbPublicYear = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            lbTotalView = new Label();
            lbUpLoadBy = new Label();
            lbDateUpLoad = new Label();
            label18 = new Label();
            label19 = new Label();
            lbTotalDownload = new Label();
            pnlRightFill = new Panel();
            flpFiles = new FlowLayoutPanel();
            panel3 = new Panel();
            panel2 = new Panel();
            lbTotalFilesSize = new Label();
            label6 = new Label();
            pnlAttachHeader = new Panel();
            lblTotalFiles = new Label();
            lblAttachLeft = new Label();
            pnlRightBottom = new Panel();
            panel1 = new Panel();
            btnDownload = new Guna.UI2.WinForms.Guna2Button();
            btnEdit = new Guna.UI2.WinForms.Guna2Button();
            pnlRightTop = new Panel();
            lblAttachmentTab = new Label();
            lblOverview = new Label();
            pnlLeft = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            lbCategory = new Label();
            label1 = new Label();
            label2 = new Label();
            lbTotalView2 = new Label();
            lbTotalDownload2 = new Label();
            label5 = new Label();
            picLeft = new PictureBox();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTop).BeginInit();
            pnlMain.SuspendLayout();
            pnlRight.SuspendLayout();
            pnDataBook.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            pnlRightFill.SuspendLayout();
            panel2.SuspendLayout();
            pnlAttachHeader.SuspendLayout();
            pnlRightBottom.SuspendLayout();
            panel1.SuspendLayout();
            pnlRightTop.SuspendLayout();
            pnlLeft.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLeft).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.White;
            pnlTop.BorderStyle = BorderStyle.FixedSingle;
            pnlTop.Controls.Add(picTop);
            pnlTop.Controls.Add(lblTitle);
            pnlTop.Controls.Add(lblSubTitle);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1076, 70);
            pnlTop.TabIndex = 1;
            // 
            // picTop
            // 
            picTop.BackColor = Color.FromArgb(239, 246, 255);
            picTop.Image = Properties.Resources.book;
            picTop.Location = new Point(20, 15);
            picTop.Name = "picTop";
            picTop.Size = new Size(40, 40);
            picTop.SizeMode = PictureBoxSizeMode.Zoom;
            picTop.TabIndex = 0;
            picTop.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(70, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(244, 32);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Cơ sở dữ liệu Oracle";
            // 
            // lblSubTitle
            // 
            lblSubTitle.AutoSize = true;
            lblSubTitle.Font = new Font("Segoe UI", 9F);
            lblSubTitle.Location = new Point(72, 40);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new Size(157, 20);
            lblSubTitle.TabIndex = 2;
            lblSubTitle.Text = "Chi tiết sách giáo trình";
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(pnlRight);
            pnlMain.Controls.Add(pnlLeft);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 70);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1076, 677);
            pnlMain.TabIndex = 0;
            // 
            // pnlRight
            // 
            pnlRight.BorderStyle = BorderStyle.FixedSingle;
            pnlRight.Controls.Add(pnDataBook);
            pnlRight.Controls.Add(pnlRightFill);
            pnlRight.Controls.Add(pnlRightBottom);
            pnlRight.Controls.Add(pnlRightTop);
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(322, 0);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(754, 677);
            pnlRight.TabIndex = 0;
            // 
            // pnDataBook
            // 
            pnDataBook.BackColor = Color.White;
            pnDataBook.Controls.Add(panel4);
            pnDataBook.Controls.Add(tableLayoutPanel2);
            pnDataBook.Dock = DockStyle.Fill;
            pnDataBook.Font = new Font("Times New Roman", 10.8F);
            pnDataBook.Location = new Point(0, 45);
            pnDataBook.Name = "pnDataBook";
            pnDataBook.Size = new Size(752, 570);
            pnDataBook.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Controls.Add(lbDescribe);
            panel4.Controls.Add(label8);
            panel4.Dock = DockStyle.Fill;
            panel4.Font = new Font("Times New Roman", 10.8F);
            panel4.Location = new Point(0, 277);
            panel4.Name = "panel4";
            panel4.Size = new Size(752, 293);
            panel4.TabIndex = 1;
            // 
            // lbDescribe
            // 
            lbDescribe.Dock = DockStyle.Fill;
            lbDescribe.Font = new Font("Times New Roman", 10.8F);
            lbDescribe.ForeColor = Color.Black;
            lbDescribe.Location = new Point(0, 38);
            lbDescribe.Name = "lbDescribe";
            lbDescribe.Size = new Size(752, 255);
            lbDescribe.TabIndex = 1;
            lbDescribe.Text = "Cuốn sách cung cấp kiến thức toàn diện về hệ quản trị cơ sở dữ liệu Oracle, từ cơ bản đến nâng cao. Nội dung bao gồm thiết kế cơ sở dữ liệu, SQL, PL/SQL, quản trị và tối ưu hóa hiệu suất.";
            // 
            // label8
            // 
            label8.Dock = DockStyle.Top;
            label8.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(752, 38);
            label8.TabIndex = 0;
            label8.Text = "Mô tả";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.3209553F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.54642F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.3103447F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.82228F));
            tableLayoutPanel2.Controls.Add(label9, 0, 1);
            tableLayoutPanel2.Controls.Add(lbISBN, 1, 2);
            tableLayoutPanel2.Controls.Add(lbAuthor, 1, 3);
            tableLayoutPanel2.Controls.Add(lbPublicYear, 1, 4);
            tableLayoutPanel2.Controls.Add(label10, 0, 4);
            tableLayoutPanel2.Controls.Add(label11, 0, 3);
            tableLayoutPanel2.Controls.Add(label12, 0, 2);
            tableLayoutPanel2.Controls.Add(label13, 2, 1);
            tableLayoutPanel2.Controls.Add(label14, 2, 2);
            tableLayoutPanel2.Controls.Add(label15, 2, 3);
            tableLayoutPanel2.Controls.Add(label16, 2, 4);
            tableLayoutPanel2.Controls.Add(label17, 2, 5);
            tableLayoutPanel2.Controls.Add(lbTotalView, 3, 5);
            tableLayoutPanel2.Controls.Add(lbUpLoadBy, 3, 4);
            tableLayoutPanel2.Controls.Add(lbDateUpLoad, 3, 3);
            tableLayoutPanel2.Controls.Add(label18, 3, 2);
            tableLayoutPanel2.Controls.Add(label19, 2, 6);
            tableLayoutPanel2.Controls.Add(lbTotalDownload, 3, 6);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Font = new Font("Times New Roman", 10.8F);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 7;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(752, 277);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label9.Location = new Point(3, 20);
            label9.Name = "label9";
            label9.Size = new Size(183, 25);
            label9.TabIndex = 0;
            label9.Text = "Thông tin cơ bản";
            // 
            // lbISBN
            // 
            lbISBN.AutoSize = true;
            lbISBN.Dock = DockStyle.Right;
            lbISBN.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            lbISBN.ForeColor = Color.Black;
            lbISBN.Location = new Point(221, 70);
            lbISBN.Name = "lbISBN";
            lbISBN.Size = new Size(150, 20);
            lbISBN.TabIndex = 0;
            lbISBN.Text = "978-604-0-12347-8";
            lbISBN.TextAlign = ContentAlignment.TopRight;
            // 
            // lbAuthor
            // 
            lbAuthor.AutoSize = true;
            lbAuthor.Dock = DockStyle.Right;
            lbAuthor.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            lbAuthor.ForeColor = Color.Black;
            lbAuthor.Location = new Point(216, 90);
            lbAuthor.Name = "lbAuthor";
            lbAuthor.Size = new Size(155, 20);
            lbAuthor.TabIndex = 0;
            lbAuthor.Text = "TS. Lê Văn Cường";
            lbAuthor.TextAlign = ContentAlignment.TopRight;
            // 
            // lbPublicYear
            // 
            lbPublicYear.AutoSize = true;
            lbPublicYear.Dock = DockStyle.Right;
            lbPublicYear.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            lbPublicYear.ForeColor = Color.Black;
            lbPublicYear.Location = new Point(326, 110);
            lbPublicYear.Name = "lbPublicYear";
            lbPublicYear.Size = new Size(45, 20);
            lbPublicYear.TabIndex = 0;
            lbPublicYear.Text = "2025";
            lbPublicYear.TextAlign = ContentAlignment.TopRight;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 10.8F);
            label10.ForeColor = Color.FromArgb(104, 116, 135);
            label10.Location = new Point(3, 110);
            label10.Name = "label10";
            label10.Size = new Size(110, 20);
            label10.TabIndex = 0;
            label10.Text = "Năm xuất bản";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 10.8F);
            label11.ForeColor = Color.FromArgb(104, 116, 135);
            label11.Location = new Point(3, 90);
            label11.Name = "label11";
            label11.Size = new Size(62, 20);
            label11.TabIndex = 0;
            label11.Text = "Tác giả";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 10.8F);
            label12.ForeColor = Color.FromArgb(104, 116, 135);
            label12.Location = new Point(3, 70);
            label12.Name = "label12";
            label12.Size = new Size(50, 20);
            label12.TabIndex = 0;
            label12.Text = "ISBN";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label13.Location = new Point(377, 20);
            label13.Name = "label13";
            label13.Size = new Size(203, 25);
            label13.TabIndex = 0;
            label13.Text = "Thông tin hệ thống";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 10.8F);
            label14.ForeColor = Color.FromArgb(104, 116, 135);
            label14.Location = new Point(377, 70);
            label14.Name = "label14";
            label14.Size = new Size(84, 20);
            label14.TabIndex = 0;
            label14.Text = "Danh mục";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Times New Roman", 10.8F);
            label15.ForeColor = Color.FromArgb(104, 116, 135);
            label15.Location = new Point(377, 90);
            label15.Name = "label15";
            label15.Size = new Size(95, 20);
            label15.TabIndex = 0;
            label15.Text = "Ngày tải lên";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Times New Roman", 10.8F);
            label16.ForeColor = Color.FromArgb(104, 116, 135);
            label16.Location = new Point(377, 110);
            label16.Name = "label16";
            label16.Size = new Size(102, 20);
            label16.TabIndex = 0;
            label16.Text = "Người tải lên";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Times New Roman", 10.8F);
            label17.ForeColor = Color.FromArgb(104, 116, 135);
            label17.Location = new Point(377, 130);
            label17.Name = "label17";
            label17.Size = new Size(80, 20);
            label17.TabIndex = 0;
            label17.Text = "Lượt xem";
            // 
            // lbTotalView
            // 
            lbTotalView.AutoSize = true;
            lbTotalView.Dock = DockStyle.Right;
            lbTotalView.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            lbTotalView.ForeColor = Color.Black;
            lbTotalView.Location = new Point(704, 130);
            lbTotalView.Name = "lbTotalView";
            lbTotalView.Size = new Size(45, 20);
            lbTotalView.TabIndex = 0;
            lbTotalView.Text = "1234";
            lbTotalView.TextAlign = ContentAlignment.TopRight;
            // 
            // lbUpLoadBy
            // 
            lbUpLoadBy.AutoSize = true;
            lbUpLoadBy.Dock = DockStyle.Right;
            lbUpLoadBy.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            lbUpLoadBy.ForeColor = Color.Black;
            lbUpLoadBy.Location = new Point(687, 110);
            lbUpLoadBy.Name = "lbUpLoadBy";
            lbUpLoadBy.Size = new Size(62, 20);
            lbUpLoadBy.TabIndex = 0;
            lbUpLoadBy.Text = "Admin";
            lbUpLoadBy.TextAlign = ContentAlignment.TopRight;
            // 
            // lbDateUpLoad
            // 
            lbDateUpLoad.AutoSize = true;
            lbDateUpLoad.Dock = DockStyle.Right;
            lbDateUpLoad.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            lbDateUpLoad.ForeColor = Color.Black;
            lbDateUpLoad.Location = new Point(658, 90);
            lbDateUpLoad.Name = "lbDateUpLoad";
            lbDateUpLoad.Size = new Size(91, 20);
            lbDateUpLoad.TabIndex = 0;
            lbDateUpLoad.Text = "15/03/2024";
            lbDateUpLoad.TextAlign = ContentAlignment.TopRight;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Dock = DockStyle.Right;
            label18.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            label18.ForeColor = Color.Black;
            label18.Location = new Point(622, 70);
            label18.Name = "label18";
            label18.Size = new Size(127, 20);
            label18.TabIndex = 0;
            label18.Text = "Sách giáo trình";
            label18.TextAlign = ContentAlignment.TopRight;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Times New Roman", 10.8F);
            label19.ForeColor = Color.FromArgb(104, 116, 135);
            label19.Location = new Point(377, 150);
            label19.Name = "label19";
            label19.Size = new Size(115, 20);
            label19.TabIndex = 0;
            label19.Text = "Lượt tải xuống";
            // 
            // lbTotalDownload
            // 
            lbTotalDownload.AutoSize = true;
            lbTotalDownload.Dock = DockStyle.Right;
            lbTotalDownload.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            lbTotalDownload.ForeColor = Color.Black;
            lbTotalDownload.Location = new Point(704, 150);
            lbTotalDownload.Name = "lbTotalDownload";
            lbTotalDownload.Size = new Size(45, 127);
            lbTotalDownload.TabIndex = 0;
            lbTotalDownload.Text = "1234";
            lbTotalDownload.TextAlign = ContentAlignment.TopRight;
            // 
            // pnlRightFill
            // 
            pnlRightFill.BackColor = Color.White;
            pnlRightFill.Controls.Add(flpFiles);
            pnlRightFill.Controls.Add(panel3);
            pnlRightFill.Controls.Add(panel2);
            pnlRightFill.Controls.Add(pnlAttachHeader);
            pnlRightFill.Dock = DockStyle.Fill;
            pnlRightFill.Location = new Point(0, 45);
            pnlRightFill.Name = "pnlRightFill";
            pnlRightFill.Size = new Size(752, 570);
            pnlRightFill.TabIndex = 0;
            pnlRightFill.Visible = false;
            // 
            // flpFiles
            // 
            flpFiles.AutoScroll = true;
            flpFiles.Dock = DockStyle.Fill;
            flpFiles.FlowDirection = FlowDirection.TopDown;
            flpFiles.Location = new Point(0, 32);
            flpFiles.Name = "flpFiles";
            flpFiles.Size = new Size(752, 402);
            flpFiles.TabIndex = 4;
            flpFiles.WrapContents = false;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 434);
            panel3.Name = "panel3";
            panel3.Size = new Size(752, 1);
            panel3.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(lbTotalFilesSize);
            panel2.Controls.Add(label6);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 435);
            panel2.Name = "panel2";
            panel2.Size = new Size(752, 135);
            panel2.TabIndex = 2;
            // 
            // lbTotalFilesSize
            // 
            lbTotalFilesSize.AutoSize = true;
            lbTotalFilesSize.Dock = DockStyle.Right;
            lbTotalFilesSize.Location = new Point(702, 0);
            lbTotalFilesSize.Name = "lbTotalFilesSize";
            lbTotalFilesSize.Size = new Size(50, 20);
            lbTotalFilesSize.TabIndex = 1;
            lbTotalFilesSize.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Left;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(127, 20);
            label6.TabIndex = 0;
            label6.Text = "Tổng dung lượng:";
            // 
            // pnlAttachHeader
            // 
            pnlAttachHeader.BackColor = Color.White;
            pnlAttachHeader.Controls.Add(lblTotalFiles);
            pnlAttachHeader.Controls.Add(lblAttachLeft);
            pnlAttachHeader.Dock = DockStyle.Top;
            pnlAttachHeader.Location = new Point(0, 0);
            pnlAttachHeader.Name = "pnlAttachHeader";
            pnlAttachHeader.Size = new Size(752, 32);
            pnlAttachHeader.TabIndex = 1;
            // 
            // lblTotalFiles
            // 
            lblTotalFiles.Dock = DockStyle.Right;
            lblTotalFiles.Location = new Point(652, 0);
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
            // pnlRightBottom
            // 
            pnlRightBottom.BackColor = Color.White;
            pnlRightBottom.Controls.Add(panel1);
            pnlRightBottom.Controls.Add(btnEdit);
            pnlRightBottom.Dock = DockStyle.Bottom;
            pnlRightBottom.Location = new Point(0, 615);
            pnlRightBottom.Name = "pnlRightBottom";
            pnlRightBottom.Size = new Size(752, 60);
            pnlRightBottom.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnDownload);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(406, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(346, 60);
            panel1.TabIndex = 3;
            // 
            // btnDownload
            // 
            btnDownload.BorderRadius = 10;
            btnDownload.CustomizableEdges = customizableEdges1;
            btnDownload.Font = new Font("Segoe UI", 9F);
            btnDownload.ForeColor = Color.White;
            btnDownload.Location = new Point(136, 12);
            btnDownload.Name = "btnDownload";
            btnDownload.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnDownload.Size = new Size(150, 40);
            btnDownload.TabIndex = 2;
            btnDownload.Text = "Tải xuống tất cả";
            // 
            // btnEdit
            // 
            btnEdit.BorderColor = Color.FromArgb(226, 230, 233);
            btnEdit.BorderRadius = 10;
            btnEdit.BorderThickness = 1;
            btnEdit.CustomizableEdges = customizableEdges3;
            btnEdit.FillColor = Color.FromArgb(248, 250, 252);
            btnEdit.Font = new Font("Segoe UI", 9F);
            btnEdit.ForeColor = Color.FromArgb(104, 116, 135);
            btnEdit.Location = new Point(20, 12);
            btnEdit.Name = "btnEdit";
            btnEdit.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnEdit.Size = new Size(125, 40);
            btnEdit.TabIndex = 0;
            btnEdit.Text = "Chỉnh sửa";
            btnEdit.Click += btnEdit_Click;
            // 
            // pnlRightTop
            // 
            pnlRightTop.BackColor = Color.White;
            pnlRightTop.BorderStyle = BorderStyle.FixedSingle;
            pnlRightTop.Controls.Add(lblAttachmentTab);
            pnlRightTop.Controls.Add(lblOverview);
            pnlRightTop.Dock = DockStyle.Top;
            pnlRightTop.Location = new Point(0, 0);
            pnlRightTop.Name = "pnlRightTop";
            pnlRightTop.Size = new Size(752, 45);
            pnlRightTop.TabIndex = 2;
            // 
            // lblAttachmentTab
            // 
            lblAttachmentTab.Dock = DockStyle.Left;
            lblAttachmentTab.ForeColor = Color.Black;
            lblAttachmentTab.Location = new Point(168, 0);
            lblAttachmentTab.Name = "lblAttachmentTab";
            lblAttachmentTab.Padding = new Padding(20, 12, 0, 0);
            lblAttachmentTab.Size = new Size(149, 43);
            lblAttachmentTab.TabIndex = 0;
            lblAttachmentTab.Text = "Tệp đính kèm";
            lblAttachmentTab.Click += lblAttachmentTab_Click;
            // 
            // lblOverview
            // 
            lblOverview.Dock = DockStyle.Left;
            lblOverview.ForeColor = Color.FromArgb(60, 131, 246);
            lblOverview.Location = new Point(0, 0);
            lblOverview.Name = "lblOverview";
            lblOverview.Padding = new Padding(20, 12, 0, 0);
            lblOverview.Size = new Size(168, 43);
            lblOverview.TabIndex = 1;
            lblOverview.Text = "Tổng quan";
            lblOverview.Click += lblOverview_Click;
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.White;
            pnlLeft.Controls.Add(tableLayoutPanel1);
            pnlLeft.Controls.Add(picLeft);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Padding = new Padding(20);
            pnlLeft.Size = new Size(322, 677);
            pnlLeft.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lbCategory, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(lbTotalView2, 1, 1);
            tableLayoutPanel1.Controls.Add(lbTotalDownload2, 1, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Location = new Point(23, 218);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.Size = new Size(279, 125);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // lbCategory
            // 
            lbCategory.AutoSize = true;
            lbCategory.Location = new Point(3, 0);
            lbCategory.Name = "lbCategory";
            lbCategory.Size = new Size(96, 20);
            lbCategory.TabIndex = 0;
            lbCategory.Text = "Cơ sở dữ liệu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(142, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "Đại học";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 50);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 0;
            label2.Text = "Lượt xem";
            // 
            // lbTotalView2
            // 
            lbTotalView2.AutoSize = true;
            lbTotalView2.Dock = DockStyle.Right;
            lbTotalView2.Location = new Point(235, 50);
            lbTotalView2.Name = "lbTotalView2";
            lbTotalView2.Size = new Size(41, 39);
            lbTotalView2.TabIndex = 0;
            lbTotalView2.Text = "3521";
            // 
            // lbTotalDownload2
            // 
            lbTotalDownload2.AutoSize = true;
            lbTotalDownload2.Dock = DockStyle.Right;
            lbTotalDownload2.Location = new Point(235, 89);
            lbTotalDownload2.Name = "lbTotalDownload2";
            lbTotalDownload2.Size = new Size(41, 36);
            lbTotalDownload2.TabIndex = 0;
            lbTotalDownload2.Text = "1247";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 89);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 0;
            label5.Text = "Lượt tải";
            // 
            // picLeft
            // 
            picLeft.BackColor = Color.FromArgb(248, 250, 252);
            picLeft.Dock = DockStyle.Top;
            picLeft.Image = Properties.Resources.book;
            picLeft.Location = new Point(20, 20);
            picLeft.Name = "picLeft";
            picLeft.Size = new Size(282, 180);
            picLeft.SizeMode = PictureBoxSizeMode.Zoom;
            picLeft.TabIndex = 6;
            picLeft.TabStop = false;
            // 
            // UcReadBook
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(pnlMain);
            Controls.Add(pnlTop);
            Name = "UcReadBook";
            Size = new Size(1076, 747);
            Load += UcReadBook_Load;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picTop).EndInit();
            pnlMain.ResumeLayout(false);
            pnlRight.ResumeLayout(false);
            pnDataBook.ResumeLayout(false);
            panel4.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            pnlRightFill.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlAttachHeader.ResumeLayout(false);
            pnlRightBottom.ResumeLayout(false);
            panel1.ResumeLayout(false);
            pnlRightTop.ResumeLayout(false);
            pnlLeft.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLeft).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlRightTop;
        private System.Windows.Forms.Panel pnlRightFill;

        private System.Windows.Forms.PictureBox picTop;
        private System.Windows.Forms.PictureBox picLeft;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblAttachmentTab;
        private System.Windows.Forms.Label lblOverview;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lbCategory;
        private Label label1;
        private Label label2;
        private Label lbTotalView2;
        private Label lbTotalDownload2;
        private Label label5;
        private Panel panel3;
        private Panel panel2;
        private Label lbTotalFilesSize;
        private Label label6;
        private Panel pnlAttachHeader;
        private Label lblTotalFiles;
        private Label lblAttachLeft;
        private Panel pnlRightBottom;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnDownload;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Panel pnDataBook;
        private Panel panel4;
        private Label lbDescribe;
        private Label label8;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label9;
        private Label lbISBN;
        private Label lbAuthor;
        private Label lbPublicYear;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label lbTotalView;
        private Label lbUpLoadBy;
        private Label lbDateUpLoad;
        private Label label18;
        private Label label19;
        private Label lbTotalDownload;
        private FlowLayoutPanel flpFiles;
    }
}
