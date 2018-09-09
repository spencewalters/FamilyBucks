using System;

namespace FamilyBucksProgram {
    public class PinAuthentication : Authentication {
        private UserRecords users;

        public void SetUsers(UserRecords _users) {
            users = _users;
        }

        public Credentials GetEmptyCredentials() {
            return new PinCredentials("");
        }

        public bool IsValidFor(Credentials credentials) {
            User lookup = users.PINLookup(credentials.Secret);
            return lookup.IsActive;
        }

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    }
}
