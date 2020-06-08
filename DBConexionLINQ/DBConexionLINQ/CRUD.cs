using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBConexionLINQ
{
    public partial class CRUD : Form
    {
        private ConexionDBDataContext ConexionDB = new ConexionDBDataContext();

        public CRUD()
        {
            InitializeComponent();
        }

        private void CRUD_Load(object sender, EventArgs e)
        {
            dgvProductos.DataSource = ConexionDB.LeerProducto();

        }
        private void LimpiarEntrada()
        {
            tbProducto.Text = "";
            tbPrecio.Text = "";
            tbCantidad.Text = "";
        }
        private void RecargarProductos()
        {
            dgvProductos.DataSource = ConexionDB.LeerProducto();
        }

        private void dgvProductos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvProductos.CurrentRow.Cells[1].Value != null)
            {
                tbProducto.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
                tbPrecio.Text = dgvProductos.CurrentRow.Cells[5].Value.ToString();
                tbCantidad.Text = dgvProductos.CurrentRow.Cells[6].Value.ToString();
                

            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            ConexionDB.InsertarProducto(tbProducto.Text, Convert.ToDecimal(tbPrecio.Text), Convert.ToInt16(tbCantidad.Text));
            RecargarProductos();
            MessageBox.Show("Producto Insertado");
            LimpiarEntrada();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idProducto = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value);
            ConexionDB.EliminarProducto(idProducto);
            RecargarProductos();
            MessageBox.Show("Producto Eliminado");
            LimpiarEntrada();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int idProducto = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value);
            ConexionDB.ActualizarProducto( tbProducto.Text, Convert.ToDecimal(tbPrecio.Text),Convert.ToInt16(tbCantidad), idProducto);
            RecargarProductos();
            MessageBox.Show("Producto Actualizado");
            LimpiarEntrada();
        }

        private void bntLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarEntrada();
        }
    }
}
