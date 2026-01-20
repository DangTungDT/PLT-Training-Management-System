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
    public partial class UcSchedule : UserControl
    {
        List<Label> _labelsNameCourse;
        List<Label> _labelsClass;
        List<Label> _labelsTime;
        List<Label> _labelsRoom;

        public UcSchedule()
        {
            InitializeComponent();
        }

        private void AddControlToListLabel()
        {
            try
            {
                _labelsNameCourse = new List<Label>()
                {
                    lbItemNameCourse2,
                    lbItemNameCourse3, lbItemNameCourse4,
                    lbItemNameCourse5, lbItemNameCourse6,
                    lbItemNameCourse7, lbItemNameCourse8
                };
                _labelsClass = new List<Label>()
                {
                    lbItemClass2,
                    lbItemClass3, lbItemClass4,
                    lbItemClass5, lbItemClass6,
                    lbItemClass7, lbItemClass8
                };
                _labelsTime = new List<Label>()
                {
                    lbItemTime2,
                    lbItemTime3, lbItemTime4,
                    lbItemTime5, lbItemTime6,
                    lbItemTime7, lbItemTime8
                };
                _labelsRoom = new List<Label>()
                {
                    lbItemRoom2,
                    lbItemRoom3, lbItemRoom4,
                    lbItemRoom5, lbItemRoom6,
                    lbItemRoom7, lbItemRoom8
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void UcSchedule_Load(object sender, EventArgs e)
        {
            AddControlToListLabel();
        }
    }
}
