using Exame_2_parical.Clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exame_2_parical
{
    /// <summary>
    /// RONALDO 17-09-2024
    /// EN ESTE PROGRAMA SE CREO UNA CLASE EMPLEADO CON SUS RESPECTIVAS PROPIEDADES, SE CREO UN ARREGLO DE EMPLEADOS PREDEFINIDOS, SE CREO UN MENU PARA AGREGAR NUEVOS EMPLEADOS A UNA LISTA, BUSCAR POR ID, BUSCAR POR DEPARTAMENTO Y MOSTRAR TODOS LOS EMPLEADOS DE LA LISTA.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Gestionador miGestion = new Gestionador();
            bool salir = false;

            while (!salir)
            {
             
                Console.WriteLine("MENU");
                Console.WriteLine("==============================");
                Console.WriteLine("1. Mostrar empleados predefinidos");
                Console.WriteLine("2. Agregar nuevo empleado");
                Console.WriteLine("3. Buscar empleado por ID");
                Console.WriteLine("4. Buscar por Departamento");
                Console.WriteLine("5. Mostrar lista completa");
                Console.WriteLine("6. Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        miGestion.MostrarPredefinidos();
                        break;
                    case "2":
                        miGestion.AgregarEmpleado();
                        break;
                    case "3":
                        miGestion.BuscarPorId();
                        break;
                    case "4":
                        miGestion.BuscarPorDepartamento();
                        break;
                    case "5":
                        miGestion.MostrarListaDinamica();
                        break;
                    case "6":
                        salir = true;
                        Console.WriteLine("Saliendo del sistema...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida, intente de nuevo.");
                        break;
                }
            }
        }
    }
}
            
