using System;

namespace FamilyBucksProgram {
    public class PinAuthentication : Authentication {
        public Credentials GetEmptyCredentials() {
            return new PinCredentials("");
        }

        public bool IsValidFor(Credentials credentials) {
            User user = LookupUserWith(credentials);
            return credentials.AreMatching(new PinCredentials(user.Pin));
        }

        private User LookupUserWith(Credentials credentials) {
            UserDao userDao = new UserDao();
            return userDao.LoadUserByPin(credentials.GetField("Pin"));
        }
    }
}
