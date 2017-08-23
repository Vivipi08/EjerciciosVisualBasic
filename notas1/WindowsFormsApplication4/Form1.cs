using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nota1, nota2;

            if (textBox1.Text == " " || textBox2.Text == "")
            {
                MessageBox.Show("Error, debe ingresar datos");
            }
            else
            {
                nota1 =double .Parse (textBox1 .Text );
                nota2 =double .Parse (textBox2 .Text );

                if (nota1 >10.0 || nota2 >10.00)
                {
                    MessageBox .Show ("Error las notas que ingrese deben estar entre 0 y 10" , "Error", MessageBoxButtons .OK ,MessageBoxIcon.Error );
                }
                        else
                        {
                            if (nota1 <= 2.0 && nota2 <= 2.0)
                            {
                                MessageBox.Show("Reprobo la asignatura porque sus calificaciones fueron muy bajas, no puede recuperar", "REPROBO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


                            }
                            else
                            {
                                if (nota1 >= 9.0 && nota2 >= 9.0)
                                {
                                    MessageBox.Show("Aprobo la materia, No tiene que presentar evaluacion final", "APROBO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {

                                    MessageBox.Show("Usted tiene posibilidad de aprobar la materia, ingrese la tercera nota y pulse el boton VERIFICAR", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                                    textBox3.Visible = true;
                                    button2.Visible = true;

                                    textBox1.ReadOnly = true;
                                    textBox2.ReadOnly = true;
                                    button1.Enabled = false;
                                }
                            }
                            



                        

        }
            }
    }
        }
    }

