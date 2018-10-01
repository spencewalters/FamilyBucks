using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBucksProgram.TypingGame {
    interface Sprite {
        void SetImage(Image image);
        ScreenPosition Position { get; }
        void DrawOn(Graphics g);
    }
}
