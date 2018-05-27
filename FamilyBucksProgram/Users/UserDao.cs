using System;
using System.Collections.Generic;
using System.IO;

namespace FamilyBucksProgram {
    public class UserDao {
        private string storagePath = $"{AppDomain.CurrentDomain.BaseDirectory}Users\\";
        private string storageFilenamePrefix = "USR";
        private string storageFilenameExtension = "fbf";

        private string StorageFilePath(string userID) {
            return $"{storagePath}{storageFilenamePrefix}{userID}.{storageFilenameExtension}";
        }
        
        public User LoadUserByPin(string pin) {
            List<User> all = LoadAll();
            User matching = new User();
            foreach (User user in all) {
                if (user.Pin == pin) {
                    matching = user;
                    break;
                }
            }

            return matching;
        }

        private List<User> LoadAll() {
            List<User> users = new List<User>();
            string searchPattern = $"{storageFilenamePrefix}*.{storageFilenameExtension}";

            foreach (string filename in Directory.EnumerateFiles(storagePath, searchPattern)) {
                User user = LoadFromFile(filename);
                users.Add(user);
            }
            return users;
        }

        public User Load(string userID) {
            return LoadFromFile(StorageFilePath(userID));
        }

        private User LoadFromFile(string userFile) {
            User user = new User();

            if (File.Exists(userFile)) {
                StreamReader file = new StreamReader(userFile);
                user.ID = file.ReadLine();
                user.SetUsername(file.ReadLine());
                user.SetFullname(file.ReadLine());
                user.Pin = file.ReadLine();
                user.SetAsAdmin(file.ReadLine());
                user.Activate();

                file.Close();

                Console.WriteLine($"Loaded user details for {user.Fullname}");
            }
            else
                Console.WriteLine("No profile on file at path: " + userFile);

            return user;
        }
        
        public void Save(User user) {
            string userFile = StorageFilePath(user.ID);
            StreamWriter file = new StreamWriter(userFile);
            file.WriteLine(user.ID);
            file.WriteLine(user.Username);
            file.WriteLine(user.Fullname);
            file.WriteLine(user.Pin);
            file.WriteLine(user.IsAnAdmin.ToString());
            file.Close();
        }
    }
}
