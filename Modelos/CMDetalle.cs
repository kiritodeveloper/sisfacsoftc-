using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    class CMDetalle
    {
        public int cantidad { get; set; }
        public Double totalVenta { get; set; }
        public String descripcion { get; set; }
        public Double preUnitario { get; set; }
        public  CMDetalle(int cantidad,Double TotalVenta,String descripcion,Double preUnitario) {
            this.cantidad = cantidad;
            this.totalVenta = TotalVenta;
            this.descripcion = descripcion;
            this.preUnitario = preUnitario;
        }
    }
}
