using BLL;
using DTO;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI.Forms
{
    public partial class FormAddFaculty : Form
    {
        private FacultyBLL _facultyBLL = new FacultyBLL();
        private SchoolBLL _schoolBLL = new SchoolBLL();
        private int _schoolId = 0;

        public FormAddFaculty()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Set School ID from parent form
        /// </summary>
        public void SetSchoolId(int schoolId)
        {
            _schoolId = schoolId;
        }

        private void FormAddFaculty_Load(object sender, EventArgs e)
        {
            // Đăng ký các events cho controls
            RegisterTextBoxEvents();

            // Load schools to combobox
            LoadSchoolsToCombobox();

            // If schoolId was set, select it
            if (_schoolId > 0)
            {
                cbSchool.SelectedValue = _schoolId;
                cbSchool.Enabled = false; // Disable if pre-selected
            }
        }

        /// <summary>
        /// Load all schools to combobox
        /// </summary>
        private void LoadSchoolsToCombobox()
        {
            try
            {
                var schools = _schoolBLL.GetAllSchools();

                cbSchool.DisplayMember = "Name";
                cbSchool.ValueMember = "Id";
                cbSchool.DataSource = schools.ToList();

                if (schools.Any())
                {
                    cbSchool.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách trường học: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Đăng ký events cho txtName, txtDescription - Không cho phép ký tự đặc biệt
        /// </summary>
        private void RegisterTextBoxEvents()
        {
            TextBox[] textBoxes = { txtName };

            foreach (var tb in textBoxes)
            {
                tb.KeyPress += TextBox_BlockSpecialChar_KeyPress;
                tb.KeyDown += TextBox_BlockSpecialChar_Paste_KeyDown;
            }
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
                FacultyDTO newFaculty = GetFacultyFromInputs();

                if (newFaculty == null)
                {
                    MessageBox.Show("Không thể lấy dữ liệu khoa!",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra khoa đã tồn tại chưa (theo tên và school)
                var existingFaculty = _facultyBLL.FindByNameAndSchool(newFaculty.Name, newFaculty.SchoolId);
                if (existingFaculty != null)
                {
                    MessageBox.Show("Khoa này đã tồn tại trong trường học!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Thêm khoa
                if (_facultyBLL.AddFaculty(newFaculty))
                {
                    MessageBox.Show("Thêm khoa thành công!",
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
            // Kiểm tra trường học đã được chọn
            if (cbSchool.SelectedValue == null || Convert.ToInt32(cbSchool.SelectedValue) <= 0)
            {
                MessageBox.Show("Vui lòng chọn trường học!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbSchool.Focus();
                return false;
            }

            // Kiểm tra tên khoa
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khoa!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            // Validate tên khoa có ít nhất 3 ký tự
            if (txtName.Text.Trim().Length < 3)
            {
                MessageBox.Show("Tên khoa phải có ít nhất 3 ký tự!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            return true;
        }

        private bool ContainsSpecialCharacter(string input)
        {
            // Cho phép chữ cái, số và dấu cách, không cho phép ký tự đặc biệt
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
        /// Lấy dữ liệu từ controls và tạo FacultyDTO
        /// </summary>
        private FacultyDTO GetFacultyFromInputs()
        {
            try
            {
                int schoolId = Convert.ToInt32(cbSchool.SelectedValue);

                FacultyDTO faculty = new FacultyDTO
                {
                    Name = txtName.Text.Trim(),
                    SchoolId = schoolId,
                    Description = txtDescription.Text.Trim()
                };

                return faculty;
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
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Allow letters, digits, spaces, and some special characters for description
        /// </summary>
        private void txtDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            bool isLetterOrDigit = char.IsLetterOrDigit(e.KeyChar);
            bool isAllowedSpecial =
                e.KeyChar == ' ' ||
                e.KeyChar == ',' ||
                e.KeyChar == '.' ||
                e.KeyChar == '-' ||
                e.KeyChar == '(' ||
                e.KeyChar == ')';

            if (!isLetterOrDigit && !isAllowedSpecial)
                e.Handled = true;
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            string allowed = @"^[\p{L}\p{N} ,.()\\-]*$";

            if (!Regex.IsMatch(txtDescription.Text, allowed))
            {
                int pos = txtDescription.SelectionStart - 1;

                txtDescription.Text = Regex.Replace(
                    txtDescription.Text,
                    @"[^\p{L}\p{N} ,.()\\-]",
                    ""
                );

                txtDescription.SelectionStart = Math.Max(pos, 0);
            }
        }
    }
}