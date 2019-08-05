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
    public partial class level3_4 : Form
    {
        public static int level;
        public level3_4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            level = 4;
            level1 l4 = new level1();
            l4.ShowDialog();
            this.Close();
        }
    }
}
