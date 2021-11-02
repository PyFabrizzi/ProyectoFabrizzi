using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Venta
    {
        public int vta_IdDeVenta { get; set; }
        public decimal vta_Monto { get; set; }
        public string vta_TipoVenta { get; set; } //local-online
        public DateTime vta_Fecha { get; set; }
        public String vta_Estado { get; set; } // --Finalizada o Anulada
        public int vta_CantTotalProd { get; set; }
        public decimal vta_MontoTotal { get; set; }
        public int vta_IdLoc { get; set; }
        public int vta_TiposDePago { get; set; }
        public int vta_Promociones { get; set; }
        public int vta_LegajoVendedor { get; set; }
    }
}
