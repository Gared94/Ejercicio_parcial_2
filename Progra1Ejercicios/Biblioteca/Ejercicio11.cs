using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio11
    {
        //11.	Programa que permita determinar el salario a pagar a un empleado teniendo como entradas el salario diario y el número de días trabajados.
        //Tenga en cuenta que al empleado se le debe descontar el 10% por concepto de pensión y 15% por concepto de salud
        public void calculoSalario() {
            double sueldoDiario, cantidadDias, descuentos, sueldoNeto;

            Console.WriteLine("Ingrese el salario diario del trabajador");
            sueldoDiario = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de dias trabajados");
            cantidadDias = int.Parse(Console.ReadLine());

            descuentos = (cantidadDias * sueldoDiario) * 0.25;
            sueldoNeto = (cantidadDias * sueldoDiario) - descuentos;
            

            Console.WriteLine("El total a pagar al trabajador es: " + sueldoNeto);
            Console.ReadKey();
        }
    }
}
