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
    public partial class level4_5map : Form
    {
        public static int level;
        public level4_5map()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            level = 5;
            level1 l5 = new level1();
            l5.ShowDialog();
            this.Close();
        }
    }
}
