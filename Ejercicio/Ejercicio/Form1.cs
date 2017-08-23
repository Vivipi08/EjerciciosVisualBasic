using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
//Una persona debe realizar un muestreo con 50 personas para determinar el promedio de peso  de los niños, jovenes, adultos y viejos que existen en su zona 
//habitacional, se determinan las categorias en base en la siguiente tabla:
//niños 0-12
//jovenes 13-29
//adultos 30- 59
//viejos 60 en adelante 


        }


        double niños =0;
        double i=0;
        double porcentaje=0;
        string    peso;

        
        private void button1_Click(object sender, EventArgs e)
        {
            while (i >= 5)
            {
                peso = Interaction.InputBox("Ingrese el peso de cada Niño", "PESO NIÑOS", " ", 50, 50);

                if (Convert.ToDouble(peso) >= 0 )
                {
                    niños = niños + i;
                }

                i = i + 1;
            }
            porcentaje = niños  / 5;
            MessageBox.Show("El porcentaje de peso en los niños es de: " + porcentaje);

        }
    }
}
