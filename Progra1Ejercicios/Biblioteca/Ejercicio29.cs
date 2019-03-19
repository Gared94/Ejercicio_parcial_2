using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio29
    {
        public void temperatura()
        {
            Console.WriteLine("Ingrese la temperatura de este dia (lunes) \n");
            double lunes = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la temperatura de este dia (Martes)\n");
            double martes = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la temperatura de este dia (Miercoles)\n");
            double miercoles = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la temperatura de este dia (Jueves)\n");
            double jueves = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la temperatura de este dia (Viernes)\n");
            double viernes = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la temperatura de este dia (sabado)\n");
            double sabado = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la temperatura de este dia (Domingo)\n");
            double domingo = Convert.ToDouble(Console.ReadLine());

            double temp = Convert.ToDouble((lunes + martes + miercoles + jueves + viernes + sabado + domingo) / 7);

            if (temp > 35)
            {
                Console.WriteLine("Que semana mas calurosa fue!!!" + temp + "°");
                Console.ReadKey();
            }
            else if (temp >= 15 && temp <= 35)
            {
                Console.WriteLine("Que clima mas delicioso !! :)" + temp + "°");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Que semana mas fria " + temp + "°");
                Console.ReadKey();
            }
        }
    }
}
