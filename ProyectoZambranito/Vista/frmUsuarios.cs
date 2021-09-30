using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoZambranito.Vista
{
    public partial class frmUsuarios : Form
    {
        OracleConnection ora;
        public frmUsuarios()
        {
            ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD=a ; USER ID = clientesbd");
            InitializeComponent();
            cargarUsuarios();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {

        }
        public void cargarUsuarios()
        {

            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("proc3", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;
                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                this.dtgUsuarios.DataSource = tabla;
                ora.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL CONECTAR");
            }

        }

        private void btbGestionarUsuarios_Click(object sender, EventArgs e)
        {
            gestionarUsuarios();
        }   
        public void gestionarUsuarios()
        {
            Vista.btnRegresar frmGestion = new Vista.btnRegresar();
            frmGestion.Show();
            this.Close();

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            volver();
        }
        public void volver()
        {
            Vista.frmMenuPrincipal frmMenuPrincipal = new Vista.frmMenuPrincipal();
            frmMenuPrincipal.Show();
            this.Hide();
        }
    }
}
