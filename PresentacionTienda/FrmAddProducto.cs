using System;
using System.Windows.Forms;
using ManejadorTienda;
using EntidadesTienda;

namespace PresentacionTienda
{
    public partial class FrmAddProducto : Form
    {
        ManejadorProductos MP;
        public FrmAddProducto()
        {
            InitializeComponent();
            MP = new ManejadorProductos();
            if (FrmTienda.productos.IDProducto>0)
            {
                txtNombre.Text = FrmTienda.productos.Nombre;
                txtDescripcion.Text = FrmTienda.productos.Descripcion;
                txtPrecio.Text = FrmTienda.productos.Precio.ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MP.Guardar(new Productos(FrmTienda.productos.IDProducto,txtNombre.Text,txtDescripcion.Text,double.Parse(txtPrecio.Text)));
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
