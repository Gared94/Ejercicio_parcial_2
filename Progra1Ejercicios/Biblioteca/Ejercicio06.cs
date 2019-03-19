using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio06
    {
        public void Porcentaje() {
            double num, resultado = 0;
            Console.WriteLine("Ingrese un numero");
            num = double.Parse(Console.ReadLine());

            resultado = num * 0.20;

            Console.WriteLine("El 20% de " + num + " es: " + resultado);
            Console.ReadKey();
        }
    }
}
