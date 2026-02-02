using GUI.Helpers;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Forms
{
    public partial class FormAddDayOfWeek : Form
    {
        public List<ClassTime> SelectedTimes { get; private set; } = new List<ClassTime>();
        public FormAddDayOfWeek()
        {
            InitializeComponent();
        }

        public List<ClassTime> GetAllClassTimesFromLabels()
        {
            List<ClassTime> list = new List<ClassTime>();

            foreach (Control c in this.Controls)
            {
                GetLabelsRecursive(c, list);
            }

            return list;
        }
        private void GetLabelsRecursive(Control parent, List<ClassTime> list)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is Label lb && lb.Name.StartsWith("lb_Information_"))
                {
                    if (!string.IsNullOrWhiteSpace(lb.Text) && lb.Text.Contains("-"))
                    {
                        string[] parts = lb.Text.Split('-');

                        if (TimeSpan.TryParse(parts[0].Trim(), out TimeSpan start) &&
                            TimeSpan.TryParse(parts[1].Trim(), out TimeSpan end))
                        {
                            list.Add(new ClassTime
                            {
                                StartTime = start,
                                EndTime = end
                            });
                        }
                    }
                }

                if (c.HasChildren)
                    GetLabelsRecursive(c, list);
            }
        }

        private void OpenFormAddTime(char session, char dayOfWeek)
        {
            using (FormAddTime formAddTime = new FormAddTime(session))
            {
                if (formAddTime.ShowDialog() == DialogResult.OK)
                {
                    // Lấy thời gian đã chọn
                    var time = GlobalClassTime.Instance.TimeLesson;

                    string start = time.StartTime.ToString(@"hh\:mm");
                    string end = time.EndTime.ToString(@"hh\:mm");

                    // Tạo tên label theo quy tắc
                    string labelName = $"lb_Information_{dayOfWeek}_{session}";

                    // Tìm control trong Form hiện tại
                    var label = this.Controls.Find(labelName, true).FirstOrDefault() as Label;

                    if (label != null)
                    {
                        label.Text = $"{start} - {end}";
                    }
                }
            }
        }

        private void FormAddDayOfWeek_Load(object sender, EventArgs e)
        {
            AttachButtonEvents();
        }

        private void AttachButtonEvents()
        {
            try
            {
                btn_2_M.Click += ScheduleButton_Click;
                btn_2_A.Click += ScheduleButton_Click;

                btn_3_M.Click += ScheduleButton_Click;
                btn_3_A.Click += ScheduleButton_Click;

                btn_4_M.Click += ScheduleButton_Click;
                btn_4_A.Click += ScheduleButton_Click;

                btn_5_M.Click += ScheduleButton_Click;
                btn_5_A.Click += ScheduleButton_Click;

                btn_6_M.Click += ScheduleButton_Click;
                btn_6_A.Click += ScheduleButton_Click;

                btn_7_M.Click += ScheduleButton_Click;
                btn_7_A.Click += ScheduleButton_Click;

                btn_8_M.Click += ScheduleButton_Click;
                btn_8_A.Click += ScheduleButton_Click;
            }
            catch
            {

            }
        }


        private void ScheduleButton_Click(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;
            if (btn == null) return;

            // btn_2_M  → ["btn","2","M"]
            string[] parts = btn.Name.Split('_');
            if (parts.Length != 3) return;

            char dayOfWeek = parts[1][0]; // '2'
            char session = parts[2][0]; // 'M' hoặc 'A'

            OpenFormAddTime(session, dayOfWeek);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SelectedTimes = GetAllClassTimesFromLabels();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void RegisterScheduleButtons(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is Button btn)
                {
                    if (btn.Name.StartsWith("btn_"))
                    {
                        btn.Click -= ScheduleButton_Click;
                        btn.Click += ScheduleButton_Click;
                    }
                }

                // QUAN TRỌNG
                if (c.HasChildren)
                    RegisterScheduleButtons(c);
            }
        }


    }
}
