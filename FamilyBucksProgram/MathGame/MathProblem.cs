using System;
using System.Windows.Forms;

namespace FamilyBucksProgram
{
    public partial class MathProblem : UserControl
    {
        public bool SolutionIsCorrect = false;
        private int correctAnswer = 0;
        private Random random;
        public event EventHandler ProblemComplete;

        protected virtual void OnProblemCompleted(EventArgs e) {
            ProblemComplete?.Invoke(this, e);
        }

        public MathProblem() {
            random = new Random((int)DateTime.Now.Ticks);

            InitializeComponent();

            topNumberLbl.Text = "";
            lowerNumberLbl.Text = "";
            operatorLbl.Text = "";
            answerTxt.Text = "";
            wrongPic.Visible = false;
            correctPic.Visible = false;            
        }

        public void CreateProblem(MathFamily family, int highestValue) {

            int firstValue = RandomNumber(highestValue);
            int secondValue = RandomNumber(highestValue);

            switch (family) {
                case MathFamily.Addition:
                    operatorLbl.Text = "+";
                    correctAnswer = firstValue + secondValue;
                    break;
                case MathFamily.Subtraction:
                    operatorLbl.Text = "-";
                    secondValue = RandomNumber(firstValue);
                    correctAnswer = firstValue - secondValue;
                    break;
                case MathFamily.Multiplication:
                    operatorLbl.Text = "X";
                    correctAnswer = firstValue * secondValue;
                    break;
                case MathFamily.Division:
                    operatorLbl.Text = "%";
                    secondValue = RandomNumber(highestValue - 1) + 1;
                    firstValue = firstValue * secondValue;                    
                    correctAnswer = firstValue / secondValue;
                    break;
                default:
                    break;
            }

            topNumberLbl.Text = firstValue.ToString();
            lowerNumberLbl.Text = secondValue.ToString();

        }

        private int RandomNumber(int highestValue) {
            return random.Next(highestValue + 1);
        }
        
        private void SubmitAnswer() {
            int solution = 0;

            if (answerTxt.Text.Length < 1)
                return;

            if (Int32.TryParse(answerTxt.Text, out solution) == false) {
                MessageBox.Show("That's not a number!");
                return;
            }

            if (solution == correctAnswer) {
                correctPic.Visible = true;
                wrongPic.Visible = false;
                SolutionIsCorrect = true;
            }
            else {
                wrongPic.Visible = true;
                correctPic.Visible = false;
                SolutionIsCorrect = false;
            }

            OnProblemCompleted(EventArgs.Empty);
        }

        private void answerTxt_Leave(object sender, EventArgs e) {
            SubmitAnswer();
        }
        
        private void answerTxt_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                SubmitAnswer();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }

    public enum MathFamily
    {
        Addition, Subtraction, Multiplication, Division
    }
}
