using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FamilyBucksProgram;
using FamilyBucksProgram.TypingGame;

namespace FamilyBucksProgram {
    public partial class TypingGameForm : Form {
        List<Vessel> vessels = new List<Vessel>();
        List<Sprite> sprites = new List<Sprite>();
        int launchVessel = 0;
        int delayBetween = 50;
        int currentFrame = 0;

        List<Char> keysAvailable = new List<char>();
        Char chosenKey;

        public BankTransaction ResultTransaction { get; internal set; }

        public TypingGameForm() {
            ResultTransaction = BankTransaction.Empty;

            InitializeComponent();

            SetupVessels();
            SetupSprites();
            UpdateLabel();
            SetupKeys();
        }

        private void SetupKeys() {
            keysAvailable.Add('F');
            keysAvailable.Add('R');
            keysAvailable.Add('T');
            SetChosenKey();
        }

        private Label GetKeyLabel(Char key) {
            string labelName = $"{key}_keyLabel";
            return (Label)Controls[labelName];
        }

        private void SetChosenKey() {
            SetChosenKeyRandomly();
            UnhighlightAllKeys();
            Highlight(chosenKey, Color.Red);
        }

        private void UnhighlightAllKeys() {
            foreach (Char letter in keysAvailable) {
                Unhighlight(letter);
            }
        }

        private void Unhighlight(char letter) {
            Label label = GetKeyLabel(chosenKey);
            label.BackColor = Color.LightGray;
        }

        private void SetChosenKeyRandomly() {
            int index = RandomHelper.Ranged(0, keysAvailable.Count - 1);
            chosenKey = keysAvailable[index];
        }

        private void Highlight(Char key, Color color) {
            Label label = GetKeyLabel(key);
            label.BackColor = color;
        }

        private void UpdateLabel() {
            launchLabel.Text = $"Launching the {vessels[launchVessel].Name}";
        }

        private void SetupVessels() {
            VesselFactory factory = new VesselFactory();
            Vessel vessel = factory.CreateRocket("Thunder Gun II", ScreenPosition.LaunchPad);
            vessels.Add(vessel);
        }

        private void SetupSprites() {
            foreach (Vessel vessel in vessels) {
                Sprite sprite = new VesselSprite(vessel, Properties.Resources.rocket2, 45, 140);
                sprites.Add(sprite);
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            MoveVessels();
            Refresh();
        }

        private void MoveVessels() {
            foreach (Vessel vessel in vessels) {
                vessel.Thrust();
            }
        }

        private void TypingGameForm_Paint(object sender, PaintEventArgs e) {
            foreach (Sprite sprite in sprites)
                sprite.DrawOn(e.Graphics);
        }

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
        (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private void TypingGameForm_FormClosed(object sender, FormClosedEventArgs e) {
            timer1.Stop();
        }

        private void TypingGameForm_KeyDown(object sender, KeyEventArgs e) {
            
        }
    }
}
