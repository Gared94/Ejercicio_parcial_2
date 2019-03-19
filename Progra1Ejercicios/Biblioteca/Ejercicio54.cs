using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio54
    {
        public void ejercicio54()
        {
            int cantidad, i;
            double precio, suma = 0;

            Console.WriteLine("Ingrese la cantidad de producto comprado");
            cantidad = int.Parse(Console.ReadLine());

            for (i = 1; i <= cantidad; i++)
            {
                Console.WriteLine("Ingrese el precio del producto " + i);
                precio = double.Parse(Console.ReadLine());
                suma = precio + suma;
            }
            Console.WriteLine("La suma total a pagar es: " + suma);
            Console.ReadKey();
        }
    }
}
