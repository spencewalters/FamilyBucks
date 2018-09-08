using System;
using System.Collections.Generic;

namespace FamilyBucksProgram {
    public class UserRecords {
        private UserDao dao;
        private List<User> records;
        private UserFactory factory;

        public int Count { get => records.Count; }
        public int AdminCount { get => GetAdminCount(); }

        public UserRecords() {
            UserDaoFactory daoFactory = new UserDaoFactory();
            dao = daoFactory.GenerateDao();
            records = new List<User>();
            factory = new UserFactory();
        }
        
        public void Refresh() {
            records.Clear();
            records = dao.LoadAll();
        }

        public void Save(User user) {
            dao.Save(user);
        }

        public User Load(string userID) {
            return dao.Load(userID);
        }

        public User PINLookup(string pin) {
            User matching = factory.GenerateEmpty();
            foreach (User user in records) {
                if (user.Pin == pin) {
                    matching = user;
                    break;
                }
            }

            return matching;
        }

        private int GetAdminCount() {
            int count = 0;
            foreach (User user in records) {
                if (user.IsAnAdmin)
                    count++;
            }

            return count;
        }

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    }
}