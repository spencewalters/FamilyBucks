using NUnit.Framework;
using System;

namespace FamilyBucksProgram {
    [TestFixture]
    [Category("Authentication")]
    class AuthenticationTests {
        public AuthenticationTests() {
            UserDaoFactory.VolatileMode = true;
        }

        [Test]
        public void Users_may_authenticate_using_a_PIN() {
            string testPin = "2345";
            AddMockUserToCache("gerald", "Gerald Kyp",  "password234", testPin);
            Authentication auth = new PinAuthentication();
            auth.SetUsers(UserCache.Records);

            Credentials pinCredentials = auth.GetEmptyCredentials();
            pinCredentials.Secret = testPin;

            Assert.True(auth.IsValidFor(pinCredentials), "PINs do not match");
        }

        [TestCase("")]
        [TestCase("abc")]
        [TestCase("23451")]
        public void Authentication_fails_on_wrong_PINs(string wrongPin) {
            string testPin = "2345";
            AddMockUserToCache("gerald", "Gerald Kyp", "password234", testPin);
            Authentication auth = new PinAuthentication();
            auth.SetUsers(UserCache.Records);

            Credentials pinCredentials = auth.GetEmptyCredentials();
            pinCredentials.Secret = wrongPin;

            Assert.False(auth.IsValidFor(pinCredentials), "PINs should not match");
        }

        private void AddMockUserToCache(string username, string fullname, string password, string pin) {
            UserFactory factory = new UserFactory();
            User user = factory.GenerateNew(username, fullname, false);
            user.Key = password;
            user.Pin = pin;

            UserRecords records = UserCache.Records;
            records.Save(user);

            log.Info($"UserCache.count:{UserCache.Count()}");
        }

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    }
}
