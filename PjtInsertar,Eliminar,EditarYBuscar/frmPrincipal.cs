using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PjtInsertar_Eliminar_EditarYBuscar
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Origen();
        }
        Articulos A=new Articulos();

       public void Origen()
        {
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = clsDatabase.Mostrar();

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            A.Nombre1 = txtNombre.Text;
            A.Precio1 = txtPrecio.Text;
            clsDatabase.Insertar(A);

            Origen();
        }

        private void dgvArticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            A.IdArticulo =int.Parse(txtCodigo.Text= dgvArticulos.CurrentRow.Cells[0].Value.ToString());
            txtNombre.Text = dgvArticulos.CurrentRow.Cells[1].Value.ToString();
            txtPrecio.Text = dgvArticulos.CurrentRow.Cells[2].Value.ToString();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            A.IdArticulo =int.Parse( txtCodigo.Text);
            clsDatabase.Eliminar(A);
            Origen();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            A.IdArticulo = int.Parse(txtCodigo.Text);
            A.Nombre1 = txtNombre.Text;
            A.Precio1 = txtPrecio.Text;
            clsDatabase.Modificar(A);
            Origen();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                A.Nombre1 = txtBuscar.Text;
                dgvArticulos.DataSource = clsDatabase.Buscar(A);
            }
            else
                Origen();

        }
    }
}
