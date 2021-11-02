using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidad;
using System.Data;

namespace Capa_Negocio
{
    public class LocalNegocio
    {
        LocalesMetodos objLocalMetodos = new LocalesMetodos();

        public Boolean grabarLocal(Local loc)
        {
            Boolean result = objLocalMetodos.grabarLocal(loc);
            return result;
        }

        public DataTable ConsultarLocales()
        {
            return objLocalMetodos.ConsultarLocales();
        }

        public DataTable ConsultarLocalId(int IdLoc)
        {
            return objLocalMetodos.ConsultarLocalId(IdLoc);
        }

        public DataTable ConsultarPorNombre(String NombreLocal)
        {
            return objLocalMetodos.ConsultarPorNombre(NombreLocal);
        }

        public Boolean darDeBajaLocal(int IdLocal)
        {
            Boolean result = objLocalMetodos.darDeBajaLocal(IdLocal);
            return result;
        }
    }
}
