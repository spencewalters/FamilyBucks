using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FamilyBucksProgram {
    public partial class ParentalSignoff : Form {
        public ParentalSignoff(User user, List<Chore> chores) {
            InitializeComponent();

            questionLabel.Text = questionLabel.Text.Replace("$NAME", user.Fullname);
            PopulateListWith(chores);
            UpdateTotalLabel(chores);
        }

        private void UpdateTotalLabel(List<Chore> chores) {
            double total = 0;
            foreach (Chore chore in chores) {
                total += chore.Value;
            }
            totalLabel.Text = $"Total: { total.ToString("N2")}";
        }

        private void PopulateListWith(List<Chore> chores) {

            foreach (Chore chore in chores) {
                ListViewItem lvItem = new ChoreAdapter(chore).ToListViewItem();
                completedLv.Items.Add(lvItem);
            }
        }

        private void notYetButton_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.No;
        }

        private void yesButton_Click(object sender, EventArgs e) {
            bool requestApproved = false;

            LoginForm loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK) {
                User user = loginForm.LoginUser;
                if ((user.IsActive) && (user.IsAnAdmin))
                    requestApproved = true;
            }

            if (requestApproved)
                DialogResult = DialogResult.Yes;
        }
    }
}
