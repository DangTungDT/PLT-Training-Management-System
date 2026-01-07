using BLL;
using DTO;
using GUI.Helpers;
using GUI.UserControls;
using GUI.UserControls.Book;
using GUI.UserControls.Exam;
using GUI.UserControls.Question;
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

        private UcReadFile _ucReadFile;
        private ucFileOfBook _ucFileOfBook;

        private UcMenuHeaderBook _ucMenuHeaderBook;
        private UcBook _ucBook;

        private UcExam _ucExam;

        private UcAddExam _ucAddExam;
        private UcReadExam _ucReadExam;
        private UcEditExam _ucEditExam;


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
            _ucMenuHeaderAddBook.ActionBackForm += NavigatePop;
        }
        private void LoadUcExam()
        {
            _ucExam = new UcExam();
            LoadUserControlForPanel(_ucExam, pbContent);

            _ucExam.OpenAddExam += () =>
            {
                var ucAddExam = new UcAddExam();
                NavigatePush(ucAddExam);
            };

            _ucExam.OpenUserControlEditExam += (int examId) =>
            {
                _ucEditExam = new UcEditExam(examId);
                NavigatePush(_ucEditExam);
            };
            _ucExam.OpenUserControlReadExam += (int examId) =>
            {
                _ucReadExam = new UcReadExam(examId);
                NavigatePush(_ucReadExam);
            };
        }

        private void LoadUcReadExam(UserControl uc)
        {
            _ucReadExam = uc as UcReadExam;
            if (_ucReadExam == null) return;

            pbContent.Controls.Clear();
            _ucReadExam.Dock = DockStyle.Fill;
            pbContent.Controls.Add(_ucReadExam);
            pbHeaderContent.Controls.Clear();

            // Wire up events
            _ucReadExam.BackToExamList += () =>
            {
                NavigatePop();
            };

            _ucReadExam.OpenUserControlEditExam += (int examId) =>
            {
                _ucEditExam = new UcEditExam(examId);
                NavigatePush(_ucEditExam);
            };
            _ucReadExam.OpenUserControlReadFile += GoToReadFile;
        }
        private void LoadUcAddExam()
        {
            _ucAddExam = new UcAddExam();
            LoadUserControlForPanel(_ucAddExam, pbContent);
            _ucAddExam.BackToUcExam += () =>
            {
                NavigatePop();
            };

        }
        private void LoadUcEditExam(UserControl uc)
        {
            _ucEditExam = uc as UcEditExam;
            if (_ucEditExam == null) return;

            pbContent.Controls.Clear();
            _ucEditExam.Dock = DockStyle.Fill;
            pbContent.Controls.Add(_ucEditExam);
            pbHeaderContent.Controls.Clear();

            // Wire up event để quay lại
            _ucEditExam.BackToUcExam += () =>
            {
                NavigatePop();
            };
        }
        //private void LoadUcEditExam(UserControl uc)
        //{
        //    pbContent.Controls.Clear();
        //    uc.Dock = DockStyle.Fill;
        //    pbContent.Controls.Add(uc);
        //    pbHeaderContent.Controls.Clear();

        //}
        private void LoadUcBook()
        {
            _ucBook = new UcBook();
            _ucBook.OpenUserControlEditBook += (string nameBook) =>
            {
                _ucEditBook = new UcEditBook(nameBook);
                NavigatePush(_ucEditBook);
            };
            _ucBook.OpenUserControlReadBook += (string nameBook) =>
            {
                _ucReadBook = new UcReadBook(nameBook);
                NavigatePush(_ucReadBook);
            };
            LoadUserControlForPanel(_ucBook, pbContent);

            _ucMenuHeaderBook = new UcMenuHeaderBook();
            _ucMenuHeaderBook.OpenContentRequested += NavigatePush;
            _ucMenuHeaderBook._findBookByNameOrAuthor += LoadFilter;
            LoadUserControlForPanel(_ucMenuHeaderBook, pbHeaderContent);
        }
        private void LoadFilter()
        {
            string valueFind = _ucMenuHeaderBook.GetStringFindBook();
            _ucBook.FindBookByNameAuthorDateLevel(valueFind);
        }
        private void EditBook()
        {

            BookDTO data = _ucEditBook.GetNewBook();
            if (data == null)
            {
                DialogResult kq = MessageBox.Show("Thông tin chưa được thay đổi bạn vẫn muốn cập nhật?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(kq == DialogResult.Yes)
                {
                    LoadUcBook();
                    return; 
                }
                else
                {
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

                //LoadUcBook();
                Navigate.Instance.Clear();
                NavigatePush(new UcBook());
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

            if(!_bookBLL.CheckISBNAlreadyExists(data.ISBN))
            {
                MessageBox.Show("Mã ISBN đã tồn tại, vui lòng nhập lại!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                //LoadUcBook();
                Navigate.Instance.Clear();
                NavigatePush(new UcBook());
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
            //OpenUcEditBook();
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
            Navigate.Instance.Clear();
            NavigatePush(new UcBook());

        }

        private void NavigatePush(UserControl uc)
        {
            Navigate.Instance.PushIfNotSame(uc);
            if(uc is UcEditExam)
            {
                LoadUcEditExam(uc);
            }
            else if (uc is UcReadExam)
            {
                LoadUcReadExam(uc);
            }
            else if(uc is UcAddExam)
            {
                LoadUcAddExam();
            }
            else if (uc is UcExam)
            {
                LoadUcExam();
            }
            else if (uc is UcBook)
            {
                LoadUcBook();
            }
            else if (uc is UcAddBook)
            {
                LoadContentAddBook(uc);
            }
            else if(uc is UcEditBook)
            {
                LoadUcEditBook(uc);
            }
            else if(uc is UcReadBook)
            {
                LoadUcReadBook(uc);
            }
            else if (uc is UcReadFile)
            {
                LoadUcReadFile(uc);
            }
        }

        //private void LoadUcAddExam()
        //{
        //    var ucAddExam = new UcAddExam();
        //    pbContent.Controls.Clear();
        //    ucAddExam.Dock = DockStyle.Fill;
        //    pbContent.Controls.Add(ucAddExam);
        //}
        private void NavigatePop()
        {
            var previous = Navigate.Instance.Pop();
            if (previous != null)
            {
                previous = Navigate.Instance.Peek();
                pbContent.Controls.Clear();
                if (previous is UcExam)
                {
                    LoadUcExam();
                    pbContent.Controls.Add(previous);
                }
                else if (previous is UcReadExam)
                {
                    LoadUcReadExam(previous);
                    pbContent.Controls.Add(previous);
                }
                else
                if (previous is UcAddExam)
                {
                    LoadUcAddExam();
                    pbContent.Controls.Add(previous);
                } else
                if (previous is UcBook)
                {
                    LoadUcBook();
                    pbContent.Controls.Add(previous);
                }
                else
                if (previous is UcAddBook)
                {
                    LoadContentAddBook(previous);
                    pbContent.Controls.Add(previous);
                }
                else if (previous is UcEditBook)
                {
                    LoadUcEditBook(previous);
                    pbContent.Controls.Add(previous);
                }
                else if (previous is UcReadBook)
                {
                    LoadUcReadBook(previous);
                    pbContent.Controls.Add(previous);
                }
                else if (previous is UcReadFile)
                {
                    LoadUcReadFile(previous);
                    pbContent.Controls.Add(previous);
                }

            }
            
        }

        private void LoadUcReadFile(UserControl uc)
        {
            _ucReadFile = uc as UcReadFile;
            if (_ucReadFile == null) return;
            pbContent.Controls.Clear();
            _ucReadFile.Dock = DockStyle.Fill;
            pbContent.Controls.Add(_ucReadFile);
            pbHeaderContent.Controls.Clear();
            var header = new UcMenuHeaderReadFile();
            header.ActionBackForm += NavigatePop;
            header.Dock = DockStyle.Fill;
            pbHeaderContent.Controls.Add(header);
        }
        private void LoadUcEditBook(UserControl uc)
        {
            pbContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pbContent.Controls.Add(uc);
            pbHeaderContent.Controls.Clear();
            var header = new UcMenuHeaderEditBook();
            header.ActionEditBook += EditBook;
            header.ActionBackForm += NavigatePop;
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

            _ucMenuHeaderReadBook.ActionBackForm += NavigatePop;
            _ucReadBook.OpenUserControlEditBook += GoToEditBook;
            _ucReadBook.OpenUserControlReadFile += GoToReadFile;
            

        }
        private void GoToReadFile(int fileID)
        {
            _ucReadFile = new UcReadFile(fileID);
            NavigatePush(_ucReadFile);
        }
        private void GoToEditBook(string nameBook)
        {
            _ucEditBook = new UcEditBook(nameBook);
            NavigatePush(_ucEditBook);
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
            Navigate.Instance.Clear();
            LoadBackGroundControlButtonMenu(btnMenuExam);
            NavigatePush(new UcExam());
        }

        private void btnMenuExercise_Click(object sender, EventArgs e)
        {
            LoadBackGroundControlButtonMenu(btnMenuExercise);
        }
    }
}
