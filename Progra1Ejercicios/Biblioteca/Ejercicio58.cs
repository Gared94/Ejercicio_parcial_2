using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio58
    {
        //58.	Programa que muestre un menú al usuario que se repita las veces que sea necesario, hasta que escoja la opción Salir. 
        //Las opciones del menú deben permitir:

        //1.	Números pares hasta 100 (usando for)
        //2.	Múltiplos de 4 (usando while)
        //3.	Tabla de Multiplicar de un número hasta 10

        public void numerosMultiplos() { 
            int opcion;
            do{

                Console.WriteLine("1. Numeros pares hasta 100");
                Console.WriteLine("2. Multiplos de 4");
                Console.WriteLine("3. Tabla de multiplicar de un numero hasta 10");
                Console.WriteLine("4. Salir");
                opcion = int.Parse(Console.ReadLine());

                switch(opcion){
                    case 1:
                        Console.WriteLine("\nNumeros Pares");
                        for(int i = 2; i <= 100; i+=2){
                            Console.WriteLine(i);
                        }
                        break;
                    case 2:
                        Console.WriteLine("\nMultiplos de 4");
                        int number = 4, incremento=0;
                        while (incremento < 100) 
                        {
                            Console.WriteLine(number + incremento);
                            incremento += 4;
                        }
                        break;
                    case 3:
                        int num, resultado;
                        Console.WriteLine("\nTabla de multiplicar");
                        Console.WriteLine("Ingrese un numero");
                        num = int.Parse(Console.ReadLine());
                        for (int i = 1; i <= 10; i++)
                        {
                            resultado = num * i;
                            Console.WriteLine(num + " x " + i + " = " + resultado);
                        }
                        break;
                }

                Console.WriteLine("\n");
            }while(opcion != 4);
        }
    }
}
