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
    public partial class UcMenuHeaderReadFile : UserControl
    {
        public event Action ActionBackForm;
        public UcMenuHeaderReadFile()
        {
            InitializeComponent();
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            ActionBackForm?.Invoke();
        }
    }
}
