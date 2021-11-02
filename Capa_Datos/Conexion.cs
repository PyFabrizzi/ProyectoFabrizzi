using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Capa_Datos
{
    public class Conexion
    {
        private SqlConnection sCon = new SqlConnection();

       private string con = "Data Source=ERIKA\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=DB_Fabrizzi";
        //private string con = "Data Source=ITATI\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=DB_Fabrizzi";

        /*  SSPI son las siglas de Security Support Provider Interface. ... 
         * Aparte de SSPI, también puede utilizar "true". La seguridad integrada realmente garantiza 
         * que se esté conectando con SQL Server mediante la autenticación de Windows, 
         * no la autenticación de SQL; que requiere que se proporcione nombre de usuario y contraseña con la cadena de conexión
          */


        public SqlConnection conectar()
        {
            try
            {
                sCon = new SqlConnection(con);
                if (sCon.State.Equals(ConnectionState.Open))
                {
                    sCon.Close();
                }
                else
                {
                    sCon.Open();
                }
            }
            catch (Exception ex)
            {
#pragma warning disable CS0103 // El nombre 'MessageBox' no existe en el contexto actual
                MessageBox.Show(ex.Message);
#pragma warning restore CS0103 // El nombre 'MessageBox' no existe en el contexto actual

            }

            return sCon;

        }

        //public Boolean cerrar()
        //{
        //    sCon = new SqlConnection(con);

        //    try
        //    {
        //        if (sCon.State.Equals(ConnectionState.Open))
        //        {
        //            sCon.Close();
        //        }
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        return false;
        //    }
        //}
    }
}
