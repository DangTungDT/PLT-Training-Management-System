using BLL;
using DTO;
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
    public partial class UcReadBook : UserControl
    {
        private BookDTO _selectedBook;
        private List<int> _allFileIdOfBookSelected;
        private List<FilesDTO> _ListFileOfBookSelected;
        private BookBLL _bookBLL = new BookBLL();
        private CategoryBLL _categoryBLL = new CategoryBLL();
        private BookFileBLL _bookFileBLL = new BookFileBLL();
        private FileBLL _fileBLL = new FileBLL();
        private PersonBLL _personBLL = new PersonBLL();
        public event Action<string> OpenUserControlEditBook;
        public event Action<int> OpenUserControlReadFile;


        private bool flagLoadFile = false;

        public UcReadBook(string bookName)
        {
            InitializeComponent();
            if (!_bookBLL.PlusASummaryForTheBook(bookName))
            {
                MessageBox.Show("Tăng lượt xem thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            _selectedBook = _bookBLL.GetBookByName(bookName);
            _allFileIdOfBookSelected = _bookFileBLL.GetAllFileIdByIdBook(_selectedBook.Id);

        }

        private void UcReadBook_Load(object sender, EventArgs e)
        {
            LoadBookInformation();
        }

        private void LoadBookInformation()
        {
            lblTitle.Text = _selectedBook.Name;
            lbISBN.Text = _selectedBook.ISBN;
            lbAuthor.Text = _selectedBook.Author;
            lbPublicYear.Text = _selectedBook.PublishedYear.ToString();
            lbCategory.Text = _categoryBLL.GetCategoryById(_selectedBook.CategoryId).Name;
            lbDescribe.Text = _selectedBook.Description;
            lbDateUpLoad.Text = _selectedBook.DateUpload.Date.ToString();
            string namePersonUpload = _personBLL.GetPersonNameById(_selectedBook.PersonId);
            lbUpLoadBy.Text = namePersonUpload;
            lbTotalView.Text = _selectedBook.TotalRead.ToString();
            lbTotalView2.Text = _selectedBook.TotalRead.ToString();
            lbTotalDownload.Text = _selectedBook.TotalDownload.ToString();
            lbTotalDownload2.Text = _selectedBook.TotalDownload.ToString();

            lblTotalFiles.Text = _allFileIdOfBookSelected.Count.ToString();
        }

        private void lblOverview_Click(object sender, EventArgs e)
        {
            lblAttachmentTab.ForeColor = Color.Black;
            lblOverview.ForeColor = Color.FromArgb(60, 131, 246);

            pnDataBook.Visible = true;
            pnlRightFill.Visible = false;
        }

        private void lblAttachmentTab_Click(object sender, EventArgs e)
        {
            lblOverview.ForeColor = Color.Black;
            lblAttachmentTab.ForeColor = Color.FromArgb(60, 131, 246);

            pnDataBook.Visible = false;
            pnlRightFill.Visible = true;

            if (!flagLoadFile)
            {
                LoadFileOfBook();
                flagLoadFile = true;
            }
        }

        private void LoadFileOfBook()
        {
            flpFiles.Controls.Clear();
            _ListFileOfBookSelected = new List<FilesDTO>();

            int positionForm = 1;
            foreach (int fileId in _allFileIdOfBookSelected)
            {
                FilesDTO file = _fileBLL.GetFileById(fileId);
                if (file == null) continue;

                _ListFileOfBookSelected.Add(file);

                ucFileOfBook ucFile = new ucFileOfBook(file, positionForm);

                ucFile.Margin = new Padding(0, 0, 0, 8);
                ucFile.Dock = DockStyle.Top;

                ucFile.DeleteFile += UcFileOfBook_ButtonDelete;
                ucFile.ActionReadFile += ReadFileOfBook;
                flpFiles.Controls.Add(ucFile);

                positionForm++;
            }
        }

        private void ReadFileOfBook(int fileId)
        {
            OpenUserControlReadFile?.Invoke(fileId);
        }
        private void UcFileOfBook_ButtonDelete(int e, int position)
        {
            try
            {
                if (!_bookFileBLL.DeleteBookFile(_selectedBook.Id, e))
                {
                    MessageBox.Show("Xóa tệp của sách thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                flpFiles.Controls.RemoveAt(position - 1);
                lblTotalFiles.Text = (int.Parse(lblTotalFiles.Text) - 1).ToString();
            }
            catch
            {
                MessageBox.Show("Xóa tệp của sách thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            OpenUserControlEditBook?.Invoke(_selectedBook.Name);
        }
    }
}
