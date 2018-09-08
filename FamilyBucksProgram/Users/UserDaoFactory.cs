namespace FamilyBucksProgram {
    public class UserDaoFactory {
        public static bool TestMode = false;

        public UserDao GenerateDao(bool test = false) {
            if (TestMode)
                return new UserMemDao();
            else
                return new UserDiskDao();
        }
    }
}
