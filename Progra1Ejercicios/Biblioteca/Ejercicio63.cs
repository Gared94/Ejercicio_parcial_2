using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio63
    {
        public void ejercicio63()
        {
            double[] progra = new Double[3]; //vector inicializado
            double num = 0;
            int posicion = 0;


            Console.WriteLine("ingrese 20 digitos");

            for (int i = 0; i < 3; i++)
            {
                progra[i] = double.Parse(Console.ReadLine());
            }

            do
            {
                Console.WriteLine("ingrese posición que desea ver");
                posicion = int.Parse(Console.ReadLine());
                if (posicion > 19)
                {
                    Console.WriteLine("La posición solicitada no existe");
                }
                else
                {
                    num = progra[posicion];
                    Console.WriteLine("posicion numero: " + posicion + "es: " + num.ToString());
                }
            }

            while (posicion < 20);


            Console.ReadKey();
        }
    }
}
