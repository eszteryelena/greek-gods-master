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
    public partial class level6_7map : Form
    {
        public static int level;
        public level6_7map()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            level = 7;
            level1 l7 = new level1();
            l7.ShowDialog();
            this.Close();
        }
    }
}
