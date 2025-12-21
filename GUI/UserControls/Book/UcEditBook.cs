using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UserControls.Book
{
    public partial class UcEditBook : UserControl
    {
        private BookDTO _selectedBook;
        private List<int> _allFileIdOfBookSelected;
        private List<FilesDTO> _ListFileOfBookSelected;
        private List<FilesDTO> _allNewFileAddedBook = new List<FilesDTO>();
        private BookBLL _bookBLL = new BookBLL();
        private CategoryBLL _categoryBLL = new CategoryBLL();
        private BookFileBLL _bookFileBLL = new BookFileBLL();
        private FileBLL _fileBLL = new FileBLL();
        private bool _flag = false;
        public UcEditBook()
        {
            InitializeComponent();
        }
        public UcEditBook(string bookName)
        {
            InitializeComponent();
            _selectedBook = _bookBLL.GetBookByName(bookName);
            _allFileIdOfBookSelected = _bookFileBLL.GetAllFileIdByIdBook(_selectedBook.Id);
            if (_allFileIdOfBookSelected.Count > 0)
            {
                _ListFileOfBookSelected = new List<FilesDTO>();
                string nameFile = "";
                string capacityFile = "";
                foreach (var fileId in _allFileIdOfBookSelected)
                {
                    FilesDTO file = _fileBLL.GetFileById(fileId);
                    _ListFileOfBookSelected.Add(file);
                    capacityFile = ((double)file.FileSize / (1024 * 1024)).ToString("F2") + " MB";
                    dgvFileBook.Rows.Add(file.FileName, file.FilePath, capacityFile);
                }
            }
        }
        public List<FilesDTO> GetNewFileOfBook()
        {
            return _allNewFileAddedBook;
        }
        public BookDTO GetNewBook()
        {

            if (!ValidateControls())
            {
                return null;
            }
            BookDTO newBook = new BookDTO()
            {
                Id = _selectedBook.Id,
                ISBN = txtISBN.Text,
                Name = txtBookName.Text,
                Author = txtAuthor.Text,
                PublishedYear = int.Parse(txtPublicYearBook.Text),
                Description = txtDescription.Text,
                DifficultyLevel = cboLevel.SelectedItem.ToString(),
                CategoryId = (int)cbCategory.SelectedValue
            };
            if (
                txtISBN.Text == _selectedBook.ISBN &&
                txtBookName.Text == _selectedBook.Name &&
                txtAuthor.Text == _selectedBook.Author &&
                txtPublicYearBook.Text == _selectedBook.PublishedYear.ToString() &&
                (int?)cbCategory.SelectedValue == _selectedBook.CategoryId &&
                cboLevel.Text == _selectedBook.DifficultyLevel &&
                txtDescription.Text == _selectedBook.Description &&
                _allNewFileAddedBook.Count == 0
                )
            {
                return null;
            }
            return newBook;
        }
        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "PDF files (*.pdf)|*.pdf",
                Multiselect = false,
                Title = "Chọn file PDF"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                HandleSelectedFile(ofd.FileName);
            }
        }

        private void pnUploadFile_DragEnter(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.None;
                return;
            }

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (files.Length == 1 &&
                Path.GetExtension(files[0]).Equals(".pdf", StringComparison.OrdinalIgnoreCase))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void HandleSelectedFile(string filePath)
        {
            if (!Path.GetExtension(filePath)
                .Equals(".pdf", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("File không hợp lệ. Vui lòng chọn file PDF.",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            FileInfo file = new FileInfo(filePath);

            if (file.Length > 500 * 1024 * 1024)
            {
                MessageBox.Show("File vượt quá 500MB",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            string nameFile = file.Name;
            string capacityFile = (file.Length / (1024.0 * 1024.0)).ToString("F2") + " MB";

            var row = dgvFileBook.Rows
                    .Cast<DataGridViewRow>()
                    .FirstOrDefault(r =>
                        !r.IsNewRow &&
                        r.Cells["colName"].Value?.ToString() == nameFile
                    );
            if(row != null)
            {
                row.Cells["colName"].Value = nameFile;
                row.Cells["colFilePath"].Value = filePath;
                row.Cells["colSizeFile"].Value = capacityFile;
            }
            else
            {
                dgvFileBook.Rows.Add(nameFile, filePath, capacityFile);
            }
            FilesDTO newFile = new FilesDTO()
            {
                FileName = nameFile,
                FilePath = filePath,
                FileSize = (int)file.Length
            };
            _allNewFileAddedBook.Add(newFile);
        }
        private void pnUploadFile_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (files.Length == 0) return;

            string filePath = files[0];

            if (!Path.GetExtension(filePath)
                .Equals(".pdf", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Chỉ cho phép tải lên file PDF",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            HandleSelectedFile(filePath);
        }
        private bool ValidateControls()
        {
            // Kiểm tra các TextBox bắt buộc không được để trống
            if (string.IsNullOrWhiteSpace(txtISBN.Text))
            {
                MessageBox.Show("Vui lòng nhập mã ISBN.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtISBN.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtBookName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBookName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAuthor.Text))
            {
                MessageBox.Show("Vui lòng nhập tên tác giả.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAuthor.Focus();
                return false;
            }

            // Kiểm tra giá trị của ComboBox cbCategory
            if (cbCategory.SelectedValue == null || string.IsNullOrEmpty(cbCategory.SelectedValue.ToString()) || (int)cbCategory.SelectedValue < 1)
            {
                MessageBox.Show("Vui lòng chọn danh mục hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbCategory.Focus();
                return false;
            }

            // Kiểm tra trường txtPublicYearBook
            if (!int.TryParse(txtPublicYearBook.Text, out int publishedYear))
            {
                MessageBox.Show("Năm xuất bản phải là số nguyên hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPublicYearBook.Focus();
                return false;
            }

            int currentYear = DateTime.Now.Year;
            if (publishedYear < 1 || publishedYear > currentYear)
            {
                MessageBox.Show($"Năm xuất bản phải lớn hơn 0 và nhỏ hơn hoặc bằng {currentYear}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPublicYearBook.Focus();
                return false;
            }

            // Tất cả các kiểm tra đều hợp lệ
            return true;
        }


        private void UcEditBook_Load(object sender, EventArgs e)
        {
            GetAllDifficultyLevelOfBookForTheCombobox();
            LoadCategoriesForCombobox();
            if (_selectedBook != null)
            {
                txtISBN.Text = _selectedBook.ISBN;
                txtBookName.Text = _selectedBook.Name;
                txtAuthor.Text = _selectedBook.Author;
                txtPublicYearBook.Text = _selectedBook.PublishedYear.ToString();
                cbCategory.SelectedValue = _selectedBook.CategoryId;
                cboLevel.SelectedText = _selectedBook.DifficultyLevel;
                txtDescription.Text = _selectedBook.Description;
            }

        }
        private void GetAllDifficultyLevelOfBookForTheCombobox()
        {
            List<string> DifficultyLevels = _bookBLL.GetAllTheLevelNameOfTheBooks();
            cboLevel.DataSource = DifficultyLevels;
        }
        private void LoadCategoriesForCombobox()
        {
            var categories = _categoryBLL.GetAllCategories();
            cbCategory.DataSource = categories;
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "Id";
        }

        private void lbInputValueBook_Click(object sender, EventArgs e)
        {
            lbInputFileBook.ForeColor = Color.FromArgb(104, 116, 135);
            lbInputValueBook.ForeColor = Color.FromArgb(60, 131, 246);

            pnInputValueBook.Visible = true;
            pnInputFileBook.Visible = false;
        }

        private void lbInputFileBook_Click(object sender, EventArgs e)
        {
            lbInputValueBook.ForeColor = Color.FromArgb(104, 116, 135);
            lbInputFileBook.ForeColor = Color.FromArgb(60, 131, 246);

            pnInputValueBook.Visible = false;
            pnInputFileBook.Visible = true;
        }
        private void txtAuthor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar)
        && !char.IsWhiteSpace(e.KeyChar)
        && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBookName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar)
        && !char.IsWhiteSpace(e.KeyChar)
        && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
