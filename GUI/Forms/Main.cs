using BLL;
using DTO;
using GUI.UserControls;
using GUI.UserControls.Book;
using Guna.UI2.WinForms;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class Main : Form
    {
        //Variable lobal
        private List<Guna2Button> _menuBuottons;

        private UcMenuHeaderAddBook _ucMenuHeaderAddBook;
        private UcAddBook _ucAddBook;

        private UcMenuHeaderEditBook _ucMenuHeaderEditBook;
        private UcEditBook _ucEditBook;

        private UcMenuHeaderReadBook _ucMenuHeaderReadBook;
        private UcReadBook _ucReadBook;

        private UcBook _ucBook;
        private BookBLL _bookBLL = new BookBLL();
        private BookFileBLL _bookFileBLL = new BookFileBLL();
        private FileBLL _fileBLL = new FileBLL();
        public Main()
        {
            InitializeComponent();
        }
        private void LoadContentAddBook(UserControl uc)
        {

            _ucAddBook = uc as UcAddBook;
            if (_ucAddBook == null) return;
            pbContent.Controls.Clear();
            _ucAddBook.Dock = DockStyle.Fill;
            pbContent.Controls.Add(_ucAddBook);

            pbHeaderContent.Controls.Clear();
            _ucMenuHeaderAddBook = new UcMenuHeaderAddBook();
            _ucMenuHeaderAddBook.Dock = DockStyle.Fill;
            pbHeaderContent.Controls.Add(_ucMenuHeaderAddBook);

            _ucMenuHeaderAddBook._ActionAddBook += AddBook;
        }

        private void BackFormBook()
        {
            _ucBook = new UcBook();
            _ucBook.OpenUserControlEditBook += (string nameBook) =>
            {
                _ucEditBook = new UcEditBook(nameBook);
                LoadUcEditBook(_ucEditBook);
            };
            _ucBook.OpenUserControlReadBook += (string nameBook) =>
            {
                _ucReadBook = new UcReadBook(nameBook);
                LoadUcReadBook(_ucReadBook);
            };
            LoadUserControlForPanel(_ucBook, pbContent);

            var header = new UcMenuHeaderBook();
            header.OpenContentRequested += LoadContentAddBook;
            LoadUserControlForPanel(header, pbHeaderContent);
        }
        private void EditBook()
        {

            BookDTO data = _ucEditBook.GetNewBook();
            if (data == null)
            {
                DialogResult kq = MessageBox.Show("Thông tin chưa được thay đổi bạn vẫn muốn cập nhật?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(kq == DialogResult.Yes)
                {
                    _ucBook = new UcBook();
                    _ucBook.OpenUserControlEditBook += (string nameBook) =>
                    {
                        _ucEditBook = new UcEditBook(nameBook);
                        LoadUcEditBook(_ucEditBook);
                    };
                    LoadUserControlForPanel(_ucBook, pbContent);

                    var header = new UcMenuHeaderBook();
                    header.OpenContentRequested += LoadContentAddBook;
                    LoadUserControlForPanel(header, pbHeaderContent);
                    return;
                }
            }

            if (_bookBLL.UpdateBook(data))
            {
                List<FilesDTO> newFilesOfBook = _ucEditBook.GetNewFileOfBook();
                if(newFilesOfBook.Count > 0)
                {
                    foreach(FilesDTO newFile in newFilesOfBook)
                    {
                        if(_fileBLL.UpdateFile(newFile))
                        {
                            int bookId = data.Id;
                            BookFileDTO bookFile = new BookFileDTO()
                            {
                                BookId = bookId,
                                FileId = newFile.Id
                            };
                            _bookFileBLL.AddNewBookFile(bookFile);
                        }
                    }
                }
                MessageBox.Show("Cập nhật thành công!");
                
                //Reload lại danh sách sách
                _ucBook = new UcBook();
                _ucBook.OpenUserControlEditBook += (string nameBook) =>
                {
                    _ucEditBook = new UcEditBook(nameBook);
                    LoadUcEditBook(_ucEditBook);
                };
                LoadUserControlForPanel(_ucBook, pbContent);

                var header = new UcMenuHeaderBook();
                header.OpenContentRequested += LoadContentAddBook;
                LoadUserControlForPanel(header, pbHeaderContent);
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }

        }
        private void AddBook()
        {
            BookDTO data = _ucAddBook.GetNewBook();
            if(data == null)
            {
                return;
            }
            if (string.IsNullOrEmpty(data.ISBN) || string.IsNullOrEmpty(data.Name) || string.IsNullOrEmpty(data.Author) || data.CategoryId < 1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần thiết!");
                return;
            }

            if (_bookBLL.AddNewBook(data))
            {
                int quanlityFilesOfBook = _ucAddBook.GetCountFileBook();

                if (quanlityFilesOfBook > 0)
                {
                    if (!_ucAddBook.AddBookFile())
                    {
                        MessageBox.Show("Thêm file sách thất bại!");
                    }
                }
                MessageBox.Show("Thêm sách mới thành công!");
                
                _ucBook = new UcBook();
                _ucBook.OpenUserControlEditBook += (string nameBook) =>
                {
                    _ucEditBook = new UcEditBook(nameBook);
                    LoadUcEditBook(_ucEditBook);
                };
                LoadUserControlForPanel(_ucBook, pbContent);

                var header = new UcMenuHeaderBook();
                header.OpenContentRequested += LoadContentAddBook;
                LoadUserControlForPanel(header, pbHeaderContent);
            }
            else
            {
                MessageBox.Show("Thêm sách mới thất bại!");
            }

        }
        private void LoadBackGroundControlButtonMenu(Guna2Button buttonSelected)
        {
            if (_menuBuottons.Count > 0)
            {
                foreach (Guna2Button button in _menuBuottons)
                {
                    if (button == buttonSelected)
                    {
                        button.FillColor = Color.Cyan;
                    }
                    else
                    {
                        button.FillColor = Color.White;
                    }
                }
            }
        }
        private Image ResizeImage(Image img, int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                g.DrawImage(img, 0, 0, width, height);
            }
            return bmp;
        }

        private void LoadUserControlForPanel(UserControl userControlIsLoaded, Panel pnaelToLoadUserControl)
        {
            pnaelToLoadUserControl.Controls.Clear();
            userControlIsLoaded.Dock = DockStyle.Fill;
            pnaelToLoadUserControl.Controls.Add(userControlIsLoaded);
        }
        private void LoadResizeImageControl()
        {
            lbHeaderRole.Image = ResizeImage(Properties.Resources.login, 24, 24);

        }
        private void Main_Load(object sender, EventArgs e)
        {
            _menuBuottons = pnMenuContent.Controls.OfType<Guna2Button>().ToList();

            LoadResizeImageControl();
            OpenUcEditBook();
        }

        private void btnMenuHome_Click(object sender, EventArgs e)
        {
            LoadBackGroundControlButtonMenu(btnMenuHome);
        }

        private void btnMenuManagementAccount_Click(object sender, EventArgs e)
        {
            LoadBackGroundControlButtonMenu(btnMenuManagementAccount);
        }

        private void btnMenuBook_Click(object sender, EventArgs e)
        {
            LoadBackGroundControlButtonMenu(btnMenuBook);

            _ucBook = new UcBook();
            _ucBook.OpenUserControlEditBook += (string nameBook) =>
            {
                    _ucEditBook = new UcEditBook(nameBook);
                LoadUcEditBook(_ucEditBook);
            };
            _ucBook.OpenUserControlReadBook += (string nameBook) =>
            {
                _ucReadBook = new UcReadBook(nameBook);
                LoadUcReadBook(_ucReadBook);
            };
            LoadUserControlForPanel(_ucBook, pbContent);

            var header = new UcMenuHeaderBook();
            header.OpenContentRequested += LoadContentAddBook;
            LoadUserControlForPanel(header, pbHeaderContent);


        }

        private void OpenUcEditBook()
        {
            var ucEditBook = new UcBook();

            ucEditBook.OpenUserControlEditBook += (string nameBook) =>
            {
                _ucEditBook = new UcEditBook(nameBook);
                LoadUcEditBook(_ucEditBook);
            };
        }

        private void LoadUcEditBook(UserControl uc)
        {
            pbContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pbContent.Controls.Add(uc);
            pbHeaderContent.Controls.Clear();
            var header = new UcMenuHeaderEditBook();
            header.ActionEditBook += EditBook;
            header.Dock = DockStyle.Fill;
            pbHeaderContent.Controls.Add(header);

        }

        private void LoadUcReadBook(UserControl uc)
        {
            _ucReadBook = uc as UcReadBook;
            if (_ucReadBook == null) return;
            pbContent.Controls.Clear();
            _ucReadBook.Dock = DockStyle.Fill;
            pbContent.Controls.Add(_ucReadBook);

            pbHeaderContent.Controls.Clear();
            _ucMenuHeaderReadBook = new UcMenuHeaderReadBook();
            _ucMenuHeaderReadBook.Dock = DockStyle.Fill;
            pbHeaderContent.Controls.Add(_ucMenuHeaderReadBook);

            _ucMenuHeaderReadBook.ActionBackForm += BackFormBook;
            _ucReadBook.OpenUserControlEditBook += GoToEditBook;

        }
        private void GoToEditBook(string nameBook)
        {
            _ucEditBook = new UcEditBook(nameBook);
            LoadUcEditBook(_ucEditBook);
        }
        private void btnMenuLessonPlan_Click(object sender, EventArgs e)
        {
            LoadBackGroundControlButtonMenu(btnMenuLessonPlan);
        }

        private void btnMenuCalendar_Click(object sender, EventArgs e)
        {
            LoadBackGroundControlButtonMenu(btnMenuCalendar);
        }

        private void btnMenuScore_Click(object sender, EventArgs e)
        {
            LoadBackGroundControlButtonMenu(btnMenuScore);
        }

        private void btnMenuResearchTopic_Click(object sender, EventArgs e)
        {
            LoadBackGroundControlButtonMenu(btnMenuResearchTopic);
        }

        private void btnMenuExam_Click(object sender, EventArgs e)
        {
            LoadBackGroundControlButtonMenu(btnMenuExam);
        }

        private void btnMenuExercise_Click(object sender, EventArgs e)
        {
            LoadBackGroundControlButtonMenu(btnMenuExercise);
        }
    }
}
