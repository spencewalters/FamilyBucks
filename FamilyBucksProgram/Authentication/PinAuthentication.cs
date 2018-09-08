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
            log.Info("cred.secret: " + credentials.Secret);
            log.Info("users count: " + users.Count);
            User lookup = users.PINLookup(credentials.Secret);
            log.Info("looked up user: " + lookup.Fullname);
            return lookup.IsActive;
        }

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    }
}
