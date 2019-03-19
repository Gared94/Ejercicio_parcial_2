using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio30
    {
        public void superTienda()
        {
            Console.WriteLine("Ingrese el monto de la compra ");
            double monto = Double.Parse(Console.ReadLine());

            if (monto >= 10000 && monto <= 20000)
            {
                double total = (monto - (monto * 0.10));
                Console.WriteLine("Felicidades usted tiene un descuento del 10 % ");
                Console.WriteLine("El total a pagar es de : " + total);
                Console.ReadKey();
            }
            else if (monto >= 20001 && monto <= 50000)
            {
                double total = (monto - (monto * 0.30));
                Console.WriteLine("Felicidades usted tiene un descuento del 30 % ");
                Console.WriteLine("El total a pagar es de : " + total);
                Console.ReadKey();
            }
            else
            {
                double total = (monto - (monto * 0.50));
                Console.WriteLine("Felicidades usted tiene un descuento del 50 %");
                Console.WriteLine("El total a pagar es de : " + total);
                Console.ReadKey();
            }
        }
    }
}
