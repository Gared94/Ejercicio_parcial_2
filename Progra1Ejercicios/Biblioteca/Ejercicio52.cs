using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio52
    {
        public void ejercicio52()
        {
            int cantidad;
            int i;
            double nota, promedio = 0, notas = 0, mayor = 0, menor = 0;
            string estado = "";
            Console.WriteLine("¿Cuantas notas desea ingresar?");
            cantidad = int.Parse(Console.ReadLine());

            for (i = 1; i <= cantidad; i++)
            {
                Console.WriteLine("Ingrese la nota " + i);
                nota = double.Parse(Console.ReadLine());

                notas = nota + notas;


                promedio = notas / cantidad;
                if (i == 1) { mayor = nota; menor = nota; }
                if (nota > mayor) { mayor = nota; }
                if (nota < menor) { menor = nota; }
                nota = 0;

                if (promedio >= 4) { estado = "Aprobado"; }
                else { estado = "Reprobado"; }



            }
            Console.WriteLine("El mayor es: " + mayor);
            Console.WriteLine("El menor es: " + menor);
            Console.WriteLine("El promedio es: " + promedio);
            Console.WriteLine("El estado del alumno es: " + estado);
            Console.ReadKey();
        }
    }
}
