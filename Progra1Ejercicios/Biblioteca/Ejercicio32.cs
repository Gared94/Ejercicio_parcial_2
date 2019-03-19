using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio32
    {
        public void vocal()
        {
            string letra;

            Console.WriteLine("Ingrese una letra ");
            letra = Console.ReadLine();

            switch (letra)
            {
                case "a":
                    Console.WriteLine("La letra ingresada es una vocal");
                    Console.ReadKey();
                    break;
                case "A":
                    Console.WriteLine("La letra ingresada es una vocal");
                    Console.ReadKey();
                    break;
                case "e":
                    Console.WriteLine("La letra ingresada es una vocal");
                    Console.ReadKey();
                    break;
                case "E":
                    Console.WriteLine("La letra ingresada es una vocal");
                    Console.ReadKey();
                    break;
                case "i":
                    Console.WriteLine("La letra ingresada es una vocal");
                    Console.ReadKey();
                    break;
                case "I":
                    Console.WriteLine("La letra ingresada es una vocal");
                    Console.ReadKey();
                    break;
                case "o":
                    Console.WriteLine("La letra ingresada es una vocal");
                    Console.ReadKey();
                    break;
                case "O":
                    Console.WriteLine("La letra ingresada es una vocal");
                    Console.ReadKey();
                    break;
                case "u":
                    Console.WriteLine("La letra ingresada es una vocal");
                    Console.ReadKey();
                    break;
                case "U":
                    Console.WriteLine("La letra ingresada es una vocal");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("La letra ingresada es una consonante");
                    Console.ReadKey();
                    break;

            }
        }
    }
}
