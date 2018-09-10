using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FamilyBucksProgram {
    public partial class AdministrateChoresForm : Form {
        ChoresDao dao = new ChoresDao();

        public AdministrateChoresForm() {
            InitializeComponent();

            Populate();
            UpdateButtons();
        }


        private void UpdateButtons() {
            if (choresListview.SelectedIndices.Count > 0) {
                editButton.Enabled = true;
                deleteButton.Enabled = true;
            }
            else {
                editButton.Enabled = false;
                deleteButton.Enabled = false;
            }
        }

        private void Populate() {
            List<Chore> chores = dao.Load();

            foreach (Chore chore in chores) {
                AddChoreToView(chore);
            }
        }

        private void AddChoreToView(Chore chore) {
            ListViewItem listviewItem = new ListViewItem(chore.Description);
            listviewItem.Name = chore.Key;
            listviewItem.Tag = chore;
            choresListview.Items.Add(listviewItem);
        }

        private void closeButton_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private void addButton_Click(object sender, EventArgs e) {
            EditChoreForm form = new EditChoreForm(new FamilyChore());
            form.ShowDialog();

            if (form.SavedChore.IsEmpty == false) {
                AddChoreToView(form.SavedChore);
            }
        }

        private void editButton_Click(object sender, EventArgs e) {
            EditSelected();
        }

        private void deleteButton_Click(object sender, EventArgs e) {
            if (choresListview.SelectedItems.Count == 1) {
                ListViewItem listviewitem = choresListview.SelectedItems[0];
                Chore chore = (Chore)listviewitem.Tag;

                DialogResult result = MessageBox.Show($"Are you sure you want to delete {chore.Name}?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) {
                    dao.Delete(chore.Key);
                    choresListview.Items.RemoveByKey(chore.Key);
                }
            }
        }

        private void EditSelected() {
            if (choresListview.SelectedItems.Count == 1) {
                ListViewItem listviewitem = choresListview.SelectedItems[0];
                Chore chore = (Chore)listviewitem.Tag;

                EditChoreForm form = new EditChoreForm(chore);
                form.ShowDialog();

                if (form.SavedChore.IsEmpty == false) {
                    UpdateChoreInView(form.SavedChore);
                }
            }
        }

        private void UpdateChoreInView(Chore savedChore) {
            Chore existingChore = (Chore)choresListview.Items[savedChore.Key].Tag;
            existingChore = savedChore;
        }

        private void choresListview_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateButtons();
        }

        private void choresListview_DoubleClick(object sender, EventArgs e) {
            EditSelected();
        }
    }
}
