namespace FamilyBucksProgram {
    public class UserDaoFactory {
        public static bool VolatileMode = false;

        public UserDao GenerateDao(bool test = false) {
            if (VolatileMode)
                return new UserMemDao();
            else
                return new UserDiskDao();
        }
    }
}
