using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    class MDetalleVenta
    {
        internal int id { get; set; }
        internal int idProducto { get; set; }
        internal int idVenta { get; set; }
        public Double cantidad { get; set; }
        public Double totalVenta { get; set; }
        public String descripcion { get; set; }
        public Double preUnitario { get; set; }
        public MDetalleVenta(int id,int idProducto,Double cantidad,int idVenta,Double TotalVenta,String descripcion,Double preUnitario) {
            this.id = id;
            this.idProducto = idProducto;
            this.idVenta = idVenta;
            this.cantidad = cantidad;
            this.totalVenta = TotalVenta;
            this.descripcion = descripcion;
            this.preUnitario = preUnitario;
        }
    }
}
