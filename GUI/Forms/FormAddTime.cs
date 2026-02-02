using GUI.Helpers;
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
    public partial class FormAddTime : Form
    {
        private char _session;
        private ClassTime _timeLesson = new ClassTime();
        public FormAddTime(char session)
        {
            InitializeComponent();
            _session = session;
        }
        private void cbStartTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateEndTimeConstraint();
        }

        private void FormAddTime_Load(object sender, EventArgs e)
        {
            LoadStartTimeAndEndTime();
        }

        private void LoadStartTimeAndEndTime()
        {
            cbStartTime.Items.Clear();

            TimeSpan start;
            TimeSpan end;
            TimeSpan step = TimeSpan.FromMinutes(45);

            if (_session == 'A') // Buổi chiều
            {
                start = new TimeSpan(12, 45, 0);   // 12:45
                end = new TimeSpan(18, 0, 0);    // 18:00 (không lấy mốc này)
            }
            else // Buổi sáng
            {
                start = new TimeSpan(7, 0, 0);     // 07:00
                end = new TimeSpan(12, 45, 0);   // 12:45 (không lấy mốc này)
            }

            for (TimeSpan time = start; time < end; time += step)
            {
                cbStartTime.Items.Add(time.ToString(@"hh\:mm"));
            }
        }

        private void UpdateEndTimeConstraint()
        {
            if (_timeLesson.StartTime == TimeSpan.Zero) return;

            cbEndTime.Items.Clear();

            TimeSpan step = TimeSpan.FromMinutes(45);
            TimeSpan endLimit = (_session == 'A')
                ? new TimeSpan(18, 0, 0)
                : new TimeSpan(12, 45, 0);

            for (TimeSpan t = _timeLesson.StartTime + step; t <= endLimit; t += step)
            {
                cbEndTime.Items.Add(new ClassTime
                {
                    StartTime = _timeLesson.StartTime,
                    EndTime = t
                });
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbStartTime.SelectedItem is ClassTime start &&
                cbEndTime.SelectedItem is ClassTime end)
            {
                GlobalClassTime.Instance.TimeLesson.StartTime = start.StartTime;
                GlobalClassTime.Instance.TimeLesson.EndTime = end.EndTime;
            }
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
