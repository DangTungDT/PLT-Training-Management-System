using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.IO;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Windows.Forms;

namespace GUI.Forms
{
    public partial class FormDatabaseConfig : Form
    {
        public FormDatabaseConfig()
        {
            InitializeComponent();
            rbWindowsAuth.Checked = true;
            LoadSqlServers();
        }
        private void LoadCurrentSettings()
        {
            try
            {
                var path = Path.Combine(AppContext.BaseDirectory, "appsettings.json");

                if (!File.Exists(path))
                    return;

                var root = JsonNode.Parse(File.ReadAllText(path));
                var connStr = root?["ConnectionStrings"]?["Default"]?.ToString();

                if (string.IsNullOrEmpty(connStr))
                    return;

                // Parse connection string
                var builder = new SqlConnectionStringBuilder(connStr);

                // Set server name
                cbServerName.Text = builder.DataSource;

                // Set authentication mode
                if (builder.IntegratedSecurity)
                {
                    rbWindowsAuth.Checked = true;
                }
                else
                {
                    rbSqlAuth.Checked = true;
                    txtUser.Text = builder.UserID;
                    txtPassword.Text = builder.Password;
                }
            }
            catch
            {
                // Ignore errors when loading settings
            }
        }
        private void LoadSqlServers()
        {
            cbServerName.Items.Clear();

            try
            {
                DataTable table = SqlDataSourceEnumerator.Instance.GetDataSources();

                foreach (DataRow row in table.Rows)
                {
                    string serverName = row["ServerName"].ToString();
                    string instanceName = row["InstanceName"].ToString();

                    if (string.IsNullOrEmpty(instanceName))
                        cbServerName.Items.Add(serverName);
                    else
                        cbServerName.Items.Add($"{serverName}\\{instanceName}");
                }

                if (cbServerName.Items.Count > 0)
                    cbServerName.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể load danh sách SQL Server.\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string serverFull = cbServerName.Text?.Trim();

            if (string.IsNullOrEmpty(serverFull))
            {
                MessageBox.Show(
                    "Vui lòng chọn hoặc nhập tên SQL Server!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                cbServerName.Focus();
                return;
            }

            string connectionString;

            if (rbWindowsAuth.Checked)
            {
                connectionString = $"Server={serverFull};Database=PTMDB;Trusted_Connection=True;TrustServerCertificate=True";
            }
            else
            {
                string username = txtUser.Text?.Trim();
                string password = txtPassword.Text;

                if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show(
                        "Vui lòng nhập tên đăng nhập!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    txtUser.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show(
                        "Vui lòng nhập mật khẩu!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    txtPassword.Focus();
                    return;
                }

                connectionString = $"Server={serverFull};Database=PTMDB;User Id={username};Password={password};TrustServerCertificate=True";
            }

            // Test connection trước khi lưu
            if (!TestConnection(connectionString))
            {
                return; // Không lưu nếu kết nối thất bại
            }

            // Lưu connection string vào appsettings.json
            try
            {
                SaveConnectionString(connectionString);

                MessageBox.Show(
                    "Lưu cấu hình thành công!\nỨng dụng sẽ khởi động lại.",
                    "Thành công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Không thể lưu cấu hình.\nLỗi: {ex.Message}",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private bool TestConnection(string connectionString)
        {
            try
            {
                // Kết nối vào master để test server
                var builder = new SqlConnectionStringBuilder(connectionString)
                {
                    InitialCatalog = "master",
                    ConnectTimeout = 5 // Timeout 5 giây
                };

                using var conn = new SqlConnection(builder.ConnectionString);
                conn.Open();

                MessageBox.Show(
                    "Kết nối SQL Server thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                return true;
            }
            catch (SqlException ex)
            {
                string errorMsg = ex.Number switch
                {
                    -1 => "Không thể kết nối đến SQL Server.\nVui lòng kiểm tra:\n- Tên server có đúng không?\n- SQL Server có đang chạy không?\n- Firewall có chặn không?",
                    18456 => "Đăng nhập thất bại.\nVui lòng kiểm tra:\n- Tên đăng nhập có đúng không?\n- Mật khẩu có đúng không?\n- SQL Server Authentication có được bật không?",
                    4060 => "Không thể mở database.\nDatabase có thể chưa tồn tại (sẽ được tạo tự động).",
                    _ => $"Lỗi SQL: {ex.Message}"
                };

                MessageBox.Show(
                    errorMsg,
                    "Lỗi kết nối",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Không thể kết nối đến SQL Server.\nLỗi: {ex.Message}",
                    "Lỗi kết nối",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return false;
            }
        }

        private void SaveConnectionString(string connectionString)
        {
            var path = Path.Combine(AppContext.BaseDirectory, "appsettings.json");

            JsonNode root;

            if (File.Exists(path))
            {
                root = JsonNode.Parse(File.ReadAllText(path))!;
            }
            else
            {
                root = new JsonObject();
            }

            if (root["ConnectionStrings"] == null)
            {
                root["ConnectionStrings"] = new JsonObject();
            }

            root["ConnectionStrings"]!["Default"] = connectionString;

            File.WriteAllText(
                path,
                root.ToJsonString(new JsonSerializerOptions { WriteIndented = true })
            );
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
