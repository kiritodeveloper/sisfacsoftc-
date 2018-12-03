using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    class MVentas
    {
        internal int id { get; set; }
        internal int idCliente { get; set; }
        internal int idUsuario { get; set; }
        internal DateTime fecVenta { get; set; }
        internal Double montoTotal { get; set; }
        internal String montoLiteral { get; set; }
        internal String tipo { get; set; }
        internal String estado { get; set; }
        internal int numero { get; set; }
        public MVentas(int id,int idCliente,int idUsuario,DateTime fecVenta,Double montoTotal,String montoLiteral,String tipo,String estado,int numero) {
            this.id = id;
            this.idCliente = idCliente;
            this.idUsuario = idUsuario;
            this.fecVenta = fecVenta;
            this.montoTotal = montoTotal;
            this.montoLiteral = montoLiteral;
            this.tipo = tipo;
            this.estado = estado;
            this.numero = numero;
        }
    }
}
