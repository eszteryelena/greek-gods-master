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
    public partial class level2_3map : Form
    {
        public static int level;
        public level2_3map()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            level = 3;
            level1 l3 = new level1();
            l3.ShowDialog();
            this.Close();
        }
    }
}
