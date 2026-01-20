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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges33 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges34 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges29 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges30 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges31 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges32 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelHeader = new Guna2Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            panelContent = new Guna2Panel();
            tlpMain = new TableLayoutPanel();
            label6 = new Label();
            tlpScheduleContent = new TableLayoutPanel();
            tableLayoutPanel14 = new TableLayoutPanel();
            label32 = new Label();
            guna2Panel13 = new Guna2Panel();
            guna2Panel14 = new Guna2Panel();
            flowLayoutPanel7 = new FlowLayoutPanel();
            lbItemNameCourse8 = new Label();
            lbItemClass8 = new Label();
            lbItemTime8 = new Label();
            lbItemRoom8 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            guna2Panel1 = new Guna2Panel();
            guna2Panel2 = new Guna2Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lbItemNameCourse2 = new Label();
            lbItemClass2 = new Label();
            lbItemTime2 = new Label();
            lbItemRoom2 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            label7 = new Label();
            guna2Panel3 = new Guna2Panel();
            guna2Panel4 = new Guna2Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            lbItemNameCourse3 = new Label();
            lbItemClass3 = new Label();
            lbItemTime3 = new Label();
            lbItemRoom3 = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            label12 = new Label();
            guna2Panel5 = new Guna2Panel();
            guna2Panel6 = new Guna2Panel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            lbItemNameCourse4 = new Label();
            lbItemClass4 = new Label();
            lbItemTime4 = new Label();
            lbItemRoom4 = new Label();
            tableLayoutPanel8 = new TableLayoutPanel();
            label17 = new Label();
            guna2Panel7 = new Guna2Panel();
            guna2Panel8 = new Guna2Panel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            lbItemNameCourse5 = new Label();
            lbItemClass5 = new Label();
            lbItemTime5 = new Label();
            lbItemRoom5 = new Label();
            tableLayoutPanel10 = new TableLayoutPanel();
            label22 = new Label();
            guna2Panel9 = new Guna2Panel();
            guna2Panel10 = new Guna2Panel();
            flowLayoutPanel5 = new FlowLayoutPanel();
            lbItemNameCourse6 = new Label();
            lbItemClass6 = new Label();
            lbItemTime6 = new Label();
            lbItemRoom6 = new Label();
            tableLayoutPanel12 = new TableLayoutPanel();
            label27 = new Label();
            guna2Panel11 = new Guna2Panel();
            guna2Panel12 = new Guna2Panel();
            flowLayoutPanel6 = new FlowLayoutPanel();
            lbItemNameCourse7 = new Label();
            lbItemClass7 = new Label();
            lbItemTime7 = new Label();
            lbItemRoom7 = new Label();
            tlpTop = new TableLayoutPanel();
            lblLichDay = new Label();
            lblLichDayTuan = new Label();
            guna2Button1 = new Guna2Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            panelHeader.SuspendLayout();
            panelContent.SuspendLayout();
            tlpMain.SuspendLayout();
            tlpScheduleContent.SuspendLayout();
            tableLayoutPanel14.SuspendLayout();
            guna2Panel13.SuspendLayout();
            guna2Panel14.SuspendLayout();
            flowLayoutPanel7.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            guna2Panel1.SuspendLayout();
            guna2Panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            guna2Panel3.SuspendLayout();
            guna2Panel4.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            guna2Panel5.SuspendLayout();
            guna2Panel6.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            guna2Panel7.SuspendLayout();
            guna2Panel8.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            guna2Panel9.SuspendLayout();
            guna2Panel10.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            guna2Panel11.SuspendLayout();
            guna2Panel12.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            tlpTop.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
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
            panelContent.CustomizableEdges = customizableEdges33;
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 110);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(24);
            panelContent.ShadowDecoration.CustomizableEdges = customizableEdges34;
            panelContent.Size = new Size(1100, 610);
            panelContent.TabIndex = 0;
            // 
            // tlpMain
            // 
            tlpMain.BackColor = Color.White;
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(label6, 0, 0);
            tlpMain.Controls.Add(tlpScheduleContent, 0, 1);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(24, 147);
            tlpMain.Name = "tlpMain";
            tlpMain.Padding = new Padding(12);
            tlpMain.RowCount = 2;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.Size = new Size(1052, 439);
            tlpMain.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(34, 45, 60);
            label6.Location = new Point(15, 12);
            label6.Name = "label6";
            label6.Padding = new Padding(6);
            label6.Size = new Size(1022, 50);
            label6.TabIndex = 3;
            label6.Text = "Tuần 1 ";
            // 
            // tlpScheduleContent
            // 
            tlpScheduleContent.ColumnCount = 7;
            tlpScheduleContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857113F));
            tlpScheduleContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tlpScheduleContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tlpScheduleContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tlpScheduleContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tlpScheduleContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tlpScheduleContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tlpScheduleContent.Controls.Add(tableLayoutPanel14, 6, 1);
            tlpScheduleContent.Controls.Add(tableLayoutPanel2, 0, 1);
            tlpScheduleContent.Controls.Add(tableLayoutPanel4, 1, 1);
            tlpScheduleContent.Controls.Add(tableLayoutPanel6, 2, 1);
            tlpScheduleContent.Controls.Add(tableLayoutPanel8, 3, 1);
            tlpScheduleContent.Controls.Add(tableLayoutPanel10, 4, 1);
            tlpScheduleContent.Controls.Add(tableLayoutPanel12, 5, 1);
            tlpScheduleContent.Dock = DockStyle.Fill;
            tlpScheduleContent.Location = new Point(15, 65);
            tlpScheduleContent.Name = "tlpScheduleContent";
            tlpScheduleContent.RowCount = 3;
            tlpScheduleContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpScheduleContent.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpScheduleContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpScheduleContent.Size = new Size(1022, 359);
            tlpScheduleContent.TabIndex = 4;
            // 
            // tableLayoutPanel14
            // 
            tableLayoutPanel14.BackColor = SystemColors.Control;
            tableLayoutPanel14.ColumnCount = 1;
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel14.Controls.Add(label32, 0, 0);
            tableLayoutPanel14.Controls.Add(guna2Panel13, 0, 1);
            tableLayoutPanel14.Dock = DockStyle.Fill;
            tableLayoutPanel14.Location = new Point(878, 33);
            tableLayoutPanel14.Margin = new Padding(3, 3, 20, 3);
            tableLayoutPanel14.Name = "tableLayoutPanel14";
            tableLayoutPanel14.RowCount = 2;
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel14.Size = new Size(124, 293);
            tableLayoutPanel14.TabIndex = 10;
            // 
            // label32
            // 
            label32.BackColor = Color.Transparent;
            label32.Dock = DockStyle.Fill;
            label32.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label32.Location = new Point(3, 0);
            label32.Name = "label32";
            label32.Size = new Size(118, 87);
            label32.TabIndex = 0;
            label32.Text = "Chủ nhật";
            label32.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guna2Panel13
            // 
            guna2Panel13.BackColor = Color.Transparent;
            guna2Panel13.Controls.Add(guna2Panel14);
            guna2Panel13.CustomizableEdges = customizableEdges5;
            guna2Panel13.Dock = DockStyle.Fill;
            guna2Panel13.Location = new Point(3, 90);
            guna2Panel13.Name = "guna2Panel13";
            guna2Panel13.Padding = new Padding(10);
            guna2Panel13.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel13.Size = new Size(118, 200);
            guna2Panel13.TabIndex = 1;
            // 
            // guna2Panel14
            // 
            guna2Panel14.BackColor = Color.White;
            guna2Panel14.BorderRadius = 10;
            guna2Panel14.Controls.Add(flowLayoutPanel7);
            guna2Panel14.CustomizableEdges = customizableEdges3;
            guna2Panel14.Dock = DockStyle.Fill;
            guna2Panel14.Location = new Point(10, 10);
            guna2Panel14.Name = "guna2Panel14";
            guna2Panel14.Padding = new Padding(20);
            guna2Panel14.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel14.Size = new Size(98, 180);
            guna2Panel14.TabIndex = 0;
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.Controls.Add(lbItemNameCourse8);
            flowLayoutPanel7.Controls.Add(lbItemClass8);
            flowLayoutPanel7.Controls.Add(lbItemTime8);
            flowLayoutPanel7.Controls.Add(lbItemRoom8);
            flowLayoutPanel7.Dock = DockStyle.Fill;
            flowLayoutPanel7.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel7.Location = new Point(20, 20);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Size = new Size(58, 140);
            flowLayoutPanel7.TabIndex = 0;
            flowLayoutPanel7.WrapContents = false;
            // 
            // lbItemNameCourse8
            // 
            lbItemNameCourse8.AutoSize = true;
            lbItemNameCourse8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lbItemNameCourse8.Location = new Point(3, 0);
            lbItemNameCourse8.Name = "lbItemNameCourse8";
            lbItemNameCourse8.Size = new Size(49, 46);
            lbItemNameCourse8.TabIndex = 4;
            lbItemNameCourse8.Text = "label36";
            // 
            // lbItemClass8
            // 
            lbItemClass8.AutoSize = true;
            lbItemClass8.Location = new Point(3, 46);
            lbItemClass8.Name = "lbItemClass8";
            lbItemClass8.Size = new Size(50, 40);
            lbItemClass8.TabIndex = 5;
            lbItemClass8.Text = "label35";
            // 
            // lbItemTime8
            // 
            lbItemTime8.AutoSize = true;
            lbItemTime8.Location = new Point(3, 86);
            lbItemTime8.Name = "lbItemTime8";
            lbItemTime8.Size = new Size(50, 40);
            lbItemTime8.TabIndex = 6;
            lbItemTime8.Text = "label34";
            // 
            // lbItemRoom8
            // 
            lbItemRoom8.AutoSize = true;
            lbItemRoom8.ForeColor = Color.Blue;
            lbItemRoom8.Location = new Point(3, 126);
            lbItemRoom8.Name = "lbItemRoom8";
            lbItemRoom8.Size = new Size(50, 40);
            lbItemRoom8.TabIndex = 7;
            lbItemRoom8.Text = "label33";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = SystemColors.Control;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(guna2Panel1, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(20, 33);
            tableLayoutPanel2.Margin = new Padding(20, 3, 20, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(105, 293);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(99, 87);
            label1.TabIndex = 0;
            label1.Text = "Thứ 2";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel1.Controls.Add(guna2Panel2);
            guna2Panel1.CustomizableEdges = customizableEdges9;
            guna2Panel1.Dock = DockStyle.Fill;
            guna2Panel1.Location = new Point(3, 90);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.Padding = new Padding(10);
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2Panel1.Size = new Size(99, 200);
            guna2Panel1.TabIndex = 1;
            // 
            // guna2Panel2
            // 
            guna2Panel2.BackColor = Color.White;
            guna2Panel2.BorderRadius = 10;
            guna2Panel2.Controls.Add(flowLayoutPanel1);
            guna2Panel2.CustomizableEdges = customizableEdges7;
            guna2Panel2.Dock = DockStyle.Fill;
            guna2Panel2.Location = new Point(10, 10);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.Padding = new Padding(20);
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Panel2.Size = new Size(79, 180);
            guna2Panel2.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lbItemNameCourse2);
            flowLayoutPanel1.Controls.Add(lbItemClass2);
            flowLayoutPanel1.Controls.Add(lbItemTime2);
            flowLayoutPanel1.Controls.Add(lbItemRoom2);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(20, 20);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(39, 140);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            // 
            // lbItemNameCourse2
            // 
            lbItemNameCourse2.AutoSize = true;
            lbItemNameCourse2.Dock = DockStyle.Fill;
            lbItemNameCourse2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lbItemNameCourse2.Location = new Point(3, 0);
            lbItemNameCourse2.Name = "lbItemNameCourse2";
            lbItemNameCourse2.Size = new Size(30, 23);
            lbItemNameCourse2.TabIndex = 4;
            lbItemNameCourse2.Text = "1";
            // 
            // lbItemClass2
            // 
            lbItemClass2.AutoSize = true;
            lbItemClass2.Dock = DockStyle.Fill;
            lbItemClass2.Location = new Point(3, 23);
            lbItemClass2.Name = "lbItemClass2";
            lbItemClass2.Size = new Size(30, 40);
            lbItemClass2.TabIndex = 5;
            lbItemClass2.Text = "label3";
            // 
            // lbItemTime2
            // 
            lbItemTime2.AutoSize = true;
            lbItemTime2.Dock = DockStyle.Fill;
            lbItemTime2.Location = new Point(3, 63);
            lbItemTime2.Name = "lbItemTime2";
            lbItemTime2.Size = new Size(30, 40);
            lbItemTime2.TabIndex = 6;
            lbItemTime2.Text = "label4";
            // 
            // lbItemRoom2
            // 
            lbItemRoom2.AutoSize = true;
            lbItemRoom2.Dock = DockStyle.Fill;
            lbItemRoom2.ForeColor = Color.Blue;
            lbItemRoom2.Location = new Point(3, 103);
            lbItemRoom2.Name = "lbItemRoom2";
            lbItemRoom2.Size = new Size(30, 40);
            lbItemRoom2.TabIndex = 7;
            lbItemRoom2.Text = "label5";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = SystemColors.Control;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(label7, 0, 0);
            tableLayoutPanel4.Controls.Add(guna2Panel3, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(148, 33);
            tableLayoutPanel4.Margin = new Padding(3, 3, 20, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel4.Size = new Size(123, 293);
            tableLayoutPanel4.TabIndex = 5;
            // 
            // label7
            // 
            label7.BackColor = Color.Transparent;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(117, 87);
            label7.TabIndex = 0;
            label7.Text = "Thứ 3";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guna2Panel3
            // 
            guna2Panel3.BackColor = Color.Transparent;
            guna2Panel3.Controls.Add(guna2Panel4);
            guna2Panel3.CustomizableEdges = customizableEdges13;
            guna2Panel3.Dock = DockStyle.Fill;
            guna2Panel3.Location = new Point(3, 90);
            guna2Panel3.Name = "guna2Panel3";
            guna2Panel3.Padding = new Padding(10);
            guna2Panel3.ShadowDecoration.CustomizableEdges = customizableEdges14;
            guna2Panel3.Size = new Size(117, 200);
            guna2Panel3.TabIndex = 1;
            // 
            // guna2Panel4
            // 
            guna2Panel4.BackColor = Color.White;
            guna2Panel4.BorderRadius = 10;
            guna2Panel4.Controls.Add(flowLayoutPanel2);
            guna2Panel4.CustomizableEdges = customizableEdges11;
            guna2Panel4.Dock = DockStyle.Fill;
            guna2Panel4.Location = new Point(10, 10);
            guna2Panel4.Name = "guna2Panel4";
            guna2Panel4.Padding = new Padding(20);
            guna2Panel4.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2Panel4.Size = new Size(97, 180);
            guna2Panel4.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(lbItemNameCourse3);
            flowLayoutPanel2.Controls.Add(lbItemClass3);
            flowLayoutPanel2.Controls.Add(lbItemTime3);
            flowLayoutPanel2.Controls.Add(lbItemRoom3);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(20, 20);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(57, 140);
            flowLayoutPanel2.TabIndex = 0;
            flowLayoutPanel2.WrapContents = false;
            // 
            // lbItemNameCourse3
            // 
            lbItemNameCourse3.AutoSize = true;
            lbItemNameCourse3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lbItemNameCourse3.Location = new Point(3, 0);
            lbItemNameCourse3.Name = "lbItemNameCourse3";
            lbItemNameCourse3.Size = new Size(49, 46);
            lbItemNameCourse3.TabIndex = 4;
            lbItemNameCourse3.Text = "label11";
            // 
            // lbItemClass3
            // 
            lbItemClass3.AutoSize = true;
            lbItemClass3.Location = new Point(3, 46);
            lbItemClass3.Name = "lbItemClass3";
            lbItemClass3.Size = new Size(50, 40);
            lbItemClass3.TabIndex = 5;
            lbItemClass3.Text = "label10";
            // 
            // lbItemTime3
            // 
            lbItemTime3.AutoSize = true;
            lbItemTime3.Location = new Point(3, 86);
            lbItemTime3.Name = "lbItemTime3";
            lbItemTime3.Size = new Size(50, 20);
            lbItemTime3.TabIndex = 6;
            lbItemTime3.Text = "label9";
            // 
            // lbItemRoom3
            // 
            lbItemRoom3.AutoSize = true;
            lbItemRoom3.ForeColor = Color.Blue;
            lbItemRoom3.Location = new Point(3, 106);
            lbItemRoom3.Name = "lbItemRoom3";
            lbItemRoom3.Size = new Size(50, 20);
            lbItemRoom3.TabIndex = 7;
            lbItemRoom3.Text = "label8";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.BackColor = SystemColors.Control;
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(label12, 0, 0);
            tableLayoutPanel6.Controls.Add(guna2Panel5, 0, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(294, 33);
            tableLayoutPanel6.Margin = new Padding(3, 3, 20, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel6.Size = new Size(123, 293);
            tableLayoutPanel6.TabIndex = 6;
            // 
            // label12
            // 
            label12.BackColor = Color.Transparent;
            label12.Dock = DockStyle.Fill;
            label12.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(3, 0);
            label12.Name = "label12";
            label12.Size = new Size(117, 87);
            label12.TabIndex = 0;
            label12.Text = "Thứ 4";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guna2Panel5
            // 
            guna2Panel5.BackColor = Color.Transparent;
            guna2Panel5.Controls.Add(guna2Panel6);
            guna2Panel5.CustomizableEdges = customizableEdges17;
            guna2Panel5.Dock = DockStyle.Fill;
            guna2Panel5.Location = new Point(3, 90);
            guna2Panel5.Name = "guna2Panel5";
            guna2Panel5.Padding = new Padding(10);
            guna2Panel5.ShadowDecoration.CustomizableEdges = customizableEdges18;
            guna2Panel5.Size = new Size(117, 200);
            guna2Panel5.TabIndex = 1;
            // 
            // guna2Panel6
            // 
            guna2Panel6.BackColor = Color.White;
            guna2Panel6.BorderRadius = 10;
            guna2Panel6.Controls.Add(flowLayoutPanel3);
            guna2Panel6.CustomizableEdges = customizableEdges15;
            guna2Panel6.Dock = DockStyle.Fill;
            guna2Panel6.Location = new Point(10, 10);
            guna2Panel6.Name = "guna2Panel6";
            guna2Panel6.Padding = new Padding(20);
            guna2Panel6.ShadowDecoration.CustomizableEdges = customizableEdges16;
            guna2Panel6.Size = new Size(97, 180);
            guna2Panel6.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(lbItemNameCourse4);
            flowLayoutPanel3.Controls.Add(lbItemClass4);
            flowLayoutPanel3.Controls.Add(lbItemTime4);
            flowLayoutPanel3.Controls.Add(lbItemRoom4);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(20, 20);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(57, 140);
            flowLayoutPanel3.TabIndex = 0;
            flowLayoutPanel3.WrapContents = false;
            // 
            // lbItemNameCourse4
            // 
            lbItemNameCourse4.AutoSize = true;
            lbItemNameCourse4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lbItemNameCourse4.Location = new Point(3, 0);
            lbItemNameCourse4.Name = "lbItemNameCourse4";
            lbItemNameCourse4.Size = new Size(49, 46);
            lbItemNameCourse4.TabIndex = 4;
            lbItemNameCourse4.Text = "label16";
            // 
            // lbItemClass4
            // 
            lbItemClass4.AutoSize = true;
            lbItemClass4.Location = new Point(3, 46);
            lbItemClass4.Name = "lbItemClass4";
            lbItemClass4.Size = new Size(50, 40);
            lbItemClass4.TabIndex = 5;
            lbItemClass4.Text = "label15";
            // 
            // lbItemTime4
            // 
            lbItemTime4.AutoSize = true;
            lbItemTime4.Location = new Point(3, 86);
            lbItemTime4.Name = "lbItemTime4";
            lbItemTime4.Size = new Size(50, 40);
            lbItemTime4.TabIndex = 6;
            lbItemTime4.Text = "label14";
            // 
            // lbItemRoom4
            // 
            lbItemRoom4.AutoSize = true;
            lbItemRoom4.ForeColor = Color.Blue;
            lbItemRoom4.Location = new Point(3, 126);
            lbItemRoom4.Name = "lbItemRoom4";
            lbItemRoom4.Size = new Size(50, 40);
            lbItemRoom4.TabIndex = 7;
            lbItemRoom4.Text = "label13";
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.BackColor = SystemColors.Control;
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Controls.Add(label17, 0, 0);
            tableLayoutPanel8.Controls.Add(guna2Panel7, 0, 1);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(440, 33);
            tableLayoutPanel8.Margin = new Padding(3, 3, 20, 3);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel8.Size = new Size(123, 293);
            tableLayoutPanel8.TabIndex = 7;
            // 
            // label17
            // 
            label17.BackColor = Color.Transparent;
            label17.Dock = DockStyle.Fill;
            label17.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(3, 0);
            label17.Name = "label17";
            label17.Size = new Size(117, 87);
            label17.TabIndex = 0;
            label17.Text = "Thứ 5";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guna2Panel7
            // 
            guna2Panel7.BackColor = Color.Transparent;
            guna2Panel7.Controls.Add(guna2Panel8);
            guna2Panel7.CustomizableEdges = customizableEdges21;
            guna2Panel7.Dock = DockStyle.Fill;
            guna2Panel7.Location = new Point(3, 90);
            guna2Panel7.Name = "guna2Panel7";
            guna2Panel7.Padding = new Padding(10);
            guna2Panel7.ShadowDecoration.CustomizableEdges = customizableEdges22;
            guna2Panel7.Size = new Size(117, 200);
            guna2Panel7.TabIndex = 1;
            // 
            // guna2Panel8
            // 
            guna2Panel8.BackColor = Color.White;
            guna2Panel8.BorderRadius = 10;
            guna2Panel8.Controls.Add(flowLayoutPanel4);
            guna2Panel8.CustomizableEdges = customizableEdges19;
            guna2Panel8.Dock = DockStyle.Fill;
            guna2Panel8.Location = new Point(10, 10);
            guna2Panel8.Name = "guna2Panel8";
            guna2Panel8.Padding = new Padding(20);
            guna2Panel8.ShadowDecoration.CustomizableEdges = customizableEdges20;
            guna2Panel8.Size = new Size(97, 180);
            guna2Panel8.TabIndex = 0;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(lbItemNameCourse5);
            flowLayoutPanel4.Controls.Add(lbItemClass5);
            flowLayoutPanel4.Controls.Add(lbItemTime5);
            flowLayoutPanel4.Controls.Add(lbItemRoom5);
            flowLayoutPanel4.Dock = DockStyle.Fill;
            flowLayoutPanel4.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel4.Location = new Point(20, 20);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(57, 140);
            flowLayoutPanel4.TabIndex = 0;
            flowLayoutPanel4.WrapContents = false;
            // 
            // lbItemNameCourse5
            // 
            lbItemNameCourse5.AutoSize = true;
            lbItemNameCourse5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lbItemNameCourse5.Location = new Point(3, 0);
            lbItemNameCourse5.Name = "lbItemNameCourse5";
            lbItemNameCourse5.Size = new Size(49, 46);
            lbItemNameCourse5.TabIndex = 4;
            lbItemNameCourse5.Text = "label21";
            // 
            // lbItemClass5
            // 
            lbItemClass5.AutoSize = true;
            lbItemClass5.Location = new Point(3, 46);
            lbItemClass5.Name = "lbItemClass5";
            lbItemClass5.Size = new Size(50, 40);
            lbItemClass5.TabIndex = 5;
            lbItemClass5.Text = "label20";
            // 
            // lbItemTime5
            // 
            lbItemTime5.AutoSize = true;
            lbItemTime5.Location = new Point(3, 86);
            lbItemTime5.Name = "lbItemTime5";
            lbItemTime5.Size = new Size(50, 40);
            lbItemTime5.TabIndex = 6;
            lbItemTime5.Text = "label19";
            // 
            // lbItemRoom5
            // 
            lbItemRoom5.AutoSize = true;
            lbItemRoom5.ForeColor = Color.Blue;
            lbItemRoom5.Location = new Point(3, 126);
            lbItemRoom5.Name = "lbItemRoom5";
            lbItemRoom5.Size = new Size(50, 40);
            lbItemRoom5.TabIndex = 7;
            lbItemRoom5.Text = "label18";
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.BackColor = SystemColors.Control;
            tableLayoutPanel10.ColumnCount = 1;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.Controls.Add(label22, 0, 0);
            tableLayoutPanel10.Controls.Add(guna2Panel9, 0, 1);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(586, 33);
            tableLayoutPanel10.Margin = new Padding(3, 3, 20, 3);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 2;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel10.Size = new Size(123, 293);
            tableLayoutPanel10.TabIndex = 8;
            // 
            // label22
            // 
            label22.BackColor = Color.Transparent;
            label22.Dock = DockStyle.Fill;
            label22.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(3, 0);
            label22.Name = "label22";
            label22.Size = new Size(117, 87);
            label22.TabIndex = 0;
            label22.Text = "Thứ 6";
            label22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guna2Panel9
            // 
            guna2Panel9.BackColor = Color.Transparent;
            guna2Panel9.Controls.Add(guna2Panel10);
            guna2Panel9.CustomizableEdges = customizableEdges25;
            guna2Panel9.Dock = DockStyle.Fill;
            guna2Panel9.Location = new Point(3, 90);
            guna2Panel9.Name = "guna2Panel9";
            guna2Panel9.Padding = new Padding(10);
            guna2Panel9.ShadowDecoration.CustomizableEdges = customizableEdges26;
            guna2Panel9.Size = new Size(117, 200);
            guna2Panel9.TabIndex = 1;
            // 
            // guna2Panel10
            // 
            guna2Panel10.BackColor = Color.White;
            guna2Panel10.BorderRadius = 10;
            guna2Panel10.Controls.Add(flowLayoutPanel5);
            guna2Panel10.CustomizableEdges = customizableEdges23;
            guna2Panel10.Dock = DockStyle.Fill;
            guna2Panel10.Location = new Point(10, 10);
            guna2Panel10.Name = "guna2Panel10";
            guna2Panel10.Padding = new Padding(20);
            guna2Panel10.ShadowDecoration.CustomizableEdges = customizableEdges24;
            guna2Panel10.Size = new Size(97, 180);
            guna2Panel10.TabIndex = 0;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(lbItemNameCourse6);
            flowLayoutPanel5.Controls.Add(lbItemClass6);
            flowLayoutPanel5.Controls.Add(lbItemTime6);
            flowLayoutPanel5.Controls.Add(lbItemRoom6);
            flowLayoutPanel5.Dock = DockStyle.Fill;
            flowLayoutPanel5.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel5.Location = new Point(20, 20);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(57, 140);
            flowLayoutPanel5.TabIndex = 0;
            flowLayoutPanel5.WrapContents = false;
            // 
            // lbItemNameCourse6
            // 
            lbItemNameCourse6.AutoSize = true;
            lbItemNameCourse6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lbItemNameCourse6.Location = new Point(3, 0);
            lbItemNameCourse6.Name = "lbItemNameCourse6";
            lbItemNameCourse6.Size = new Size(49, 46);
            lbItemNameCourse6.TabIndex = 4;
            lbItemNameCourse6.Text = "label26";
            // 
            // lbItemClass6
            // 
            lbItemClass6.AutoSize = true;
            lbItemClass6.Location = new Point(3, 46);
            lbItemClass6.Name = "lbItemClass6";
            lbItemClass6.Size = new Size(50, 40);
            lbItemClass6.TabIndex = 5;
            lbItemClass6.Text = "label25";
            // 
            // lbItemTime6
            // 
            lbItemTime6.AutoSize = true;
            lbItemTime6.Location = new Point(3, 86);
            lbItemTime6.Name = "lbItemTime6";
            lbItemTime6.Size = new Size(50, 40);
            lbItemTime6.TabIndex = 6;
            lbItemTime6.Text = "label24";
            // 
            // lbItemRoom6
            // 
            lbItemRoom6.AutoSize = true;
            lbItemRoom6.ForeColor = Color.Blue;
            lbItemRoom6.Location = new Point(3, 126);
            lbItemRoom6.Name = "lbItemRoom6";
            lbItemRoom6.Size = new Size(50, 40);
            lbItemRoom6.TabIndex = 7;
            lbItemRoom6.Text = "label23";
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.BackColor = SystemColors.Control;
            tableLayoutPanel12.ColumnCount = 1;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel12.Controls.Add(label27, 0, 0);
            tableLayoutPanel12.Controls.Add(guna2Panel11, 0, 1);
            tableLayoutPanel12.Dock = DockStyle.Fill;
            tableLayoutPanel12.Location = new Point(732, 33);
            tableLayoutPanel12.Margin = new Padding(3, 3, 20, 3);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 2;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel12.Size = new Size(123, 293);
            tableLayoutPanel12.TabIndex = 9;
            // 
            // label27
            // 
            label27.BackColor = Color.Transparent;
            label27.Dock = DockStyle.Fill;
            label27.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label27.Location = new Point(3, 0);
            label27.Name = "label27";
            label27.Size = new Size(117, 87);
            label27.TabIndex = 0;
            label27.Text = "Thứ 7";
            label27.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guna2Panel11
            // 
            guna2Panel11.BackColor = Color.Transparent;
            guna2Panel11.Controls.Add(guna2Panel12);
            guna2Panel11.CustomizableEdges = customizableEdges29;
            guna2Panel11.Dock = DockStyle.Fill;
            guna2Panel11.Location = new Point(3, 90);
            guna2Panel11.Name = "guna2Panel11";
            guna2Panel11.Padding = new Padding(10);
            guna2Panel11.ShadowDecoration.CustomizableEdges = customizableEdges30;
            guna2Panel11.Size = new Size(117, 200);
            guna2Panel11.TabIndex = 1;
            // 
            // guna2Panel12
            // 
            guna2Panel12.BackColor = Color.White;
            guna2Panel12.BorderRadius = 10;
            guna2Panel12.Controls.Add(flowLayoutPanel6);
            guna2Panel12.CustomizableEdges = customizableEdges27;
            guna2Panel12.Dock = DockStyle.Fill;
            guna2Panel12.Location = new Point(10, 10);
            guna2Panel12.Name = "guna2Panel12";
            guna2Panel12.Padding = new Padding(20);
            guna2Panel12.ShadowDecoration.CustomizableEdges = customizableEdges28;
            guna2Panel12.Size = new Size(97, 180);
            guna2Panel12.TabIndex = 0;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.Controls.Add(lbItemNameCourse7);
            flowLayoutPanel6.Controls.Add(lbItemClass7);
            flowLayoutPanel6.Controls.Add(lbItemTime7);
            flowLayoutPanel6.Controls.Add(lbItemRoom7);
            flowLayoutPanel6.Dock = DockStyle.Fill;
            flowLayoutPanel6.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel6.Location = new Point(20, 20);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(57, 140);
            flowLayoutPanel6.TabIndex = 0;
            flowLayoutPanel6.WrapContents = false;
            // 
            // lbItemNameCourse7
            // 
            lbItemNameCourse7.AutoSize = true;
            lbItemNameCourse7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lbItemNameCourse7.Location = new Point(3, 0);
            lbItemNameCourse7.Name = "lbItemNameCourse7";
            lbItemNameCourse7.Size = new Size(49, 46);
            lbItemNameCourse7.TabIndex = 4;
            lbItemNameCourse7.Text = "label31";
            // 
            // lbItemClass7
            // 
            lbItemClass7.AutoSize = true;
            lbItemClass7.Location = new Point(3, 46);
            lbItemClass7.Name = "lbItemClass7";
            lbItemClass7.Size = new Size(50, 40);
            lbItemClass7.TabIndex = 5;
            lbItemClass7.Text = "label30";
            // 
            // lbItemTime7
            // 
            lbItemTime7.AutoSize = true;
            lbItemTime7.Location = new Point(3, 86);
            lbItemTime7.Name = "lbItemTime7";
            lbItemTime7.Size = new Size(50, 40);
            lbItemTime7.TabIndex = 6;
            lbItemTime7.Text = "label29";
            // 
            // lbItemRoom7
            // 
            lbItemRoom7.AutoSize = true;
            lbItemRoom7.ForeColor = Color.Blue;
            lbItemRoom7.Location = new Point(3, 126);
            lbItemRoom7.Name = "lbItemRoom7";
            lbItemRoom7.Size = new Size(50, 40);
            lbItemRoom7.TabIndex = 7;
            lbItemRoom7.Text = "label28";
            // 
            // tlpTop
            // 
            tlpTop.BackColor = Color.White;
            tlpTop.ColumnCount = 2;
            tlpTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.9143963F));
            tlpTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.0856F));
            tlpTop.Controls.Add(lblLichDay, 0, 0);
            tlpTop.Controls.Add(lblLichDayTuan, 0, 1);
            tlpTop.Controls.Add(guna2Button1, 1, 0);
            tlpTop.Controls.Add(tableLayoutPanel1, 1, 1);
            tlpTop.Dock = DockStyle.Top;
            tlpTop.Location = new Point(24, 24);
            tlpTop.Name = "tlpTop";
            tlpTop.Padding = new Padding(12);
            tlpTop.RowCount = 2;
            tlpTop.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tlpTop.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tlpTop.Size = new Size(1052, 123);
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
            lblLichDay.Size = new Size(209, 53);
            lblLichDay.TabIndex = 0;
            lblLichDay.Text = "Lịch dạy";
            // 
            // lblLichDayTuan
            // 
            lblLichDayTuan.AutoSize = true;
            lblLichDayTuan.Dock = DockStyle.Fill;
            lblLichDayTuan.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblLichDayTuan.ForeColor = Color.FromArgb(34, 45, 60);
            lblLichDayTuan.Location = new Point(15, 65);
            lblLichDayTuan.Name = "lblLichDayTuan";
            lblLichDayTuan.Padding = new Padding(6);
            lblLichDayTuan.Size = new Size(209, 75);
            lblLichDayTuan.TabIndex = 2;
            lblLichDayTuan.Text = "Lịch dạy tuần";
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges31;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(230, 15);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges32;
            guna2Button1.Size = new Size(225, 47);
            guna2Button1.TabIndex = 3;
            guna2Button1.Text = "guna2Button1";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(label5, 2, 0);
            tableLayoutPanel1.Controls.Add(label3, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(230, 68);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(807, 69);
            tableLayoutPanel1.TabIndex = 4;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(271, 0);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 1;
            label3.Text = "Học kỳ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(539, 0);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 3;
            label5.Text = "label5";
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
            tlpScheduleContent.ResumeLayout(false);
            tableLayoutPanel14.ResumeLayout(false);
            guna2Panel13.ResumeLayout(false);
            guna2Panel14.ResumeLayout(false);
            flowLayoutPanel7.ResumeLayout(false);
            flowLayoutPanel7.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            guna2Panel1.ResumeLayout(false);
            guna2Panel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            guna2Panel3.ResumeLayout(false);
            guna2Panel4.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            guna2Panel5.ResumeLayout(false);
            guna2Panel6.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            guna2Panel7.ResumeLayout(false);
            guna2Panel8.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            tableLayoutPanel10.ResumeLayout(false);
            guna2Panel9.ResumeLayout(false);
            guna2Panel10.ResumeLayout(false);
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            tableLayoutPanel12.ResumeLayout(false);
            guna2Panel11.ResumeLayout(false);
            guna2Panel12.ResumeLayout(false);
            flowLayoutPanel6.ResumeLayout(false);
            flowLayoutPanel6.PerformLayout();
            tlpTop.ResumeLayout(false);
            tlpTop.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
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

        // Populate cbWeekSelect with sample weeks
        private void BuildWeekSelector()
        {
            if (cbWeekSelect == null) return;

            var weeks = new[]
            {
                new ComboItem { Id = 1, Name = "Tuần 1 (15/01 - 21/01)" },
                new ComboItem { Id = 2, Name = "Tuần 2 (22/01 - 28/01)" }
            }.ToList();

            cbWeekSelect.DisplayMember = "Name";
            cbWeekSelect.ValueMember = "Id";
            cbWeekSelect.DataSource = weeks;
            cbWeekSelect.StartIndex = 0;
        }

        // Create a week panel with a title and a horizontal FlowLayoutPanel containing 7 day cards
        private Panel CreateWeekPanel(int weekId, string weekLabel)
        {
            var container = new Panel
            {
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                BackColor = Color.Transparent,
                Padding = new Padding(6),
                Margin = new Padding(6),
                MaximumSize = new Size(int.MaxValue, 1000)
            };

            var lbl = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 11F, FontStyle.Regular),
                ForeColor = Color.FromArgb(34, 45, 60),
                Text = weekLabel,
                Dock = DockStyle.Top,
                Padding = new Padding(4)
            };
            container.Controls.Add(lbl);

            var flow = new FlowLayoutPanel
            {
                Dock = DockStyle.Top,
                Height = 220,
                AutoSize = false,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                Padding = new Padding(6),
                BackColor = Color.Transparent
            };

            // create 7 day cards (Thứ 2 -> Chủ nhật)
            var dayNames = new[] { "Thứ 2", "Thứ 3", "Thứ 4", "Thứ 5", "Thứ 6", "Thứ 7", "Chủ nhật" };
            for (int i = 0; i < 7; i++)
            {
                // sample content varies a bit
                string subjectTitle = i % 3 == 0 ? "Cơ sở dữ liệu" : (i % 3 == 1 ? "Kiểm thử phần mềm" : "Lập trình Java");
                string subjectCode = $"CNTT0{(i % 4) + 1}";
                string timeRange = i % 3 == 1 ? "09:30-11:30" : "07:30-09:30";
                string room = $"P30{(i % 4) + 1}";

                var dayCard = CreateDayCard(dayNames[i], subjectTitle, subjectCode, timeRange, room);
                flow.Controls.Add(dayCard);
            }

            container.Controls.Add(flow);
            return container;
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

        private Label label6;
        private TableLayoutPanel tlpScheduleContent;
        private TableLayoutPanel tableLayoutPanel14;
        private Label label32;
        private Guna2Panel guna2Panel13;
        private Guna2Panel guna2Panel14;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Guna2Panel guna2Panel1;
        private Guna2Panel guna2Panel2;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label7;
        private Guna2Panel guna2Panel3;
        private Guna2Panel guna2Panel4;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label12;
        private Guna2Panel guna2Panel5;
        private Guna2Panel guna2Panel6;
        private TableLayoutPanel tableLayoutPanel8;
        private Label label17;
        private Guna2Panel guna2Panel7;
        private Guna2Panel guna2Panel8;
        private TableLayoutPanel tableLayoutPanel10;
        private Label label22;
        private Guna2Panel guna2Panel9;
        private Guna2Panel guna2Panel10;
        private TableLayoutPanel tableLayoutPanel12;
        private Label label27;
        private Guna2Panel guna2Panel11;
        private Guna2Panel guna2Panel12;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lbItemNameCourse2;
        private Label lbItemRoom2;
        private Label lbItemTime2;
        private Label lbItemClass2;
        private FlowLayoutPanel flowLayoutPanel7;
        private Label lbItemNameCourse8;
        private Label lbItemClass8;
        private Label lbItemTime8;
        private Label lbItemRoom8;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label lbItemNameCourse3;
        private Label lbItemClass3;
        private Label lbItemTime3;
        private Label lbItemRoom3;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label lbItemNameCourse4;
        private Label lbItemClass4;
        private Label lbItemTime4;
        private Label lbItemRoom4;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label lbItemNameCourse5;
        private Label lbItemClass5;
        private Label lbItemTime5;
        private Label lbItemRoom5;
        private FlowLayoutPanel flowLayoutPanel5;
        private Label lbItemNameCourse6;
        private Label lbItemClass6;
        private Label lbItemTime6;
        private Label lbItemRoom6;
        private FlowLayoutPanel flowLayoutPanel6;
        private Label lbItemNameCourse7;
        private Label lbItemClass7;
        private Label lbItemTime7;
        private Label lbItemRoom7;
        private Guna2Button guna2Button1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label5;
        private Label label3;
        private Label label2;
    }
}