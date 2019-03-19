using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio76
    {
        public void ejercicio76()
        {
            double[,] M;
            double sumcol = 0;
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
            //Sumando valores por columna
            for (j = 0; j < b; j++)
            {
                for (i = 0; i < a; i++)
                {
                    sumcol = sumcol + M[i, j];
                }
                Console.WriteLine("La suma de la columna " + (j + 1) + " es " + sumcol);
                sumcol = 0;
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();

        }
    }
}
