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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnMenu = new Panel();
            pnMenuContent = new Panel();
            btnMenuExercise = new Guna.UI2.WinForms.Guna2Button();
            btnMenuExam = new Guna.UI2.WinForms.Guna2Button();
            btnMenuResearchTopic = new Guna.UI2.WinForms.Guna2Button();
            btnMenuScore = new Guna.UI2.WinForms.Guna2Button();
            btnMenuCalendar = new Guna.UI2.WinForms.Guna2Button();
            btnMenuLessonPlan = new Guna.UI2.WinForms.Guna2Button();
            btnMenuBook = new Guna.UI2.WinForms.Guna2Button();
            btnMenuManagementAccount = new Guna.UI2.WinForms.Guna2Button();
            btnMenuHome = new Guna.UI2.WinForms.Guna2Button();
            panel4 = new Panel();
            panel3 = new Panel();
            panel1 = new Panel();
            pnMenuLogo = new Panel();
            lbLogo = new Label();
            pbLogo = new PictureBox();
            pbHeader = new Panel();
            pbHeaderContent = new Panel();
            lbHeaderRole = new Label();
            pbContent = new Panel();
            pnMenu.SuspendLayout();
            pnMenuContent.SuspendLayout();
            pnMenuLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pbHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnMenu
            // 
            pnMenu.BackColor = Color.White;
            pnMenu.BorderStyle = BorderStyle.FixedSingle;
            pnMenu.Controls.Add(pnMenuContent);
            pnMenu.Controls.Add(panel1);
            pnMenu.Controls.Add(pnMenuLogo);
            pnMenu.Dock = DockStyle.Left;
            pnMenu.Location = new Point(0, 0);
            pnMenu.Name = "pnMenu";
            pnMenu.Size = new Size(240, 595);
            pnMenu.TabIndex = 0;
            // 
            // pnMenuContent
            // 
            pnMenuContent.Controls.Add(btnMenuExercise);
            pnMenuContent.Controls.Add(btnMenuExam);
            pnMenuContent.Controls.Add(btnMenuResearchTopic);
            pnMenuContent.Controls.Add(btnMenuScore);
            pnMenuContent.Controls.Add(btnMenuCalendar);
            pnMenuContent.Controls.Add(btnMenuLessonPlan);
            pnMenuContent.Controls.Add(btnMenuBook);
            pnMenuContent.Controls.Add(btnMenuManagementAccount);
            pnMenuContent.Controls.Add(btnMenuHome);
            pnMenuContent.Controls.Add(panel4);
            pnMenuContent.Controls.Add(panel3);
            pnMenuContent.Dock = DockStyle.Fill;
            pnMenuContent.Location = new Point(0, 79);
            pnMenuContent.Name = "pnMenuContent";
            pnMenuContent.Size = new Size(238, 514);
            pnMenuContent.TabIndex = 2;
            // 
            // btnMenuExercise
            // 
            btnMenuExercise.BorderRadius = 10;
            btnMenuExercise.CustomizableEdges = customizableEdges1;
            btnMenuExercise.DisabledState.BorderColor = Color.DarkGray;
            btnMenuExercise.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMenuExercise.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMenuExercise.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMenuExercise.Dock = DockStyle.Top;
            btnMenuExercise.FillColor = Color.Transparent;
            btnMenuExercise.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenuExercise.ForeColor = Color.FromArgb(104, 116, 135);
            btnMenuExercise.HoverState.FillColor = Color.FromArgb(192, 255, 255);
            btnMenuExercise.Image = Properties.Resources.homework;
            btnMenuExercise.ImageAlign = HorizontalAlignment.Left;
            btnMenuExercise.Location = new Point(15, 320);
            btnMenuExercise.Name = "btnMenuExercise";
            btnMenuExercise.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnMenuExercise.Size = new Size(208, 40);
            btnMenuExercise.TabIndex = 10;
            btnMenuExercise.Text = "Bài tập và đồ án";
            btnMenuExercise.TextAlign = HorizontalAlignment.Left;
            btnMenuExercise.Click += btnMenuExercise_Click;
            // 
            // btnMenuExam
            // 
            btnMenuExam.BorderRadius = 10;
            btnMenuExam.CustomizableEdges = customizableEdges3;
            btnMenuExam.DisabledState.BorderColor = Color.DarkGray;
            btnMenuExam.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMenuExam.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMenuExam.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMenuExam.Dock = DockStyle.Top;
            btnMenuExam.FillColor = Color.Transparent;
            btnMenuExam.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenuExam.ForeColor = Color.FromArgb(104, 116, 135);
            btnMenuExam.HoverState.FillColor = Color.FromArgb(192, 255, 255);
            btnMenuExam.Image = Properties.Resources.exam;
            btnMenuExam.ImageAlign = HorizontalAlignment.Left;
            btnMenuExam.Location = new Point(15, 280);
            btnMenuExam.Name = "btnMenuExam";
            btnMenuExam.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnMenuExam.Size = new Size(208, 40);
            btnMenuExam.TabIndex = 9;
            btnMenuExam.Text = "Quản lý đề thi";
            btnMenuExam.TextAlign = HorizontalAlignment.Left;
            btnMenuExam.Click += btnMenuExam_Click;
            // 
            // btnMenuResearchTopic
            // 
            btnMenuResearchTopic.BorderRadius = 10;
            btnMenuResearchTopic.CustomizableEdges = customizableEdges5;
            btnMenuResearchTopic.DisabledState.BorderColor = Color.DarkGray;
            btnMenuResearchTopic.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMenuResearchTopic.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMenuResearchTopic.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMenuResearchTopic.Dock = DockStyle.Top;
            btnMenuResearchTopic.FillColor = Color.Transparent;
            btnMenuResearchTopic.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenuResearchTopic.ForeColor = Color.FromArgb(104, 116, 135);
            btnMenuResearchTopic.HoverState.FillColor = Color.FromArgb(192, 255, 255);
            btnMenuResearchTopic.Image = Properties.Resources.idea;
            btnMenuResearchTopic.ImageAlign = HorizontalAlignment.Left;
            btnMenuResearchTopic.Location = new Point(15, 240);
            btnMenuResearchTopic.Name = "btnMenuResearchTopic";
            btnMenuResearchTopic.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnMenuResearchTopic.Size = new Size(208, 40);
            btnMenuResearchTopic.TabIndex = 8;
            btnMenuResearchTopic.Text = "Đề tài nghiên cứu";
            btnMenuResearchTopic.TextAlign = HorizontalAlignment.Left;
            btnMenuResearchTopic.Click += btnMenuResearchTopic_Click;
            // 
            // btnMenuScore
            // 
            btnMenuScore.BorderRadius = 10;
            btnMenuScore.CustomizableEdges = customizableEdges7;
            btnMenuScore.DisabledState.BorderColor = Color.DarkGray;
            btnMenuScore.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMenuScore.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMenuScore.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMenuScore.Dock = DockStyle.Top;
            btnMenuScore.FillColor = Color.Transparent;
            btnMenuScore.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenuScore.ForeColor = Color.FromArgb(104, 116, 135);
            btnMenuScore.HoverState.FillColor = Color.FromArgb(192, 255, 255);
            btnMenuScore.Image = Properties.Resources.score;
            btnMenuScore.ImageAlign = HorizontalAlignment.Left;
            btnMenuScore.Location = new Point(15, 200);
            btnMenuScore.Name = "btnMenuScore";
            btnMenuScore.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnMenuScore.Size = new Size(208, 40);
            btnMenuScore.TabIndex = 7;
            btnMenuScore.Text = "Quản lý điểm";
            btnMenuScore.TextAlign = HorizontalAlignment.Left;
            btnMenuScore.Click += btnMenuScore_Click;
            // 
            // btnMenuCalendar
            // 
            btnMenuCalendar.BorderRadius = 10;
            btnMenuCalendar.CustomizableEdges = customizableEdges9;
            btnMenuCalendar.DisabledState.BorderColor = Color.DarkGray;
            btnMenuCalendar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMenuCalendar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMenuCalendar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMenuCalendar.Dock = DockStyle.Top;
            btnMenuCalendar.FillColor = Color.Transparent;
            btnMenuCalendar.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenuCalendar.ForeColor = Color.FromArgb(104, 116, 135);
            btnMenuCalendar.HoverState.FillColor = Color.FromArgb(192, 255, 255);
            btnMenuCalendar.Image = Properties.Resources.calendar;
            btnMenuCalendar.ImageAlign = HorizontalAlignment.Left;
            btnMenuCalendar.Location = new Point(15, 160);
            btnMenuCalendar.Name = "btnMenuCalendar";
            btnMenuCalendar.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnMenuCalendar.Size = new Size(208, 40);
            btnMenuCalendar.TabIndex = 6;
            btnMenuCalendar.Text = "Lịch dạy";
            btnMenuCalendar.TextAlign = HorizontalAlignment.Left;
            btnMenuCalendar.Click += btnMenuCalendar_Click;
            // 
            // btnMenuLessonPlan
            // 
            btnMenuLessonPlan.BorderRadius = 10;
            btnMenuLessonPlan.CustomizableEdges = customizableEdges11;
            btnMenuLessonPlan.DisabledState.BorderColor = Color.DarkGray;
            btnMenuLessonPlan.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMenuLessonPlan.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMenuLessonPlan.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMenuLessonPlan.Dock = DockStyle.Top;
            btnMenuLessonPlan.FillColor = Color.Transparent;
            btnMenuLessonPlan.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenuLessonPlan.ForeColor = Color.FromArgb(104, 116, 135);
            btnMenuLessonPlan.HoverState.FillColor = Color.FromArgb(192, 255, 255);
            btnMenuLessonPlan.Image = Properties.Resources.lessonPlan;
            btnMenuLessonPlan.ImageAlign = HorizontalAlignment.Left;
            btnMenuLessonPlan.Location = new Point(15, 120);
            btnMenuLessonPlan.Name = "btnMenuLessonPlan";
            btnMenuLessonPlan.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnMenuLessonPlan.Size = new Size(208, 40);
            btnMenuLessonPlan.TabIndex = 5;
            btnMenuLessonPlan.Text = "Giáo án";
            btnMenuLessonPlan.TextAlign = HorizontalAlignment.Left;
            btnMenuLessonPlan.Click += btnMenuLessonPlan_Click;
            // 
            // btnMenuBook
            // 
            btnMenuBook.BorderRadius = 10;
            btnMenuBook.CustomizableEdges = customizableEdges13;
            btnMenuBook.DisabledState.BorderColor = Color.DarkGray;
            btnMenuBook.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMenuBook.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMenuBook.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMenuBook.Dock = DockStyle.Top;
            btnMenuBook.FillColor = Color.Transparent;
            btnMenuBook.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenuBook.ForeColor = Color.FromArgb(104, 116, 135);
            btnMenuBook.HoverState.FillColor = Color.FromArgb(192, 255, 255);
            btnMenuBook.Image = Properties.Resources.book;
            btnMenuBook.ImageAlign = HorizontalAlignment.Left;
            btnMenuBook.Location = new Point(15, 80);
            btnMenuBook.Name = "btnMenuBook";
            btnMenuBook.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnMenuBook.Size = new Size(208, 40);
            btnMenuBook.TabIndex = 4;
            btnMenuBook.Text = "Sách và giáo trình";
            btnMenuBook.TextAlign = HorizontalAlignment.Left;
            btnMenuBook.Click += btnMenuBook_Click;
            // 
            // btnMenuManagementAccount
            // 
            btnMenuManagementAccount.BorderRadius = 10;
            btnMenuManagementAccount.CustomizableEdges = customizableEdges15;
            btnMenuManagementAccount.DisabledState.BorderColor = Color.DarkGray;
            btnMenuManagementAccount.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMenuManagementAccount.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMenuManagementAccount.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMenuManagementAccount.Dock = DockStyle.Top;
            btnMenuManagementAccount.FillColor = Color.Transparent;
            btnMenuManagementAccount.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenuManagementAccount.ForeColor = Color.FromArgb(104, 116, 135);
            btnMenuManagementAccount.HoverState.FillColor = Color.FromArgb(192, 255, 255);
            btnMenuManagementAccount.Image = Properties.Resources.user;
            btnMenuManagementAccount.ImageAlign = HorizontalAlignment.Left;
            btnMenuManagementAccount.Location = new Point(15, 40);
            btnMenuManagementAccount.Name = "btnMenuManagementAccount";
            btnMenuManagementAccount.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnMenuManagementAccount.Size = new Size(208, 40);
            btnMenuManagementAccount.TabIndex = 3;
            btnMenuManagementAccount.Text = "Quản lý tài khoản";
            btnMenuManagementAccount.TextAlign = HorizontalAlignment.Left;
            btnMenuManagementAccount.Click += btnMenuManagementAccount_Click;
            // 
            // btnMenuHome
            // 
            btnMenuHome.BorderRadius = 10;
            btnMenuHome.CustomizableEdges = customizableEdges17;
            btnMenuHome.DisabledState.BorderColor = Color.DarkGray;
            btnMenuHome.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMenuHome.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMenuHome.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMenuHome.Dock = DockStyle.Top;
            btnMenuHome.FillColor = Color.Transparent;
            btnMenuHome.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenuHome.ForeColor = Color.FromArgb(104, 116, 135);
            btnMenuHome.HoverState.FillColor = Color.FromArgb(192, 255, 255);
            btnMenuHome.Image = Properties.Resources.home;
            btnMenuHome.ImageAlign = HorizontalAlignment.Left;
            btnMenuHome.Location = new Point(15, 0);
            btnMenuHome.Name = "btnMenuHome";
            btnMenuHome.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnMenuHome.Size = new Size(208, 40);
            btnMenuHome.TabIndex = 2;
            btnMenuHome.Text = "Tổng quan";
            btnMenuHome.TextAlign = HorizontalAlignment.Left;
            btnMenuHome.Click += btnMenuHome_Click;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(15, 514);
            panel4.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(223, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(15, 514);
            panel3.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(238, 15);
            panel1.TabIndex = 1;
            // 
            // pnMenuLogo
            // 
            pnMenuLogo.BackColor = Color.White;
            pnMenuLogo.Controls.Add(lbLogo);
            pnMenuLogo.Controls.Add(pbLogo);
            pnMenuLogo.Dock = DockStyle.Top;
            pnMenuLogo.Location = new Point(0, 0);
            pnMenuLogo.Name = "pnMenuLogo";
            pnMenuLogo.Size = new Size(238, 64);
            pnMenuLogo.TabIndex = 0;
            // 
            // lbLogo
            // 
            lbLogo.BackColor = Color.White;
            lbLogo.Dock = DockStyle.Fill;
            lbLogo.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogo.Location = new Point(125, 0);
            lbLogo.Name = "lbLogo";
            lbLogo.Size = new Size(113, 64);
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
            pbHeader.BorderStyle = BorderStyle.Fixed3D;
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
            pbHeaderContent.Size = new Size(922, 60);
            pbHeaderContent.TabIndex = 1;
            // 
            // lbHeaderRole
            // 
            lbHeaderRole.Dock = DockStyle.Right;
            lbHeaderRole.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHeaderRole.ImageAlign = ContentAlignment.MiddleLeft;
            lbHeaderRole.Location = new Point(922, 0);
            lbHeaderRole.Name = "lbHeaderRole";
            lbHeaderRole.Size = new Size(150, 60);
            lbHeaderRole.TabIndex = 0;
            lbHeaderRole.Text = "Admin";
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
            pnMenuContent.ResumeLayout(false);
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
        private Label lbHeaderRole;
        private Panel pbHeaderContent;
        private Panel pbContent;
        private Panel pnMenuContent;
        private Panel panel4;
        private Panel panel3;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnMenuExercise;
        private Guna.UI2.WinForms.Guna2Button btnMenuExam;
        private Guna.UI2.WinForms.Guna2Button btnMenuResearchTopic;
        private Guna.UI2.WinForms.Guna2Button btnMenuScore;
        private Guna.UI2.WinForms.Guna2Button btnMenuCalendar;
        private Guna.UI2.WinForms.Guna2Button btnMenuLessonPlan;
        private Guna.UI2.WinForms.Guna2Button btnMenuBook;
        private Guna.UI2.WinForms.Guna2Button btnMenuManagementAccount;
        private Guna.UI2.WinForms.Guna2Button btnMenuHome;
    }
}
