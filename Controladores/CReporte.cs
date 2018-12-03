using Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Controladores
{
    class CReporte
    {
        public static DataTable Reporte1(int id_usuario, int cliente_id, string tipo_venta, string fecha_inicio, string fecha_final)
        {
            string usuario = "";
            if (id_usuario!= -1)
            {
                usuario = " and v.idUsuario=" + id_usuario;
            }
            string cliente = "";
            if (cliente_id != -1)
            {
                cliente = " and c.id=" + cliente_id;
            }
            string venta = "";
            if (tipo_venta != "Todos")
            {
                venta = " and v.tipo='" + tipo_venta + "'";
            }

            DataTable DtResultado = new DataTable("producto");
            MySqlConnection SqlCon = new MySqlConnection(Conexion.Cn);
            string cad = "SELECT v.id venta_id,c.id cliente_id, v.fecVenta as fecha, v.montoTotal as importe, v.tipo, c.nombre,c.ci, v.estado FROM ventas v, clientes c WHERE v.idCliente=c.id " + cliente + venta + usuario + " and date(v.fecVenta) BETWEEN '" + fecha_inicio + "' and '" + fecha_final + "'";
            
            MySqlCommand SqlDat = new MySqlCommand(cad, SqlCon);
            SqlCon.Open();
            MySqlDataReader dr = SqlDat.ExecuteReader(CommandBehavior.CloseConnection);
            DtResultado.Load(dr);
            dr.Close();
            SqlDat.Dispose();
            SqlCon.Close();
            return DtResultado;
        }

        internal static object Reporte2(int id_cliente, string pedidos, string fecha_inicio, string fecha_final)
        {
            string cliente = "";
            if (id_cliente != -1)
            {
                cliente = " and c.id=" + id_cliente;
            }
            string venta = "";
            if (pedidos != "Todos")
            {
                venta = " and v.tipo='" + pedidos + "'";
            }

            DataTable DtResultado = new DataTable("producto");
            MySqlConnection SqlCon = new MySqlConnection(Conexion.Cn);
            string cad = "SELECT c.id,c.nombre, SUM(v.montoTotal) as importe, COUNT(v.montoTotal) as cantidad,v.fecVenta, c.ci,v.tipo from clientes c, ventas v where v.estado='cancelado' and c.id=v.idCliente " + cliente + venta + " and date(v.fecVenta) BETWEEN '" + fecha_inicio + "' and '" + fecha_final + "' GROUP by c.id;";
            MySqlCommand SqlDat = new MySqlCommand(cad, SqlCon);
            SqlCon.Open();
            MySqlDataReader dr = SqlDat.ExecuteReader(CommandBehavior.CloseConnection);
            DtResultado.Load(dr);
            dr.Close();
            SqlDat.Dispose();
            SqlCon.Close();
            return DtResultado;
        }

        internal static object Reporte3(int id_cliente, string pedidos, string fecha_inicio, string fecha_final)
        {
            //SELECT p.id, p.nombre, SUM(dv.cantidad) as cantidad, SUM(totalVenta) as total FROM productos p, detalleventas dv, ventas v where p.id=dv.idProducto and dv.idVenta=v.id and date(v.fecVenta) BETWEEN '2018-06-17' and '2018-06-18' GROUP by p.id ORDER by cantidad DESC
           
            string venta = "";
            if (pedidos != "Todos")
            {
                venta = " and v.tipo='" + pedidos + "'";
            }

            DataTable DtResultado = new DataTable("producto");
            MySqlConnection SqlCon = new MySqlConnection(Conexion.Cn);
            string cad = "SELECT p.id, p.nombre,p.codigo,p.precio, SUM(dv.cantidad) as cantidad, SUM(totalVenta) as importe  from productos p, detalleventas dv, ventas v where v.estado='cancelado' and p.id=dv.idProducto and dv.idVenta=v.id " + venta + " and date(v.fecVenta) BETWEEN '" + fecha_inicio + "' and '" + fecha_final + "' GROUP by p.id ORDER by cantidad DESC;";
            
            MySqlCommand SqlDat = new MySqlCommand(cad, SqlCon);
            SqlCon.Open();
            MySqlDataReader dr = SqlDat.ExecuteReader(CommandBehavior.CloseConnection);
            DtResultado.Load(dr);
            dr.Close();
            SqlDat.Dispose();
            SqlCon.Close();
            return DtResultado;
        }

        internal static object Reporte4(string fecha_inicio, string fecha_final)
        {
            //SELECT p.* from ventas v, productos p LEFT JOIN detalleventas dv on p.id=dv.idProducto where dv.idProducto is null and Date(v.fecVenta) BETWEEN '2018-06-18' and '2018-06-18' GROUP by p.id
            
            DataTable DtResultado = new DataTable("producto");
            MySqlConnection SqlCon = new MySqlConnection(Conexion.Cn);
            string cad = "SELECT p.* from ventas v, productos p LEFT JOIN detalleventas dv on p.id=dv.idProducto where dv.idProducto is null and v.estado='cancelado' and date(v.fecVenta) BETWEEN '" + fecha_inicio + "' and '" + fecha_final + "' GROUP by p.id;";

            MySqlCommand SqlDat = new MySqlCommand(cad, SqlCon);
            SqlCon.Open();
            MySqlDataReader dr = SqlDat.ExecuteReader(CommandBehavior.CloseConnection);
            DtResultado.Load(dr);
            dr.Close();
            SqlDat.Dispose();
            SqlCon.Close();
            return DtResultado;
        }

        internal static DataTable Reporte5(string di, string df)
        {
            DataTable DtResultado = new DataTable("producto");
            MySqlConnection SqlCon = new MySqlConnection(Conexion.Cn);
            string cad = "SELECT f.numFactura as Factura, cl.nombre, cl.ci, f.codControl as Cod_Control, f.fecEmision as Emision, v.montoTotal as Importe, v.estado, c.autorizacion, c.fecFinal as Fecha_Limite  FROM facturas f, ventas v, codigos c, clientes cl where v.id= f.idVenta and v.idCliente=cl.id and f.idCodigo=c.id and date(v.fecVenta) BETWEEN date('" + di + "') and date('" + df + "');";
            MySqlCommand SqlDat = new MySqlCommand(cad, SqlCon);
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
