using System;
using System.Windows.Forms;
using ManejadorTienda;
using EntidadesTienda;

namespace PresentacionTienda
{
    public partial class FrmTienda : Form
    {
        ManejadorProductos MP;
        public static Productos productos = new Productos(0,"","",0.0);
        int col = 0, fila = 0;
        public FrmTienda()
        {
            InitializeComponent();
            MP = new ManejadorProductos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            productos.IDProducto = -1;
            FrmAddProducto FAP = new FrmAddProducto();
            FAP.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void dtgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            productos.IDProducto = int.Parse(dtgProductos.Rows[fila].Cells[0].Value.ToString());
            productos.Nombre = dtgProductos.Rows[fila].Cells[1].Value.ToString();
            productos.Descripcion = dtgProductos.Rows[fila].Cells[2].Value.ToString();
            productos.Precio = double.Parse(dtgProductos.Rows[fila].Cells[3].Value.ToString());
            switch (col)
            {
                case 4: {
                        FrmAddProducto FAP = new FrmAddProducto();
                        FAP.ShowDialog();
                        Actualizar();
                    }; break;

                case 5: {
                        MP.Borrar(productos);
                        Actualizar();
                    } break;
                
                default:
                    break;
            }
        }

        private void dtgProductos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            col = e.ColumnIndex;
        }

        void Actualizar()
        {
            MP.Mostrar(dtgProductos, txtBuscar.Text);
        }
    }
}
