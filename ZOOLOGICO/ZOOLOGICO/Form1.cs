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

namespace ZOOLOGICO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //DETERMINAR EL PORCENTAJE DE ANIMALES QUE HAY EN LAS SIGUIENTES 3 CATEGORIAS DE EDADES
            //DE 0 A 1 AÑO
            //DE MAS DE 1 AÑO Y MENOS DE 3
            //DE 3 O MAS AÑOS
            //EL ZOOLOGICO TODAVIA NO ESTA SEGURO DEL ANIMAL QUE VA A ESTUDIAR. SI SE DECIDE POR ELEFANTES SOLO TOMARA LA MUESTRA DE 20 DE ELLOS
            //SI SE DECIDE POR LAS JIRAFAS, TOMARA 15 MUESTRAS Y SI SON CHIMPANCES TOMARA 40
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            double edad,prom,n;
            int i;
            edad = 0;
            for (i = 1; i <= n; i++)
            {
                edad = double.Parse(Interaction.InputBox("Ingrese la edad", "EDAD", " ", 0, 0));
                prom  = prom + edad;
            }
            prom = edad / n;
            return prom;


        }
        }
    }
}
