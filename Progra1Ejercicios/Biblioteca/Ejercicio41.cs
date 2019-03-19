using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio41
    {
        public void ejercicio41()
        {
            double promedio;
            int counter1 = 0;
            int[] a = new int[26];

            Console.WriteLine("Calcular edad promedio de 15 estudiantes");
            Console.WriteLine("Ingrese 15 edades");
            for (int i = 1; i <= 15; i++)
            {
                Console.WriteLine("edad " + i + " de 15");
                a[i] = int.Parse(Console.ReadLine());
                counter1 = counter1 + a[i];
            }

            promedio = counter1 / 15;

            Console.WriteLine("el promedio de edades son: " + promedio);
            Console.ReadKey();
        }
    }
}
