using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio55
    {
        public void ejercicio55()
        {
            double estatura = 0, mayor = 0;
            int i, cantidad = 0;

            Console.WriteLine("Cantidad de alumno a registrar");
            cantidad = int.Parse(Console.ReadLine());
            for (i = 1; i <= cantidad; i++)
            {
                Console.WriteLine("Ingrese la estatura del alumno " + i);
                estatura = double.Parse(Console.ReadLine());

                if (i == 1)
                {
                    mayor = estatura;
                }
                if (estatura > mayor)
                {
                    mayor = estatura;
                }
                estatura = 0;
            }
            Console.WriteLine("La mayor estatura ingresada es: " + mayor);
            Console.ReadKey();
        }
    }
}
