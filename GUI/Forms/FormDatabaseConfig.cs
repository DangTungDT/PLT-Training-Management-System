using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Windows.Forms;
using Microsoft.Data.Sql;
using System.Data;

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
            string serverFull = cbServerName.SelectedItem?.ToString().Trim();

            if (string.IsNullOrEmpty(serverFull))
            {
                MessageBox.Show("Vui lòng chọn SQL Server");
                return;
            }
            string conn;

            if (rbWindowsAuth.Checked)
            {
                conn = $"Server={serverFull};Database=PTMDB;Trusted_Connection=True;TrustServerCertificate=True";
            }
            else
            {
                conn = $"Server={serverFull};Database=PTMDB;User Id={txtUser.Text};Password={txtPassword.Text};TrustServerCertificate=True";
            }


            SaveConnectionString(conn);
            DialogResult = DialogResult.OK;
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
