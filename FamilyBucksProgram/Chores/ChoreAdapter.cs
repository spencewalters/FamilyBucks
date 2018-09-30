using System;
using System.Globalization;
using System.Windows.Forms;

namespace FamilyBucksProgram {
    public class ChoreAdapter {
        private Chore _chore;

        public ChoreAdapter(Chore chore) {
            _chore = chore;
        }

        public ListViewItem ToListViewItem() {
            ListViewItem lvItem = new ListViewItem();
            ConvertTo(lvItem);

            return lvItem;
        }

        private void ConvertTo(ListViewItem lvItem) {
            lvItem.Tag = _chore;
            lvItem.Name = _chore.Key;
            lvItem.Text = _chore.Name;

            ListViewItem.ListViewSubItem subItem = lvItem.SubItems.Add(new ListViewItem.ListViewSubItem());
            subItem.Text = $"{_chore.Value.ToString("C", new CultureInfo("en-us")) }";

            ListViewItem.ListViewSubItem subItem2 = lvItem.SubItems.Add(new ListViewItem.ListViewSubItem());
            subItem2.Text = $"{_chore.Description}";
        }

        public static Chore ParseChore(ListViewItem lvItem) {
            Chore chore = (Chore)lvItem.Tag;

            return chore;
        }

        internal void Update(ListViewItem listviewitem) {
            ConvertTo(listviewitem);
        }
    }
}
