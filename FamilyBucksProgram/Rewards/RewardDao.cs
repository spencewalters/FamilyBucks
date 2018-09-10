using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FamilyBucksProgram {
    public class RewardDao {
        private string storagePath = FolderHelper.rewardsPath;
        private Type UseType = typeof(InGameReward);
        private string storageFilenamePrefix = "RWD";
        private string storageFilenameExtension = "fbf";
        private string StorageFilePath() {
            return $"{storagePath}{storageFilenamePrefix}{UseType.Name}.{storageFilenameExtension}";
        }

        public void Save(List<Reward> rewards) {
            string filename = StorageFilePath();
            StreamWriter file = new StreamWriter(filename);

            foreach (Reward reward in rewards) {
                WriteEntry(reward, file);
            }

            file.Close();
        }

        public List<Reward> Load() {
            return LoadFromFile(StorageFilePath());
        }

        private List<Reward> LoadFromFile(string filename) {
            List<Reward> list = new List<Reward>();

            if (File.Exists(filename)) {
                StreamReader file = new StreamReader(filename);
                string entry = file.ReadLine();
                while (String.IsNullOrEmpty(entry) == false) {
                    Reward Reward = ParseEntry(entry);
                    if (Reward.IsActive)
                        list.Add(Reward);

                    entry = file.ReadLine();
                }

                file.Close();
            }
            else
                Console.WriteLine("File not found: " + filename);

            return list;
        }

        private Reward EmptyReward() {
            return new InGameReward();
        }

        private Reward ParseEntry(string entry) {
            Reward reward = EmptyReward();
            string[] fields = entry.Split(',');
            if (fields.Length >= 4) {
                string key = fields[0].Trim();
                string name = fields[1].Trim();
                double value = double.Parse(fields[2]);
                string description = fields[3].Trim();

                reward = new InGameReward(name, value, description);
                reward.SetKey(key);
            }
            return reward;
        }

        private static void WriteEntry(Reward Reward, StreamWriter file) {
            StringBuilder builder = new StringBuilder();

            builder.Append(Reward.Key);

            builder.Append(",");
            builder.Append(Reward.Name);

            builder.Append(",");
            builder.Append(Reward.Price.ToString("N3"));

            builder.Append(",");
            builder.Append(Reward.Description);

            file.WriteLine(builder.ToString());
        }
    }
}
