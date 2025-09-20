using System;
using System.Collections.Generic;
using System.Linq;

// Clase con alta cohesión: representa un producto.
// Su única responsabilidad es guardar la información del producto.
public class Producto
{
    public string Nombre { get; private set; }
    public decimal Precio { get; private set; }

    public Producto(string nombre, decimal precio)
    {
        Nombre = nombre;
        Precio = precio;
    }
}

// Clase con alta cohesión: gestiona las operaciones del carrito.
// Su única responsabilidad es manejar la lista de productos y calcular el total.
public class CarritoDeCompras
{
    private List<Producto> _productos;

    public CarritoDeCompras()
    {
        _productos = new List<Producto>();
    }

    public void AgregarProducto(Producto producto)
    {
        _productos.Add(producto);
        Console.WriteLine($":white_check_mark: '{producto.Nombre}' ha sido agregado al carrito.");
    }

    public void RemoverProducto(Producto producto)
    {
        if (_productos.Remove(producto))
        {
            Console.WriteLine($":x: '{producto.Nombre}' ha sido removido del carrito.");
        }
        else
        {
            Console.WriteLine($":warning: El producto '{producto.Nombre}' no se encontró en el carrito.");
        }
    }

    public decimal CalcularTotal()
    {
        // La responsabilidad de calcular el total está encapsulada aquí.
        // No necesitamos que otra clase lo haga.
        return _productos.Sum(p => p.Precio);
    }
}

// Clase principal para ejecutar el ejemplo.
class Program
{
    static void Main(string[] args)
    {
        // Creamos una instancia de nuestro carrito de compras.
        var miCarrito = new CarritoDeCompras();

        // Creamos algunos productos.
        var laptop = new Producto("Laptop Gamer", 1500.00M);
        var mouse = new Producto("Mouse Inalámbrico", 25.50M);

        // Agregamos los productos al carrito.
        miCarrito.AgregarProducto(laptop);
        miCarrito.AgregarProducto(mouse);
        
        Console.WriteLine("\n--- Resumen del Carrito ---");

        // Calculamos y mostramos el total.
        decimal total = miCarrito.CalcularTotal();
        Console.WriteLine($":moneybag: El total del carrito es: ${total}");

        Console.WriteLine("\n--------------------------");
        
        // Removemos un producto.
        miCarrito.RemoverProducto(laptop);

        // Volvemos a calcular el total.
        total = miCarrito.CalcularTotal();
        Console.WriteLine($"\n:moneybag: El nuevo total del carrito es: ${total}");
    }
}