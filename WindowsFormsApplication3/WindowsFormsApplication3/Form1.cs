using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // un entrenador le propone a un atleta recorrer una ruta de 5 kilometros 
        //durante 10 dias para determinar si es apto para la prueba de 5 kilometros, 
        //o debe buscar otra especialidad para considerarlo apto debe cumplir por
        // lo menos una de las siguientes condiciones que en ninguna de las pruebas  
        //haga un tiempo mayor a 16 minutos que al menos una de las pruebas realiza 
        //un tiempo mayor a 16 minutos que su promedio de tiempo sea menor o 
        //igual a 15 minutos
        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            double.Parse(textBox1.Text);
            double.Parse(textBox2.Text);
            double.Parse(textBox3.Text);


            textBox4.Text = (double.Parse(textBox1.Text) + (double.Parse(textBox2.Text) + (double.Parse(textBox3.Text)ToString() ;
        }

        
    }
}
