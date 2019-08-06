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
        int score, lives;
        int blastSpeed = 200;
        bool shooting = false;

        
        public level1()
        {
            InitializeComponent();
            blast.Top = -100;
            blast.Left = -100;

            for (int i = 0; i < 7; i++)
            {
                int x = 7 + (i * 75);
                villan[i] = new villan(x);
            }
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty |
            BindingFlags.Instance | BindingFlags.NonPublic, null, pnlGame, new object[] { true });

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
        private void level1_Load(object sender, EventArgs e)
        {
            txtName.Text = beginning.SetValueForText1;
        }

        private void tmrHero_Tick(object sender, EventArgs e)
        {
            character.characterRec.Y = MousePosition.Y - (character.characterRec.Height / 2);
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


        private void txtscore_TextChanged(object sender, EventArgs e)
        {

        }

        private void enemyhit()
        {
            for (int i = 0; i < 7; i++)
            {
                villan[i].moveVillan();
                if (blast.Bounds.IntersectsWith(villan[i].villanRec))
                {
                    //reset planet[i] back to top of panel
                    villan[i].x = 10; // set  y value of planetRec
                    score += 1;// lose a life
                    txtscore.Text = score.ToString();// display number of lives
                    blastSpeed = 0;
                    blast.Top = 380;
                    blast.Left = 360;
                    shooting = false;
                }
            }
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
                    villan[i].x = 10; // set  y value of planetRec
                    lives -= 1;// lose a life
                    txtLives.Text = lives.ToString();// display number of lives
                    checkLives();
                }
                if (level11_12map.level == 12)
                {
                    if (score >= 500)
                    {
                        
                        tmrVillan.Enabled = false;
                        tmrHero.Enabled = false;
                     
                    }
                }

                else
                {
                    if (level10_11map.level == 11)
                    {
                        if (score >= 500)
                        {
                            this.Hide();
                            tmrVillan.Enabled = false;
                            tmrHero.Enabled = false;
                            level10_11map l10to11m = new level10_11map();
                            l10to11m.ShowDialog();
                            this.Close();
                        }
                    }
                    else
                    {
                        if (level9_10map.level == 10)
                        {
                            if (score >= 500)
                            {
                                this.Hide();
                                tmrVillan.Enabled = false;
                                tmrHero.Enabled = false;
                                level9_10map l9to10m = new level9_10map();
                                l9to10m.ShowDialog();
                                this.Close();
                            }
                        }

                        else
                        {
                            if (level8_9mapcs.level == 9)
                            {
                                if (score >= 500)
                                {
                                    this.Hide();
                                    tmrVillan.Enabled = false;
                                    tmrHero.Enabled = false;
                                    level8_9mapcs l8to9m = new level8_9mapcs();
                                    l8to9m.ShowDialog();
                                    this.Close();
                                }
                            }

                            else
                            {
                                if (level7_8map.level == 8)
                                {
                                    if (score >= 500)
                                    {
                                        this.Hide();
                                        tmrVillan.Enabled = false;
                                        tmrHero.Enabled = false;
                                        level7_8map l7to8m = new level7_8map();
                                        l7to8m.ShowDialog();
                                        this.Close();
                                    }
                                }
                                else
                                {
                                    if (level6_7map.level == 7)
                                    {
                                        if (score >= 500)
                                        {
                                            this.Hide();
                                            tmrVillan.Enabled = false;
                                            tmrHero.Enabled = false;
                                            level6_7map l6to7m = new level6_7map();
                                            l6to7m.ShowDialog();
                                            this.Close();
                                        }
                                    }

                                    else
                                    {
                                        if (level5_6map.level == 6)
                                        {
                                            if (score >= 500)
                                            {
                                                this.Hide();
                                                tmrVillan.Enabled = false;
                                                tmrHero.Enabled = false;
                                                level6_7map l6to7m = new level6_7map();
                                                l6to7m.ShowDialog();
                                                this.Close();
                                            }
                                        }

                                        else
                                        {
                                            if (level4_5map.level == 5)
                                            {
                                                if (score >= 500)
                                                {
                                                    this.Hide();
                                                    tmrVillan.Enabled = false;
                                                    tmrHero.Enabled = false;
                                                    level5_6map l5to6m = new level5_6map();
                                                    l5to6m.ShowDialog();
                                                    this.Close();
                                                }
                                            }

                                            else
                                            {
                                                if (level3_4.level == 4)
                                                {
                                                    if (score >= 500)
                                                    {
                                                        this.Hide();
                                                        tmrVillan.Enabled = false;
                                                        tmrHero.Enabled = false;
                                                        level4_5map l4to5m = new level4_5map();
                                                        l4to5m.ShowDialog();
                                                        this.Close();
                                                    }
                                                }
                                                else
                                                {
                                                    if (level2_3map.level == 3)
                                                    {
                                                        if (score >= 500)
                                                        {
                                                            this.Hide();
                                                            tmrVillan.Enabled = false;
                                                            tmrHero.Enabled = false;
                                                            level3_4 l3to4m = new level3_4();
                                                            l3to4m.ShowDialog();
                                                            this.Close();
                                                        }

                                                    }
                                                    else
                                                    {
                                                        if (level1_2map.level == 2)
                                                        {
                                                            if (score >= 500)
                                                            {
                                                                this.Hide();
                                                                tmrVillan.Enabled = false;
                                                                tmrHero.Enabled = false;
                                                                level2_3map l1to2m = new level2_3map();
                                                                l1to2m.ShowDialog();
                                                                this.Close();
                                                            }

                                                        }

                                                        else
                                                        {
                                                            if (score >= 200)
                                                            {
                                                                this.Hide();
                                                                tmrVillan.Enabled = false;
                                                                tmrHero.Enabled = false;
                                                                level1_2map l1to2m = new level1_2map();
                                                                l1to2m.ShowDialog();
                                                                this.Close();
                                                            }

                                                        }
                                                    }
                                                }
                                            }
                                        }


                                    }
                                }
                            }
                        }

                    }
                }
               

                pnlGame.Invalidate();
                //makes the paint event fire to redraw the panel
            }
        }


        private void onKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (shooting == false)
                {
                    blastSpeed = 200;
                    blast.Left = character.characterRec.X + 50;
                    blast.Top = character.characterRec.Y;
                    shooting = true;

                }
            }
        }


        private void tmrBlast_Tick(object sender, EventArgs e)
        {
            blast.Left -= blastSpeed;
            if (shooting && blast.Left < 0)
            {
                shooting = false;
                blastSpeed = 0;
                blast.Top = -100;
                blast.Left = -100;
                enemyhit();
            }
            
        }

        private void tmrLevel_Tick(object sender, EventArgs e)
        {
            //level two
            if (level11_12map.level == 12)
            {
                this.BackgroundImage = Properties.Resources.twelve;
            }
            else
            {
                if (level10_11map.level == 11)
                {
                    this.BackgroundImage = Properties.Resources.eleven;
                }
                else
                {
                    if (level9_10map.level == 10)
                    {
                        this.BackgroundImage = Properties.Resources.ten;
                    }
                    else
                    {
                        if (level8_9mapcs.level == 9)
                        {
                            this.BackgroundImage = Properties.Resources.nine;
                        }
                        else
                        {
                            if (level7_8map.level == 8)
                            {
                                this.BackgroundImage = Properties.Resources.eight;
                            }
                            else
                            {
                                if (level6_7map.level == 7)
                                {
                                    this.BackgroundImage = Properties.Resources.seven;
                                }
                                else
                                {
                                    if (level5_6map.level == 6)
                                    {
                                        this.BackgroundImage = Properties.Resources.six;
                                    }
                                    else
                                    {
                                        if (level4_5map.level == 5)
                                        {
                                            this.BackgroundImage = Properties.Resources.five;
                                        }
                                        else
                                        {

                                            if (level3_4.level == 4)
                                            {
                                                this.BackgroundImage = Properties.Resources.four;
                                            }
                                            else
                                            {
                                                if (level2_3map.level == 3)
                                                {
                                                    this.BackgroundImage = Properties.Resources.three;
                                                }
                                                else
                                                {
                                                    if (level1_2map.level == 2)
                                                    {
                                                        this.BackgroundImage = Properties.Resources.wo;
                                                    }
                                                    else
                                                    {
                                                        this.BackgroundImage = Properties.Resources.one;
                                                    }
                                                }

                                            }

                                        }

                                    }
                                }
                            }
                        }

                    }
                }

            }

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

