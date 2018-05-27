namespace FamilyBucksProgram
{
    public interface Chore : FamilyData {
        string Name { get; set; }
        string Description { get; set; }
        double Value { get; set; }
    }
}
