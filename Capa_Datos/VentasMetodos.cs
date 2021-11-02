using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using System.Data;
using System.Data.SqlClient;


namespace Capa_Datos
{
    public class VentasMetodos : Conexion
    {

        public DataTable VentaConsultarStock(Usuario usu_idLocal)
        {

            var sqlStr = "select sl.SL_CodDeProd, p.prod_Tipo ,p.prod_Subtipo,p.prod_Color,sl.SL_Cantidad from StockLocal sl left join Productos p on p.prod_CodDeProd = sl.SL_CodDeProd where sl.SL_Cantidad != 0 and sl.SL_IdLoc='" + usu_idLocal + "'";
            var da = new SqlDataAdapter(sqlStr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            return dt;
        }

        public DataTable consultaLocalUsuario(Usuario usu_Legajo)
        {
            //
            var sqlStr = "select usu_idLocal from Usuarios where usu_Legajo = '" + usu_Legajo + "'";
            var da = new SqlDataAdapter(sqlStr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            return dt;
        }
    }
}
