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
    public class LoginNegocio
    {
        LoginMetodo objLoginMetodo = new LoginMetodo();

        public DataTable ConsultarLogin(string usu, string pas)
        {
            return objLoginMetodo.ConsultarLogin(usu , pas);
        }

        public int ultimoId()
        {
            int ultimoId = objLoginMetodo.ultimoId();

            return ultimoId;
         }

        public DataTable consultaNombre(string usu)
        {
            return objLoginMetodo.consultaNombre(usu);
        }

        public Boolean CambiarPass(int legajo, string pass)
        {
            Boolean result = objLoginMetodo.CambiarPass(legajo, pass);
            return result;
        }

        public DataTable consultaExisteLegajo(int legajo)
        {
            return objLoginMetodo.consultaExisteLegajo(legajo);
        }

        public DataTable consultaPassAnterior(int legajo)
        {
            return objLoginMetodo.consultaPassAnterior(legajo);
        }
    }

    
}
