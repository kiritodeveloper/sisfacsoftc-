using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    class MListaFactura
    {

        public String nombre {get;set;}
        public String ci{get;set;}
        public String Cod_Control{get;set;}
        public String Emision {get;set;}
        public Double Importe {get;set;}
        public String autorizacion {get;set;}
        public String Fecha_Limite { get; set; }
        public String estado { get; set; }
        public int Factura { get; set; }
        
        
    }
}
