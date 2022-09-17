using EntidadesTienda;
using ConectarBD;
using System.Data;

namespace AccesoDatosTienda
{
    public class AccesoDatosProductos
    {
        Base b = new Base("localhost", "root", "", "tiendagit");

        public void Borrar(dynamic Entidad)
        {
            b.Comando(string.Format("call eliminarproducto({0})", Entidad.IDProductos));
        }

        public void Guardar(dynamic Entidad)
        {
            b.Comando(string.Format("call insertarproducto('{0}','{1}',{2})", Entidad.Nombre, Entidad.Descripcion, Entidad.Precio));
        }

        public DataSet Mostrar(string Filtro)
        {
            return b.Obtener(string.Format("call showproducto('%{0}%')", Filtro), "Producto");
        }
    }
}
