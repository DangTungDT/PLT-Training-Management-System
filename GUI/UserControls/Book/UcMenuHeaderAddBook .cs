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
    public partial class UcMenuHeaderAddBook : UserControl
    {
        public event Action _ActionAddBook;
        public event Action ActionBackForm;
        public UcMenuHeaderAddBook()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            _ActionAddBook?.Invoke();
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            ActionBackForm?.Invoke();
        }
    }
}
