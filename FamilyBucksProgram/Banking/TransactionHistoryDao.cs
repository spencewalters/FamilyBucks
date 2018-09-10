using System;
using System.IO;
using System.Text;

namespace FamilyBucksProgram {
    public class TransactionHistoryDao {
        private string storagePath = FolderHelper.bankaccountHistoryPath;
        private string storageFilenamePrefix = "TXHST";
        private string storageFilenameExtension = "fbf";
        private string StorageFilePath(string ID) {
            return $"{storagePath}{storageFilenamePrefix}{ID}.{storageFilenameExtension}";
        }

        public void Save(TransactionHistory history) {
            string filename = StorageFilePath(history.Key);
            StreamWriter file = new StreamWriter(filename);

            file.WriteLine(history.Key);

            int countWritten = 0;
            foreach (BankTransaction transaction in history.Items) {
                WriteEntry(transaction, file);
                countWritten++;
            }

            file.Close();
            Console.WriteLine($"TX History: Written {countWritten} entries.");
        }

        public TransactionHistory Load(string ID) {
            return LoadFromFile(StorageFilePath(ID), ID);
        }

        private TransactionHistory LoadFromFile(string filename, string ID) {
            TransactionHistory history = new TransactionHistory(ID);

            if (File.Exists(filename)) {
                StreamReader file = new StreamReader(filename);
                history.SetKey(file.ReadLine());
                string entry = file.ReadLine();
                while (String.IsNullOrEmpty(entry) == false) {
                    BankTransaction transaction = ParseEntry(entry);
                    if (transaction.IsActive)
                        history.AddEntry(transaction);

                    entry = file.ReadLine();
                }
                history.Activate();

                file.Close();

                Console.WriteLine($"Loaded history details for {history.Key} (count:{history.Count})");
            }
            else
                Console.WriteLine("File not found: " + filename);

            return history;
        }

        private static BankTransaction ParseEntry(string entry) {
            BankTransaction transaction = new BankTransaction();
            string[] fields = entry.Split(',');
            if (fields.Length >= 4) {
                string key= fields[0].Trim();
                BankTransactionType tranType = (BankTransactionType)Enum.Parse(typeof(BankTransactionType), fields[1]);
                double amount = double.Parse(fields[2]);
                string reason = fields[3].Trim();
                DateTime dateTime = DateTime.Parse(fields[4]);

                transaction = new BankTransaction(tranType, amount, reason);
                transaction.SetKey(key);
                transaction.SetCreationTime(dateTime);
                transaction.Activate();
            }
            return transaction;
        }

        private static void WriteEntry(BankTransaction transaction, StreamWriter file) {
            StringBuilder builder = new StringBuilder();

            builder.Append(transaction.Key);

            builder.Append(",");
            builder.Append(transaction.TransactionType.ToString());

            builder.Append(",");
            builder.Append(transaction.TransactionAmount.ToString("N3"));

            builder.Append(",");
            builder.Append(transaction.ReasonFor);

            builder.Append(",");
            builder.Append(transaction.CreationTime.ToShortDateString());
            builder.Append(" ");
            builder.Append(transaction.CreationTime.ToShortTimeString());
            

            file.WriteLine(builder.ToString());
        }
    }
}
