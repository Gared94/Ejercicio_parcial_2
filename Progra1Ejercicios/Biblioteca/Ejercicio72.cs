using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio72
    {
        public void ejercicio72()
        {
            double[,] M;
            int a, b, i, j, m, n, z;

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

            //Ubicando los valores deseados por usuario
            do
            {
                Console.Write("Ingrese la fila de interés: ");
                m = int.Parse(Console.ReadLine());
                Console.Write("Ingrese la columna de interés: ");
                n = int.Parse(Console.ReadLine());
                if ((m <= a) && (n <= b))
                {
                    Console.WriteLine("El valor en la posición M[" + m + "," + n + "] es " + M[(m - 1), (n - 1)]);
                    z = 1;
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("El valor de fila o columna ingresado es mayor a la dimensión de la matriz dada.");
                    z = 0;
                    Console.WriteLine();
                }
            } while (z != 0);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();

        }

    }
}
