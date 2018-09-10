﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyBucksProgram {
    public partial class EditChoreForm : Form {
        private Chore editChore;
        private ChoresDao dao;
        public Chore SavedChore;

        public EditChoreForm(Chore targetChore) {
            editChore = targetChore;

            InitializeComponent();

            SetDefaults();
            ApplyChoreToForm();
        }
        private void SetDefaults() {
            dao = new ChoresDao();
            ChoreFactory factory = new ChoreFactory();
            SavedChore = factory.GenerateEmpty();
        }

        private void ApplyChoreToForm() {
            if (editChore.IsEmpty == false) {
                nameTextbox.Text = editChore.Name;
                descriptionTextbox.Text = editChore.Description;
                valueUpDown.Value = (decimal)editChore.Value;
                isActiveCheckbox.Checked = editChore.IsActive;
            }
            else {
                this.Text = "Create New Chore";
                isActiveCheckbox.Checked = true;
            }
        }

        private void ApplyFormToChore() {
            string preserveKey = editChore.Key;
            editChore = new FamilyChore(nameTextbox.Text, (double)valueUpDown.Value, descriptionTextbox.Text);
            editChore.SetKey(preserveKey);

            if (isActiveCheckbox.Checked)
                editChore.Activate();
            else
                editChore.Inactivate();
        }

        private void SaveChore() {
            ApplyFormToChore();
            dao.Save(editChore);
            SavedChore = editChore.Clone();
        }

        private void ValidateForm() {
            bool valid = true;

            if (String.IsNullOrEmpty(nameTextbox.Text))
                valid = false;

            if (String.IsNullOrEmpty(descriptionTextbox.Text))
                valid = false;

            saveButton.Enabled = valid;
        }

        private void nameTextbox_TextChanged(object sender, EventArgs e) {
            ValidateForm();
        }

        private void descriptionTextbox_TextChanged(object sender, EventArgs e) {
            ValidateForm();
        }

        private void saveButton_Click(object sender, EventArgs e) {
            SaveChore();
            saveButton.Enabled = false;
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }
    }
}
