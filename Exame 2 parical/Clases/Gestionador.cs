using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exame_2_parical.Clases
{
    public class Gestionador
    {
        private Empleado[] empleadosPredefinidos;

        // Lista de objetos (Gestión dinámica)
        private List<Empleado> listaEmpleados;

        public Gestionador()
        {
            listaEmpleados = new List<Empleado>();
            // Inicializar arreglo con 3 empleados de prueba
            empleadosPredefinidos = new Empleado[]
            {
                new Empleado(101, "Ana García", "Sistemas", 2500.50),
                new Empleado(102, "Luis Torres", "Recursos Humanos", 1800.00),
                new Empleado(103, "Carla Ruiz", "Sistemas", 2200.00)
            };
        }

        public void MostrarPredefinidos()
        {
            Console.WriteLine("\n--- Empleados Predefinidos (Arreglo) ---");
            foreach (var emp in empleadosPredefinidos)
            {
                Console.WriteLine(emp.ToString());
            }
        }

        public void AgregarEmpleado()
        {
            Console.WriteLine("\n--- Registro de Nuevo Empleado ---");
            // ID Automático basado en la cantidad actual + 1
            int nuevoId = listaEmpleados.Count + 1;

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Departamento: ");
            string depto = Console.ReadLine();
            Console.Write("Sueldo: ");
            double sueldo = double.Parse(Console.ReadLine());

            listaEmpleados.Add(new Empleado(nuevoId, nombre, depto, sueldo));
            Console.WriteLine("¡Empleado agregado exitosamente!");
        }

        public void BuscarPorId()
        {
            Console.Write("\nIngrese el ID a buscar: ");
            int idBusqueda = int.Parse(Console.ReadLine());

            var empleado = listaEmpleados.FirstOrDefault(e => e.Id == idBusqueda);

            if (empleado != null)
                Console.WriteLine("Resultado: " + empleado.ToString());
            else
                Console.WriteLine("Empleado no encontrado.");
        }

        public void BuscarPorDepartamento()
        {
            Console.Write("\nIngrese el Departamento a buscar: ");
            string deptoBusqueda = Console.ReadLine();

            var resultados = listaEmpleados.Where(e => e.Departamento.Equals(deptoBusqueda, StringComparison.OrdinalIgnoreCase)).ToList();

            if (resultados.Any())
            {
                Console.WriteLine($"--- Empleados en {deptoBusqueda} ---");
                resultados.ForEach(e => Console.WriteLine(e.ToString()));
            }
            else
            {
                Console.WriteLine("No se encontraron empleados en ese departamento.");
            }
        }

        public void MostrarListaDinamica()
        {
            if (listaEmpleados.Count == 0)
            {
                Console.WriteLine("\nLa lista dinámica está vacía.");
                return;
            }

            Console.WriteLine("\n--- Todos los Empleados (Lista) ---");
            foreach (var emp in listaEmpleados)
            {
                Console.WriteLine(emp.ToString());
            }
        }
    }
}
  