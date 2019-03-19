using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio27
    {
        public void compras()
        {
            Console.WriteLine("Ingrese el valor de la compra");
            double comp = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de articulos ");
            int cant = int.Parse(Console.ReadLine());

            double total = comp * cant;


            if (total < 20000)
            {
                double desc = (total - (total * 0.15));
                Console.WriteLine("Felicidaedes uted tiene un descuento de 15% total a pagar: " + desc);
                Console.ReadKey();
            }
            else
            {
                double desc = (total - (total * 0.35));
                Console.WriteLine("Felicidades usted tiene un descuento de 35% total a pagar: " + desc);
                Console.ReadKey();
            }
        }
    }
}
