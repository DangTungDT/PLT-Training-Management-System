using System;
using BLL;
using DTO;
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
        private BookBLL _bookBLL = new BookBLL();
        private IEnumerable<BookDTO> _books;
        private int _pageIndex = 1;
        private int _pageSize = 10;

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
        private bool LoadDataForDataGridViewBook()
        {
            if(_pageIndex < 1) return false;
            try
            {
                dgvBooks.Rows.Clear();
                _books = _bookBLL.GetBookforPage(_pageIndex, _pageSize);
                foreach (var book in _books)
                {
                    dgvBooks.Rows.Add(
                        $"{book.Name}\n{book.ISBN}",
                        $"{book.Author}",
                        book.Category != null ? book.Category.Name : "",
                        book.PublishedYear,
                        book.DifficultyLevel,
                        null, null, null
                    );
                }
                lbPageIndex.Text = _pageIndex.ToString();
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void UcBook_Load(object sender, EventArgs e)
        {

            LoadImageForColumnDataGirdViewBook();

            if (LoadDataForDataGridViewBook())
            {

            }
        }
        private void LoadImageForColumnDataGirdViewBook()
        {
            colEdit.Image = ResizeImage(Properties.Resources.edit, 24, 24);
            colDelete.Image = ResizeImage(Properties.Resources.delete, 24, 24);
            colView.Image = ResizeImage(Properties.Resources.view, 24, 24);
        }

        private void btnPageAfter_Click(object sender, EventArgs e)
        {
            _pageIndex++;
            if (LoadDataForDataGridViewBook())
            {
            }
        }

        private void btnPageBefore_Click(object sender, EventArgs e)
        {
            if(_pageIndex > 0) _pageIndex--;
            if (LoadDataForDataGridViewBook())
            {
            }
        }
    }
}
