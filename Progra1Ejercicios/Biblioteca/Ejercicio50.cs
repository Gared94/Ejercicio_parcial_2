using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio50
    {
        public void ejercicio50()
        {
            int valor, hasta, n = 1, o = 1;
            int[] a = new int[26];

            Console.WriteLine("calculador de potencias");
            Console.WriteLine("cuantos numeros ingresaras? ingrese valor");
            valor = int.Parse(Console.ReadLine());
            hasta = valor;
            while (n <= hasta)
            {
                Console.WriteLine("Ingrese valor " + n);
                a[n] = int.Parse(Console.ReadLine());
                n++;
            }

            Console.WriteLine("La respuestas son: ");
            while (o <= hasta)
            {
                Console.WriteLine("las potencias de: " + a[o] + " a la 3: " + (Math.Pow(a[o], 3)) + " a la 4: " + (Math.Pow(a[o], 4)) + " a la 5: " + (Math.Pow(a[o], 5)));
                o++;
            }
            Console.ReadKey();
        }
    }
}
