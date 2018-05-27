using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBucksProgram {
    public class PinCredentials : Credentials {
        private Dictionary<string, string> fields = new Dictionary<string, string>();
        private string PinField = "Pin";
        public Dictionary<string, string> Fields => throw new NotImplementedException();

        public PinCredentials(string pinValue) {
            fields.Add(PinField, pinValue);
        }

        public bool AreMatching(Credentials credentials) {            
            return (fields[PinField] == credentials.GetField(PinField));
        }

        public string GetField(string field) {
            return fields[field];
        }

        public void SetField(string field, string value) {
            fields[field] = value;
        }
    }
}
