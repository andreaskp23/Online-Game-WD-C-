﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casino
{
    public partial class berandaAdmin : Form
    {
        public berandaAdmin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginGeneral logingeneral = new loginGeneral();
            logingeneral.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addcash addCash = new addcash();
            addCash.Show();
            this.Hide();
        }
    }
}
