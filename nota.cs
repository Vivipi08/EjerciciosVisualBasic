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
            double nota1, nota2,nota3;

            nota3 = double.Parse(textBox3.Text);

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
                                    evaluacion.Visible = true;

                                    textBox1.ReadOnly = true;
                                    textBox2.ReadOnly = true;
                                    button1.Enabled = false;
                                }
                            }
                            



                        

        }
            }
    }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            double nota1, nota2, nota3, promedio;

            nota1 = double.Parse(textBox1.Text);
            nota2 = double.Parse(textBox2.Text);

            if (textBox1.Text == "")
            {
                MessageBox.Show("Error, Debe ingresar un dato");


            }


            else
            {

                nota3 = double.Parse(textBox3.Text);

                if (nota3 > 10.0)
                {

                    MessageBox.Show("Error, las notas que ingreso deben estar entre 0 y 10", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                else
                {


                    promedio = (nota1 + nota2 + nota3) / 3;

                    if (promedio >= 7.0)
                    {

                        MessageBox.Show("felcitaciones usted ha aprobado la materia con um `promedio de:   " + promedio, "felicitaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }

                    else

                    {

                        if (promedio < 3.0)
                        {

                            MessageBox.Show("usted es un vago y no aprobo laa materia con un promedio de:      " + promedio, "lo sieno", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        }

                        else
                        {

                            MessageBox.Show("usted tiene la posibilidad de aprobar la materia presentando una evalucion , tiene promedio de:   " + promedio, "pero no es suficiente para aprobar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            MessageBox.Show("ingrese la nota de la evaluacion parta saber si definitaivamente aprobo o reprobo la materia  ");

                            textBox4.Visible = true;
                            notafinal.Visible = true;
                            textBox3.ReadOnly = true;
                            evaluacion.Enabled = false;
                        
                        }
                    
                    
                    }


                
                }
            
            }
        }

        private void notafinal_Click(object sender, EventArgs e)
        {
            double evaluacion;

            if (textBox4.Text == "")
            {

                MessageBox.Show("error debe ingresar un dato");




            }
            else
            {


                evaluacion = double.Parse(textBox4.Text);

                if (evaluacion > 10.0)
                {

                    MessageBox.Show("errar las notas deben estar entre 0 y 10", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if (evaluacion <= 5)
                    {
                        MessageBox.Show("la evaluacion final no tuvo una nota lo suficientemente alta para aprobar la materia, desaafortunadamente perdio ");


                    }
                    else
                    {


                        MessageBox.Show("aprobo la materia", "informacion", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    
                    
                    }
                
                
                
                
                }


            
            
            }
        }
        }
    }

