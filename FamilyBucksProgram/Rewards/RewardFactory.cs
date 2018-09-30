using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBucksProgram {
    public class RewardFactory {
        public Reward Generate(string name, string description, double price) {
            Reward reward = new InGameReward(name, price, description);
            reward.Activate();
            return reward;
        }
        public static Reward Empty { get => new EmptyReward(); }
    }
}
