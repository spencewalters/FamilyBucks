using System.Drawing;

namespace FamilyBucksProgram.TypingGame {
    class VesselSprite :  Sprite {
        Vessel vessel;
        Image image;
        Rectangle vesselRectangle;

        public VesselSprite(Vessel vessel, Image image, int width, int height) {
            this.vessel = vessel;
            SetImage(image);
            
            vesselRectangle = new Rectangle(vessel.Longitude, vessel.Altitude, width, height);
        }

        public ScreenPosition Position => new ScreenPosition(vessel.Longitude, vessel.Altitude, vessel.Latitude);

        public void DrawOn(Graphics g) {
            vesselRectangle.X = Position.X;
            vesselRectangle.Y = Position.Y;
            g.DrawImage(image, vesselRectangle);
        }

        public void SetImage(Image image) {
            this.image = image;
        }
    }
}
