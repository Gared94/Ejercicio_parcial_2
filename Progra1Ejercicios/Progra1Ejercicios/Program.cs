using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Progra1Ejercicios;
using Biblioteca;

namespace Progra1Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            String resp;
            do
            {

                int opcion;
                Console.WriteLine("Ingrese el numero de ejercicio a revisar");
                opcion = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("SUMA");
                        Ejercicio01 obj1 = new Ejercicio01();
                        obj1.Sumar();
                        break;
                    case 2:
                        Console.WriteLine("MULTIPLICACION");
                        Ejercicio02 obj2 = new Ejercicio02();
                        obj2.Multiplicar();
                        break;
                    case 3:
                        Console.WriteLine("DIVISION");
                        Ejercicio03 obj3 = new Ejercicio03();
                        obj3.division();
                        break;
                    case 4:
                        Console.WriteLine("MOVIMIENTO RECTILINEO UNIFORME");
                        Ejercicio04 obj4 = new Ejercicio04();
                        obj4.MRU();
                        break;
                    case 5:
                        Console.WriteLine("CALCULAR EDAD");
                        Ejercicio05 obj5 = new Ejercicio05();
                        obj5.calcularEdad();
                        break;
                    case 6:
                        Console.WriteLine("CALCULAR 20%");
                        Ejercicio06 obj6 = new Ejercicio06();
                        obj6.Porcentaje();
                        break;
                    case 7:
                        Console.WriteLine("CALCULAR 30%, 60%, 90%");
                        Ejercicio07 obj7 = new Ejercicio07();
                        obj7.Porcentajes();
                        break;
                    case 8:
                        Console.WriteLine("AREA DE UN CUADRADO");
                        Ejercicio08 obj8 = new Ejercicio08();
                        obj8.areaCuadrado();
                        break;
                    case 9:
                        Console.WriteLine("PROMEDIO");
                        Ejercicio09 obj9 = new Ejercicio09();
                        obj9.promedio();
                        break;
                    case 10:
                        Console.WriteLine("TIENDA");
                        Ejercicio10 obj10 = new Ejercicio10();
                        obj10.tienda();
                        break;
                    case 11:
                        Console.WriteLine("TRABAJADOR");
                        Ejercicio11 obj11 = new Ejercicio11();
                        obj11.calculoSalario();
                        break;
                    case 12:
                        Console.WriteLine("PERIMETRO DE UN CUADRADO");
                        Ejercicio12 obj12 = new Ejercicio12();
                        obj12.perimetroCuadrado();
                        break;
                    case 13:
                        Console.WriteLine("OPERACIONES");
                        Ejercicio13 obj13 = new Ejercicio13();
                        obj13.Operaciones();
                        break;
                    case 14:
                        Console.WriteLine("SUMA Y PROMEDIO");
                        Ejercicio14 obj14 = new Ejercicio14();
                        obj14.sumaPromedio();
                        break;
                    case 15:
                        Console.WriteLine("TIENDA");
                        Ejercicio15 obj15 = new Ejercicio15();
                        obj15.abonoComprador();
                        break;
                    case 16:
                        Console.WriteLine("MAYOR O MENOR");
                        Ejercicio16 obj16 = new Ejercicio16();
                        obj16.mayorEdad();
                        break;
                    case 17:
                        Console.WriteLine("POSITIVO O NEGATIVO");
                        Ejercicio17 obj17 = new Ejercicio17();
                        obj17.positivoNegativo();
                        break;
                    case 18:
                        Console.WriteLine("NUMERO MAYOR");
                        Ejercicio18 obj18 = new Ejercicio18();
                        obj18.numeroMayor();;
                        break;
                    case 19:
                        Console.WriteLine("HENRIQUE OLAVA HERRERA");
                        Ejercicio19 obj19 = new Ejercicio19();
                        obj19.refrigerio();
                        break;
                    case 20:
                        Console.WriteLine("MITAD DE UN NUMERO");
                        Ejercicio20 obj20 = new Ejercicio20();
                        obj20.mitad();
                        break;
                    case 21:
                        Console.WriteLine("SUMA O RESTA");
                        Ejercicio21 obj21 = new Ejercicio21();
                        obj21.numero();
                        break;
                    case 22:
                        Console.WriteLine("ESTUDIANTE");
                        Ejercicio22 obj22 = new Ejercicio22();
                        obj22.estudiante();
                        break;
                    case 23:
                        Console.WriteLine("TIENDA");
                        Ejercicio23 obj23 = new Ejercicio23();
                        obj23.almacen();
                        break;
                    case 24:
                        Console.WriteLine("MAYOR Y MENOR");
                        Ejercicio24 obj24 = new Ejercicio24();
                        obj24.numeros();
                        break;
                    case 25:
                        Console.WriteLine("NOTAS");
                        Ejercicio25 obj25 = new Ejercicio25();
                        obj25.notas();
                        break;
                    case 26:
                        Console.WriteLine("DIGITOS");
                        Ejercicio26 obj26 = new Ejercicio26();
                        obj26.numeros();
                        break;
                    case 27:
                        Console.WriteLine("COMPRA");
                        Ejercicio27 obj27 = new Ejercicio27();
                        obj27.compras();
                        break;
                    case 28:
                        Console.WriteLine("PAR O IMPAR");
                        Ejercicio28 obj28 = new Ejercicio28();
                        obj28.numero();
                        break;
                    case 29:
                        Console.WriteLine("TEMPERATURA");
                        Ejercicio29 obj29 = new Ejercicio29();
                        obj29.temperatura();
                        break;
                    case 30:
                        Console.WriteLine("TOTAL A PAGAR");
                        Ejercicio30 obj30 = new Ejercicio30();
                        obj30.superTienda();
                        break;
                    case 31:
                        Console.WriteLine("EQUIPO BALONCESTO");
                        Ejercicio31 obj31 = new Ejercicio31();
                        obj31.deportista();
                        break;
                    case 32:
                        Console.WriteLine("VOCAL O CONSONANTE");
                        Ejercicio32 obj32 = new Ejercicio32();
                        obj32.vocal();
                        break;
                    case 33:
                        Console.WriteLine("MOVIMIENTO RECTILINEO");
                        Ejercicio33 obj33 = new Ejercicio33();
                        obj33.rectilineo();
                        break;
                    case 34:
                        Console.WriteLine("POSITIVO NEGATIVO PAR O IMPAR");
                        Ejercicio34 obj34 = new Ejercicio34();
                        obj34.numcual();
                        break;
                    case 35:
                        Console.WriteLine("MOVIMIENTO RECTILINEO");
                        Ejercicio35 obj35 = new Ejercicio35();
                        obj35.Menu();
                        break;
                    case 36:
                        Console.WriteLine("NUMEROS NATURALES");
                        Ejercicio36 obj36 = new Ejercicio36();
                        obj36.naturales();
                        break;
                    case 37:
                        Console.WriteLine("NUMEROS PARES");
                        Ejercicio37 obj37 = new Ejercicio37();
                        obj37.Pares();
                        break;
                    case 38:
                        Console.WriteLine("NUMEROS IMPARES");
                        Ejercicio38 obj38 = new Ejercicio38();
                        obj38.Impares();
                        break;
                    case 39:
                        Console.WriteLine("ESTUDIANTES MAYORES");
                        Ejercicio39 obj39 = new Ejercicio39();
                        obj39.Estudiantes();
                        break;
                    case 40:
                        Console.WriteLine("HOMBRES/MUJERES");
                        Ejercicio40 obj40 = new Ejercicio40();
                        obj40.ejercicio40();
                        break;
                    case 41:
                        Console.WriteLine("EDAD PROMEDIO");
                        Ejercicio41 obj41 = new Ejercicio41();
                        obj41.ejercicio41();
                        break;
                    case 42:
                        Console.WriteLine("ESTATURA PROMEDIO");
                        Ejercicio42 obj42 = new Ejercicio42();
                        obj42.ejercicio42();
                        break;
                    case 43:
                        Console.WriteLine("MULTIPLOS DE 3");
                        Ejercicio43 obj43 = new Ejercicio43();
                        obj43.ejercicio43();
                        break;
                    case 44:
                        Console.WriteLine("MULTIPLOS DE 3");
                        Ejercicio44 obj44 = new Ejercicio44();
                        obj44.ejercicio44();
                        break;
                    case 45:
                        Console.WriteLine("MULTIPLOS DE 5");
                        Ejercicio45 obj45 = new Ejercicio45();
                        obj45.ejercicio45();
                        break;
                    case 46:
                        Console.WriteLine("PROMEDIO");
                        Ejercicio46 obj46 = new Ejercicio46();
                        obj46.ejercicio46();
                        break;
                    case 47:
                        Console.WriteLine("POTENCIA");
                        Ejercicio47 obj47 = new Ejercicio47();
                        obj47.ejercicio47();
                        break;
                    case 48:
                        Console.WriteLine("SUMA");
                        Ejercicio48 obj48 = new Ejercicio48();
                        obj48.ejercicio48();
                        break;
                    case 49:
                        Console.WriteLine("MAYOR Y MENOR");
                        Ejercicio49 obj49 = new Ejercicio49();
                        obj49.ejercicio49();
                        break;
                    case 50:
                        Console.WriteLine("POTENCIAS");
                        Ejercicio50 obj50 = new Ejercicio50();
                        obj50.ejercicio50();
                        break;
                    case 51:
                        Console.WriteLine("BUSCAR NUMERO");
                        Ejercicio51 obj51 = new Ejercicio51();
                        obj51.ejercicio51();
                        break;

                    case 52:
                        Console.WriteLine("CALIFICACIONES");
                        Ejercicio52 obj52 = new Ejercicio52();
                        obj52.ejercicio52();
                        break;


                    case 53:
                        Console.WriteLine("FACTORIAL DE UN NUMERO");
                        Ejercicio53 obj53 = new Ejercicio53();
                        obj53.ejercicio53();
                        break;

                    case 54:
                        Console.WriteLine("VALOR A PAGAR EN CAJA");
                        Ejercicio54 obj54 = new Ejercicio54();
                        obj54.ejercicio54();
                        break;

                    case 55:
                        Console.WriteLine("ESTATURA");
                        Ejercicio55 obj55 = new Ejercicio55();
                        obj55.ejercicio55();
                        break;

                    case 56:
                        Console.WriteLine("OPERACIONES - DOWHILE");
                        Ejercicio56 obj56 = new Ejercicio56();
                        obj56.OperacionesDoWhile();
                        break;
                    case 57:
                        Console.WriteLine("OPERACIONES - DOWHILE");
                        Ejercicio57 obj57 = new Ejercicio57();
                        obj57.factorialPotencia();
                        break;
                    case 58:
                        Console.WriteLine("NUMEROS Y MULTIPLOS");
                        Ejercicio58 obj58 = new Ejercicio58();
                        obj58.numerosMultiplos();
                        break;
                    case 59:
                        Console.WriteLine("EDAD");
                        Ejercicio59 obj59 = new Ejercicio59();
                        obj59.edades();
                        break;
                    case 60:
                        Console.WriteLine("NOMBRES");
                        Ejercicio60 obj60 = new Ejercicio60();
                        obj60.nombres();
                        break;
                    case 61:
                        Console.WriteLine("NOMBRES");
                        Ejercicio61 obj61 = new Ejercicio61();
                        obj61.sumaVector();
                        break;

                    case 62:
                        Console.WriteLine("VECTOR");
                        Ejercicio62 obj62 = new Ejercicio62();
                        obj62.ejercicio62();
                        break;

                    case 63:
                        Console.WriteLine("VECTOR");
                        Ejercicio63 obj63 = new Ejercicio63();
                        obj63.ejercicio63();
                        break;

                    case 64:
                        Console.WriteLine("VECTOR 18");
                        Ejercicio64 obj64 = new Ejercicio64();
                        obj64.vector();
                        break;
                    case 65:
                        Console.WriteLine("HOTEL");
                        Ejercicio65 obj65 = new Ejercicio65();
                        obj65.Hotel();
                        break;
                    case 66:
                        Console.WriteLine("OPERACIONES VECTOR");
                        Ejercicio66 obj66 = new Ejercicio66();
                        obj66.operacionesVector();
                        break;
                    case 67:
                        Console.WriteLine("OPERACIONES VECTOR");
                        Ejercicio67 obj67 = new Ejercicio67();
                        obj67.operacionesAvanzadas();
                        break;
                    case 68:
                        Console.WriteLine("OPERACIONES VECTOR");
                        Ejercicio68 obj68 = new Ejercicio68();
                        obj68.vectorEstudiantes();
                        break;
                    case 69:
                        Console.WriteLine("OPERACIONES VECTOR");
                        Ejercicio69 obj69 = new Ejercicio69();
                        obj69.vectorUnido();
                        break;
                    case 70:
                        Console.WriteLine("MATRIZ");
                        Ejercicio70 obj70 = new Ejercicio70();
                        obj70.ejercicio70();
                        break;

                    case 71:
                        Console.WriteLine("MATRIZ");
                        Ejercicio71 obj71 = new Ejercicio71();
                        obj71.ejercicio71();
                        break;

                    case 72:
                        Console.WriteLine("MATRIZ");
                        Ejercicio72 obj72 = new Ejercicio72();
                        obj72.ejercicio72();
                        break;

                    case 73:
                        Console.WriteLine("MATRIZ");
                        Ejercicio73 obj73 = new Ejercicio73();
                        obj73.ejercicio73();
                        break;

                    case 74:
                        Console.WriteLine("MATRIZ");
                        Ejercicio74 obj74 = new Ejercicio74();
                        obj74.ejercicio74();
                        break;

                    case 75:
                        Console.WriteLine("MATRIZ");
                        Ejercicio75 obj75 = new Ejercicio75();
                        obj75.ejercicio75();
                        break;
                    case 76:
                        Console.WriteLine("MATRIZ");
                        Ejercicio76 obj76 = new Ejercicio76();
                        obj76.ejercicio76();
                        break;

                    case 77:
                        Console.WriteLine("MATRIZ");
                        Ejercicio77 obj77 = new Ejercicio77();
                        obj77.ejercicio77();
                        break;

                    case 78:
                        Console.WriteLine("MATRIZ");
                        Ejercicio78 obj78 = new Ejercicio78();
                        obj78.ejercicio78();
                        break;
                }

                Console.WriteLine("");
                Console.WriteLine("Desea evaluar otro ejercicio? S/N");
                resp = Console.ReadLine();
            } while (resp.Equals("S")||resp.Equals("s"));
        }
    }
}