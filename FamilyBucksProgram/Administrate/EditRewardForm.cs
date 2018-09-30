using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyBucksProgram {
    public partial class EditRewardForm : Form {
        private Reward reward;
        private RewardDao dao;
        private RewardFactory factory;

        public Reward SavedReward;

        public EditRewardForm(Reward reward) {
            this.reward = reward;

            InitializeComponent();

            SetupDefaults();
            PopulateFromReward();
        }

        private void SetupDefaults() {
            dao = new RewardDao();
            factory = new RewardFactory();
            SavedReward = RewardFactory.Empty;
        }

        private void PopulateFromReward() {
            choreNameTextbox.Text = reward.Name;
            descriptionTextbox.Text = reward.Description;
            priceUpDown.Value = (Decimal)reward.Price;
            isActiveCheckbox.Checked = reward.IsActive;
        }

        private void UpdateReward() {
            string preserveKey = reward.Key;
            reward = factory.Generate(choreNameTextbox.Text, descriptionTextbox.Text, (Double)priceUpDown.Value);
            reward.SetKey(preserveKey);

            if (isActiveCheckbox.Checked)
                reward.Activate();
            else
                reward.Inactivate();
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private void choreNameTextbox_TextChanged(object sender, EventArgs e) {
            ChangeMade();
        }

        private void descriptionTextbox_TextChanged(object sender, EventArgs e) {
            ChangeMade();

        }

        private void priceUpDown_ValueChanged(object sender, EventArgs e) {
            ChangeMade();
        }

        private void ChangeMade() {
            if (FormIsValid())
                saveButton.Enabled = true;
            else
                saveButton.Enabled = false;
        }

        private bool FormIsValid() {
            bool valid = true;

            valid &= FormHelper.TextFieldIsValid(choreNameTextbox.Text);
            valid &= FormHelper.TextFieldIsValid(descriptionTextbox.Text);

            return valid;
        }

        private void saveButton_Click(object sender, EventArgs e) {
            SaveReward();
            saveButton.Enabled = false;
        }

        private void SaveReward() {
            UpdateReward();
            
            dao.Save(reward);
            SavedReward = reward.Clone();
        }
    }
}
