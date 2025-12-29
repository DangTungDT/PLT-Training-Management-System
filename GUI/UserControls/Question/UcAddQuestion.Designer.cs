namespace GUI.UserControls.Question
{
    partial class UcAddQuestion
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            label4 = new Label();
            label5 = new Label();
            txtScoreQuestion = new Guna.UI2.WinForms.Guna2TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            txtOptionD = new Guna.UI2.WinForms.Guna2TextBox();
            txtOptionC = new Guna.UI2.WinForms.Guna2TextBox();
            txtOptionB = new Guna.UI2.WinForms.Guna2TextBox();
            txtOptionA = new Guna.UI2.WinForms.Guna2TextBox();
            radA = new RadioButton();
            radB = new RadioButton();
            radC = new RadioButton();
            radD = new RadioButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            txtContentQuestion = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
            panel2 = new Panel();
            cbTypeQuestion = new Guna.UI2.WinForms.Guna2ComboBox();
            lbNumberQuestion = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel3);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20);
            panel1.Size = new Size(1034, 596);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(label4, 0, 0);
            tableLayoutPanel3.Controls.Add(label5, 0, 1);
            tableLayoutPanel3.Controls.Add(txtScoreQuestion, 0, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(20, 464);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel3.Size = new Size(994, 112);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Bottom;
            label4.ForeColor = Color.FromArgb(104, 116, 135);
            label4.Location = new Point(3, 10);
            label4.Name = "label4";
            label4.Size = new Size(988, 20);
            label4.TabIndex = 0;
            label4.Text = "Chọn đáp án đúng bằng cách click vào radio button";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Bottom;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(3, 32);
            label5.Name = "label5";
            label5.Size = new Size(988, 28);
            label5.TabIndex = 1;
            label5.Text = "Điểm số";
            // 
            // txtScoreQuestion
            // 
            txtScoreQuestion.BorderColor = Color.Black;
            txtScoreQuestion.BorderRadius = 10;
            txtScoreQuestion.CustomizableEdges = customizableEdges1;
            txtScoreQuestion.DefaultText = "";
            txtScoreQuestion.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtScoreQuestion.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtScoreQuestion.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtScoreQuestion.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtScoreQuestion.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtScoreQuestion.Font = new Font("Segoe UI", 9F);
            txtScoreQuestion.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtScoreQuestion.Location = new Point(3, 64);
            txtScoreQuestion.Margin = new Padding(3, 4, 3, 4);
            txtScoreQuestion.Name = "txtScoreQuestion";
            txtScoreQuestion.PlaceholderText = "";
            txtScoreQuestion.SelectedText = "";
            txtScoreQuestion.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtScoreQuestion.Size = new Size(397, 39);
            txtScoreQuestion.TabIndex = 2;
            txtScoreQuestion.TextChanged += NumericTextBox_TextChanged;
            txtScoreQuestion.KeyDown += NumericTextBox_KeyDown;
            txtScoreQuestion.KeyPress += NumericTextBox_KeyPress;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(txtOptionD, 1, 3);
            tableLayoutPanel2.Controls.Add(txtOptionC, 1, 2);
            tableLayoutPanel2.Controls.Add(txtOptionB, 1, 1);
            tableLayoutPanel2.Controls.Add(txtOptionA, 1, 0);
            tableLayoutPanel2.Controls.Add(radA, 0, 0);
            tableLayoutPanel2.Controls.Add(radB, 0, 1);
            tableLayoutPanel2.Controls.Add(radC, 0, 2);
            tableLayoutPanel2.Controls.Add(radD, 0, 3);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(20, 299);
            tableLayoutPanel2.MinimumSize = new Size(996, 165);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.Size = new Size(996, 165);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // txtOptionD
            // 
            txtOptionD.BorderColor = Color.Black;
            txtOptionD.BorderRadius = 10;
            txtOptionD.CustomizableEdges = customizableEdges3;
            txtOptionD.DefaultText = "";
            txtOptionD.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtOptionD.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtOptionD.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtOptionD.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtOptionD.Dock = DockStyle.Fill;
            txtOptionD.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtOptionD.Font = new Font("Segoe UI", 9F);
            txtOptionD.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtOptionD.Location = new Point(103, 124);
            txtOptionD.Margin = new Padding(3, 4, 3, 4);
            txtOptionD.Name = "txtOptionD";
            txtOptionD.PlaceholderText = "Lựa chọn D";
            txtOptionD.SelectedText = "";
            txtOptionD.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtOptionD.Size = new Size(890, 37);
            txtOptionD.TabIndex = 9;
            // 
            // txtOptionC
            // 
            txtOptionC.BorderColor = Color.Black;
            txtOptionC.BorderRadius = 10;
            txtOptionC.CustomizableEdges = customizableEdges5;
            txtOptionC.DefaultText = "";
            txtOptionC.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtOptionC.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtOptionC.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtOptionC.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtOptionC.Dock = DockStyle.Fill;
            txtOptionC.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtOptionC.Font = new Font("Segoe UI", 9F);
            txtOptionC.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtOptionC.Location = new Point(103, 84);
            txtOptionC.Margin = new Padding(3, 4, 3, 4);
            txtOptionC.Name = "txtOptionC";
            txtOptionC.PlaceholderText = "Lựa chọn C";
            txtOptionC.SelectedText = "";
            txtOptionC.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtOptionC.Size = new Size(890, 32);
            txtOptionC.TabIndex = 7;
            // 
            // txtOptionB
            // 
            txtOptionB.BorderColor = Color.Black;
            txtOptionB.BorderRadius = 10;
            txtOptionB.CustomizableEdges = customizableEdges7;
            txtOptionB.DefaultText = "";
            txtOptionB.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtOptionB.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtOptionB.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtOptionB.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtOptionB.Dock = DockStyle.Fill;
            txtOptionB.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtOptionB.Font = new Font("Segoe UI", 9F);
            txtOptionB.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtOptionB.Location = new Point(103, 44);
            txtOptionB.Margin = new Padding(3, 4, 3, 4);
            txtOptionB.Name = "txtOptionB";
            txtOptionB.PlaceholderText = "Lựa chọn B";
            txtOptionB.SelectedText = "";
            txtOptionB.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtOptionB.Size = new Size(890, 32);
            txtOptionB.TabIndex = 5;
            // 
            // txtOptionA
            // 
            txtOptionA.BorderColor = Color.Black;
            txtOptionA.BorderRadius = 10;
            txtOptionA.CustomizableEdges = customizableEdges9;
            txtOptionA.DefaultText = "";
            txtOptionA.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtOptionA.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtOptionA.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtOptionA.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtOptionA.Dock = DockStyle.Fill;
            txtOptionA.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtOptionA.Font = new Font("Segoe UI", 9F);
            txtOptionA.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtOptionA.Location = new Point(103, 4);
            txtOptionA.Margin = new Padding(3, 4, 3, 4);
            txtOptionA.Name = "txtOptionA";
            txtOptionA.PlaceholderText = "Lựa chọn A";
            txtOptionA.SelectedText = "";
            txtOptionA.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtOptionA.Size = new Size(890, 32);
            txtOptionA.TabIndex = 3;
            // 
            // radA
            // 
            radA.AutoSize = true;
            radA.Dock = DockStyle.Fill;
            radA.Location = new Point(3, 3);
            radA.Name = "radA";
            radA.Size = new Size(94, 34);
            radA.TabIndex = 10;
            radA.TabStop = true;
            radA.Text = "A";
            radA.UseVisualStyleBackColor = true;
            // 
            // radB
            // 
            radB.AutoSize = true;
            radB.Dock = DockStyle.Fill;
            radB.Location = new Point(3, 43);
            radB.Name = "radB";
            radB.Size = new Size(94, 34);
            radB.TabIndex = 10;
            radB.TabStop = true;
            radB.Text = "B";
            radB.UseVisualStyleBackColor = true;
            // 
            // radC
            // 
            radC.AutoSize = true;
            radC.Dock = DockStyle.Fill;
            radC.Location = new Point(3, 83);
            radC.Name = "radC";
            radC.Size = new Size(94, 34);
            radC.TabIndex = 10;
            radC.TabStop = true;
            radC.Text = "C";
            radC.UseVisualStyleBackColor = true;
            // 
            // radD
            // 
            radD.AutoSize = true;
            radD.Dock = DockStyle.Fill;
            radD.Location = new Point(3, 123);
            radD.Name = "radD";
            radD.Size = new Size(94, 39);
            radD.TabIndex = 10;
            radD.TabStop = true;
            radD.Text = "D";
            radD.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(txtContentQuestion, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(20, 137);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.Size = new Size(994, 162);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(988, 30);
            label2.TabIndex = 0;
            label2.Text = "Nội dung câu hỏi *";
            // 
            // txtContentQuestion
            // 
            txtContentQuestion.BorderColor = Color.Black;
            txtContentQuestion.BorderRadius = 10;
            txtContentQuestion.CustomizableEdges = customizableEdges11;
            txtContentQuestion.DefaultText = "";
            txtContentQuestion.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtContentQuestion.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtContentQuestion.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtContentQuestion.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtContentQuestion.Dock = DockStyle.Fill;
            txtContentQuestion.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtContentQuestion.Font = new Font("Segoe UI", 9F);
            txtContentQuestion.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtContentQuestion.Location = new Point(3, 34);
            txtContentQuestion.Margin = new Padding(3, 4, 3, 4);
            txtContentQuestion.Name = "txtContentQuestion";
            txtContentQuestion.PlaceholderText = "";
            txtContentQuestion.SelectedText = "";
            txtContentQuestion.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtContentQuestion.Size = new Size(988, 94);
            txtContentQuestion.TabIndex = 1;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(3, 132);
            label3.Name = "label3";
            label3.Size = new Size(988, 30);
            label3.TabIndex = 2;
            label3.Text = "Các lựa chọn";
            // 
            // panel2
            // 
            panel2.Controls.Add(cbTypeQuestion);
            panel2.Controls.Add(lbNumberQuestion);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(20, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(994, 117);
            panel2.TabIndex = 0;
            // 
            // cbTypeQuestion
            // 
            cbTypeQuestion.BackColor = Color.Transparent;
            cbTypeQuestion.BorderRadius = 10;
            cbTypeQuestion.CustomizableEdges = customizableEdges13;
            cbTypeQuestion.DrawMode = DrawMode.OwnerDrawFixed;
            cbTypeQuestion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTypeQuestion.FillColor = Color.FromArgb(217, 217, 217);
            cbTypeQuestion.FocusedColor = Color.FromArgb(94, 148, 255);
            cbTypeQuestion.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbTypeQuestion.Font = new Font("Segoe UI", 10F);
            cbTypeQuestion.ForeColor = Color.Black;
            cbTypeQuestion.ItemHeight = 30;
            cbTypeQuestion.Items.AddRange(new object[] { "Trắc nghiệm", "Tự luận" });
            cbTypeQuestion.Location = new Point(3, 76);
            cbTypeQuestion.Name = "cbTypeQuestion";
            cbTypeQuestion.ShadowDecoration.CustomizableEdges = customizableEdges14;
            cbTypeQuestion.Size = new Size(397, 36);
            cbTypeQuestion.TabIndex = 3;
            // 
            // lbNumberQuestion
            // 
            lbNumberQuestion.AutoSize = true;
            lbNumberQuestion.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbNumberQuestion.Location = new Point(3, 0);
            lbNumberQuestion.Name = "lbNumberQuestion";
            lbNumberQuestion.Size = new Size(89, 28);
            lbNumberQuestion.TabIndex = 0;
            lbNumberQuestion.Text = "Câu hỏi ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(3, 45);
            label1.Name = "label1";
            label1.Size = new Size(126, 28);
            label1.TabIndex = 0;
            label1.Text = "Loại câu hỏi";
            // 
            // UcAddQuestion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panel1);
            Name = "UcAddQuestion";
            Size = new Size(1034, 596);
            panel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtContentQuestion;
        private Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cbTypeQuestion;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel2;
        private Guna.UI2.WinForms.Guna2TextBox txtOptionD;
        private Guna.UI2.WinForms.Guna2TextBox txtOptionC;
        private Guna.UI2.WinForms.Guna2TextBox txtOptionB;
        private Guna.UI2.WinForms.Guna2TextBox txtOptionA;
        private RadioButton radA;
        private RadioButton radB;
        private RadioButton radC;
        private RadioButton radD;
        private Label label4;
        private Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtScoreQuestion;
        private Label lbNumberQuestion;
    }
}
