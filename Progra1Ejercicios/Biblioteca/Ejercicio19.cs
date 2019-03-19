using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio19
    {
        public void refrigerio()
        {


            Console.WriteLine("Desea refrigerio  si(1) /no(2) ? ");
            int respuesta = int.Parse(Console.ReadLine());

            if (respuesta == 1)
            {
                Console.WriteLine("Ingrese el numero de grado cursa");
                int resp = int.Parse(Console.ReadLine());

                if (resp > 0 && resp <= 6)
                {
                    Console.WriteLine("Su refrigerio va en camino!!!");
                    Console.ReadKey();
                }
                else 
                {
                    Console.WriteLine("Usted no aplica a refrigerio");
                    Console.ReadKey();
                }
            }
            else 
            {
                Console.WriteLine("Vuelva cuando desee");
                Console.ReadKey();
            }
        }
    }
}
