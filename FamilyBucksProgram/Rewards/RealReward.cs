using System;

namespace FamilyBucksProgram {
    public class RealReward : Reward {
        public string Key { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public void SetKey(string key) { Key = key; }

        private GeneralState state = GeneralState.EMPTY;
        public bool IsActive { get => state == GeneralState.ACTIVE; }
        public bool IsInactive { get => state == GeneralState.INACTIVE; }
        public bool IsEmpty { get => state == GeneralState.EMPTY; }
        public void Activate() { state = GeneralState.ACTIVE; }
        public void Inactivate() { state = GeneralState.INACTIVE; }
        public void Destroy() { state = GeneralState.EMPTY; }

        public RealReward() { }

        public RealReward(string name, double price, string description = "") {
            Key = Guid.NewGuid().ToString();
            Name = name;
            Description = description;
            Price = price;

            Activate();
        }
    }
}
