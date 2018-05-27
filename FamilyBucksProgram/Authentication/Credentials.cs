using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBucksProgram {
    public interface Credentials {
        Dictionary<string,string> Fields { get; }
        void SetField(string field, string value);
        string GetField(string field);
        bool AreMatching(Credentials credentials);
    }
}
