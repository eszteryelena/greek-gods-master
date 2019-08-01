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
        public Image villanImage2;//variable for the planet's image
        public Rectangle villanRec;//variable for a rectangle to place our image in
        public int score;

        public villan()
        {
        }

        //Create a constructor (initialises the values of the fields)
        public villan( int spacing)
        {
            y = spacing; //changed
            x = 10; //changed
            width = 20;
            height = 20;
            villanImage = Image.FromFile("object.png");
            villanImage2 = Image.FromFile("hydra.png");
            villanRec = new Rectangle(x, y, width, height);
        }

            // Methods for the Planet class
            public void drawVillan(Graphics g)
        {
            if (level1_2map.level == 2)
            {
                villanRec = new Rectangle(x, y, width, height);
                g.DrawImage(villanImage2, villanRec);
            }
            else
            {
                villanRec = new Rectangle(x, y, width, height);
                g.DrawImage(villanImage, villanRec);
            }
        }
            

        public void moveVillan()
        {
            villanRec.Location = new Point(x, y);
            if (villanRec.Location.X > 400) //changed
            {
                score += 1;// add 1 to score when planet reaches bottom of panel
                x = 20; //changed
                villanRec.Location = new Point(x, y);
            }

        }



    }
}
