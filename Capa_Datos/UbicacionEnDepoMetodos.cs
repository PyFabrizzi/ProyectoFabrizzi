using System;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class UbicacionEnDepoMetodos : Conexion
    {
        public DataTable ConsultarUbicacionID(String piso, int estante, int perchero, int nivel)
        {
            var sqlStr = "select Ued_id 'ID' from UbicacionEnDepo where Ued_Piso = '"+piso+"' and Ued_Estante = "+ estante +" and Ued_Perchero =" + perchero+" and Ued_Nivel = "+nivel+";";
            var da = new SqlDataAdapter(sqlStr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            return dt;
        }
        public DataTable ConsultarUbicacionParaEstantes()
        {
            var sqlStr = "select Ued_id 'ID',Ued_Piso 'Piso', Ued_Estante 'Estante',  Ued_Nivel 'Nivel' from UbicacionEnDepo where Ued_Perchero = 0;";
            var da = new SqlDataAdapter(sqlStr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            return dt;
        }

        public DataTable ConsultarUbicacionParaPercheros()
        {
            var sqlStr = "Select Ued_id 'ID', Ued_Piso 'Piso' , Ued_Perchero 'Perchero' from UbicacionEnDepo where Ued_Estante = 0;";
            var da = new SqlDataAdapter(sqlStr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            return dt;
        }
    }
}
