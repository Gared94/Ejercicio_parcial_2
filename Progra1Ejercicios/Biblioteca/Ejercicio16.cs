using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio16
    {
        //16.	Programa que determine si una persona es mayor de edad o no teniendo en cuenta el año actual y su año de nacimiento

        public void mayorEdad() {
            int anio, edad;

            Console.WriteLine("Ingrese su año de nacimiento");
            anio = int.Parse(Console.ReadLine());

            edad = DateTime.Today.Year - anio;

            if (edad >= 0 && edad < 18) {
                Console.WriteLine("Aun eres menor de edad");
            }
            else
            {
                Console.WriteLine("Eres mayor de edad");
            }
        }
    }
}
