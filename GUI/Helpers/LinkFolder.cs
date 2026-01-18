using GUI.Forms;
using System;
using System.IO;
using System.Windows.Forms;

namespace GUI.Helpers
{
    /// <summary>
    /// Class Singleton quản lý đường dẫn folder toàn cục
    /// </summary>
    public class LinkFolder
    {
        private static LinkFolder _instance;
        private static readonly object _lock = new object();
        private string _linkFolderPath;

        // Private constructor để ngăn tạo instance từ bên ngoài
        private LinkFolder()
        {
            LoadLinkFolderFile();
        }

        /// <summary>
        /// Lấy instance duy nhất của LinkFolder (Singleton Pattern)
        /// </summary>
        public static LinkFolder Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new LinkFolder();
                        }
                    }
                }
                return _instance;
            }
        }

        /// <summary>
        /// Property để lấy hoặc set đường dẫn folder
        /// </summary>
        public string FolderPath
        {
            get { return _linkFolderPath; }
            set
            {
                _linkFolderPath = value;
                SaveLinkToFile(value);
            }
        }

        /// <summary>
        /// Method public để cập nhật đường dẫn từ bên ngoài (dùng cho FormInputLink)
        /// </summary>
        public void UpdateFolderPath(string path)
        {
            _linkFolderPath = path;
            SaveLinkToFile(path);
        }

        /// <summary>
        /// Đọc file link.txt trong thư mục bin hoặc bin/debug
        /// </summary>
        private void LoadLinkFolderFile()
        {
            try
            {
                // Lấy đường dẫn thư mục hiện tại (bin hoặc bin/debug)
                string currentDirectory = Application.StartupPath;
                string linkFilePath = Path.Combine(currentDirectory, "link.txt");

                // Kiểm tra file có tồn tại không
                if (File.Exists(linkFilePath))
                {
                    // Đọc nội dung file
                    _linkFolderPath = File.ReadAllText(linkFilePath).Trim();
                }
                else
                {
                    // File không tồn tại, đặt giá trị rỗng
                    _linkFolderPath = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đọc file link: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                _linkFolderPath = string.Empty;
            }
        }

        /// <summary>
        /// Mở form để người dùng nhập link folder
        /// </summary>
        private void OpenFormInputLink()
        {
            using (FormInputLink formInput = new FormInputLink())
            {
                if (formInput.ShowDialog() == DialogResult.OK)
                {
                    _linkFolderPath = formInput.LinkFolder;

                    // Lưu link vào file link.txt
                    SaveLinkToFile(_linkFolderPath);
                }
                else
                {
                    // Nếu người dùng cancel, đặt giá trị mặc định
                    MessageBox.Show("Bạn chưa nhập đường dẫn folder!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    _linkFolderPath = string.Empty;
                }
            }
        }

        /// <summary>
        /// Lưu link vào file link.txt
        /// </summary>
        private void SaveLinkToFile(string link)
        {
            try
            {
                string currentDirectory = Application.StartupPath;
                string linkFilePath = Path.Combine(currentDirectory, "link.txt");

                File.WriteAllText(linkFilePath, link);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu file link: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Method public để lưu link (có thể gọi từ FormInputLink)
        /// </summary>
        public void SaveLink(string link)
        {
            SaveLinkToFile(link);
        }

        /// <summary>
        /// Kiểm tra xem đường dẫn folder có hợp lệ và tồn tại không
        /// </summary>
        public bool IsValidPath()
        {
            return !string.IsNullOrWhiteSpace(_linkFolderPath) && Directory.Exists(_linkFolderPath);
        }

        /// <summary>
        /// Mở lại form để thay đổi đường dẫn folder
        /// </summary>
        public void ChangeFolderPath()
        {
            OpenFormInputLink();
        }

        /// <summary>
        /// Tạo thư mục con trong folder chính
        /// </summary>
        /// <param name="subFolderName">Tên thư mục con</param>
        /// <returns>Đường dẫn đầy đủ của thư mục con</returns>
        public string CreateSubFolder(string subFolderName)
        {
            if (!IsValidPath())
            {
                MessageBox.Show("Đường dẫn folder chưa được cấu hình!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            try
            {
                string subFolderPath = Path.Combine(_linkFolderPath, subFolderName);
                if (!Directory.Exists(subFolderPath))
                {
                    Directory.CreateDirectory(subFolderPath);
                }
                return subFolderPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tạo thư mục con: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /// <summary>
        /// Lấy đường dẫn đầy đủ của file trong folder
        /// </summary>
        /// <param name="fileName">Tên file</param>
        /// <returns>Đường dẫn đầy đủ</returns>
        public string GetFullPath(string fileName)
        {
            if (!IsValidPath())
            {
                return null;
            }
            return Path.Combine(_linkFolderPath, fileName);
        }
    }
}