using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio24
    {
        public void numeros()
        {
            Console.WriteLine("Ingrese 2 numeros");
            double num1 = Convert.ToInt32(Console.ReadLine());
            double num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                int resul = Convert.ToInt32(num1 + num2);
                int resultado = Convert.ToInt32(num1 - num2);

                Console.WriteLine("El resultado de la suma es : " + resul);
                Console.WriteLine("El resultado de la resta es : " + resultado);
                Console.ReadKey();
            }
            else
            {
                int resul = Convert.ToInt32(num1 * num2);
                double resultado = num1 / num2;

                Console.WriteLine("El resultado de la multiplicacion es : " + resul);
                Console.WriteLine("El resultado de la division es : " + resultado);
                Console.ReadKey();
            }
        }
    }
}
