using BLL;
using DTO;
using GUI.Helpers;
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
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace GUI.UserControls.Book
{
    public partial class UcAddBook : UserControl
    {
        //Variable lobal
        private BookBLL _bookBLL = new BookBLL();
        private CategoryBLL _categoryBLL = new CategoryBLL();
        private FileBLL _fileBLL = new FileBLL();
        private BookFileBLL _bookFileBLL = new BookFileBLL();
        private int _accountId = 2;
        public UcAddBook()
        {
            InitializeComponent();
        }

        public UcAddBook(int accountId)
        {
            InitializeComponent();
            _accountId = accountId;
        }

        public List<string> GetFileNamesOfBook()
        {
            List<string> fileNames = new List<string>();
            foreach (DataGridViewRow row in dgvFileBook.Rows)
            {
                if (row.IsNewRow) continue;

                var value = row.Cells[0].Value?.ToString();
                if (!string.IsNullOrEmpty(value))
                    fileNames.Add(value);
            }
            return fileNames;

        }
        public int GetCountFileBook()
        {
            return dgvFileBook.Rows.Count;
        }
        public BookDTO GetNewBook()
        {

            try
            {
                if (!ValidateControls())
                {
                    return null;
                }
                return new BookDTO()
                {
                    ISBN = txtISBN.Text,
                    Name = txtBookName.Text,
                    Author = txtAuthor.Text,
                    PublishedYear = int.Parse(txtPublicYearBook.Text),
                    Description = txtDescription.Text,
                    DifficultyLevel = cboLevel.SelectedItem.ToString(),
                    CategoryId = (int)cbCategory.SelectedValue,
                    DateUpload = DateTime.Now,
                    PersonId = _accountId,
                    TotalRead = 0,
                    TotalDownload = 0
                };
            }
            catch
            {

                return null;
            }
        }
        private bool ContainsSpecialCharacter(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return false;

            return Regex.IsMatch(input, @"[^a-zA-Z0-9\sÀ-ỹ]");
        }
        private bool ValidateControls()
        {
            if (string.IsNullOrWhiteSpace(txtISBN.Text))
            {
                MessageBox.Show("Vui lòng nhập mã ISBN.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtISBN.Focus();
                return false;
            }
            if (ContainsSpecialCharacter(txtISBN.Text))
            {
                MessageBox.Show("Không được nhập ký tự đặc biệt trong ISBN.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtISBN.Focus();
                return false;
            }


            if (string.IsNullOrWhiteSpace(txtBookName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBookName.Focus();
                return false;
            }
            if (ContainsSpecialCharacter(txtBookName.Text))
            {
                MessageBox.Show("Không được nhập ký tự đặc biệt trong tên sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBookName.Focus();
                return false;
            }


            if (string.IsNullOrWhiteSpace(txtAuthor.Text))
            {
                MessageBox.Show("Vui lòng nhập tên tác giả.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAuthor.Focus();
                return false;
            }
            if (ContainsSpecialCharacter(txtAuthor.Text))
            {
                MessageBox.Show("Không được nhập ký tự đặc biệt trong tên tác giả.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAuthor.Focus();
                return false;
            }


            if (cboLevel.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn trình độ!.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            if (cbCategory.SelectedValue == null
                || !int.TryParse(cbCategory.SelectedValue.ToString(), out int categoryId)
                || categoryId < 1)
            {
                MessageBox.Show("Vui lòng chọn danh mục hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbCategory.Focus();
                return false;
            }


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

            return true;
        }

        private void LoadCategoriesForCombobox()
        {
            var categories = _categoryBLL.GetAllCategories();
            cbCategory.DataSource = categories;
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "Id";
        }
        private void UcAddBook_Load(object sender, EventArgs e)
        {
            LoadComboboxYear();
            LoadCategoriesForCombobox();
        }
        private void txtISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPublicYearBook_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
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

            // Kiểm tra LinkFolder đã được cấu hình chưa
            if (!LinkFolder.Instance.IsValidPath())
            {
                MessageBox.Show("Chưa cấu hình đường dẫn thư mục lưu trữ!",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            string nameFile = file.Name;
            string capacityFile = (file.Length / (1024.0 * 1024.0)).ToString("F2") + " MB";

            // Lưu trực tiếp vào LinkFolder (không tạo subfolder)
            string destFilePath = Path.Combine(LinkFolder.Instance.FolderPath, file.Name);

            dgvFileBook.Rows.Add(nameFile, destFilePath, capacityFile);
            SaveFileToProject(filePath);
        }

        private void SaveFileToProject(string filePath)
        {
            FileInfo file = new FileInfo(filePath);

            // Kiểm tra LinkFolder đã được cấu hình chưa
            if (!LinkFolder.Instance.IsValidPath())
            {
                MessageBox.Show("Chưa cấu hình đường dẫn thư mục lưu trữ!",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // Lưu trực tiếp vào thư mục LinkFolder
            string destFilePath = Path.Combine(LinkFolder.Instance.FolderPath, file.Name);

            try
            {
                if (System.IO.File.Exists(destFilePath))
                {
                    DialogResult result = MessageBox.Show(
                        $"File '{file.Name}' đã tồn tại. Bạn có muốn ghi đè không?",
                        "Xác nhận",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.No)
                    {
                        return;
                    }

                    System.IO.File.Delete(destFilePath);
                }

                System.IO.File.Copy(file.FullName, destFilePath);

                MessageBox.Show($"Lưu file thành công tại:\n{destFilePath}",
                                "Thành công",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (IOException ex)
            {
                MessageBox.Show(
                    "Không thể lưu file. Hãy chắc chắn file không đang được mở.\n\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Lỗi khi lưu file: {ex.Message}",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        //private void HandleSelectedFile(string filePath)
        //{
        //    if (!Path.GetExtension(filePath)
        //        .Equals(".pdf", StringComparison.OrdinalIgnoreCase))
        //    {
        //        MessageBox.Show("File không hợp lệ. Vui lòng chọn file PDF.",
        //                        "Lỗi",
        //                        MessageBoxButtons.OK,
        //                        MessageBoxIcon.Error);
        //        return;
        //    }

        //    FileInfo file = new FileInfo(filePath);

        //    if (file.Length > 500 * 1024 * 1024)
        //    {
        //        MessageBox.Show("File vượt quá 500MB",
        //                        "Lỗi",
        //                        MessageBoxButtons.OK,
        //                        MessageBoxIcon.Warning);
        //        return;
        //    }

        //    string nameFile = file.Name;
        //    string capacityFile = (file.Length / (1024.0 * 1024.0)).ToString("F2") + " MB";

        //    string guiRootPath = Path.GetFullPath(
        //        Path.Combine(Application.StartupPath, @"..\..\..\")
        //    );
        //    string filesFolderPath = Path.Combine(guiRootPath, "Files");
        //    string destFilePath = Path.Combine(filesFolderPath, file.Name);
        //    dgvFileBook.Rows.Add(nameFile, destFilePath, capacityFile);
        //    SaveFileToProject(filePath);
        //}


        //private void SaveFileToProject(string filePath)
        //{

        //    FileInfo file = new FileInfo(filePath);
        //    string guiRootPath = Path.GetFullPath(
        //        Path.Combine(Application.StartupPath, @"..\..\..\")
        //    );

        //    string filesFolderPath = Path.Combine(guiRootPath, "Files");

        //    if (!Directory.Exists(filesFolderPath))
        //    {
        //        Directory.CreateDirectory(filesFolderPath);
        //    }
        //    string destFilePath = Path.Combine(filesFolderPath, file.Name);

        //    try
        //    {
        //        if (System.IO.File.Exists(destFilePath))
        //            System.IO.File.Delete(destFilePath);

        //        System.IO.File.Copy(file.FullName, destFilePath);
        //    }
        //    catch (IOException ex)
        //    {
        //        MessageBox.Show(
        //            "Không thể ghi đè file. Hãy chắc chắn file không đang được mở.\n\n" + ex.Message,
        //            "Lỗi",
        //            MessageBoxButtons.OK,
        //            MessageBoxIcon.Error);
        //    }
        //}

        public bool AddBookFile()
        {
            foreach (DataGridViewRow row in dgvFileBook.Rows)
            {
                string fileName = row.Cells[0].Value?.ToString();
                string filePath = row.Cells[1].Value?.ToString();
                int fileSize = 0;
                var match = Regex.Match(row.Cells[2].Value?.ToString(), @"([\d\.]+)\s*MB");

                if (match.Success)
                {
                    double sizeTypeDouble = double.Parse(match.Groups[1].Value) * (1024.0 * 1024.0);
                    fileSize = Convert.ToInt32(sizeTypeDouble);
                }


                if (string.IsNullOrEmpty(fileName))
                {
                    continue;
                }
                string guiRootPath = Path.GetFullPath(
                                        Path.Combine(Application.StartupPath, @"..\..\..\")
                                        );
                string filesFolderPath = Path.Combine(guiRootPath, "Files");
                string destFilePath = Path.Combine(filesFolderPath, fileName);
                FilesDTO filePDF = new FilesDTO
                {
                    FileName = fileName,
                    FilePath = destFilePath,
                    FileType = "pdf",
                    FileSize = fileSize,
                    CreatedAt = DateTime.Now
                };
                if (!_fileBLL.AddNewFile(filePDF))
                {
                    return false;
                }
                BookFileDTO bookFileDTO = new BookFileDTO
                {
                    BookId = _bookBLL.GetIdbyBookName(txtBookName.Text),
                    FileId = filePDF.Id
                };
                if (bookFileDTO.BookId > 0 && _bookFileBLL.AddNewBookFile(bookFileDTO) == false) return false;
            }
            return true;
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

        private void txtPublicYearBook_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadComboboxYear()
        {
            cbYear.Items.Clear();

            int currentYear = DateTime.Now.Year;
            cbYear.Items.Add("");
            for (int y = currentYear; y >= 1990; y--)
            {
                cbYear.Items.Add(y.ToString());
            }
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbYear.SelectedIndex == 0) return;
            try
            {
                txtPublicYearBook.Text = cbYear.SelectedItem.ToString();
            }
            catch
            {
                txtPublicYearBook.Text = "";
            }
            finally
            {
                cbYear.SelectedIndex = 0;
            }
        }

        private void txtDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Control next = this.Controls
                    .Cast<Control>()
                    .FirstOrDefault(c => c.TabIndex == 1);

                if (next != null)
                    next.Focus();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
