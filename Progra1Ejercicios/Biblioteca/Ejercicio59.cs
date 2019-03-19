using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio59
    {
        public void edades() 
        {
            int[] edad = new int[10];

            for (int i = 0; i < 10; i++) {
                Console.WriteLine("Ingrese la edad " + (i+1));
                edad[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nEDADES INGRESADAS");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Edad" + (i+1) + "=" + edad[i]);
            }
        }
    }
}
