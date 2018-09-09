using System;
using System.Collections.Generic;
using System.IO;

namespace FamilyBucksProgram {
    public class UserDiskDao : UserDao {
        private string storagePath = $"{AppDomain.CurrentDomain.BaseDirectory}Users\\";
        private string storageFilenamePrefix = "USR";
        private string storageFilenameExtension = "fbf";

        public UserDiskDao() {
            if (Directory.Exists(storagePath) == false) {
                Directory.CreateDirectory(storagePath);
            }
        }

        private string StorageFilePath(string userID) {
            return $"{storagePath}{storageFilenamePrefix}{userID}.{storageFilenameExtension}";
        }

        public List<User> LoadAll() {
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

                log.Info($"Loaded user details for {user.Fullname}");
            }
            else
                log.Warn("No profile on file at path: " + userFile);

            return user;
        }

        public void Delete(string userID) {
            string userFile = StorageFilePath(userID);
            if (File.Exists(userFile)) {
                File.Delete(userFile);
                log.Info($"Deleted {userFile}");
            }
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

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    }
}
