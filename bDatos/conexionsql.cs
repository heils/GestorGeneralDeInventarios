using System;
using System.Data.OracleClient;
namespace bDatos
{
    public abstract class conexionsql
    {
        private  string conexionstringsql = "DATA SOURCE = xe; PASSWORD = a; USER ID = clientesbd;";
        protected conexionsql()
        {

        }

        protected OracleConnection getConexion()
        {
            OracleConnection conOracle = new OracleConnection(conexionstringsql);

            return conOracle;
        }
    }
}
