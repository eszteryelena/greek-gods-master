using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace greek_gods
{
    public partial class level1 : Form
    {
        Graphics g; //declare a graphics object called g
        villan[] villan = new villan [7]; //create the object, planet1
        Random yspeed = new Random();
        character character = new character();

        public level1()
        {
            
            InitializeComponent();
            for (int i = 0; i < 7; i++)
            {
                int x = 10 + (i * 75);
                villan[i] = new villan(x);
            }

        }

        private void level1_Load(object sender, EventArgs e)
        {

        }

        private void pnlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the panel control
            g = e.Graphics;
            character.drawCharacter(g);
            //call the Planet class's DrawPlanet method to draw the image planet1 
            for (int i = 0; i < 7; i++)
            {
                int rndmspeed = yspeed.Next(5, 20);
                villan[i].y += rndmspeed;

                //call the Planet class's drawPlanet method to draw the images
                villan[i].drawVillan(g);
            }

            
        }

        private void tmrVillan_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                villan[i].moveVillan();
            }
            pnlGame.Invalidate();
              
                //makes the paint event fire to redraw the panel

        }
    }
}
