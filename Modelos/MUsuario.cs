using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    class MUsuario
    {
        public int id { get; set; }
        public String nombre { get; set; }
        public String ci { get; set; }
        internal String direccion { get; set; }
        internal String telefono { get; set; }
        public String tipo { get; set; }
        internal String estado { get; set; }
        internal String cuenta { get; set; }
        internal String contraseña { get; set; }
        public MUsuario(int id,String nombre,String ci,String direccion,String telefono,String tipo,String estado,String cuenta,String contraseña) {
           this.id = id;
           this.nombre = nombre;
           this.ci = ci;
           this.direccion = direccion;
           this.telefono = telefono;
           this.tipo = tipo;
           this.estado = estado;
           this.cuenta = cuenta;
           this.contraseña = contraseña;
            
        }
    }
}
