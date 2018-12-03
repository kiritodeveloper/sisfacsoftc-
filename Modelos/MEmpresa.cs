using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    class MEmpresa
    {
        internal int id { get; set; }
        internal String nombre { get; set; }
        
        internal String nit { get; set; }
        internal String logo { get; set; }
        internal String direccion { get; set; }
        internal String telefono { get; set; }
        internal String sigla { get; set; }
        internal String nomPropietario { get; set; }
        public MEmpresa(String nombre,String nit,String logo,String direccion,String telefono,String sigla,String nomPropietario) {
            this.nombre = nombre;
            this.nit = nit;
            this.logo = logo;
            this.direccion = direccion;
            this.telefono = telefono;
            this.sigla = sigla;
            this.nomPropietario = nomPropietario;
        }
    }
}
