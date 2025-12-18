using Guna.UI2.WinForms;
using System.Drawing.Drawing2D;

namespace GUI
{
    public partial class Main : Form
    {
        //Variable lobal
        List<Guna2Button> _menuBuottons;

        public Main()
        {
            InitializeComponent();
        }

        private void LoadBackGroundControlButtonMenu(Guna2Button buttonSelected)
        {
            if (_menuBuottons.Count > 0)
            {
                foreach (Guna2Button button in _menuBuottons)
                {
                    if (button == buttonSelected)
                    {
                        button.FillColor = Color.Cyan;
                    }
                    else
                    {
                        button.FillColor = Color.White;
                    }
                }
            }
        }
        private Image ResizeImage(Image img, int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                g.DrawImage(img, 0, 0, width, height);
            }
            return bmp;
        }

        private void LoadUserControlForPanel(UserControl userControlIsLoaded, Panel pnaelToLoadUserControl)
        {
            pnaelToLoadUserControl.Controls.Clear();
            userControlIsLoaded.Dock = DockStyle.Fill;
            pnaelToLoadUserControl.Controls.Add(userControlIsLoaded);
        }
        private void LoadResizeImageControl()
        {
            lbHeaderRole.Image = ResizeImage(Properties.Resources.login, 24, 24);

        }
        private void Main_Load(object sender, EventArgs e)
        {
            _menuBuottons = pnMenuContent.Controls.OfType<Guna2Button>().ToList();

            LoadResizeImageControl();
        }

        private void btnMenuHome_Click(object sender, EventArgs e)
        {
            LoadBackGroundControlButtonMenu(btnMenuHome);
        }

        private void btnMenuManagementAccount_Click(object sender, EventArgs e)
        {
            LoadBackGroundControlButtonMenu(btnMenuManagementAccount);
        }

        private void btnMenuBook_Click(object sender, EventArgs e)
        {
            LoadBackGroundControlButtonMenu(btnMenuBook);
            LoadUserControlForPanel(new UserControls.UcBook(), pbContent);
            LoadUserControlForPanel(new UserControls.UcMenuHeaderBook(), pbHeaderContent);

        }

        private void btnMenuLessonPlan_Click(object sender, EventArgs e)
        {
            LoadBackGroundControlButtonMenu(btnMenuLessonPlan);
        }

        private void btnMenuCalendar_Click(object sender, EventArgs e)
        {
            LoadBackGroundControlButtonMenu(btnMenuCalendar);
        }

        private void btnMenuScore_Click(object sender, EventArgs e)
        {
            LoadBackGroundControlButtonMenu(btnMenuScore);
        }

        private void btnMenuResearchTopic_Click(object sender, EventArgs e)
        {
            LoadBackGroundControlButtonMenu(btnMenuResearchTopic);
        }

        private void btnMenuExam_Click(object sender, EventArgs e)
        {
            LoadBackGroundControlButtonMenu(btnMenuExam);
        }

        private void btnMenuExercise_Click(object sender, EventArgs e)
        {
            LoadBackGroundControlButtonMenu(btnMenuExercise);
        }
    }
}
