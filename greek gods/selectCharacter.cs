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

        public int megara =0;
        public selectCharacter()
        {
            InitializeComponent();
        }

        private void chose1_Click(object sender, EventArgs e)
        {
            //this openes a new level one form
            this.Hide();
            level1 fl1 = new level1();
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
            megara = 1;
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


    }
}
