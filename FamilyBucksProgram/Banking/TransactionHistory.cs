using System;
using System.Collections.Generic;

namespace FamilyBucksProgram {
    public class TransactionHistory {
        private string _key;
        private List<BankTransaction> history;
        private GeneralState state = GeneralState.EMPTY;

        public string Key { get => _key; }
        public void SetKey(string key) { _key = key; }
        public List<BankTransaction> Items => history;
        public int Count => history.Count;

        public bool IsActive { get => state == GeneralState.ACTIVE; }
        public bool IsInactive { get => state == GeneralState.INACTIVE; }
        public bool IsEmpty { get => state == GeneralState.EMPTY; }
        public void Activate() { state = GeneralState.ACTIVE; }
        public void Inactivate() { state = GeneralState.INACTIVE; }
        public void Destroy() { state = GeneralState.EMPTY; }

        public TransactionHistory(string accountKey) {
            _key = accountKey;
            history = new List<BankTransaction>();
        }

        public void AddEntry(BankTransaction entry) {
            history.Add(entry);
        }
    }
}
