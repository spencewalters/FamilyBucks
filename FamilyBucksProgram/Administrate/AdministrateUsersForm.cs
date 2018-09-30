using System;
using System.Drawing;
using System.Windows.Forms;

namespace FamilyBucksProgram {
    public partial class AdministrateUsersForm : Form {
        private string defaultImageKey = "default_user_image";

        public AdministrateUsersForm() {
            InitializeComponent();

            SetupListViewImages();
            PopulateUsers();
            UpdateButtons();
        }

        private void SetupListViewImages() {
            Image defaultImage = Properties.Resources.user;
            ImageList imageList = new ImageList();
            
            imageList.Images.Add(defaultImageKey, defaultImage);
            usersListview.LargeImageList = imageList;
            usersListview.SmallImageList = imageList;
        }

        private void PopulateUsers() {
            UserRecords records = UserCache.Records;

            foreach (User user in records.ToList()) {
                AddUserToView(user);
            }
        }

        private void addButton_Click(object sender, EventArgs e) {
            UserFactory factory = new UserFactory();
            EditUserForm form = new EditUserForm(UserFactory.Empty);
            form.ShowDialog();

            if (form.SavedUser.IsEmpty == false) {
                AddUserToView(form.SavedUser);
            }
        }

        private void AddUserToView(User savedUser) {
            ListViewItem listviewItem = new ListViewItem(savedUser.Fullname);
            listviewItem.Name = savedUser.ID;
            listviewItem.Tag = savedUser;
            listviewItem.ImageKey = defaultImageKey;
            usersListview.Items.Add(listviewItem);
        }

        private void editButton_Click(object sender, EventArgs e) {
            EditSelected();
        }

        private void EditSelected() {
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

        private void deleteButton_Click(object sender, EventArgs e) {
            if (usersListview.SelectedItems.Count == 1) {
                ListViewItem listviewitem = usersListview.SelectedItems[0];
                User user = (User)listviewitem.Tag;

                DialogResult result = MessageBox.Show($"Are you sure you want to delete {user.Fullname}'s account?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) {
                    UserRecords records = UserCache.Records;
                    records.Delete(user.ID);
                    usersListview.Items.RemoveByKey(user.ID);
                }
            }
        }

        private void usersListview_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateButtons();
        }

        private void UpdateButtons() {
            if (usersListview.SelectedIndices.Count > 0) {
                editButton.Enabled = true;
                deleteButton.Enabled = true;
            }
            else {
                editButton.Enabled = false;
                deleteButton.Enabled = false;
            }
        }

        private void usersListview_DoubleClick(object sender, EventArgs e) {
            EditSelected();
        }
    }
}
