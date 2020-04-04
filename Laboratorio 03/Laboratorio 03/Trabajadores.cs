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
        public Trabajadores(string rut, string nombre, string apellido, string fecha_de_Nacimiento, string nacionalidad, string puesto)
        {
            Rut = rut;
            Nombre = nombre;
            Apellido = apellido;
            Fecha_de_Nacimiento = fecha_de_Nacimiento;
            Nacionalidad = nacionalidad;
            Puesto = puesto;
        }
        public void Determinacion_Sueldo(string puesto)
        {
            if (puesto =="Vendedor")
            { Sueldo = 450000; }
            else if (puesto=="Auxiliar")
            { Sueldo = 385000; }
            else if (puesto=="Supervisor")
            { Sueldo = 750000; }
        }
        public void Cambio_de_Puesto(Trabajadores trabajador,string puesto)
        {
            trabajador.Puesto = puesto;
            trabajador.Determinacion_Sueldo(trabajador.Puesto);
        }
    }
}
