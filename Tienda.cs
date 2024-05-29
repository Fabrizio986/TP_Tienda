using System;
using System.Collections.Generic;
using System.Linq;

class Tienda
{
    private List<Producto> productos = new List<Producto>();
    private Carrito carrito = new Carrito();
    private decimal dineroEnCaja = 0;

    public void AgregarProducto()
    {
        Console.Write("Ingrese nombre del producto: ");
        string nombre = Console.ReadLine();
        Console.Write("Ingrese costo del producto: ");
        decimal costo = decimal.Parse(Console.ReadLine());
        Console.Write("Ingrese stock del producto: ");
        int stock = int.Parse(Console.ReadLine());

        Producto producto = new Producto(nombre, costo, stock);
        productos.Add(producto);
        Console.WriteLine("Producto agregado con éxito.");
    }

    public void EliminarProducto()
    {
        Console.Write("Ingrese nombre del producto a eliminar: ");
        string nombre = Console.ReadLine();
        Producto producto = productos.FirstOrDefault(p => p.Nombre == nombre);

        if (producto != null)
        {
            productos.Remove(producto);
            Console.WriteLine("Producto eliminado con éxito.");
        }
        else
        {
            Console.WriteLine("Producto no encontrado.");
        }
    }

    public void MostrarProductos()
    {
        foreach (var producto in productos)
        {
            Console.WriteLine(producto);
        }
    }

    public void AgregarProductoAlCarrito()
    {
        Console.Write("Ingrese nombre del producto: ");
        string nombre = Console.ReadLine();
        Producto producto = productos.FirstOrDefault(p => p.Nombre == nombre);

        if (producto != null)
        {
            Console.Write("Ingrese cantidad: ");
            int cantidad = int.Parse(Console.ReadLine());

            if (cantidad <= producto.Stock)
            {
                carrito.AgregarProducto(producto, cantidad);
                producto.Stock -= cantidad;
                Console.WriteLine("Producto agregado al carrito con éxito.");
            }
            else
            {
                Console.WriteLine("No hay suficiente stock disponible.");
            }
        }
        else
        {
            Console.WriteLine("Producto no encontrado.");
        }
    }

    public void EliminarProductoDelCarrito()
    {
        Console.Write("Ingrese nombre del producto a eliminar del carrito: ");
        string nombre = Console.ReadLine();
        Producto producto = productos.FirstOrDefault(p => p.Nombre == nombre);

        if (producto != null)
        {
            carrito.EliminarProducto(producto);
            Console.WriteLine("Producto eliminado del carrito con éxito.");
        }
        else
        {
            Console.WriteLine("Producto no encontrado.");
        }
    }

    public void MostrarProductosDelCarrito()
    {
        carrito.MostrarProductos();
    }

    public void Cobrar()
    {
        decimal total = carrito.CalcularSubtotal();
        Console.WriteLine($"Total a pagar: {total:C}");
        Console.Write("Ingrese cantidad con la que paga el cliente: ");
        decimal pago = decimal.Parse(Console.ReadLine());

        if (pago >= total)
        {
            decimal vuelto = pago - total;
            dineroEnCaja += total;
            Console.WriteLine($"Pago realizado con éxito. Vuelto: {vuelto:C}");
        }
        else
        {
            Console.WriteLine("El pago es insuficiente.");
        }
    }
}
