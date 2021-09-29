using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.Windows.Forms;

namespace bDatos
{
    public class accUser : conexionsql
    {
        public int Login( string prmUser, string prmPass)
        {
            
             OracleConnection conxSQL = getConexion();
            try
            {
                conxSQL.Open();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


            OracleCommand orCommand = new OracleCommand();
            orCommand.Connection = conxSQL;
            orCommand.Parameters.AddWithValue(":prmUser", prmUser);
            orCommand.Parameters.AddWithValue(":prmPass", prmPass);
            orCommand.CommandText = "SELECT * FROM USUARIO WHERE NICK = :prmUser AND CONTRASENIA = :prmPass AND ROL = 'admin'";
            OracleDataReader varReader = orCommand.ExecuteReader();

            if (varReader.HasRows)

            {
                return 1;
            }
            else
            {
                orCommand.CommandText = "SELECT * FROM USUARIO WHERE NICK = :prmUser AND CONTRASENIA = :prmPass AND ROL = 'user'";
                varReader = orCommand.ExecuteReader();

                if (varReader.HasRows)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }


        }
    }
}
