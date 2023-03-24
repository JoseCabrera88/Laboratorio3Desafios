using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] TareasR = new string[10];
            int opciones = 0;

            do
            {
                Console.WriteLine("    -- Lista de Tareas --   ");
                Console.WriteLine(" - Menu de Opciones : ");
                Console.WriteLine("1. Mostrar");
                Console.WriteLine("2. Agregar");
                Console.WriteLine("3. Eliminar");
                Console.WriteLine("4. Salir");
                Console.Write("   ---- Ingrese la opción deseada: ");
                opciones = int.Parse(Console.ReadLine());

                switch (opciones)
                {
                    case 1:
                        MostrarTareas(TareasR);
                        break;
                    case 2:
                        AgregarTarea(TareasR);
                        break;
                    case 3:
                        EliminarTarea(TareasR);
                        break;
                }
                Console.WriteLine();
            } while (opciones != 4);
        }
        static void MostrarTareas(string[] tareasM)
        {
            if (tareasM[0] == null)
            {
                Console.WriteLine("   ---- Estas son las Tareas Ingresadas ---- ");
            }
            else
            {
                for (int i = 0; i < tareasM.Length; i++)
                {
                    if (tareasM[i] != null)
                    {
                        Console.WriteLine(" // Tarea Ingresadas // ");
                        Console.WriteLine("{0}. {1}", i + 1, tareasM[i]);
                    }
                }
            }
        }
        static void AgregarTarea(string[] tareasA)
        {
            Console.Write("   ---- Ingrese una Tarea a Realizar : ");
            string tareaA = Console.ReadLine();

            for (int i = 0; i < tareasA.Length; i++)
            {
                if (tareasA[i] == null)
                {
                    tareasA[i] = tareaA;
                    Console.WriteLine("La Tarea se agrego");
                    return;
                }
            }
        }
        static void EliminarTarea(string[] tareaE)
        {
            Console.Write("   ---- Ingrese el número de la tarea a eliminar: ");
            int numTarea = int.Parse(Console.ReadLine());

            if (tareaE[numTarea - 1] != null)
            {
                tareaE[numTarea - 1] = null;
            }
        }
    }
}
