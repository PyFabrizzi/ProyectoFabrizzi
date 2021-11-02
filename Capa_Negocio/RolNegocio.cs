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
    public class RolNegocio
    {
        RolesMetodos objRolMetodo = new RolesMetodos();

        public Boolean grabarUsuario(Rol rolNew)
        {
            Boolean result = objRolMetodo.grabarUsuario(rolNew);
            return result;
        }

        public DataTable ConsultarId(string legajo)
        {
            return objRolMetodo.ConsultarId(legajo);
        }

        public DataTable Consultar()
        {
            return objRolMetodo.Consultar();
        }

        public DataTable Consultar(String nombreDeRol, String Descripcion)
        {
            return objRolMetodo.Consultar(nombreDeRol, Descripcion);
        }

        public DataTable Consultar2(String nombreDeRol, String Descripcion)
        {
            return objRolMetodo.Consultar2(nombreDeRol, Descripcion);
        }

        public DataTable Consultar3(String nombreDeRol)
        {
            return objRolMetodo.Consultar3(nombreDeRol);
        }

        public DataTable ConsultarPorRol(String Rol)
        {
            return objRolMetodo.ConsultarPorRol(Rol);
        }

        public DataTable ConsultarRoles2()
        {
            return objRolMetodo.ConsultarRoles2();
        }

        public DataTable ConsultarPorEstado(String Estado)
        {
            return objRolMetodo.ConsultarPorEstado(Estado);
        }

        public DataTable ConsultarPorRolEstado(String Rol, String Estado)
        {
            return objRolMetodo.ConsultarPorRolEstado(Rol,Estado);
        }

        public Boolean darDeBajaRol(int IdRol)
        {
            Boolean result = objRolMetodo.darDeBajaRol(IdRol);
            return result;
        }

        public Boolean ModificarRol(String descRol, int IdRol)
        {
            Boolean result = objRolMetodo.ModificarRol(descRol,IdRol);
            return result;
        }

    }
}

