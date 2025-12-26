namespace GUI.UserControls.File
{
    partial class ucserTest2
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnInputExam2 = new Panel();
            flpQuestion = new FlowLayoutPanel();
            panel3 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            btnAddQuestion = new Guna.UI2.WinForms.Guna2Button();
            pnInputExam2.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnInputExam2
            // 
            pnInputExam2.Controls.Add(flpQuestion);
            pnInputExam2.Controls.Add(panel3);
            pnInputExam2.Controls.Add(panel2);
            pnInputExam2.Dock = DockStyle.Fill;
            pnInputExam2.Location = new Point(0, 0);
            pnInputExam2.Name = "pnInputExam2";
            pnInputExam2.Size = new Size(1036, 564);
            pnInputExam2.TabIndex = 0;
            // 
            // flpQuestion
            // 
            flpQuestion.AutoScroll = true;
            flpQuestion.Dock = DockStyle.Fill;
            flpQuestion.Location = new Point(0, 63);
            flpQuestion.Name = "flpQuestion";
            flpQuestion.Size = new Size(1036, 430);
            flpQuestion.TabIndex = 2;
            flpQuestion.WrapContents = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel1);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 493);
            panel3.Name = "panel3";
            panel3.Size = new Size(1036, 71);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1036, 63);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(165, 28);
            label1.TabIndex = 0;
            label1.Text = "Tạo câu hỏi mới";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAddQuestion);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(786, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 71);
            panel1.TabIndex = 0;
            // 
            // btnAddQuestion
            // 
            btnAddQuestion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddQuestion.BorderRadius = 10;
            btnAddQuestion.CustomizableEdges = customizableEdges3;
            btnAddQuestion.FillColor = Color.FromArgb(34, 197, 94);
            btnAddQuestion.Font = new Font("Segoe UI", 9F);
            btnAddQuestion.ForeColor = Color.White;
            btnAddQuestion.Location = new Point(91, 11);
            btnAddQuestion.Margin = new Padding(0, 8, 0, 0);
            btnAddQuestion.Name = "btnAddQuestion";
            btnAddQuestion.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAddQuestion.Size = new Size(139, 40);
            btnAddQuestion.TabIndex = 2;
            btnAddQuestion.Text = "Thêm câu hỏi";
            // 
            // ucserTest2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnInputExam2);
            Name = "ucserTest2";
            Size = new Size(1036, 564);
            pnInputExam2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnInputExam2;
        private Panel panel3;
        private Panel panel2;
        private Label label1;
        private FlowLayoutPanel flpQuestion;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnAddQuestion;
    }
}
