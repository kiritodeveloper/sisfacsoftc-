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
    class CDetalleVenta
    {
        internal static String table = "detalleventas";
        public static bool Insertar(MDetalleVenta objeto, facturacion.Vistas.VVentas form)
        {

            MySqlConnection SqlCon = new MySqlConnection(Conexion.Cn);
            //try
            //{
                SqlCon.Open();
                string query001 = "INSERT INTO " + table + "(idProducto,idVenta,cantidad,TotalVenta,descripcion,preUnitario) Values(@idProducto,@idVenta,@cantidad,@TotalVenta,@descripcion,@preUnitario)";
                MySqlCommand command = new MySqlCommand(query001, SqlCon);
                command.Parameters.AddWithValue("@idProducto", objeto.idProducto);
                command.Parameters.AddWithValue("@idVenta", objeto.idVenta);
                command.Parameters.AddWithValue("@cantidad", objeto.cantidad);
                command.Parameters.AddWithValue("@TotalVenta", objeto.totalVenta);
                command.Parameters.AddWithValue("@descripcion", objeto.descripcion);
                command.Parameters.AddWithValue("@preUnitario", objeto.preUnitario);
                command.ExecuteNonQuery();
                SqlCon.Close();
                return false;
                
            /*}
            catch (MySqlException e)
            {
                ToastNotification.Show(form, e.Message, global::facturacion.Properties.Resources.error, 3000, (eToastGlowColor.Red), (eToastPosition.TopLeft));
                return false;
            }*/
        }
        public static bool Editar(int id, MDetalleVenta objeto, facturacion.Vistas.VVentas form)
        {

            MySqlConnection SqlCon = new MySqlConnection(Conexion.Cn);
            try
            {
                SqlCon.Open();
                string query001 = "UPDATE " + table + " SET idProducto=@idProducto,idVenta=@idVenta,cantidad=@cantidad,TotalVenta=@TotalVenta,descripcion=@descripcion,preUnitario=@preUnitario where id=@id;";
                Console.WriteLine(query001);
                MySqlCommand command = new MySqlCommand(query001, SqlCon);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@idProducto", objeto.idProducto);
                command.Parameters.AddWithValue("@idVenta", objeto.idVenta);
                command.Parameters.AddWithValue("@cantidad", objeto.cantidad);
                command.Parameters.AddWithValue("@TotalVenta", objeto.totalVenta);
                command.Parameters.AddWithValue("@descripcion", objeto.descripcion);
                command.Parameters.AddWithValue("@preUnitario", objeto.preUnitario);
                if (command.ExecuteNonQuery() == 1)
                {
                    ToastNotification.Show(form, "El detalle de venta fue Editada Correctamente", global::facturacion.Properties.Resources.ok, 3000, (eToastGlowColor.Green), (eToastPosition.TopRight));
                    SqlCon.Close();
                    return true;
                }
                else
                {
                    ToastNotification.Show(form, "El detalle de venta no pudo ser Editado", global::facturacion.Properties.Resources.error, 3000, (eToastGlowColor.Red), (eToastPosition.TopRight));
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
        public static bool Eliminar(int id, facturacion.Vistas.VVentas form)
        {
            MySqlConnection SqlCon = new MySqlConnection(Conexion.Cn);
            try
            {
                SqlCon.Open();
                MySqlCommand command = new MySqlCommand(String.Format("UPDATE " + table + " SET estado='disable' where id='" + id + "';"), SqlCon);
                if (command.ExecuteNonQuery() == 1)
                {
                    ToastNotification.Show(form, " El detalle de venta se elimino correctamente", global::facturacion.Properties.Resources.ok, 3000, (eToastGlowColor.Green), (eToastPosition.TopRight));
                    SqlCon.Close();
                    return true;
                }
                else
                {
                    ToastNotification.Show(form, "El detalle de venta no se pudo eliminar", global::facturacion.Properties.Resources.error, 3000, (eToastGlowColor.Red), (eToastPosition.TopRight));
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


        public static DataTable Mostrar(int id_venta)
        {
            DataTable DtResultado = new DataTable("venta");
            MySqlConnection SqlCon = new MySqlConnection(Conexion.Cn);
            MySqlCommand SqlDat = new MySqlCommand(String.Format("SELECT * FROM " + table + " where idVenta="+id_venta+"  ORDER BY id DESC;"), SqlCon);
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
            MySqlCommand SqlDat = new MySqlCommand(String.Format("SELECT  * FROM " + table + " where " + buscarPor + " like '%" + variableAbuscar + "%' ORDER BY  nombre DESC;"), SqlCon);
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
