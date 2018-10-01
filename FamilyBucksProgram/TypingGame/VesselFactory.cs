using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBucksProgram.TypingGame {
    public class VesselFactory {
        public Vessel CreateRocket(string name, ScreenPosition position) {
            Vessel vessel = new Rocket(name);
            vessel.Altitude = position.Z;
            vessel.Longitude = position.X;
            vessel.Latitude = position.Y;

            return vessel;
        }

    }
}
