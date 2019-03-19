using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio10
    {
        public void tienda() {
            double precio, totalPagar;
            int cantidad;

            Console.WriteLine("Ingrese el precio del producto");
            precio = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad");
            cantidad = int.Parse(Console.ReadLine());

            totalPagar = (cantidad * precio) * 1.13;

            Console.WriteLine("Total a pagar: $" + totalPagar);
            Console.ReadKey();
        }
    }
}
