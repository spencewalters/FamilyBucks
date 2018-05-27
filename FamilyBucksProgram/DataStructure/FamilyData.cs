namespace FamilyBucksProgram {
    public interface FamilyData    {
        string Key { get; }
        bool IsActive { get; }
        bool IsEmpty { get; }
        bool IsInactive { get; }

        void Activate();
        void Inactivate();
        void Destroy();
    }
}
