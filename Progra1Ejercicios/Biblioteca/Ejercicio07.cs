using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio07
    {
        public void Porcentajes() {
            double num, calculo1 = 0, calculo2 = 0, calculo3 = 0;

            Console.WriteLine("Ingrese un numero");
            num = double.Parse(Console.ReadLine());

            calculo1 = num * 0.30;
            calculo2 = num * 0.60;
            calculo3 = num * 0.90;
            Console.WriteLine("El 30% de " + num + " es: " + calculo1);
            Console.WriteLine("El 60% de " + num + " es: " + calculo2);
            Console.WriteLine("El 90% de " + num + " es: " + calculo3);
        }
    }
}
