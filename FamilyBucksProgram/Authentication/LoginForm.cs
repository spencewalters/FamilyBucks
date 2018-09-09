using System;
using System.Windows.Forms;

namespace FamilyBucksProgram {
    public partial class LoginForm : Form {
        public User LoginUser = new User();

        public LoginForm() {
            InitializeComponent();

            FocusOnPINTextbox();
        }

        private void FocusOnPINTextbox() {
            this.ActiveControl = passwordTxt;
        }

        private void button1_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private void button2_Click(object sender, EventArgs e) {
            SubmitLogin();
        }

        private void passwordTxt_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                e.Handled = true;
                e.SuppressKeyPress = true;
                SubmitLogin();
            }
        }

        private void SubmitLogin() {
            ProcessLoginCredentials();
            UpdateFormResponseToLogin();
        }

        private void ProcessLoginCredentials() {
            if (String.IsNullOrWhiteSpace(passwordTxt.Text) == false) {
                string pin = passwordTxt.Text;

                Authentication authentication = new PinAuthentication();
                authentication.SetUsers(UserCache.Records);
                Credentials pinCredentials = authentication.GetEmptyCredentials();
                pinCredentials.Secret = pin;

                if (authentication.IsValidFor(pinCredentials)) {
                    UserDaoFactory daoFactory = new UserDaoFactory();
                    UserDao dao = daoFactory.GenerateDao();
                    LoginUser = UserCache.PINLookup(pin);
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void UpdateFormResponseToLogin() {
            if (LoginUser.IsActive)
                incorrectPinLabel.Visible = false;
            else
                incorrectPinLabel.Visible = true;
        }
    }
}
