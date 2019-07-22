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


        public character()
        {
           //this.megara = megara;
            x = 360;
            y = 360;
            width = 35;
            height = 55;
            characterRec = new Rectangle(x, y, width, height);
            characterImage = Image.FromFile("megaraselect.png");
            characterImage2 = Image.FromFile("herculesselect.png");

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

//       public void moveCharacter(string move)
 //       {
 //           characterRec.Location = new Point(x, y);
 //
   //         if (move == "down")
     //       {
//                if (characterRec.Location.Y > 450) // is spaceship within 50 of right side
  //              {
  //
    //                y = 450;
      //              characterRec.Location = new Point(x, y);
        //        }
          //      else
            //    {
              //      y += 5;
                //    characterRec.Location = new Point(x, y);
   //             }

   //         }
   //
     //       if (move == "up")
  //          {
    //            if (characterRec.Location.Y < 10) // is spaceship within 10 of left side
      //          {
//
  //                  y = 10;
    //                characterRec.Location = new Point(x, y);
      //          }
        //        else
          //      {
        //            y -= 5;
             //       characterRec.Location = new Point(x, y);
           //     }

         //   }


       // }

       
        // public void moveCharacter(int mouseX, int mouseY)
       // {
       //     characterRec.X = mouseX;
      //     characterRec.Y = mouseY;
       // }

        
    }
}



