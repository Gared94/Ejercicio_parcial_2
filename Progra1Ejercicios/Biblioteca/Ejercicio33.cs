using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio33
    {
        public void rectilineo()
        {

            Console.WriteLine("\n Binevenido al menu\n  ");
            Console.WriteLine(" 1): calcular distancia  ");
            Console.WriteLine(" 2): calcular tiempo     ");
            Console.WriteLine(" 3): calcular velocidad  ");

            int opc = Convert.ToInt32(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    Console.WriteLine("Ingrese la velocidad");
                    double velocidad = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el tiempo");
                    double tiempo = Convert.ToDouble(Console.ReadLine());

                    double distan = velocidad * tiempo;

                    Console.WriteLine("La distancia recorrida es de : " + distan);
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("Ingrese la distancia");
                    double distancia = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese la velocidad");
                    double veloc = Convert.ToDouble(Console.ReadLine());

                    double tiem = distancia / veloc;

                    Console.WriteLine("El tiempo es :" + tiem);
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("ingrese la distancia ");
                    double dista = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el tiempo ");
                    double tiemp = Convert.ToDouble(Console.ReadLine());

                    double velocida = dista / tiemp;

                    Console.WriteLine("La velocidad es :" + velocida);
                    Console.ReadKey();

                    Console.ReadKey();
                    break;
                default:
                    break;

            }
        }
    }
}
