using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio31
    {
        //31.	Programa para determinar si un deportista es aceptado en el quipo de baloncesto de  Bogotá.  Las condiciones para ser aceptado son:
        //a)	La edad debe ser menor o igual a 18 años
        //b)	La estatura debe ser mayor a 180 cm
        //c)	El peso debe ser menor o igual a 80 kg
        //Si el aspirante cumple las 3 condiciones aceptarlo si no rechazarlo.
        public void deportista(){
            int edad;
            double estatura, peso;

            Console.WriteLine("Ingrese la edad");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la estatura en centimetros");
            estatura = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el peso en kilogramos");
            peso = double.Parse(Console.ReadLine());

            if (edad <= 18)
            {
                if (estatura > 180)
                {
                    if (peso <= 80)
                    {
                        Console.WriteLine("Felicidades!! Usted cumple las condiciones y a sido ACEPTADO");
                    }
                    else 
                    {
                        Console.WriteLine("Lo sentimos, usted no cumple las condiciones debido a su peso");
                    }
                }
                else 
                {
                    Console.WriteLine("Lo sentimos, usted no cumple las condiciones debido a su estatura");
                }
            }
            else 
            {
                Console.WriteLine("Lo sentimos, usted no cumple las condiciones debido a su edad");
            }
        }
    }
}
