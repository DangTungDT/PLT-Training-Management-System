using System.Drawing;

namespace GUI
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnMenu = new Panel();
            btnMenuExercise = new Button();
            btnMenuExam = new Button();
            btnMenuResearchTopic = new Button();
            btnMenuScore = new Button();
            btnMenuCalendar = new Button();
            btnMenuLessonPlan = new Button();
            btnMenuBook = new Button();
            btnMenuManagementAccount = new Button();
            btnMenuHome = new Button();
            pnMenuLogo = new Panel();
            lbLogo = new Label();
            pbLogo = new PictureBox();
            pbHeader = new Panel();
            pbHeaderContent = new Panel();
            lbHeaderRole = new Label();
            pbContent = new Panel();
            pnMenu.SuspendLayout();
            pnMenuLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pbHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnMenu
            // 
            pnMenu.BackColor = Color.White;
            pnMenu.Controls.Add(btnMenuExercise);
            pnMenu.Controls.Add(btnMenuExam);
            pnMenu.Controls.Add(btnMenuResearchTopic);
            pnMenu.Controls.Add(btnMenuScore);
            pnMenu.Controls.Add(btnMenuCalendar);
            pnMenu.Controls.Add(btnMenuLessonPlan);
            pnMenu.Controls.Add(btnMenuBook);
            pnMenu.Controls.Add(btnMenuManagementAccount);
            pnMenu.Controls.Add(btnMenuHome);
            pnMenu.Controls.Add(pnMenuLogo);
            pnMenu.Dock = DockStyle.Left;
            pnMenu.Location = new Point(0, 0);
            pnMenu.Name = "pnMenu";
            pnMenu.Size = new Size(240, 595);
            pnMenu.TabIndex = 0;
            // 
            // btnMenuExercise
            // 
            btnMenuExercise.BackColor = Color.White;
            btnMenuExercise.Dock = DockStyle.Top;
            btnMenuExercise.FlatAppearance.BorderSize = 0;
            btnMenuExercise.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            btnMenuExercise.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnMenuExercise.FlatStyle = FlatStyle.Flat;
            btnMenuExercise.ForeColor = Color.Black;
            btnMenuExercise.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuExercise.Location = new Point(0, 464);
            btnMenuExercise.Name = "btnMenuExercise";
            btnMenuExercise.Size = new Size(240, 50);
            btnMenuExercise.TabIndex = 9;
            btnMenuExercise.Text = "Bài tập và đồ án";
            btnMenuExercise.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuExercise.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuExercise.UseVisualStyleBackColor = false;
            btnMenuExercise.Click += btnMenuExercise_Click;
            // 
            // btnMenuExam
            // 
            btnMenuExam.BackColor = Color.White;
            btnMenuExam.Dock = DockStyle.Top;
            btnMenuExam.FlatAppearance.BorderSize = 0;
            btnMenuExam.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            btnMenuExam.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnMenuExam.FlatStyle = FlatStyle.Flat;
            btnMenuExam.ForeColor = Color.Black;
            btnMenuExam.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuExam.Location = new Point(0, 414);
            btnMenuExam.Name = "btnMenuExam";
            btnMenuExam.Size = new Size(240, 50);
            btnMenuExam.TabIndex = 8;
            btnMenuExam.Text = "Quản lý đề thi";
            btnMenuExam.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuExam.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuExam.UseVisualStyleBackColor = false;
            btnMenuExam.Click += btnMenuExam_Click;
            // 
            // btnMenuResearchTopic
            // 
            btnMenuResearchTopic.BackColor = Color.White;
            btnMenuResearchTopic.Dock = DockStyle.Top;
            btnMenuResearchTopic.FlatAppearance.BorderSize = 0;
            btnMenuResearchTopic.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            btnMenuResearchTopic.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnMenuResearchTopic.FlatStyle = FlatStyle.Flat;
            btnMenuResearchTopic.ForeColor = Color.Black;
            btnMenuResearchTopic.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuResearchTopic.Location = new Point(0, 364);
            btnMenuResearchTopic.Name = "btnMenuResearchTopic";
            btnMenuResearchTopic.Size = new Size(240, 50);
            btnMenuResearchTopic.TabIndex = 7;
            btnMenuResearchTopic.Text = "Đề tài nghiên cứu";
            btnMenuResearchTopic.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuResearchTopic.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuResearchTopic.UseVisualStyleBackColor = false;
            btnMenuResearchTopic.Click += btnMenuResearchTopic_Click;
            // 
            // btnMenuScore
            // 
            btnMenuScore.BackColor = Color.White;
            btnMenuScore.Dock = DockStyle.Top;
            btnMenuScore.FlatAppearance.BorderSize = 0;
            btnMenuScore.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            btnMenuScore.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnMenuScore.FlatStyle = FlatStyle.Flat;
            btnMenuScore.ForeColor = Color.Black;
            btnMenuScore.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuScore.Location = new Point(0, 314);
            btnMenuScore.Name = "btnMenuScore";
            btnMenuScore.Size = new Size(240, 50);
            btnMenuScore.TabIndex = 6;
            btnMenuScore.Text = "Quản lý điểm";
            btnMenuScore.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuScore.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuScore.UseVisualStyleBackColor = false;
            btnMenuScore.Click += btnMenuScore_Click;
            // 
            // btnMenuCalendar
            // 
            btnMenuCalendar.BackColor = Color.White;
            btnMenuCalendar.Dock = DockStyle.Top;
            btnMenuCalendar.FlatAppearance.BorderSize = 0;
            btnMenuCalendar.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            btnMenuCalendar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnMenuCalendar.FlatStyle = FlatStyle.Flat;
            btnMenuCalendar.ForeColor = Color.Black;
            btnMenuCalendar.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuCalendar.Location = new Point(0, 264);
            btnMenuCalendar.Name = "btnMenuCalendar";
            btnMenuCalendar.Size = new Size(240, 50);
            btnMenuCalendar.TabIndex = 5;
            btnMenuCalendar.Text = "Lịch dạy";
            btnMenuCalendar.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuCalendar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuCalendar.UseVisualStyleBackColor = false;
            btnMenuCalendar.Click += btnMenuCalendar_Click;
            // 
            // btnMenuLessonPlan
            // 
            btnMenuLessonPlan.BackColor = Color.White;
            btnMenuLessonPlan.Dock = DockStyle.Top;
            btnMenuLessonPlan.FlatAppearance.BorderSize = 0;
            btnMenuLessonPlan.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            btnMenuLessonPlan.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnMenuLessonPlan.FlatStyle = FlatStyle.Flat;
            btnMenuLessonPlan.ForeColor = Color.Black;
            btnMenuLessonPlan.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuLessonPlan.Location = new Point(0, 214);
            btnMenuLessonPlan.Name = "btnMenuLessonPlan";
            btnMenuLessonPlan.Size = new Size(240, 50);
            btnMenuLessonPlan.TabIndex = 4;
            btnMenuLessonPlan.Text = "Giáo án";
            btnMenuLessonPlan.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuLessonPlan.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuLessonPlan.UseVisualStyleBackColor = false;
            btnMenuLessonPlan.Click += btnMenuLessonPlan_Click;
            // 
            // btnMenuBook
            // 
            btnMenuBook.BackColor = Color.White;
            btnMenuBook.Dock = DockStyle.Top;
            btnMenuBook.FlatAppearance.BorderSize = 0;
            btnMenuBook.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            btnMenuBook.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnMenuBook.FlatStyle = FlatStyle.Flat;
            btnMenuBook.ForeColor = Color.Black;
            btnMenuBook.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuBook.Location = new Point(0, 164);
            btnMenuBook.Name = "btnMenuBook";
            btnMenuBook.Size = new Size(240, 50);
            btnMenuBook.TabIndex = 3;
            btnMenuBook.Text = "Sách và giáo trình";
            btnMenuBook.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuBook.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuBook.UseVisualStyleBackColor = false;
            btnMenuBook.Click += btnMenuBook_Click;
            // 
            // btnMenuManagementAccount
            // 
            btnMenuManagementAccount.BackColor = Color.White;
            btnMenuManagementAccount.Dock = DockStyle.Top;
            btnMenuManagementAccount.FlatAppearance.BorderSize = 0;
            btnMenuManagementAccount.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            btnMenuManagementAccount.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnMenuManagementAccount.FlatStyle = FlatStyle.Flat;
            btnMenuManagementAccount.ForeColor = Color.Black;
            btnMenuManagementAccount.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuManagementAccount.Location = new Point(0, 114);
            btnMenuManagementAccount.Name = "btnMenuManagementAccount";
            btnMenuManagementAccount.Size = new Size(240, 50);
            btnMenuManagementAccount.TabIndex = 2;
            btnMenuManagementAccount.Text = "Quản lý tài khoản";
            btnMenuManagementAccount.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuManagementAccount.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuManagementAccount.UseVisualStyleBackColor = false;
            btnMenuManagementAccount.Click += btnMenuManagementAccount_Click;
            // 
            // btnMenuHome
            // 
            btnMenuHome.BackColor = Color.White;
            btnMenuHome.Dock = DockStyle.Top;
            btnMenuHome.FlatAppearance.BorderSize = 0;
            btnMenuHome.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            btnMenuHome.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnMenuHome.FlatStyle = FlatStyle.Flat;
            btnMenuHome.ForeColor = Color.Black;
            btnMenuHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuHome.Location = new Point(0, 64);
            btnMenuHome.Name = "btnMenuHome";
            btnMenuHome.Size = new Size(240, 50);
            btnMenuHome.TabIndex = 1;
            btnMenuHome.Text = "Tổng quan";
            btnMenuHome.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuHome.UseVisualStyleBackColor = false;
            btnMenuHome.Click += btnMenuHome_Click;
            // 
            // pnMenuLogo
            // 
            pnMenuLogo.BackColor = Color.White;
            pnMenuLogo.Controls.Add(lbLogo);
            pnMenuLogo.Controls.Add(pbLogo);
            pnMenuLogo.Dock = DockStyle.Top;
            pnMenuLogo.Location = new Point(0, 0);
            pnMenuLogo.Name = "pnMenuLogo";
            pnMenuLogo.Size = new Size(240, 64);
            pnMenuLogo.TabIndex = 0;
            // 
            // lbLogo
            // 
            lbLogo.BackColor = Color.White;
            lbLogo.Dock = DockStyle.Fill;
            lbLogo.Location = new Point(125, 0);
            lbLogo.Name = "lbLogo";
            lbLogo.Size = new Size(115, 64);
            lbLogo.TabIndex = 1;
            lbLogo.Text = "PTM";
            lbLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbLogo
            // 
            pbLogo.BackColor = Color.White;
            pbLogo.Dock = DockStyle.Left;
            pbLogo.Image = Properties.Resources.card;
            pbLogo.Location = new Point(0, 0);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(125, 64);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // pbHeader
            // 
            pbHeader.BackColor = Color.White;
            pbHeader.Controls.Add(pbHeaderContent);
            pbHeader.Controls.Add(lbHeaderRole);
            pbHeader.Dock = DockStyle.Top;
            pbHeader.Location = new Point(240, 0);
            pbHeader.Name = "pbHeader";
            pbHeader.Size = new Size(1076, 64);
            pbHeader.TabIndex = 1;
            // 
            // pbHeaderContent
            // 
            pbHeaderContent.Dock = DockStyle.Fill;
            pbHeaderContent.Location = new Point(0, 0);
            pbHeaderContent.Name = "pbHeaderContent";
            pbHeaderContent.Size = new Size(926, 64);
            pbHeaderContent.TabIndex = 1;
            // 
            // lbHeaderRole
            // 
            lbHeaderRole.Dock = DockStyle.Right;
            lbHeaderRole.ImageAlign = ContentAlignment.MiddleLeft;
            lbHeaderRole.Location = new Point(926, 0);
            lbHeaderRole.Name = "lbHeaderRole";
            lbHeaderRole.Size = new Size(150, 64);
            lbHeaderRole.TabIndex = 0;
            lbHeaderRole.Text = "label1";
            lbHeaderRole.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbContent
            // 
            pbContent.Dock = DockStyle.Fill;
            pbContent.Location = new Point(240, 64);
            pbContent.Name = "pbContent";
            pbContent.Size = new Size(1076, 531);
            pbContent.TabIndex = 2;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1316, 595);
            Controls.Add(pbContent);
            Controls.Add(pbHeader);
            Controls.Add(pnMenu);
            Name = "Main";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Main_Load;
            pnMenu.ResumeLayout(false);
            pnMenuLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            pbHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnMenu;
        private Panel pbHeader;
        private Panel pnMenuLogo;
        private Label lbLogo;
        private PictureBox pbLogo;
        private Button btnMenuExercise;
        private Button btnMenuExam;
        private Button btnMenuResearchTopic;
        private Button btnMenuScore;
        private Button btnMenuCalendar;
        private Button btnMenuLessonPlan;
        private Button btnMenuBook;
        private Button btnMenuManagementAccount;
        private Button btnMenuHome;
        private Label lbHeaderRole;
        private Panel pbHeaderContent;
        private Panel pbContent;
    }
}
