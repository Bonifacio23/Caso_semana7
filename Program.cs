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
            Console.WriteLine("***************************************"); Console.WriteLine("\tSISTEMA DE NOTAS"); Console.WriteLine("***************************************");
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
        static public void modificar_Not()
        {
            Console.WriteLine("**********MODIFICAR ESTUDIANTE**********");
            if (contador == 0)
            {
                Console.WriteLine("No hay estudiantes registrados.");
                return;
            }
            Console.WriteLine("Ingrese el nombre del estudiante a modificar: ");
            string nombreBuscado = Console.ReadLine();
            bool encontrado = false;
            for (int i = 0; i < contador; i++)
            {
                if (nombres[i].Equals(nombreBuscado, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Estudiante encontrado: {nombres[i]} - Nota: {notas[i]}");
                    double nuevaNota;
                    while (true)
                    {
                        Console.WriteLine("Ingrese la nueva nota: ");
                        nuevaNota = double.Parse(Console.ReadLine());
                        if (nuevaNota >= 0 && nuevaNota <= 20)
                        {
                            notas[i] = nuevaNota;
                            Console.WriteLine("Nota modificada exitosamente.");
                            break;
                        }
                        Console.WriteLine("Nota inválida.");
                    }
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado)
            {
                Console.WriteLine("Estudiante no encontrado.");
            }
        }
        static public void modificar_nom()
        {
            Console.WriteLine("**********MODIFICAR ESTUDIANTE**********");
            if (contador == 0)
            {
                Console.WriteLine("No hay estudiantes registrados.");
                return;
            }
            Console.WriteLine("Ingrese el nombre del estudiante a modificar: ");
            string nombreBuscado = Console.ReadLine();
            bool encontrado = false;
            for (int i = 0; i < contador; i++)
            {
                if (nombres[i].Equals(nombreBuscado, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Estudiante encontrado: {nombres[i]} - Nota: {notas[i]}");
                    String nuevoNombre;
                    while (true)
                    {
                        Console.WriteLine("Ingrese el nuevo nombre: ");
                        nuevoNombre = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(nuevoNombre))
                        {
                            break;
                        }
                        nombres[i] = nuevoNombre;
                        Console.WriteLine("Nombre modificado exitosamente.");
                        break;
                    }
                    encontrado = true;
                }
                if (!encontrado)
                {
                    Console.WriteLine("Estudiante no encontrado.");
                }
            }
        }
            static public void Buscar_Estu()
            {
            Console.WriteLine("**********BUSCAR ESTUDIANTE**********");
            if (contador == 0)
            {
                Console.WriteLine("No hay estudiantes registrados.");
                return;
            }
            Console.WriteLine("Ingrese el nombre del estudiante a buscar: ");
            string nombreBuscado = Console.ReadLine();
            bool encontrado = false;
            for (int i = 0; i < contador; i++)
            {
                if (nombres[i].Equals(nombreBuscado, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Estudiante encontrado: {nombres[i]} - Nota: {notas[i]}");
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado)
            {
                Console.WriteLine("Estudiante no encontrado.");
            }
        }
        static public void burbuja()
        {
            for (int i = 0; i < contador - 1; i++)
            {
                for (int j = 0; j < contador - i - 1; j++)
                {
                    if (notas[j] > notas[j + 1])
                    {
                        // Intercambiar notas
                        double tempNota = notas[j];
                        notas[j] = notas[j + 1];
                        notas[j + 1] = tempNota;
                        // Intercambiar nombres correspondientes
                        string tempNombre = nombres[j];
                        nombres[j] = nombres[j + 1];
                        nombres[j + 1] = tempNombre;
                    }
                }
            }
            Console.WriteLine("Lista ordenada por nota de menor a mayor:");
            mostrar();
        }
        
        static public void seleccion_desc()
        {
            for (int i = 0; i < contador - 1; i++)
            {
                int indiceMaximo = i;
                for (int j = i + 1; j < contador; j++)
                {
                    if (notas[j] > notas[indiceMaximo])
                    {
                        indiceMaximo = j;
                    }
                }
                // Intercambiar notas
                double tempNota = notas[i];
                notas[i] = notas[indiceMaximo];
                notas[indiceMaximo] = tempNota;
                // Intercambiar nombres correspondientes
                string tempNombre = nombres[i];
                nombres[i] = nombres[indiceMaximo];
                nombres[indiceMaximo] = tempNombre;
            }
            Console.WriteLine("Lista ordenada por nota de mayor a menor:");
            mostrar();
        }
        static public void promedio_maximo()
        {
            if (contador == 0)
            {
                Console.WriteLine("No hay estudiantes registrados.");
                return;
            }
            double suma = 0;
            double maxNota = notas[0];
            for (int i = 0; i < contador; i++)
            {
                suma += notas[i];
                if (notas[i] > maxNota)
                {
                    maxNota = notas[i];
                }
            }
            double promedio = suma / contador;
            Console.WriteLine($"Promedio de notas: {promedio:F2}");
            Console.WriteLine($"Nota máxima: {maxNota}");
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
            while(op != 9)
            {
                Console.Clear();
                Console.WriteLine("******MENU PRINCIPAL******");
                Console.WriteLine("1. Registrar estudiante ");
                Console.WriteLine("2. Buscar estudiante ");
                Console.WriteLine("3. Modificar Nota");
                Console.WriteLine("4. Modificar Nombre");
                Console.WriteLine("5. Mostrar lista sin ordenar");
                Console.WriteLine("6. Mostrar reporte ordenado");
                Console.WriteLine("7. Mostrar por seleccion DESC");
                Console.WriteLine("8. Promedio y nota maxima");
                Console.WriteLine("9. Salir");
                Console.Write("Ingresar opción: ");
                if (!int.TryParse(Console.ReadLine(),out op))
                {
                    Console.WriteLine("!!!!ERROR OPCION FUERA DE RANGO!!!!");
                    continue;
                }
                switch (op)
                {
                    case 1:
                        Registrar_Estu(); break;
                    case 2:
                        Buscar_Estu();
                        break;
                    case 3:
                        modificar_Not();
                        break;
                    case 4:
                        modificar_nom();
                        break;
                    case 5:
                        mostrar(); break;
                    case 6:
                        burbuja();
                        break;
                    case 7:
                        seleccion_desc(); break;
                    case 8:
                        promedio_maximo(); break;
                    case 9:
                        Console.WriteLine("Saliendo del sistema...."); break;
                    default:
                        Console.WriteLine("Opción incorrecta"); break ;

                }
                Console.ReadKey();
                
            }
        }
    }
}
