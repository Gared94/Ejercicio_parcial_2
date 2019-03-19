using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio49
    {
        public void ejercicio49()
        {
            int valor, hasta, n = 1, o = 1;
            int valormayor = 0, valormenor = 0, valoreva;
            int[] a = new int[26];

            Console.WriteLine("calculador de los numeros mayores");
            Console.WriteLine("cuantos numeros ingresaras? ingrese valor");
            valor = int.Parse(Console.ReadLine());
            hasta = valor;
            while (n <= hasta)
            {
                Console.WriteLine("Ingrese valor " + n);
                a[n] = int.Parse(Console.ReadLine());
                n++;
            }
            while (o <= hasta)
            {
                valoreva = a[o];
                if (valoreva > valormayor)
                {
                    valormayor = valoreva;
                }
                if (valoreva < valormayor)
                {
                    valormenor = valoreva;
                }
                o++;
            }
            Console.WriteLine("El valor mayor es: " + valormayor);
            Console.WriteLine("El valor menor es: " + valormenor);
            Console.ReadKey();
        }
    }
}
