using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio48
    {
        public void ejercicio48()
        {
            int valor, hasta, n = 1;
            Console.WriteLine("Suma de numeros naturales");
            Console.WriteLine("ingrese el limite de las sumas");
            valor = int.Parse(Console.ReadLine());
            hasta = valor;
            while (n < hasta)
            {
                valor = valor + n;
                n++;
            }
            Console.WriteLine("La respuesta es: " + valor);
            Console.ReadKey();
        }
    }
}
