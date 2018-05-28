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
    }
}
