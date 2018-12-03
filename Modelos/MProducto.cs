using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    class MProducto
    {
        public int id { get; set; }
        public String nombre { get; set; }
        public String codigo { get; set; }
        internal String unidad { get; set; }
        public Double precio { get; set; }
        public String descripcion { get; set; }
        public String imagen { get; set; }
        internal String estado { get; set; }
        public MProducto(int id, String nombre, String codigo, String unidad, Double precio, String descripcion, String imagen, String estado)
        {
            this.id = id;
            this.nombre = nombre;
            this.codigo = codigo;
            this.unidad = unidad;
            this.precio = precio;
            this.descripcion = descripcion;
            this.imagen = imagen;
            this.estado = estado;
        }
    }
}
