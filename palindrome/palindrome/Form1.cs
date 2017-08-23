using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace palindrome
{

    //CRTRE UN PROGRAMA QUE PIDA EL INGRESO DE UN A FRASE IDENTIFIQUE SI ES PALINDROME Y LA ESCRIOBA AL REVEZ 
    //EJEMPLO "ANITA LAVA LA TINA "
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Text = "";
            if (checkBox1.Checked == true)
            {
                Text = Text + "(" + checkBox1.Text + ")";

            }
            if (checkBox2.Checked == true)
            {
                Text = Text + "(" + checkBox2.Text + ")";

            }
            if (checkBox3.Checked == true)
            {
                Text = Text + "(" + checkBox3.Text + ")";

            }
        }
    }
}
