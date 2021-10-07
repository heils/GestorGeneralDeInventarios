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
    public partial class frmProveedores : Form
    {
        OracleConnection ora;
        public frmProveedores()
        {
            ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD=a ; USER ID = clientesbd");
            InitializeComponent();
            cargarProveedores();
        }
        public void cargarProveedores()
        {

            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("mostrarProveedores", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;
                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = comando;

                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                this.dtgProveedores.DataSource = tabla;
                ora.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL CONECTAR");
            }

        }

        private void btnCarga_Click(object sender, EventArgs e)
        {
            cargarProveedores();
        }
        public void buscarProveedor()
        {

            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("buscarProveedor", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("prm_id", OracleType.Number).Value = this.txtIdProveedor.Text;
                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = comando;
                comando.ExecuteReader();
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                this.dtgProveedores.DataSource = tabla;
                ora.Close();
                txtIdProveedor.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL CONECTAR");
            }

        }
        public void EliminarProveedor()
        {

            try
            {

                ora.Open();
                OracleCommand comando = new OracleCommand("eliminarProveedor", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("prm_id", OracleType.Number).Value = this.txtIdProveedorEliminar.Text;
                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = comando;
                comando.ExecuteReader();
                ora.Close();

                MessageBox.Show("El proveedor se elimino con exito");
                txtIdProveedorEliminar.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL CONECTAR, ES POSIBLE QUE EL ID NO EXISTA");
            }

        }
        public void agregarProveedor()
        {
            if (string.IsNullOrEmpty(txtNombreProveedor.Text) || string.IsNullOrEmpty(txtDireccionProveedor.Text) || string.IsNullOrEmpty(txtTelefonoProveedor.Text) || string.IsNullOrEmpty(txtCorreoProveedor.Text) || string.IsNullOrEmpty(txtCedulaProveedor.Text))
            {

                MessageBox.Show("ningun campo puede estar vacio");

                return;

            }
            else
            {
                try
                {

                    ora.Open();
                    Console.WriteLine("1");
                    OracleCommand comando = new OracleCommand("agregarProveedor", ora);
                    Console.WriteLine("2");
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    Console.WriteLine("3");
                    comando.Parameters.Add("prm_nombre", OracleType.VarChar).Value = this.txtNombreProveedor.Text;
                    Console.WriteLine("4");
                    comando.Parameters.Add("prm_direccion", OracleType.VarChar).Value = this.txtDireccionProveedor.Text;
                    Console.WriteLine("5");
                    comando.Parameters.Add("prm_telefono", OracleType.Number).Value = this.txtTelefonoProveedor.Text;
                    Console.WriteLine("6");
                    comando.Parameters.Add("prm_correo", OracleType.VarChar).Value = this.txtCorreoProveedor.Text;
                    Console.WriteLine("7");
                    comando.Parameters.Add("prm_cedula", OracleType.Number).Value = this.txtCedulaProveedor.Text;
                    Console.WriteLine("8");
                    OracleDataAdapter adaptador = new OracleDataAdapter();
                    Console.WriteLine("9");
                    adaptador.SelectCommand = comando;
                    comando.ExecuteReader();
                    Console.WriteLine("10");
                    ora.Close();

                    MessageBox.Show("El proveedor se agrego con exito");
                    txtNombreProveedor.Clear();
                    txtDireccionProveedor.Clear();
                    txtTelefonoProveedor.Clear();
                    txtCorreoProveedor.Clear();
                    txtCedulaProveedor.Clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR AL CONECTAR");
                }
            }



        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            buscarProveedor();
        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            EliminarProveedor();
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            agregarProveedor();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {

        }
    }
}
