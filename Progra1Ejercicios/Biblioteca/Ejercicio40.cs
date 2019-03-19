using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio40
    {
        public void ejercicio40()
        {
            int counter1 = 0, counter2 = 0;
            int[] a = new int[26];

            Console.WriteLine("Se contaran cuantos hombres y mujeres se encuentran en su seccion");
            Console.WriteLine("digite 1 si es hombre");
            Console.WriteLine("digite 2 si es mujer");
            for (int i = 1; i <= 25; i++)
            {
                Console.WriteLine("Contador " + i + " de 25");
                a[i] = int.Parse(Console.ReadLine());

                if (a[i] == 1)
                {
                    counter1 = counter1 + 1;
                }
                else
                {
                    counter2 = counter2 + 1;
                }
            }
            Console.WriteLine("El total de hombres son:" + counter1);
            Console.WriteLine("El total de mujeres son:" + counter2);
            Console.ReadKey();
        }
    }
}
