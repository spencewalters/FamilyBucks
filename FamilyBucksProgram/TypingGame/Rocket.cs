using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBucksProgram.TypingGame {
    public class Rocket : Vessel {
        public int Latitude { get; set; }
        public int Longitude { get; set; }
        public int Altitude { get; set; }
        public string Name { get; set; }

        public Rocket(string name) {
            Name = name;
        }

        public void Thrust() {
            Altitude = Altitude - 1;
        }
    }
}
