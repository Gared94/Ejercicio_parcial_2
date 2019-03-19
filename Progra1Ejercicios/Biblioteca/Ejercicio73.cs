using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio73
    {
        public void ejercicio73()
        {
            double[,] M;
            int a, b, i, j, sumpos = 0, sumneg = 0, zeros = 0;

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

            //Contabilizando números positivos, negativos y ceros
            for (i = 0; i < a; i++)
            {
                for (j = 0; j < b; j++)
                {
                    if (M[i, j] < 0)
                    {
                        sumneg = sumneg + 1;
                    }
                    else if (M[i, j] > 0)
                    {
                        sumpos = sumpos + 1;
                    }
                    else
                    {
                        zeros = zeros + 1;
                    }
                }
                Console.WriteLine();
            }
            //Entrega resultados
            Console.WriteLine("Cantidad Total de Numeros Negativos en Matriz: " + sumneg);
            Console.WriteLine("Cantidad Total de Numeros Positivos en Matriz: " + sumpos);
            Console.WriteLine("Cantidad Total de Numeros Ceros en Matriz: " + zeros);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();

        }
    }
}
