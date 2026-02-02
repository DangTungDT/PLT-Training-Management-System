using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Linq;
using System.Text.Json;

namespace DAL.databaseContext
{
    public static class DatabaseInitializer
    {
        private static string _workingConnectionString = null;

        /// <summary>
        /// Khởi tạo database schema bằng migrations
        /// </summary>
        public static void Initialize()
        {
            using (var context = new AppDBContext())
            {
                context.Database.Migrate();
            }
        }

        /// <summary>
        /// Tự động phát hiện và kết nối SQL Server, lưu cấu hình nếu thành công
        /// </summary>
        public static bool CanConnectToServer()
        {
            var baseConnectionString = GetConnectionString();
            var builder = new SqlConnectionStringBuilder(baseConnectionString);

            // Bước 1: Thử kết nối với server trong config trước
            var currentServer = builder.DataSource;
            if (!string.IsNullOrEmpty(currentServer) && TryConnect(currentServer, builder))
            {
                Console.WriteLine($"✓ Kết nối với server đã lưu: {currentServer}");
                return true;
            }

            // Bước 2: Thử các server phổ biến (nhanh hơn)
            var commonServers = new List<string>
            {
                ".",
                "localhost",
                "(local)",
                ".\\SQLEXPRESS",
                "localhost\\SQLEXPRESS",
                "(local)\\SQLEXPRESS",
                ".\\MSSQLSERVER",
                "localhost\\MSSQLSERVER"
            };

            foreach (var serverName in commonServers)
            {
                if (TryConnect(serverName, builder))
                {
                    Console.WriteLine($"✓ Kết nối nhanh với: {serverName}");
                    SaveServerNameToConfig(serverName);
                    return true;
                }
            }

            // Bước 3: Nếu không kết nối được, quét tất cả SQL Server instances
            Console.WriteLine("Đang quét SQL Server instances trên mạng...");
            var discoveredServers = DiscoverSqlServerInstances();

            foreach (var serverName in discoveredServers)
            {
                if (TryConnect(serverName, builder))
                {
                    Console.WriteLine($"✓ Phát hiện và kết nối với: {serverName}");
                    SaveServerNameToConfig(serverName);
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Phát hiện tất cả SQL Server instances trên mạng local
        /// </summary>
        private static List<string> DiscoverSqlServerInstances()
        {
            var instances = new List<string>();

            try
            {
                var sqlDataSourceEnumerator = SqlDataSourceEnumerator.Instance;
                var dataTable = sqlDataSourceEnumerator.GetDataSources();

                foreach (DataRow row in dataTable.Rows)
                {
                    var serverName = row["ServerName"]?.ToString();
                    var instanceName = row["InstanceName"]?.ToString();

                    if (!string.IsNullOrEmpty(serverName))
                    {
                        if (string.IsNullOrEmpty(instanceName))
                        {
                            // Default instance
                            instances.Add(serverName);
                        }
                        else
                        {
                            // Named instance
                            instances.Add($"{serverName}\\{instanceName}");
                        }
                    }
                }

                Console.WriteLine($"Phát hiện {instances.Count} SQL Server instance(s)");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"⚠ Lỗi khi quét SQL Server: {ex.Message}");
            }

            return instances;
        }

        /// <summary>
        /// Thử kết nối với một server cụ thể
        /// </summary>
        private static bool TryConnect(string serverName, SqlConnectionStringBuilder baseBuilder)
        {
            try
            {
                var builder = new SqlConnectionStringBuilder(baseBuilder.ConnectionString)
                {
                    DataSource = serverName,
                    InitialCatalog = "master",
                    ConnectTimeout = 3 // Giảm timeout để quét nhanh hơn
                };

                using var conn = new SqlConnection(builder.ConnectionString);
                conn.Open();

                // Lưu connection string thành công
                builder.InitialCatalog = baseBuilder.InitialCatalog;
                builder.ConnectTimeout = 30; // Khôi phục timeout bình thường
                _workingConnectionString = builder.ConnectionString;

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Lưu server name vào appsettings.json
        /// </summary>
        private static void SaveServerNameToConfig(string serverName)
        {
            try
            {
                var configPath = System.IO.Path.Combine(AppContext.BaseDirectory, "appsettings.json");

                // Đọc file hiện tại
                var json = System.IO.File.ReadAllText(configPath);
                using var doc = JsonDocument.Parse(json);

                var root = doc.RootElement;
                var connectionStrings = root.GetProperty("ConnectionStrings");
                var currentConnectionString = connectionStrings.GetProperty("Default").GetString();

                // Cập nhật Server Name
                var builder = new SqlConnectionStringBuilder(currentConnectionString)
                {
                    DataSource = serverName
                };

                // Tạo JSON mới
                var newConfig = new
                {
                    ConnectionStrings = new
                    {
                        Default = builder.ConnectionString
                    }
                };

                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                };

                var newJson = JsonSerializer.Serialize(newConfig, options);
                System.IO.File.WriteAllText(configPath, newJson);

                Console.WriteLine($"✓ Đã lưu server '{serverName}' vào appsettings.json");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"⚠ Không thể lưu config: {ex.Message}");
                // Không throw exception vì vẫn kết nối được
            }
        }

        /// <summary>
        /// Kiểm tra database có tồn tại hay không
        /// </summary>
        public static bool DatabaseExists()
        {
            try
            {
                var builder = new SqlConnectionStringBuilder(GetWorkingConnectionString());
                var dbName = builder.InitialCatalog;

                // Kết nối vào master để check database
                builder.InitialCatalog = "master";

                using var conn = new SqlConnection(builder.ConnectionString);
                conn.Open();

                using var cmd = new SqlCommand(
                    "SELECT database_id FROM sys.databases WHERE Name = @dbName",
                    conn
                );
                cmd.Parameters.AddWithValue("@dbName", dbName);

                return cmd.ExecuteScalar() != null;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Tạo database mới
        /// </summary>
        public static void CreateDatabase()
        {
            var builder = new SqlConnectionStringBuilder(GetWorkingConnectionString());
            var dbName = builder.InitialCatalog;

            // Kết nối vào master để tạo database
            builder.InitialCatalog = "master";

            using var conn = new SqlConnection(builder.ConnectionString);
            conn.Open();

            // Tạo database
            var sql = $@"
                IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'{dbName}')
                BEGIN
                    CREATE DATABASE [{dbName}]
                END
            ";

            using var cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Lấy connection string đang hoạt động
        /// </summary>
        private static string GetWorkingConnectionString()
        {
            return _workingConnectionString ?? GetConnectionString();
        }

        /// <summary>
        /// Lấy connection string từ config file
        /// </summary>
        private static string GetConnectionString()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

            return config.GetConnectionString("Default");
        }

        /// <summary>
        /// Kiểm tra kết nối đến database cụ thể
        /// </summary>
        public static bool CanConnect()
        {
            try
            {
                using var conn = new SqlConnection(GetWorkingConnectionString());
                conn.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Lấy thông tin server name đang kết nối
        /// </summary>
        public static string GetConnectedServerName()
        {
            if (_workingConnectionString != null)
            {
                var builder = new SqlConnectionStringBuilder(_workingConnectionString);
                return builder.DataSource;
            }

            var currentBuilder = new SqlConnectionStringBuilder(GetConnectionString());
            return currentBuilder.DataSource;
        }

        /// <summary>
        /// Lấy danh sách tất cả SQL Server instances có thể kết nối
        /// </summary>
        public static List<string> GetAvailableSqlServers()
        {
            var availableServers = new List<string>();
            var baseConnectionString = GetConnectionString();
            var builder = new SqlConnectionStringBuilder(baseConnectionString);

            // Thêm các server phổ biến
            var commonServers = new List<string>
            {
                ".", "localhost", "(local)",
                ".\\SQLEXPRESS", "localhost\\SQLEXPRESS", "(local)\\SQLEXPRESS"
            };

            foreach (var server in commonServers)
            {
                if (TryConnect(server, builder))
                {
                    if (!availableServers.Contains(server))
                        availableServers.Add(server);
                }
            }

            // Thêm các server được phát hiện
            var discovered = DiscoverSqlServerInstances();
            foreach (var server in discovered)
            {
                if (!availableServers.Contains(server) && TryConnect(server, builder))
                {
                    availableServers.Add(server);
                }
            }

            return availableServers;
        }

        /// <summary>
        /// Cho phép user chọn server và lưu vào config
        /// </summary>
        public static bool SetAndSaveServer(string serverName)
        {
            var baseConnectionString = GetConnectionString();
            var builder = new SqlConnectionStringBuilder(baseConnectionString);

            if (TryConnect(serverName, builder))
            {
                SaveServerNameToConfig(serverName);
                return true;
            }

            return false;
        }
    }
}