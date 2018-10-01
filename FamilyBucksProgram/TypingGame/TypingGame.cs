using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBucksProgram {
    public class TypingProgram : FamilyBucksProgram {
        public string Name => "Typing Game";
        public string ID => "069B4772-7E1F-4421-808D-8C54C10342C3";
        public FamilyBucksPlayLimitation PlayLimitation => FamilyBucksPlayLimitation.Per_Day;
        public int Limit => 50;
    }
}
