namespace FamilyBucksProgram.TypingGame {
    public interface Vessel {
        int Latitude { get; set; }
        int Longitude { get; set; }
        int Altitude { get; set; }
        string Name { get; set; }

        void Thrust();
    }
}