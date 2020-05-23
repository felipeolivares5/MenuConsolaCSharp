using System;
using System.Collections.Generic;
namespace menus
{
    class Program
    {
        static void Main(string[] args)
        {
            var clientes = new List<Cliente>();
            int opcion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Elija una opción:");
                Console.WriteLine("1 - Clientes");
                Console.WriteLine("2 - Articulos");
                Console.WriteLine("3 - Empleados");
                Console.WriteLine("4 - Salir");
                opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    Console.WriteLine("Sección Clientes");
                    Cliente.menuCliente(clientes);
                    Console.ReadLine();
                }
                if (opcion == 2)
                {
                    Console.WriteLine("Sección Articulos");
                    Console.ReadLine();
                }
                if (opcion == 3)
                {
                    Console.WriteLine("Sección Empleados");
                    Console.ReadLine();
                }

            } while (opcion != 4);

        }
    }
}