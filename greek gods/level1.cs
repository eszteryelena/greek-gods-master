using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace greek_gods
{
    public partial class level1 : Form
    {
        Graphics g; //declare a graphics object called g
        villan[] villan = new villan[7]; //create the object, planet1
        Random xspeed = new Random();
        character character = new character();
        //bool left, right;
        bool up, down;
        bool isMouseDown = false;
        int score, lives;
        string move;


        public level1()
        {
            InitializeComponent();

            for (int i = 0; i < 7; i++)
            {
                int x = 7 + (i * 75);
                villan[i] = new villan(x);
            }
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty |
            BindingFlags.Instance | BindingFlags.NonPublic, null, pnlGame, new object[] { true });
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
                int rndmspeed = xspeed.Next(5, 20);
                villan[i].x += rndmspeed;

                //call the Planet class's drawPlanet method to draw the images
                villan[i].drawVillan(g);
            }


        }

        private void level1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { up = false; }
            if (e.KeyData == Keys.Right) { down = false; }
        }

        private void level1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { up = true; }
            if (e.KeyData == Keys.Right) { down = true; }
        }

        private void tmrHero_Tick(object sender, EventArgs e)
        {
            //  if (up) // if right arrow key pressed
            //  {
            //      move = "up";
            //     character.moveCharacter(move);
            // }
            // if (down) // if left arrow key pressed
            //  {
            //     move = "down";
            //     character.moveCharacter(move);
            // }
            Invalidate();
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

        private void level1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown == true)
            {
                character.characterRec.Width = MousePosition.X - character.characterRec.Width;
                character.characterRec.Height = MousePosition.Y - character.characterRec.Height;
            }
            Refresh();

        }

        private void level1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void level1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
        }

        private void tmrFollow_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }




        //private void tmrFollow_Tick(object sender, EventArgs e)
        // {
        //     pictureBox1.Left = MousePosition.X;//- pictureBox1.Width;
        //  pictureBox1.Top = MousePosition.Y; //- pictureBox1.Height;
        //}

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

