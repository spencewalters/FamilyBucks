using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace FamilyBucksProgram {
    public partial class ChoresCompletion : Form
    {
        private double talliedTotal;
        private User _user;
        private List<Chore> availableChores = new List<Chore>();

        public BankTransaction ResultTransaction { get; internal set; }

        public ChoresCompletion(User user) {
            ResultTransaction = BankTransaction.Empty;
            _user = user;

            InitializeComponent();

            LoadAvailableChores();
            PopulateListView();
            UpdateTotal(0);
        }

        private void LoadAvailableChores() {

            availableChores.Add(new FamilyChore("Prepared a family meal", 2.50));
            availableChores.Add(new FamilyChore("Cleaned my room", 2.00));
            availableChores.Add(new FamilyChore("Fed and watered Diamond", 0.50));
            availableChores.Add(new FamilyChore("Laundered my clothing", 1.00));
        }

        private void PopulateListView() {
            foreach (Chore chore in availableChores) {
                choresLv.Items.Add(new ChoreAdapter(chore).ToListViewItem());
            }
        }

        private double TallySelectedChores() {
            double talliedtotal = 0;

            foreach(ListViewItem lvItem in choresLv.SelectedItems) {
                Chore chore = ChoreAdapter.ParseChore(lvItem);
                talliedtotal += chore.Value;
            }

            return talliedtotal;
        }

        private void choresLv_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateTotalBasedOnSelections();
        }

        private void UpdateTotalBasedOnSelections() {
            talliedTotal = TallySelectedChores();
            UpdateTotal(talliedTotal);
        }

        private void UpdateTotal(double total) {
            totalLbl.Text = $"Total:  {total.ToString("C", new CultureInfo("en-us"))}";
        }

        private void button1_Click(object sender, EventArgs e) {
            ParentalSignoff signoff = new ParentalSignoff(_user, SelectedChores());
            
            if (signoff.ShowDialog() == DialogResult.Yes) {
                StringBuilder choreNamesBuilder = new StringBuilder();
                foreach (Chore chore in SelectedChores()) {
                    choreNamesBuilder.Append(chore.Name);
                    choreNamesBuilder.Append(";");
                }

                string choresCompletedReason = $"Chores completed:{choreNamesBuilder.ToString()}";
                ResultTransaction = new BankTransaction(BankTransactionType.DEPOSIT, talliedTotal, choresCompletedReason);
                DialogResult = DialogResult.OK;
            }
        }

        private List<Chore> SelectedChores() {
            List<Chore> selected = new List<Chore>();

            foreach (ListViewItem lvItem in choresLv.SelectedItems) {
                Chore chore = ChoreAdapter.ParseChore(lvItem);
                selected.Add(chore);
            }

            return selected;
        }

        private void button2_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }
    }
}
