using System;
using System.Windows.Forms;

namespace FamilyBucksProgram {
    public partial class EditUserForm : Form {
        private User editUser;
        public User SavedUser;

        public EditUserForm(User targetUser) {
            editUser = targetUser;

            InitializeComponent();

            SetDefaults();
            ApplyUserToForm();
        }

        private void SetDefaults() {
            UserFactory factory = new UserFactory();
            SavedUser = factory.GenerateEmpty();
        }

        private void ApplyUserToForm() {
            if (editUser.IsEmpty == false) {
                usernameTextbox.Text = editUser.Username;
                usernameTextbox.ReadOnly = true;
                nameTextbox.Text = editUser.Fullname;
                pinTextbox.Text = editUser.Pin;
                isAdminCheckbox.Checked = editUser.IsAnAdmin;
                isActiveCheckbox.Checked = editUser.IsActive;
            }
            else {
                this.Text = "Create New User";
                isActiveCheckbox.Checked = true;
            }
        }

        private void SaveUser() {
            UserRecords records = UserCache.Records;
            records.Save(editUser);
            SavedUser = editUser.Clone();
        }

        private void ApplyFormToUser() {
            editUser.SetUsername(usernameTextbox.Text);
            editUser.SetFullname(nameTextbox.Text);
            editUser.Pin = pinTextbox.Text;
            if (isActiveCheckbox.Checked)
                editUser.Activate();
            else
                editUser.Inactivate();
            editUser.SetAsAdmin(isAdminCheckbox.Checked.ToString());
        }

        private void nameTextbox_TextChanged(object sender, EventArgs e) {
            ValidateForm();
        }

        private void pinTextbox_TextChanged(object sender, EventArgs e) {
            ValidateForm();
        }

        private void passwordTextbox_TextChanged(object sender, EventArgs e) {
            ValidateForm();
        }

        private void isAdminCheckbox_CheckedChanged(object sender, EventArgs e) {
            ValidateForm();
        }

        private void isActiveCheckbox_CheckedChanged(object sender, EventArgs e) {
            ValidateForm();
        }

        private void ValidateForm() {
            bool valid = true;

            if (String.IsNullOrEmpty(usernameTextbox.Text))
                valid = false;

            if (String.IsNullOrEmpty(nameTextbox.Text))
                valid = false;

            if (String.IsNullOrEmpty(pinTextbox.Text))
                valid = false;

            saveButton.Enabled = valid;
        }

        private void saveButton_Click(object sender, EventArgs e) {
            saveButton.Enabled = false;
            ApplyFormToUser();
            SaveUser();
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private void usernameTextbox_TextChanged(object sender, EventArgs e) {
            ValidateForm();
        }
    }
}
