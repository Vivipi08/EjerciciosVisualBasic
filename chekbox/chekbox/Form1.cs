﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chekbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {

                Text = checkBox1.Text;
            }

            if (checkBox2.Checked == true)
            {
                Text = checkBox2.Text;
            }

            if (checkBox3.Checked == true)
            {
                Text = checkBox3.Text;
            }
        }
    }
}
