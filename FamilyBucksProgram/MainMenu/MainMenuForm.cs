using System;
using System.Media;
using System.Windows.Forms;


namespace FamilyBucksProgram {
    public partial class MainMenuForm : Form {
        FamilyBucksProgramManager programManager;

        public MainMenuForm() {
            programManager = new FamilyBucksProgramManager();
            InitializeComponent();

            log.Info($"Program starting {Application.ProductName} {Application.ProductVersion}");

            ApplyDefaults();
            PlayMusic();
            CheckForSetup();
        }

        private void CheckForSetup() {
            // if no admin users in system,
            // prompt to create admin user
            // that person will be able to login and create more users
            //   - have admin type user
            //   - have ability to control whether PIN is required for all users
            //   - change login to show picture of user, click on user, then prompt for pin if required

            if (UserCache.AdminCount() == 0) {
                MessageBox.Show("Setup", 
                    "There are no administrative users setup.  Please proceed to create one and keep the password or PIN in a safe place.", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void ApplyDefaults() {
            EnableSessionButtons(false);
            ShowAccountInfo(false);
        }

        public void PlayMusic() {
            if (Properties.Settings.Default.PlayThemeMusicOnStartup) {
                string musicPath = AppDomain.CurrentDomain.BaseDirectory + Properties.Settings.Default.ThemeMusicPath;
                Console.WriteLine("Music path: " + musicPath);

                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = musicPath;
                player.Play();
            }
        }

        private void LogoutAction() {
            programManager.EndSession();
            EnableSessionButtons(false);
            ShowAccountInfo(false);
            loginBtn.Text = "Login";
        }

        private void LoginAction() {
            LoginForm loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK) {
                User loginUser = loginForm.LoginUser;
                if (loginUser.IsActive) {

                    programManager.BeginSession(loginUser);
                    if (programManager.SessionAlive) {
                        EnableSessionButtons(true);
                        ShowAccountInfo(true);
                        loginBtn.Text = "Logout";
                    }
                }
                else
                    MessageBox.Show("Login Failed", "The username or password you provided does not match our records.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowAccountInfo(bool show) {
            if (show) {
                if (programManager.SessionAlive) {
                    Session session = programManager.CurrentSession;
                    User user = session.User;
                    AccountInformation account = session.AccountInfo;

                    welcomeLbl.Text = "Welcome " + user.Fullname + " !!";
                    balanceValueLbl.Text = account.FormattedAccountBalance;
                }
            }
            else {
                welcomeLbl.Text = "Welcome guest!";
                balanceValueLbl.Text = "N/A";
            }
        }

        private void EnableSessionButtons(bool enable) {
            foreach (Control control in Controls) {
                if (control.GetType() == typeof(Button)) {
                    Button button = (Button)control;
                    SetButtonAsEnabled(enable, button);
                }
            }
        }

        private static void SetButtonAsEnabled(bool enable, Button button) {
            string buttonTag = (string)button.Tag;
            if (String.IsNullOrEmpty(buttonTag) == false) {
                if (buttonTag == "session")
                    button.Enabled = enable;
            }
        }

        private void RunProgram(FamilyBucksProgram program) {
            BankTransaction resultTransaction = BankTransaction.Empty;

            if (programManager.PermitsPlaying(program)) {
                programManager.RecordAsPlayed(program);

                switch (program.Name) {
                    case "Math Game":
                        resultTransaction = PlayMathGame();
                        break;
                    case "Free Family Buck":
                        resultTransaction = PlayFreeFamilyBuck();
                        break;
                    case "Chores Completion":
                        resultTransaction = RunChoresCompletion(programManager.SessionUser);
                        break;
                    default:
                        break;
                }

                programManager.ProcessTransaction(resultTransaction);
                InformUserOfChangeToBalance(resultTransaction);
                UpdateBalance();
            }
            else
                MessageBox.Show("You have already played this game up to the limit!", "No more playing this today");
        }

        private void InformUserOfChangeToBalance(BankTransaction resultTransaction) {
            if (resultTransaction.TransactionAmount > 0) {
                string amount = resultTransaction.TransactionAmount.ToString("N2");

                if (resultTransaction.TransactionType == BankTransactionType.DEPOSIT)
                    MessageBox.Show($"You've earned {amount} more Family Bucks!");
                else
                    MessageBox.Show($"You've spent {amount} Family Bucks.");
            }
        }

        private BankTransaction RunChoresCompletion(User user) {
            ChoresCompletion choresForm = new ChoresCompletion(user);
            choresForm.ShowDialog();
            return choresForm.ResultTransaction;
        }

        private BankTransaction PlayMathGame() {
            MathGameForm form = new MathGameForm();
            form.ShowDialog();
            return form.ResultTransaction;
        }

        private BankTransaction PlayFreeFamilyBuck() {
            FreeFamilyBuckForm form = new FreeFamilyBuckForm();
            form.ShowDialog();
            return form.ResultTransaction;
        }

        private void UpdateBalance() {
            AccountInformation account = programManager.CurrentSession.AccountInfo;
            balanceValueLbl.Text = account.FormattedAccountBalance;
        }

        private void freeBtn_Click(object sender, EventArgs e) {
            try {
                RunProgram(new FreeFamilyBuck());
            }
            catch (Exception exception) {
                ExceptionHandler.RespondTo(exception);
            }
        }

        private void mathBtn_Click(object sender, EventArgs e) {
            try {
                RunProgram(new MathGame());
            }
            catch (Exception exception) {
                ExceptionHandler.RespondTo(exception);
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                RunProgram(new ChoresCompletionProgram());
            }
            catch (Exception exception) {
                ExceptionHandler.RespondTo(exception);
            }
        }

        private void aboutBtn_Click(object sender, EventArgs e) {
            try {
                About aboutForm = new About();
                aboutForm.ShowDialog();
            }
            catch (Exception exception) {
                ExceptionHandler.RespondTo(exception);
            }
        }

        private void rewardsBtn_Click(object sender, EventArgs e) {
            try {
                RewardsForm rewardsForm = new RewardsForm();
                rewardsForm.ShowDialog();
            }
            catch (Exception exception) {
                ExceptionHandler.RespondTo(exception);
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            Close();
        }

        private void loginBtn_Click(object sender, EventArgs e) {
            try {
                if (loginBtn.Text == "Login")
                    LoginAction();
                else
                    LogoutAction();
            }
            catch (Exception exception) {
                ExceptionHandler.RespondTo(exception, "Something went wrong during login.");
            }
        }

        private void myCharacterButton_Click(object sender, EventArgs e) {
            MyCharacter myCharactor = new MyCharacter();
            myCharactor.ShowDialog();
        }

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
        (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    }
}
