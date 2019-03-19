using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio51
    {
        public void ejercicio51()
        {
            int valor, valor_evaluar, hasta, n = 1, o = 1, contador = 0;
            int[] a = new int[26];

            Console.WriteLine("Contador de numeros");
            Console.WriteLine("cuantos numeros ingresaras? ingrese valor");
            valor = int.Parse(Console.ReadLine());
            Console.WriteLine("Que valor hay que buscar");
            valor_evaluar = int.Parse(Console.ReadLine());
            hasta = valor;
            while (n <= hasta)
            {
                Console.WriteLine("Ingrese valor " + n);
                a[n] = int.Parse(Console.ReadLine());
                n++;
            }

            Console.WriteLine("el numero que deseas saber cuanto se repite es: " + valor_evaluar);
            while (o <= hasta)
            {
                if (a[o] == valor_evaluar)
                {
                    contador = contador + 1;
                }
                o++;
            }
            Console.WriteLine("el numero: " + valor_evaluar + " se repite " + contador + " veces");
            Console.ReadKey();
        }
    }
}
