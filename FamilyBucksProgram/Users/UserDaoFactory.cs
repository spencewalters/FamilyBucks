namespace FamilyBucksProgram {
    public class UserDaoFactory {
        public static bool VolatileMode = false;

        public UserDao GenerateDao() {
            if (VolatileMode)
                return new UserMemDao();
            else
                return new UserDiskDao();
        }
    }
}
