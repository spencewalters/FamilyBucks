using NUnit.Framework;

namespace FamilyBucksProgram.Users {
    [TestFixture]
    [Category("Users")]
    class UserTests {
        public UserTests() {
            UserDaoFactory.TestMode = true;
        }

        [Test]
        public void An_empty_user_is_not_active() {
            UserFactory factory = new UserFactory();
            User user = factory.GenerateEmpty();

            Assert.False(user.IsActive, "User should not be active");
        }

        [Test]
        public void A_factory_generated_user_is_active() {
            UserFactory factory = new UserFactory();
            User user = factory.GenerateNew("alvin","Alvin Sooq", false);

            Assert.True(user.IsActive, "User should be active");
        }

    }
}
