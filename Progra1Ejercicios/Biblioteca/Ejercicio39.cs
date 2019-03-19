using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio39
    {
        public void Estudiantes()
        {
            int mayores = 0;
            int menores = 0;

            /*Console.WriteLine("ingrese su edad ");
            int fecha = Convert.ToInt32(Console.ReadLine());*/

            for (int i = 0; i < 21; i++)
            {
                Console.WriteLine("ingrese su edad ");
                int edad = Convert.ToInt32(Console.ReadLine());
                if (edad >= 18)
                {
                    mayores = mayores + 1;
                }
                else
                {
                    menores = menores + 1;
                }

                // Console.WriteLine("{0}", i); <--- con esto sale el secuencial

            }
            Console.WriteLine("El numero de estudiantes mayores de edad son : " + mayores);
            // Console.WriteLine(mayores);<---- lo dejo opcional nada mas
            Console.WriteLine("El numero de estudiantes menores de edad son : " + menores);
            // Console.WriteLine(menores);<-- opcional
            Console.ReadKey();
            Console.WriteLine("\n");
        }
    }
}
