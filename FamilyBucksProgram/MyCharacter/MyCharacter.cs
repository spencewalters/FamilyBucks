using System;
using System.Drawing;
using System.Windows.Forms;

namespace FamilyBucksProgram {
    public partial class MyCharacter : Form {
        Image characterBody, characterHead;
        Rectangle bodyRectangle, headRectangle;
        Point characterLocation;
        Point groundLocation;

        enum Direction { Left, Right };
        Direction direction = Direction.Left;
        double leftRightInertia = 30, sidewaysInertia = 0, friction = 5;
        double jumpInertia = 60, verticalInertia = 0, gravity = 30;
        private double appliedFriction;
        private int characterWidth = 160;
        private int characterHeight = 200;

        public MyCharacter() {
            InitializeComponent();

            groundLocation = new Point(300, 175);
            SetControls();
            LoadCharacterImage();
            SetupCharacterPosition();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            UpdateLocation();
            Refresh();
        }

        private void SetControls() {
            jumpCtrl.Value = (decimal)jumpInertia;
            gravityCtrl.Value = (decimal)gravity;
            lurchCtrl.Value = (decimal)leftRightInertia;
            frictionCtrl.Value = (decimal)friction;
        }

        private void SetupCharacterPosition() {
            characterLocation = new Point(groundLocation.X, groundLocation.Y);

            LocateAt(characterLocation);
        }

        private void LocateAt(Point point) {
            headRectangle = new Rectangle(point.X, point.Y, 50, 50);
            bodyRectangle = new Rectangle(point.X - 55, point.Y + 48, characterWidth, characterHeight);
        }

        private void LoadCharacterImage() {
            characterBody = Properties.Resources.body;
            characterHead = Properties.Resources.head;
        }

        private void closeButton_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private void MyCharacter_Paint(object sender, PaintEventArgs e) {

            Graphics g = e.Graphics;

            DrawCharacter(g);
        }
        
        private void MyCharacter_KeyDown(object sender, KeyEventArgs e) {

            switch (e.KeyCode) {
                case (Keys.A):
                    MoveLeft();                    
                    break;
                case (Keys.F):
                    MoveRight();
                    break;
                case (Keys.E):
                    Jump();
                    break;
                default:
                    break;
            }

            e.Handled = true;
        }


        private void MyCharacter_KeyUp(object sender, KeyEventArgs e) {
            switch (e.KeyCode) {
                case (Keys.A):                  
                case (Keys.F):
                    appliedFriction = friction;
                    break;
                case (Keys.E):
                    break;
                default:
                    break;
            }
        }


        private void MoveRight() {
            direction = Direction.Right;
            sidewaysInertia = leftRightInertia;
            appliedFriction = 0;
        }

        private void MoveLeft() {
            direction = Direction.Left;
            sidewaysInertia = leftRightInertia;
            appliedFriction = 0;
        }

        private void Jump() {
            if (characterLocation.Y == groundLocation.Y) {
                verticalInertia = jumpInertia;
            }
        }
        private void jumpCtrl_ValueChanged(object sender, EventArgs e) {
            jumpInertia = (double)jumpCtrl.Value;
        }

        private void gravityCtrl_ValueChanged(object sender, EventArgs e) {
            gravity = (double)gravityCtrl.Value;
        }

        private void lurchCtrl_ValueChanged(object sender, EventArgs e) {
            leftRightInertia = (double)lurchCtrl.Value;
        }

        private void frictionCtrl_ValueChanged(object sender, EventArgs e) {
            friction = (double)frictionCtrl.Value;
        }

        private void DrawCharacter(Graphics g) {
            g.DrawImage(characterBody, bodyRectangle);
            g.DrawImage(characterHead, headRectangle);
        }

        private void UpdateLocation() {
            HandleMovement();
            RelocateOnMovement();
            StopMovement();
        }

        private void StopMovement() {
            UpdateLateralInertia();
            UpdateVerticalInertia();
        }

        private void RelocateOnMovement() {
            LocateAt(characterLocation);
        }

        private void HandleMovement() {

            if (direction == Direction.Left)
                characterLocation.X -= (int)sidewaysInertia;
            else if (direction == Direction.Right)
                characterLocation.X += (int)sidewaysInertia;
            
            characterLocation.Y -= (int)verticalInertia;
            if (characterLocation.Y > groundLocation.Y)
                characterLocation.Y = groundLocation.Y;

            if (characterLocation.X < 1)
                characterLocation.X = 1;
            else if (characterLocation.X > (Width - characterWidth))
                characterLocation.X = Width - characterWidth;
        }

        private void UpdateVerticalInertia() {
            if (characterLocation.Y < groundLocation.Y) {
                verticalInertia -= gravity;
            }
            else if (characterLocation.Y > groundLocation.Y) {
                characterLocation.Y = groundLocation.Y;
                verticalInertia = 0;
            }
        }

        private void UpdateLateralInertia() {

            if (sidewaysInertia <= appliedFriction)
                sidewaysInertia = 0;
            else if (sidewaysInertia > appliedFriction)
                sidewaysInertia -= appliedFriction;
        }

    }
}
