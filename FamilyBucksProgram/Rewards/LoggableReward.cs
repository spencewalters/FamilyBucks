using System.Text;

namespace FamilyBucksProgram {
    internal class LoggableReward {
        private Reward reward;

        public LoggableReward(Reward reward) {
            this.reward = reward;
        }

        public override string ToString() {
            StringBuilder builder = new StringBuilder();
            builder.Append($"\nReward: {reward.Name}");
            builder.Append($"\n    Description-> {reward.Description}");
            builder.Append($"\n    Price-> {reward.Price}");
            builder.Append($"\n    Key-> {reward.Key}");

            return builder.ToString();
        }
    }
}