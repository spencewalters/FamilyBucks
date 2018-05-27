using System;

namespace FamilyBucksProgram {
    public class AccountInformation : FamilyData {
        private string accountID;
        private double accountBalance = 0;
        private GeneralState state = GeneralState.EMPTY;

        public string Key { get => accountID; }
        public double AccountBalance { get => accountBalance; }
        public string FormattedAccountBalance { get => accountBalance.ToString("N2"); }

        public bool IsActive { get => state == GeneralState.ACTIVE; }
        public bool IsInactive { get => state == GeneralState.INACTIVE; }
        public bool IsEmpty { get => state == GeneralState.EMPTY; }
        public void Activate() { state = GeneralState.ACTIVE; }
        public void Inactivate() { state = GeneralState.INACTIVE; }
        public void Destroy() { state = GeneralState.EMPTY; }

        public AccountInformation() {
            accountID = Guid.NewGuid().ToString();
        }

        private void Initialize() {
            accountBalance = 0;
        }

        public void Deposit(double amount) {
            accountBalance += amount;         
        }

        public void Withdraw(double amount) {
            if (amount > accountBalance) {
                throw new InvalidOperationException("Not enough Family Bucks remaining for withdrawal");
            }

            accountBalance -= amount;                        
        }

        internal void SetID(string ID) {
            accountID = ID;
        }

        internal void SetBalance(string balance) {
            accountBalance = double.Parse(balance);
        }
    }
}
