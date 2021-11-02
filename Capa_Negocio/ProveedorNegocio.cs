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
    public class ProveedorNegocio
    {
        ProveedoresMetodos objProveedorMetodo = new ProveedoresMetodos();

        public Boolean grabarProveedor(Proveedor prov)
        {
            Boolean result = objProveedorMetodo.grabarProveedor(prov);
            return result;
        }

        public DataTable ConsultarProv(String Cuit)
        {
            return objProveedorMetodo.ConsultarProv(Cuit);
        }

        public DataTable ConsultarProv()
        {
            return objProveedorMetodo.ConsultarProv();
        }

        public DataTable ConsultarProv2(String CUIT)
        {
            return objProveedorMetodo.ConsultarProv2(CUIT);
        }

        public DataTable ConsultarProv2(String CUIT, String RazoSocial)
        {
            return objProveedorMetodo.ConsultarProv2(CUIT, RazoSocial);
        }

        public DataTable ConsultarProv3(String RazoSocial)
        {
            return objProveedorMetodo.ConsultarProv3(RazoSocial);
        }

        public DataTable ConsultarIdDirProv(String CUIT)
        {
            return objProveedorMetodo.ConsultarIdDirProv(CUIT);
        }

        public DataTable ConsultarRZProv()
        {
            return objProveedorMetodo.ConsultarRZProv();
        }

        public Boolean ModificarTelProv(String CUIT, String Tel)
        {
            Boolean result = objProveedorMetodo.ModificarTelProv(CUIT, Tel);
            return result;
        }

        public Boolean ModificarMailProv(String CUIT, String Mail)
        {
            Boolean result = objProveedorMetodo.ModificarMailProv(CUIT, Mail);
            return result;
        }

        public Boolean darDeBajaProveedor(String CUIT)
        {
            Boolean result = objProveedorMetodo.darDeBajaProveedor(CUIT);
            return result;
        }


    }
}
