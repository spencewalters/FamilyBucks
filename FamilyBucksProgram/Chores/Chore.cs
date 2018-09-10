namespace FamilyBucksProgram
{
    public interface Chore : FamilyData {
        string Name { get; }
        string Description { get; }
        double Value { get; }
        void SetKey(string key);
        Chore Clone();
    }
}
