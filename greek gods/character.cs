using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace greek_gods
{
    class character
    {
        public int x, y, width, height;//variables for the rectangle
        public Image characterImage;//variable for the planet's image
        public Image characterImage2;//variable for the planet's image
        public Rectangle characterRec;//variable for a rectangle to place our image in


        //Create a constructor (initialises the values of the fields)
        public character()
        {
           //this.megara = megara;
            x = 380;
            y = 360;
            width = 35;
            height = 55;
            characterRec = new Rectangle(x, y, width, height);
            

            characterImage = Image.FromFile("megaraselect.png");
            characterImage2 = Image.FromFile("herculesselect.png");

        }

        public void drawCharacter(Graphics g)
        {
            if (selectCharacter.variable1 == 1){
                g.DrawImage(characterImage, characterRec);
               }
            else
            {
                g.DrawImage(characterImage2, characterRec);
            }
        }



    }
}



