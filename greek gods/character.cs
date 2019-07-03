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
        //decalres an int called megara
        
        public int x, y, width, height;//variables for the rectangle
        public Image characterImage;//variable for the planet's image
        public Image characterImage2;//variable for the planet's image
        public Rectangle characterRec;//variable for a rectangle to place our image in
                                      //Create a constructor (initialises the values of the fields)

        //private selectCharacter slctChar;

        public character()
        {
           //this.megara = megara;
            x = 10;
            y = 360;
            width = 40;
            height = 40;
            characterRec = new Rectangle(x, y, width, height);
            characterImage = Image.FromFile("object.png");
            characterImage2 = Image.FromFile("statue1.png");

        }

        public void drawCharacter(Graphics g)
        {
            characterRec = new Rectangle(x, y, width, height);
           

            if (selectCharacter.variable1 == 1){
                g.DrawImage(characterImage, characterRec);
               }
            else
            {
                g.DrawImage(characterImage2, characterRec);
            }
        }

        //public character(int megara)
       // {
           // this.megara = megara;
           
         //   }
        }

    

}



