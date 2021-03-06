using System;
using Capa_Datos;
using Capa_Entidad;
using System.Data;


namespace Capa_Negocio
{
    public class MateriaPrimaNegocio
    {
        MateriasPrimasMetodos objMateriaPrimaMetodo = new MateriasPrimasMetodos();

        public Boolean grabarMatPri(MateriaPrima MatPri)
        {
            Boolean result = objMateriaPrimaMetodo.grabarMatPri(MatPri);
            return result;
        }

        public DataTable ConsultarMateria()
        {
            return objMateriaPrimaMetodo.ConsultarMateria();
        }
        public DataTable ConsultarMatPrimaporProv(String ProvRS)
        {
            return objMateriaPrimaMetodo.ConsultarMatPrimaporProv(ProvRS);
        }

        public DataTable ConsultarMatPrimaporTipo(String Tipo)
        {
            return objMateriaPrimaMetodo.ConsultarMatPrimaporTipo(Tipo);
        }

        public DataTable ConsultarMatPrimaporProvyTipo(String RzSocial, String Tipo)
        {
            return objMateriaPrimaMetodo.ConsultarMatPrimaporProvyTipo(RzSocial,Tipo);
        }
    }
}
