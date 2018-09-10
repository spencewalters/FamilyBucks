using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FamilyBucksProgram {
    public partial class AdministrateRewardsForm : Form {
        RewardDao dao = new RewardDao();

        public AdministrateRewardsForm() {
            InitializeComponent();
            Populate();
            UpdateButtons();
        }


        private void UpdateButtons() {
            if (rewardsListview.SelectedIndices.Count > 0) {
                editButton.Enabled = true;
                deleteButton.Enabled = true;
            }
            else {
                editButton.Enabled = false;
                deleteButton.Enabled = false;
            }
        }

        private void Populate() {
            List<Reward> rewards = dao.Load();

            foreach (Reward reward in rewards) {
                AddRewardToListview(reward);
            }
        }

        private void AddRewardToListview(Reward reward) {
            ListViewItem listviewItem = new ListViewItem(reward.Description);
            listviewItem.Name = reward.Key;
            listviewItem.Tag = reward;
            rewardsListview.Items.Add(listviewItem);
        }

        private void closeButton_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }
    }
}
