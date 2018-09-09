using System;
using System.IO;

namespace FamilyBucksProgram {
    public class PlayHistoryDao {
        private string storagePath = $"{AppDomain.CurrentDomain.BaseDirectory}History\\";
        private string storageFilenamePrefix = "PLHST";
        private string storageFilenameExtension = "fbf";

        public PlayHistoryDao() {
            if (Directory.Exists(storagePath) == false) {
                Directory.CreateDirectory(storagePath);
            }
        }
        private string StorageFilePath(string ID) {
            return $"{storagePath}{storageFilenamePrefix}{ID}.{storageFilenameExtension}";
        }

        public void Save(PlayHistory history) {
            string filename = StorageFilePath(history.Key);
            StreamWriter file = new StreamWriter(filename);
            file.WriteLine(history.Key);
            foreach (ProgramAndTime pair in history.Items)
                WriteEntry(pair, file);

            file.Close();
        }

        public PlayHistory Load(string ID) {
            return LoadFromFile(StorageFilePath(ID));
        }

        private PlayHistory LoadFromFile(string filename) {
            PlayHistory history = new PlayHistory();

            if (File.Exists(filename)) {
                StreamReader file = new StreamReader(filename);
                history.SetKey(file.ReadLine());
                string entry = file.ReadLine();
                while (String.IsNullOrEmpty(entry) == false) {
                    ProgramAndTime pair = ReadEntry(entry);
                    if (pair.IsActive)
                        history.AddEntry(pair);

                    entry = file.ReadLine();
                }
                history.Activate();

                file.Close();

                Console.WriteLine($"Loaded history details for {history.Key}");
            }
            else
                Console.WriteLine("File not found: " + filename);

            return history;
        }

        private static ProgramAndTime ReadEntry(string entry) {
            ProgramAndTime pair = new ProgramAndTime();
            string[] fields = entry.Split(',');
            if (fields.Length == 2) {
                pair.programID = fields[0].Trim();
                pair.playDate = DateTime.Parse(fields[1]);
            }
            return pair;
        }

        private static void WriteEntry(ProgramAndTime pair, System.IO.StreamWriter file) {
            file.WriteLine($"{ pair.programID },{pair.playDate.ToShortDateString()} {pair.playDate.ToShortTimeString()}");
        }
    }
}