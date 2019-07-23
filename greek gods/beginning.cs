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
    public partial class beginning : Form
    {
        //this will switch from this form to select Character
        // ghgfhvghuvgfyu 
        public static string SetValueForText1 = "";
        public beginning()
        {
            InitializeComponent();
        }

        private void play_Click(object sender, EventArgs e)
        {
            this.Hide();
            SetValueForText1 = txtboxName.Text;
            selectCharacter sc = new selectCharacter();
            sc.ShowDialog();
            this.Close();
        }

        private void play_MouseHover(object sender, EventArgs e)
        {
            play.ForeColor = Color.FromArgb(187, 202, 221);
        }

        private void play_MouseLeave(object sender, EventArgs e)
        {
            play.ForeColor = Color.White;
        }

        private void beginning_Load(object sender, EventArgs e)
        {

        }

        private void mnuStart_Click(object sender, EventArgs e)
        {

        }

        private void beginning_Shown(object sender, EventArgs e)
        {
            txtboxName.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtboxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
