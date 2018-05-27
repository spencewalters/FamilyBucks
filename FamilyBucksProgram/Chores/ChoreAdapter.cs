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
            lvItem.Tag = _chore;
            lvItem.Name = _chore.Key;
            lvItem.Text = _chore.Name;
            ListViewItem.ListViewSubItem subItem = lvItem.SubItems.Add(new ListViewItem.ListViewSubItem());
            subItem.Text = $"{_chore.Value.ToString("C",new CultureInfo("en-us")) }";
            return lvItem;
        }

        public static Chore ParseChore(ListViewItem lvItem) {
            Chore chore = (Chore)lvItem.Tag;

            return chore;
        }
    }
}
