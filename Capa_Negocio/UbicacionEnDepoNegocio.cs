using System;
using Capa_Datos;
using Capa_Entidad;
using System.Data;

namespace Capa_Negocio
{
    public class UbicacionEnDepoNegocio
    {
        UbicacionEnDepoMetodos ObjUbiDepoMet = new UbicacionEnDepoMetodos();

        public DataTable ConsultarUbicacionID(String piso, int estante, int perchero, int nivel)
        {
            return ObjUbiDepoMet.ConsultarUbicacionID(piso,estante, perchero,nivel);
        }
        public DataTable ConsultarUbicacionParaEstantes()
        {
            return ObjUbiDepoMet.ConsultarUbicacionParaEstantes();
        }

        public DataTable ConsultarUbicacionParaPercheros()
        {
            return ObjUbiDepoMet.ConsultarUbicacionParaPercheros();
        }
    }
}
