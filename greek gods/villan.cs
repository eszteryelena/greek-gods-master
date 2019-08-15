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
        public Rectangle villanRec;//variable for a rectangle to place our image in
        public int score;

        //these are the images for the antagonist of each of the levels// 
        // the corresonding antagonist to hercules labours.
        public Image villanImage1;//variable for the planet's image
        public Image villanImage2;//variable for the planet's image
        public Image villanImage3;//variable for the planet's image
        public Image villanImage4;//variable for the planet's image
        public Image villanImage5;//variable for the planet's image
        public Image villanImage6;//variable for the planet's image
        public Image villanImage7;//variable for the planet's image
        public Image villanImage8;//variable for the planet's image
        public Image villanImage9;//variable for the planet's image
        public Image villanImage10;//variable for the planet's image
        public Image villanImage11;//variable for the planet's image
        public Image villanImage12;//variable for the planet's image
       

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
            villanImage1 = Image.FromFile("object.png");
            villanImage2 = Image.FromFile("hydra.png");
            villanImage3 = Image.FromFile("arrow.png");
            villanImage4 = Image.FromFile("boar.png");
            villanImage5 = Image.FromFile("rake.png");
            villanImage6 = Image.FromFile("feather.png");
            villanImage7 = Image.FromFile("bull2.png");
            villanImage8 = Image.FromFile("horse-shoe.png");
            villanImage9 = Image.FromFile("spear.png");
            villanImage10 = Image.FromFile("dogs.png");
            villanImage11 = Image.FromFile("earth.png");
            villanImage12 = Image.FromFile("fire.png");

            villanRec = new Rectangle(x, y, width, height);
        }

            // Methods for the Planet class
            public void drawVillan(Graphics g)
        {
            if (level10_11map.level == 12)
            {
                villanRec = new Rectangle(x, y, width, height);
                g.DrawImage(villanImage12, villanRec);
            }
            else
            {
                if (level10_11map.level == 11)
                {
                    villanRec = new Rectangle(x, y, width, height);
                    g.DrawImage(villanImage11, villanRec);
                }
                else
                {
                    if (level9_10map.level == 10)
                    {
                        villanRec = new Rectangle(x, y, width, height);
                        g.DrawImage(villanImage10, villanRec);
                    }
                    else
                    {
                        if (level8_9mapcs.level == 9)
                        {
                            villanRec = new Rectangle(x, y, width, height);
                            g.DrawImage(villanImage9, villanRec);
                        }
                        else
                        {
                            if (level7_8map.level == 8)
                            {
                                villanRec = new Rectangle(x, y, width, height);
                                g.DrawImage(villanImage8, villanRec);
                            }
                            else
                            {
                                if (level6_7map.level == 7)
                                {
                                    villanRec = new Rectangle(x, y, width, height);
                                    g.DrawImage(villanImage7, villanRec);
                                }
                                else
                                {
                                    if (level5_6map.level == 6)
                                    {
                                        villanRec = new Rectangle(x, y, width, height);
                                        g.DrawImage(villanImage6, villanRec);
                                    }
                                    else
                                    {
                                        if (level4_5map.level == 5)
                                        {
                                            villanRec = new Rectangle(x, y, width, height);
                                            g.DrawImage(villanImage5, villanRec);
                                        }
                                        else
                                        {
                                            if (level3_4.level == 4)
                                            {
                                                villanRec = new Rectangle(x, y, width, height);
                                                g.DrawImage(villanImage4, villanRec);
                                            }
                                            else
                                            {
                                                if (level2_3map.level == 3)
                                                {
                                                    villanRec = new Rectangle(x, y, width, height);
                                                    g.DrawImage(villanImage3, villanRec);
                                                }
                                                else
                                                {
                                                    if (level1_2map.level == 2)
                                                    {
                                                        villanRec = new Rectangle(x, y, width, height);
                                                        g.DrawImage(villanImage2, villanRec);
                                                    }
                                                    else
                                                    {
                                                        villanRec = new Rectangle(x, y, width, height);
                                                        g.DrawImage(villanImage1, villanRec);
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
            

        public void moveVillan()
        {
            villanRec.Location = new Point(x, y);
            if (villanRec.Location.X > 450) //changed
            {
                score += 1;// add 1 to score when planet reaches bottom of panel
                x = 20; //changed
                villanRec.Location = new Point(x, y);
            }

        }



    }
}
