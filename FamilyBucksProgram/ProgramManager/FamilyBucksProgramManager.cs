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
            if (accountInfo.IsEmpty) {
                accountInfo.SetID(user.ID);
                accountInfo.Activate();
                log.Info("Initializing new account");
                log.Info(new UserLoggable(user));
                log.Info(new AccountInformationLoggable(accountInfo));
            }

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

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
        (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    }
}
