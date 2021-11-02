using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using Capa_Datos;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Negocio
{
   public class VentaNegocio
    {
        VentasMetodos ventita = new VentasMetodos();

       public DataTable VentaConsultarStock(Usuario usu_idLocal)
        {
        
            return ventita.VentaConsultarStock(usu_idLocal);
        }

        public DataTable consultaLocalUsuario(Usuario usu_Legajo)
        {
            return ventita.consultaLocalUsuario(usu_Legajo);
        }

        public DataTable ConsultaLocal()
        {
            return ventita.ConsultaLocal();
        }
    }
}
