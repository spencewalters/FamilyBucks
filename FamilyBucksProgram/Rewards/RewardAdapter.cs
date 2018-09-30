using System;
using System.Globalization;
using System.Windows.Forms;

namespace FamilyBucksProgram {
    public class RewardAdapter {
        private Reward _reward;

        public RewardAdapter(Reward reward) {
            _reward = reward;
        }

        public ListViewItem ToListViewItem() {
            ListViewItem lvItem = new ListViewItem();
            ConvertTo(lvItem);

            return lvItem;
        }

        public static Reward ParseReward(ListViewItem lvItem) {
            Reward reward = (Reward)lvItem.Tag;

            return reward;
        }

        private void ConvertTo(ListViewItem lvItem) {
            lvItem.Tag = _reward;
            lvItem.Name = _reward.Key;
            lvItem.Text = _reward.Name;

            ListViewItem.ListViewSubItem subItem = lvItem.SubItems.Add(new ListViewItem.ListViewSubItem());
            subItem.Text = $"{_reward.Price.ToString("C", new CultureInfo("en-us")) }";

            ListViewItem.ListViewSubItem subItem2 = lvItem.SubItems.Add(new ListViewItem.ListViewSubItem());
            subItem2.Text = $"{_reward.Description}";
        }

        internal void Update(ListViewItem existing) {
            ConvertTo(existing);
        }
    }
}
