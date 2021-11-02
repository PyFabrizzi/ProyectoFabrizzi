using System;
using Capa_Datos;
using Capa_Entidad;
using System.Data;

namespace Capa_Negocio
{
    public class DireccionNegocio
    {
        DireccionesMetodos objDireccionesMetodos = new DireccionesMetodos();

        public Boolean grabarDireccion(Direccion dir)
        {
            Boolean result = objDireccionesMetodos.grabarDireccion(dir);
            return result;
        }

        public DataTable ConsultarIdDirProv()
        {
            return objDireccionesMetodos.ConsultarIdDirProv();
        }

        public DataTable ConsultarDirProv()
        {
            return objDireccionesMetodos.ConsultarDirProv();
        }

        public DataTable ConsultarDirLocal()
        {
            return objDireccionesMetodos.ConsultarDirLocal();
        }

        public DataTable ConsultarLocal()
        {
            return objDireccionesMetodos.ConsultarLocal();
        }

        public DataTable ConsultarProv()
        {
            return objDireccionesMetodos.ConsultarProv();
        }

        public DataTable ConsultarIdDirLoc()
        {
            return objDireccionesMetodos.ConsultarIdDirLoc();
        }
        public DataTable ConsultarDireccion(String idDir)
        {
            return objDireccionesMetodos.ConsultarDireccion(idDir);
        }

        public Boolean BorrarDireccion(String dir)
        {
            Boolean result = objDireccionesMetodos.BorrarDireccion(dir);
            return result;
        }

        public Boolean ModificarDireccion(Direccion dir)
        {
            Boolean result = objDireccionesMetodos.ModificarDireccion(dir);
            return result;
        }
    }
}
