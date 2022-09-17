namespace EntidadesTienda
{
    public class Productos
    {
        public Productos(int iDProducto, string nombre, string descripcion, double precio)
        {
            IDProducto = iDProducto;
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
        }

        public int IDProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
    }
}
