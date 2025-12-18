using GUI.UserControls.Book;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UserControls
{
    public partial class UcMenuHeaderBook : UserControl
    {
        public event Action<UserControl> OpenContentRequested;
        public UcMenuHeaderBook()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            OpenContentRequested?.Invoke(new UcAddBook());
        }
    }
}
