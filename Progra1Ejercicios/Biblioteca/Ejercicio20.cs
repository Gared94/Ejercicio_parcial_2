using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio20
    {
        public void mitad()
        {
            Console.WriteLine("Digite el numero que usted guste");
            int num1 = Convert.ToInt32(Console.ReadLine());

            int respuesta = num1 / 2;

            if (respuesta < 100)
            {
                Console.WriteLine("La mitad del numero ingresado es menor a 100 ");
                Console.WriteLine("La mitad del numero ingresado es : " + respuesta);
                Console.ReadKey();
            }
            else if (respuesta == 100)
            {
                Console.WriteLine("El numero ingresado es igual a 100 ");
                Console.WriteLine("La mitad del numero ingresado es : " + respuesta);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("La mitad del numero ingresado es mayor a 100 ");
                Console.WriteLine("La mitad del numero ingresado es : " + respuesta);
                Console.ReadKey();
            }

        }
    }
}
