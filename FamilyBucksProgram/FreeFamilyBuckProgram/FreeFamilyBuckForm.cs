using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyBucksProgram
{
    public partial class FreeFamilyBuckForm : Form
    {
        public BankTransaction ResultTransaction;

        public FreeFamilyBuckForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResultTransaction = new BankTransaction(BankTransactionType.DEPOSIT, 1, "Free Family Buck!");
            MessageBox.Show("Transfer Complete", "1 Family Buck recieved.");
            DialogResult = DialogResult.OK;
        }
    }
}
