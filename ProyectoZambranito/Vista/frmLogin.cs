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
    public partial class frmLogin : Form
    {
        private void ComponentesModificados()
        {
            txtUser.Size = new Size(345,30);
            txtPass.Size = new Size(345,30);
            txtUser.AutoSize = false;
            txtPass.AutoSize = false;
            txtPass.UseSystemPasswordChar = true;
        }

        public frmLogin()
        {
            InitializeComponent();
            ComponentesModificados();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void lblBienvenidos_Click(object sender, EventArgs e)
        {

        }
        #region Eventos labels
        private void lblPassF_Click(object sender, EventArgs e)
        {

        }
        private void lblPassF_MouseEnter(object sender, EventArgs e)
        {
            lblPassF.ForeColor= Color.Red;
        }

        #endregion

        private void lblPassF_MouseLeave(object sender, EventArgs e)
        {
            lblPassF.ForeColor = Color.Black;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            accUser loginUser = new accUser();
            if (loginUser.Login(txtUser.Text, txtPass.Text) == true)
            {
                frmMenuPrincipal MainMenu = new frmMenuPrincipal();
                MainMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("USUARIO/CONTRASEÑA INCORRECTO");
                txtPass.Clear();
                txtPass.Focus();
            }
        }
    }
}
