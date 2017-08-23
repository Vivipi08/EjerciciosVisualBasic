using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUMA_DE_HETEROGENEOS_CON_SWITCHS
{
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
            double a,b,c,d,resultado,multiplicacion;
            int op;
            if (textBox5.Text == "")
            {
            
            MessageBox.Show("debe elegir una opcion a realizar");
            
            }
            else
            {
            
            a = double.Parse(txta.Text);
                 b = double.Parse(txtb.Text);
                 c = double.Parse(txtc.Text);
                 d = double.Parse(txtd.Text);
                 op = int.Parse(textBox5.Text);

                 switch (op)
                 {
                     case 1:
                         {
                             if (c == d)
                             {
                                 multiplicacion = a + b;
                                 resultado = d = c;
                                 cajaresultado.Text = multiplicacion.ToString();
                                 textBox2.Text = resultado.ToString();

                             }
                             else
                             {
                                 MessageBox.Show("DEBE INGRESARLOS DENOMINADORES IGUALES, YA QUE ES UNA FRACCION HOMOGENEA");
                             }
                             break;

                         }
                     case 2:
                         {
                             if (c == d)
                             {
                                 multiplicacion = (a - b);
                                 resultado = (c = d);
                                 cajaresultado.Text = multiplicacion.ToString();
                                 textBox2.Text = resultado.ToString();
                             }
                             else
                             {
                                 MessageBox.Show("DEBE INGRESAR LOS DENOMINADORES IGUALES YA QUE ES UNA FRACCION HOMOGENEA");
                             }
                             break;
                         }
                     case 3:
                         {
                             if (c == d)
                             {
                                 multiplicacion = (a * b);
                                 resultado = (c * d);
                                 cajaresultado.Text = multiplicacion.ToString();
                                 textBox2.Text = resultado.ToString();

                             }
                             else
                             {
                                 MessageBox.Show("DEBE INGRESAR LOS DENOMINADORES IGUALES YA QUE ES UNA FRACCION HOMOGENEA");
                             }
                             break;
                         }
                        case 4:
                         {
                            
                             {
                                 multiplicacion = (a * d);
                                 resultado = (b * c);
                                 cajaresultado.Text = multiplicacion.ToString();
                                 textBox2.Text = resultado.ToString();

                             }
                             
                             break;
                         }




                 }
            
            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            txta.Clear();
            txtb.Clear();
            txtc.Clear();
            txtd.Clear();
            cajaresultado.Clear();
            textBox2.Clear();

        }
    }
}
