using System;
using System.Media;
using System.Windows.Forms;


namespace FamilyBucksProgram {
    public partial class MainMenu : Form
    {
        FamilyBucksProgramManager programManager;

        public MainMenu() {
            programManager = new FamilyBucksProgramManager();
            InitializeComponent();

            ApplyDefaults();
            PlayMusic();
        }

        private void ApplyDefaults() {
            EnableSessionButtons(false);
            ShowAccountInfo(false);
        }

        public void PlayMusic() {
            string musicPath = AppDomain.CurrentDomain.BaseDirectory + "Resources\\ShineBrightLikeADiamondClip.wav";
            Console.WriteLine("Music path: " + musicPath);

            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = musicPath;
            player.Play();
        }

        private void aboutBtn_Click(object sender, EventArgs e) {
            About aboutForm = new About();
            aboutForm.ShowDialog();
        }

        private void rewardsBtn_Click(object sender, EventArgs e) {
            Rewards rewardsForm = new Rewards();
            rewardsForm.ShowDialog();
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
            catch(Exception exception) {
                ExceptionHandler.RespondTo(exception, "Something went wrong during login.");
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
            RunProgram(new FreeFamilyBuck());
        }

        private void mathBtn_Click(object sender, EventArgs e) {
            RunProgram(new MathGame());
        }

        private void button1_Click(object sender, EventArgs e) {
            RunProgram(new ChoresCompletionProgram());            
        }
    }
}
