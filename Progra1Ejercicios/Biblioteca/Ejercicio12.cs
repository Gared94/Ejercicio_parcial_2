using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio12
    {
        //12.	Realizar la carga del lado de un cuadrado, mostrar por pantalla el perímetro del mismo 
        //(El perímetro de un cuadrado se calcula multiplicando el valor del lado por cuatro)
        public void perimetroCuadrado() {
            double lado, perimetro;

            Console.WriteLine("Ingrese el lado del cuadrado");
            lado = double.Parse(Console.ReadLine());

            perimetro = lado * 4;

            Console.WriteLine("El perimetro del cuadrado es: " + perimetro);
            Console.ReadKey();
        }
    }
}
