using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBucksProgram {
    public interface Credentials {
        string Identity { get; set; }
        string Secret { get; set; }
        bool Equals(Credentials credentials);
    }
}
