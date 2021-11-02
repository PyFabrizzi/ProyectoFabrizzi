using System;
using Capa_Datos;
using Capa_Entidad;
using System.Data;

namespace Capa_Negocio
{
    public class UsuarioNegocio
    {
        UsuariosMetodos objUsuarioMetodo = new Capa_Datos.UsuariosMetodos();

        public DataTable Consultar()
        {
            return objUsuarioMetodo.Consultar();
        }

        public Boolean grabarUsuario(Usuario usu)
        {
            Boolean result = objUsuarioMetodo.grabarUsuario(usu);
            return result;
        }

        public DataTable ConsultarDni(String DNI)
        {
            return objUsuarioMetodo.ConsultarDni(DNI);
        }

        public DataTable ConsultarPorRol(String Rol)
        {
            return objUsuarioMetodo.ConsultarPorRol(Rol);
        }

        public DataTable ConsultarPorArea(String Area)
        {
            return objUsuarioMetodo.ConsultarPorArea(Area);
        }
        public DataTable ConsultarPorAreaRol(String Area, String Rol)
        {
            return objUsuarioMetodo.ConsultarPorAreaRol(Area, Rol);
        }
        public Boolean ModificarRol(int Rol, int Legajo)
        {
            Boolean result = objUsuarioMetodo.ModificarRol(Rol, Legajo);
            return result;
        }

        public Boolean ModificarArea(String Area, int Legajo)
        {
            Boolean result = objUsuarioMetodo.ModificarArea(Area, Legajo);
            return result;
        }

        public Boolean ModificarAreaRol(int Rol, int Legajo, String Area)
        {
            Boolean result = objUsuarioMetodo.ModificarAreaRol(Rol, Legajo,Area);
            return result;
        }

        public DataTable ConsultarLegajo2(int Legajo)
        {
            return objUsuarioMetodo.ConsultarLegajo2(Legajo);
        }

        public DataTable ConsultarLegajo(int Legajo)
        {
            return objUsuarioMetodo.ConsultarLegajo(Legajo);
        }

        public Boolean darDeBajaUsuario(int legajo)
        {
            Boolean result = objUsuarioMetodo.darDeBajaUsuario(legajo);
            return result;
        }
    }
}
