using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FamilyBucksProgram {
    [TestFixture]
    [Category("Rewards")]
    public class RewardTests {

        [Test]
        public void A_generated_reward_has_a_unique_key() {
            Reward reward = GetTestReward();
            log.Info(new LoggableReward(reward));

            Assert.False(string.IsNullOrWhiteSpace(reward.Key));
        }

        private static Reward GetTestReward() {
            RewardFactory factory = new RewardFactory();
            return factory.Generate("Mystery Prize", 
                "Receive a mysterious wrapped present.  What's inside??", 
                10.00);
        }

        [Test]
        public void Rewards_can_be_saved_loaded_and_deleted() {
            Reward reward = GetTestReward();
            RewardDao dao = new RewardDao();

            dao.Save(reward);
            Reward loaded = dao.Load(reward.Key);
            Assert.False(loaded.IsEmpty);

            dao.Delete(reward.Key);
            Reward reloaded = dao.Load(reward.Key);
            Assert.True(reloaded.IsEmpty);
        }

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
        (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    }
}
