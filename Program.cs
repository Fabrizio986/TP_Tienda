using System;

class Program
{
    static void Main(string[] args)
    {
        Tienda tienda = new Tienda();
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Agregar producto a la tienda");
            Console.WriteLine("2. Eliminar producto de la tienda");
            Console.WriteLine("3. Mostrar productos de la tienda");
            Console.WriteLine("4. Agregar producto al carrito");
            Console.WriteLine("5. Eliminar producto del carrito");
            Console.WriteLine("6. Mostrar productos del carrito y subtotal");
            Console.WriteLine("7. Cobrar");
            Console.WriteLine("8. Salir");
            Console.Write("Opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    tienda.AgregarProducto();
                    break;
                case "2":
                    tienda.EliminarProducto();
                    break;
                case "3":
                    tienda.MostrarProductos();
                    break;
                case "4":
                    tienda.AgregarProductoAlCarrito();
                    break;
                case "5":
                    tienda.EliminarProductoDelCarrito();
                    break;
                case "6":
                    tienda.MostrarProductosDelCarrito();
                    break;
                case "7":
                    tienda.Cobrar();
                    break;
                case "8":
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}
