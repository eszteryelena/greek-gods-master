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
    public partial class messageboxpowerups : Form
    {
        public messageboxpowerups()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            level1.earlypowerup = false;

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            level1.powerups = 0;

            if (level1.powerups == 3)
            {
                if (level10_11map.level == 11)
                {
                    this.Hide();
                    level11_12map mbpu = new level11_12map();
                    mbpu.ShowDialog();
                    this.Close();
                }
                else
                {
                    if (level9_10map.level == 10)
                    {
                        if (level10_11map.level == 11)
                        {
                            this.Hide();
                            level11_12map mbpu = new level11_12map();
                            mbpu.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            if (level8_9mapcs.level == 9)
                            {
                                if (level10_11map.level == 11)
                                {
                                    this.Hide();
                                    level11_12map mbpu = new level11_12map();
                                    mbpu.ShowDialog();
                                    this.Close();
                                }
                                else
                                {
                                    if (level7_8map.level == 8)
                                    {
                                        if (level10_11map.level == 11)
                                        {
                                            this.Hide();
                                            level10_11map mbpu = new level10_11map();
                                            mbpu.ShowDialog();
                                            this.Close();
                                        }
                                        else
                                        {
                                            if (level6_7map.level == 7)
                                            {
                                                if (level10_11map.level == 11)
                                                {
                                                    this.Hide();
                                                    level9_10map mbpu = new level9_10map();
                                                    mbpu.ShowDialog();
                                                    this.Close();
                                                }
                                                else
                                                {
                                                    if (level5_6map.level == 6)
                                                    {
                                                        this.Hide();
                                                        level9_10map mbpu = new level9_10map();
                                                        mbpu.ShowDialog();
                                                        this.Close();
                                                    }
                                                    else
                                                    {
                                                        if (level4_5map.level == 5)
                                                        {
                                                            this.Hide();
                                                            level5_6map mbpu = new level5_6map();
                                                            mbpu.ShowDialog();
                                                            this.Close();
                                                        }
                                                        else
                                                        {

                                                            if (level3_4.level == 4)
                                                            {
                                                                this.Hide();
                                                                level5_6map mbpu = new level5_6map();
                                                                mbpu.ShowDialog();
                                                                this.Close();
                                                            }
                                                            else
                                                            {
                                                                if (level2_3map.level == 3)
                                                                {
                                                                    this.Hide();
                                                                    level5_6map mbpu = new level5_6map();
                                                                    mbpu.ShowDialog();
                                                                    this.Close();
                                                                }
                                                                else
                                                                {
                                                                    if (level1_2map.level == 2)
                                                                    {
                                                                        this.Hide();
                                                                        level5_6map mbpu = new level5_6map();
                                                                        mbpu.ShowDialog();
                                                                        this.Close();
                                                                    }
                                                                    else
                                                                    {
                                                                        this.Hide();
                                                                        level5_6map mbpu = new level5_6map();
                                                                        mbpu.ShowDialog();
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
                    }
                }
            }
            else if (level1.powerups == 6)
            {
                if (level10_11map.level == 11)
                {
                    this.Hide();
                    level11_12map mbpu = new level11_12map();
                    mbpu.ShowDialog();
                    this.Close();
                }
                else
                {
                    if (level9_10map.level == 10)
                    {
                        if (level10_11map.level == 11)
                        {
                            this.Hide();
                            level11_12map mbpu = new level11_12map();
                            mbpu.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            if (level8_9mapcs.level == 9)
                            {
                                if (level10_11map.level == 11)
                                {
                                    this.Hide();
                                    level11_12map mbpu = new level11_12map();
                                    mbpu.ShowDialog();
                                    this.Close();
                                }
                                else
                                {
                                    if (level7_8map.level == 8)
                                    {
                                        if (level10_11map.level == 11)
                                        {
                                            this.Hide();
                                            level11_12map mbpu = new level11_12map();
                                            mbpu.ShowDialog();
                                            this.Close();
                                        }
                                        else
                                        {
                                            if (level6_7map.level == 7)
                                            {
                                                if (level10_11map.level == 11)
                                                {
                                                    this.Hide();
                                                    level9_10map mbpu = new level9_10map();
                                                    mbpu.ShowDialog();
                                                    this.Close();
                                                }
                                                else
                                                {
                                                    if (level5_6map.level == 6)
                                                    {
                                                        this.Hide();
                                                        level9_10map mbpu = new level9_10map();
                                                        mbpu.ShowDialog();
                                                        this.Close();
                                                    }
                                                    else
                                                    {
                                                        if (level4_5map.level == 5)
                                                        {
                                                            this.Hide();
                                                            level8_9mapcs mbpu = new level8_9mapcs();
                                                            mbpu.ShowDialog();
                                                            this.Close();
                                                        }
                                                        else
                                                        {

                                                            if (level3_4.level == 4)
                                                            {
                                                                this.Hide();
                                                                level8_9mapcs mbpu = new level8_9mapcs();
                                                                mbpu.ShowDialog();
                                                                this.Close();
                                                            }
                                                            else
                                                            {
                                                                if (level2_3map.level == 3)
                                                                {
                                                                    this.Hide();
                                                                    level8_9mapcs mbpu = new level8_9mapcs();
                                                                    mbpu.ShowDialog();
                                                                    this.Close();
                                                                }
                                                                else
                                                                {
                                                                    if (level1_2map.level == 2)
                                                                    {
                                                                        this.Hide();
                                                                        level5_6map mbpu = new level5_6map();
                                                                        mbpu.ShowDialog();
                                                                        this.Close();
                                                                    }
                                                                    else
                                                                    {
                                                                        this.Hide();
                                                                        level5_6map mbpu = new level5_6map();
                                                                        mbpu.ShowDialog();
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
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    

