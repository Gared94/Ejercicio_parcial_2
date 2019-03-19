using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio61
    {
        public void sumaVector() 
        {
            int[] num = new int[12];
            int suma = 0;

            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("Digite el valor " + (i+1));
                num[i] = int.Parse(Console.ReadLine());
                suma += num[i];
            }

            Console.WriteLine("\nSUMA: " + suma);
            Console.ReadKey();
        }
    }
}
