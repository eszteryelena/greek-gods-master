﻿using System;
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
    public partial class level5_6map : Form
    {
        public static int level;
        public level5_6map()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            level = 6;
            level1 l6 = new level1();
            l6.ShowDialog();
            this.Close();
        }
    }
}
