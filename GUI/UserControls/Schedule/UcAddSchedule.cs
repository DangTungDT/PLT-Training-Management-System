using GUI.Forms;
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

namespace GUI.UserControls.Schedule
{
    public partial class UcAddSchedule : UserControl
    {
        private List<ClassTime> _scheduleTimes = new List<ClassTime>();
        public event Action BackToUcSchedule;
        public UcAddSchedule()
        {
            InitializeComponent();
        }

        private void btnOpenDayOfWeek_Click(object sender, EventArgs e)
        {
            using (FormAddDayOfWeek form = new FormAddDayOfWeek())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Lấy dữ liệu từ form con
                    _scheduleTimes = form.SelectedTimes;

                    // Đổ vào ComboBox
                    cbDayOfWeek.Items.Clear();

                    foreach (var t in _scheduleTimes)
                    {
                        cbDayOfWeek.Items.Add($"{t.StartTime:hh\\:mm} - {t.EndTime:hh\\:mm}");
                    }
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            BackToUcSchedule?.Invoke();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {


                BackToUcSchedule?.Invoke();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
