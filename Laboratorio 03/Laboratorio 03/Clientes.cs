using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_03
{
    class Clientes : Persona
    {
        //Atributos
        public Random rnd = new Random();
        public int Saldo_Disponible;
        //Constructos
        public Clientes(string rut, string nombre, string apellido, string fecha_de_Nacimiento, string nacionalidad)
        {
            Rut = rut;
            Nombre = nombre;
            Apellido = apellido;
            Fecha_de_Nacimiento = fecha_de_Nacimiento;
            Nacionalidad = nacionalidad;
            this.Saldo_Disponible = rnd.Next(300000, 1000000);
        }
        public void Comprar(Clientes clientes,int cant, Productos producto)
        {
            if (cant*producto.Precio<=clientes.Saldo_Disponible)
            {
                producto.Comprar(producto, cant);
                Console.WriteLine("Compra valida");
            }
            else
            {
                Console.WriteLine("Compra invalida, saldo no disponible");
            }
        }
    }
}
