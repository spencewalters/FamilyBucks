using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBucksProgram {
    public static class FolderHelper {

        public static readonly string bankaccountPath = $"{AppDomain.CurrentDomain.BaseDirectory}BankAccount\\";
        public static readonly string bankaccountHistoryPath = $"{AppDomain.CurrentDomain.BaseDirectory}BankAccount\\History\\";
        public static readonly string choresPath = $"{AppDomain.CurrentDomain.BaseDirectory}Chores\\";
        public static readonly string playHistoryPath = $"{AppDomain.CurrentDomain.BaseDirectory}History\\";
        public static readonly string rewardsPath = $"{AppDomain.CurrentDomain.BaseDirectory}Rewards\\";
        public static readonly string userPath = $"{AppDomain.CurrentDomain.BaseDirectory}Users\\";

        public static void CreateProjectFolders() {
            CreateIfMissing(bankaccountPath);
            CreateIfMissing(bankaccountHistoryPath);
            CreateIfMissing(choresPath);
            CreateIfMissing(playHistoryPath);
            CreateIfMissing(rewardsPath);
            CreateIfMissing(userPath);
        }

        private static void CreateIfMissing(string path) {
            if (Directory.Exists(path) == false) {
                Directory.CreateDirectory(path);
            }
        }
    }
}
