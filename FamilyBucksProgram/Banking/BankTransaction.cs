using System;

namespace FamilyBucksProgram {
    public class BankTransaction : FamilyData {
        private BankTransactionType _transactionType;
        private double _transactionAmount;
        private string _reasonFor;
        private string _key;
        private GeneralState state = GeneralState.EMPTY;
        private DateTime _creationTime;

        public BankTransactionType TransactionType { get => _transactionType; }
        public double TransactionAmount { get => _transactionAmount; }
        public string ReasonFor { get => _reasonFor; }

        public string Key { get => _key; }
        public bool IsActive { get => state == GeneralState.ACTIVE; }
        public bool IsInactive { get => state == GeneralState.INACTIVE; }
        public bool IsEmpty { get => state == GeneralState.EMPTY; }
        public DateTime CreationTime { get=>_creationTime;}
        public static BankTransaction Empty { get => new BankTransaction(BankTransactionType.NONE, 0, "Empty"); }

        public void Activate() { state = GeneralState.ACTIVE; }
        public void Inactivate() { state = GeneralState.INACTIVE; }
        public void Destroy() { state = GeneralState.EMPTY; }

        public BankTransaction() { }

        public BankTransaction(BankTransactionType transactionType, double amount, string reasonFor) {
            _transactionAmount = amount;
            _transactionType = transactionType;
            _reasonFor = reasonFor;
            _key = Guid.NewGuid().ToString();
            _creationTime = DateTime.Now;            
        }

        public void SetKey(string key) {
            _key = key;
        }

        public void SetCreationTime(DateTime dateTime) {
            _creationTime = dateTime;
        }
    }
}