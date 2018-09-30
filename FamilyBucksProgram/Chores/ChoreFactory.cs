using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBucksProgram{
    public class ChoreFactory {
        public Chore Generate(string name, string description, double cost) {
            Chore chore = new FamilyChore(name, cost, description);
            chore.Activate();
            return chore;
        }

        public static Chore Empty { get => new EmptyChore(); }
    }
}
