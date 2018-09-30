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
            RewardAdapter adapter = new RewardAdapter(reward);

            rewardsListview.Items.Add(adapter.ToListViewItem());
        }

        private void closeButton_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private void addButton_Click(object sender, EventArgs e) {
            RewardFactory factory = new RewardFactory();
            Reward newReward = factory.Generate("", "", 10.00);
            EditRewardForm form = new EditRewardForm(newReward);
            form.ShowDialog();

            if (form.SavedReward.IsEmpty == false) {
                AddRewardToListview(form.SavedReward);
            }
        }

        private void rewardsListview_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateButtons();
        }

        private void deleteButton_Click(object sender, EventArgs e) {
            if (rewardsListview.SelectedItems.Count == 1) {
                Reward selected = GetSelected();

                DialogResult result = MessageBox.Show($"Are you sure you want to delete this reward: {selected.Name}", "DELETE",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes) {

                    dao.Delete(selected.Key);
                    rewardsListview.Items.RemoveByKey(selected.Key);
                }
            }
        }

        private Reward GetSelected() {
            ListViewItem listviewitem = rewardsListview.SelectedItems[0];
            Reward selected = (Reward)listviewitem.Tag;
            return selected;
        }

        private Reward GetByKey(string key) {
            ListViewItem listviewitem = rewardsListview.SelectedItems[key];
            return (Reward)listviewitem.Tag;
        }

        private void editButton_Click(object sender, EventArgs e) {
            EditSelected();
        }

        private void EditSelected() {
            if (rewardsListview.SelectedItems.Count == 1) {
                Reward selected = GetSelected();
                EditRewardForm form = new EditRewardForm(selected);
                form.ShowDialog();
                if (form.SavedReward.IsEmpty == false) {
                    UpdateInListView(form.SavedReward);
                }
            }
        }

        private void UpdateInListView(Reward savedReward) {
            ListViewItem listviewitem = rewardsListview.Items[savedReward.Key];
            RewardAdapter adapter = new RewardAdapter(savedReward);
            adapter.Update(listviewitem);
        }

        private void rewardsListview_DoubleClick(object sender, EventArgs e) {
            EditSelected();
        }

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
        (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    }
}
