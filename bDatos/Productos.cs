using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.Data;

namespace bDatos
{
    public class Productos
    {
        private Conexionsql varConexion = new Conexionsql();
        OracleDataReader varReader;
        DataTable varTabla = new DataTable();
        OracleCommand varCommand = new OracleCommand();

        public DataTable mostrarProductos()
        {
            //Mostrar
            varCommand.Connection = varConexion.openBD();
            varCommand.CommandText = "mostraProductos";
            varCommand.CommandType = CommandType.StoredProcedure;
            varCommand.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;
            varReader = varCommand.ExecuteReader();
            varTabla.Load(varReader);
            varConexion.closeBD();
            return varTabla;
        }
        public void insertarProductos(int prmId, string prmNombre, double prmPeso, DateTime prmFDV, double prmPrecio, int prmStock)
        {
            varCommand.Connection = varConexion.openBD();
            varCommand.CommandText = "insertarProductos";
            varCommand.CommandType = CommandType.StoredProcedure;
            varCommand.Parameters.Add("prmID", OracleType.Number).Value =prmId;
            varCommand.Parameters.Add("prmNombre", OracleType.VarChar).Value = prmNombre;
            varCommand.Parameters.Add("prmPeso", OracleType.Number).Value = prmPeso;
            varCommand.Parameters.Add("prmFDV", OracleType.DateTime).Value = prmFDV;
            varCommand.Parameters.Add("prmPrecio", OracleType.Number).Value = prmPrecio;
            varCommand.Parameters.Add("prmStock", OracleType.Number).Value = prmStock;
            varCommand.ExecuteNonQuery();

        }
        public void ModificarProductos(int prmId, string prmNombre, double prmPeso, double prmPrecio, int prmStock)
        {
            varCommand.Connection = varConexion.openBD();
            varCommand.CommandText = "modificarProductos";
            varCommand.CommandType = CommandType.StoredProcedure;
            varCommand.Parameters.Add("prmID", OracleType.Number).Value = prmId;
            varCommand.Parameters.Add("prmNombre", OracleType.VarChar).Value = prmNombre;
            varCommand.Parameters.Add("prmPeso", OracleType.Number).Value = prmPeso;
            varCommand.Parameters.Add("prmPrecio", OracleType.Number).Value = prmPrecio;
            varCommand.Parameters.Add("prmStock", OracleType.Number).Value = prmStock;
            varCommand.ExecuteNonQuery();

        }
    }
}
