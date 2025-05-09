/* A partir de la lista de productos que se obtiene de Producto.CrearListaDeEjemplo()
             * Resolver:
             * 1. El primer producto 
             * 2. El último producto
             * 3. La suma de precios
             * 4. El promedio de precios
             * 5. Listar los productos con Id mayor a 15
             * 6. Obtener una lista de cada producto con su nombre y el precio en formato moneda, luego mostrar los elementos
             * 7. El producto con el precio más alto
             * 8. El producto con el precio más bajo
             * 9. Obtener y mostrar los productos cuyo precio sea mayor al promedio
             * 10. Listar los productos ordenados por descripción de forma descendente
             * Cada punto se debe realizar en un método distinto, en una nueva clase llamada Solucion
*/
namespace Dsw2025Ej10
{
    internal class Solucion
    {
        public static void PrimerProducto(List<Producto> productos)
        {
            Console.WriteLine("==============================================================");
            Console.WriteLine($"Primer producto:");
            Console.WriteLine($"{productos.FirstOrDefault().ObtenerDetalle()}");
        }

        public static void UltimoProducto(List<Producto> productos)
        {
            Console.WriteLine("==============================================================");
            Console.WriteLine($"Último producto:");
            Console.WriteLine($"{productos.LastOrDefault().ObtenerDetalle()}");
        }
        public static void SumaDePrecios(List<Producto> productos)
        {
            Console.WriteLine("==============================================================");
            Console.WriteLine($"Suma de precios: ${productos.Sum(p => p.Precio)}");
        }
        public static void PromedioDePrecios(List<Producto> productos)
        {
            Console.WriteLine("==============================================================");
            Console.WriteLine($"Promedio de precios: ${productos.Average(p => p.Precio)}");
        }
        public static void ProductosConIdMayorA15(List<Producto> productos)
        {
            Console.WriteLine("==============================================================");
            Console.WriteLine($"Productos con Id mayor a 15:");
            foreach (var producto in productos.Where(p => p.Id > 15))
            {
                Console.WriteLine($"{producto.ObtenerDetalle()}");
            }
        }
        public static void ListaConPreciosEnFormatoMoneda(List<Producto> productos)
        {
            Console.WriteLine("==============================================================");
            Console.WriteLine($"Lista con precios en formato moneda:");
            foreach (var producto in productos)
            {
                Console.WriteLine($"{producto.ObtenerDetalle()}");
            }
        }
        public static void ProductoConPrecioMasAlto(List<Producto> productos)
        {
            Console.WriteLine("==============================================================");
            Console.WriteLine($"Producto con el precio más alto:");
            Console.WriteLine($"{productos.OrderByDescending(p => p.Precio).FirstOrDefault().ObtenerDetalle()}");
        }
        public static void ProductoConPrecioMasBajo(List<Producto> productos)
        {
            Console.WriteLine("==============================================================");
            Console.WriteLine($"Producto con el precio más bajo:");
            Console.WriteLine($"{productos.OrderByDescending(p => p.Precio).LastOrDefault().ObtenerDetalle()}");
        }
        public static void ProductosConPrecioMayorAlPromedio(List<Producto> productos)
        {
            Console.WriteLine("==============================================================");
            Console.WriteLine($"Productos con precio mayor al promedio:");
            foreach (var producto in productos.Where(p => p.Precio > productos.Average(p => p.Precio)))
            {
                Console.WriteLine($"{producto.ObtenerDetalle()}");
            }
        }
        public static void ProductosOrdenadosPorDescripcion(List<Producto> productos)
        {
            Console.WriteLine("==============================================================");
            Console.WriteLine($"Productos ordenados por descripción de forma descendente:");
            foreach (var producto in productos.OrderByDescending(p => p.Descripcion))
            {
                Console.WriteLine($"{producto.ObtenerDetalle()}");
            }
        }
    }
}
