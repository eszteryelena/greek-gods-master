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
    public partial class level9_10map : Form
    {
        public static int level;
        public level9_10map()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            level = 10;
            level1 l10 = new level1();
            l10.ShowDialog();
            this.Close();
        }
    }
}
