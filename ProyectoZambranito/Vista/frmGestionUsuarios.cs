using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoZambranito.Vista
{
    public partial class btnRegresar : Form
    {
        OracleConnection ora;
        public btnRegresar()
        {
            ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD=a ; USER ID = clientesbd");
            InitializeComponent();
        }

        private void frmGestionUsuarios_Load(object sender, EventArgs e)
        {

        }
        public void EliminarUsuario()
        {

            try
            {

                ora.Open();
                OracleCommand comando = new OracleCommand("proc4", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("prm_id", OracleType.Number).Value = this.txtIdUsuarioEliminar.Text;
                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = comando;
                comando.ExecuteReader();
                ora.Close();
                
                MessageBox.Show("El usuario se elimino con exito");
                txtIdUsuarioEliminar.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL CONECTAR, ES POSIBLE QUE EL ID NO EXISTA");
            }

        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            EliminarUsuario();
        }
        public void crearUsuario()
        {
            if (string.IsNullOrEmpty(txtNick.Text)|| string.IsNullOrEmpty(txtContrasenia.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(cbxRol.Text))
            {

                MessageBox.Show("ningun campo puede estar vacio");

                return;

            }
            else
            {
                try
                {

                    ora.Open();
                    OracleCommand comando = new OracleCommand("proc6", ora);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.Add("prm_nick", OracleType.VarChar).Value = this.txtNick.Text;
                    comando.Parameters.Add("prm_nombre", OracleType.VarChar).Value = this.txtNombre.Text;
                    comando.Parameters.Add("prm_contrasenia", OracleType.VarChar).Value = this.txtContrasenia.Text;
                    comando.Parameters.Add("prm_rol", OracleType.VarChar).Value = this.cbxRol.SelectedItem.ToString();
                    OracleDataAdapter adaptador = new OracleDataAdapter();
                    adaptador.SelectCommand = comando;
                    comando.ExecuteReader();
                    ora.Close();
                    
                    MessageBox.Show("El usuario se creo con exito");
                    txtNick.Clear();
                    txtNombre.Clear();
                    txtContrasenia.Clear();
                    cbxRol.Text = null;
                            
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR AL CONECTAR");
                }
            }

           

        }

        private void btmCrearUsuario_Click(object sender, EventArgs e)
        {
            crearUsuario();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            regresar();
            
        }
        public void regresar()
        {
            Vista.frmUsuarios frmUsuarios = new Vista.frmUsuarios();
            frmUsuarios.Show();
            this.Close();

        }
    }
   
}
