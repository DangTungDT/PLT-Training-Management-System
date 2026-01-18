using BLL;
using DTO;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace GUI.Forms
{
    public partial class FormAddSubject : Form
    {
        private CourseBLL _courseBLL = new CourseBLL();
        private SemesterBLL _semesterBLL = new SemesterBLL();
        private CategoryBLL _categoryBLL = new CategoryBLL();

        // helper class for binding (if you already have a global CbItem, it's okay to reuse)
        public class CbItem
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public FormAddSubject()
        {
            InitializeComponent();
        }

        private void FormAddSubject_Load(object sender, EventArgs e)
        {
            LoadSemesterToComboBox();
            LoadCategoryToComboBox();
            RegisterTextBoxEvents();
            RegisterDateTimePickerEvents();
        }

        private void RegisterTextBoxEvents()
        {
            txtFullName.KeyPress += TextBox_BlockSpecialChar_KeyPress;
            txtFullName.KeyDown += TextBox_BlockSpecialChar_Paste_KeyDown;

            txtShortName.KeyPress += TextBox_BlockSpecialChar_KeyPress;
            txtShortName.KeyDown += TextBox_BlockSpecialChar_Paste_KeyDown;

            txtDescription.KeyPress += TextBox_BlockSpecialChar_KeyPress;
            txtDescription.KeyDown += TextBox_BlockSpecialChar_Paste_KeyDown;
        }

        private void RegisterDateTimePickerEvents()
        {
            dtpStartDate.ValueChanged += DtpStartDate_ValueChanged;
            dtpEndDate.ValueChanged += DtpEndDate_ValueChanged;
        }

        private void DtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpEndDate.Value <= dtpStartDate.Value)
            {
                // tự động đặt end = start + 1 ngày
                dtpEndDate.Value = dtpStartDate.Value.AddDays(1);
            }
        }

        private void DtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpEndDate.Value <= dtpStartDate.Value)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpEndDate.Value = dtpStartDate.Value.AddDays(1);
            }
        }

        private void LoadSemesterToComboBox()
        {
            try
            {
                var semesters = _semesterBLL.GetAll() ?? new List<SemesterDTO>();
                var items = semesters.Select(s => new CbItem { Id = s.Id, Name = s.Name }).ToList();

                if (items.Count == 0)
                {
                    // still allow user to create course but inform them
                    cbSemester.DisplayMember = "Name";
                    cbSemester.ValueMember = "Id";
                    cbSemester.DataSource = new List<CbItem> { new CbItem { Id = 0, Name = "Chưa có học kỳ" } };
                    cbSemester.SelectedIndex = 0;
                    return;
                }

                cbSemester.DisplayMember = "Name";
                cbSemester.ValueMember = "Id";
                cbSemester.DataSource = items;
                cbSemester.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải học kỳ: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCategoryToComboBox()
        {
            try
            {
                var categories = _categoryBLL.GetAllCategories() ?? new List<CategoryDTO>();
                var items = categories.Select(c => new CbItem { Id = c.Id, Name = c.Name }).ToList();

                if (items.Count == 0)
                {
                    cbCategory.DisplayMember = "Name";
                    cbCategory.ValueMember = "Id";
                    cbCategory.DataSource = new List<CbItem> { new CbItem { Id = 0, Name = "Chưa có nhóm" } };
                    cbCategory.SelectedIndex = 0;
                    return;
                }

                cbCategory.DisplayMember = "Name";
                cbCategory.ValueMember = "Id";
                cbCategory.DataSource = items;
                cbCategory.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải nhóm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ContainsSpecialCharacter(string input)
        {
            // Cho phép chữ, số, dấu cách; không cho phép ký tự đặc biệt
            return !Regex.IsMatch(input ?? string.Empty, @"^[\p{L}0-9\s]+$");
        }

        private void TextBox_BlockSpecialChar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBox_BlockSpecialChar_Paste_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                string clipboardText = Clipboard.GetText();
                if (ContainsSpecialCharacter(clipboardText))
                {
                    MessageBox.Show("Không được dán ký tự đặc biệt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInputs())
                    return;

                var course = new CourseDTO
                {
                    FullName = txtFullName.Text.Trim(),
                    ShortName = txtShortName.Text.Trim(),
                    StartDate = dtpStartDate.Value,
                    EndDate = dtpEndDate.Value,
                    Description = txtDescription.Text.Trim(),
                    SemesterId = cbSemester.SelectedValue == null ? 0 : Convert.ToInt32(cbSemester.SelectedValue),
                    CategoryId = cbCategory.SelectedValue == null ? 0 : Convert.ToInt32(cbCategory.SelectedValue)
                };

                bool added = false;
                try
                {
                    added = _courseBLL.AddCourse(course);
                }
                catch (ArgumentException aex)
                {
                    MessageBox.Show(aex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (added)
                {
                    MessageBox.Show("Thêm môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm môn học thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm môn học: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs()
        {
            // FullName
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên môn học (FullName)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return false;
            }
            if (ContainsSpecialCharacter(txtFullName.Text))
            {
                MessageBox.Show("Tên môn học không được chứa ký tự đặc biệt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return false;
            }

            // ShortName
            if (string.IsNullOrWhiteSpace(txtShortName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên rút gọn (ShortName)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtShortName.Focus();
                return false;
            }
            if (ContainsSpecialCharacter(txtShortName.Text))
            {
                MessageBox.Show("Tên rút gọn không được chứa ký tự đặc biệt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtShortName.Focus();
                return false;
            }

            // Category
            if (cbCategory.SelectedValue == null || Convert.ToInt32(cbCategory.SelectedValue) <= 0)
            {
                MessageBox.Show("Vui lòng chọn nhóm (Category)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbCategory.Focus();
                return false;
            }

            // Semester
            if (cbSemester.SelectedValue == null || Convert.ToInt32(cbSemester.SelectedValue) <= 0)
            {
                MessageBox.Show("Vui lòng chọn học kỳ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbSemester.Focus();
                return false;
            }

            // Description (optional but block special characters if provided)
            if (!string.IsNullOrWhiteSpace(txtDescription.Text) && ContainsSpecialCharacter(txtDescription.Text))
            {
                MessageBox.Show("Mô tả không được chứa ký tự đặc biệt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescription.Focus();
                return false;
            }

            // Dates
            if (dtpStartDate.Value >= dtpEndDate.Value)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpStartDate.Focus();
                return false;
            }

            return true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}