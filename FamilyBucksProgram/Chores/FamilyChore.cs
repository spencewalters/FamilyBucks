using System;

namespace FamilyBucksProgram {
    public class FamilyChore : Chore 
    {
        public string Key { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Value { get; set; }
        public GeneralState State { get=>state; }

        public void SetKey(string key) { Key = key; }
        private GeneralState state = GeneralState.EMPTY;
        public bool IsActive { get => state == GeneralState.ACTIVE; }
        public bool IsInactive { get => state == GeneralState.INACTIVE; }
        public bool IsEmpty { get => state == GeneralState.EMPTY; }
        public void Activate() { state = GeneralState.ACTIVE; }
        public void Inactivate() { state = GeneralState.INACTIVE; }
        public void Destroy() { state = GeneralState.EMPTY; }

        public FamilyChore() {}

        public FamilyChore(string name, double value, string description="") {
            Key = Guid.NewGuid().ToString();
            Name = name;
            Description = description;
            Value = value;

            Activate();
        }

        public Chore Clone() {
            return (Chore)MemberwiseClone();
        }
    }
}
