using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio42
    {
        public void ejercicio42()
        {
            double promedio;
            double counter1 = 0;
            double[] a = new double[26];

            Console.WriteLine("Calcular la altura promedio de 18 estudiantes");
            Console.WriteLine("Ingrese 18 alturas de personas: ");
            for (int i = 1; i <= 18; i++)
            {
                Console.WriteLine("estudiante No. " + i + " de 18");
                a[i] = double.Parse(Console.ReadLine());
                counter1 = counter1 + a[i];
            }

            promedio = counter1 / 18;

            if (promedio < 1.40)
            {
                Console.WriteLine("Estudiantes muy bajos, prom: " + promedio);
            }
            if ((promedio >= 1.40) && (promedio <= 1.70))
            {
                Console.WriteLine("Estudiantes de estatura normal, prom: " + promedio);
            }
            if (promedio > 1.70)
            {
                Console.WriteLine("Estudiantes muy altos, prom: " + promedio);
            }

            Console.ReadKey();
        }
    }
}
