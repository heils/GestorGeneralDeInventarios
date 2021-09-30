using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoZambranito.Vista
{
    public partial class frmMenuUser : Form
    {
        public frmMenuUser()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Clientes();
        }
        public void Clientes()
        {
            Vista.frmClientes mostrarClientes = new Vista.frmClientes();
            mostrarClientes.Show();
           
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            cerrarSesion();
        }
        public void cerrarSesion()
        {
            Vista.frmLogin Login = new Vista.frmLogin();
            Login.Show();
            this.Hide();
        }
    }
}
