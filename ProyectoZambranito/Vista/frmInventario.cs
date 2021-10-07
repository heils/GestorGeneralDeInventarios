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
        public frmInventario()
        {
            InitializeComponent();
        }
        
        private void frmInventario_Load(object sender, EventArgs e)
        {
            dgvInventario.DataSource = obJProd.mostrarProductos();
        }

        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
