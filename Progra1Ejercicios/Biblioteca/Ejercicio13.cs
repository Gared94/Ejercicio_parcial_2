using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio13
    {
        //13.	Escribir un programa en el cual se ingresen cinco números, calcular e informar la suma de los dos primeros y el producto 
        //del tercero con el cuarto los resultados multiplicarlos y dividirlos por el quinto número.
        public void Operaciones() {
            double num1, num2, num3, num4, num5, suma, multi, division;

            Console.WriteLine("Ingrese el valor del primer numero");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del segundo numero");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del tercer numero");
            num3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del cuarto numero");
            num4 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del quinto numero");
            num5 = double.Parse(Console.ReadLine());

            suma = num1 + num2;
            multi = num3 * num4;
            division = (suma * multi) / num5;

            Console.WriteLine("Suma: " + suma);
            Console.WriteLine("Multiplicacion: " + multi);
            Console.WriteLine("Multipicacion de resultados y division por el quinto numero: " + division);
            
        }
    }
}
