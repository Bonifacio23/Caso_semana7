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
        }
    }
}
