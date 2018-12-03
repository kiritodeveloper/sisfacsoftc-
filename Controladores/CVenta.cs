using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using MySql.Data.MySqlClient;
using DevComponents.DotNetBar;
using System.Data;

namespace Controladores
{
    class CVenta
    {
        internal static String table = "ventas";
        public static long Insertar(MVentas objeto, facturacion.Vistas.VVentas form)
        {
            long id = -1;
            MySqlConnection SqlCon = new MySqlConnection(Conexion.Cn);
            try
            {
                SqlCon.Open();
                string query001 = "INSERT INTO " + table + "(idCliente,idUsuario,fecVenta,montoTotal,montoLiteral,tipo,estado,numero) Values(@idCliente,@idUsuario,@fecVenta,@montoTotal,@montoLiteral,@tipo,@estado,@numero)";
                MySqlCommand command = new MySqlCommand(query001, SqlCon);
                command.Parameters.AddWithValue("@idCliente", objeto.idCliente);
                command.Parameters.AddWithValue("@idUsuario", objeto.idUsuario);
                command.Parameters.AddWithValue("@fecVenta", objeto.fecVenta);
                command.Parameters.AddWithValue("@montoTotal", objeto.montoTotal);
                command.Parameters.AddWithValue("@montoLiteral", objeto.montoLiteral);
                command.Parameters.AddWithValue("@tipo", objeto.tipo);
                command.Parameters.AddWithValue("@estado", objeto.estado);
                command.Parameters.AddWithValue("@numero", objeto.numero);
                
                if (command.ExecuteNonQuery() == 1)
                {
                    id=command.LastInsertedId;
                    ToastNotification.Show(form, "venta Creada Correctamente", global::facturacion.Properties.Resources.ok, 3000, (eToastGlowColor.Green), (eToastPosition.TopRight));
                    SqlCon.Close();
                    return id;
                }
                else
                {
                    ToastNotification.Show(form, "La venta no pudo ser Creada", global::facturacion.Properties.Resources.error, 3000, (eToastGlowColor.Red), (eToastPosition.TopRight));
                    SqlCon.Close();
                    return id;
                }
            }
            catch (MySqlException e)
            {
                ToastNotification.Show(form, e.Message, global::facturacion.Properties.Resources.error, 3000, (eToastGlowColor.Red), (eToastPosition.TopLeft));
                return id;
            }
        }
        public static bool Editar(int id, MVentas objeto, facturacion.Vistas.VListaVentas form)
        {

            MySqlConnection SqlCon = new MySqlConnection(Conexion.Cn);
            try
            {
                SqlCon.Open();
                string query001 = "UPDATE " + table + " SET idCliente=@idCliente,idUsuario=@idUsuario,fecVenta=@fecVenta,montoTotal=@montoTotal,montoLiteral=@montoLiteral,tipo=@tipo,estado=@estado where id=@id;";
                MySqlCommand command = new MySqlCommand(query001, SqlCon);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@idCliente", objeto.idCliente);
                command.Parameters.AddWithValue("@idUsuario", objeto.idUsuario);
                command.Parameters.AddWithValue("@fecVenta", objeto.fecVenta);
                command.Parameters.AddWithValue("@montoTotal", objeto.montoTotal);
                command.Parameters.AddWithValue("@montoLiteral", objeto.montoLiteral);
                command.Parameters.AddWithValue("@tipo", objeto.tipo);
                command.Parameters.AddWithValue("@estado", objeto.estado);
                if (command.ExecuteNonQuery() == 1)
                {
                    ToastNotification.Show(form, "venta Editada Correctamente", global::facturacion.Properties.Resources.ok, 3000, (eToastGlowColor.Green), (eToastPosition.TopRight));
                    SqlCon.Close();
                    return true;
                }
                else
                {
                    ToastNotification.Show(form, "La venta no pudo ser Editado", global::facturacion.Properties.Resources.error, 3000, (eToastGlowColor.Red), (eToastPosition.TopRight));
                    SqlCon.Close();
                    return false;
                }
            }
            catch (MySqlException e)
            {
                ToastNotification.Show(form, e.Message, global::facturacion.Properties.Resources.error, 3000, (eToastGlowColor.Red), (eToastPosition.TopLeft));
                return false;
            }
        }
        public static bool Eliminar(long id, facturacion.Vistas.VListaVentas form)
        {
            MySqlConnection SqlCon = new MySqlConnection(Conexion.Cn);
            try
            {
                SqlCon.Open();
                MySqlCommand command = new MySqlCommand(String.Format("UPDATE " + table + " SET estado='anulado' where id='" + id + "';"), SqlCon);
                if (command.ExecuteNonQuery() == 1)
                {
                    ToastNotification.Show(form, " La venta se elimino correctamente", global::facturacion.Properties.Resources.ok, 3000, (eToastGlowColor.Green), (eToastPosition.TopRight));
                    SqlCon.Close();
                    return true;
                }
                else
                {
                    ToastNotification.Show(form, "La venta no se pudo eliminar", global::facturacion.Properties.Resources.error, 3000, (eToastGlowColor.Red), (eToastPosition.TopRight));
                    SqlCon.Close();
                    return false;
                }
            }
            catch (Exception e)
            {
                ToastNotification.Show(form, e.Message, global::facturacion.Properties.Resources.error, 3000, (eToastGlowColor.Red), (eToastPosition.TopLeft));
                return false;
            }

        }


        public static DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("venta");
            MySqlConnection SqlCon = new MySqlConnection(Conexion.Cn);
            MySqlCommand SqlDat = new MySqlCommand(String.Format("SELECT * FROM " + table + " where estado='cancelado' ORDER BY id DESC;"), SqlCon);
            SqlCon.Open();
            MySqlDataReader dr = SqlDat.ExecuteReader(CommandBehavior.CloseConnection);
            DtResultado.Load(dr);
            dr.Close();
            SqlDat.Dispose();
            SqlCon.Close();
            return DtResultado;
        }
        public static DataTable Buscar(String buscarPor, String variableAbuscar)
        {
            DataTable DtResultado = new DataTable("venta");
            MySqlConnection SqlCon = new MySqlConnection(Conexion.Cn);
            MySqlCommand SqlDat = new MySqlCommand(String.Format("SELECT  * FROM " + table + " where estado='cancelado' AND " + buscarPor + " like '%" + variableAbuscar + "%' ORDER BY  nombre DESC;"), SqlCon);
            SqlCon.Open();
            MySqlDataReader dr = SqlDat.ExecuteReader(CommandBehavior.CloseConnection);
            DtResultado.Load(dr);
            dr.Close();
            SqlDat.Dispose();
            SqlCon.Close();
            return DtResultado;
        }
        public static DataTable Ventas(string fecha_inicio,string fecha_final,string ci)
        {
            string whereci = " ";
            if (ci != string.Empty) {
                whereci = "and c.ci like '%"+ci+"%'";
            }
            DataTable DtResultado = new DataTable("venta");
            MySqlConnection SqlCon = new MySqlConnection(Conexion.Cn);
            MySqlCommand SqlDat = new MySqlCommand(String.Format("SELECT v.id as id,ci,montoTotal as Importe,fecVenta as fecha,nombre,tipo FROM " + table + " v,clientes c WHERE v.estado='cancelado' and c.id=v.idCliente " + whereci + " and Date(fecVenta) BETWEEN '" + fecha_inicio + "' and '" + fecha_final + "' ORDER BY v.id"), SqlCon);
            SqlCon.Open();
            MySqlDataReader dr = SqlDat.ExecuteReader(CommandBehavior.CloseConnection);
            DtResultado.Load(dr);
            dr.Close();
            SqlDat.Dispose();
            SqlCon.Close();
            return DtResultado;
        }
        public static DataTable ultimo()
        {
            DataTable DtResultado = new DataTable("venta");
            MySqlConnection SqlCon = new MySqlConnection(Conexion.Cn);
            MySqlCommand SqlDat = new MySqlCommand(String.Format("SELECT id FROM " + table + " ORDER BY id DESC limit 1"), SqlCon);
            SqlCon.Open();
            MySqlDataReader dr = SqlDat.ExecuteReader(CommandBehavior.CloseConnection);
            DtResultado.Load(dr);
            dr.Close();
            SqlDat.Dispose();
            SqlCon.Close();
            return DtResultado;
        }

        public static DataTable ultimofecha()
        {
            DataTable DtResultado = new DataTable("venta");
            MySqlConnection SqlCon = new MySqlConnection(Conexion.Cn);
            String cadena="SELECT id,numero FROM " + table + " where date(fecVenta)=@fecha ORDER BY id DESC limit 1";
            Console.Write(cadena);
            MySqlCommand SqlDat = new MySqlCommand(cadena, SqlCon);
            SqlDat.Parameters.AddWithValue("@fecha", DateTime.Now.ToString("yyyy-MM-dd"));
            SqlCon.Open();
            MySqlDataReader dr = SqlDat.ExecuteReader(CommandBehavior.CloseConnection);
            DtResultado.Load(dr);
            dr.Close();
            SqlDat.Dispose();
            SqlCon.Close();
            return DtResultado;
        }

        internal static DataTable MostrarID(long id_venta)
        {
            DataTable DtResultado = new DataTable("venta");
            MySqlConnection SqlCon = new MySqlConnection(Conexion.Cn);
            MySqlCommand SqlDat = new MySqlCommand(String.Format("SELECT * FROM " + table + " where id=" + id_venta + " ORDER BY id DESC limit 1"), SqlCon);
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
