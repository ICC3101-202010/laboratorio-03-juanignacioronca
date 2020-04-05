using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_03
{
    class Productos
    {
        //Atributos
        public string Nombre;
        public string Marca;
        public int Stock;
        public int Precio;

        //Metodos
        public Productos(string nombre, string marca, int stock, int precio)
        {
            Nombre = nombre;
            Marca = marca;
            Stock = stock;
            Precio = precio;
        }

        public void Comprar(Productos producto, int cant)
        {
            producto.Stock -= cant;
        }

        public string Informacion_Stock(Productos productos)
        {
            return productos.Nombre + " " + productos.Marca + " Stock disponible : " + productos.Stock;
        }
    }
}
