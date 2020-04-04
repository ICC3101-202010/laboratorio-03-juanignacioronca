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
        public int Comprar(Clientes clientes,int cant, Productos producto)
        {
            if (cant*producto.Precio<=clientes.Saldo_Disponible)
            {
                if (producto.Stock>=cant)
                {
                    producto.Comprar(producto, cant);
                    this.Saldo_Disponible -= producto.Precio * cant;
                    Console.WriteLine("Compra valida");
                    return 1;
                }
                else {Console.WriteLine("Compra invalida, stock no disponible");
                    return 0;
                }
            }
            else
            {
                Console.WriteLine("Compra invalida, saldo no disponible");
                return 0;
            }
        }
    }
}
