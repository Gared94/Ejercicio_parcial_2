using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio75
    {
        public void ejercicio75()
        {
            double[,] M;
            double sumrow = 0;
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
            //Sumando valores por fila
            for (i = 0; i < a; i++)
            {
                for (j = 0; j < b; j++)
                {
                    sumrow = sumrow + M[i, j];
                }
                Console.WriteLine("La suma de la fila " + (i + 1) + " es " + sumrow);
                sumrow = 0;
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();

        }
    }
}
