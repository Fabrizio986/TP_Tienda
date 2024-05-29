using System;

class Producto
{
    private string nombre;
    private decimal costo;
    private int stock;

    public string Nombre
    {
        get { return nombre; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("El nombre no puede estar vacío.");
            }
            nombre = value;
        }
    }

    public decimal Costo
    {
        get { return costo; }
        private set
        {
            if (value < 0)
            {
                Console.WriteLine("El costo debe ser mayor o igual a cero.");
            }
            costo = value;
        }
    }

    public decimal PrecioVenta
    {
        get { return costo * 1.3m; }
    }

    public int Stock
    {
        get { return stock; }
        set 
        {
            if (value < 0)
            {
                Console.WriteLine("El stock no puede ser negativo.");
            }
            stock = value;
        }
    }

    public Producto(string nombre, decimal costo, int stock)
    {
        Nombre = nombre;
        Costo = costo;
        Stock = stock;
    }

    public override string ToString()
    {
        return $"{Nombre} - Costo: {Costo:C} - Precio de Venta: {PrecioVenta:C} - Stock: {Stock}";
    }
}
