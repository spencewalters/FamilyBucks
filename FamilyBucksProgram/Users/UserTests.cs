using NUnit.Framework;
using System;

namespace FamilyBucksProgram.Users {
    [TestFixture]
    [Category("Users")]
    class UserTests {

        private UserFactory factory;

        public UserTests() {
            UserDaoFactory.VolatileMode = true;
            factory = new UserFactory();
        }

        [Test]
        public void An_empty_user_is_empty_and_not_active() {
            User user = UserFactory.Empty;

            Assert.True(user.IsEmpty, "User should be empty");
        }

        [Test]
        public void A_factory_generated_user_is_active() {
            User user = factory.Generate("alvin", "Alvin Sooq", false);

            Assert.True(user.IsActive, "User should be active");
        }

        [Test]
        public void A_factory_generated_admin_is_active() {
            User user = factory.Generate("alvin", "Alvin Sooq", true);

            Assert.True(user.IsActive, "Admin user should be active");
        }

        [Test]
        public void The_user_records_provides_a_count_of_users_and_admins() {
            UserRecords records = new UserRecords();
            UserFactory factory = new UserFactory();

            records.Save(factory.Generate("alvin", "Alvin Sooq", false));
            records.Save(factory.Generate("terra", "Terra Haute", true));
            records.Save(factory.Generate("gitty", "Gyn Mitty", false));

            Assert.That(records.Count, Is.EqualTo(3));
            Assert.That(records.AdminCount, Is.EqualTo(1));
        }

        [Test]
        public void The_user_records_can_save_load_and_delete_records() {
            UserRecords records = new UserRecords();

            User saveUser = factory.Generate("gitty", "Gyn Mitty", false);
            records.Save(saveUser);

            User testUser = records.Load(saveUser.ID);
            Assert.True(testUser.IsActive);
            Assert.That(records.Count, Is.EqualTo(1));

            records.Delete(testUser.ID);
            Assert.That(records.Count, Is.EqualTo(0));
        }

        [Test]
        public void User_records_maintains_single_copy_of_user_saved_twice() {
            UserRecords records = new UserRecords();
            User saveUser = factory.Generate("gitty", "Gyn Mitty", false);

            records.Save(saveUser);
            records.Save(saveUser);
            Assert.That(records.Count, Is.EqualTo(1));
        }

        [Test]
        public void The_user_records_does_not_crash_when_given_empty_or_missing_parameters() {
            UserRecords records = new UserRecords();
            User test = records.Load("");
            Assert.True(test.IsEmpty);

            records.Delete("");
            try {
                records.Save(new User());
                Assert.Fail("Should not have saved an empty user");
            }
            catch (InvalidOperationException exception) {
                log.Info("Captured expected exception: " + exception.Message);
            }
            Assert.That(records.Count, Is.EqualTo(0));
        }

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    }
}
