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
    public partial class UcBook : UserControl
    {
        public UcBook()
        {
            InitializeComponent();
        }
        private static Image ResizeImage(Image img, int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(img, 0, 0, width, height);
            }
            return bmp;
        }
        private void UcBook_Load(object sender, EventArgs e)
        {

            LoadImageForColumnDataGirdViewBook();
            
            LoadVirtualDataToDataGridViewBook();
        }
        private void LoadImageForColumnDataGirdViewBook()
        {
            colEdit.Image = ResizeImage(Properties.Resources.edit, 24, 24);
            colDelete.Image = ResizeImage(Properties.Resources.delete, 24, 24);
            colView.Image = ResizeImage(Properties.Resources.view, 24, 24);
        }

        private void LoadVirtualDataToDataGridViewBook()
        {
            dgvBooks.Rows.Clear();
            dgvBooks.Rows.Add(
                "Cơ sở dữ liệu Oracle\n978-604-0-12347-8",
                "TS. Lê Văn Cường\nNXB Thông tin và Truyền thông",
                "Cơ sở dữ liệu",
                "2022",
                "Đại học",
                null, null, null
            );

            dgvBooks.Rows.Add(
                "Kiểm thử phần mềm cơ bản\n978-604-0-12345-6",
                "TS. Nguyễn Văn An\nNXB Giáo dục",
                "Kiểm thử phần mềm",
                "2023",
                "Cao đẳng",
                null, null, null
            );

            dgvBooks.Rows.Add(
                "Lập trình Java nâng cao\n978-604-0-12346-7",
                "PGS.TS. Trần Thị Bình\nNXB Đại học Quốc gia",
                "Lập trình",
                "2023",
                "Cao đẳng",
                null, null, null
            );
        }
    }
}
