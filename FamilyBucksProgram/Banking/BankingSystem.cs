using System;

namespace FamilyBucksProgram {
    public class BankingSystem {
        AccountInformation _account;
        AccountDao dao = new AccountDao();

        public BankingSystem(AccountInformation account) {
            _account = account;
        }

        private void DepositFamilyBucks(double amount) {
            _account.Deposit(amount);
            dao.Save(_account);
            Console.WriteLine(String.Format("{0} Fb deposited.", amount.ToString("N3")));
        }

        private void WithdrawFamilyBucks(double amount) {
            _account.Withdraw(amount);
            dao.Save(_account);
            Console.WriteLine(String.Format("{0} Fb withdrawn.", amount.ToString("N3")));
        }

        public void ProcessTransaction(BankTransaction transaction) {
            FinalizeTransaction(transaction);
            RecordToHistory(transaction);
        }

        private void FinalizeTransaction(BankTransaction transaction) {
            switch (transaction.TransactionType) {
                case BankTransactionType.NONE:
                    break;
                case BankTransactionType.WITHDRAW:
                    WithdrawFamilyBucks(transaction.TransactionAmount);
                    break;
                case BankTransactionType.DEPOSIT:
                    DepositFamilyBucks(transaction.TransactionAmount);
                    break;
                default:
                    break;
            }
        }

        private void RecordToHistory(BankTransaction transaction) {
            if (transaction.TransactionType != BankTransactionType.NONE) {
                TransactionHistoryDao historyDao = new TransactionHistoryDao();
                TransactionHistory history = historyDao.Load(_account.Key);
                history.AddEntry(transaction);
                historyDao.Save(history);
            }
        }
    }
}
