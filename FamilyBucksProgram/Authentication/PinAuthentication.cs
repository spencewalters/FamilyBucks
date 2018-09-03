using System;

namespace FamilyBucksProgram {
    public class PinAuthentication : Authentication {
        Credentials actualCredentials;

        public Credentials GetEmptyCredentials() {
            return new PinCredentials("");
        }

        public void SetActualCredentials(Credentials credentials) {
            actualCredentials = credentials;
        }
        
        public bool IsValidFor(Credentials credentials) {
            return credentials.AreMatching(actualCredentials);
        }

        private User LookupUserWith(Credentials credentials) {
            UserDao userDao = new UserDao();
            return userDao.LoadUserByPin(credentials.GetField("Pin"));
        }
    }
}
