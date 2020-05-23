using System;
using System.Collections.Generic;

namespace menus
{
    class Cliente
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public Cliente(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public static void menuCliente(List<Cliente> clientes)
        {
            int opcionCliente = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Elija una opción de cliente:");
                Console.WriteLine("1 - guardar cliente");
                Console.WriteLine("2 - mostrar clientes");
                Console.WriteLine("3 - Salir");
                opcionCliente = int.Parse(Console.ReadLine());
                if (opcionCliente == 1)
                {
                    Console.WriteLine("Sección Guardar clientes");
                    guardarCliente(clientes);
                    Console.ReadLine();
                }
                if (opcionCliente == 2)
                {
                    Console.WriteLine("Sección Mostrar clientes");
                    mostrarCliente(clientes);
                    Console.ReadLine();
                }

            } while (opcionCliente != 3);
        }
        public static void guardarCliente(List<Cliente> clientes){
            Console.WriteLine("ingrese nombre de cliente");
            string nombre = Console.ReadLine();
            Console.WriteLine("ingrese apellido de cliente");
            string apellido = Console.ReadLine();
            Cliente c1 = new Cliente(nombre,apellido);
            clientes.Add(c1);
        }
         public static void mostrarCliente(List<Cliente> clientes){
            
            foreach (var cli in clientes)
            {
                Console.WriteLine("nombre cliente: "+ cli.nombre);
                Console.WriteLine("apellido cliente: "+ cli.apellido);
            }
        }
       
    }
}
