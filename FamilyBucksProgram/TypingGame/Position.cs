using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBucksProgram.TypingGame {
    public class ScreenPosition {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public ScreenPosition(int x, int y, int z) {
            X = x;
            Y = y;
            Z = y;
        }

        public static ScreenPosition LaunchPad { get => new ScreenPosition(425, 335, 0); }
        public static ScreenPosition RandomGround { get => new ScreenPosition(RandomHelper.Ranged(1,625), 335, 0); }
    }
}
