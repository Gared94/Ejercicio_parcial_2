using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio17
    {
        public void positivoNegativo() {
            double num;

            Console.WriteLine("Ingrese un numero");
            num = double.Parse(Console.ReadLine());

            if (num < 0) {
                Console.WriteLine("Numero ingresado es NEGATIVO");
            }
            else if (num > 0)
            {
                Console.WriteLine("Numero ingresado es POSITIVO");
            }
            else {
                Console.WriteLine("Numero ingresado es cero y carece de signo");
            }
        }
    }
}
