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
        public int megara;
        public int x, y, width, height;//variables for the rectangle
        public Image characterImage;//variable for the planet's image
        public Rectangle characterRec;//variable for a rectangle to place our image in
        //Create a constructor (initialises the values of the fields)
        public character()
        {

            x = 10;
            y = 350;
            width = 30;
            height = 50;

            //if megara equals one then the character will be megara
            if (megara == 1)
                characterImage = Image.FromFile("megaraselect.png");
            characterRec = new Rectangle(x, y, width, height);

            //if megara = 1{
            //  characterImage = Image.FromFile("human1.png");
            //characterRec = new Rectangle(x, y, width, height);
        }

        public character(int megara)
        {
            this.megara = megara;
           
            }
        }
    }
                

    
