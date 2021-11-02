using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Datos;
using Capa_Entidad;
using System.Data.SqlClient;

namespace Capa_Negocio
{
    public class ProductoNegocio
    {
        ProductosMetodos objProdMetodos = new ProductosMetodos();
        public Boolean NuevoProducto(Producto producto)
        {
            Boolean result = objProdMetodos.NuevoProducto(producto);
            return result;
        }

        //public DataTable ConsultarProducto()
        //{
        //  //  return objProdMetodos.ConsultarProducto();
        //}

        public DataTable ConsultarProductoTipo(Producto prod_Tipo)
        {
            return objProdMetodos.ConsultarProductoTipo(prod_Tipo);
        }

        public DataTable ConsultarColor()
        {
            return objProdMetodos.ConsultarColor();
        }



    }
}
