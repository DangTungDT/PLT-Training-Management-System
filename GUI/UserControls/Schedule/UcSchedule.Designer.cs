using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace GUI.UserControls.Schedule
{
    partial class UcSchedule
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        #region Designer fields
        private Guna2Panel panelHeader;
        private Label lblTitle;
        private Label lblSubtitle;

        private Guna2Panel panelContent;
        private TableLayoutPanel tlpTop;
        private Label lblLichDay;
        private Label lblLichDayTuan;

        private TableLayoutPanel tlpMain;
        #endregion

        #region Dispose
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #endregion

        #region Component Designer generated code

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges39 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges40 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges29 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges30 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges31 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges32 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges33 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges34 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges35 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges36 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges37 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges38 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelHeader = new Guna2Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            panelContent = new Guna2Panel();
            tlpMain = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            guna2Panel15 = new Guna2Panel();
            flpScheduleSundayA = new FlowLayoutPanel();
            lbCourseNameSundayA = new Label();
            lbClassSundayA = new Label();
            lbTimeSundayA = new Label();
            lbRoomSundayA = new Label();
            panel8 = new Panel();
            guna2Panel14 = new Guna2Panel();
            flpScheduleSaturdayA = new FlowLayoutPanel();
            lbCourseNameSaturdayA = new Label();
            lbClassSaturdayA = new Label();
            lbTimeSaturdayA = new Label();
            lbRoomSaturdayA = new Label();
            panel9 = new Panel();
            guna2Panel13 = new Guna2Panel();
            flpScheduleFridayA = new FlowLayoutPanel();
            lbCourseNameFridayA = new Label();
            lbClassFridayA = new Label();
            lbTimeFridayA = new Label();
            lbRoomFridayA = new Label();
            panel10 = new Panel();
            guna2Panel12 = new Guna2Panel();
            flpScheduleThursdayA = new FlowLayoutPanel();
            lbCourseNameThursdayA = new Label();
            lbClassThursdayA = new Label();
            lbTimeThursdayA = new Label();
            lbRoomThursdayA = new Label();
            panel11 = new Panel();
            guna2Panel11 = new Guna2Panel();
            flpScheduleWednesdayA = new FlowLayoutPanel();
            lbCourseNameWednesdayA = new Label();
            lbClassWednesdayA = new Label();
            lbTimeWednesdayA = new Label();
            lbRoomWednesdayA = new Label();
            panel12 = new Panel();
            guna2Panel10 = new Guna2Panel();
            flpScheduleTuesdayA = new FlowLayoutPanel();
            lbCourseNameTuesdayA = new Label();
            lbClassTuesdayA = new Label();
            lbTimeTuesdayA = new Label();
            lbRoomTuesdayA = new Label();
            panel13 = new Panel();
            guna2Panel9 = new Guna2Panel();
            flpScheduleMondayA = new FlowLayoutPanel();
            lbCourseNameMondayA = new Label();
            lbClassMondayA = new Label();
            lbTimeMondayA = new Label();
            lbRoomMondayA = new Label();
            panel14 = new Panel();
            guna2Panel8 = new Guna2Panel();
            panel16 = new Panel();
            flpScheduleSundayM = new FlowLayoutPanel();
            lbCourseNameSundayM = new Label();
            lbClassSundayM = new Label();
            lbTimeSundayM = new Label();
            lbRoomSundayM = new Label();
            panel7 = new Panel();
            guna2Panel7 = new Guna2Panel();
            panel17 = new Panel();
            flpScheduleSaturdayM = new FlowLayoutPanel();
            lbCourseNameSaturdayM = new Label();
            lbClassSaturdayM = new Label();
            lbTimeSaturdayM = new Label();
            lbRoomSaturdayM = new Label();
            panel6 = new Panel();
            guna2Panel6 = new Guna2Panel();
            panel18 = new Panel();
            flpScheduleFridayM = new FlowLayoutPanel();
            lbCourseNameFridayM = new Label();
            lbClassFridayM = new Label();
            lbTimeFridayM = new Label();
            lbRoomFridayM = new Label();
            panel5 = new Panel();
            guna2Panel5 = new Guna2Panel();
            panel19 = new Panel();
            flpScheduleThursdayM = new FlowLayoutPanel();
            lbCourseNameThursdayM = new Label();
            lbClassThursdayM = new Label();
            lbTimeThursdayM = new Label();
            lbRoomThursdayM = new Label();
            panel4 = new Panel();
            guna2Panel4 = new Guna2Panel();
            panel20 = new Panel();
            flpScheduleWednesdayM = new FlowLayoutPanel();
            lbCourseNameWednesdayM = new Label();
            lbClassWednesdayM = new Label();
            lbTimeWednesdayM = new Label();
            lbRoomWednesdayM = new Label();
            panel3 = new Panel();
            guna2Panel3 = new Guna2Panel();
            panel21 = new Panel();
            flpScheduleTuesdayM = new FlowLayoutPanel();
            lbCourseNameTuesdayM = new Label();
            lbClassTuesdayM = new Label();
            lbTimeTuesdayM = new Label();
            lbRoomTuesdayM = new Label();
            panel2 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label1 = new Label();
            label4 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            guna2Panel1 = new Guna2Panel();
            panel22 = new Panel();
            flpScheduleMondayM = new FlowLayoutPanel();
            lbCourseNameMondayM = new Label();
            lbClassMondayM = new Label();
            lbTimeMondayM = new Label();
            lbRoomMondayM = new Label();
            panel1 = new Panel();
            panel15 = new Panel();
            lbWeek = new Label();
            tlpTop = new TableLayoutPanel();
            lblLichDay = new Label();
            lblLichDayTuan = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            cbWeek = new Guna2ComboBox();
            cbSemester = new Guna2ComboBox();
            lb5 = new Label();
            label3 = new Label();
            label2 = new Label();
            cbSchool = new Guna2ComboBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnAddSchedule = new Guna2Button();
            panelHeader.SuspendLayout();
            panelContent.SuspendLayout();
            tlpMain.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            guna2Panel15.SuspendLayout();
            flpScheduleSundayA.SuspendLayout();
            guna2Panel14.SuspendLayout();
            flpScheduleSaturdayA.SuspendLayout();
            guna2Panel13.SuspendLayout();
            flpScheduleFridayA.SuspendLayout();
            guna2Panel12.SuspendLayout();
            flpScheduleThursdayA.SuspendLayout();
            guna2Panel11.SuspendLayout();
            flpScheduleWednesdayA.SuspendLayout();
            guna2Panel10.SuspendLayout();
            flpScheduleTuesdayA.SuspendLayout();
            guna2Panel9.SuspendLayout();
            flpScheduleMondayA.SuspendLayout();
            guna2Panel8.SuspendLayout();
            flpScheduleSundayM.SuspendLayout();
            guna2Panel7.SuspendLayout();
            flpScheduleSaturdayM.SuspendLayout();
            guna2Panel6.SuspendLayout();
            flpScheduleFridayM.SuspendLayout();
            guna2Panel5.SuspendLayout();
            flpScheduleThursdayM.SuspendLayout();
            guna2Panel4.SuspendLayout();
            flpScheduleWednesdayM.SuspendLayout();
            guna2Panel3.SuspendLayout();
            flpScheduleTuesdayM.SuspendLayout();
            guna2Panel1.SuspendLayout();
            flpScheduleMondayM.SuspendLayout();
            tlpTop.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.Transparent;
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.CustomizableEdges = customizableEdges1;
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Padding = new Padding(24, 20, 24, 10);
            panelHeader.ShadowDecoration.CustomizableEdges = customizableEdges2;
            panelHeader.Size = new Size(1100, 110);
            panelHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(21, 32, 43);
            lblTitle.Location = new Point(24, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(281, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Quản lý Lịch dạy";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(120, 130, 145);
            lblSubtitle.Location = new Point(24, 60);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(332, 23);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Tạo, chỉnh sửa và quản lý lịch dạy của bạn";
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.WhiteSmoke;
            panelContent.Controls.Add(tlpMain);
            panelContent.Controls.Add(tlpTop);
            panelContent.CustomizableEdges = customizableEdges39;
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 110);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(24);
            panelContent.ShadowDecoration.CustomizableEdges = customizableEdges40;
            panelContent.Size = new Size(1100, 610);
            panelContent.TabIndex = 0;
            // 
            // tlpMain
            // 
            tlpMain.BackColor = Color.White;
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(tableLayoutPanel2, 0, 1);
            tlpMain.Controls.Add(lbWeek, 0, 0);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(24, 176);
            tlpMain.Name = "tlpMain";
            tlpMain.Padding = new Padding(12);
            tlpMain.RowCount = 2;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.Size = new Size(1052, 410);
            tlpMain.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 8;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.Controls.Add(guna2Panel15, 7, 2);
            tableLayoutPanel2.Controls.Add(guna2Panel14, 6, 2);
            tableLayoutPanel2.Controls.Add(guna2Panel13, 5, 2);
            tableLayoutPanel2.Controls.Add(guna2Panel12, 4, 2);
            tableLayoutPanel2.Controls.Add(guna2Panel11, 3, 2);
            tableLayoutPanel2.Controls.Add(guna2Panel10, 2, 2);
            tableLayoutPanel2.Controls.Add(guna2Panel9, 1, 2);
            tableLayoutPanel2.Controls.Add(guna2Panel8, 7, 1);
            tableLayoutPanel2.Controls.Add(guna2Panel7, 6, 1);
            tableLayoutPanel2.Controls.Add(guna2Panel6, 5, 1);
            tableLayoutPanel2.Controls.Add(guna2Panel5, 4, 1);
            tableLayoutPanel2.Controls.Add(guna2Panel4, 3, 1);
            tableLayoutPanel2.Controls.Add(guna2Panel3, 2, 1);
            tableLayoutPanel2.Controls.Add(label8, 7, 0);
            tableLayoutPanel2.Controls.Add(label7, 6, 0);
            tableLayoutPanel2.Controls.Add(label1, 5, 0);
            tableLayoutPanel2.Controls.Add(label4, 4, 0);
            tableLayoutPanel2.Controls.Add(label9, 3, 0);
            tableLayoutPanel2.Controls.Add(label10, 2, 0);
            tableLayoutPanel2.Controls.Add(label11, 1, 0);
            tableLayoutPanel2.Controls.Add(label12, 0, 1);
            tableLayoutPanel2.Controls.Add(label13, 0, 2);
            tableLayoutPanel2.Controls.Add(guna2Panel1, 1, 1);
            tableLayoutPanel2.Controls.Add(panel15, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(15, 65);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1022, 330);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // guna2Panel15
            // 
            guna2Panel15.Controls.Add(flpScheduleSundayA);
            guna2Panel15.Controls.Add(panel8);
            guna2Panel15.CustomizableEdges = customizableEdges3;
            guna2Panel15.Dock = DockStyle.Fill;
            guna2Panel15.Location = new Point(882, 185);
            guna2Panel15.Margin = new Padding(0);
            guna2Panel15.Name = "guna2Panel15";
            guna2Panel15.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel15.Size = new Size(140, 145);
            guna2Panel15.TabIndex = 38;
            // 
            // flpScheduleSundayA
            // 
            flpScheduleSundayA.Controls.Add(lbCourseNameSundayA);
            flpScheduleSundayA.Controls.Add(lbClassSundayA);
            flpScheduleSundayA.Controls.Add(lbTimeSundayA);
            flpScheduleSundayA.Controls.Add(lbRoomSundayA);
            flpScheduleSundayA.Dock = DockStyle.Fill;
            flpScheduleSundayA.FlowDirection = FlowDirection.TopDown;
            flpScheduleSundayA.Location = new Point(0, 0);
            flpScheduleSundayA.Name = "flpScheduleSundayA";
            flpScheduleSundayA.Padding = new Padding(5);
            flpScheduleSundayA.Size = new Size(139, 145);
            flpScheduleSundayA.TabIndex = 2;
            flpScheduleSundayA.WrapContents = false;
            // 
            // lbCourseNameSundayA
            // 
            lbCourseNameSundayA.AutoSize = true;
            lbCourseNameSundayA.BackColor = Color.Transparent;
            lbCourseNameSundayA.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCourseNameSundayA.Location = new Point(8, 5);
            lbCourseNameSundayA.Name = "lbCourseNameSundayA";
            lbCourseNameSundayA.Size = new Size(83, 23);
            lbCourseNameSundayA.TabIndex = 0;
            lbCourseNameSundayA.Text = "Khoá học";
            // 
            // lbClassSundayA
            // 
            lbClassSundayA.AutoSize = true;
            lbClassSundayA.BackColor = Color.Transparent;
            lbClassSundayA.Location = new Point(8, 28);
            lbClassSundayA.Name = "lbClassSundayA";
            lbClassSundayA.Size = new Size(34, 20);
            lbClassSundayA.TabIndex = 1;
            lbClassSundayA.Text = "Lớp";
            // 
            // lbTimeSundayA
            // 
            lbTimeSundayA.AutoSize = true;
            lbTimeSundayA.BackColor = Color.Transparent;
            lbTimeSundayA.Location = new Point(8, 48);
            lbTimeSundayA.Name = "lbTimeSundayA";
            lbTimeSundayA.Size = new Size(71, 20);
            lbTimeSundayA.TabIndex = 2;
            lbTimeSundayA.Text = "Thời gian";
            // 
            // lbRoomSundayA
            // 
            lbRoomSundayA.AutoSize = true;
            lbRoomSundayA.BackColor = Color.Transparent;
            lbRoomSundayA.ForeColor = Color.FromArgb(0, 0, 192);
            lbRoomSundayA.Location = new Point(8, 68);
            lbRoomSundayA.Name = "lbRoomSundayA";
            lbRoomSundayA.Size = new Size(51, 20);
            lbRoomSundayA.TabIndex = 3;
            lbRoomSundayA.Text = "Phòng";
            // 
            // panel8
            // 
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Dock = DockStyle.Right;
            panel8.Location = new Point(139, 0);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Size = new Size(1, 145);
            panel8.TabIndex = 1;
            // 
            // guna2Panel14
            // 
            guna2Panel14.Controls.Add(flpScheduleSaturdayA);
            guna2Panel14.Controls.Add(panel9);
            guna2Panel14.CustomizableEdges = customizableEdges5;
            guna2Panel14.Dock = DockStyle.Fill;
            guna2Panel14.Location = new Point(745, 185);
            guna2Panel14.Margin = new Padding(0);
            guna2Panel14.Name = "guna2Panel14";
            guna2Panel14.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel14.Size = new Size(137, 145);
            guna2Panel14.TabIndex = 37;
            // 
            // flpScheduleSaturdayA
            // 
            flpScheduleSaturdayA.Controls.Add(lbCourseNameSaturdayA);
            flpScheduleSaturdayA.Controls.Add(lbClassSaturdayA);
            flpScheduleSaturdayA.Controls.Add(lbTimeSaturdayA);
            flpScheduleSaturdayA.Controls.Add(lbRoomSaturdayA);
            flpScheduleSaturdayA.Dock = DockStyle.Fill;
            flpScheduleSaturdayA.FlowDirection = FlowDirection.TopDown;
            flpScheduleSaturdayA.Location = new Point(0, 0);
            flpScheduleSaturdayA.Name = "flpScheduleSaturdayA";
            flpScheduleSaturdayA.Padding = new Padding(5);
            flpScheduleSaturdayA.Size = new Size(136, 145);
            flpScheduleSaturdayA.TabIndex = 2;
            flpScheduleSaturdayA.WrapContents = false;
            // 
            // lbCourseNameSaturdayA
            // 
            lbCourseNameSaturdayA.AutoSize = true;
            lbCourseNameSaturdayA.BackColor = Color.Transparent;
            lbCourseNameSaturdayA.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCourseNameSaturdayA.Location = new Point(8, 5);
            lbCourseNameSaturdayA.Name = "lbCourseNameSaturdayA";
            lbCourseNameSaturdayA.Size = new Size(83, 23);
            lbCourseNameSaturdayA.TabIndex = 0;
            lbCourseNameSaturdayA.Text = "Khoá học";
            // 
            // lbClassSaturdayA
            // 
            lbClassSaturdayA.AutoSize = true;
            lbClassSaturdayA.BackColor = Color.Transparent;
            lbClassSaturdayA.Location = new Point(8, 28);
            lbClassSaturdayA.Name = "lbClassSaturdayA";
            lbClassSaturdayA.Size = new Size(34, 20);
            lbClassSaturdayA.TabIndex = 1;
            lbClassSaturdayA.Text = "Lớp";
            // 
            // lbTimeSaturdayA
            // 
            lbTimeSaturdayA.AutoSize = true;
            lbTimeSaturdayA.BackColor = Color.Transparent;
            lbTimeSaturdayA.Location = new Point(8, 48);
            lbTimeSaturdayA.Name = "lbTimeSaturdayA";
            lbTimeSaturdayA.Size = new Size(71, 20);
            lbTimeSaturdayA.TabIndex = 2;
            lbTimeSaturdayA.Text = "Thời gian";
            // 
            // lbRoomSaturdayA
            // 
            lbRoomSaturdayA.AutoSize = true;
            lbRoomSaturdayA.BackColor = Color.Transparent;
            lbRoomSaturdayA.ForeColor = Color.FromArgb(0, 0, 192);
            lbRoomSaturdayA.Location = new Point(8, 68);
            lbRoomSaturdayA.Name = "lbRoomSaturdayA";
            lbRoomSaturdayA.Size = new Size(51, 20);
            lbRoomSaturdayA.TabIndex = 3;
            lbRoomSaturdayA.Text = "Phòng";
            // 
            // panel9
            // 
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Dock = DockStyle.Right;
            panel9.Location = new Point(136, 0);
            panel9.Margin = new Padding(0);
            panel9.Name = "panel9";
            panel9.Size = new Size(1, 145);
            panel9.TabIndex = 1;
            // 
            // guna2Panel13
            // 
            guna2Panel13.Controls.Add(flpScheduleFridayA);
            guna2Panel13.Controls.Add(panel10);
            guna2Panel13.CustomizableEdges = customizableEdges7;
            guna2Panel13.Dock = DockStyle.Fill;
            guna2Panel13.Location = new Point(608, 185);
            guna2Panel13.Margin = new Padding(0);
            guna2Panel13.Name = "guna2Panel13";
            guna2Panel13.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Panel13.Size = new Size(137, 145);
            guna2Panel13.TabIndex = 36;
            // 
            // flpScheduleFridayA
            // 
            flpScheduleFridayA.Controls.Add(lbCourseNameFridayA);
            flpScheduleFridayA.Controls.Add(lbClassFridayA);
            flpScheduleFridayA.Controls.Add(lbTimeFridayA);
            flpScheduleFridayA.Controls.Add(lbRoomFridayA);
            flpScheduleFridayA.Dock = DockStyle.Fill;
            flpScheduleFridayA.FlowDirection = FlowDirection.TopDown;
            flpScheduleFridayA.Location = new Point(0, 0);
            flpScheduleFridayA.Name = "flpScheduleFridayA";
            flpScheduleFridayA.Padding = new Padding(5);
            flpScheduleFridayA.Size = new Size(136, 145);
            flpScheduleFridayA.TabIndex = 2;
            flpScheduleFridayA.WrapContents = false;
            // 
            // lbCourseNameFridayA
            // 
            lbCourseNameFridayA.AutoSize = true;
            lbCourseNameFridayA.BackColor = Color.Transparent;
            lbCourseNameFridayA.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCourseNameFridayA.Location = new Point(8, 5);
            lbCourseNameFridayA.Name = "lbCourseNameFridayA";
            lbCourseNameFridayA.Size = new Size(83, 23);
            lbCourseNameFridayA.TabIndex = 0;
            lbCourseNameFridayA.Text = "Khoá học";
            // 
            // lbClassFridayA
            // 
            lbClassFridayA.AutoSize = true;
            lbClassFridayA.BackColor = Color.Transparent;
            lbClassFridayA.Location = new Point(8, 28);
            lbClassFridayA.Name = "lbClassFridayA";
            lbClassFridayA.Size = new Size(34, 20);
            lbClassFridayA.TabIndex = 1;
            lbClassFridayA.Text = "Lớp";
            // 
            // lbTimeFridayA
            // 
            lbTimeFridayA.AutoSize = true;
            lbTimeFridayA.BackColor = Color.Transparent;
            lbTimeFridayA.Location = new Point(8, 48);
            lbTimeFridayA.Name = "lbTimeFridayA";
            lbTimeFridayA.Size = new Size(71, 20);
            lbTimeFridayA.TabIndex = 2;
            lbTimeFridayA.Text = "Thời gian";
            // 
            // lbRoomFridayA
            // 
            lbRoomFridayA.AutoSize = true;
            lbRoomFridayA.BackColor = Color.Transparent;
            lbRoomFridayA.ForeColor = Color.FromArgb(0, 0, 192);
            lbRoomFridayA.Location = new Point(8, 68);
            lbRoomFridayA.Name = "lbRoomFridayA";
            lbRoomFridayA.Size = new Size(51, 20);
            lbRoomFridayA.TabIndex = 3;
            lbRoomFridayA.Text = "Phòng";
            // 
            // panel10
            // 
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Dock = DockStyle.Right;
            panel10.Location = new Point(136, 0);
            panel10.Margin = new Padding(0);
            panel10.Name = "panel10";
            panel10.Size = new Size(1, 145);
            panel10.TabIndex = 1;
            // 
            // guna2Panel12
            // 
            guna2Panel12.Controls.Add(flpScheduleThursdayA);
            guna2Panel12.Controls.Add(panel11);
            guna2Panel12.CustomizableEdges = customizableEdges9;
            guna2Panel12.Dock = DockStyle.Fill;
            guna2Panel12.Location = new Point(471, 185);
            guna2Panel12.Margin = new Padding(0);
            guna2Panel12.Name = "guna2Panel12";
            guna2Panel12.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2Panel12.Size = new Size(137, 145);
            guna2Panel12.TabIndex = 35;
            // 
            // flpScheduleThursdayA
            // 
            flpScheduleThursdayA.Controls.Add(lbCourseNameThursdayA);
            flpScheduleThursdayA.Controls.Add(lbClassThursdayA);
            flpScheduleThursdayA.Controls.Add(lbTimeThursdayA);
            flpScheduleThursdayA.Controls.Add(lbRoomThursdayA);
            flpScheduleThursdayA.Dock = DockStyle.Fill;
            flpScheduleThursdayA.FlowDirection = FlowDirection.TopDown;
            flpScheduleThursdayA.Location = new Point(0, 0);
            flpScheduleThursdayA.Name = "flpScheduleThursdayA";
            flpScheduleThursdayA.Padding = new Padding(5);
            flpScheduleThursdayA.Size = new Size(136, 145);
            flpScheduleThursdayA.TabIndex = 2;
            flpScheduleThursdayA.WrapContents = false;
            // 
            // lbCourseNameThursdayA
            // 
            lbCourseNameThursdayA.AutoSize = true;
            lbCourseNameThursdayA.BackColor = Color.Transparent;
            lbCourseNameThursdayA.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCourseNameThursdayA.Location = new Point(8, 5);
            lbCourseNameThursdayA.Name = "lbCourseNameThursdayA";
            lbCourseNameThursdayA.Size = new Size(83, 23);
            lbCourseNameThursdayA.TabIndex = 0;
            lbCourseNameThursdayA.Text = "Khoá học";
            // 
            // lbClassThursdayA
            // 
            lbClassThursdayA.AutoSize = true;
            lbClassThursdayA.BackColor = Color.Transparent;
            lbClassThursdayA.Location = new Point(8, 28);
            lbClassThursdayA.Name = "lbClassThursdayA";
            lbClassThursdayA.Size = new Size(34, 20);
            lbClassThursdayA.TabIndex = 1;
            lbClassThursdayA.Text = "Lớp";
            // 
            // lbTimeThursdayA
            // 
            lbTimeThursdayA.AutoSize = true;
            lbTimeThursdayA.BackColor = Color.Transparent;
            lbTimeThursdayA.Location = new Point(8, 48);
            lbTimeThursdayA.Name = "lbTimeThursdayA";
            lbTimeThursdayA.Size = new Size(71, 20);
            lbTimeThursdayA.TabIndex = 2;
            lbTimeThursdayA.Text = "Thời gian";
            // 
            // lbRoomThursdayA
            // 
            lbRoomThursdayA.AutoSize = true;
            lbRoomThursdayA.BackColor = Color.Transparent;
            lbRoomThursdayA.ForeColor = Color.FromArgb(0, 0, 192);
            lbRoomThursdayA.Location = new Point(8, 68);
            lbRoomThursdayA.Name = "lbRoomThursdayA";
            lbRoomThursdayA.Size = new Size(51, 20);
            lbRoomThursdayA.TabIndex = 3;
            lbRoomThursdayA.Text = "Phòng";
            // 
            // panel11
            // 
            panel11.BorderStyle = BorderStyle.FixedSingle;
            panel11.Dock = DockStyle.Right;
            panel11.Location = new Point(136, 0);
            panel11.Margin = new Padding(0);
            panel11.Name = "panel11";
            panel11.Size = new Size(1, 145);
            panel11.TabIndex = 1;
            // 
            // guna2Panel11
            // 
            guna2Panel11.Controls.Add(flpScheduleWednesdayA);
            guna2Panel11.Controls.Add(panel12);
            guna2Panel11.CustomizableEdges = customizableEdges11;
            guna2Panel11.Dock = DockStyle.Fill;
            guna2Panel11.Location = new Point(334, 185);
            guna2Panel11.Margin = new Padding(0);
            guna2Panel11.Name = "guna2Panel11";
            guna2Panel11.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2Panel11.Size = new Size(137, 145);
            guna2Panel11.TabIndex = 34;
            // 
            // flpScheduleWednesdayA
            // 
            flpScheduleWednesdayA.Controls.Add(lbCourseNameWednesdayA);
            flpScheduleWednesdayA.Controls.Add(lbClassWednesdayA);
            flpScheduleWednesdayA.Controls.Add(lbTimeWednesdayA);
            flpScheduleWednesdayA.Controls.Add(lbRoomWednesdayA);
            flpScheduleWednesdayA.Dock = DockStyle.Fill;
            flpScheduleWednesdayA.FlowDirection = FlowDirection.TopDown;
            flpScheduleWednesdayA.Location = new Point(0, 0);
            flpScheduleWednesdayA.Name = "flpScheduleWednesdayA";
            flpScheduleWednesdayA.Padding = new Padding(5);
            flpScheduleWednesdayA.Size = new Size(136, 145);
            flpScheduleWednesdayA.TabIndex = 2;
            flpScheduleWednesdayA.WrapContents = false;
            // 
            // lbCourseNameWednesdayA
            // 
            lbCourseNameWednesdayA.AutoSize = true;
            lbCourseNameWednesdayA.BackColor = Color.Transparent;
            lbCourseNameWednesdayA.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCourseNameWednesdayA.Location = new Point(8, 5);
            lbCourseNameWednesdayA.Name = "lbCourseNameWednesdayA";
            lbCourseNameWednesdayA.Size = new Size(83, 23);
            lbCourseNameWednesdayA.TabIndex = 0;
            lbCourseNameWednesdayA.Text = "Khoá học";
            // 
            // lbClassWednesdayA
            // 
            lbClassWednesdayA.AutoSize = true;
            lbClassWednesdayA.BackColor = Color.Transparent;
            lbClassWednesdayA.Location = new Point(8, 28);
            lbClassWednesdayA.Name = "lbClassWednesdayA";
            lbClassWednesdayA.Size = new Size(34, 20);
            lbClassWednesdayA.TabIndex = 1;
            lbClassWednesdayA.Text = "Lớp";
            // 
            // lbTimeWednesdayA
            // 
            lbTimeWednesdayA.AutoSize = true;
            lbTimeWednesdayA.BackColor = Color.Transparent;
            lbTimeWednesdayA.Location = new Point(8, 48);
            lbTimeWednesdayA.Name = "lbTimeWednesdayA";
            lbTimeWednesdayA.Size = new Size(71, 20);
            lbTimeWednesdayA.TabIndex = 2;
            lbTimeWednesdayA.Text = "Thời gian";
            // 
            // lbRoomWednesdayA
            // 
            lbRoomWednesdayA.AutoSize = true;
            lbRoomWednesdayA.BackColor = Color.Transparent;
            lbRoomWednesdayA.ForeColor = Color.FromArgb(0, 0, 192);
            lbRoomWednesdayA.Location = new Point(8, 68);
            lbRoomWednesdayA.Name = "lbRoomWednesdayA";
            lbRoomWednesdayA.Size = new Size(51, 20);
            lbRoomWednesdayA.TabIndex = 3;
            lbRoomWednesdayA.Text = "Phòng";
            // 
            // panel12
            // 
            panel12.BorderStyle = BorderStyle.FixedSingle;
            panel12.Dock = DockStyle.Right;
            panel12.Location = new Point(136, 0);
            panel12.Margin = new Padding(0);
            panel12.Name = "panel12";
            panel12.Size = new Size(1, 145);
            panel12.TabIndex = 1;
            // 
            // guna2Panel10
            // 
            guna2Panel10.Controls.Add(flpScheduleTuesdayA);
            guna2Panel10.Controls.Add(panel13);
            guna2Panel10.CustomizableEdges = customizableEdges13;
            guna2Panel10.Dock = DockStyle.Fill;
            guna2Panel10.Location = new Point(197, 185);
            guna2Panel10.Margin = new Padding(0);
            guna2Panel10.Name = "guna2Panel10";
            guna2Panel10.ShadowDecoration.CustomizableEdges = customizableEdges14;
            guna2Panel10.Size = new Size(137, 145);
            guna2Panel10.TabIndex = 33;
            // 
            // flpScheduleTuesdayA
            // 
            flpScheduleTuesdayA.Controls.Add(lbCourseNameTuesdayA);
            flpScheduleTuesdayA.Controls.Add(lbClassTuesdayA);
            flpScheduleTuesdayA.Controls.Add(lbTimeTuesdayA);
            flpScheduleTuesdayA.Controls.Add(lbRoomTuesdayA);
            flpScheduleTuesdayA.Dock = DockStyle.Fill;
            flpScheduleTuesdayA.FlowDirection = FlowDirection.TopDown;
            flpScheduleTuesdayA.Location = new Point(0, 0);
            flpScheduleTuesdayA.Name = "flpScheduleTuesdayA";
            flpScheduleTuesdayA.Padding = new Padding(5);
            flpScheduleTuesdayA.Size = new Size(136, 145);
            flpScheduleTuesdayA.TabIndex = 2;
            flpScheduleTuesdayA.WrapContents = false;
            // 
            // lbCourseNameTuesdayA
            // 
            lbCourseNameTuesdayA.AutoSize = true;
            lbCourseNameTuesdayA.BackColor = Color.Transparent;
            lbCourseNameTuesdayA.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCourseNameTuesdayA.Location = new Point(8, 5);
            lbCourseNameTuesdayA.Name = "lbCourseNameTuesdayA";
            lbCourseNameTuesdayA.Size = new Size(83, 23);
            lbCourseNameTuesdayA.TabIndex = 0;
            lbCourseNameTuesdayA.Text = "Khoá học";
            // 
            // lbClassTuesdayA
            // 
            lbClassTuesdayA.AutoSize = true;
            lbClassTuesdayA.BackColor = Color.Transparent;
            lbClassTuesdayA.Location = new Point(8, 28);
            lbClassTuesdayA.Name = "lbClassTuesdayA";
            lbClassTuesdayA.Size = new Size(34, 20);
            lbClassTuesdayA.TabIndex = 1;
            lbClassTuesdayA.Text = "Lớp";
            // 
            // lbTimeTuesdayA
            // 
            lbTimeTuesdayA.AutoSize = true;
            lbTimeTuesdayA.BackColor = Color.Transparent;
            lbTimeTuesdayA.Location = new Point(8, 48);
            lbTimeTuesdayA.Name = "lbTimeTuesdayA";
            lbTimeTuesdayA.Size = new Size(71, 20);
            lbTimeTuesdayA.TabIndex = 2;
            lbTimeTuesdayA.Text = "Thời gian";
            // 
            // lbRoomTuesdayA
            // 
            lbRoomTuesdayA.AutoSize = true;
            lbRoomTuesdayA.BackColor = Color.Transparent;
            lbRoomTuesdayA.ForeColor = Color.FromArgb(0, 0, 192);
            lbRoomTuesdayA.Location = new Point(8, 68);
            lbRoomTuesdayA.Name = "lbRoomTuesdayA";
            lbRoomTuesdayA.Size = new Size(51, 20);
            lbRoomTuesdayA.TabIndex = 3;
            lbRoomTuesdayA.Text = "Phòng";
            // 
            // panel13
            // 
            panel13.BorderStyle = BorderStyle.FixedSingle;
            panel13.Dock = DockStyle.Right;
            panel13.Location = new Point(136, 0);
            panel13.Margin = new Padding(0);
            panel13.Name = "panel13";
            panel13.Size = new Size(1, 145);
            panel13.TabIndex = 1;
            // 
            // guna2Panel9
            // 
            guna2Panel9.Controls.Add(flpScheduleMondayA);
            guna2Panel9.Controls.Add(panel14);
            guna2Panel9.CustomizableEdges = customizableEdges15;
            guna2Panel9.Dock = DockStyle.Fill;
            guna2Panel9.Location = new Point(60, 185);
            guna2Panel9.Margin = new Padding(0);
            guna2Panel9.Name = "guna2Panel9";
            guna2Panel9.ShadowDecoration.CustomizableEdges = customizableEdges16;
            guna2Panel9.Size = new Size(137, 145);
            guna2Panel9.TabIndex = 32;
            // 
            // flpScheduleMondayA
            // 
            flpScheduleMondayA.Controls.Add(lbCourseNameMondayA);
            flpScheduleMondayA.Controls.Add(lbClassMondayA);
            flpScheduleMondayA.Controls.Add(lbTimeMondayA);
            flpScheduleMondayA.Controls.Add(lbRoomMondayA);
            flpScheduleMondayA.Dock = DockStyle.Fill;
            flpScheduleMondayA.FlowDirection = FlowDirection.TopDown;
            flpScheduleMondayA.Location = new Point(0, 0);
            flpScheduleMondayA.Name = "flpScheduleMondayA";
            flpScheduleMondayA.Padding = new Padding(5);
            flpScheduleMondayA.Size = new Size(136, 145);
            flpScheduleMondayA.TabIndex = 2;
            flpScheduleMondayA.WrapContents = false;
            // 
            // lbCourseNameMondayA
            // 
            lbCourseNameMondayA.AutoSize = true;
            lbCourseNameMondayA.BackColor = Color.Transparent;
            lbCourseNameMondayA.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCourseNameMondayA.Location = new Point(8, 5);
            lbCourseNameMondayA.Name = "lbCourseNameMondayA";
            lbCourseNameMondayA.Size = new Size(83, 23);
            lbCourseNameMondayA.TabIndex = 0;
            lbCourseNameMondayA.Text = "Khoá học";
            // 
            // lbClassMondayA
            // 
            lbClassMondayA.AutoSize = true;
            lbClassMondayA.BackColor = Color.Transparent;
            lbClassMondayA.Location = new Point(8, 28);
            lbClassMondayA.Name = "lbClassMondayA";
            lbClassMondayA.Size = new Size(34, 20);
            lbClassMondayA.TabIndex = 1;
            lbClassMondayA.Text = "Lớp";
            // 
            // lbTimeMondayA
            // 
            lbTimeMondayA.AutoSize = true;
            lbTimeMondayA.BackColor = Color.Transparent;
            lbTimeMondayA.Location = new Point(8, 48);
            lbTimeMondayA.Name = "lbTimeMondayA";
            lbTimeMondayA.Size = new Size(71, 20);
            lbTimeMondayA.TabIndex = 2;
            lbTimeMondayA.Text = "Thời gian";
            // 
            // lbRoomMondayA
            // 
            lbRoomMondayA.AutoSize = true;
            lbRoomMondayA.BackColor = Color.Transparent;
            lbRoomMondayA.ForeColor = Color.FromArgb(0, 0, 192);
            lbRoomMondayA.Location = new Point(8, 68);
            lbRoomMondayA.Name = "lbRoomMondayA";
            lbRoomMondayA.Size = new Size(51, 20);
            lbRoomMondayA.TabIndex = 3;
            lbRoomMondayA.Text = "Phòng";
            // 
            // panel14
            // 
            panel14.BorderStyle = BorderStyle.FixedSingle;
            panel14.Dock = DockStyle.Right;
            panel14.Location = new Point(136, 0);
            panel14.Margin = new Padding(0);
            panel14.Name = "panel14";
            panel14.Size = new Size(1, 145);
            panel14.TabIndex = 1;
            // 
            // guna2Panel8
            // 
            guna2Panel8.Controls.Add(panel16);
            guna2Panel8.Controls.Add(flpScheduleSundayM);
            guna2Panel8.Controls.Add(panel7);
            guna2Panel8.CustomizableEdges = customizableEdges17;
            guna2Panel8.Dock = DockStyle.Fill;
            guna2Panel8.Location = new Point(882, 40);
            guna2Panel8.Margin = new Padding(0);
            guna2Panel8.Name = "guna2Panel8";
            guna2Panel8.ShadowDecoration.CustomizableEdges = customizableEdges18;
            guna2Panel8.Size = new Size(140, 145);
            guna2Panel8.TabIndex = 31;
            // 
            // panel16
            // 
            panel16.BorderStyle = BorderStyle.FixedSingle;
            panel16.Dock = DockStyle.Bottom;
            panel16.Location = new Point(0, 144);
            panel16.Margin = new Padding(0);
            panel16.Name = "panel16";
            panel16.Size = new Size(139, 1);
            panel16.TabIndex = 2;
            // 
            // flpScheduleSundayM
            // 
            flpScheduleSundayM.Controls.Add(lbCourseNameSundayM);
            flpScheduleSundayM.Controls.Add(lbClassSundayM);
            flpScheduleSundayM.Controls.Add(lbTimeSundayM);
            flpScheduleSundayM.Controls.Add(lbRoomSundayM);
            flpScheduleSundayM.Dock = DockStyle.Fill;
            flpScheduleSundayM.FlowDirection = FlowDirection.TopDown;
            flpScheduleSundayM.Location = new Point(0, 0);
            flpScheduleSundayM.Name = "flpScheduleSundayM";
            flpScheduleSundayM.Padding = new Padding(5);
            flpScheduleSundayM.Size = new Size(139, 145);
            flpScheduleSundayM.TabIndex = 2;
            flpScheduleSundayM.WrapContents = false;
            // 
            // lbCourseNameSundayM
            // 
            lbCourseNameSundayM.AutoSize = true;
            lbCourseNameSundayM.BackColor = Color.Transparent;
            lbCourseNameSundayM.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCourseNameSundayM.Location = new Point(8, 5);
            lbCourseNameSundayM.Name = "lbCourseNameSundayM";
            lbCourseNameSundayM.Size = new Size(83, 23);
            lbCourseNameSundayM.TabIndex = 0;
            lbCourseNameSundayM.Text = "Khoá học";
            // 
            // lbClassSundayM
            // 
            lbClassSundayM.AutoSize = true;
            lbClassSundayM.BackColor = Color.Transparent;
            lbClassSundayM.Location = new Point(8, 28);
            lbClassSundayM.Name = "lbClassSundayM";
            lbClassSundayM.Size = new Size(34, 20);
            lbClassSundayM.TabIndex = 1;
            lbClassSundayM.Text = "Lớp";
            // 
            // lbTimeSundayM
            // 
            lbTimeSundayM.AutoSize = true;
            lbTimeSundayM.BackColor = Color.Transparent;
            lbTimeSundayM.Location = new Point(8, 48);
            lbTimeSundayM.Name = "lbTimeSundayM";
            lbTimeSundayM.Size = new Size(71, 20);
            lbTimeSundayM.TabIndex = 2;
            lbTimeSundayM.Text = "Thời gian";
            // 
            // lbRoomSundayM
            // 
            lbRoomSundayM.AutoSize = true;
            lbRoomSundayM.BackColor = Color.Transparent;
            lbRoomSundayM.ForeColor = Color.FromArgb(0, 0, 192);
            lbRoomSundayM.Location = new Point(8, 68);
            lbRoomSundayM.Name = "lbRoomSundayM";
            lbRoomSundayM.Size = new Size(51, 20);
            lbRoomSundayM.TabIndex = 3;
            lbRoomSundayM.Text = "Phòng";
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Dock = DockStyle.Right;
            panel7.Location = new Point(139, 0);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Size = new Size(1, 145);
            panel7.TabIndex = 1;
            // 
            // guna2Panel7
            // 
            guna2Panel7.Controls.Add(panel17);
            guna2Panel7.Controls.Add(flpScheduleSaturdayM);
            guna2Panel7.Controls.Add(panel6);
            guna2Panel7.CustomizableEdges = customizableEdges19;
            guna2Panel7.Dock = DockStyle.Fill;
            guna2Panel7.Location = new Point(745, 40);
            guna2Panel7.Margin = new Padding(0);
            guna2Panel7.Name = "guna2Panel7";
            guna2Panel7.ShadowDecoration.CustomizableEdges = customizableEdges20;
            guna2Panel7.Size = new Size(137, 145);
            guna2Panel7.TabIndex = 30;
            // 
            // panel17
            // 
            panel17.BorderStyle = BorderStyle.FixedSingle;
            panel17.Dock = DockStyle.Bottom;
            panel17.Location = new Point(0, 144);
            panel17.Margin = new Padding(0);
            panel17.Name = "panel17";
            panel17.Size = new Size(136, 1);
            panel17.TabIndex = 3;
            // 
            // flpScheduleSaturdayM
            // 
            flpScheduleSaturdayM.Controls.Add(lbCourseNameSaturdayM);
            flpScheduleSaturdayM.Controls.Add(lbClassSaturdayM);
            flpScheduleSaturdayM.Controls.Add(lbTimeSaturdayM);
            flpScheduleSaturdayM.Controls.Add(lbRoomSaturdayM);
            flpScheduleSaturdayM.Dock = DockStyle.Fill;
            flpScheduleSaturdayM.FlowDirection = FlowDirection.TopDown;
            flpScheduleSaturdayM.Location = new Point(0, 0);
            flpScheduleSaturdayM.Name = "flpScheduleSaturdayM";
            flpScheduleSaturdayM.Padding = new Padding(5);
            flpScheduleSaturdayM.Size = new Size(136, 145);
            flpScheduleSaturdayM.TabIndex = 2;
            flpScheduleSaturdayM.WrapContents = false;
            // 
            // lbCourseNameSaturdayM
            // 
            lbCourseNameSaturdayM.AutoSize = true;
            lbCourseNameSaturdayM.BackColor = Color.Transparent;
            lbCourseNameSaturdayM.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCourseNameSaturdayM.Location = new Point(8, 5);
            lbCourseNameSaturdayM.Name = "lbCourseNameSaturdayM";
            lbCourseNameSaturdayM.Size = new Size(83, 23);
            lbCourseNameSaturdayM.TabIndex = 0;
            lbCourseNameSaturdayM.Text = "Khoá học";
            // 
            // lbClassSaturdayM
            // 
            lbClassSaturdayM.AutoSize = true;
            lbClassSaturdayM.BackColor = Color.Transparent;
            lbClassSaturdayM.Location = new Point(8, 28);
            lbClassSaturdayM.Name = "lbClassSaturdayM";
            lbClassSaturdayM.Size = new Size(34, 20);
            lbClassSaturdayM.TabIndex = 1;
            lbClassSaturdayM.Text = "Lớp";
            // 
            // lbTimeSaturdayM
            // 
            lbTimeSaturdayM.AutoSize = true;
            lbTimeSaturdayM.BackColor = Color.Transparent;
            lbTimeSaturdayM.Location = new Point(8, 48);
            lbTimeSaturdayM.Name = "lbTimeSaturdayM";
            lbTimeSaturdayM.Size = new Size(71, 20);
            lbTimeSaturdayM.TabIndex = 2;
            lbTimeSaturdayM.Text = "Thời gian";
            // 
            // lbRoomSaturdayM
            // 
            lbRoomSaturdayM.AutoSize = true;
            lbRoomSaturdayM.BackColor = Color.Transparent;
            lbRoomSaturdayM.ForeColor = Color.FromArgb(0, 0, 192);
            lbRoomSaturdayM.Location = new Point(8, 68);
            lbRoomSaturdayM.Name = "lbRoomSaturdayM";
            lbRoomSaturdayM.Size = new Size(51, 20);
            lbRoomSaturdayM.TabIndex = 3;
            lbRoomSaturdayM.Text = "Phòng";
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(136, 0);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1, 145);
            panel6.TabIndex = 1;
            // 
            // guna2Panel6
            // 
            guna2Panel6.Controls.Add(panel18);
            guna2Panel6.Controls.Add(flpScheduleFridayM);
            guna2Panel6.Controls.Add(panel5);
            guna2Panel6.CustomizableEdges = customizableEdges21;
            guna2Panel6.Dock = DockStyle.Fill;
            guna2Panel6.Location = new Point(608, 40);
            guna2Panel6.Margin = new Padding(0);
            guna2Panel6.Name = "guna2Panel6";
            guna2Panel6.ShadowDecoration.CustomizableEdges = customizableEdges22;
            guna2Panel6.Size = new Size(137, 145);
            guna2Panel6.TabIndex = 29;
            // 
            // panel18
            // 
            panel18.BorderStyle = BorderStyle.FixedSingle;
            panel18.Dock = DockStyle.Bottom;
            panel18.Location = new Point(0, 144);
            panel18.Margin = new Padding(0);
            panel18.Name = "panel18";
            panel18.Size = new Size(136, 1);
            panel18.TabIndex = 3;
            // 
            // flpScheduleFridayM
            // 
            flpScheduleFridayM.Controls.Add(lbCourseNameFridayM);
            flpScheduleFridayM.Controls.Add(lbClassFridayM);
            flpScheduleFridayM.Controls.Add(lbTimeFridayM);
            flpScheduleFridayM.Controls.Add(lbRoomFridayM);
            flpScheduleFridayM.Dock = DockStyle.Fill;
            flpScheduleFridayM.FlowDirection = FlowDirection.TopDown;
            flpScheduleFridayM.Location = new Point(0, 0);
            flpScheduleFridayM.Name = "flpScheduleFridayM";
            flpScheduleFridayM.Padding = new Padding(5);
            flpScheduleFridayM.Size = new Size(136, 145);
            flpScheduleFridayM.TabIndex = 2;
            flpScheduleFridayM.WrapContents = false;
            // 
            // lbCourseNameFridayM
            // 
            lbCourseNameFridayM.AutoSize = true;
            lbCourseNameFridayM.BackColor = Color.Transparent;
            lbCourseNameFridayM.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCourseNameFridayM.Location = new Point(8, 5);
            lbCourseNameFridayM.Name = "lbCourseNameFridayM";
            lbCourseNameFridayM.Size = new Size(83, 23);
            lbCourseNameFridayM.TabIndex = 0;
            lbCourseNameFridayM.Text = "Khoá học";
            // 
            // lbClassFridayM
            // 
            lbClassFridayM.AutoSize = true;
            lbClassFridayM.BackColor = Color.Transparent;
            lbClassFridayM.Location = new Point(8, 28);
            lbClassFridayM.Name = "lbClassFridayM";
            lbClassFridayM.Size = new Size(34, 20);
            lbClassFridayM.TabIndex = 1;
            lbClassFridayM.Text = "Lớp";
            // 
            // lbTimeFridayM
            // 
            lbTimeFridayM.AutoSize = true;
            lbTimeFridayM.BackColor = Color.Transparent;
            lbTimeFridayM.Location = new Point(8, 48);
            lbTimeFridayM.Name = "lbTimeFridayM";
            lbTimeFridayM.Size = new Size(71, 20);
            lbTimeFridayM.TabIndex = 2;
            lbTimeFridayM.Text = "Thời gian";
            // 
            // lbRoomFridayM
            // 
            lbRoomFridayM.AutoSize = true;
            lbRoomFridayM.BackColor = Color.Transparent;
            lbRoomFridayM.ForeColor = Color.FromArgb(0, 0, 192);
            lbRoomFridayM.Location = new Point(8, 68);
            lbRoomFridayM.Name = "lbRoomFridayM";
            lbRoomFridayM.Size = new Size(51, 20);
            lbRoomFridayM.TabIndex = 3;
            lbRoomFridayM.Text = "Phòng";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(136, 0);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1, 145);
            panel5.TabIndex = 1;
            // 
            // guna2Panel5
            // 
            guna2Panel5.Controls.Add(panel19);
            guna2Panel5.Controls.Add(flpScheduleThursdayM);
            guna2Panel5.Controls.Add(panel4);
            guna2Panel5.CustomizableEdges = customizableEdges23;
            guna2Panel5.Dock = DockStyle.Fill;
            guna2Panel5.Location = new Point(471, 40);
            guna2Panel5.Margin = new Padding(0);
            guna2Panel5.Name = "guna2Panel5";
            guna2Panel5.ShadowDecoration.CustomizableEdges = customizableEdges24;
            guna2Panel5.Size = new Size(137, 145);
            guna2Panel5.TabIndex = 28;
            // 
            // panel19
            // 
            panel19.BorderStyle = BorderStyle.FixedSingle;
            panel19.Dock = DockStyle.Bottom;
            panel19.Location = new Point(0, 144);
            panel19.Margin = new Padding(0);
            panel19.Name = "panel19";
            panel19.Size = new Size(136, 1);
            panel19.TabIndex = 3;
            // 
            // flpScheduleThursdayM
            // 
            flpScheduleThursdayM.Controls.Add(lbCourseNameThursdayM);
            flpScheduleThursdayM.Controls.Add(lbClassThursdayM);
            flpScheduleThursdayM.Controls.Add(lbTimeThursdayM);
            flpScheduleThursdayM.Controls.Add(lbRoomThursdayM);
            flpScheduleThursdayM.Dock = DockStyle.Fill;
            flpScheduleThursdayM.FlowDirection = FlowDirection.TopDown;
            flpScheduleThursdayM.Location = new Point(0, 0);
            flpScheduleThursdayM.Name = "flpScheduleThursdayM";
            flpScheduleThursdayM.Padding = new Padding(5);
            flpScheduleThursdayM.Size = new Size(136, 145);
            flpScheduleThursdayM.TabIndex = 2;
            flpScheduleThursdayM.WrapContents = false;
            // 
            // lbCourseNameThursdayM
            // 
            lbCourseNameThursdayM.AutoSize = true;
            lbCourseNameThursdayM.BackColor = Color.Transparent;
            lbCourseNameThursdayM.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCourseNameThursdayM.Location = new Point(8, 5);
            lbCourseNameThursdayM.Name = "lbCourseNameThursdayM";
            lbCourseNameThursdayM.Size = new Size(83, 23);
            lbCourseNameThursdayM.TabIndex = 0;
            lbCourseNameThursdayM.Text = "Khoá học";
            // 
            // lbClassThursdayM
            // 
            lbClassThursdayM.AutoSize = true;
            lbClassThursdayM.BackColor = Color.Transparent;
            lbClassThursdayM.Location = new Point(8, 28);
            lbClassThursdayM.Name = "lbClassThursdayM";
            lbClassThursdayM.Size = new Size(34, 20);
            lbClassThursdayM.TabIndex = 1;
            lbClassThursdayM.Text = "Lớp";
            // 
            // lbTimeThursdayM
            // 
            lbTimeThursdayM.AutoSize = true;
            lbTimeThursdayM.BackColor = Color.Transparent;
            lbTimeThursdayM.Location = new Point(8, 48);
            lbTimeThursdayM.Name = "lbTimeThursdayM";
            lbTimeThursdayM.Size = new Size(71, 20);
            lbTimeThursdayM.TabIndex = 2;
            lbTimeThursdayM.Text = "Thời gian";
            // 
            // lbRoomThursdayM
            // 
            lbRoomThursdayM.AutoSize = true;
            lbRoomThursdayM.BackColor = Color.Transparent;
            lbRoomThursdayM.ForeColor = Color.FromArgb(0, 0, 192);
            lbRoomThursdayM.Location = new Point(8, 68);
            lbRoomThursdayM.Name = "lbRoomThursdayM";
            lbRoomThursdayM.Size = new Size(51, 20);
            lbRoomThursdayM.TabIndex = 3;
            lbRoomThursdayM.Text = "Phòng";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(136, 0);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1, 145);
            panel4.TabIndex = 1;
            // 
            // guna2Panel4
            // 
            guna2Panel4.Controls.Add(panel20);
            guna2Panel4.Controls.Add(flpScheduleWednesdayM);
            guna2Panel4.Controls.Add(panel3);
            guna2Panel4.CustomizableEdges = customizableEdges25;
            guna2Panel4.Dock = DockStyle.Fill;
            guna2Panel4.Location = new Point(334, 40);
            guna2Panel4.Margin = new Padding(0);
            guna2Panel4.Name = "guna2Panel4";
            guna2Panel4.ShadowDecoration.CustomizableEdges = customizableEdges26;
            guna2Panel4.Size = new Size(137, 145);
            guna2Panel4.TabIndex = 27;
            // 
            // panel20
            // 
            panel20.BorderStyle = BorderStyle.FixedSingle;
            panel20.Dock = DockStyle.Bottom;
            panel20.Location = new Point(0, 144);
            panel20.Margin = new Padding(0);
            panel20.Name = "panel20";
            panel20.Size = new Size(136, 1);
            panel20.TabIndex = 3;
            // 
            // flpScheduleWednesdayM
            // 
            flpScheduleWednesdayM.Controls.Add(lbCourseNameWednesdayM);
            flpScheduleWednesdayM.Controls.Add(lbClassWednesdayM);
            flpScheduleWednesdayM.Controls.Add(lbTimeWednesdayM);
            flpScheduleWednesdayM.Controls.Add(lbRoomWednesdayM);
            flpScheduleWednesdayM.Dock = DockStyle.Fill;
            flpScheduleWednesdayM.FlowDirection = FlowDirection.TopDown;
            flpScheduleWednesdayM.Location = new Point(0, 0);
            flpScheduleWednesdayM.Name = "flpScheduleWednesdayM";
            flpScheduleWednesdayM.Padding = new Padding(5);
            flpScheduleWednesdayM.Size = new Size(136, 145);
            flpScheduleWednesdayM.TabIndex = 2;
            flpScheduleWednesdayM.WrapContents = false;
            // 
            // lbCourseNameWednesdayM
            // 
            lbCourseNameWednesdayM.AutoSize = true;
            lbCourseNameWednesdayM.BackColor = Color.Transparent;
            lbCourseNameWednesdayM.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCourseNameWednesdayM.Location = new Point(8, 5);
            lbCourseNameWednesdayM.Name = "lbCourseNameWednesdayM";
            lbCourseNameWednesdayM.Size = new Size(83, 23);
            lbCourseNameWednesdayM.TabIndex = 0;
            lbCourseNameWednesdayM.Text = "Khoá học";
            // 
            // lbClassWednesdayM
            // 
            lbClassWednesdayM.AutoSize = true;
            lbClassWednesdayM.BackColor = Color.Transparent;
            lbClassWednesdayM.Location = new Point(8, 28);
            lbClassWednesdayM.Name = "lbClassWednesdayM";
            lbClassWednesdayM.Size = new Size(34, 20);
            lbClassWednesdayM.TabIndex = 1;
            lbClassWednesdayM.Text = "Lớp";
            // 
            // lbTimeWednesdayM
            // 
            lbTimeWednesdayM.AutoSize = true;
            lbTimeWednesdayM.BackColor = Color.Transparent;
            lbTimeWednesdayM.Location = new Point(8, 48);
            lbTimeWednesdayM.Name = "lbTimeWednesdayM";
            lbTimeWednesdayM.Size = new Size(71, 20);
            lbTimeWednesdayM.TabIndex = 2;
            lbTimeWednesdayM.Text = "Thời gian";
            // 
            // lbRoomWednesdayM
            // 
            lbRoomWednesdayM.AutoSize = true;
            lbRoomWednesdayM.BackColor = Color.Transparent;
            lbRoomWednesdayM.ForeColor = Color.FromArgb(0, 0, 192);
            lbRoomWednesdayM.Location = new Point(8, 68);
            lbRoomWednesdayM.Name = "lbRoomWednesdayM";
            lbRoomWednesdayM.Size = new Size(51, 20);
            lbRoomWednesdayM.TabIndex = 3;
            lbRoomWednesdayM.Text = "Phòng";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(136, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1, 145);
            panel3.TabIndex = 1;
            // 
            // guna2Panel3
            // 
            guna2Panel3.Controls.Add(panel21);
            guna2Panel3.Controls.Add(flpScheduleTuesdayM);
            guna2Panel3.Controls.Add(panel2);
            guna2Panel3.CustomizableEdges = customizableEdges27;
            guna2Panel3.Dock = DockStyle.Fill;
            guna2Panel3.Location = new Point(197, 40);
            guna2Panel3.Margin = new Padding(0);
            guna2Panel3.Name = "guna2Panel3";
            guna2Panel3.ShadowDecoration.CustomizableEdges = customizableEdges28;
            guna2Panel3.Size = new Size(137, 145);
            guna2Panel3.TabIndex = 26;
            // 
            // panel21
            // 
            panel21.BorderStyle = BorderStyle.FixedSingle;
            panel21.Dock = DockStyle.Bottom;
            panel21.Location = new Point(0, 144);
            panel21.Margin = new Padding(0);
            panel21.Name = "panel21";
            panel21.Size = new Size(136, 1);
            panel21.TabIndex = 3;
            // 
            // flpScheduleTuesdayM
            // 
            flpScheduleTuesdayM.Controls.Add(lbCourseNameTuesdayM);
            flpScheduleTuesdayM.Controls.Add(lbClassTuesdayM);
            flpScheduleTuesdayM.Controls.Add(lbTimeTuesdayM);
            flpScheduleTuesdayM.Controls.Add(lbRoomTuesdayM);
            flpScheduleTuesdayM.Dock = DockStyle.Fill;
            flpScheduleTuesdayM.FlowDirection = FlowDirection.TopDown;
            flpScheduleTuesdayM.Location = new Point(0, 0);
            flpScheduleTuesdayM.Name = "flpScheduleTuesdayM";
            flpScheduleTuesdayM.Padding = new Padding(5);
            flpScheduleTuesdayM.Size = new Size(136, 145);
            flpScheduleTuesdayM.TabIndex = 2;
            flpScheduleTuesdayM.WrapContents = false;
            // 
            // lbCourseNameTuesdayM
            // 
            lbCourseNameTuesdayM.AutoSize = true;
            lbCourseNameTuesdayM.BackColor = Color.Transparent;
            lbCourseNameTuesdayM.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCourseNameTuesdayM.Location = new Point(8, 5);
            lbCourseNameTuesdayM.Name = "lbCourseNameTuesdayM";
            lbCourseNameTuesdayM.Size = new Size(83, 23);
            lbCourseNameTuesdayM.TabIndex = 0;
            lbCourseNameTuesdayM.Text = "Khoá học";
            // 
            // lbClassTuesdayM
            // 
            lbClassTuesdayM.AutoSize = true;
            lbClassTuesdayM.BackColor = Color.Transparent;
            lbClassTuesdayM.Location = new Point(8, 28);
            lbClassTuesdayM.Name = "lbClassTuesdayM";
            lbClassTuesdayM.Size = new Size(34, 20);
            lbClassTuesdayM.TabIndex = 1;
            lbClassTuesdayM.Text = "Lớp";
            // 
            // lbTimeTuesdayM
            // 
            lbTimeTuesdayM.AutoSize = true;
            lbTimeTuesdayM.BackColor = Color.Transparent;
            lbTimeTuesdayM.Location = new Point(8, 48);
            lbTimeTuesdayM.Name = "lbTimeTuesdayM";
            lbTimeTuesdayM.Size = new Size(71, 20);
            lbTimeTuesdayM.TabIndex = 2;
            lbTimeTuesdayM.Text = "Thời gian";
            // 
            // lbRoomTuesdayM
            // 
            lbRoomTuesdayM.AutoSize = true;
            lbRoomTuesdayM.BackColor = Color.Transparent;
            lbRoomTuesdayM.ForeColor = Color.FromArgb(0, 0, 192);
            lbRoomTuesdayM.Location = new Point(8, 68);
            lbRoomTuesdayM.Name = "lbRoomTuesdayM";
            lbRoomTuesdayM.Size = new Size(51, 20);
            lbRoomTuesdayM.TabIndex = 3;
            lbRoomTuesdayM.Text = "Phòng";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(136, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1, 145);
            panel2.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ControlDark;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Dock = DockStyle.Fill;
            label8.Location = new Point(882, 0);
            label8.Margin = new Padding(0);
            label8.Name = "label8";
            label8.Size = new Size(140, 40);
            label8.TabIndex = 7;
            label8.Text = "Chủ nhật";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ControlDark;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(745, 0);
            label7.Margin = new Padding(0);
            label7.Name = "label7";
            label7.Size = new Size(137, 40);
            label7.TabIndex = 6;
            label7.Text = "Thứ 7";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDark;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(608, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(137, 40);
            label1.TabIndex = 5;
            label1.Text = "Thứ 6";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlDark;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(471, 0);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(137, 40);
            label4.TabIndex = 4;
            label4.Text = "Thứ 5";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ControlDark;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Dock = DockStyle.Fill;
            label9.Location = new Point(334, 0);
            label9.Margin = new Padding(0);
            label9.Name = "label9";
            label9.Size = new Size(137, 40);
            label9.TabIndex = 3;
            label9.Text = "Thứ 4";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ControlDark;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Dock = DockStyle.Fill;
            label10.Location = new Point(197, 0);
            label10.Margin = new Padding(0);
            label10.Name = "label10";
            label10.Size = new Size(137, 40);
            label10.TabIndex = 2;
            label10.Text = "Thứ 3";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.ControlDark;
            label11.BorderStyle = BorderStyle.FixedSingle;
            label11.Dock = DockStyle.Fill;
            label11.Location = new Point(60, 0);
            label11.Margin = new Padding(0);
            label11.Name = "label11";
            label11.Size = new Size(137, 40);
            label11.TabIndex = 0;
            label11.Text = "Thứ 2";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.ControlDark;
            label12.BorderStyle = BorderStyle.FixedSingle;
            label12.Dock = DockStyle.Fill;
            label12.Location = new Point(3, 40);
            label12.Name = "label12";
            label12.Size = new Size(54, 145);
            label12.TabIndex = 1;
            label12.Text = "Sáng";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.ControlDark;
            label13.BorderStyle = BorderStyle.FixedSingle;
            label13.Dock = DockStyle.Fill;
            label13.Location = new Point(3, 185);
            label13.Name = "label13";
            label13.Size = new Size(54, 145);
            label13.TabIndex = 9;
            label13.Text = "Chiều";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(panel22);
            guna2Panel1.Controls.Add(flpScheduleMondayM);
            guna2Panel1.Controls.Add(panel1);
            guna2Panel1.CustomizableEdges = customizableEdges29;
            guna2Panel1.Dock = DockStyle.Fill;
            guna2Panel1.Location = new Point(60, 40);
            guna2Panel1.Margin = new Padding(0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges30;
            guna2Panel1.Size = new Size(137, 145);
            guna2Panel1.TabIndex = 24;
            // 
            // panel22
            // 
            panel22.BorderStyle = BorderStyle.FixedSingle;
            panel22.Dock = DockStyle.Bottom;
            panel22.Location = new Point(0, 144);
            panel22.Margin = new Padding(0);
            panel22.Name = "panel22";
            panel22.Size = new Size(136, 1);
            panel22.TabIndex = 3;
            // 
            // flpScheduleMondayM
            // 
            flpScheduleMondayM.Controls.Add(lbCourseNameMondayM);
            flpScheduleMondayM.Controls.Add(lbClassMondayM);
            flpScheduleMondayM.Controls.Add(lbTimeMondayM);
            flpScheduleMondayM.Controls.Add(lbRoomMondayM);
            flpScheduleMondayM.Dock = DockStyle.Fill;
            flpScheduleMondayM.FlowDirection = FlowDirection.TopDown;
            flpScheduleMondayM.Location = new Point(0, 0);
            flpScheduleMondayM.Name = "flpScheduleMondayM";
            flpScheduleMondayM.Padding = new Padding(5);
            flpScheduleMondayM.Size = new Size(136, 145);
            flpScheduleMondayM.TabIndex = 1;
            flpScheduleMondayM.WrapContents = false;
            // 
            // lbCourseNameMondayM
            // 
            lbCourseNameMondayM.AutoSize = true;
            lbCourseNameMondayM.BackColor = Color.Transparent;
            lbCourseNameMondayM.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCourseNameMondayM.Location = new Point(8, 5);
            lbCourseNameMondayM.Name = "lbCourseNameMondayM";
            lbCourseNameMondayM.Size = new Size(83, 23);
            lbCourseNameMondayM.TabIndex = 0;
            lbCourseNameMondayM.Text = "Khoá học";
            // 
            // lbClassMondayM
            // 
            lbClassMondayM.AutoSize = true;
            lbClassMondayM.BackColor = Color.Transparent;
            lbClassMondayM.Location = new Point(8, 28);
            lbClassMondayM.Name = "lbClassMondayM";
            lbClassMondayM.Size = new Size(34, 20);
            lbClassMondayM.TabIndex = 1;
            lbClassMondayM.Text = "Lớp";
            // 
            // lbTimeMondayM
            // 
            lbTimeMondayM.AutoSize = true;
            lbTimeMondayM.BackColor = Color.Transparent;
            lbTimeMondayM.Location = new Point(8, 48);
            lbTimeMondayM.Name = "lbTimeMondayM";
            lbTimeMondayM.Size = new Size(71, 20);
            lbTimeMondayM.TabIndex = 2;
            lbTimeMondayM.Text = "Thời gian";
            // 
            // lbRoomMondayM
            // 
            lbRoomMondayM.AutoSize = true;
            lbRoomMondayM.BackColor = Color.Transparent;
            lbRoomMondayM.ForeColor = Color.FromArgb(0, 0, 192);
            lbRoomMondayM.Location = new Point(8, 68);
            lbRoomMondayM.Name = "lbRoomMondayM";
            lbRoomMondayM.Size = new Size(51, 20);
            lbRoomMondayM.TabIndex = 3;
            lbRoomMondayM.Text = "Phòng";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(136, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1, 145);
            panel1.TabIndex = 0;
            // 
            // panel15
            // 
            panel15.BackColor = Color.DarkGray;
            panel15.Dock = DockStyle.Fill;
            panel15.Location = new Point(0, 0);
            panel15.Margin = new Padding(0);
            panel15.Name = "panel15";
            panel15.Size = new Size(60, 40);
            panel15.TabIndex = 39;
            // 
            // lbWeek
            // 
            lbWeek.AutoSize = true;
            lbWeek.Dock = DockStyle.Fill;
            lbWeek.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbWeek.ForeColor = Color.FromArgb(34, 45, 60);
            lbWeek.Location = new Point(15, 12);
            lbWeek.Name = "lbWeek";
            lbWeek.Padding = new Padding(6);
            lbWeek.Size = new Size(1022, 50);
            lbWeek.TabIndex = 3;
            lbWeek.Text = "Tuần 1 ";
            // 
            // tlpTop
            // 
            tlpTop.BackColor = Color.White;
            tlpTop.ColumnCount = 2;
            tlpTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.9144F));
            tlpTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.0856F));
            tlpTop.Controls.Add(lblLichDay, 0, 0);
            tlpTop.Controls.Add(lblLichDayTuan, 0, 1);
            tlpTop.Controls.Add(tableLayoutPanel1, 1, 1);
            tlpTop.Controls.Add(tableLayoutPanel3, 1, 0);
            tlpTop.Dock = DockStyle.Top;
            tlpTop.Location = new Point(24, 24);
            tlpTop.Name = "tlpTop";
            tlpTop.Padding = new Padding(12);
            tlpTop.RowCount = 2;
            tlpTop.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpTop.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTop.Size = new Size(1052, 152);
            tlpTop.TabIndex = 1;
            // 
            // lblLichDay
            // 
            lblLichDay.AutoSize = true;
            lblLichDay.Dock = DockStyle.Fill;
            lblLichDay.Font = new Font("Segoe UI", 12F);
            lblLichDay.ForeColor = Color.FromArgb(34, 118, 255);
            lblLichDay.Location = new Point(15, 12);
            lblLichDay.Name = "lblLichDay";
            lblLichDay.Padding = new Padding(6, 6, 0, 0);
            lblLichDay.Size = new Size(209, 50);
            lblLichDay.TabIndex = 0;
            lblLichDay.Text = "Lịch dạy";
            // 
            // lblLichDayTuan
            // 
            lblLichDayTuan.AutoSize = true;
            lblLichDayTuan.Dock = DockStyle.Fill;
            lblLichDayTuan.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblLichDayTuan.ForeColor = Color.FromArgb(34, 45, 60);
            lblLichDayTuan.Location = new Point(15, 62);
            lblLichDayTuan.Name = "lblLichDayTuan";
            lblLichDayTuan.Padding = new Padding(6);
            lblLichDayTuan.Size = new Size(209, 78);
            lblLichDayTuan.TabIndex = 2;
            lblLichDayTuan.Text = "Lịch dạy tuần";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(cbWeek, 2, 1);
            tableLayoutPanel1.Controls.Add(cbSemester, 1, 1);
            tableLayoutPanel1.Controls.Add(lb5, 2, 0);
            tableLayoutPanel1.Controls.Add(label3, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(cbSchool, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(230, 65);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(807, 72);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // cbWeek
            // 
            cbWeek.BackColor = Color.Transparent;
            cbWeek.BorderRadius = 10;
            cbWeek.CustomizableEdges = customizableEdges31;
            cbWeek.Dock = DockStyle.Fill;
            cbWeek.DrawMode = DrawMode.OwnerDrawFixed;
            cbWeek.DropDownStyle = ComboBoxStyle.DropDownList;
            cbWeek.FocusedColor = Color.FromArgb(94, 148, 255);
            cbWeek.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbWeek.Font = new Font("Segoe UI", 10F);
            cbWeek.ForeColor = Color.FromArgb(68, 88, 112);
            cbWeek.ItemHeight = 30;
            cbWeek.Location = new Point(540, 28);
            cbWeek.Name = "cbWeek";
            cbWeek.ShadowDecoration.CustomizableEdges = customizableEdges32;
            cbWeek.Size = new Size(264, 36);
            cbWeek.TabIndex = 6;
            cbWeek.SelectedIndexChanged += cbWeek_SelectedIndexChanged;
            // 
            // cbSemester
            // 
            cbSemester.BackColor = Color.Transparent;
            cbSemester.BorderRadius = 10;
            cbSemester.CustomizableEdges = customizableEdges33;
            cbSemester.Dock = DockStyle.Fill;
            cbSemester.DrawMode = DrawMode.OwnerDrawFixed;
            cbSemester.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSemester.FocusedColor = Color.FromArgb(94, 148, 255);
            cbSemester.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbSemester.Font = new Font("Segoe UI", 10F);
            cbSemester.ForeColor = Color.FromArgb(68, 88, 112);
            cbSemester.ItemHeight = 30;
            cbSemester.Location = new Point(271, 28);
            cbSemester.Name = "cbSemester";
            cbSemester.ShadowDecoration.CustomizableEdges = customizableEdges34;
            cbSemester.Size = new Size(263, 36);
            cbSemester.TabIndex = 5;
            cbSemester.SelectedIndexChanged += cbSemester_SelectedIndexChanged;
            // 
            // lb5
            // 
            lb5.AutoSize = true;
            lb5.Location = new Point(540, 0);
            lb5.Name = "lb5";
            lb5.Size = new Size(41, 20);
            lb5.TabIndex = 3;
            lb5.Text = "Tuần";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(271, 0);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 1;
            label3.Text = "Học kỳ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 0;
            label2.Text = "Trường";
            // 
            // cbSchool
            // 
            cbSchool.BackColor = Color.Transparent;
            cbSchool.BorderRadius = 10;
            cbSchool.CustomizableEdges = customizableEdges35;
            cbSchool.Dock = DockStyle.Fill;
            cbSchool.DrawMode = DrawMode.OwnerDrawFixed;
            cbSchool.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSchool.FocusedColor = Color.FromArgb(94, 148, 255);
            cbSchool.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbSchool.Font = new Font("Segoe UI", 10F);
            cbSchool.ForeColor = Color.FromArgb(68, 88, 112);
            cbSchool.ItemHeight = 30;
            cbSchool.Location = new Point(3, 28);
            cbSchool.Name = "cbSchool";
            cbSchool.ShadowDecoration.CustomizableEdges = customizableEdges36;
            cbSchool.Size = new Size(262, 36);
            cbSchool.TabIndex = 4;
            cbSchool.SelectedIndexChanged += cbSchool_SelectedIndexChanged;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(btnAddSchedule, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(230, 15);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(807, 44);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // btnAddSchedule
            // 
            btnAddSchedule.BorderRadius = 10;
            btnAddSchedule.CustomizableEdges = customizableEdges37;
            btnAddSchedule.DisabledState.BorderColor = Color.DarkGray;
            btnAddSchedule.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddSchedule.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddSchedule.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddSchedule.Dock = DockStyle.Fill;
            btnAddSchedule.Font = new Font("Segoe UI", 9F);
            btnAddSchedule.ForeColor = Color.White;
            btnAddSchedule.Image = Properties.Resources.add;
            btnAddSchedule.ImageAlign = HorizontalAlignment.Left;
            btnAddSchedule.Location = new Point(540, 3);
            btnAddSchedule.Name = "btnAddSchedule";
            btnAddSchedule.ShadowDecoration.CustomizableEdges = customizableEdges38;
            btnAddSchedule.Size = new Size(264, 38);
            btnAddSchedule.TabIndex = 0;
            btnAddSchedule.Text = "Thêm lịch dạy";
            btnAddSchedule.Click += btnAddSchedule_Click;
            // 
            // UcSchedule
            // 
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            Name = "UcSchedule";
            Size = new Size(1100, 720);
            Load += UcSchedule_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContent.ResumeLayout(false);
            tlpMain.ResumeLayout(false);
            tlpMain.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            guna2Panel15.ResumeLayout(false);
            flpScheduleSundayA.ResumeLayout(false);
            flpScheduleSundayA.PerformLayout();
            guna2Panel14.ResumeLayout(false);
            flpScheduleSaturdayA.ResumeLayout(false);
            flpScheduleSaturdayA.PerformLayout();
            guna2Panel13.ResumeLayout(false);
            flpScheduleFridayA.ResumeLayout(false);
            flpScheduleFridayA.PerformLayout();
            guna2Panel12.ResumeLayout(false);
            flpScheduleThursdayA.ResumeLayout(false);
            flpScheduleThursdayA.PerformLayout();
            guna2Panel11.ResumeLayout(false);
            flpScheduleWednesdayA.ResumeLayout(false);
            flpScheduleWednesdayA.PerformLayout();
            guna2Panel10.ResumeLayout(false);
            flpScheduleTuesdayA.ResumeLayout(false);
            flpScheduleTuesdayA.PerformLayout();
            guna2Panel9.ResumeLayout(false);
            flpScheduleMondayA.ResumeLayout(false);
            flpScheduleMondayA.PerformLayout();
            guna2Panel8.ResumeLayout(false);
            flpScheduleSundayM.ResumeLayout(false);
            flpScheduleSundayM.PerformLayout();
            guna2Panel7.ResumeLayout(false);
            flpScheduleSaturdayM.ResumeLayout(false);
            flpScheduleSaturdayM.PerformLayout();
            guna2Panel6.ResumeLayout(false);
            flpScheduleFridayM.ResumeLayout(false);
            flpScheduleFridayM.PerformLayout();
            guna2Panel5.ResumeLayout(false);
            flpScheduleThursdayM.ResumeLayout(false);
            flpScheduleThursdayM.PerformLayout();
            guna2Panel4.ResumeLayout(false);
            flpScheduleWednesdayM.ResumeLayout(false);
            flpScheduleWednesdayM.PerformLayout();
            guna2Panel3.ResumeLayout(false);
            flpScheduleTuesdayM.ResumeLayout(false);
            flpScheduleTuesdayM.PerformLayout();
            guna2Panel1.ResumeLayout(false);
            flpScheduleMondayM.ResumeLayout(false);
            flpScheduleMondayM.PerformLayout();
            tlpTop.ResumeLayout(false);
            tlpTop.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);

            // Populate sample data and selector at runtime (caller should invoke these from constructor)
            // BuildWeekSelector();
            // BuildSampleWeeks();
        }

        #endregion

        #region UI helper methods (kept in Designer per request)

        // Simple DTO for combobox items
        private class ComboItem
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public override string ToString() => Name;
        }

        // Create a single day card UI element
        private Panel CreateDayCard(string dayLabel, string subjectTitle, string subjectCode, string timeRange, string room)
        {
            int cardWidth = 140;
            int cardHeight = 180;

            var outer = new Guna2Panel
            {
                Width = cardWidth,
                Height = cardHeight,
                FillColor = Color.FromArgb(230, 230, 230),
                Margin = new Padding(10),
                Padding = new Padding(8)
            };

            // itemHeader
            var header = new Panel
            {
                Height = 36,
                Dock = DockStyle.Top,
                BackColor = Color.Transparent
            };
            var lblDay = new Label
            {
                Text = dayLabel,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                ForeColor = Color.FromArgb(60, 70, 90)
            };
            header.Controls.Add(lblDay);
            outer.Controls.Add(header);

            // spacer
            var spacer = new Panel
            {
                Height = 10,
                Dock = DockStyle.Top,
                BackColor = Color.Transparent
            };
            outer.Controls.Add(spacer);

            // itemContent white box
            var content = new Panel
            {
                Width = cardWidth - outer.Padding.Left - outer.Padding.Right - 10,
                Height = 110,
                BackColor = Color.White,
                Dock = DockStyle.Top,
                Padding = new Padding(8)
            };

            var lblSubject = new Label
            {
                Text = subjectTitle,
                AutoSize = false,
                Dock = DockStyle.Top,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Color.FromArgb(34, 45, 60),
                Height = 34
            };
            content.Controls.Add(lblSubject);

            var lblCode = new Label
            {
                Text = subjectCode,
                AutoSize = false,
                Dock = DockStyle.Top,
                Font = new Font("Segoe UI", 8F, FontStyle.Regular),
                ForeColor = Color.FromArgb(110, 118, 130),
                Height = 18
            };
            content.Controls.Add(lblCode);

            var lblTime = new Label
            {
                Text = timeRange,
                AutoSize = false,
                Dock = DockStyle.Top,
                Font = new Font("Segoe UI", 8F, FontStyle.Regular),
                ForeColor = Color.FromArgb(110, 118, 130),
                Height = 18
            };
            content.Controls.Add(lblTime);

            var lblRoom = new LinkLabel
            {
                Text = room,
                AutoSize = false,
                Dock = DockStyle.Top,
                Font = new Font("Segoe UI", 8F, FontStyle.Regular),
                LinkColor = Color.FromArgb(59, 130, 246),
                Height = 18
            };
            content.Controls.Add(lblRoom);

            outer.Controls.Add(content);

            return outer;
        }

        #endregion

        private Label lbWeek;
        private Guna2Button guna2Button1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lb5;
        private Label label3;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
        private Guna2Panel guna2Panel15;
        private FlowLayoutPanel flpScheduleSundayA;
        private Label lbCourseNameSundayA;
        private Label lbClassSundayA;
        private Label lbTimeSundayA;
        private Label lbRoomSundayA;
        private Panel panel8;
        private Guna2Panel guna2Panel14;
        private FlowLayoutPanel flpScheduleSaturdayA;
        private Label lbCourseNameSaturdayA;
        private Label lbClassSaturdayA;
        private Label lbTimeSaturdayA;
        private Label lbRoomSaturdayA;
        private Panel panel9;
        private Guna2Panel guna2Panel13;
        private FlowLayoutPanel flpScheduleFridayA;
        private Label lbCourseNameFridayA;
        private Label lbClassFridayA;
        private Label lbTimeFridayA;
        private Label lbRoomFridayA;
        private Panel panel10;
        private Guna2Panel guna2Panel12;
        private FlowLayoutPanel flpScheduleThursdayA;
        private Label lbCourseNameThursdayA;
        private Label lbClassThursdayA;
        private Label lbTimeThursdayA;
        private Label lbRoomThursdayA;
        private Panel panel11;
        private Guna2Panel guna2Panel11;
        private FlowLayoutPanel flpScheduleWednesdayA;
        private Label lbCourseNameWednesdayA;
        private Label lbClassWednesdayA;
        private Label lbTimeWednesdayA;
        private Label lbRoomWednesdayA;
        private Panel panel12;
        private Guna2Panel guna2Panel10;
        private FlowLayoutPanel flpScheduleTuesdayA;
        private Label lbCourseNameTuesdayA;
        private Label lbClassTuesdayA;
        private Label lbTimeTuesdayA;
        private Label lbRoomTuesdayA;
        private Panel panel13;
        private Guna2Panel guna2Panel9;
        private FlowLayoutPanel flpScheduleMondayA;
        private Label lbCourseNameMondayA;
        private Label lbClassMondayA;
        private Label lbTimeMondayA;
        private Label lbRoomMondayA;
        private Panel panel14;
        private Guna2Panel guna2Panel8;
        private FlowLayoutPanel flpScheduleSundayM;
        private Label lbCourseNameSundayM;
        private Label lbClassSundayM;
        private Label lbTimeSundayM;
        private Label lbRoomSundayM;
        private Panel panel7;
        private Guna2Panel guna2Panel7;
        private FlowLayoutPanel flpScheduleSaturdayM;
        private Label lbCourseNameSaturdayM;
        private Label lbClassSaturdayM;
        private Label lbTimeSaturdayM;
        private Label lbRoomSaturdayM;
        private Panel panel6;
        private Guna2Panel guna2Panel6;
        private FlowLayoutPanel flpScheduleFridayM;
        private Label lbCourseNameFridayM;
        private Label lbClassFridayM;
        private Label lbTimeFridayM;
        private Label lbRoomFridayM;
        private Panel panel5;
        private Guna2Panel guna2Panel5;
        private FlowLayoutPanel flpScheduleThursdayM;
        private Label lbCourseNameThursdayM;
        private Label lbClassThursdayM;
        private Label lbTimeThursdayM;
        private Label lbRoomThursdayM;
        private Panel panel4;
        private Guna2Panel guna2Panel4;
        private FlowLayoutPanel flpScheduleWednesdayM;
        private Label lbCourseNameWednesdayM;
        private Label lbClassWednesdayM;
        private Label lbTimeWednesdayM;
        private Label lbRoomWednesdayM;
        private Panel panel3;
        private Guna2Panel guna2Panel3;
        private FlowLayoutPanel flpScheduleTuesdayM;
        private Label lbCourseNameTuesdayM;
        private Label lbClassTuesdayM;
        private Label lbTimeTuesdayM;
        private Label lbRoomTuesdayM;
        private Panel panel2;
        private Label label8;
        private Label label7;
        private Label label1;
        private Label label4;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Guna2Panel guna2Panel1;
        private FlowLayoutPanel flpScheduleMondayM;
        private Label lbCourseNameMondayM;
        private Label lbClassMondayM;
        private Label lbTimeMondayM;
        private Label lbRoomMondayM;
        private Panel panel1;
        private Panel panel15;
        private Guna2ComboBox cbSchool;
        private Guna2ComboBox cbWeek;
        private Guna2ComboBox cbSemester;
        private TableLayoutPanel tableLayoutPanel3;
        private Guna2Button btnAddSchedule;
        private Panel panel16;
        private Panel panel17;
        private Panel panel18;
        private Panel panel19;
        private Panel panel20;
        private Panel panel21;
        private Panel panel22;
    }
}