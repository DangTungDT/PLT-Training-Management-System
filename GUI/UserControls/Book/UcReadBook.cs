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
            LoadFileOfBook();
        }

        private void LoadBookInformation()
        {
            lblTitle.Text = _selectedBook.Name;
            lbISBN.Text = _selectedBook.ISBN;
            lbAuthor.Text = _selectedBook.Author;
            lbPublicYear.Text = _selectedBook.PublishedYear.ToString();
            lbDescribe.Text = _selectedBook.Description;
            lbDateUpLoad.Text = _selectedBook.DateUpload.Date.ToString();
            string namePersonUpload = _personBLL.GetPersonNameById(_selectedBook.PersonId);
            lbUpLoadBy.Text = namePersonUpload;
            lbTotalView.Text = _selectedBook.TotalRead.ToString();
            lbTotalDownload.Text = _selectedBook.TotalDownload.ToString();

            lblTotalFiles.Text = _allFileIdOfBookSelected.Count.ToString();
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

                // Tính toán kích thước dựa theo FlowLayoutPanel
                int targetWidth = flpFiles.ClientSize.Width - flpFiles.Padding.Left - flpFiles.Padding.Right;
                int targetHeight = (int)(targetWidth * 0.3f); // Tỷ lệ chiều cao, có thể điều chỉnh

                ucFile.Size = new Size(targetWidth, targetHeight);
                ucFile.Margin = new Padding(0, 0, 0, 8);
                ucFile.Dock = DockStyle.None; // Đổi từ Top sang None để có thể set Size
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
