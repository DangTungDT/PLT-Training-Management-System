using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UserControls.Book
{
    public partial class UcAddBook : UserControl
    {
        public UcAddBook()
        {
            InitializeComponent();
        }

        private void lbInputValueBook_Click(object sender, EventArgs e)
        {
            LoadUserControlForPanel(new UcInputValueBook(), pbContentInput);
        }

        private void UcAddBook_Load(object sender, EventArgs e)
        {
            LoadUserControlForPanel(new UcInputValueBook(), pbContentInput);
        }

        private void LoadUserControlForPanel(UserControl userControlIsLoaded, Panel pnaelToLoadUserControl)
        {
            pnaelToLoadUserControl.Controls.Clear();
            userControlIsLoaded.Dock = DockStyle.Fill;
            pnaelToLoadUserControl.Controls.Add(userControlIsLoaded);
        }

        private void lbInputFileBook_Click(object sender, EventArgs e)
        {
            LoadUserControlForPanel(new UcInputFileBook(), pbContentInput);
        }
    }
}
