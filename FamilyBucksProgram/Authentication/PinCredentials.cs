using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBucksProgram {
    public class PinCredentials : Credentials {
        public string Identity { get; set; }
        public string Secret { get; set; }

        public PinCredentials(string pinValue) {
            Secret = pinValue;
        }

        public bool Equals(Credentials credentials) {            
            return (Secret == credentials.Secret);
        }        
    }
}
