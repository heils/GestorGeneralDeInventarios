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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            clientes();
        }
        public void clientes()
        {
            Vista.frmClientes frmClientes = new Vista.frmClientes();
            frmClientes.Show();

        }

        private void label11_Click(object sender, EventArgs e)
        {
            Vista.frmLogin frmLogin = new Vista.frmLogin();
            this.Hide();
            frmLogin.Show();
        }
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios();
        }
        public void Usuarios()
        {
            Vista.frmUsuarios frmUsuarios = new Vista.frmUsuarios();
            frmUsuarios.Show();
            this.Close();
            
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

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            proveedores();
        }
        public void proveedores()
        {
            Vista.frmProveedores frmProveedores = new Vista.frmProveedores();
            frmProveedores.Show();
        }
    }
}
