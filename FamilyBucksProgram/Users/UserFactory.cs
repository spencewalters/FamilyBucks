using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBucksProgram {
    public class UserFactory {
        public User Generate(string username, string fullName, bool isAdmin) {
            User user = new User();
            user.SetUsername(username);
            user.SetFullname(fullName);
            if (isAdmin)
                user.SetAsAdmin("true");

            user.Activate();

            return user;
        }

        public static User Empty { get => new User();
    }
}
}
