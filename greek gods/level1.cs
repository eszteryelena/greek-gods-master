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
        bool left, right;
        int score, lives;
        string move;


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

        private void level1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = false; }
            if (e.KeyData == Keys.Right) { right = false; }
        }

        private void level1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = true; }
            if (e.KeyData == Keys.Right) { right = true; }
        }

        private void tmrHero_Tick(object sender, EventArgs e)
        {
            if (right) // if right arrow key pressed
            {
                move = "right";
                character.moveCharacter(move);
            }
            if (left) // if left arrow key pressed
            {
                move = "left";
                character.moveCharacter(move);
            }

        }

        private void mnuStart_Click(object sender, EventArgs e)
        {
            score = 0;
            txtscore.Text = score.ToString();
            lives = int.Parse(txtLives.Text);// pass lives entered from textbox to lives variable
            tmrVillan.Enabled = true;
            tmrHero.Enabled = true;

        }

        private void mnuStop_Click(object sender, EventArgs e)
        {
            tmrHero.Enabled = false;
            tmrVillan.Enabled = false;
        }

        private void tmrVillan_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                score += villan[i].score;// get score from Planet class (in movePlanet method)
                txtscore.Text = score.ToString();// display score
                villan[i].moveVillan();
                if (character.characterRec.IntersectsWith(villan[i].villanRec))
                {
                    //reset planet[i] back to top of panel
                    villan[i].y = 30; // set  y value of planetRec
                    lives -= 1;// lose a life
                    txtLives.Text = lives.ToString();// display number of lives
                    checkLives();
                }
            }
            pnlGame.Invalidate();
            //makes the paint event fire to redraw the panel

            

        }

        private void checkLives()
        {
            if (lives == 0)
            {
                tmrVillan.Enabled = false;
                tmrHero.Enabled = false;
                MessageBox.Show("Game Over");

            }
        }

    }
}
