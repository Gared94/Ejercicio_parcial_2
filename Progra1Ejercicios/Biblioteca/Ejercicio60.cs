using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio60
    {
        public void nombres()
        {
            string[] nombres = new string[15];

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Ingrese el nombre " + (i + 1));
                nombres[i] = Console.ReadLine();
            }

            Console.WriteLine("\nNOMBRES INGRESADOS");
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Nombre " + (i + 1) + "=" + nombres[i]);
            }
        }
    }
}
