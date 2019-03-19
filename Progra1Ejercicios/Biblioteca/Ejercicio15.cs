using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio15
    {
        //15.	Se debe desarrollar un programa que pida el ingreso del precio de un artículo y la cantidad que lleva el cliente. Mostrar lo que debe abonar el comprador.

        public void abonoComprador() {
            double precio, total;
            int cantidad;

            Console.WriteLine("Ingrese el precio del articulo");
            precio = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de articulos");
            cantidad = int.Parse(Console.ReadLine());

            total = precio * cantidad;

            Console.WriteLine("Total a pagar por el comprador es " + total);
            Console.ReadKey();

        }
    }
}
