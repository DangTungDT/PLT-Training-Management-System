namespace GUI.UserControls.Exam
{
    partial class UcExam
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

        #region Component Designer generated code

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            pbContentBottom = new Panel();
            pbContentLeft = new Panel();
            lbTotalExam = new Label();
            pbContentRight = new Panel();
            pnContentTop = new Panel();
            pnHeader = new Panel();
            panel4 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            cbCourse = new Guna.UI2.WinForms.Guna2ComboBox();
            cbSemester = new Guna.UI2.WinForms.Guna2ComboBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            cbSchool = new Guna.UI2.WinForms.Guna2ComboBox();
            panel2 = new Panel();
            panel1 = new Panel();
            btnAddExam = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            lbNameFunction = new Label();
            pbContent = new Panel();
            pbContentMain = new Panel();
            dgvExams = new DataGridView();
            colExamId = new DataGridViewTextBoxColumn();
            colExamName = new DataGridViewTextBoxColumn();
            colSubject = new DataGridViewTextBoxColumn();
            colSchool = new DataGridViewTextBoxColumn();
            colClassName = new DataGridViewTextBoxColumn();
            colExamType = new DataGridViewTextBoxColumn();
            colExamTime = new DataGridViewTextBoxColumn();
            colTotalQuestion = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colView = new DataGridViewImageColumn();
            colEdit = new DataGridViewImageColumn();
            colDelete = new DataGridViewImageColumn();
            pnContentTop.SuspendLayout();
            pnHeader.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            pbContent.SuspendLayout();
            pbContentMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExams).BeginInit();
            SuspendLayout();
            // 
            // pbContentBottom
            // 
            pbContentBottom.Dock = DockStyle.Bottom;
            pbContentBottom.Location = new Point(20, 353);
            pbContentBottom.Name = "pbContentBottom";
            pbContentBottom.Size = new Size(1036, 20);
            pbContentBottom.TabIndex = 2;
            // 
            // pbContentLeft
            // 
            pbContentLeft.Dock = DockStyle.Left;
            pbContentLeft.Location = new Point(0, 0);
            pbContentLeft.Name = "pbContentLeft";
            pbContentLeft.Size = new Size(20, 373);
            pbContentLeft.TabIndex = 0;
            // 
            // lbTotalExam
            // 
            lbTotalExam.AutoSize = true;
            lbTotalExam.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotalExam.Location = new Point(6, 3);
            lbTotalExam.Name = "lbTotalExam";
            lbTotalExam.Size = new Size(301, 46);
            lbTotalExam.TabIndex = 0;
            lbTotalExam.Text = "Danh sách đề thi: ";
            // 
            // pbContentRight
            // 
            pbContentRight.Dock = DockStyle.Right;
            pbContentRight.Location = new Point(1056, 0);
            pbContentRight.Name = "pbContentRight";
            pbContentRight.Size = new Size(20, 373);
            pbContentRight.TabIndex = 1;
            // 
            // pnContentTop
            // 
            pnContentTop.Controls.Add(lbTotalExam);
            pnContentTop.Dock = DockStyle.Top;
            pnContentTop.Location = new Point(0, 0);
            pnContentTop.Name = "pnContentTop";
            pnContentTop.Size = new Size(1036, 65);
            pnContentTop.TabIndex = 0;
            // 
            // pnHeader
            // 
            pnHeader.Controls.Add(panel4);
            pnHeader.Controls.Add(label1);
            pnHeader.Controls.Add(lbNameFunction);
            pnHeader.Dock = DockStyle.Top;
            pnHeader.Location = new Point(0, 0);
            pnHeader.Name = "pnHeader";
            pnHeader.Size = new Size(1076, 158);
            pnHeader.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(tableLayoutPanel1);
            panel4.Controls.Add(panel2);
            panel4.Controls.Add(panel1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 95);
            panel4.Name = "panel4";
            panel4.Size = new Size(1076, 63);
            panel4.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(cbCourse, 2, 1);
            tableLayoutPanel1.Controls.Add(cbSemester, 1, 1);
            tableLayoutPanel1.Controls.Add(label5, 0, 0);
            tableLayoutPanel1.Controls.Add(label4, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 2, 0);
            tableLayoutPanel1.Controls.Add(cbSchool, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(20, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(592, 63);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // cbCourse
            // 
            cbCourse.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbCourse.BackColor = Color.Transparent;
            cbCourse.BorderRadius = 10;
            cbCourse.CustomizableEdges = customizableEdges1;
            cbCourse.DrawMode = DrawMode.OwnerDrawFixed;
            cbCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCourse.FillColor = Color.FromArgb(217, 217, 217);
            cbCourse.FocusedColor = Color.FromArgb(94, 148, 255);
            cbCourse.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbCourse.Font = new Font("Times New Roman", 12F);
            cbCourse.ForeColor = Color.Black;
            cbCourse.ItemHeight = 30;
            cbCourse.Location = new Point(397, 23);
            cbCourse.Name = "cbCourse";
            cbCourse.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cbCourse.Size = new Size(192, 36);
            cbCourse.TabIndex = 14;
            cbCourse.SelectedIndexChanged += cbCourse_SelectedIndexChanged;
            // 
            // cbSemester
            // 
            cbSemester.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbSemester.BackColor = Color.Transparent;
            cbSemester.BorderRadius = 10;
            cbSemester.CustomizableEdges = customizableEdges3;
            cbSemester.DrawMode = DrawMode.OwnerDrawFixed;
            cbSemester.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSemester.FillColor = Color.FromArgb(217, 217, 217);
            cbSemester.FocusedColor = Color.FromArgb(94, 148, 255);
            cbSemester.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbSemester.Font = new Font("Times New Roman", 12F);
            cbSemester.ForeColor = Color.Black;
            cbSemester.ItemHeight = 30;
            cbSemester.Location = new Point(200, 23);
            cbSemester.Name = "cbSemester";
            cbSemester.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cbSemester.Size = new Size(191, 36);
            cbSemester.TabIndex = 13;
            cbSemester.SelectedIndexChanged += cbSemester_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 10;
            label5.Text = "Trường";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(200, 0);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 11;
            label4.Text = "Học kỳ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(397, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 12;
            label2.Text = "Môn học";
            // 
            // cbSchool
            // 
            cbSchool.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbSchool.BackColor = Color.Transparent;
            cbSchool.BorderRadius = 10;
            cbSchool.CustomizableEdges = customizableEdges5;
            cbSchool.DrawMode = DrawMode.OwnerDrawFixed;
            cbSchool.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSchool.FillColor = Color.FromArgb(217, 217, 217);
            cbSchool.FocusedColor = Color.FromArgb(94, 148, 255);
            cbSchool.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbSchool.Font = new Font("Times New Roman", 12F);
            cbSchool.ForeColor = Color.Black;
            cbSchool.ItemHeight = 30;
            cbSchool.Location = new Point(3, 23);
            cbSchool.Name = "cbSchool";
            cbSchool.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cbSchool.Size = new Size(191, 36);
            cbSchool.TabIndex = 7;
            cbSchool.SelectedIndexChanged += cbSchool_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(20, 63);
            panel2.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAddExam);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(612, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(464, 63);
            panel1.TabIndex = 4;
            // 
            // btnAddExam
            // 
            btnAddExam.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddExam.BackColor = Color.Transparent;
            btnAddExam.BorderRadius = 8;
            btnAddExam.CustomizableEdges = customizableEdges7;
            btnAddExam.FillColor = Color.FromArgb(59, 130, 246);
            btnAddExam.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAddExam.ForeColor = Color.White;
            btnAddExam.Image = Properties.Resources.add;
            btnAddExam.ImageAlign = HorizontalAlignment.Left;
            btnAddExam.Location = new Point(254, 23);
            btnAddExam.Margin = new Padding(3, 4, 3, 4);
            btnAddExam.Name = "btnAddExam";
            btnAddExam.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnAddExam.Size = new Size(190, 36);
            btnAddExam.TabIndex = 3;
            btnAddExam.TabStop = false;
            btnAddExam.Text = "Tạo đề thi mới";
            btnAddExam.Click += btnAddExam_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(104, 116, 135);
            label1.Location = new Point(0, 64);
            label1.Name = "label1";
            label1.Padding = new Padding(20, 0, 0, 0);
            label1.Size = new Size(573, 31);
            label1.TabIndex = 1;
            label1.Text = "Tạo, chỉnh sửa và quản lý các đề thi cho các môn học";
            // 
            // lbNameFunction
            // 
            lbNameFunction.Dock = DockStyle.Top;
            lbNameFunction.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNameFunction.Location = new Point(0, 0);
            lbNameFunction.Name = "lbNameFunction";
            lbNameFunction.Padding = new Padding(10, 0, 0, 0);
            lbNameFunction.Size = new Size(1076, 64);
            lbNameFunction.TabIndex = 0;
            lbNameFunction.Text = "Quản lý đề thi";
            // 
            // pbContent
            // 
            pbContent.Controls.Add(pbContentMain);
            pbContent.Controls.Add(pbContentBottom);
            pbContent.Controls.Add(pbContentRight);
            pbContent.Controls.Add(pbContentLeft);
            pbContent.Dock = DockStyle.Fill;
            pbContent.Location = new Point(0, 158);
            pbContent.Name = "pbContent";
            pbContent.Size = new Size(1076, 373);
            pbContent.TabIndex = 3;
            // 
            // pbContentMain
            // 
            pbContentMain.BackColor = Color.White;
            pbContentMain.Controls.Add(dgvExams);
            pbContentMain.Controls.Add(pnContentTop);
            pbContentMain.Dock = DockStyle.Fill;
            pbContentMain.Location = new Point(20, 0);
            pbContentMain.Name = "pbContentMain";
            pbContentMain.Size = new Size(1036, 353);
            pbContentMain.TabIndex = 3;
            // 
            // dgvExams
            // 
            dgvExams.AllowUserToAddRows = false;
            dgvExams.AllowUserToDeleteRows = false;
            dgvExams.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvExams.BackgroundColor = Color.White;
            dgvExams.BorderStyle = BorderStyle.None;
            dgvExams.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvExams.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvExams.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvExams.ColumnHeadersHeight = 55;
            dgvExams.Columns.AddRange(new DataGridViewColumn[] { colExamId, colExamName, colSubject, colSchool, colClassName, colExamType, colExamTime, colTotalQuestion, colStatus, colView, colEdit, colDelete });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Times New Roman", 10F);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(128, 255, 255);
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvExams.DefaultCellStyle = dataGridViewCellStyle7;
            dgvExams.Dock = DockStyle.Fill;
            dgvExams.EnableHeadersVisualStyles = false;
            dgvExams.GridColor = Color.FromArgb(217, 217, 217);
            dgvExams.Location = new Point(0, 65);
            dgvExams.MultiSelect = false;
            dgvExams.Name = "dgvExams";
            dgvExams.ReadOnly = true;
            dgvExams.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvExams.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvExams.RowHeadersVisible = false;
            dgvExams.RowHeadersWidth = 51;
            dgvExams.RowTemplate.Height = 40;
            dgvExams.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvExams.Size = new Size(1036, 288);
            dgvExams.TabIndex = 0;
            dgvExams.CellClick += dgvExams_CellClick;
            // 
            // colExamId
            // 
            colExamId.HeaderText = "ExamId";
            colExamId.MinimumWidth = 6;
            colExamId.Name = "colExamId";
            colExamId.ReadOnly = true;
            colExamId.Visible = false;
            // 
            // colExamName
            // 
            colExamName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colExamName.FillWeight = 20F;
            colExamName.HeaderText = "TÊN ĐỀ THI";
            colExamName.MinimumWidth = 6;
            colExamName.Name = "colExamName";
            colExamName.ReadOnly = true;
            // 
            // colSubject
            // 
            colSubject.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colSubject.FillWeight = 16F;
            colSubject.HeaderText = "MÔN HỌC";
            colSubject.MinimumWidth = 6;
            colSubject.Name = "colSubject";
            colSubject.ReadOnly = true;
            // 
            // colSchool
            // 
            colSchool.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colSchool.FillWeight = 15F;
            colSchool.HeaderText = "TRƯỜNG";
            colSchool.MinimumWidth = 6;
            colSchool.Name = "colSchool";
            colSchool.ReadOnly = true;
            // 
            // colClassName
            // 
            colClassName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colClassName.DefaultCellStyle = dataGridViewCellStyle2;
            colClassName.HeaderText = "LỚP";
            colClassName.MinimumWidth = 6;
            colClassName.Name = "colClassName";
            colClassName.ReadOnly = true;
            colClassName.Width = 150;
            // 
            // colExamType
            // 
            colExamType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colExamType.DefaultCellStyle = dataGridViewCellStyle3;
            colExamType.FillWeight = 10F;
            colExamType.HeaderText = "LOẠI ĐỀ";
            colExamType.MinimumWidth = 6;
            colExamType.Name = "colExamType";
            colExamType.ReadOnly = true;
            // 
            // colExamTime
            // 
            colExamTime.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colExamTime.DefaultCellStyle = dataGridViewCellStyle4;
            colExamTime.HeaderText = "THỜI GIAN";
            colExamTime.MinimumWidth = 6;
            colExamTime.Name = "colExamTime";
            colExamTime.ReadOnly = true;
            colExamTime.Width = 120;
            // 
            // colTotalQuestion
            // 
            colTotalQuestion.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colTotalQuestion.DefaultCellStyle = dataGridViewCellStyle5;
            colTotalQuestion.HeaderText = "SỐ CÂU";
            colTotalQuestion.MinimumWidth = 6;
            colTotalQuestion.Name = "colTotalQuestion";
            colTotalQuestion.ReadOnly = true;
            colTotalQuestion.Width = 120;
            // 
            // colStatus
            // 
            colStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colStatus.DefaultCellStyle = dataGridViewCellStyle6;
            colStatus.HeaderText = "TRẠNG THÁI";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.Width = 120;
            // 
            // colView
            // 
            colView.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colView.HeaderText = "";
            colView.MinimumWidth = 6;
            colView.Name = "colView";
            colView.ReadOnly = true;
            colView.Resizable = DataGridViewTriState.True;
            colView.SortMode = DataGridViewColumnSortMode.Automatic;
            colView.Width = 90;
            // 
            // colEdit
            // 
            colEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colEdit.HeaderText = "";
            colEdit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colEdit.MinimumWidth = 6;
            colEdit.Name = "colEdit";
            colEdit.ReadOnly = true;
            colEdit.ToolTipText = "Sửa";
            colEdit.Width = 90;
            // 
            // colDelete
            // 
            colDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colDelete.HeaderText = "";
            colDelete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colDelete.MinimumWidth = 6;
            colDelete.Name = "colDelete";
            colDelete.ReadOnly = true;
            colDelete.ToolTipText = "Xóa";
            colDelete.Width = 90;
            // 
            // UcExam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pbContent);
            Controls.Add(pnHeader);
            Name = "UcExam";
            Size = new Size(1076, 531);
            Load += UcExam_Load;
            pnContentTop.ResumeLayout(false);
            pnContentTop.PerformLayout();
            pnHeader.ResumeLayout(false);
            pnHeader.PerformLayout();
            panel4.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            pbContent.ResumeLayout(false);
            pbContentMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvExams).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pbContentBottom;
        private Panel pbContentLeft;
        private Label lbTotalExam;
        private Panel pbContentRight;
        private Panel pnContentTop;
        private Panel pnHeader;
        private Label label1;
        private Label lbNameFunction;
        private Panel pbContent;
        private Panel pbContentMain;
        private DataGridView dgvExams;
        private Panel panel4;
        private Guna.UI2.WinForms.Guna2Button btnAddExam;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label5;
        private Label label4;
        private Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cbSchool;
        private Panel panel2;
        private DataGridViewTextBoxColumn colExamId;
        private DataGridViewTextBoxColumn colExamName;
        private DataGridViewTextBoxColumn colSubject;
        private DataGridViewTextBoxColumn colSchool;
        private DataGridViewTextBoxColumn colClassName;
        private DataGridViewTextBoxColumn colExamType;
        private DataGridViewTextBoxColumn colExamTime;
        private DataGridViewTextBoxColumn colTotalQuestion;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewImageColumn colView;
        private DataGridViewImageColumn colEdit;
        private DataGridViewImageColumn colDelete;
        private Guna.UI2.WinForms.Guna2ComboBox cbSemester;
        private Guna.UI2.WinForms.Guna2ComboBox cbCourse;
    }
}
