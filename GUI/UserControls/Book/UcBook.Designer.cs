using System.Drawing;
namespace GUI.UserControls
{
    partial class UcBook
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnHeader = new Panel();
            label1 = new Label();
            lbNameFunction = new Label();
            pbContent = new Panel();
            pbContentMain = new Panel();
            dgvBooks = new DataGridView();
            colBookName = new DataGridViewTextBoxColumn();
            colAuthor = new DataGridViewTextBoxColumn();
            colSubject = new DataGridViewTextBoxColumn();
            colYear = new DataGridViewTextBoxColumn();
            colLevel = new DataGridViewTextBoxColumn();
            colView = new DataGridViewImageColumn();
            colEdit = new DataGridViewImageColumn();
            colDelete = new DataGridViewImageColumn();
            panel1 = new Panel();
            lbDisplayDisplayBookAtPage = new Label();
            label3 = new Label();
            panel3 = new Panel();
            lbPageIndex = new CustomControls.RoundedLabel();
            btnPageBefore = new CustomControls.RoundedButton();
            btnPageAfter = new CustomControls.RoundedButton();
            panelContentHeader = new Panel();
            panel2 = new Panel();
            btnResetFilter = new Guna.UI2.WinForms.Guna2Button();
            dtpFindDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            cbFindLevel = new Guna.UI2.WinForms.Guna2ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            lbTotalItem = new Label();
            label2 = new Label();
            lbContentFillHeader = new Label();
            pbContentBottom = new Panel();
            pbContentRight = new Panel();
            pbContentLeft = new Panel();
            pnHeader.SuspendLayout();
            pbContent.SuspendLayout();
            pbContentMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panelContentHeader.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnHeader
            // 
            pnHeader.Controls.Add(label1);
            pnHeader.Controls.Add(lbNameFunction);
            pnHeader.Dock = DockStyle.Top;
            pnHeader.Location = new Point(0, 0);
            pnHeader.Name = "pnHeader";
            pnHeader.Size = new Size(1076, 125);
            pnHeader.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(104, 116, 135);
            label1.Location = new Point(0, 64);
            label1.Name = "label1";
            label1.Size = new Size(687, 31);
            label1.TabIndex = 1;
            label1.Text = "Thêm, xóa, sửa, và quản lý toàn bộ sách, giáo trình trong hệ thống";
            // 
            // lbNameFunction
            // 
            lbNameFunction.Dock = DockStyle.Top;
            lbNameFunction.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNameFunction.Location = new Point(0, 0);
            lbNameFunction.Name = "lbNameFunction";
            lbNameFunction.Size = new Size(1076, 64);
            lbNameFunction.TabIndex = 0;
            lbNameFunction.Text = "Quản lý sách và giáo trình";
            // 
            // pbContent
            // 
            pbContent.Controls.Add(pbContentMain);
            pbContent.Controls.Add(pbContentBottom);
            pbContent.Controls.Add(pbContentRight);
            pbContent.Controls.Add(pbContentLeft);
            pbContent.Dock = DockStyle.Fill;
            pbContent.Location = new Point(0, 125);
            pbContent.Name = "pbContent";
            pbContent.Size = new Size(1076, 406);
            pbContent.TabIndex = 1;
            // 
            // pbContentMain
            // 
            pbContentMain.BackColor = Color.White;
            pbContentMain.BackgroundImage = Properties.Resources.Cardmoi_PLT_Trang;
            pbContentMain.BackgroundImageLayout = ImageLayout.Zoom;
            pbContentMain.Controls.Add(dgvBooks);
            pbContentMain.Controls.Add(panel1);
            pbContentMain.Controls.Add(panelContentHeader);
            pbContentMain.Dock = DockStyle.Fill;
            pbContentMain.Location = new Point(20, 0);
            pbContentMain.Name = "pbContentMain";
            pbContentMain.Size = new Size(1036, 386);
            pbContentMain.TabIndex = 3;
            // 
            // dgvBooks
            // 
            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.AllowUserToDeleteRows = false;
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.BackgroundColor = Color.White;
            dgvBooks.BorderStyle = BorderStyle.None;
            dgvBooks.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBooks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBooks.ColumnHeadersHeight = 29;
            dgvBooks.Columns.AddRange(new DataGridViewColumn[] { colBookName, colAuthor, colSubject, colYear, colLevel, colView, colEdit, colDelete });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Times New Roman", 10F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(128, 255, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvBooks.DefaultCellStyle = dataGridViewCellStyle6;
            dgvBooks.Dock = DockStyle.Fill;
            dgvBooks.EnableHeadersVisualStyles = false;
            dgvBooks.GridColor = Color.FromArgb(217, 217, 217);
            dgvBooks.Location = new Point(0, 97);
            dgvBooks.MultiSelect = false;
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvBooks.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvBooks.RowHeadersVisible = false;
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.RowTemplate.Height = 40;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.Size = new Size(1036, 224);
            dgvBooks.TabIndex = 0;
            dgvBooks.CellClick += dgvBooks_CellClick;
            dgvBooks.CellContentClick += dgvBooks_CellContentClick;
            // 
            // colBookName
            // 
            colBookName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colBookName.FillWeight = 20F;
            colBookName.HeaderText = "TÊN SÁCH";
            colBookName.MinimumWidth = 6;
            colBookName.Name = "colBookName";
            colBookName.ReadOnly = true;
            // 
            // colAuthor
            // 
            colAuthor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colAuthor.DefaultCellStyle = dataGridViewCellStyle2;
            colAuthor.FillWeight = 16F;
            colAuthor.HeaderText = "TÁC GIẢ";
            colAuthor.MinimumWidth = 6;
            colAuthor.Name = "colAuthor";
            colAuthor.ReadOnly = true;
            // 
            // colSubject
            // 
            colSubject.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colSubject.DefaultCellStyle = dataGridViewCellStyle3;
            colSubject.FillWeight = 15F;
            colSubject.HeaderText = "MÔN HỌC";
            colSubject.MinimumWidth = 6;
            colSubject.Name = "colSubject";
            colSubject.ReadOnly = true;
            // 
            // colYear
            // 
            colYear.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colYear.DefaultCellStyle = dataGridViewCellStyle4;
            colYear.FillWeight = 8F;
            colYear.HeaderText = "NĂM XB";
            colYear.MinimumWidth = 6;
            colYear.Name = "colYear";
            colYear.ReadOnly = true;
            // 
            // colLevel
            // 
            colLevel.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colLevel.DefaultCellStyle = dataGridViewCellStyle5;
            colLevel.FillWeight = 10F;
            colLevel.HeaderText = "TRÌNH ĐỘ";
            colLevel.MinimumWidth = 6;
            colLevel.Name = "colLevel";
            colLevel.ReadOnly = true;
            // 
            // colView
            // 
            colView.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colView.HeaderText = "";
            colView.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colView.MinimumWidth = 6;
            colView.Name = "colView";
            colView.ReadOnly = true;
            colView.ToolTipText = "Xem";
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
            // panel1
            // 
            panel1.Controls.Add(lbDisplayDisplayBookAtPage);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 321);
            panel1.Name = "panel1";
            panel1.Size = new Size(1036, 65);
            panel1.TabIndex = 1;
            // 
            // lbDisplayDisplayBookAtPage
            // 
            lbDisplayDisplayBookAtPage.AutoSize = true;
            lbDisplayDisplayBookAtPage.Font = new Font("Segoe UI", 12F);
            lbDisplayDisplayBookAtPage.ForeColor = Color.FromArgb(104, 116, 135);
            lbDisplayDisplayBookAtPage.Location = new Point(100, 22);
            lbDisplayDisplayBookAtPage.Name = "lbDisplayDisplayBookAtPage";
            lbDisplayDisplayBookAtPage.Size = new Size(254, 28);
            lbDisplayDisplayBookAtPage.TabIndex = 1;
            lbDisplayDisplayBookAtPage.Text = "1-5 trong tổng số 5 kết quả";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.FromArgb(104, 116, 135);
            label3.Location = new Point(6, 22);
            label3.Name = "label3";
            label3.Size = new Size(85, 28);
            label3.TabIndex = 1;
            label3.Text = "Hiển thị ";
            // 
            // panel3
            // 
            panel3.Controls.Add(lbPageIndex);
            panel3.Controls.Add(btnPageBefore);
            panel3.Controls.Add(btnPageAfter);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(741, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(295, 65);
            panel3.TabIndex = 0;
            // 
            // lbPageIndex
            // 
            lbPageIndex.AutoSize = true;
            lbPageIndex.BackColor = Color.FromArgb(60, 131, 246);
            lbPageIndex.BorderColor = Color.Transparent;
            lbPageIndex.BorderRadius = 8;
            lbPageIndex.BorderSize = 0;
            lbPageIndex.Font = new Font("Times New Roman", 12F);
            lbPageIndex.ForeColor = Color.White;
            lbPageIndex.Location = new Point(155, 12);
            lbPageIndex.MinimumSize = new Size(31, 39);
            lbPageIndex.Name = "lbPageIndex";
            lbPageIndex.Size = new Size(31, 39);
            lbPageIndex.TabIndex = 2;
            lbPageIndex.Text = "1";
            lbPageIndex.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPageBefore
            // 
            btnPageBefore.BackColor = Color.White;
            btnPageBefore.BorderColor = Color.Silver;
            btnPageBefore.BorderRadius = 10;
            btnPageBefore.BorderSize = 1;
            btnPageBefore.FlatAppearance.BorderSize = 0;
            btnPageBefore.FlatStyle = FlatStyle.Flat;
            btnPageBefore.Font = new Font("Segoe UI", 12F);
            btnPageBefore.ForeColor = Color.FromArgb(104, 116, 135);
            btnPageBefore.Location = new Point(56, 13);
            btnPageBefore.Name = "btnPageBefore";
            btnPageBefore.Size = new Size(66, 38);
            btnPageBefore.TabIndex = 1;
            btnPageBefore.Text = "Trước";
            btnPageBefore.UseVisualStyleBackColor = false;
            btnPageBefore.Click += btnPageBefore_Click;
            // 
            // btnPageAfter
            // 
            btnPageAfter.BackColor = Color.White;
            btnPageAfter.BorderColor = Color.Silver;
            btnPageAfter.BorderRadius = 10;
            btnPageAfter.BorderSize = 1;
            btnPageAfter.FlatAppearance.BorderSize = 0;
            btnPageAfter.FlatStyle = FlatStyle.Flat;
            btnPageAfter.Font = new Font("Segoe UI", 12F);
            btnPageAfter.ForeColor = Color.FromArgb(104, 116, 135);
            btnPageAfter.Location = new Point(216, 13);
            btnPageAfter.Name = "btnPageAfter";
            btnPageAfter.Size = new Size(66, 38);
            btnPageAfter.TabIndex = 1;
            btnPageAfter.Text = "Sau";
            btnPageAfter.UseVisualStyleBackColor = false;
            btnPageAfter.Click += btnPageAfter_Click;
            // 
            // panelContentHeader
            // 
            panelContentHeader.Controls.Add(panel2);
            panelContentHeader.Controls.Add(label4);
            panelContentHeader.Controls.Add(lbTotalItem);
            panelContentHeader.Controls.Add(label2);
            panelContentHeader.Controls.Add(lbContentFillHeader);
            panelContentHeader.Dock = DockStyle.Top;
            panelContentHeader.Location = new Point(0, 0);
            panelContentHeader.Name = "panelContentHeader";
            panelContentHeader.Size = new Size(1036, 97);
            panelContentHeader.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnResetFilter);
            panel2.Controls.Add(dtpFindDate);
            panel2.Controls.Add(cbFindLevel);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(405, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(631, 97);
            panel2.TabIndex = 1;
            // 
            // btnResetFilter
            // 
            btnResetFilter.BorderRadius = 10;
            btnResetFilter.CustomizableEdges = customizableEdges1;
            btnResetFilter.DisabledState.BorderColor = Color.DarkGray;
            btnResetFilter.DisabledState.CustomBorderColor = Color.DarkGray;
            btnResetFilter.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnResetFilter.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnResetFilter.Font = new Font("Segoe UI", 9F);
            btnResetFilter.ForeColor = Color.White;
            btnResetFilter.Location = new Point(460, 34);
            btnResetFilter.Name = "btnResetFilter";
            btnResetFilter.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnResetFilter.Size = new Size(165, 36);
            btnResetFilter.TabIndex = 6;
            btnResetFilter.Text = "Làm mới tìm kiếm";
            btnResetFilter.Click += btnResetFilter_Click;
            // 
            // dtpFindDate
            // 
            dtpFindDate.BorderRadius = 10;
            dtpFindDate.Checked = true;
            dtpFindDate.CustomizableEdges = customizableEdges3;
            dtpFindDate.FillColor = Color.FromArgb(217, 217, 217);
            dtpFindDate.FocusedColor = Color.FromArgb(217, 217, 217);
            dtpFindDate.Font = new Font("Times New Roman", 12F);
            dtpFindDate.ForeColor = Color.Black;
            dtpFindDate.Format = DateTimePickerFormat.Short;
            dtpFindDate.HoverState.FillColor = Color.FromArgb(217, 217, 217);
            dtpFindDate.Location = new Point(17, 34);
            dtpFindDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpFindDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpFindDate.Name = "dtpFindDate";
            dtpFindDate.ShadowDecoration.CustomizableEdges = customizableEdges4;
            dtpFindDate.Size = new Size(222, 36);
            dtpFindDate.TabIndex = 5;
            dtpFindDate.Value = new DateTime(2025, 12, 17, 12, 51, 10, 598);
            dtpFindDate.ValueChanged += dtpFindDate_ValueChanged;
            // 
            // cbFindLevel
            // 
            cbFindLevel.BackColor = Color.White;
            cbFindLevel.BorderRadius = 10;
            cbFindLevel.CustomizableEdges = customizableEdges5;
            cbFindLevel.DrawMode = DrawMode.OwnerDrawFixed;
            cbFindLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFindLevel.FillColor = Color.FromArgb(217, 217, 217);
            cbFindLevel.FocusedColor = Color.FromArgb(94, 148, 255);
            cbFindLevel.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbFindLevel.Font = new Font("Times New Roman", 12F);
            cbFindLevel.ForeColor = Color.Black;
            cbFindLevel.ItemHeight = 30;
            cbFindLevel.Location = new Point(245, 34);
            cbFindLevel.Name = "cbFindLevel";
            cbFindLevel.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cbFindLevel.Size = new Size(206, 36);
            cbFindLevel.TabIndex = 2;
            cbFindLevel.SelectedIndexChanged += cbFindLevel_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.FromArgb(104, 116, 135);
            label6.Location = new Point(245, 3);
            label6.Name = "label6";
            label6.Size = new Size(83, 28);
            label6.TabIndex = 3;
            label6.Text = "Trình độ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.FromArgb(104, 116, 135);
            label5.Location = new Point(17, 3);
            label5.Name = "label5";
            label5.Size = new Size(117, 28);
            label5.TabIndex = 4;
            label5.Text = "Ngày tải lên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.FromArgb(104, 116, 135);
            label4.Location = new Point(144, 60);
            label4.Name = "label4";
            label4.Size = new Size(53, 28);
            label4.TabIndex = 0;
            label4.Text = "Sách";
            // 
            // lbTotalItem
            // 
            lbTotalItem.AutoSize = true;
            lbTotalItem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotalItem.Location = new Point(77, 60);
            lbTotalItem.Name = "lbTotalItem";
            lbTotalItem.Size = new Size(50, 23);
            lbTotalItem.TabIndex = 0;
            lbTotalItem.Text = "0000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.FromArgb(104, 116, 135);
            label2.Location = new Point(6, 60);
            label2.Name = "label2";
            label2.Size = new Size(66, 28);
            label2.TabIndex = 0;
            label2.Text = "Tổng :";
            // 
            // lbContentFillHeader
            // 
            lbContentFillHeader.AutoSize = true;
            lbContentFillHeader.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbContentFillHeader.Location = new Point(6, 3);
            lbContentFillHeader.Name = "lbContentFillHeader";
            lbContentFillHeader.Size = new Size(348, 46);
            lbContentFillHeader.TabIndex = 0;
            lbContentFillHeader.Text = "Danh sách giáo trình";
            // 
            // pbContentBottom
            // 
            pbContentBottom.Dock = DockStyle.Bottom;
            pbContentBottom.Location = new Point(20, 386);
            pbContentBottom.Name = "pbContentBottom";
            pbContentBottom.Size = new Size(1036, 20);
            pbContentBottom.TabIndex = 2;
            // 
            // pbContentRight
            // 
            pbContentRight.Dock = DockStyle.Right;
            pbContentRight.Location = new Point(1056, 0);
            pbContentRight.Name = "pbContentRight";
            pbContentRight.Size = new Size(20, 406);
            pbContentRight.TabIndex = 1;
            // 
            // pbContentLeft
            // 
            pbContentLeft.Dock = DockStyle.Left;
            pbContentLeft.Location = new Point(0, 0);
            pbContentLeft.Name = "pbContentLeft";
            pbContentLeft.Size = new Size(20, 406);
            pbContentLeft.TabIndex = 0;
            // 
            // UcBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pbContent);
            Controls.Add(pnHeader);
            Name = "UcBook";
            Size = new Size(1076, 531);
            Load += UcBook_Load;
            pnHeader.ResumeLayout(false);
            pnHeader.PerformLayout();
            pbContent.ResumeLayout(false);
            pbContentMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelContentHeader.ResumeLayout(false);
            panelContentHeader.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnHeader;
        private Label label1;
        private Label lbNameFunction;
        private Panel pbContent;
        private Panel pbContentMain;
        private Panel pbContentBottom;
        private Panel pbContentRight;
        private Panel pbContentLeft;
        private Panel panelContentHeader;
        private Label label4;
        private Label lbTotalItem;
        private Label label2;
        private Label lbContentFillHeader;
        private Panel panel1;
        private DataGridView dgvBooks;
        private Panel panel3;
        private Panel panel2;
        private Label label6;
        private Label label5;
        private CustomControls.RoundedButton btnPageAfter;
        private CustomControls.RoundedButton btnPageBefore;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFindDate;
        private Guna.UI2.WinForms.Guna2ComboBox cbFindLevel;
        private CustomControls.RoundedLabel lbPageIndex;
        private Label lbDisplayDisplayBookAtPage;
        private Label label3;
        private DataGridViewTextBoxColumn colBookName;
        private DataGridViewTextBoxColumn colAuthor;
        private DataGridViewTextBoxColumn colSubject;
        private DataGridViewTextBoxColumn colYear;
        private DataGridViewTextBoxColumn colLevel;
        private DataGridViewImageColumn colView;
        private DataGridViewImageColumn colEdit;
        private DataGridViewImageColumn colDelete;
        private Guna.UI2.WinForms.Guna2Button btnResetFilter;
    }
}
