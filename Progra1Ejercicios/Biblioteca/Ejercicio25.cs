using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio25
    {
        public void notas()
        {
            Console.WriteLine("Ingrese 3 notas del alumno ");
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());

            double promedio = (num1 + num2 + num3) / 3;

            if (promedio >= 7)
            {
                Console.WriteLine("Felicidades ¡¡PROMOCIONADO!!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No promocionado");
            }
        }
    }
}
