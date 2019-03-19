using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio77
    {
        public void ejercicio77()
        {
            double[,] M;
            double sdp = 0;
            int a = 5, b = 5, i, j;
            M = new double[a, b];
            Console.WriteLine();

            //Llenando la matriz NxN
            for (i = 0; i < a; i++)
            {
                for (j = 0; j < b; j++)
                {
                    Console.Write("Ingrese el número M[" + (i + 1) + "," + (j + 1) + "]= ");
                    M[i, j] = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
            }
            Console.WriteLine();

            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    if (i == j)
                    {
                        sdp = sdp + M[i, j];
                    }
                }
            }
            Console.WriteLine("La suma de Diagonal Principal es: " + sdp);
            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();

        }
    }
}
