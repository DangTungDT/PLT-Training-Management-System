using BLL;
using DTO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.UserControls.Book
{
    public partial class ucFileOfBook : UserControl
    {
        private int _position = -1;
        public event Action<int, int> DeleteFile;
        public event Action<int> ActionReadFile;
        private int _fileId;
        private FileBLL _fileBLL = new FileBLL();
        public ucFileOfBook(FilesDTO file, int positionOfList)
        {
            InitializeComponent();
            _position = positionOfList;
            _fileId = file.Id;
            SetData(file);
        }
        public int GetFileId()
        {
            return _fileId;
        }
        public void SetData(FilesDTO file)
        {
            if (file == null) return;

            lblFileName.Text = file.FileName;

            string sizeText = FormatFileSize(file.FileSize);
            string typeText = file.FileType?.ToUpper() ?? "UNKNOWN";
            string dateText = file.CreatedAt.ToString("dd/MM/yyyy");

            lblFileInfo.Text = $"{sizeText} • {typeText} • {dateText}";

            SetIconColor(typeText);
        }

        private void SetIconColor(string type)
        {
            switch (type)
            {
                case "PDF":
                    picIcon.FillColor = Color.FromArgb(254, 242, 242); // đỏ nhạt
                    break;

                case "DOC":
                case "DOCX":
                    picIcon.FillColor = Color.FromArgb(239, 246, 255); // xanh nhạt
                    break;

                case "ZIP":
                case "RAR":
                    picIcon.FillColor = Color.FromArgb(240, 253, 244); // xanh lá
                    break;

                default:
                    picIcon.FillColor = Color.FromArgb(243, 244, 246); // xám
                    break;
            }
        }

        private string FormatFileSize(int? size)
        {
            if (size == null || size <= 0)
                return "0 MB";

            double mb = size.Value / (1024.0 * 1024.0);
            return $"{mb:F2} MB";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DeleteFile?.Invoke(_fileId, _position);
            }

        }

        private void lblFileName_DoubleClick(object sender, EventArgs e)
        {
            FilesDTO selectedFile = _fileBLL.GetFileById(_fileId);
            if (selectedFile != null)
            {
                ActionReadFile?.Invoke(_fileId);
            }
            else
            {
                MessageBox.Show("File không tồn tại hoặc không thể mở.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void picIcon_Click(object sender, EventArgs e)
        {

        }
    }
}
