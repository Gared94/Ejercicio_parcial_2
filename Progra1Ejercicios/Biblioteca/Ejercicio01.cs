using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio01
    {
        int num1, num2, suma = 0;
        public void Sumar()
        {
            Console.WriteLine("Ingrese el primer numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            num2 = int.Parse(Console.ReadLine());

            suma = num1 + num2;
            Console.WriteLine("\nResultado de la suma: " + suma);
            Console.ReadKey();
        }
    }
}
