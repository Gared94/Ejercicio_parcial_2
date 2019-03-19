using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio69
    {
        public void vectorUnido() 
        {
            int i = 0, j = 1;
            string[] name = new string[25];
            string[] surname = new string[25];

            //Registrando nombres y apellidos
            do
            {
                Console.Write("Digite nombre de la persona " + j + ": ");
                name[i] = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Digite apellido de la persona " + j + ": ");
                surname[i] = Console.ReadLine();
                Console.WriteLine();

                i = i + 1;
                j = j + 1;
            } while (i < 25);

            Console.WriteLine();
            i = 0; j = 1;

            //Imprimiendo Listado
            Console.WriteLine("Listado de Personas");
            do
            {
                Console.WriteLine(j + ".- " + name[i] + " " + surname[i]);
                i = i + 1;
                j = j + 1;
            } while (i < 25);

            Console.WriteLine();
            Console.WriteLine("Digite cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
