using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio62
    {
        public void ejercicio62()
        {
            double[] progra = new Double[20]; //vector inicializado
            int contpos = 0, contneg = 0, contcero = 0;

            Console.WriteLine("ingrese 20 digitos"); //ingresar digitos por consola

            foreach (int numero in progra) //Recorrer el vector
            {
                progra[numero] = double.Parse(Console.ReadLine()); // leer cada dato ingresado 
                                                                   //Console.WriteLine(progra[numero]);

                if (progra[numero] > 0) //numero > 0 aumenta contador
                {
                    contpos = contpos + 1;
                }

                else if (progra[numero] < 0) //numero < 0 aumenta contador
                {
                    contneg = contneg + 1;
                }

                else contcero = contcero + 1; //numero = 0 aumenta contador
            }

            Console.WriteLine("positivos: " + contpos.ToString() + " \nnegativos: " + contneg.ToString() + "\nceros: " + contcero); //imprimir resultados 

            Console.ReadKey();

        }

    }
}
