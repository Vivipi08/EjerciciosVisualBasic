using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nombres
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[,] nombre = { { "A", "B" }, { "C", "D" }, { "E", "F" }, { "G", "H" }, { "I", "J" }, { "K", "L" }, { "M", "N" }, { "O", "P" }, { "Q", "R" }, { "S", "T" }, { "U", "V" }, { "W", "X" }, { "Y", "Z" } };

            MessageBox.Show("NOMBRE:   " + nombre[0, 0] + nombre[6, 1] + nombre[1, 1] + nombre[2, 0] + nombre[8, 1] + nombre[9, 0] + nombre[7, 0] + nombre[6, 1]);



        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] NUMERO = new int[10];



            NUMERO[0] = 1;
            NUMERO[1] = 2;
            NUMERO[2] = 3;
            NUMERO[3] = 4;
            NUMERO[4] = 5;
            NUMERO[5] = 6;
            NUMERO[6] = 7;
            NUMERO[7] = 8;
            NUMERO[8] = 9;
            NUMERO[9] = 0;
            MessageBox.Show("TARJETA IDENTIDAD:    " + NUMERO[0] + NUMERO[9] + NUMERO[0] + NUMERO[1] + NUMERO[3] + NUMERO[0] + NUMERO[3] + NUMERO[4] + NUMERO[4] + NUMERO[4]);
        }
    }
}
