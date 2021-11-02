
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_Entidad;


namespace Capa_Datos
{
    public class ProductosMetodos : Conexion
    {
        public Boolean NuevoProducto(Producto producto)
        {

            
            
            try
            {
                var sel = "set dateformat dmy insert into Productos(prod_CodDeProd, prod_Descripción, prod_Talle,prod_Tipo, prod_SubTipo, prod_Color, prod_StockMin, prod_StockMax, prod_Estado, prod_Temporada, prod_Fecha, prod_Anio, prod_UbiEnDepo)" +
                   " values('" + producto.prod_CodDeProd + "', '" + producto.prod_Descripción + "','" + producto.prod_Talle + "','" + producto.prod_Tipo + "','"+ producto.prod_subTipo+"','" + producto.prod_Color + "'," + producto.prod_StockMin + "," + producto.prod_StockMax + ",'" + producto.prod_Estado + "','" + producto.prod_Temporada + "','" + producto.prod_Fecha + "','" + producto.prod_Anio + "'," + producto.prod_UbiEnDepo + ");";
                SqlCommand com = new SqlCommand(sel, conectar());

                com.ExecuteNonQuery();

                return true;
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {
                return false;
            }
        }

        public DataTable ConsultarProductoTipo(Producto prod_Tipo)
        {
            throw new NotImplementedException();
        }

        public DataTable ConsultarProdXTipo(Producto prod_Tipo)
        {
            var sqlStr = "select prod_CodDeProd as Codigo,prod_Tipo as tipo,prod_subtipo as Subtipo from Productos where prod_Tipo ='" + prod_Tipo + "';";
            var da = new SqlDataAdapter(sqlStr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            return dt;
        }

        public DataTable ConsultarColor()
        {
            var sqlStr = "select Col_Id 'ID', Col_Nombre 'Nombre' from Color";
            var da = new SqlDataAdapter(sqlStr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            return dt;
        }

    }
}

