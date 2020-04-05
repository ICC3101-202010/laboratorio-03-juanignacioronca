using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_03
{
    class Registro
    {
        //Atributos
        private string Nombre_Cliente;
        private string Apellido_Cliente;
        private string Nombre_Vendedor;
        private string Apellido_Vendedor;
        private string Nombre_Producto;
        private string Marca_Producto;
        private int Cantidad_Producto;
        private int Precio_Compra;
        private DateTime DateTime;

        public Registro(string nombre_Cliente, string apellido_Cliente, string nombre_Vendedor,
        string apellido_Vendedor, string nombre_Producto, string marca_Producto, int cantidad_Producto, int precio_Compra,DateTime dateTime)
        {
            Nombre_Cliente = nombre_Cliente;
            Apellido_Cliente = apellido_Cliente;
            Nombre_Vendedor = nombre_Vendedor;
            Apellido_Vendedor = apellido_Vendedor;
            Nombre_Producto = nombre_Producto;
            Marca_Producto = marca_Producto;
            Cantidad_Producto = cantidad_Producto;
            Precio_Compra = precio_Compra;
            DateTime = dateTime;
        }
        //Metodos
        public string Informacion(Registro registro)
        {
            return "\n|Nombre Cliente: " + registro.Nombre_Cliente + " " + registro.Apellido_Cliente +"\n|Nombre Vendedor: " + registro.Nombre_Vendedor + " " + registro.Apellido_Vendedor +"\n|Nombre Producto: " + registro.Nombre_Producto + " " + registro.Marca_Producto+"\n|Cantidad del Producto: "+ registro.Cantidad_Producto+"\n|Valor de compra :"+ registro.Precio_Compra + "\n|Hora de compra: "+registro.DateTime;
        }
    }
}
