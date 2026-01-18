using GUI;
using System;
using System.IO;
using System.Windows.Forms;
using GUI.Helpers;
namespace GUI.Forms
{
    public partial class FormInputLink : Form
    {
        public string LinkFolder { get; private set; }

        public FormInputLink()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Chọn thư mục lưu trữ file";
                folderDialog.ShowNewFolderButton = true;

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    txtLinkFolder.Text = folderDialog.SelectedPath;
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string path = txtLinkFolder.Text.Trim();

            if (string.IsNullOrWhiteSpace(path))
            {
                MessageBox.Show("Vui lòng nhập đường dẫn thư mục!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLinkFolder.Focus();
                return;
            }

            try
            {
                // Tạo thư mục nếu chưa tồn tại
                if (!Directory.Exists(path))
                {
                    DialogResult result = MessageBox.Show(
                        "Thư mục không tồn tại. Bạn có muốn tạo mới không?",
                        "Xác nhận",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        Directory.CreateDirectory(path);
                    }
                    else
                    {
                        return;
                    }
                }

                // Lưu đường dẫn vào file link.txt trong thư mục bin/debug
                string currentDirectory = Application.StartupPath;
                string linkFilePath = Path.Combine(currentDirectory, "link.txt");
                File.WriteAllText(linkFilePath, path);

                // Cập nhật biến _linkFolderPath trong class LinkFolder
                Helpers.LinkFolder.Instance.UpdateFolderPath(path);

                LinkFolder = path;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đường dẫn không hợp lệ: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}