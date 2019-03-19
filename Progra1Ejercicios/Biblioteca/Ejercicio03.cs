using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio03
    {
        public void division() {
            double num1, num2, division=0;
            Console.WriteLine("Ingrese el primer numero");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el primer numero");
            num2 = double.Parse(Console.ReadLine());
            if (num2 != 0)
            {

                division = num1 / num2;
                Console.WriteLine("Resultado: " + division);
                Console.ReadKey();
            }
            else 
            {
                Console.WriteLine("No puede dividirse por cero");
                Console.ReadKey();
            }
        }
    }
}
