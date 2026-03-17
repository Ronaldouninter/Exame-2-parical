using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exame_2_parical.Clases
{
    /// <summary>
    /// RONALDO 17-09-2024
    /// EN ESTA CLASE SE CREO LA CLASE EMPLEADO CON SUS RESPECTIVAS PROPIEDADES, SE CREO UN ARREGLO DE EMPLEADOS PREDEFINIDOS, SE CREO UN MENU PARA AGREGAR NUEVOS EMPLEADOS A UNA LISTA, BUSCAR POR ID, BUSCAR POR DEPARTAMENTO Y MOSTRAR TODOS LOS EMPLEADOS DE LA LISTA. 
    /// </summary>
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Departamento { get; set; }
        public double Sueldo { get; set; }

        public Empleado(int id, string nombre, string departamento, double sueldo)
        {
            Id = id;
            Nombre = nombre;
            Departamento = departamento;
            Sueldo = sueldo;
        }

        public override string ToString()
        {
            return $"[ID: {Id}] Nombre: {Nombre} | Depto: {Departamento} | Sueldo: ${Sueldo:N2}";
        }
    }
} 

    

