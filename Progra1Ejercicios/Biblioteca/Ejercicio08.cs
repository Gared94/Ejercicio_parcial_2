using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio08
    {

        public void areaCuadrado(){
            double lado, area;

            Console.WriteLine("Ingrese el valor de un lado del cuadrado");
            lado = double.Parse(Console.ReadLine());

            area = Math.Pow(lado, 2);

            Console.WriteLine("El area del cuadrado es: " + area);
            Console.ReadKey();
        }
    }
}
