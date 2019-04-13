using FamilyBucksProgram.Rewards;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FamilyBucksProgram {
    public partial class RewardsForm : Form
    {
        List<Reward> availableRewards = new List<Reward>();

        public RewardsForm()
        {
            InitializeComponent();
            LoadRewards();
            PopulateListview();
        }
        
        private void LoadRewards() {
            RewardDao dao = new RewardDao();
            availableRewards = dao.Load();
        }

        private void PopulateListview() {
            foreach (Reward reward in availableRewards) {
                ListViewItem lvItem = new RewardAdapter(reward).ToListViewItem();
                rewardsLv.Items.Add(lvItem);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void rewardsLv_DoubleClick(object sender, EventArgs e) {
            OpenSelected();
        }

        private void OpenSelected() {
            try {
                if (rewardsLv.SelectedItems.Count == 1) {
                    ListViewItem item = rewardsLv.SelectedItems[0];
                    Reward reward = (Reward)item.Tag;

                    // ShowReward form = new ShowReward(reward);
                    // form.ShowDialog();
                    throw new NotImplementedException();
                }
            }catch(Exception exception) {
                ExceptionHandler.RespondTo(exception, "Problem encountered while opening reward - try again!");
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            OpenSelected();
        }
    }
}
