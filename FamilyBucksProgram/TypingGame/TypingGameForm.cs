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

        public BankTransaction ResultTransaction { get; internal set; }

        public TypingGameForm() {
            ResultTransaction = BankTransaction.Empty;

            InitializeComponent();

            SetupVessels();
            SetupSprites();
            UpdateLabel();
        }

        private void UpdateLabel() {
            launchLabel.Text = $"Launching the {vessels[launchVessel].Name}";
        }

        private void SetupVessels() {
            VesselFactory factory = new VesselFactory();
            Vessel vessel = factory.CreateRocket("Thunder Gun I", ScreenPosition.LaunchPad);
            vessels.Add(vessel);

            Vessel vessel2 = factory.CreateRocket("Shuttle Up", ScreenPosition.RandomGround);
            vessels.Add(vessel2);

            Vessel vessel3 = factory.CreateRocket("Skybound", ScreenPosition.RandomGround);
            vessels.Add(vessel3);
        }

        private void SetupSprites() {
            foreach (Vessel vessel in vessels) {
                Sprite sprite = new VesselSprite(vessel, Properties.Resources.rocket2, 45, 140);
                sprites.Add(sprite);
            }

        }

        private void timer1_Tick(object sender, EventArgs e) {
            LaunchAnother();
            MoveVessels();
            Refresh();
        }

        private void LaunchAnother() {
            if (currentFrame > delayBetween) {
                currentFrame = 0;
                if (launchVessel < (vessels.Count - 1)) {
                    launchVessel++;
                    UpdateLabel();
                }
            }
            else
                currentFrame++;
        }

        private void MoveVessels() {
            int current = 0;
            foreach (Vessel vessel in vessels) {
                if (current <= launchVessel)
                    vessel.Thrust();

                current++;
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
    }
}
