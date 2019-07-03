using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace greek_gods
{

    class villan
    {
        public int x, y, width, height;//variables for the rectangle
        public Image villanImage;//variable for the planet's image
        public Rectangle villanRec;//variable for a rectangle to place our image in
        public int score;

        public villan()
        {
        }

        //Create a constructor (initialises the values of the fields)
        public villan( int spacing)
        {
            x = spacing;
            y = 10;
            width = 20;
            height = 20;
            villanImage = Image.FromFile("object.png");
            villanRec = new Rectangle(x, y, width, height);
        }

            // Methods for the Planet class
            public void drawVillan(Graphics g)
        {
            villanRec = new Rectangle(x, y, width, height);
            g.DrawImage(villanImage, villanRec);
        }

        public void moveVillan()
        {
            villanRec.Location = new Point(x, y);
            if (villanRec.Location.Y > 400)
            {
                score += 1;// add 1 to score when planet reaches bottom of panel
                y = 20;
                villanRec.Location = new Point(x, y);
            }

        }



    }
}
