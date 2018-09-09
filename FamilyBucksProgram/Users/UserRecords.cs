using System;
using System.Collections.Generic;

namespace FamilyBucksProgram {
    public class UserRecords {
        private UserDao dao;
        private Dictionary<string, User> records;
        private UserFactory factory;

        public int Count { get => records.Count; }
        public int AdminCount { get => GetAdminCount(); }

        public UserRecords() {
            UserDaoFactory daoFactory = new UserDaoFactory();
            dao = daoFactory.GenerateDao();
            records = new Dictionary<string, User>();
            factory = new UserFactory();
        }

        public List<User> ToList() {
            List<User> list = new List<User>();
            foreach (string ID in records.Keys) {
                list.Add(records[ID]);
            }

            return list;
        }

        public void Clear() {
            records.Clear();
        }

        public void Refresh() {
            records.Clear();
            List<User> list = dao.LoadAll();
            foreach (User user in list) {
                records.Add(user.ID, user);
            }
        }

        public void Save(User user) {
            if (user.IsEmpty) {
                throw new InvalidOperationException("Cannot save an empty user");
            }
                dao.Save(user);
                records.Remove(user.ID);
                records.Add(user.ID, user);
        }

        public User Load(string userID) {
            User user;

            if (records.ContainsKey(userID))
                user = records[userID];
            else {
                user = dao.Load(userID);
                if (user.IsEmpty == false)
                    records.Add(user.ID, user);
            }
            return user;
        }

        public User PINLookup(string pin) {
            User matching = factory.GenerateEmpty();
            foreach (string ID in records.Keys) {
                User user = records[ID];
                if (user.Pin == pin) {
                    matching = user;
                    break;
                }
            }

            return matching;
        }

        private int GetAdminCount() {
            int count = 0;
            foreach (string ID in records.Keys) {
                User user = records[ID];
                if (user.IsAnAdmin)
                    count++;
            }

            return count;
        }

        public void Delete(string ID) {
            dao.Delete(ID);
            records.Remove(ID);
        }

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    }
}