using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    class MClientes
    {
        public int id { get; set; }
        public String nombre { get; set; }
        public String ci { get; set; }
        internal String direccion { get; set; }
        internal String telefono { get; set; }
        internal DateTime created_at { get; set; }
        public MClientes(int id,String nombre,String ci,String direccion,String telefono,DateTime created_at) {
            this.id = id;
            this.nombre = nombre;
            this.ci = ci;
            this.direccion = direccion;
            this.telefono = telefono;
            this.created_at = created_at;
        }
    }
}
