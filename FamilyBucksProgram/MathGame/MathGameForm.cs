using System;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;

namespace FamilyBucksProgram
{
    public partial class MathGameForm : Form
    {
        public BankTransaction ResultTransaction;
        private int countdownClock;
        private int startTime = 30;
        private int totalCorrect = 0;
        private int numberOfProblems = 10;
        private double totalEarnings = 0;
        private List<MathProblem> problemList;
        private SoundPlayer emitBell, emitHorn, emitVictory;
        private MathFamily TypeOfMath = MathFamily.Addition;
        private int HighestNumber = 18;

        public MathGameForm() {
            InitializeComponent();

            ResultTransaction = BankTransaction.Empty;
            problemList = new List<MathProblem>();
            ChooseMathType();
            RestartClock();
            SetupProblems();
            SetupSounds();
            FocusOnFirstProblem();
        }

        private void ChooseMathType() {
            Random random = new Random((int)DateTime.Now.Ticks);
            TypeOfMath = (MathFamily)random.Next(2);
        }

        private void FocusOnFirstProblem() {
            if (problemList.Count > 0)
                ActiveControl = FirstProblem();
        }

        private Control FirstProblem() {
            return problemList[0];
        }

        private void SetupSounds() {
            string soundsPath = AppDomain.CurrentDomain.BaseDirectory + "Resources\\";
            
            emitBell = new SoundPlayer();
            emitBell.SoundLocation = soundsPath + "Bell.wav";

            emitHorn = new SoundPlayer();
            emitHorn.SoundLocation = soundsPath + "Air Horn.wav";

            emitVictory = new SoundPlayer();
            emitVictory.SoundLocation = soundsPath + "Victory.wav";
        }

        private void SetupProblems() {
            int xPosition = 0, xoffset=10, column;
            int yPosition = 0, yoffset=77, row;

            for (int problemIndex=0; problemIndex < numberOfProblems; problemIndex++) {
                MathProblem problem = new MathProblem();

                column = problemIndex % 5;
                row = problemIndex / 5;
                xPosition = 1 + (problem.Width * column);
                yPosition = 1 + (problem.Height * row);

                problem.Location = new System.Drawing.Point(xoffset + xPosition, yoffset + yPosition);
                problem.Name = "mathProblem" + problemIndex;
                problem.Size = new System.Drawing.Size(200, 185);
                problem.TabIndex = 13;

                problem.CreateProblem(TypeOfMath, HighestNumber);
                problem.ProblemComplete += MathProblem1_ProblemComplete;

                Controls.Add(problem);
                problemList.Add(problem);
            }            
        }

        private void MathProblem1_ProblemComplete(object sender, EventArgs e) {
            PlaySoundIfNewlyCorrect((MathProblem)sender);
            UpdateStats();
        }

        private void PlaySoundIfNewlyCorrect(MathProblem sender) {
            if ((sender.Enabled) && (sender.SolutionIsCorrect))
                EmitBell();
        }

        private void UpdateStats() {
            UpdateCorrectCount();
            UpdateEarnings();
            CheckForAllDone();
        }

        private void CheckForAllDone() {
            if (numberOfProblems == totalCorrect) {
                EmitVictory();
                ShowSmileFace();
                StopClock();
            }
        }

        private void ShowSmileFace() {
            smileFacePic.Visible = true;
        }

        private void UpdateEarnings() {
            totalEarnings = ((double)totalCorrect) / 20;
            earningsLbl.Text = totalEarnings.ToString("N2");
        }

        private void UpdateCorrectCount() {
            int count = 0;

            foreach (MathProblem problem in problemList) {
                if ((problem.Enabled) &&
                (problem.SolutionIsCorrect)) {
                    count++;
                    problem.Enabled = false;
                }
            }

            totalCorrect += count;
            correctLbl.Text = totalCorrect.ToString();
        }

        private void RestartClock() {
            StopClock();
            countdownClock = startTime;
            StartClock();
        }

        private void StopClock() {
            timer1.Enabled = false;
        }

        private void StartClock() {
            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e) {            
            DialogResult = DialogResult.OK;
        }

        private void timer1_Tick(object sender, EventArgs e) {
            countdownClock--;
            if (countdownClock <= 0) {
                countdownClock = 0;
                EmitHorn();
                StopClock();
                DisableProblems();
            }

            UpdateClock();
        }

        private void DisableProblems() {
            foreach (MathProblem problem in problemList)
                problem.Enabled = false;
        }

        private void UpdateClock() {
            int minutes = (countdownClock >= 60) ? (countdownClock / 60) : (0);
            int seconds = (countdownClock % 60);

            countdownClockLbl.Text = String.Format("{0}:{1}",
                minutes.ToString("D2"),
                seconds.ToString("D2"));
        }

        public void EmitBell() {
            emitBell.Play();
        }
        
        private void EmitVictory() {
            emitVictory.Play();
        }

        private void MathGameForm_FormClosing(object sender, FormClosingEventArgs e) {
            ResultTransaction = new BankTransaction(BankTransactionType.DEPOSIT, totalEarnings, "Math Game Winnings");
        }

        public void EmitHorn() {
            emitHorn.Play();
        }
    }
}
