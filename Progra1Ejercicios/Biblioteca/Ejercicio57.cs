using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio57
    {
        public void factorialPotencia() {
            int i, factorial = 0, resulfactorial = 1, potencia = 1, num, resultado, opcion, var;
            double resultado1 = 1;
            do
            {
                Console.WriteLine("\nMENU");
                Console.WriteLine("1. Factorial de un numero");
                Console.WriteLine("2. Potencia de un numero");
                Console.WriteLine("3. Salir");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese un numero");
                        factorial = int.Parse(Console.ReadLine());
                        for (i = 1; i <= factorial; i++)
                        {
                            resulfactorial = resulfactorial * i;
                        }
                        Console.WriteLine("El factorial de " + factorial + " es: " + resulfactorial);
                        break;

                    case 2:
                        resultado1 = 1;
                        var = 1;
                        Console.WriteLine("Ingrese un numero entero");
                        num = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese potencia a calcular");
                        potencia = int.Parse(Console.ReadLine());
                        while (var <= potencia) 
                        {
                            resultado1 *= num;
                            var++;
                        }
                        Console.WriteLine("Potencia: " + resultado1);
                        break;
                }
            }
            while (opcion != 3);
        }
    }
}
