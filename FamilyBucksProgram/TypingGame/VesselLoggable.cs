using FamilyBucksProgram.TypingGame;
using System.Text;

namespace FamilyBucksProgram {
    internal class VesselLoggable {
        private Vessel vessel;

        public VesselLoggable(Vessel vessel) {
            this.vessel = vessel;
        }

        public override string ToString() {
            StringBuilder builder = new StringBuilder();
            builder.Append($"\nVessel: {vessel.Name}");
            builder.Append($"\n    Longitude: {vessel.Longitude}");
            builder.Append($"\n    Altitude: {vessel.Altitude}");

            return builder.ToString();
        }
    }
}