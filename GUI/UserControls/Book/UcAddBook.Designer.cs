namespace GUI.UserControls.Book
{
    partial class UcAddBook
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
            pbContentBottom = new Panel();
            pbContentLeft = new Panel();
            lbInputValueBook = new Label();
            lbContentFillHeader = new Label();
            panelContentHeader = new Panel();
            lbInputFileBook = new Label();
            pnHeader = new Panel();
            label1 = new Label();
            lbNameFunction = new Label();
            pbContent = new Panel();
            pbContentMain = new Panel();
            pbContentInput = new Panel();
            pbContentRight = new Panel();
            panelContentHeader.SuspendLayout();
            pnHeader.SuspendLayout();
            pbContent.SuspendLayout();
            pbContentMain.SuspendLayout();
            SuspendLayout();
            // 
            // pbContentBottom
            // 
            pbContentBottom.Dock = DockStyle.Bottom;
            pbContentBottom.Location = new Point(20, 386);
            pbContentBottom.Name = "pbContentBottom";
            pbContentBottom.Size = new Size(1036, 20);
            pbContentBottom.TabIndex = 2;
            // 
            // pbContentLeft
            // 
            pbContentLeft.Dock = DockStyle.Left;
            pbContentLeft.Location = new Point(0, 0);
            pbContentLeft.Name = "pbContentLeft";
            pbContentLeft.Size = new Size(20, 406);
            pbContentLeft.TabIndex = 0;
            // 
            // lbInputValueBook
            // 
            lbInputValueBook.AutoSize = true;
            lbInputValueBook.Font = new Font("Times New Roman", 12F);
            lbInputValueBook.ForeColor = Color.FromArgb(104, 116, 135);
            lbInputValueBook.Location = new Point(16, 86);
            lbInputValueBook.Name = "lbInputValueBook";
            lbInputValueBook.Size = new Size(142, 22);
            lbInputValueBook.TabIndex = 0;
            lbInputValueBook.Text = "Thông tin cơ bản";
            lbInputValueBook.Click += lbInputValueBook_Click;
            // 
            // lbContentFillHeader
            // 
            lbContentFillHeader.AutoSize = true;
            lbContentFillHeader.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbContentFillHeader.Location = new Point(6, 3);
            lbContentFillHeader.Name = "lbContentFillHeader";
            lbContentFillHeader.Size = new Size(321, 38);
            lbContentFillHeader.TabIndex = 0;
            lbContentFillHeader.Text = "Danh sách giáo trình";
            // 
            // panelContentHeader
            // 
            panelContentHeader.Controls.Add(lbInputFileBook);
            panelContentHeader.Controls.Add(lbInputValueBook);
            panelContentHeader.Controls.Add(lbContentFillHeader);
            panelContentHeader.Dock = DockStyle.Top;
            panelContentHeader.Location = new Point(0, 0);
            panelContentHeader.Name = "panelContentHeader";
            panelContentHeader.Size = new Size(1036, 122);
            panelContentHeader.TabIndex = 0;
            // 
            // lbInputFileBook
            // 
            lbInputFileBook.AutoSize = true;
            lbInputFileBook.Font = new Font("Times New Roman", 12F);
            lbInputFileBook.ForeColor = Color.FromArgb(104, 116, 135);
            lbInputFileBook.Location = new Point(185, 86);
            lbInputFileBook.Name = "lbInputFileBook";
            lbInputFileBook.Size = new Size(117, 22);
            lbInputFileBook.TabIndex = 0;
            lbInputFileBook.Text = "Tệp đính kèm";
            lbInputFileBook.Click += lbInputFileBook_Click;
            // 
            // pnHeader
            // 
            pnHeader.Controls.Add(label1);
            pnHeader.Controls.Add(lbNameFunction);
            pnHeader.Dock = DockStyle.Top;
            pnHeader.Location = new Point(0, 0);
            pnHeader.Name = "pnHeader";
            pnHeader.Size = new Size(1076, 125);
            pnHeader.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(104, 116, 135);
            label1.Location = new Point(0, 64);
            label1.Name = "label1";
            label1.Size = new Size(630, 26);
            label1.TabIndex = 1;
            label1.Text = "Thêm, xóa, sửa, và quản lý toàn bộ sách, giáo trình trong hệ thống";
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
            pbContent.TabIndex = 3;
            // 
            // pbContentMain
            // 
            pbContentMain.BackColor = Color.White;
            pbContentMain.Controls.Add(pbContentInput);
            pbContentMain.Controls.Add(panelContentHeader);
            pbContentMain.Dock = DockStyle.Fill;
            pbContentMain.Location = new Point(20, 0);
            pbContentMain.Name = "pbContentMain";
            pbContentMain.Size = new Size(1036, 386);
            pbContentMain.TabIndex = 3;
            // 
            // pbContentInput
            // 
            pbContentInput.Dock = DockStyle.Fill;
            pbContentInput.Location = new Point(0, 122);
            pbContentInput.Name = "pbContentInput";
            pbContentInput.Size = new Size(1036, 264);
            pbContentInput.TabIndex = 1;
            // 
            // pbContentRight
            // 
            pbContentRight.Dock = DockStyle.Right;
            pbContentRight.Location = new Point(1056, 0);
            pbContentRight.Name = "pbContentRight";
            pbContentRight.Size = new Size(20, 406);
            pbContentRight.TabIndex = 1;
            // 
            // UcAddBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pbContent);
            Controls.Add(pnHeader);
            Name = "UcAddBook";
            Size = new Size(1076, 531);
            Load += UcAddBook_Load;
            panelContentHeader.ResumeLayout(false);
            panelContentHeader.PerformLayout();
            pnHeader.ResumeLayout(false);
            pnHeader.PerformLayout();
            pbContent.ResumeLayout(false);
            pbContentMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pbContentBottom;
        private Panel pbContentLeft;
        private Label label4;
        private Label lbTotalItem;
        private Label lbInputValueBook;
        private Label lbContentFillHeader;
        private Panel panelContentHeader;
        private Panel pnHeader;
        private Label label1;
        private Label lbNameFunction;
        private Panel pbContent;
        private Panel pbContentMain;
        private Panel pbContentInput;
        private Panel pbContentRight;
        private Label lbInputFileBook;
    }
}
