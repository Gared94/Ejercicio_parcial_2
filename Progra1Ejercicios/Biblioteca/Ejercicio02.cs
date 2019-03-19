using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio02
    {
        public void Multiplicar() {
            int num1, num2, num3, multiplicar = 0;
            Console.WriteLine("Ingrese el primer numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero");
            num3 = int.Parse(Console.ReadLine());

            multiplicar = num1 * num2 * num3;

            Console.WriteLine("Resultado: " + multiplicar);
            Console.ReadKey();
        }
    }
}
