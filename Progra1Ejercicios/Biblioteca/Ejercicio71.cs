using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio71
    {
        public void ejercicio71()
        {
            double[,] M;
            int a = 3, b = 4, i, j;
            double sum = 0;
            M = new double[a, b];

            //Llenando la matriz NxN
            for (i = 0; i < a; i++)
            {
                for (j = 0; j < b; j++)
                {
                    Console.Write("Ingrese el número M[" + (i + 1) + "," + (j + 1) + "]= ");
                    M[i, j] = double.Parse(Console.ReadLine());
                    sum = sum + M[i, j];
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("La suma total de los valores de la matriz es: " + sum);
            Console.WriteLine("El promedio de los valores de la matriz es: " + (sum / (a * b)));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();

        }
    }
}
