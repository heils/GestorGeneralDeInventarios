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
        public Boolean Login( string prmUser, string prmPass)
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
            orCommand.CommandText = "SELECT * FROM USUARIO WHERE NICK = :prmUser AND CONTRASENIA = :prmPass ";
            Console.WriteLine(prmUser);
            Console.WriteLine(prmPass);
            orCommand.Parameters.AddWithValue(":prmUser", prmUser);
            orCommand.Parameters.AddWithValue(":prmPass", prmPass);
            OracleDataReader varReader = orCommand.ExecuteReader();
            varReader.GetValue(0);


            if (varReader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}
