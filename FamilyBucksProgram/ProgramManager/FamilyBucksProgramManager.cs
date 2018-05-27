using System;

namespace FamilyBucksProgram {
    class FamilyBucksProgramManager {
        private Session currentSession = new NormalSession();

        public bool SessionAlive { get => currentSession.IsActive; }
        internal User SessionUser { get => currentSession.User; }
        public Session CurrentSession { get => currentSession; }

        public FamilyBucksProgramManager() {
        }

        public void EndSession() {
            currentSession.Inactivate();
        }

        public void BeginSession(User user) {
            PlayHistoryDao playDao = new PlayHistoryDao();
            PlayHistory history = playDao.Load(user.ID);

            AccountDao accountDao = new AccountDao();
            AccountInformation accountInfo = accountDao.Load(user.ID);


            currentSession = new NormalSession(user, accountInfo, history);
        }

        public bool PermitsPlaying(FamilyBucksProgram program) {
            int playCount = TodaysPlayCountFor(program);

            if (program.PlayLimitation == FamilyBucksPlayLimitation.Per_Day) {
                if (playCount >= program.Limit)
                    return false;
            }

            return true;
        }

        private int TodaysPlayCountFor(FamilyBucksProgram program) {
            PlayHistory history = currentSession.ProgramsRun;
            return history.CountMatching(program.ID, DateTime.Today, DateTime.Today.AddDays(1));
        }

        public void RecordAsPlayed(FamilyBucksProgram program) {
            PlayHistory history = currentSession.ProgramsRun;
            history.AddEntry(program.ID);

            PlayHistoryDao dao = new PlayHistoryDao();
            dao.Save(history);
        }

        internal void ProcessTransaction(BankTransaction resultTransaction) {
            BankingSystem banking = new BankingSystem(currentSession.AccountInfo);
            banking.ProcessTransaction(resultTransaction);
        }
    }
}
