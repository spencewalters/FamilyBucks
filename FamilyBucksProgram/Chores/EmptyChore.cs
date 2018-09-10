using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBucksProgram {
    public class EmptyChore : Chore {
        public EmptyChore() {
        }

        public string Key => "";

        public GeneralState State => GeneralState.EMPTY;

        public string Name => "";

        public string Description => "";

        public double Value => 0;

        public bool IsActive => false;

        public bool IsEmpty => true;

        public bool IsInactive => true;

        public void Activate() {            
        }

        public void Destroy() {
        }

        public void Inactivate() {
        }

        public void SetKey(string key) {
        }

        public Chore Clone() {
            return (Chore)MemberwiseClone();
        }
    }
}
