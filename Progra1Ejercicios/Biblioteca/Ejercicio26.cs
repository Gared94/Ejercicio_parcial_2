using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio26
    {
        public void numeros()
        {
            Console.WriteLine("Ingrese un numero del 1 al 99 ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 < 10)
            {
                Console.WriteLine("El valor ingresado tiene 1 digito");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("El valor ingresado tiene 2 digitos");
                Console.ReadKey();
            }
        }
    }
}
