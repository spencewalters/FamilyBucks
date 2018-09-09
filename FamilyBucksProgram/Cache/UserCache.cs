using System;

namespace FamilyBucksProgram {
    public static class UserCache {
        private static UserRecords cachedRecords = new UserRecords();

        public static UserRecords Records{ get=> GetRecords(); }

        private static void InitializeCache() {
            if (cachedRecords.Count == 0)
                Refresh();
        }

        private static void Refresh() {            
            cachedRecords.Refresh();
        }

        private static UserRecords GetRecords() {
            InitializeCache();
            return cachedRecords;
        }

        public static User PINLookup(string pin) {
            InitializeCache();
            return cachedRecords.PINLookup(pin);
        }

        public static int Count() {
            InitializeCache();
            return cachedRecords.Count;
        }

        public static int AdminCount() {
            InitializeCache();
            return cachedRecords.AdminCount;
        }

    }
}
