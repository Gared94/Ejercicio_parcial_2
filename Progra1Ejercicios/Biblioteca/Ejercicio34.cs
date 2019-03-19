using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio34
    {
        public void numcual()
        {
            Console.WriteLine("Ingrese un numero");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("seleccione una opcion");
            Console.WriteLine("1): Determinar si es positivo o negativo ");
            Console.WriteLine("2): Determinar si es par o impar ");

            int opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    if (num < 0)
                    {
                        Console.WriteLine("El numero ingresado es negativo " + num);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("El numero ingresado es positivo : " + num);
                        Console.ReadKey();
                    }
                    break;
                case 2:
                    if ((num % 2) == 0)
                    {
                        Console.WriteLine("El numero ingresado es par");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("El numero ingresado es impar");
                        Console.ReadKey();
                    }
                    break;
            }
        }
    }
}
