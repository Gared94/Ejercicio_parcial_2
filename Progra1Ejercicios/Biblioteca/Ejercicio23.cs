using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio23
    {
        public void almacen()
        {
            Console.WriteLine("Ingrese el precio del articulo :");
            double arti = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de articulos que llevara :");
            double cant = Convert.ToDouble(Console.ReadLine());

            double resultado = cant * arti;

            if (resultado <= 100000)
            {
                Console.WriteLine("el precio a pagar es de : " + resultado);
            }
            else if (resultado > 100000)
            {
                double total = (resultado - (resultado * 0.20));
                Console.WriteLine("Felicidades usted tiene un descuento de 20 % y pagara: " + total);
            }
        }
    }
}
