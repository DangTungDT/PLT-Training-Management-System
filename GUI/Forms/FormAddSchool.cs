using BLL;
using DTO;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI.Forms
{
    public partial class FormAddSchool : Form
    {
        private SchoolBLL _schoolBLL = new SchoolBLL();

        public FormAddSchool()
        {
            InitializeComponent();
        }

        private void FormAddSchool_Load(object sender, EventArgs e)
        {
            // Đăng ký các events cho controls
            RegisterTextBoxEvents();
            RegisterPhoneEvents();
        }

        /// <summary>
        /// Đăng ký events cho txtName, txtShortName, txtAddress - Không cho phép ký tự đặc biệt
        /// </summary>
        private void RegisterTextBoxEvents()
        {
            TextBox[] textBoxes = { txtName, txtShortName };

            foreach (var tb in textBoxes)
            {
                tb.KeyPress += TextBox_BlockSpecialChar_KeyPress;
                tb.KeyDown += TextBox_BlockSpecialChar_Paste_KeyDown;
            }
        }

        /// <summary>
        /// Đăng ký events cho txtPhone - Chỉ cho phép số, tối đa 11 ký tự
        /// </summary>
        private void RegisterPhoneEvents()
        {
            txtPhone.KeyPress += TxtPhone_KeyPress;
            txtPhone.TextChanged += TxtPhone_TextChanged;
            txtPhone.KeyDown += TxtPhone_KeyDown;
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
                SchoolDTO newSchool = GetSchoolFromInputs();

                if (newSchool == null)
                {
                    MessageBox.Show("Không thể lấy dữ liệu trường học!",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra trường đã tồn tại chưa (theo tên)
                var existingSchool = _schoolBLL.FindByName(newSchool.Name);
                if (existingSchool != null)
                {
                    MessageBox.Show("Trường học này đã tồn tại!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Thêm trường học
                if (_schoolBLL.AddSchool(newSchool))
                {
                    MessageBox.Show("Thêm trường học thành công!",
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
            // Kiểm tra tất cả các trường bắt buộc đã được nhập chưa
            if (string.IsNullOrWhiteSpace(txtName.Text) &&
                string.IsNullOrWhiteSpace(txtShortName.Text) &&
                string.IsNullOrWhiteSpace(txtAddress.Text) &&
                string.IsNullOrWhiteSpace(txtEmail.Text) &&
                string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên trường!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtShortName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên viết tắt!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtShortName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.Focus();
                return false;
            }

            // Validate Email format
            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                if (!IsValidEmail(txtEmail.Text))
                {
                    MessageBox.Show("Email không hợp lệ!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return false;
                }
            }

            // Validate Phone format
            if (!string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                if (!IsValidPhone(txtPhone.Text))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPhone.Focus();
                    return false;
                }
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidPhone(string phone)
        {
            // Chỉ cho phép số và có độ dài từ 10-11 số
            string digitsOnly = new string(phone.Where(char.IsDigit).ToArray());
            return digitsOnly.Length >= 10 && digitsOnly.Length <= 11;
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
        /// txtPhone chỉ cho phép nhập số
        /// </summary>
        private void TxtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// txtPhone giới hạn tối đa 11 ký tự
        /// </summary>
        private void TxtPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtPhone.Text.Length > 11)
            {
                txtPhone.Text = txtPhone.Text.Substring(0, 11);
                txtPhone.SelectionStart = txtPhone.Text.Length;
            }
        }

        /// <summary>
        /// Block paste không phải số vào txtPhone
        /// </summary>
        private void TxtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                if (Clipboard.ContainsText())
                {
                    string text = Clipboard.GetText();
                    if (!text.All(char.IsDigit))
                    {
                        MessageBox.Show(
                            "Chỉ được nhập số!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        e.SuppressKeyPress = true;
                    }
                }
            }
        }

        /// <summary>
        /// Lấy dữ liệu từ controls và tạo SchoolDTO
        /// IsActive mặc định là true
        /// </summary>
        private SchoolDTO GetSchoolFromInputs()
        {
            try
            {
                SchoolDTO school = new SchoolDTO
                {
                    Name = txtName.Text.Trim(),
                    ShortName = txtShortName.Text.Trim(),
                    Address = txtAddress.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    IsActive = true  // Mặc định là true
                };

                return school;
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

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            bool isLetterOrDigit = char.IsLetterOrDigit(e.KeyChar);
            bool isAllowedSpecial =
                e.KeyChar == ' ' ||
                e.KeyChar == ',' ||
                e.KeyChar == '/' ||
                e.KeyChar == '.' ||
                e.KeyChar == '\\';

            if (!isLetterOrDigit && !isAllowedSpecial)
                e.Handled = true;
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            string allowed = @"^[\p{L}\p{N} ,./\\]*$";

            if (!Regex.IsMatch(txtAddress.Text, allowed))
            {
                int pos = txtAddress.SelectionStart - 1;

                txtAddress.Text = Regex.Replace(
                    txtAddress.Text,
                    @"[^\p{L}\p{N} ,./\\]",
                    ""
                );

                txtAddress.SelectionStart = Math.Max(pos, 0);
            }
        }
    }
}