using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBucksProgram {
    public interface Reward : FamilyData {
        string Name { get;  }
        string Description { get;  }
        double Price { get; }
        void SetKey(string key);
        Reward Clone();
    }
}
