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
        private int _totalBooks = 0;
        public event Action<string> OpenUserControlEditBook;
        public event Action<string> OpenUserControlReadBook;
        public UcBook()
        {
            InitializeComponent();
        }
        private void UcBook_Load(object sender, EventArgs e)
        {
            CustomFormatDateTimePickerFindDateToEmpty();
            GetAllDifficultyLevelOfBookForTheCombobox();

            LoadImageForColumnDataGirdViewBook();

            if (LoadDataForDataGridViewBook()) { }
            UpdateTotalBooks();

            if (_pageIndex == 1)
            {
                btnPageBefore.Visible = false;
            }

            if (_books.Count() < 10)
            {
                btnPageBefore.Visible = false;
                btnPageAfter.Visible = false;
            }
            else
            {
                btnPageAfter.Visible = true;
            }
        }


        private void cbFindLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataGridViewBook();
        }
        private void GetAllDifficultyLevelOfBookForTheCombobox()
        {
            List<string> DifficultyLevels = _bookBLL.GetAllTheLevelNameOfTheBooks();
            DifficultyLevels.Add("Tất cả");
            cbFindLevel.DataSource = DifficultyLevels;
            cbFindLevel.SelectedItem = "Tất cả";
        }
        private void UpdateTotalBooks()
        {
            if (dtpFindDate.CustomFormat == " ")
            {
                _totalBooks = _bookBLL.GetQuantityOfAllBooks(null, cbFindLevel.SelectedItem?.ToString());
            }
            else
            {
                _totalBooks = _bookBLL.GetQuantityOfAllBooks(dtpFindDate.Value, cbFindLevel.SelectedItem?.ToString());
            }
            lbTotalItem.Text = _totalBooks.ToString();

            int positionBookStart = (_pageIndex - 1) * _pageSize + 1;
            int positionBookEnd = dgvBooks.RowCount;
            if (positionBookEnd == 0)
            {
                positionBookStart = 0;
            }
            else
            {
                positionBookEnd = (_pageIndex - 1) * _pageSize + positionBookEnd;
            }
            lbDisplayDisplayBookAtPage.Text = positionBookStart.ToString() + "-" + positionBookEnd.ToString() + " trong tổng số " + _totalBooks.ToString() + " kết quả";
        }
        private bool LoadDataForDataGridViewBook()
        {
            if (_pageIndex < 1) return false;
            try
            {
                if (dtpFindDate.CustomFormat == " ")
                {
                    _books = _bookBLL.GetBookforPage(null, cbFindLevel.SelectedItem?.ToString(), _pageIndex, _pageSize);
                }
                else
                {
                    _books = _bookBLL.GetBookforPage(dtpFindDate.Value, cbFindLevel.SelectedItem?.ToString(), _pageIndex, _pageSize);
                }
                if (_books.Count() == 0)
                {
                    dgvBooks.Rows.Clear();
                    return false;
                }
                dgvBooks.Rows.Clear();
                foreach (var book in _books)
                {
                    dgvBooks.Rows.Add(
                        $"{book.Name}",
                        $"{book.Author}",
                        book.Category != null ? book.Category.Name : "",
                        book.PublishedYear,
                        book.DifficultyLevel,
                        null, null, null
                    );
                }
                lbPageIndex.Text = _pageIndex.ToString();

                if (_books.Count() < 10)
                {
                    btnPageBefore.Visible = false;
                    btnPageAfter.Visible = false;
                }
                else
                {
                    btnPageAfter.Visible = true;
                }

                return true;
            }
            catch
            {
                return false;
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
            if (_pageIndex != 1 && _books.Count() == 0) return;
            _pageIndex++;
            if (!LoadDataForDataGridViewBook())
            {
                // List Book have no data
                _pageIndex--;
                if (btnPageAfter.Visible == true)
                {
                    btnPageAfter.Visible = false;
                }
            }

            int maximumNumberOfPages = (_totalBooks + _pageSize - 1) / _pageSize;
            if (_pageIndex >= maximumNumberOfPages)
            {
                btnPageAfter.Visible = false;
            }

            if (btnPageBefore.Visible == false)
            {
                btnPageBefore.Visible = true;
            }
            UpdateTotalBooks();
        }

        private void btnPageBefore_Click(object sender, EventArgs e)
        {
            if (_pageIndex == 1) return;
            if (_pageIndex > 1) _pageIndex--;
            if (LoadDataForDataGridViewBook())
            {
            }
            UpdateTotalBooks();

            if (_pageIndex == 1)
            {
                btnPageBefore.Visible = false;
            }
            if (btnPageAfter.Visible == false)
            {
                btnPageAfter.Visible = true;
            }
        }

        private void CustomFormatDateTimePickerFindDateToEmpty()
        {
            dtpFindDate.Format = DateTimePickerFormat.Custom;
            dtpFindDate.CustomFormat = " ";
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

        private void dtpFindDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFindDate.CustomFormat != "dd/MM/yyyy")
            {
                dtpFindDate.CustomFormat = "dd/MM/yyyy";
            }
            LoadDataGridViewBook();

        }

        private void LoadDataGridViewBook()
        {
            _pageIndex = 1;
            if (LoadDataForDataGridViewBook()) { }
            UpdateTotalBooks();
        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;
            string booknameSeleteced = dgvBooks.Rows[rowIndex].Cells[0].Value.ToString();
            string nameOfColumn = dgvBooks.Columns[columnIndex].Name;
            DataGridViewRow row = dgvBooks.Rows[e.RowIndex];
            if (nameOfColumn == "colEdit")
            {
                OpenUserControlEditBook?.Invoke(booknameSeleteced);
            }
            else if (nameOfColumn == "colDelete")
            {
                var result = MessageBox.Show($"Bạn có chắc chắn muốn xóa sách '{booknameSeleteced}'?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    bool isDeleted = _bookBLL.DeleteAllRelationsOfBookByBookName(booknameSeleteced);
                    if (isDeleted)
                    {
                        MessageBox.Show($"Xóa sách '{booknameSeleteced}' thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataGridViewBook();
                    }
                    else
                    {
                        MessageBox.Show($"Xóa sách '{booknameSeleteced}' thất bại.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (nameOfColumn == "colView")
            {
                OpenUserControlReadBook?.Invoke(booknameSeleteced);
            }
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
