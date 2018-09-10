using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBucksProgram{
    public class ChoreFactory {
        public Chore GenerateEmpty() => new EmptyChore();
    }
}
