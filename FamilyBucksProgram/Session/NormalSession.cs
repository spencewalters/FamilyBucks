using System;

namespace FamilyBucksProgram {
    public class NormalSession : Session {
        private string key;
        private User _user;
        private AccountInformation _accountInfo;
        private PlayHistory _playHistory;
        private DateTime loginTime;

        public string Key => key;
        public User User => _user;
        public AccountInformation AccountInfo => _accountInfo;
        public PlayHistory ProgramsRun => _playHistory;
        public TimeSpan LoginDuration => DateTime.Now.Subtract(loginTime);
        public DateTime LoginTime => loginTime;

        private GeneralState state = GeneralState.EMPTY;
        public bool IsActive { get => state == GeneralState.ACTIVE; }
        public bool IsInactive { get => state == GeneralState.INACTIVE; }
        public bool IsEmpty { get => state == GeneralState.EMPTY; }
        public void Activate() { state = GeneralState.ACTIVE; }
        public void Inactivate() { state = GeneralState.INACTIVE; }
        public void Destroy() { state = GeneralState.EMPTY; }

        public NormalSession() { }

        public NormalSession(User user, AccountInformation accountInfo, PlayHistory playHistory) {
            key = Guid.NewGuid().ToString();
            _user = user;
            _accountInfo = accountInfo;
            _playHistory = playHistory;
            loginTime = DateTime.Now;
            Activate();
        }
    }
}
