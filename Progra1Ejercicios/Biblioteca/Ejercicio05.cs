using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio05
    {
        public void calcularEdad() { 
            int anio, edad = 0;
            Console.WriteLine("En que año naciste");
            anio = int.Parse(Console.ReadLine());
            
            //Obtenemos el año del sistema con la clase DateTime
            edad = DateTime.Today.Year - anio;

            Console.WriteLine("Tu edad es: " + edad + " años");
            Console.ReadKey();
        }
    }
}
