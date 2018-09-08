using System;
using System.Collections.Generic;

namespace FamilyBucksProgram {
    public interface UserDao {

        List<User> LoadAll();
        User Load(string userID);
        void Save(User user);

    }
}
