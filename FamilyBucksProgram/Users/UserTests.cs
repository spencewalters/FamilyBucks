using NUnit.Framework;

namespace FamilyBucksProgram.Users {
    [TestFixture]
    [Category("Users")]
    class UserTests {
        public UserTests() {
            UserDaoFactory.VolatileMode = true;
        }

        [Test]
        public void An_empty_user_is_empty_and_not_active() {
            UserFactory factory = new UserFactory();
            User user = factory.GenerateEmpty();

            Assert.True(user.IsEmpty, "User should be empty");
        }

        [Test]
        public void A_factory_generated_user_is_active() {
            UserFactory factory = new UserFactory();
            User user = factory.GenerateNew("alvin","Alvin Sooq", false);

            Assert.True(user.IsActive, "User should be active");
        }

        [Test]
        public void A_factory_generated_admin_is_active() {
            UserFactory factory = new UserFactory();
            User user = factory.GenerateNew("alvin", "Alvin Sooq", true);

            Assert.True(user.IsActive, "Admin user should be active");
        }

    }
}
