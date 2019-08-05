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
    public partial class level7_8map : Form
    {
        public static int level;
        public level7_8map()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            level = 8;
            level1 l8 = new level1();
            l8.ShowDialog();
            this.Close();
        }
    }
}
