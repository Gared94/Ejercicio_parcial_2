using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicio65
    {
        public void Hotel(){

        int m,i,j,mes=0,sum;
			string month="";
						
			//Capturando el mes de interés			
			do{
				Console.WriteLine("Digite el mes en números (1 - 12)");
				m=int.Parse(Console.ReadLine());
				switch (m)
				{
					case 1:
						mes=31;
						month="Enero";
						break;
					case 2:
						mes=28;
						month="Febrero";
						break;
					case 3:
						mes=31;
						month="Marzo";
						break;
					case 4:
						mes=30;
						month="Abril";
						break;
					case 5:
						mes=31;
						month="Mayo";
						break;
					case 6:
						mes=30;
						month="Junio";
						break;
					case 7:
						mes=31;
						month="Julio";
						break;
					case 8:
						mes=31;
						month="Agosto";
						break;
					case 9:
						mes=30;
						month="Septiembre";
						break;
					case 10:
						mes=31;
						month="Octubre";
						break;
					case 11:
						mes=30;
						month="Noviembre";
						break;
					case 12:
						mes=31;
						month="Diciembre";
						break;
					default:
						Console.WriteLine("Número digitado es incorrecto");
						break;
				}
			}while (m>12);
			//Asignando tamanio del vector
			int[] C = new int[mes];
			//Capturando cantidad de clientes por dia del mes
			i=0;
			do{
				j =i+1;
				Console.WriteLine("Digite cantidad de clientes del día "+j+": ");
				C[i] = int.Parse(Console.ReadLine());
				i = i+1;
			}while (i < mes);
			//Haciendo sumatoria total de clientes del mes
			i = 0; sum=0;
			do{
				sum = sum + C[i];
				i = i+1;
			}while (i<mes);
			Console.WriteLine();
			Console.WriteLine("La cantidad de clientes en el mes "+month+" fue de "+sum);
			Console.WriteLine();
			Console.WriteLine("Digite cualquier tecla para salir..."); 
			Console.ReadKey();
		
        }
    }
}
