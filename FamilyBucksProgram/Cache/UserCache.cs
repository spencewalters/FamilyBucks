using System;

namespace FamilyBucksProgram {
    public static class UserCache {
        private static UserRecords cache = new UserRecords();

        public static UserRecords Cache{ get=> GetCache(); }

        private static void InitializeCache() {
            if (cache.Count == 0)
                Refresh();
        }

        private static void Refresh() {            
            cache.Refresh();
        }

        private static UserRecords GetCache() {
            InitializeCache();
            return cache;
        }

        public static User PINLookup(string pin) {
            InitializeCache();
            return cache.PINLookup(pin);
        }

        public static int Count() {
            InitializeCache();
            return cache.Count;
        }

        public static int AdminCount() {
            InitializeCache();
            return cache.AdminCount;
        }

    }
}
