using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio04
    {
        public void MRU() {
            double velocidad, tiempo, distancia = 0;
            Console.WriteLine("Ingrese la velocidad en Km/h");
            velocidad = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tiempo en horas");
            tiempo = double.Parse(Console.ReadLine());

            distancia = velocidad * tiempo;

            Console.WriteLine("Distancia recorrida es: " + distancia + "Km");
            Console.ReadKey();
        }
    }
}
