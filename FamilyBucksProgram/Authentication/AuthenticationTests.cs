using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace FamilyBucksProgram {
    [TestFixture]
    [Category("Authentication")]
    class AuthenticationTests {
        [Test]
        public void Users_may_authenticate_using_a_PIN() {
            User actualUser = LoadMockUser("gerald", "password234", "2345");
            string providedPin = "2345";

            Authentication auth = new PinAuthentication();
            auth.SetActualCredentials(new PinCredentials(actualUser.Pin));

            Credentials pinCredentials = auth.GetEmptyCredentials();
            pinCredentials.SetField("Pin", providedPin);

            Assert.True(auth.IsValidFor(pinCredentials), "PINs do not match");
        }

        private User LoadMockUser(string username, string password, string pin) {
            User user = new User();
            user.ID = Guid.NewGuid().ToString();
            user.SetUsername(username);
            user.Key = password;
            user.Pin = pin;

            return user;
        }
    }
}
