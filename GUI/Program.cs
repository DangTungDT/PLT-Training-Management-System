using DAL.databaseContext;
using GUI.Forms;
using Microsoft.Data.SqlClient;
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

            if (!DatabaseInitializer.CanConnectToServer())
            {
                // Không tìm thấy SQL Server nào, cho phép user cấu hình thủ công
                MessageBox.Show(
                    "Không tìm thấy SQL Server nào có thể kết nối.\n" +
                    "Vui lòng cấu hình thủ công.",
                    "Cấu hình Database",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                using var frm = new FormDatabaseConfig();
                if (frm.ShowDialog() != DialogResult.OK)
                    return;

                Application.Restart();
                return;
            }
            // Bước 2: Kiểm tra database có tồn tại không
            if (!DatabaseInitializer.DatabaseExists())
            {
                try
                {
                    DatabaseInitializer.CreateDatabase();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"Không thể tạo CSDL.\n\nLỗi: {ex.Message}",
                        "Lỗi hệ thống",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }
            }

            // Bước 3: Khởi tạo/migrate schema
            try
            {
                Console.WriteLine("Đang khởi tạo schema database...");
                DatabaseInitializer.Initialize();
                Console.WriteLine("✓ Khởi tạo schema thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Không thể khởi tạo schema CSDL.\n\nLỗi: {ex.Message}",
                    "Lỗi hệ thống",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            // Chạy ứng dụng chính
            Application.Run(new Main());
        }
    }
}