using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio18
    {
        //18.	Programa para determinar cuál es mayor entre 2 números cualquiera ingresados por el usuario
        public void numeroMayor() {
            double num1, num2;

            Console.WriteLine("Ingrese el valor 1");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor 2");
            num2 = double.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("El numero 1 (" + num1 + ") es mayor");
            }
            else if (num2 > num1) {
                Console.WriteLine("El numero 2 (" + num2 + ") es mayor");
            }
            else
            {
                Console.WriteLine("Ambos numeros son iguales");
            }
        }
    }
}
