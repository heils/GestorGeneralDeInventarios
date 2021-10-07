using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bDatos;

namespace ProyectoZambranito.Vista
{
    public partial class frmInventario : Form
    {
        Productos obJProd = new Productos();
        private string varidprod = null;
        private bool varModificar = false;
        public frmInventario()
        {
            InitializeComponent();
        }
        
        private void frmInventario_Load(object sender, EventArgs e)
        {
            mostrarP();
        }
        private void mostrarP()
        {
            Productos nObJ = new Productos();
            dgvInventario.DataSource = nObJ.mostrarProductos();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (varModificar == false)
            {
                obJProd.insertarProductos(Convert.ToInt32(txtID.Text), txtNombre.Text, Convert.ToDouble(txtPeso.Text), Convert.ToDateTime(dtpFDV.Value), Convert.ToDouble(txtPrecio.Text), Convert.ToInt32(txtStock.Text));
                MessageBox.Show("Producto Registrado con exito.");
                mostrarP();
            }
            if (varModificar == true)
            {
                obJProd.ModificarProductos(Convert.ToInt32(varidprod), txtNombre.Text, Convert.ToDouble(txtPeso.Text), Convert.ToDouble(txtPrecio.Text), Convert.ToInt32(txtStock.Text));
                mostrarP();
                varModificar = false;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvInventario.SelectedRows.Count > 0)
            {
                txtID.Hide();
                lblID.Hide();
                dtpFDV.Hide();
                lblFDV.Hide();
                varModificar = true;
                txtNombre.Text = dgvInventario.CurrentRow.Cells[1].Value.ToString();
                txtPeso.Text = dgvInventario.CurrentRow.Cells[2].Value.ToString();
                txtPrecio.Text = dgvInventario.CurrentRow.Cells[4].Value.ToString();
                txtStock.Text = dgvInventario.CurrentRow.Cells[5].Value.ToString();
                varidprod = dgvInventario.CurrentRow.Cells[0].Value.ToString();
            }
            else
            {
                MessageBox.Show("No ha seleccionado ninguna fila.");
            }
        }
    }
}
