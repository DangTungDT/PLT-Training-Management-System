using System.Drawing.Drawing2D;

namespace GUI
{
    public partial class Main : Form
    {
        //Variable lobal
        List<Button> _menuBuottons;

        public Main()
        {
            InitializeComponent();
        }

        private void LoadBackGroundControlButtonMenu(Button buttonSelected)
        {
            if (_menuBuottons.Count > 0)
            {
                foreach (Button button in _menuBuottons)
                {
                    if (button == buttonSelected)
                    {
                        button.BackColor = Color.Cyan;
                    }
                    else
                    {
                        button.BackColor = Color.White;
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
            btnMenuHome.Image = ResizeImage(Properties.Resources.home, 24, 24);
            btnMenuManagementAccount.Image = ResizeImage(Properties.Resources.user, 24, 24);
            btnMenuBook.Image = ResizeImage(Properties.Resources.book, 24, 24);
            btnMenuLessonPlan.Image = ResizeImage(Properties.Resources.lessonPlan, 24, 24);
            btnMenuCalendar.Image = ResizeImage(Properties.Resources.calendar, 24, 24);
            btnMenuScore.Image = ResizeImage(Properties.Resources.score, 24, 24);
            btnMenuResearchTopic.Image = ResizeImage(Properties.Resources.idea, 24, 24);
            btnMenuExam.Image = ResizeImage(Properties.Resources.exam, 24, 24);
            btnMenuExercise.Image = ResizeImage(Properties.Resources.homework, 24, 24);
            lbHeaderRole.Image = ResizeImage(Properties.Resources.login, 24, 24);

        }
        private void Main_Load(object sender, EventArgs e)
        {
            _menuBuottons = pnMenu.Controls.OfType<Button>().ToList();

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
