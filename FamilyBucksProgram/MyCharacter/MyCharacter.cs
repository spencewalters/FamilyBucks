using System;
using System.Drawing;
using System.Windows.Forms;

namespace FamilyBucksProgram {
    public partial class MyCharacter : Form {
        Image characterImage;
        Rectangle drawRectangle;

        int xVelocity = 30;
        int yVelocity = 10;

        public MyCharacter() {
            InitializeComponent();

            LoadCharacterImage();
            SetupDrawRectangle();
        }

        private void SetupDrawRectangle() {
            drawRectangle = new Rectangle(20, 20, 70, 70);
        }

        private void LoadCharacterImage() {
            characterImage = Properties.Resources.olivia_at_computer;
        }

        private void closeButton_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private void MyCharacter_Paint(object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;
            g.DrawImage(characterImage, drawRectangle);
        }

        private void timer1_Tick(object sender, EventArgs e) {
            drawRectangle.X += xVelocity;
            drawRectangle.Y += yVelocity;

            if (drawRectangle.X > (this.Width - drawRectangle.Width))
                xVelocity = -30;
            else if (drawRectangle.X < 1)
                xVelocity = 30;

            if (drawRectangle.Y > (this.Height - drawRectangle.Height))
                yVelocity = -10;
            else if (drawRectangle.Y < 1)
                yVelocity = 10;

            Invalidate();
        }
    }
}
