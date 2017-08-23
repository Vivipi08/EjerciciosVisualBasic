using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {




        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        { 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double A, B, SUMA, RESTA;

            A = double.Parse(textBox1.Text);
            B = double.Parse(textBox2.Text);


            if (radioButton1.Checked == true)
            {
                

                SUMA = A + B;

                Text = SUMA.ToString();
            }

            else
            {

                if (radioButton1.Checked == true)
                {
                    A = double.Parse(textBox1.Text);
                    B = double.Parse(textBox2.Text);

                    RESTA = A - B;

                    Text = RESTA.ToString();
                }

            }
        }
    }
}