using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladores
{
    class CReportes
    {
        public static DataTable Mostrar(string fecha_inicio,string fecha_fin,int cliente_id,string tipo_venta)
        {
            string cliente = "";
            if (cliente_id != -1) {
                cliente = " and c.id="+cliente_id;
            }
            string venta = "";
            if (tipo_venta != "Todos") {
                venta = " and v.tipo='" + tipo_venta + "'";
            }

            DataTable DtResultado = new DataTable("producto");
            MySqlConnection SqlCon = new MySqlConnection(Conexion.Cn);
            string cad = "SELECT * FROM ventas v, clientes c WHERE v.idCliente=c.id "+cliente+venta+" and date(v.fecVenta) BETWEEN '"+fecha_inicio+"' and '"+tipo_venta+"'";
            MySqlCommand SqlDat = new MySqlCommand(String.Format("SELECT * FROM " + table + " where estado='enable' ORDER BY nombre DESC;"), SqlCon);
            SqlCon.Open();
            MySqlDataReader dr = SqlDat.ExecuteReader(CommandBehavior.CloseConnection);
            DtResultado.Load(dr);
            dr.Close();
            SqlDat.Dispose();
            SqlCon.Close();
            return DtResultado;
        }
    }
}
