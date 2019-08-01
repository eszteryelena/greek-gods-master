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
    public partial class selectCharacter : Form
    {
        character character = new character();
        public static int variable1;
        // declaration in form1
        public selectCharacter()
        {
            InitializeComponent();
            timer1.Enabled = false;
        }

        private void chose1_Click(object sender, EventArgs e)
        {
            //this openes a new level one form
            this.Hide();
            level1 fl1 = new level1();
            //timer1.Enabled = true;
            fl1.ShowDialog();
            this.Close();
        }

        private void chose1_MouseHover(object sender, EventArgs e)
        {
            chose1.ForeColor = Color.FromArgb(187, 202, 221);
        }

        private void chose1_MouseLeave(object sender, EventArgs e)
        {
            chose1.ForeColor = Color.White;
        }

        private void chose2_Click(object sender, EventArgs e)
        {
            //this openes a new level one form
            this.Hide();
            //character.characterImage = Image.FromFile("object.png");
            variable1 = 1;
            level1 fl1 = new level1();
            fl1.ShowDialog();
            this.Close();
        }

        private void chose2_MouseHover(object sender, EventArgs e)
        {
            chose2.ForeColor = Color.FromArgb(187, 202, 221);

        }

        private void chose2_MouseLeave(object sender, EventArgs e)
        {
            chose2.ForeColor = Color.White;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void selectCharacter_Load(object sender, EventArgs e)
        {

        }
    }
}
