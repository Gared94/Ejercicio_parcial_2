using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio35
    {
        public void Menu()
        {
            Console.WriteLine("************************************");
            Console.WriteLine("Por favor selecciones una opcion");
            Console.WriteLine(" 1): Pasa o no la materia?");
            Console.WriteLine(" 2):Es mayor o menor de edad?");
            Console.WriteLine("************************************");

            int opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    Console.WriteLine("Ingrese 3 notas del alumno");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    double num3 = Convert.ToDouble(Console.ReadLine());
                    double promedio = (num1 + num2 + num3) / 3;

                    if (promedio > 3)
                    {
                        Console.WriteLine("Felicidades usted ha pasado la materia ");
                        Console.WriteLine("Su promedio es de : " + promedio);
                        Console.ReadKey();
                    }
                    else 
                    {
                        Console.WriteLine("Usted a reprobado");
                    }
                    break;
                case 2:
                    Console.WriteLine("Ingrese su año de nacimiento");
                    int naci = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el año actual ");
                    int year = Convert.ToInt32(Console.ReadLine());

                    int resultado = year - naci;
                    if (resultado < 18)
                    {
                        Console.WriteLine("Usted ya es mayor de edad, su edad actual es :" + resultado + "años");
                    }
                    else
                    {
                        Console.WriteLine("Usted es menor de edad, su edad es : " + resultado + "años");
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
