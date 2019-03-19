using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio22
    {
        public void estudiante()
        {
            Console.WriteLine("Ingrese el nombre del estudiante");
            string name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Ingese el codigo del estudiante ");
            string code = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Ingrese el nombre de la materia");
            string materia = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Ingrese las 3 notas del estudiante");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            double num3 = Convert.ToDouble(Console.ReadLine());

            double prom = (num1 + num2 + num3) / 3;

            if (prom <= 4.0)
            {
                Console.WriteLine(name + " su codigo es " + code + " en la materia " + materia + " has REPROBADO");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(name + " su codigo es " + code + " en la materia " + materia + " has APROBADO");
                Console.ReadLine();
            }

        }
    }
}
