using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Rol
    {
        public int IdRol { get; set; }
        public String NombreRol { get; set; }
        public String DescripcionRol { get; set; }
        public String Area { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaBaja { get; set; }
        public DateTime FechaMod { get; set; }
    }
}
