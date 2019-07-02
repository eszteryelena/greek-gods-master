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
        public beginning()
        {
            InitializeComponent();
        }

        private void play_Click(object sender, EventArgs e)
        {
            this.Hide();
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
    }
}
