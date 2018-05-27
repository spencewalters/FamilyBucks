using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

                Authentication authentication = new PinAuthentication();
                Credentials pinCredentials = authentication.GetEmptyCredentials();
                pinCredentials.SetField("Pin", passwordTxt.Text);

                if (authentication.IsValidFor(pinCredentials)) {
                    UserDao dao = new UserDao();
                    LoginUser = dao.LoadUserByPin(pinCredentials.GetField("Pin"));
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
