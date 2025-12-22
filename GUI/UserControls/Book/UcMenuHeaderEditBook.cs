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
    public partial class UcMenuHeaderEditBook : UserControl
    {
        public event Action ActionEditBook;
        public event Action ActionBackForm;
        public UcMenuHeaderEditBook()
        {
            InitializeComponent();
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            ActionEditBook?.Invoke();
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            ActionBackForm?.Invoke();
        }
    }
}
