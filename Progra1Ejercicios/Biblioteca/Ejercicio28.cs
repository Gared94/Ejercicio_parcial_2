using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio28
    {
        public void numero()
        {
            Console.WriteLine("Ingrese un numero");
            int num1 = int.Parse(Console.ReadLine());

            if ((num1 % 2) == 0)
            {
                Console.WriteLine("El numero ingresado es par");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("El numero ingresado es impar");
                Console.ReadKey();
            }
        }
    }
}
