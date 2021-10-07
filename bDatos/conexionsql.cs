using System;
using System.Data.OracleClient;
using System.Windows.Forms;
namespace bDatos
{
    public class Conexionsql
    {
        OracleConnection varConexion;
        public Conexionsql()
        {
            varConexion = new OracleConnection(@"Data Source = xe ;USER ID=clientesbd; Password=a;");
        }
        public OracleConnection rBD()
        {

            return varConexion;
        }
        public OracleConnection openBD()
        {
            try
            {
                Console.WriteLine("Entro");
                varConexion.Open();
                return varConexion;
            }
            catch (Exception ex)
            {

                return null;
            } 
        }
        public bool closeBD()
        {
            try
            {
                varConexion.Close();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

    }
}
