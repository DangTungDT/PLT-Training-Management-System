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
            pnHeader = new Panel();
            pbContent = new Panel();
            lbNameFunction = new Label();
            label1 = new Label();
            pbContentLeft = new Panel();
            pbContentRight = new Panel();
            pbContentBottom = new Panel();
            pbContentMain = new Panel();
            panelContentHeader = new Panel();
            lbContentFillHeader = new Label();
            label2 = new Label();
            lbTotalItem = new Label();
            label4 = new Label();
            dtpFindDate = new DateTimePicker();
            cbFindLevel = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            lbPageNumber = new Label();
            btnPageBefore = new Button();
            btnPageAfter = new Button();
            dgvBooks = new DataGridView();
            pnHeader.SuspendLayout();
            pbContent.SuspendLayout();
            pbContentMain.SuspendLayout();
            panelContentHeader.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
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
            // lbNameFunction
            // 
            lbNameFunction.Dock = DockStyle.Top;
            lbNameFunction.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNameFunction.Location = new Point(0, 0);
            lbNameFunction.Name = "lbNameFunction";
            lbNameFunction.Size = new Size(1076, 64);
            lbNameFunction.TabIndex = 0;
            lbNameFunction.Text = "Quản lý sách và giáo trình";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(0, 64);
            label1.Name = "label1";
            label1.Size = new Size(630, 26);
            label1.TabIndex = 1;
            label1.Text = "Thêm, xóa, sửa, và quản lý toàn bộ sách, giáo trình trong hệ thống";
            // 
            // pbContentLeft
            // 
            pbContentLeft.Dock = DockStyle.Left;
            pbContentLeft.Location = new Point(0, 0);
            pbContentLeft.Name = "pbContentLeft";
            pbContentLeft.Size = new Size(20, 406);
            pbContentLeft.TabIndex = 0;
            // 
            // pbContentRight
            // 
            pbContentRight.Dock = DockStyle.Right;
            pbContentRight.Location = new Point(1056, 0);
            pbContentRight.Name = "pbContentRight";
            pbContentRight.Size = new Size(20, 406);
            pbContentRight.TabIndex = 1;
            // 
            // pbContentBottom
            // 
            pbContentBottom.Dock = DockStyle.Bottom;
            pbContentBottom.Location = new Point(20, 386);
            pbContentBottom.Name = "pbContentBottom";
            pbContentBottom.Size = new Size(1036, 20);
            pbContentBottom.TabIndex = 2;
            // 
            // pbContentMain
            // 
            pbContentMain.Controls.Add(dgvBooks);
            pbContentMain.Controls.Add(panel1);
            pbContentMain.Controls.Add(panelContentHeader);
            pbContentMain.Dock = DockStyle.Fill;
            pbContentMain.Location = new Point(20, 0);
            pbContentMain.Name = "pbContentMain";
            pbContentMain.Size = new Size(1036, 386);
            pbContentMain.TabIndex = 3;
            // 
            // panelContentHeader
            // 
            panelContentHeader.Controls.Add(cbFindLevel);
            panelContentHeader.Controls.Add(dtpFindDate);
            panelContentHeader.Controls.Add(label4);
            panelContentHeader.Controls.Add(lbTotalItem);
            panelContentHeader.Controls.Add(label2);
            panelContentHeader.Controls.Add(label6);
            panelContentHeader.Controls.Add(label5);
            panelContentHeader.Controls.Add(lbContentFillHeader);
            panelContentHeader.Dock = DockStyle.Top;
            panelContentHeader.Location = new Point(0, 0);
            panelContentHeader.Name = "panelContentHeader";
            panelContentHeader.Size = new Size(1036, 65);
            panelContentHeader.TabIndex = 0;
            // 
            // lbContentFillHeader
            // 
            lbContentFillHeader.AutoSize = true;
            lbContentFillHeader.Location = new Point(6, 3);
            lbContentFillHeader.Name = "lbContentFillHeader";
            lbContentFillHeader.Size = new Size(145, 20);
            lbContentFillHeader.TabIndex = 0;
            lbContentFillHeader.Text = "Danh sách giáo trình";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 34);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 0;
            label2.Text = "Tổng :";
            // 
            // lbTotalItem
            // 
            lbTotalItem.AutoSize = true;
            lbTotalItem.Location = new Point(62, 34);
            lbTotalItem.Name = "lbTotalItem";
            lbTotalItem.Size = new Size(41, 20);
            lbTotalItem.TabIndex = 0;
            lbTotalItem.Text = "0000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(144, 34);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 0;
            label4.Text = "Sách";
            // 
            // dtpFindDate
            // 
            dtpFindDate.Format = DateTimePickerFormat.Short;
            dtpFindDate.Location = new Point(613, 27);
            dtpFindDate.Name = "dtpFindDate";
            dtpFindDate.Size = new Size(191, 27);
            dtpFindDate.TabIndex = 1;
            // 
            // cbFindLevel
            // 
            cbFindLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFindLevel.FormattingEnabled = true;
            cbFindLevel.Location = new Point(819, 26);
            cbFindLevel.Name = "cbFindLevel";
            cbFindLevel.Size = new Size(211, 28);
            cbFindLevel.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(613, 3);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 0;
            label5.Text = "Ngày tải lên";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(819, 3);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 0;
            label6.Text = "Trình độ";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnPageAfter);
            panel1.Controls.Add(btnPageBefore);
            panel1.Controls.Add(lbPageNumber);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 321);
            panel1.Name = "panel1";
            panel1.Size = new Size(1036, 65);
            panel1.TabIndex = 1;
            // 
            // lbPageNumber
            // 
            lbPageNumber.AutoSize = true;
            lbPageNumber.Location = new Point(874, 25);
            lbPageNumber.Name = "lbPageNumber";
            lbPageNumber.Size = new Size(69, 20);
            lbPageNumber.TabIndex = 0;
            lbPageNumber.Text = "Số lượng";
            // 
            // btnPageBefore
            // 
            btnPageBefore.Location = new Point(802, 16);
            btnPageBefore.Name = "btnPageBefore";
            btnPageBefore.Size = new Size(66, 38);
            btnPageBefore.TabIndex = 1;
            btnPageBefore.Text = "Trước";
            btnPageBefore.UseVisualStyleBackColor = true;
            // 
            // btnPageAfter
            // 
            btnPageAfter.Location = new Point(949, 16);
            btnPageAfter.Name = "btnPageAfter";
            btnPageAfter.Size = new Size(66, 38);
            btnPageAfter.TabIndex = 1;
            btnPageAfter.Text = "Sau";
            btnPageAfter.UseVisualStyleBackColor = true;
            // 
            // dgvBooks
            // 
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Dock = DockStyle.Fill;
            dgvBooks.Location = new Point(0, 65);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.Size = new Size(1036, 256);
            dgvBooks.TabIndex = 2;
            // 
            // UcBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pbContent);
            Controls.Add(pnHeader);
            Name = "UcBook";
            Size = new Size(1076, 531);
            pnHeader.ResumeLayout(false);
            pnHeader.PerformLayout();
            pbContent.ResumeLayout(false);
            pbContentMain.ResumeLayout(false);
            panelContentHeader.ResumeLayout(false);
            panelContentHeader.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
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
        private ComboBox cbFindLevel;
        private DateTimePicker dtpFindDate;
        private Label label4;
        private Label lbTotalItem;
        private Label label2;
        private Label lbContentFillHeader;
        private Label label6;
        private Label label5;
        private Panel panel1;
        private Button btnPageAfter;
        private Button btnPageBefore;
        private Label lbPageNumber;
        private DataGridView dgvBooks;
    }
}
