using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Capa_Datos
{
    public class Conexion
    {
        private SqlConnection sCon = new SqlConnection();

       //private string con = "Data Source=ERIKA\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=DB_Fabrizzi";
        private string con = "Data Source=ITATI\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=DB_Fabrizzi";

        


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

    }
}
