using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FamilyBucksProgram {
    public class ChoresDao {
        private string storagePath = FolderHelper.choresPath;
        private Type UseType = typeof(FamilyChore);
        private string storageFilenamePrefix = "CHR";
        private string storageFilenameExtension = "fbf";
        private ChoreFactory factory = new ChoreFactory();

        private string StorageFilePath() {
            return $"{storagePath}{storageFilenamePrefix}{UseType.Name}.{storageFilenameExtension}";
        }

        public ChoresDao() {
            if (Directory.Exists(storagePath) == false) {
                Directory.CreateDirectory(storagePath);
            }
        }

        public void Save(Chore chore) {
            List<Chore> list = Load();
            List<Chore> newList = new List<Chore>();

            newList.Add(chore);
            foreach(Chore entry in list) {
                if (entry.Key != chore.Key) {
                    newList.Add(entry);
                }
            }

            Save(newList);
        }

        public void Save(List<Chore> chores) {
            string filename = StorageFilePath();
            StreamWriter file = new StreamWriter(filename);

            foreach (Chore chore in chores) {
                WriteEntry(chore, file);
            }

            file.Close();
        }

        public List<Chore> Load() {
            return LoadFromFile(StorageFilePath());
        }

        private List<Chore> LoadFromFile(string filename) {
            List<Chore> list = new List<Chore>();

            if (File.Exists(filename)) {
                StreamReader file = new StreamReader(filename);
                string entry = file.ReadLine();
                while (String.IsNullOrEmpty(entry) == false) {
                    Chore chore = ParseEntry(entry);
                    if (chore.IsActive)
                        list.Add(chore);

                    entry = file.ReadLine();
                }

                file.Close();
            }
            else
                Console.WriteLine("File not found: " + filename);

            return list;
        }

        private Chore ParseEntry(string entry) {
            Chore chore = factory.GenerateEmpty();

            string[] fields = entry.Split(',');
            if (fields.Length >= 4) {
                string key = fields[0].Trim();
                string name = fields[1].Trim();
                double value = double.Parse(fields[2]);
                string description = fields[3].Trim();

                chore = new FamilyChore(name, value, description);
                chore.SetKey(key);
            }

            return chore;
        }

        public void Delete(string key) {
            List<Chore> list = Load();
            List<Chore> newList = new List<Chore>();
            foreach(Chore chore in list) {
                if (chore.Key != key) {
                    newList.Add(chore);
                }
            }

            Save(newList);
        }

        private static void WriteEntry(Chore chore, StreamWriter file) {
            StringBuilder builder = new StringBuilder();

            builder.Append(chore.Key);

            builder.Append(",");
            builder.Append(chore.Name);

            builder.Append(",");
            builder.Append(chore.Value.ToString("N3"));

            builder.Append(",");
            builder.Append(chore.Description);

            file.WriteLine(builder.ToString());
        }
    }
}
