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
    public partial class frmClientes : Form
    {
        OracleConnection ora;


        public frmClientes()
        {
            ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD=a ; USER ID = clientesbd");
            InitializeComponent();
            cargarClientes();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {

            buscarCliente();
        }

        public void buscarCliente()
        {

            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("proc1", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("prm_id", OracleType.Number).Value = this.txtNombreCliente.Text;
                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                this.dtgClientes.DataSource = tabla;
                ora.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL CONECTAR");
            }

        }

        public void cargarClientes()
        {

            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("proc2", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;
                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                this.dtgClientes.DataSource = tabla;
                ora.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL CONECTAR");
            }

        }
    }
}
