using System;
using System.Collections.Generic;
using System.Linq;

class Carrito
{
    private List<(Producto, int)> productos = new List<(Producto, int)>();

    public void AgregarProducto(Producto producto, int cantidad)
    {
        var item = productos.FirstOrDefault(p => p.Item1 == producto);
        if (item.Item1 != null)
        {
            productos.Remove(item);
            productos.Add((producto, item.Item2 + cantidad));
        }
        else
        {
            productos.Add((producto, cantidad));
        }
    }

    public void EliminarProducto(Producto producto)
    {
        productos.RemoveAll(p => p.Item1 == producto);
    }

    public decimal CalcularSubtotal()
    {
        return productos.Sum(p => p.Item1.PrecioVenta * p.Item2);
    }

    public void MostrarProductos()
    {
        foreach (var (producto, cantidad) in productos)
        {
            Console.WriteLine($"{producto.Nombre} - Cantidad: {cantidad} - Precio Total: {producto.PrecioVenta * cantidad:C}");
        }
        Console.WriteLine($"Subtotal: {CalcularSubtotal():C}");
    }
}
