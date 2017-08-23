﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APLICACION
{
    class Numeros
    {
        private int[] numeros;
        private String[] rutas;

        public Numeros()
        {
            numeros = new int[16];
            rutas = new string[8];
            for (int i = 0; i < 8; i++)
            {
                numeros[i] = i;
                numeros[i + 8] = i;
                rutas[i] = "/imagenes/" + i + ".jpg";
            }

        }
        public int obtenernumero()
        {
            Random aleatorio = new Random();
            int numeroAleatorio = aleatorio.Next(0, numeros.Length);
            int aux = numeros[numeroAleatorio];
            List<int> lista = numeros.OfType<int>().ToList<int>();
            
            lista.RemoveAt(numeroAleatorio);
            numeros = lista.ToArray();
            return aux;




        }

        public String conseguirimagenes(int aux)
        {
            for (int i = 0; i < 8; i++)
            {
                if (i == 8)
                {
                    return rutas[i];

                }

            }
            return "";
        }
    }
}

