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
    public partial class UcInputFileBook : UserControl
    {
        public UcInputFileBook()
        {
            InitializeComponent();
        }

        private void pnUploadFile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pnUploadFile_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (files.Length > 0)
            {
                HandleSelectedFile(files[0]);
            }
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "PDF, DOC, DOCX, ZIP, RAR|*.pdf;*.doc;*.docx;*.zip;*.rar",
                Multiselect = false
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                HandleSelectedFile(ofd.FileName);
            }
        }
        private void HandleSelectedFile(string filePath)
        {
            FileInfo file = new FileInfo(filePath);

            if (file.Length > 500 * 1024 * 1024)
            {
                MessageBox.Show("File vượt quá 500MB");
                return;
            }
            string nameFile = file.Name;
            string capacityFile = (file.Length / (1024.0 * 1024.0)).ToString("F2") + " MB";
            dgvFileBook.Rows.Add(nameFile,capacityFile );

        }
    }
}
