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
    public partial class AdministrateForm : Form {
        public AdministrateForm() {
            InitializeComponent();
        }

        private void usersButton_Click(object sender, EventArgs e) {
            AdministrateUsersForm form = new AdministrateUsersForm();
            form.ShowDialog();
        }

        private void choresButton_Click(object sender, EventArgs e) {
            AdministrateChoresForm form = new AdministrateChoresForm();
            form.ShowDialog();
        }

        private void rewardsButton_Click(object sender, EventArgs e) {
            AdministrateRewardsForm form = new AdministrateRewardsForm();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }
    }
}
