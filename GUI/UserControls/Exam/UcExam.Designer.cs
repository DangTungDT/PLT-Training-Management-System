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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pbContentBottom = new Panel();
            pbContentLeft = new Panel();
            lbTotalExam = new Label();
            pbContentRight = new Panel();
            panelContentHeader = new Panel();
            pnHeader = new Panel();
            panel4 = new Panel();
            btnAddExam = new Guna.UI2.WinForms.Guna2Button();
            panel5 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            btnSubject = new Guna.UI2.WinForms.Guna2ComboBox();
            btnSchool = new Guna.UI2.WinForms.Guna2ComboBox();
            cbYearCourse = new Guna.UI2.WinForms.Guna2ComboBox();
            label1 = new Label();
            lbNameFunction = new Label();
            pbContent = new Panel();
            pbContentMain = new Panel();
            dgvExams = new DataGridView();
            colExamName = new DataGridViewTextBoxColumn();
            colSubject = new DataGridViewTextBoxColumn();
            colSchool = new DataGridViewTextBoxColumn();
            colClass = new DataGridViewTextBoxColumn();
            colExamType = new DataGridViewTextBoxColumn();
            colExamTime = new DataGridViewTextBoxColumn();
            colTotalQuestion = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colEdit = new DataGridViewImageColumn();
            colDelete = new DataGridViewImageColumn();
            panelContentHeader.SuspendLayout();
            pnHeader.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
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
            lbTotalExam.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotalExam.Location = new Point(6, 3);
            lbTotalExam.Name = "lbTotalExam";
            lbTotalExam.Size = new Size(281, 38);
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
            // panelContentHeader
            // 
            panelContentHeader.Controls.Add(lbTotalExam);
            panelContentHeader.Dock = DockStyle.Top;
            panelContentHeader.Location = new Point(0, 0);
            panelContentHeader.Name = "panelContentHeader";
            panelContentHeader.Size = new Size(1036, 65);
            panelContentHeader.TabIndex = 0;
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
            panel4.Controls.Add(btnAddExam);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 90);
            panel4.Name = "panel4";
            panel4.Size = new Size(1076, 68);
            panel4.TabIndex = 2;
            // 
            // btnAddExam
            // 
            btnAddExam.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddExam.BorderRadius = 8;
            btnAddExam.CustomizableEdges = customizableEdges1;
            btnAddExam.FillColor = Color.FromArgb(59, 130, 246);
            btnAddExam.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAddExam.ForeColor = Color.White;
            btnAddExam.Image = Properties.Resources.add;
            btnAddExam.ImageAlign = HorizontalAlignment.Left;
            btnAddExam.Location = new Point(866, 26);
            btnAddExam.Margin = new Padding(3, 4, 3, 4);
            btnAddExam.Name = "btnAddExam";
            btnAddExam.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAddExam.Size = new Size(190, 36);
            btnAddExam.TabIndex = 3;
            btnAddExam.TabStop = false;
            btnAddExam.Text = "Tạo đề thi mới";
            // 
            // panel5
            // 
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(btnSubject);
            panel5.Controls.Add(btnSchool);
            panel5.Controls.Add(cbYearCourse);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(676, 68);
            panel5.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(455, 3);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 6;
            label5.Text = "Môn học";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(241, 3);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 6;
            label4.Text = "Trường";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 3);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 6;
            label2.Text = "Năm học";
            // 
            // btnSubject
            // 
            btnSubject.BackColor = Color.White;
            btnSubject.BorderRadius = 10;
            btnSubject.CustomizableEdges = customizableEdges3;
            btnSubject.DrawMode = DrawMode.OwnerDrawFixed;
            btnSubject.DropDownStyle = ComboBoxStyle.DropDownList;
            btnSubject.FillColor = Color.FromArgb(217, 217, 217);
            btnSubject.FocusedColor = Color.FromArgb(94, 148, 255);
            btnSubject.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            btnSubject.Font = new Font("Times New Roman", 12F);
            btnSubject.ForeColor = Color.Black;
            btnSubject.ItemHeight = 30;
            btnSubject.Location = new Point(453, 26);
            btnSubject.Name = "btnSubject";
            btnSubject.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSubject.Size = new Size(206, 36);
            btnSubject.TabIndex = 3;
            // 
            // btnSchool
            // 
            btnSchool.BackColor = Color.White;
            btnSchool.BorderRadius = 10;
            btnSchool.CustomizableEdges = customizableEdges5;
            btnSchool.DrawMode = DrawMode.OwnerDrawFixed;
            btnSchool.DropDownStyle = ComboBoxStyle.DropDownList;
            btnSchool.FillColor = Color.FromArgb(217, 217, 217);
            btnSchool.FocusedColor = Color.FromArgb(94, 148, 255);
            btnSchool.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            btnSchool.Font = new Font("Times New Roman", 12F);
            btnSchool.ForeColor = Color.Black;
            btnSchool.ItemHeight = 30;
            btnSchool.Location = new Point(241, 26);
            btnSchool.Name = "btnSchool";
            btnSchool.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnSchool.Size = new Size(206, 36);
            btnSchool.TabIndex = 4;
            // 
            // cbYearCourse
            // 
            cbYearCourse.BackColor = Color.White;
            cbYearCourse.BorderRadius = 10;
            cbYearCourse.CustomizableEdges = customizableEdges7;
            cbYearCourse.DrawMode = DrawMode.OwnerDrawFixed;
            cbYearCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            cbYearCourse.FillColor = Color.FromArgb(217, 217, 217);
            cbYearCourse.FocusedColor = Color.FromArgb(94, 148, 255);
            cbYearCourse.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbYearCourse.Font = new Font("Times New Roman", 12F);
            cbYearCourse.ForeColor = Color.Black;
            cbYearCourse.ItemHeight = 30;
            cbYearCourse.Location = new Point(20, 26);
            cbYearCourse.Name = "cbYearCourse";
            cbYearCourse.ShadowDecoration.CustomizableEdges = customizableEdges8;
            cbYearCourse.Size = new Size(206, 36);
            cbYearCourse.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(104, 116, 135);
            label1.Location = new Point(0, 64);
            label1.Name = "label1";
            label1.Size = new Size(511, 26);
            label1.TabIndex = 1;
            label1.Text = "Tạo, chỉnh sửa và quản lý các đề thi cho các môn học";
            // 
            // lbNameFunction
            // 
            lbNameFunction.Dock = DockStyle.Top;
            lbNameFunction.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNameFunction.Location = new Point(0, 0);
            lbNameFunction.Name = "lbNameFunction";
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
            pbContentMain.Controls.Add(panelContentHeader);
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
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvExams.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvExams.ColumnHeadersHeight = 55;
            dgvExams.Columns.AddRange(new DataGridViewColumn[] { colExamName, colSubject, colSchool, colClass, colExamType, colExamTime, colTotalQuestion, colStatus, colEdit, colDelete });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(128, 255, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvExams.DefaultCellStyle = dataGridViewCellStyle2;
            dgvExams.Dock = DockStyle.Fill;
            dgvExams.EnableHeadersVisualStyles = false;
            dgvExams.GridColor = Color.FromArgb(217, 217, 217);
            dgvExams.Location = new Point(0, 65);
            dgvExams.MultiSelect = false;
            dgvExams.Name = "dgvExams";
            dgvExams.ReadOnly = true;
            dgvExams.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvExams.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvExams.RowHeadersVisible = false;
            dgvExams.RowHeadersWidth = 51;
            dgvExams.RowTemplate.Height = 40;
            dgvExams.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvExams.Size = new Size(1036, 288);
            dgvExams.TabIndex = 0;
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
            // colClass
            // 
            colClass.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colClass.FillWeight = 8F;
            colClass.HeaderText = "LỚP";
            colClass.MinimumWidth = 6;
            colClass.Name = "colClass";
            colClass.ReadOnly = true;
            colClass.Width = 120;
            // 
            // colExamType
            // 
            colExamType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colExamType.FillWeight = 10F;
            colExamType.HeaderText = "LOẠI ĐỀ";
            colExamType.MinimumWidth = 6;
            colExamType.Name = "colExamType";
            colExamType.ReadOnly = true;
            // 
            // colExamTime
            // 
            colExamTime.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colExamTime.HeaderText = "THỜI GIAN";
            colExamTime.MinimumWidth = 6;
            colExamTime.Name = "colExamTime";
            colExamTime.ReadOnly = true;
            colExamTime.Width = 120;
            // 
            // colTotalQuestion
            // 
            colTotalQuestion.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colTotalQuestion.HeaderText = "SỐ CÂU";
            colTotalQuestion.MinimumWidth = 6;
            colTotalQuestion.Name = "colTotalQuestion";
            colTotalQuestion.ReadOnly = true;
            colTotalQuestion.Width = 120;
            // 
            // colStatus
            // 
            colStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colStatus.HeaderText = "TRẠNG THÁI";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.Width = 120;
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
            panelContentHeader.ResumeLayout(false);
            panelContentHeader.PerformLayout();
            pnHeader.ResumeLayout(false);
            pnHeader.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
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
        private Panel panelContentHeader;
        private Panel pnHeader;
        private Label label1;
        private Label lbNameFunction;
        private Panel pbContent;
        private Panel pbContentMain;
        private DataGridView dgvExams;
        private Panel panel4;
        private Panel panel5;
        private Guna.UI2.WinForms.Guna2ComboBox btnSubject;
        private Guna.UI2.WinForms.Guna2ComboBox btnSchool;
        private Guna.UI2.WinForms.Guna2ComboBox cbYearCourse;
        private Guna.UI2.WinForms.Guna2Button btnAddExam;
        private Label label5;
        private Label label4;
        private Label label2;
        private DataGridViewTextBoxColumn colExamName;
        private DataGridViewTextBoxColumn colSubject;
        private DataGridViewTextBoxColumn colSchool;
        private DataGridViewTextBoxColumn colClass;
        private DataGridViewTextBoxColumn colExamType;
        private DataGridViewTextBoxColumn colExamTime;
        private DataGridViewTextBoxColumn colTotalQuestion;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewImageColumn colEdit;
        private DataGridViewImageColumn colDelete;
    }
}
