using DAL.databaseContext;
using System;
using System.Windows.Forms;

namespace GUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            try
            {
                DatabaseInitializer.Initialize();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể kết nối hoặc khởi tạo Cơ sở dữ liệu.\nLỗi: {ex.Message}", "Lỗi Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Application.Run(new Main());
        }
    }
}