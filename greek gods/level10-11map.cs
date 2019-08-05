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
    public partial class level10_11map : Form
    {
        public static int level;
        public level10_11map()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            level = 11;
            level1 l11 = new level1();
            l11.ShowDialog();
            this.Close();
        }
    }
}
