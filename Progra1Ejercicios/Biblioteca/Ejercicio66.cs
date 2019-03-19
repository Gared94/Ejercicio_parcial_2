using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio66
    {
        public void operacionesVector() {
            int i = 0, j = 0;
            double[] VA = new double[12];
            double[] VB = new double[12];
            double[] VS = new double[12];
            double[] VR = new double[12];

            //Recopilando los datos del vector A
            do
            {
                j = i + 1;
                Console.Write("Digite la posición " + j + " del vector A: ");
                VA[i] = double.Parse(Console.ReadLine());
                Console.WriteLine();
                i = i + 1;
            } while (i < 12);

            //Recopilando los datos del vector B
            i = 0; j = 0;
            do
            {
                j = i + 1;
                Console.Write("Digite la posición " + j + " del vector B: ");
                VB[i] = double.Parse(Console.ReadLine());
                Console.WriteLine();
                i = i + 1;
            } while (i < 12);

            //Realizando la suma y resta de los vectores A y B
            i = 0; j = 0;
            do
            {
                VS[i] = VA[i] + VB[i];
                VR[i] = VA[i] - VB[i];
                i = i + 1;
            } while (i < 12);

            //Imprimiendo Vector A
            Console.WriteLine("Vector A");
            i = 0;
            do
            {
                Console.Write(VA[i] + "   ");
                i = i + 1;
            } while (i < 12);
            Console.WriteLine();
            Console.WriteLine();

            //Imprimiendo Vector B
            Console.WriteLine("Vector B");
            i = 0;
            do
            {
                Console.Write(VB[i] + "   ");
                i = i + 1;
            } while (i < 12);
            Console.WriteLine();
            Console.WriteLine();

            //Imprimiendo Vector Suma
            Console.WriteLine("Vector Suma = A + B");
            i = 0;
            do
            {
                Console.Write(VS[i] + "   ");
                i = i + 1;
            } while (i < 12);
            Console.WriteLine();
            Console.WriteLine();

            //Imprimiendo Vector Resta
            Console.WriteLine("Vector Resta = A - B");
            i = 0;
            do
            {
                Console.Write(VR[i] + "   ");
                i = i + 1;
            } while (i < 12);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Digite cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
