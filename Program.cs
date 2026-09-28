using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    internal class Program
    {
        static int max = 100;
        static string[] nombres = new string[max];
        static double[] notas = new double[max];
        static int contador = 0;
        static public void Tittle()
        {
            Console.WriteLine("***************************************"); Console.WriteLine("SISTEMA DE NOTAS"); Console.WriteLine("***************************************");
        }
        static public void Registrar_Estu()
        {

            Console.WriteLine("Registro de estudiante nuevo");
            if (contador >= max)
            {
                Console.WriteLine("Haz llegado a la capacidad máxima ");
                return;
            }
            Console.WriteLine("Ingrese nombres: ");
            String nombre = Console.ReadLine();
            double nota;
            while (true)
            {
                Console.WriteLine("Ingresar la nota: ");
                nota = double.Parse(Console.ReadLine());
                if (nota >= 0 && nota <= 20)
                {
                    break;
                }
                Console.WriteLine("Nota inválida.");

            }
            nombres[contador] = nombre;
            notas[contador] = nota;
            contador++;
        }
        static public void mostrar()
        {
            Console.WriteLine("****************************Listado de estudiantes**********************");
            if(contador == 0)
            {
                Console.WriteLine("No hay datos, la lista esta vacia"); return;
            }
            for (int i = 0; i < contador ; i++)
            {
                Console.WriteLine($"{i+1}.- {nombres[i]} -Nota: {notas[i]}");
            }
        }
        static void Main(string[] args)
        {
            Tittle();
            int op = 0;
            while(op != 6)
            {
                Console.WriteLine("******MENU PRINCIPAL******");
                Console.WriteLine("1. Registrar estudiante ");
                Console.WriteLine("2. Buscar estudiante ");
                Console.WriteLine("3. Modificar nota");
                Console.WriteLine("4. Mostrar lista sin ordenar");
                Console.WriteLine("5. Mostrar reporte ordenado");
                Console.WriteLine("6. Salir del programa");
                Console.Write("Ingresar opción: ");
                if(op<1 || op > 6)
                {
                    Console.WriteLine("!!!!ERROR OPCION FUERA DE RANGO!!!!");
                    continue;
                }
                switch (op)
                {
                    case 1:
                        Registrar_Estu(); break;
                    case 2:
                        //Buscar_Estu();
                        break;
                    case 3:
                        //modificar_nota();
                        break;
                    case 4:
                        mostrar(); break;
                    case 5:
                        //burbuja();
                        break;
                    case 6:
                        Console.WriteLine("Saliendo del sistema...."); break;
                    default:
                        Console.WriteLine("Opción incorrecta"); break ;

                }
                
            }
        }
    }
}
