using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBucksProgram{
    public static class RandomHelper {
        private static Random random = new Random(DateTime.Now.Millisecond * DateTime.Now.DayOfYear);

        public static int Ranged(int start, int finish) {
            return random.Next(start, finish);
        }
    }
}
