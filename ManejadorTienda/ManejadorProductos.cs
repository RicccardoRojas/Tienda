using AccesoDatosTienda;
using EntidadesTienda;
using Crud;
using System.Windows.Forms;
using System.Drawing;

namespace ManejadorTienda
{
    public class ManejadorProductos
    {
        AccesoDatosProductos ADP = new AccesoDatosProductos();
        Grafico g = new Grafico();

        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show(
                string.Format(
                    string.Format("¿Estas Seguro de Borrar: {0}?", Entidad.Nombre)),
                "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                ADP.Borrar(Entidad);
            }
        }

        public void Guardar(dynamic Entidad)
        {
            ADP.Guardar(Entidad);
            g.Mensaje("Producto Guardado", "¡Atencion!", MessageBoxIcon.Information);
            return;
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = ADP.Mostrar(filtro).Tables["Producto"];
            tabla.Columns.Insert(4, g.Boton("Editar", Color.Blue));
            tabla.Columns.Insert(5, g.Boton("Borrar", Color.Red));
        }
    }
}
