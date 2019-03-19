using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio67
    {
        public void operacionesAvanzadas() 
        {
            int i = 0, j = 0, n = 0;
            double[] VA1;
            double[] VA2;
            double[] VA3;

            //Determinando tamanio del vector A1
            Console.Write("Ingrese el tamaño del vector: ");
            n = int.Parse(Console.ReadLine());

            //Definiendo tamanio de los vectores
            VA1 = new double[n];
            VA2 = new double[n];
            VA3 = new double[n];

            //Recopilando los datos del vector A1
            do
            {
                j = i + 1;
                Console.Write("Digite la posición " + j + " del vector A: ");
                VA1[i] = double.Parse(Console.ReadLine());
                Console.WriteLine();
                i = i + 1;
            } while (i < n);

            //Calculando el cuadrado
            i = 0;
            do
            {
                VA2[i] = VA1[i] * VA1[i];
                i = i + 1;
            } while (i < n);

            //Calculando el cubo
            i = 0;
            do
            {
                VA3[i] = VA1[i] * VA1[i] * VA1[i];
                i = i + 1;
            } while (i < n);

            //Imprimiendo Vector A
            Console.WriteLine("Vector A1");
            i = 0;
            do
            {
                Console.Write(VA1[i] + "   ");
                i = i + 1;
            } while (i < n);
            Console.WriteLine();
            Console.WriteLine();

            //Imprimiendo Vector A2
            Console.WriteLine("Cuadrado de Elementos Vector A1");
            i = 0;
            do
            {
                Console.Write(VA2[i] + "   ");
                i = i + 1;
            } while (i < n);
            Console.WriteLine();
            Console.WriteLine();

            //Imprimiendo Vector A3
            Console.WriteLine("Cubo de Elementos Vector A1");
            i = 0;
            do
            {
                Console.Write(VA3[i] + "   ");
                i = i + 1;
            } while (i < n);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Digite cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
