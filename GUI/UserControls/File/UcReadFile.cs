using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfiumViewer;
using BLL;
using DTO;

namespace GUI.UserControls.Book
{
    public partial class UcReadFile : UserControl
    {
        private string _filePath = "";
        private FilesDTO _fileSelected;
        private FileBLL _fileBLL = new FileBLL();
        private PdfRenderer _pdfRenderer;
        private PdfDocument _pdfDocument;
        private int _currentPage = 0;
        private int _totalPages = 0;
        private float _zoom = 1.0f;
        public UcReadFile(int fileId)
        {
            InitializeComponent();
            _fileSelected = _fileBLL.GetFileById(fileId);
            _filePath = _fileSelected.FilePath;
        }

        private void LoadValueExamToControl()
        {
            lblFileName.Text = _fileSelected.FileName;
            lblTenFileValue.Text = _fileSelected.FileName;
            lblNgayTaiValue.Text =_fileSelected.CreatedAt.ToString();
            lblKichThuocValue.Text = (_fileSelected.FileSize / 1024) + " MB";
        }
        private void LoadPdfToPanel(string filePath)
        {
            try
            {
                panelFillContent.Controls.Clear();
                panelFillContent.AutoScroll = true;

                _pdfDocument = PdfDocument.Load(filePath);
                _totalPages = _pdfDocument.PageCount;
                lbTotalPage.Text = $"{_totalPages}";
                _currentPage = 0;
                lblSoTrangText.Text = _pdfDocument.PageCount.ToString();
                RenderPage(_currentPage);
            }
            catch
            {
                MessageBox.Show("Tài liệu hiện không tồn tại hoặc không tìm thấy!", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RenderPage(int pageIndex)
        {
            if (_pdfDocument == null) return;

            var size = _pdfDocument.PageSizes[pageIndex];
            int renderWidth = (int)(size.Width * _zoom);
            int renderHeight = (int)(size.Height * _zoom);

            var bitmap = _pdfDocument.Render(pageIndex, renderWidth, renderHeight, 96, 96, PdfRenderFlags.Annotations);

            var pb = new PictureBox
            {
                Image = bitmap,
                SizeMode = PictureBoxSizeMode.Normal,
                Width = bitmap.Width,
                Height = bitmap.Height
            };

            var innerPanel = new Panel
            {
                Width = Math.Max(panelFillContent.Width, pb.Width),
                Height = Math.Max(panelFillContent.Height, pb.Height),
                Dock = DockStyle.Fill,
                AutoScroll = true
            };

            pb.Left = (innerPanel.Width - pb.Width) / 2;
            pb.Top = (innerPanel.Height - pb.Height) / 2;

            innerPanel.Controls.Add(pb);

            panelFillContent.Controls.Clear();
            panelFillContent.AutoScroll = true;
            panelFillContent.Controls.Add(innerPanel);
        }



        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_currentPage < _pdfDocument.PageCount - 1)
            {
                _currentPage++;
                RenderPage(_currentPage);
                txtPageNumber.Text = (_currentPage + 1).ToString();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (_currentPage > 0)
            {
                _currentPage--;
                RenderPage(_currentPage);
                txtPageNumber.Text = (_currentPage + 1).ToString();
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UcReadFile_Load(object sender, EventArgs e)
        {
            if (_filePath != "")
            {
                txtPageNumber.Text = "1";
                this.BeginInvoke(new Action(() =>
                {
                    LoadPdfToPanel(_filePath);
                }));
                LoadValueExamToControl();
            }
            else
            {
                MessageBox.Show("File không tồn tại hoặc không thể mở.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            _zoom += 0.25f;
            RenderPage(_currentPage);
            lbMagnification.Text = $"{_zoom * 100}%";
        }

        private void btnMiuns_Click(object sender, EventArgs e)
        {
            if (_zoom > 0.25f)
            {
                _zoom -= 0.25f;
                RenderPage(_currentPage);
                lbMagnification.Text = $"{_zoom * 100}%";
            }
            
        }
    }
}
