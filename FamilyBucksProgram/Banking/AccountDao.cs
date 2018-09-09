using System;
using System.IO;

namespace FamilyBucksProgram {
    public class AccountDao {
        private string storagePath = $"{AppDomain.CurrentDomain.BaseDirectory}BankAccount\\";
        private string storageFilenamePrefix = "ACCT";
        private string storageFilenameExtension = "fbf";

        public AccountDao() {
            if (Directory.Exists(storagePath) == false) {
                Directory.CreateDirectory(storagePath);
            }
        }

        private string StorageFilePath(string ID) {
            return $"{storagePath}{storageFilenamePrefix}{ID}.{storageFilenameExtension}";
        }

        public void Save(AccountInformation account) {
            string filename = StorageFilePath(account.Key);
            StreamWriter file = new StreamWriter(filename);
            file.WriteLine(account.Key);
            file.WriteLine(account.AccountBalance.ToString("N3"));
            file.Close();
        }
        
        public AccountInformation Load(string ID) {
            return LoadFromFile(StorageFilePath(ID));
        }

        private AccountInformation LoadFromFile(string filename) {
            AccountInformation account = new AccountInformation();

            if (File.Exists(filename)) {
                StreamReader file = new StreamReader(filename);
                account.SetID(file.ReadLine());
                account.SetBalance(file.ReadLine());
                account.Activate();

                file.Close();

                Console.WriteLine($"Loaded account details for {account.Key}");
            }
            else
                Console.WriteLine("File not found: " + filename);

            return account;
        }

    }
}
