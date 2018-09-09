using System;

namespace FamilyBucksProgram
{
    public class User : FamilyData
    {
        private string id;
        private string username;
        private string fullname;
        private bool isAnAdmin = false;
        private GeneralState state;

        public string ID { get => id; set => id = value; }
        public string Username { get => username;}
        public string Fullname { get => fullname; }
        public string Pin { get; internal set; }
        public string Key { get => ID; set => ID = value; }
        
        public bool IsActive { get => state == GeneralState.ACTIVE; }
        public bool IsInactive { get => state == GeneralState.INACTIVE; }
        public bool IsEmpty { get => state == GeneralState.EMPTY;  }
        public bool IsAnAdmin { get => isAnAdmin; }

        public void Activate() { state = GeneralState.ACTIVE; }
        public void Inactivate() { state = GeneralState.INACTIVE;  }
        public void Destroy() { state = GeneralState.EMPTY; }

        public User() {
            username = "";
            id = Guid.NewGuid().ToString();
            state = GeneralState.EMPTY;
            Pin = "";
        }

        public void SetUsername(string newUsername) {
            username = newUsername;
        }

        public void SetFullname(string newFullname) {
            fullname = newFullname;
        }

        internal User Clone() {
            return (User)MemberwiseClone();
        }

        internal void SetAsAdmin(string isAdminString) {
            isAnAdmin = Boolean.Parse(isAdminString);
        }
    }
}
