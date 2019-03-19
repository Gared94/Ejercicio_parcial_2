using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio78
    {
        public void ejercicio78()
        {
            double[,] M;
            double sdi = 0, sds = 0;
            int a = 5, b = 5, i, j, m = 1, n = 4;

            //Llenando la matriz NxN
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

            //Suma de elementos diagonal superior matriz NxN
            for (i = 0; i < 4; i++)
            {
                for (j = m; j < 5; j++)
                {
                    sds = sds + M[i, j];
                }
                m = m + 1;
            }

            //Suma de elementos diagonal inferior matriz NxN
            for (i = 4; i > 0; i--)
            {
                for (j = 0; j < n; j++)
                {
                    sdi = sdi + M[i, j];
                }
                n = n - 1;
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("La suma de Diagonal Superior es: " + sds);
            Console.WriteLine("La suma de Diagonal Inferior es: " + sdi);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();

        }
    }
}
