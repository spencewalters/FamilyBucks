using System;
using System.Windows.Forms;

namespace FamilyBucksProgram {
    public partial class Administrate : Form {
        public Administrate() {
            InitializeComponent();

            PopulateUsers();
        }

        private void PopulateUsers() {
            UserRecords records = UserCache.Cache;

            foreach(User user in records.All()) {
                AddUserToView(user);
            }
        }

        private void addButton_Click(object sender, EventArgs e) {
            UserFactory factory = new UserFactory();
            EditUserForm form = new EditUserForm(factory.GenerateEmpty());
            form.ShowDialog();

            if (form.SavedUser.IsEmpty == false) {
                AddUserToView(form.SavedUser);
            }
        }

        private void AddUserToView(User savedUser) {
            ListViewItem listviewItem = new ListViewItem(savedUser.Fullname);
            listviewItem.Name = savedUser.ID;
            listviewItem.Tag = savedUser;
            usersListview.Items.Add(listviewItem);
        }

        private void editButton_Click(object sender, EventArgs e) {
            if (usersListview.SelectedItems.Count == 1) {
                ListViewItem listviewitem = usersListview.SelectedItems[0];
                User user = (User)listviewitem.Tag;

                UserFactory factory = new UserFactory();
                EditUserForm form = new EditUserForm(user);
                form.ShowDialog();


                if (form.SavedUser.IsEmpty == false) {
                    UpdateUserInView(form.SavedUser);
                }
            }
        }

        private void UpdateUserInView(User savedUser) {
            User existingUser = (User)usersListview.Items[savedUser.ID].Tag;
            existingUser = savedUser;
        }

        private void closeButton_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }
    }
}
