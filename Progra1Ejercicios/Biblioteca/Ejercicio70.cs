using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio70
    {
        public void ejercicio70()
        {
            double[,] M;
            int a, b, i, j;

            //Llenando la matriz NxN
            Console.Write("Ingrese cantidad de filas de la matriz: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Ingrese cantidad de columnas de la matriz: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            M = new double[a, b];
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
            Console.WriteLine();
            for (i = 0; i < a; i++)
            {
                for (j = 0; j < b; j++)
                {
                    Console.Write("M[" + (i + 1) + "," + (j + 1) + "]= " + M[i, j] + "   ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();

        }
    }
}
