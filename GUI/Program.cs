using DAL.databaseContext;
using GUI.Forms;
using System;
using System.Windows.Forms;

namespace GUI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            if (!DatabaseInitializer.CanConnect())
            {
                using (var frm = new FormDatabaseConfig())
                {
                    if (frm.ShowDialog() != DialogResult.OK)
                        return;
                }
                Application.Restart();
                return;
            }
            try
            {
                DatabaseInitializer.Initialize();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Không thể khởi tạo CSDL.\nLỗi: {ex.Message}",
                    "Lỗi hệ thống",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            Application.Run(new Main());
        }
    }
}
