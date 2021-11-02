using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Producto
    {
        public String prod_CodDeProd { get; set; }
        public String prod_Descripción { get; set; }
        public String prod_Talle { get; set; }
        public String prod_Tipo { get; set; }
        public String prod_subTipo { get; set; }
        public int prod_UbiEnDepo { get; set; }
        public int prod_Cantidad { get; set; }
        public int prod_StockMin { get; set; }
        public int prod_StockMax { get; set; }
        public String prod_Estado { get; set; }
        public String prod_Temporada { get; set; }
        public DateTime prod_Fecha { get; set; }
        public String prod_Anio { get; set; }
        public String prod_Color{get; set;}
}
}
