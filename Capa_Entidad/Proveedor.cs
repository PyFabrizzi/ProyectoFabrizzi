﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Proveedor
    {
        public String pro_CUIT { get; set; }
        public String pro_RazonSocial { get; set; }
        public String pro_IdDireccion { get; set; }
        public String pro_Telefono { get; set; }
        public String pro_Email { get; set; }
        public DateTime pro_FechaAlta { get; set; }//
        public DateTime pro_FechaBaja { get; set; }//
        public DateTime pro_FechaModificacion { get; set; }//
    }
}
