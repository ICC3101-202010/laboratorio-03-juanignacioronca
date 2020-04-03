using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_03
{
    class Trabajadores:Persona
    {
        // Atributos
        public string Puesto;
        public int Sueldo;
        public int Hora_de_Trabajo = 45;
        //Constructor
        public Trabajadores(string rut, string nombre, string apellido, string fecha_de_Nacimiento, string nacionalidad, string puesto, int sueldo)
        {
            Rut = rut;
            Nombre = nombre;
            Apellido = apellido;
            Fecha_de_Nacimiento = fecha_de_Nacimiento;
            Nacionalidad = nacionalidad;
            Puesto = puesto;
            Sueldo = sueldo;
        }
    }
}
