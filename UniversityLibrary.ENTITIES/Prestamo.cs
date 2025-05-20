using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLibrary.ENTITIES
{
    public class Prestamo
    {
        public string id_usuario { get; set; }
        public string id_libro { get; set; }
        public string estado { get; set; }
        public string fecha_prestamo { get; set; }
        public string fecha_devolucion { get; set; }
    }

}
