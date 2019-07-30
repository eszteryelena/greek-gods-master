using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;

namespace greek_gods
{
    class blastclass
    {
        public int x, y, width, height;
        public double xSpeed, ySpeed;
        public Image blastImage;//variable for the missile's image
        public int blastRotated;
        public Matrix matrixBlast;//matrix to enable us to rotate missile in the same angle as the spaceship
        public Rectangle blastRec;//variable for a rectangle to place our image in
        Point centreBlast;//centre of missile
        private Rectangle characterRec;

        public blastclass(Rectangle characterRec)
        {
            this.characterRec = characterRec;
        }

        // in the following constructor we pass in the values of spaceRec and the rotation angle of the spaceship
        // this gives us the position of the spaceship which we can then use to place the
        // missile where the spaceship is located and at the correct angle

        public blastclass(Rectangle characterRec, int blastRotate)
        {
            width = 10;
            height = 20;
            blastImage = Image.FromFile("blast.png");
            blastRec = new Rectangle(x, y, width, height);
            //this code works out the speed of the missile to be used in the moveMissile method
            xSpeed = 30 * (Math.Cos((blastRotate - 90) * Math.PI / 180));
            ySpeed = 30 * (Math.Sin((blastRotate + 90) * Math.PI / 180));
            //calculate x,y to move missile to middle of spaceship in drawMissile method
            x = characterRec.X + characterRec.Width / 2;
            y = characterRec.Y + characterRec.Height / 2;
            //pass missileRotate angle to missileRotated so that it can be used in the drawMissile method
            blastRotated = blastRotate;
        }

        public void drawBlast(Graphics g)
        {
            //centre missile 
            centreBlast = new Point(x, y);
            //instantiate a Matrix object called matrixMissile
            matrixBlast = new Matrix();
            //rotate the matrix (in this case missileRec) about its centre
            matrixBlast.RotateAt(blastRotated, centreBlast);
            //Set the current draw location to the rotated matrix point i.e. where missileRec is now
            g.Transform = matrixBlast;
            //Draw the missile
            g.DrawImage(blastImage, blastRec);

        }

        public void moveBlast(Graphics g)
        {
            x += (int)xSpeed;//cast double to an integer value
            y -= (int)ySpeed;
            blastRec.Location = new Point(x, y);//missiles new location

        }
    }

}


