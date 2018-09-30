using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBucksProgram{
    public class UserLoggable {
        private User user;
        public UserLoggable(User user) {
            this.user = user;
        }

        public override string ToString() {
            StringBuilder builder = new StringBuilder();
            builder.Append($"\nUser: {user.Username}");
            builder.Append($"\n    Name-> {user.Fullname}");
            builder.Append($"\n    Key-> {user.Key}");

            return builder.ToString();
        }
    }
}
