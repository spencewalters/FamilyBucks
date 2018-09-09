using System.Collections.Generic;

namespace FamilyBucksProgram {
    public class UserMemDao : UserDao {
        List<User> userStorage = new List<User>();
        UserFactory factory = new UserFactory();

        public User Load(string userID) {
            foreach(User user in userStorage) {
                if (user.ID == userID)
                    return user;
            }

            return factory.GenerateEmpty();
        }

        public List<User> LoadAll() {
            return userStorage;
        }

        public void Save(User user) {
            userStorage.Add(user);
        }

        public void Delete(string ID) {
            userStorage.RemoveAll(user => user.ID == ID);
        }

    }
}
