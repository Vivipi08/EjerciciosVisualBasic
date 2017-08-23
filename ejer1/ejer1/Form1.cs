using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejer1
{

    //realizar un ejercicio en el cual nos muestre el salario de un trabajador 
    //teniendo encuenta que si trabaja cuarenta horas o menos el valor de su hora 
    //sera 5000 pesos de lo contrario si el trabajador trabajo 40 horas o mas tomandose com ohotas 
    //extras el valor de la hora sera de 7000 pesos imprimir el salario del trabajador 
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
            if (int.Parse(textBox2.Text) > 40)
            {

                (textBox3.Text) = "7000" ;


                MessageBox.Show("supero las 40 horas ");

            }

            else
            {
                (textBox3.Text) = "5000";
                MessageBox.Show("no supero las 40 horas la hora cuesta 5000");


             
            }
            textBox1.Text = (double.Parse(textBox2.Text) * double.Parse(textBox3.Text)).ToString();

            
        }
    }
}
