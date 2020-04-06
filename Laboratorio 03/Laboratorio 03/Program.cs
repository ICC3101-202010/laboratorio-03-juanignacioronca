using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            //Creacion listas:
            List<Clientes> Lista_Clientes = new List<Clientes>();
            List<Trabajadores> Lista_Trabajadores = new List<Trabajadores>();
            List<Productos> Lista_Productos = new List<Productos>();
            List<Registro> Lista_Registro = new List<Registro>();

            //Creacion clientes:
            Clientes cliente_1 = new Clientes("123456789", "Agustin", "Gonzalez", "02-11-1960", "Chilena");
            Clientes cliente_2 = new Clientes("987654321", "Benjamin", "Fernandez", "22-08-1984", "Argentina");
            Clientes cliente_3 = new Clientes("135792468", "Sebastian", "Herrera", "27-03-1990", "Española");
            Clientes cliente_4 = new Clientes("246813579", "Juan", "Muñoz", "05-05--1995", "Chilena");
            Clientes cliente_5 = new Clientes("192837465", "Gonzalo", "Perez", "16-01-1998", "Chilena");
            Clientes cliente_6 = new Clientes("564738291", "Maria", "Riquelme", "01-12-1973", "Argentina");
            Clientes cliente_7 = new Clientes("123987456", "Teresa", "Errazuriz", "26-10-1967", "Española");
            Clientes cliente_8 = new Clientes("123987465", "Catalina", "Alvarez", "03-04-2000", "Chilena");
            Clientes cliente_9 = new Clientes("214365879", "Sofia", "Amunategui", "29-02-1940", "Chilena");
            Clientes cliente_10 = new Clientes("112233445", "Dominga", "Tagle", "03-07-1999", "Argentina");

            //Agregar a la lista
            Lista_Clientes.Add(cliente_1);
            Lista_Clientes.Add(cliente_2);
            Lista_Clientes.Add(cliente_3);
            Lista_Clientes.Add(cliente_4);
            Lista_Clientes.Add(cliente_5);
            Lista_Clientes.Add(cliente_6);
            Lista_Clientes.Add(cliente_7);
            Lista_Clientes.Add(cliente_8);
            Lista_Clientes.Add(cliente_9);
            Lista_Clientes.Add(cliente_10);

            //Creacion trabajadores:
            Trabajadores trabajador_1 = new Trabajadores("192633363", "Hugo", "Cuevas", "02-05-1967", "Chilena", "Auxiliar");
            Trabajadores trabajador_2 = new Trabajadores("154976661", "Alvaro", "Fuente", "17-11-1973", "Venezolana", "Vendedor");
            Trabajadores trabajador_3 = new Trabajadores("176459873", "Carlos", "Cifuentes", "12-05-1978", "Chilena", "Auxiliar");
            Trabajadores trabajador_4 = new Trabajadores("153461974", "Mateo", "Gallardo", "16-12-1991", "Peruana", "Vendedor");
            Trabajadores trabajador_5 = new Trabajadores("201356927", "Josefina", "Silva", "23-10-1987", "Chilena", "Supervisor");
            Trabajadores trabajador_6 = new Trabajadores("146278936", "Antonia", "Echeverria", "17-11-1993", "Peruana", "Vendedor");
            Trabajadores trabajador_7 = new Trabajadores("153484472", "Catalina", "Swett", "29-01-1975", "Peruana", "Vendedor");
            Trabajadores trabajador_8 = new Trabajadores("207963454", "Rosario", "Ugarte", "04-07-1980", "Chilena", "Auxiliar");
            Trabajadores trabajador_9 = new Trabajadores("160877310", "Martina", "Irarrazabal", "31-08-1986", "Venezolana", "Auxiliar");
            trabajador_1.Determinacion_Sueldo(trabajador_1.Puesto);
            trabajador_2.Determinacion_Sueldo(trabajador_2.Puesto);
            trabajador_3.Determinacion_Sueldo(trabajador_3.Puesto);
            trabajador_4.Determinacion_Sueldo(trabajador_4.Puesto);
            trabajador_5.Determinacion_Sueldo(trabajador_5.Puesto);
            trabajador_6.Determinacion_Sueldo(trabajador_6.Puesto);
            trabajador_7.Determinacion_Sueldo(trabajador_7.Puesto);
            trabajador_8.Determinacion_Sueldo(trabajador_8.Puesto);
            trabajador_9.Determinacion_Sueldo(trabajador_9.Puesto);

            //Agregar a la lista
            Lista_Trabajadores.Add(trabajador_1);
            Lista_Trabajadores.Add(trabajador_2);
            Lista_Trabajadores.Add(trabajador_3);
            Lista_Trabajadores.Add(trabajador_4);
            Lista_Trabajadores.Add(trabajador_5);
            Lista_Trabajadores.Add(trabajador_6);
            Lista_Trabajadores.Add(trabajador_7);
            Lista_Trabajadores.Add(trabajador_8);
            Lista_Trabajadores.Add(trabajador_9);

            //Creacion Productos:
            Productos producto_1 = new Productos("Maquilaje", "NCN", 500, 7000);
            Productos producto_2 = new Productos("Maquilaje", "Beauty Store", 500, 5000);
            Productos producto_3 = new Productos("Ropa", "Boulevard", 500, 12000);
            Productos producto_4 = new Productos("Ropa", "Sybilla", 500, 8000);
            Productos producto_5 = new Productos("Carne", "La Preferida ", 500, 15000);
            Productos producto_6 = new Productos("Carne", "La Crianza", 500, 20000);
            Productos producto_7 = new Productos("Agua", "Benedictino", 500, 1000);
            Productos producto_8 = new Productos("Agua", "Cachantun", 500, 1500);
            Productos producto_9 = new Productos("Yogurt", "Soprole ", 500, 300);
            Productos producto_10 = new Productos("Yogurt", "Danone", 500, 400);
            Productos producto_11 = new Productos("Papel Higiénico", "Confort", 500, 1000);
            Productos producto_12 = new Productos("Papel Higiénico", "Elite", 500, 1500);
            Productos producto_13 = new Productos("Lapices ", "Bic", 500, 1000);
            Productos producto_14 = new Productos("Lapices", "Stabilo", 500, 1500);
            Productos producto_15 = new Productos("Shampoo", "Pantene", 500, 6000);
            Productos producto_16 = new Productos("Shampoo", "Herbal Essence", 500, 8000);
            Productos producto_17 = new Productos("Balsamo", "Head Shoulders", 500, 5000);
            Productos producto_18 = new Productos("Balsamo", "Deluxe", 500, 7000);
            Productos producto_19 = new Productos("Crema Corporal", "Nivea", 500, 7000);
            Productos producto_20 = new Productos("Crema Corporal", "Natura", 500, 5000);

            //Agregar a la lista
            Lista_Productos.Add(producto_1);
            Lista_Productos.Add(producto_2);
            Lista_Productos.Add(producto_3);
            Lista_Productos.Add(producto_4);
            Lista_Productos.Add(producto_5);
            Lista_Productos.Add(producto_6);
            Lista_Productos.Add(producto_7);
            Lista_Productos.Add(producto_8);
            Lista_Productos.Add(producto_9);
            Lista_Productos.Add(producto_10);
            Lista_Productos.Add(producto_11);
            Lista_Productos.Add(producto_12);
            Lista_Productos.Add(producto_13);
            Lista_Productos.Add(producto_14);
            Lista_Productos.Add(producto_15);
            Lista_Productos.Add(producto_16);
            Lista_Productos.Add(producto_17);
            Lista_Productos.Add(producto_18);
            Lista_Productos.Add(producto_19);
            Lista_Productos.Add(producto_20);

            int aux_1 = -1;
            while (aux_1!=0)
            {
                Console.WriteLine("Menu\n1.Simular compra manual:\n2.Simular compra automatica:\n3.Ver registro:\n4.Ver stock disponible:\n5.Ajuste de puesto: \n0.Salir");
                aux_1 =Convert.ToInt32(Console.ReadLine());
                if (aux_1 == 1)
                {
                    int aux_2 =-1;
                    while (aux_2!=0)
                    {
                        Console.WriteLine("Primero selecione un cliente o '0' para volver atras:");
                        int aux_3 = 1;  
                        foreach (var item in Lista_Clientes)
                        {
                            Console.WriteLine(aux_3+"."+item.Nombre+" "+item.Apellido);
                            aux_3 += 1;
                        }
                        aux_2 = Convert.ToInt32(Console.ReadLine());
                        if (aux_2 == 0)
                        {
                            continue;
                        }
                        else if (aux_2<0 | aux_2>10)
                        {
                            Console.WriteLine("Numero invalido, intente nuevamente");
                            continue;
                        }
                        else 
                        {
                            int aux_4 = -1;
                            while (aux_4!=0)
                            {
                                Console.WriteLine("Cliente selecionado: " + Lista_Clientes[aux_2-1].Nombre + " " + Lista_Clientes[aux_2-1].Apellido);
                                Console.WriteLine("Ahora selecione un vendedor o '0' para volver atras:");
                                int aux_5 = 1;
                                foreach (var item in Lista_Trabajadores)
                                { 
                                    if (item.Puesto=="Vendedor")
                                    {
                                        Console.WriteLine(aux_5 + ". Caja de " + item.Nombre + " " + item.Apellido);
                                        aux_5 += 1;
                                    }
                                    else
                                    {
                                        aux_5 += 1;
                                    }
                                }
                                aux_4=Convert.ToInt32(Console.ReadLine());
                                if (aux_4 == 0)
                                {
                                    continue;
                                }
                                else if (aux_4 < 0 | aux_4 > 9)
                                {
                                    Console.WriteLine("Numero invalido, intente nuevamente");
                                    continue;
                                }
                                else
                                {
                                    if (Lista_Trabajadores[aux_4 - 1].Puesto == "Vendedor")
                                    {
                                        int aux_6 = -1;
                                        while (aux_6!=0)
                                        {
                                            Console.WriteLine("Caja selecionada: " + Lista_Trabajadores[aux_4-1].Nombre+" "+ Lista_Trabajadores[aux_4 - 1].Apellido);
                                            Console.WriteLine("Ahora selecione un producto o '0' para volver atras:");
                                            int aux_7 = 1;
                                            foreach (var item in Lista_Productos)
                                            {
                                                Console.WriteLine(aux_7 + "." + item.Nombre + " " + item.Marca);
                                                aux_7 += 1;
                                            }
                                            aux_6 = Convert.ToInt32(Console.ReadLine());
                                            if (aux_6 == 0)
                                            {
                                                continue;
                                            }
                                            else if (aux_6 < 0 | aux_6 > 20)
                                            {
                                                Console.WriteLine("Numero invalido, intente nuevamente");
                                                continue;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Quedan del producto " + Lista_Productos[aux_6 - 1].Nombre + " " + Lista_Productos[aux_6 - 1].Marca + ": " + Lista_Productos[aux_6 - 1].Stock + " en stock.");
                                                Console.WriteLine("Cuantos desea comprar:");
                                                int aux_8 = Convert.ToInt32(Console.ReadLine());
                                                int aux_9 = Lista_Registro.Count;
                                                Console.WriteLine(aux_9);
                                                if (Lista_Clientes[aux_2 - 1].Comprar(Lista_Clientes[aux_2 - 1], aux_8, Lista_Productos[aux_6 - 1]) == 1)
                                                {
                                                    Lista_Registro.Add(new Registro(Lista_Clientes[aux_2 - 1].Nombre, Lista_Clientes[aux_2 - 1].Apellido,
                                                        Lista_Trabajadores[aux_4 - 1].Nombre, Lista_Trabajadores[aux_4 - 1].Apellido,
                                                        Lista_Productos[aux_6 - 1].Nombre, Lista_Productos[aux_6 - 1].Marca,
                                                        aux_8, Lista_Productos[aux_6 - 1].Precio * aux_8,DateTime.Now));
                                                }
                                                else
                                                {
                                                    continue;
                                                }
                                                
                                                
                                                aux_2 = 0;
                                                aux_4 = 0;
                                                aux_6 = 0;
                                            }
                                        }
                                    }
                                    else
                                    {Console.WriteLine("Numero invalido, intente nuevamente");
                                        continue;}
                                }
                            }
                        }
                    }
                }
                else if (aux_1== 2)
                {
                    int aux_2 = -1;
                    while (aux_2 != 0)
                    {
                        Console.WriteLine("Primero selecione un cliente o '0' para volver atras:");
                        int aux_3 = 1;
                        foreach (var item in Lista_Clientes)
                        {
                            Console.WriteLine(aux_3 + "." + item.Nombre + " " + item.Apellido);
                            aux_3 += 1;
                        }
                        aux_2 = rnd.Next(1,10);
                        if (aux_2 == 0)
                        {
                            continue;
                        }
                        else if (aux_2 < 0 | aux_2 > 10)
                        {
                            Console.WriteLine("Numero invalido, intente nuevamente");
                            continue;
                        }
                        else
                        {
                            int aux_4 = -1;
                            while (aux_4 != 0)
                            {
                                Console.WriteLine("Cliente selecionado: " + Lista_Clientes[aux_2 - 1].Nombre + " " + Lista_Clientes[aux_2 - 1].Apellido);
                                Console.WriteLine("Ahora selecione un vendedor o '0' para volver atras:");
                                int aux_5 = 1;
                                foreach (var item in Lista_Trabajadores)
                                {
                                    if (item.Puesto == "Vendedor")
                                    {
                                        Console.WriteLine(aux_5 + ". Caja de " + item.Nombre + " " + item.Apellido);
                                        aux_5 += 1;
                                    }
                                    else
                                    {
                                        aux_5 += 1;
                                    }
                                }
                                aux_4 = rnd.Next(1,9);
                                if (aux_4 == 0)
                                {
                                    continue;
                                }
                                else if (aux_4 < 0 | aux_4 > 9)
                                {
                                    Console.WriteLine("Numero invalido, intente nuevamente");
                                    continue;
                                }
                                else
                                {
                                    if (Lista_Trabajadores[aux_4 - 1].Puesto == "Vendedor")
                                    {
                                        int aux_6 = -1;
                                        while (aux_6 != 0)
                                        {
                                            Console.WriteLine("Caja selecionada: " + Lista_Trabajadores[aux_4 - 1].Nombre + " " + Lista_Trabajadores[aux_4 - 1].Apellido);
                                            Console.WriteLine("Ahora selecione un producto o '0' para volver atras:");
                                            int aux_7 = 1;
                                            foreach (var item in Lista_Productos)
                                            {
                                                Console.WriteLine(aux_7 + "." + item.Nombre + " " + item.Marca);
                                                aux_7 += 1;
                                            }
                                            aux_6 = rnd.Next(1,20);
                                            if (aux_6 == 0)
                                            {
                                                continue;
                                            }
                                            else if (aux_6 < 0 | aux_6 > 20)
                                            {
                                                Console.WriteLine("Numero invalido, intente nuevamente");
                                                continue;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Quedan del producto " + Lista_Productos[aux_6 - 1].Nombre + " " + Lista_Productos[aux_6 - 1].Marca + ": " + Lista_Productos[aux_6 - 1].Stock + " en stock.");
                                                Console.WriteLine("Cuantos desea comprar:");
                                                int aux_8 = rnd.Next(1,100);
                                                int aux_9 = Lista_Registro.Count;
                                                Console.WriteLine(aux_9);
                                                if (Lista_Clientes[aux_2 - 1].Comprar(Lista_Clientes[aux_2 - 1], aux_8, Lista_Productos[aux_6 - 1]) == 1)
                                                {
                                                    Lista_Registro.Add(new Registro(Lista_Clientes[aux_2 - 1].Nombre, Lista_Clientes[aux_2 - 1].Apellido,
                                                        Lista_Trabajadores[aux_4 - 1].Nombre, Lista_Trabajadores[aux_4 - 1].Apellido,
                                                        Lista_Productos[aux_6 - 1].Nombre, Lista_Productos[aux_6 - 1].Marca,
                                                        aux_8, Lista_Productos[aux_6 - 1].Precio * aux_8, DateTime.Now));
                                                }
                                                else
                                                {
                                                    continue;
                                                }
                                                aux_2 = 0;
                                                aux_4 = 0;
                                                aux_6 = 0;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Numero invalido, intente nuevamente");
                                        continue;
                                    }
                                }
                            }
                        }
                    }
                }
                else if (aux_1== 3)
                {
                    int aux_11 = 1;
                    foreach (var item in Lista_Registro)
                    {
                        Console.WriteLine("\nREGISTRO NUMERO "+aux_11+":");
                        Console.WriteLine(item.Informacion(item));
                        aux_11 += 1;
                    }
                }
                else if (aux_1 == 4)
                {
                    Console.WriteLine("\n--------Stock disponible--------\n");
                    int aux_12 = 1;
                    foreach (var item in Lista_Productos)
                    {
                        Console.WriteLine(aux_12+": "+item.Informacion_Stock(item));
                        aux_12 += 1;
                    }
                }
                else if (aux_1== 5)
                {
                    int aux_14 = -1;
                    while (aux_14 != 0)
                    {
                        Console.WriteLine("Seleccione un trabajador o '0' para volver atras:");
                        int aux_13 = 1;
                        foreach (var item in Lista_Trabajadores)
                        {
                            Console.WriteLine(aux_13 + ". " + item.Nombre + " " + item.Apellido + " " + item.Puesto);
                            aux_13 += 1;
                            if (true)
                            {

                            }
                        }
                        aux_14 = Convert.ToInt32(Console.ReadLine());
                        if (aux_14 == 0)
                        {
                            continue;
                        }
                        else if (aux_14<0 | aux_14>9)
                        {
                            Console.WriteLine("Numero invalido, intente nuevamente:");
                        }
                        else
                        {
                            int aux_15 = -1;
                            while (aux_15 != 0)
                            {
                                Console.WriteLine("Nombre: " + Lista_Trabajadores[aux_14 - 1].Nombre + " " + Lista_Trabajadores[aux_14 - 1].Apellido + ". Puesto:  " + Lista_Trabajadores[aux_14 - 1].Puesto);
                                Console.WriteLine("Selecione a que puesto desea cambiar al trabajador o '0' para volver atras: \n1.Vendedor\n2.Auxiliar\n3.Supervisor");
                                aux_15 = Convert.ToInt32(Console.ReadLine());
                                if (aux_15 ==0)
                                {
                                    continue;
                                }
                                else if (aux_15 == 1)
                                { Lista_Trabajadores[aux_14 - 1].Cambio_de_Puesto(Lista_Trabajadores[aux_14 - 1],"Vendedor"); aux_15 = 0; }
                                else if (aux_15 == 2)
                                { Lista_Trabajadores[aux_14 - 1].Cambio_de_Puesto(Lista_Trabajadores[aux_14 - 1], "Auxiliar"); aux_15 = 0; }
                                else if (aux_15 == 3)
                                { Lista_Trabajadores[aux_14 - 1].Cambio_de_Puesto(Lista_Trabajadores[aux_14 - 1], "Supervisor"); aux_15 = 0; }
                                else
                                {
                                    Console.WriteLine("Numero incorrecto, intente nuevamente");
                                }
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Opcion invalida, intente nuevamente");
                }
            }
        }
    }
}