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
    }
}
