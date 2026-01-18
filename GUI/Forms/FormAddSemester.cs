using BLL;
using DTO;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI.Forms
{
    public partial class FormAddSemester : Form
    {
        private SemesterBLL _semesterBLL = new SemesterBLL();
        private SchoolBLL _schoolBLL = new SchoolBLL();

        public FormAddSemester()
        {
            InitializeComponent();
        }

        private void FormAddSemester_Load(object sender, EventArgs e)
        {
            LoadSchoolToComboBox();
            LoadYearToComboBox();
            RegisterTextBoxEvents();
            RegisterDateTimePickerEvents();
        }

        /// <summary>
        /// Đăng ký events cho txtName - Không cho phép ký tự đặc biệt
        /// </summary>
        private void RegisterTextBoxEvents()
        {
            txtName.KeyPress += TextBox_BlockSpecialChar_KeyPress;
            txtName.KeyDown += TextBox_BlockSpecialChar_Paste_KeyDown;
        }

        /// <summary>
        /// Đăng ký events cho DateTimePicker
        /// </summary>
        private void RegisterDateTimePickerEvents()
        {
            dtpStartDate.ValueChanged += DtpStartDate_ValueChanged;
            dtpEndDate.ValueChanged += DtpEndDate_ValueChanged;
        }

        /// <summary>
        /// Kiểm tra khi thay đổi ngày bắt đầu
        /// </summary>
        private void DtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpEndDate.Value <= dtpStartDate.Value)
            {
                // Tự động set ngày kết thúc = ngày bắt đầu + 1 ngày
                dtpEndDate.Value = dtpStartDate.Value.AddDays(1);
            }
        }

        /// <summary>
        /// Kiểm tra khi thay đổi ngày kết thúc
        /// </summary>
        private void DtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpEndDate.Value <= dtpStartDate.Value)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpEndDate.Value = dtpStartDate.Value.AddDays(1);
            }
        }

        /// <summary>
        /// Load tất cả trường vào ComboBox - Hiển thị tên, lưu ID
        /// </summary>
        private void LoadSchoolToComboBox()
        {
            try
            {
                var schools = _schoolBLL.GetAllSchools();

                if (schools == null || schools.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu trường học!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                cbSchool.DisplayMember = "Name";  // Hiển thị tên trường
                cbSchool.ValueMember = "Id";      // Lưu ID trường
                cbSchool.DataSource = schools;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách trường: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadYearToComboBox()
        {
            int currentYear = DateTime.Now.Year;
            for (int i = currentYear - 5; i <= currentYear + 5; i++)
            {
                cbYear.Items.Add(i);
            }
            cbYear.SelectedItem = currentYear;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate dữ liệu
                if (!ValidateInputs())
                {
                    return;
                }

                // Lấy dữ liệu từ controls
                SemesterDTO newSemester = GetSemesterFromInputs();

                if (newSemester == null)
                {
                    MessageBox.Show("Không thể lấy dữ liệu học kỳ!",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra học kỳ đã tồn tại chưa
                var existingSemester = _semesterBLL.FindByNameAndYear(newSemester.Name, newSemester.Year);
                if (existingSemester != null)
                {
                    MessageBox.Show("Học kỳ này đã tồn tại!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Thêm học kỳ
                if (_semesterBLL.AddSemester(newSemester))
                {
                    MessageBox.Show("Thêm học kỳ thành công!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Thêm thất bại! Lỗi: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs()
        {
            // Kiểm tra txtName
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên học kỳ!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            // Kiểm tra cbYear
            if (cbYear.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn năm!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbYear.Focus();
                return false;
            }

            // Kiểm tra cbSchool
            if (cbSchool.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn trường!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbSchool.Focus();
                return false;
            }

            // Kiểm tra ngày
            if (dtpStartDate.Value >= dtpEndDate.Value)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpStartDate.Focus();
                return false;
            }

            return true;
        }

        private bool ContainsSpecialCharacter(string input)
        {
            // Cho phép chữ cái, số và dấu cách
            return !Regex.IsMatch(input, @"^[\p{L}0-9\s]+$");
        }

        /// <summary>
        /// Block ký tự đặc biệt khi nhập
        /// </summary>
        private void TextBox_BlockSpecialChar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            // Cho phép chữ, số và dấu cách
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Block paste ký tự đặc biệt
        /// </summary>
        private void TextBox_BlockSpecialChar_Paste_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                string clipboardText = Clipboard.GetText();

                if (ContainsSpecialCharacter(clipboardText))
                {
                    MessageBox.Show(
                        "Không được dán ký tự đặc biệt!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    e.SuppressKeyPress = true;
                }
            }
        }

        /// <summary>
        /// Lấy dữ liệu từ controls và tạo SemesterDTO
        /// Lưu ý: cbSchool.SelectedValue trả về SchoolId (int)
        /// </summary>
        private SemesterDTO GetSemesterFromInputs()
        {
            try
            {
                int year = Convert.ToInt32(cbYear.SelectedItem);

                // Lấy SchoolId từ SelectedValue của ComboBox
                // ComboBox hiển thị Name nhưng lưu Id
                int schoolId = Convert.ToInt32(cbSchool.SelectedValue);

                SemesterDTO semester = new SemesterDTO
                {
                    Name = txtName.Text.Trim(),
                    Year = year,
                    StartDate = dtpStartDate.Value,
                    EndDate = dtpEndDate.Value,
                    SchoolId = schoolId  // Lấy từ SelectedValue
                };

                return semester;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy dữ liệu: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}