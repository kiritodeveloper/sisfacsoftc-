using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    class MCodigo
    {
        internal int id { get; set; }
        internal DateTime fecInicio { get; set; }
        internal DateTime fecFinal { get; set; }
        internal String clave { get; set; }
        internal String autorizacion { get; set; }
        public MCodigo(int id,DateTime fecInicio,DateTime fecFinal, String clave,String autorizacion) {
            this.id = id;
            this.fecInicio = fecInicio;
            this.fecFinal = fecFinal;
            this.clave = clave;
            this.autorizacion = autorizacion;
        }
    }
}
