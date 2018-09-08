using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBucksProgram {
    public class UserFactory {
        public User GenerateNew(string username, string fullName, bool isAdmin) {
            User user = new User();
            user.SetUsername(username);
            user.SetFullname(fullName);
            if (isAdmin)
                user.SetAsAdmin("1");

            user.Activate();

            return user;
        }

        public User GenerateEmpty() {
            User user = new User();
            user.Inactivate();

            return user;
        }
    }
}
