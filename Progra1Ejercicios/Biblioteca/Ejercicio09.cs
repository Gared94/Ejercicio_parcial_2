using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio09
    {
        //9.	Programa que permita ingresar 5 números y calcular el promedio de estos

        public void promedio() {
            double num1, num2, num3, num4, num5, promedio;

            Console.WriteLine("Ingrese el valor primero numero");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor segundo numero");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor tercer numero");
            num3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor cuarto numero");
            num4 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor quinto numero");
            num5 = double.Parse(Console.ReadLine());

            promedio = (num1 + num2 + num3 + num4 + num5) / 5;

            Console.WriteLine("El promedio de los numeros ingresados es: " + promedio);
            Console.ReadKey();
        }
    }
}
