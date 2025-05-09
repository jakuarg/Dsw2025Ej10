namespace Dsw2025Ej10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creo una lista de productos para manejarla desde el main
            List<Producto> productos = Producto.CrearListaDeEjemplo();
            //#1
            Solucion.PrimerProducto(productos);
            //#2
            Solucion.UltimoProducto(productos);
            //#3
            Solucion.SumaDePrecios(productos);
            //#4
            Solucion.PromedioDePrecios(productos);
            //#5
            Solucion.ProductosConIdMayorA15(productos);
            //#6
            Solucion.ListarProductos(productos);
            //#7
            Solucion.ProductoConPrecioMasAlto(productos);
            //#8
            Solucion.ProductoConPrecioMasBajo(productos);
            //#9
            Solucion.ProductosConPrecioMayorAlPromedio(productos);
            //#10
            Solucion.ProductosOrdenadosPorDescripcion(productos);
        }
    }
}
