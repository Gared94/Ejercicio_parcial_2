using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio64
    {
        public void vector() {
            int i, j;
            double[] n;
            n = new double[18];
            Console.WriteLine("Imprime un vector de 18 posiciones al derecho y al revés");
            Console.WriteLine();
            //Ingreso de datos al vector
            i = 0;
            do
            {
                j = i + 1;
                Console.Write("Digite el elemento " + j + ": ");
                n[i] = double.Parse(Console.ReadLine());
                Console.WriteLine();
                i = i + 1;
            } while (i < 18);
            Console.WriteLine();
            Console.WriteLine("Vector al derecho");
            i = 0;
            do
            {
                Console.Write(n[i] + "   ");
                i = i + 1;
            } while (i < 18);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Vector al revés");
            i = 17;
            do
            {
                Console.Write(n[i] + "   ");
                i = i - 1;
            } while (i >= 0);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
