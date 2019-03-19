using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio56
    {
        //56.	Programa que muestre un menú al usuario que se repita las veces que sea necesario, hasta que escoja la opción salir. 
//        Las opciones del menú deben permitir:

//1.	Ingresar 2 números
//2.	Realizar la suma
//3.	Realizar la resta
//4.	Realizar la multiplicación
//5.	Realizar la división
//6.	Salir del programa

        public void OperacionesDoWhile() {
            int opcion;
            double num1, num2, suma, multi, division, resta;

            do{
                Console.WriteLine("1. Ingresar 2 numeros");
                Console.WriteLine("2. Realizar la suma");
                Console.WriteLine("3. Realizar la resta");
                Console.WriteLine("4. Realizar la multiplicacion");
                Console.WriteLine("5. Realizar la division");
                Console.WriteLine("6. Salir del programa\n");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1 || opcion == 2 || opcion == 3 || opcion == 4 || opcion == 5) 
                {
                    Console.WriteLine("\nIngrese el primer numero");
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero");
                    num2 = double.Parse(Console.ReadLine());

                    switch(opcion){
                        case 1:
                            Console.WriteLine("\n***************************");
                            Console.WriteLine("Numeros han sido ingresados");
                            Console.WriteLine("***************************\n");
                            break;
                        case 2:
                            suma = num1 + num2;
                            Console.WriteLine("\n***************************");
                            Console.WriteLine("Suma: " + suma);
                            Console.WriteLine("***************************\n");
                            break;
                        case 3:
                            resta = num1 - num2;
                            Console.WriteLine("\n***************************");
                            Console.WriteLine("Resta: " + resta);
                            Console.WriteLine("***************************\n");
                            break;
                        case 4:
                            multi = num1 * num2;
                            Console.WriteLine("\n***************************");
                            Console.WriteLine("Multiplicacion: " + multi);
                            Console.WriteLine("***************************\n");
                            break;
                        case 5:
                            if (num2 != 0)
                            {
                                division = num1 / num2;
                                Console.WriteLine("\n***************************");
                                Console.WriteLine("Division: " + division);
                                Console.WriteLine("***************************\n");
                            }
                            else 
                            {
                                Console.WriteLine("***************************");
                                Console.WriteLine("No se puede dividir por cero");
                                Console.WriteLine("***************************\n");
                            }
                            break;
                    }
                }
            }while(opcion != 6);
        }

    }
}
