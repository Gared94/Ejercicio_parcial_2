using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio47
    {
        public void ejercicio47()
        {
            int bse, exponente, n = 2, resp = 0;
            Console.WriteLine("Ingresa la base");
            bse = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el exponente");
            exponente = int.Parse(Console.ReadLine());

            resp = bse * bse;
            while (n < exponente)
            {

                resp = resp * bse;
                n++;
            }
            Console.WriteLine("La respuesta es: " + resp);
            Console.ReadKey();
        }
    }
}
