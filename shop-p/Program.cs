using System;
using System.Collections;

class Producto
{
    private string nombre;
    private decimal precio;
    private int cantidad;

    public Producto(string nombre, decimal precio, int cantidad)
    {
        this.nombre = nombre;
        this.precio = precio;
        this.cantidad = cantidad;
    }

    public string ObtenerNombre()
    {
        return nombre;
    }

    public decimal ObtenerPrecio()
    {
        return precio;
    }

    public int ObtenerCantidad()
    {
        return cantidad;
    }
}

class Program
{
    static ArrayList listaProductos = new ArrayList();

    static void Main()
    {
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("*********** Menú ***********");
            Console.WriteLine("1. Registrar un producto");
            Console.WriteLine("2. Buscar un producto");
            Console.WriteLine("3. Mostrar todos los productos");
            Console.WriteLine("4. Salir");
            Console.WriteLine("*****************************");

            Console.WriteLine("Ingrese una opción:");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    RegistrarProducto();
                    break;
                case "2":
                    BuscarProducto();
                    break;
                case "3":
                    MostrarProductos();
                    break;
                case "4":
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void RegistrarProducto()
    {
        Console.WriteLine("Ingrese el nombre del producto:");
        string nombre = Console.ReadLine();

        Console.WriteLine("Ingrese el precio del producto:");
        decimal precio = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la cantidad del producto:");
        int cantidad = int.Parse(Console.ReadLine());

        Producto nuevoProducto = new Producto(nombre, precio, cantidad);
        listaProductos.Add(nuevoProducto);

        Console.WriteLine("Producto registrado exitosamente.");
    }

    static void BuscarProducto()
    {
        Console.WriteLine("Ingrese el nombre del producto a buscar:");
        string nombreBusqueda = Console.ReadLine();

        Producto productoEncontrado = null;

        foreach (Producto producto in listaProductos)
        {
            if (producto.ObtenerNombre() == nombreBusqueda)
            {
                productoEncontrado = producto;
                break;
            }
        }

        if (productoEncontrado != null)
        {
            Console.WriteLine($"Producto: {productoEncontrado.ObtenerNombre()}");
            Console.WriteLine($"Precio: {productoEncontrado.ObtenerPrecio()}");
            Console.WriteLine($"Cantidad: {productoEncontrado.ObtenerCantidad()}");
        }
        else
        {
            Console.WriteLine("Producto no encontrado.");
        }
    }

    static void MostrarProductos()
    {
        foreach (Producto producto in listaProductos)
        {
            Console.WriteLine($"Producto: {producto.ObtenerNombre()}");
            Console.WriteLine($"Precio: {producto.ObtenerPrecio()}");
            Console.WriteLine($"Cantidad: {producto.ObtenerCantidad()}");
            Console.WriteLine("-----------------------------");
        }
    }
}




//  class Producto
//  {
//      public string Nombre { get; set; }
//      public decimal Precio { get; set; }
//      public int Cantidad { get; set; }

//     public Producto(string nombre, decimal precio, int cantidad)
//      {
//          Nombre = nombre;
//          Precio = precio;
//          Cantidad = cantidad;
//      }
//  }