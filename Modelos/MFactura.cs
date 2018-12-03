using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    class MFactura
    {
        internal int id { get; set; }
        internal int idVenta { get; set; }
        internal int idCodigo { get; set; }
        internal String codControl { get; set; }
        internal String QR { get; set; }
        internal String numFactura { get; set; }
        internal DateTime fecEmision { get; set; }
        public MFactura(int id,int idVenta,int idCodigo,String codControl,String QR,String numFactura,DateTime fecEmision) {
            this.id = id;
            this.idVenta = idVenta;
            this.codControl = codControl;
            this.QR = QR;
            this.numFactura = numFactura;
            this.fecEmision = fecEmision;
            this.idCodigo = idCodigo;
        }
    }
}
