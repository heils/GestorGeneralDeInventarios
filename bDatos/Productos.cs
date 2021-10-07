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
            varCommand.Connection = varConexion.openBD();
            varCommand.CommandText = "mostraProductos";
            varCommand.CommandType = CommandType.StoredProcedure;
            varCommand.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;
            varReader = varCommand.ExecuteReader();
            varTabla.Load(varReader);
            varConexion.closeBD();
            return varTabla;
        }
    }
}
