using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio14
    {
        //14.	Realizar un programa que lea cuatro valores numéricos e informar su suma y promedio.
        public void sumaPromedio() {
            double num1, num2, num3, num4, suma, promedio;

            Console.WriteLine("Ingrese el valor del primer numero");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del segundo numero");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del tercer numero");
            num3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del cuarto numero");
            num4 = double.Parse(Console.ReadLine());

            suma = num1 + num2 + num3 + num4;
            promedio = suma / 4;

            Console.WriteLine("Suma: " + suma);
            Console.WriteLine("Promedio: " + promedio);
            Console.ReadKey();
        }
    }
}
