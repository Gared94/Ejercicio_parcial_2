using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio68
    {
        public void vectorEstudiantes() 
        {
            //Control Cantidad de Alumnos en aulas

            int[] C = new int[5];
            int i = 0, low = 0, high = 0, min = 0, may = 0, sum = 0;

            //Ingresando cantidad de alumnos por aula
            do
            {
                Console.Write("Ingrese cantidad de alumnos en el aula " + (i + 1) + ": ");
                C[i] = int.Parse(Console.ReadLine());
                i = i + 1;
                Console.WriteLine();
            } while (i < 5);

            //Cantidad mayor, menor y total de alumnos
            i = 0;
            do
            {
                if (C[i] > high)
                {
                    high = C[i];
                    //may = i+1;
                }
                else if (C[i] < low)
                {
                    low = C[i];
                    //min = i+1;
                }
                sum = sum + C[i];
            } while (i < 5);

            //Imprimiendo los resultados
            Console.WriteLine("El aula con menos estudiantes es la número " + min);
            Console.WriteLine("Y tiene " + low + " estudiantes");
            Console.WriteLine();
            Console.WriteLine("El aula con mas estudiantes es la número " + may);
            Console.WriteLine("Y tiene " + high + " estudiantes");
            Console.WriteLine();
            Console.WriteLine("La cantidad total de alumnos es de " + sum);

            Console.WriteLine();
            Console.WriteLine("Digite cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
