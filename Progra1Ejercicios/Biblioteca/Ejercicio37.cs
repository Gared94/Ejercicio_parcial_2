using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio37
    {
            int par = 0;

            public void Pares()
            {
                int n = 0;
                for (int i = 0; i < 201; i++)
                {

                    if (i % 2 == 0)
                    {
                        Console.WriteLine("{0}", i);
                        n++;
                    }
                }
                Console.Write("\n\nDel 0 al 200 hay : " + n + " pares ");
                Console.WriteLine("\n");
            }
    }
}
