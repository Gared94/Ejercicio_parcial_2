using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio53
    {

        public void ejercicio53()
        {
            int i, numero, resultado = 1;
            Console.WriteLine("Ingrese numero entero al que dese sacar el factorial");
            numero = int.Parse(Console.ReadLine());

            for (i = 1; i <= numero; i++)
            {
                resultado = resultado * i;
            }
            Console.WriteLine("El factorial de " + numero + " es: " + resultado);
            Console.ReadKey();
        }
    }
}
