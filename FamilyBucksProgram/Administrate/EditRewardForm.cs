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
    public partial class EditRewardForm : Form {
        public EditRewardForm() {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private void usernameTextbox_TextChanged(object sender, EventArgs e) {

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

    }
}
