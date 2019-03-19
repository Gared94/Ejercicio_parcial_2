using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio74
    {
        public void ejercicio74()
        {
            double[,] M;
            double x;
            int a, b, i, j, c = 0;

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

            //Comparando valores dado por usuario y matriz
            Console.Write("Digite valor buscado: ");
            x = double.Parse(Console.ReadLine());
            for (i = 0; i < a; i++)
            {
                for (j = 0; j < b; j++)
                {
                    if (M[i, j] == x)
                    {
                        Console.WriteLine("El número " + x + " se encuentra en la posición: M[" + (i + 1) + "," + (j + 1) + "]");
                        i = a; j = b; c = 1;
                    }
                }
                Console.WriteLine();
            }
            if (c != 1)
            {
                Console.WriteLine("El número " + x + " no se encuentra en la matriz.");
            }
            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();

        }
    }
}
