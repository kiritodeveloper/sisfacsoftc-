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
    class CFactura
    {
        internal static String table = "facturas";
        public static bool Insertar(MFactura objeto, facturacion.Vistas.VVentas form)
        {

            MySqlConnection SqlCon = new MySqlConnection(Conexion.Cn);
            try
            {
                SqlCon.Open();
                string query001 = "INSERT INTO " + table + "(idVenta,idCodigo,codControl,QR,numFactura,fecEmision) Values(@idVenta,@idCodigo,@codControl,@QR,@numFactura,@fecEmision)";
                MySqlCommand command = new MySqlCommand(query001, SqlCon);
                command.Parameters.AddWithValue("@idVenta", objeto.idVenta);
                command.Parameters.AddWithValue("@idCodigo", objeto.idCodigo);
                command.Parameters.AddWithValue("@codControl", objeto.codControl);
                command.Parameters.AddWithValue("@QR", objeto.QR);
                command.Parameters.AddWithValue("@numFactura", objeto.numFactura);
                command.Parameters.AddWithValue("@fecEmision", objeto.fecEmision);


                if (command.ExecuteNonQuery() == 1)
                {
                    ToastNotification.Show(form, "Factura Creada Correctamente", global::facturacion.Properties.Resources.ok, 3000, (eToastGlowColor.Green), (eToastPosition.TopRight));
                    SqlCon.Close();
                    return true;
                }
                else
                {
                    ToastNotification.Show(form, "La factura no pudo ser Creada", global::facturacion.Properties.Resources.error, 3000, (eToastGlowColor.Red), (eToastPosition.TopRight));
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
        public static bool Editar(int id, MFactura objeto, facturacion.Vistas.VVentas form)
        {

            MySqlConnection SqlCon = new MySqlConnection(Conexion.Cn);
            try
            {
                SqlCon.Open();
                string query001 = "UPDATE " + table + " SET idVenta=@idVenta,idCodigo=@idCodigo,codControl=@codControl,QR=@QR,numFactura=@numFactura,fecEmision=@fecEmision where id=@id;";
                Console.WriteLine(query001);
                MySqlCommand command = new MySqlCommand(query001, SqlCon);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@idVenta", objeto.idVenta);
                command.Parameters.AddWithValue("@idCodigo", objeto.idCodigo);
                command.Parameters.AddWithValue("@codControl", objeto.codControl);
                command.Parameters.AddWithValue("@QR", objeto.QR);
                command.Parameters.AddWithValue("@numFactura", objeto.numFactura);
                command.Parameters.AddWithValue("@fecEmision", objeto.fecEmision);
                if (command.ExecuteNonQuery() == 1)
                {
                    ToastNotification.Show(form, "Factura Editada Correctamente", global::facturacion.Properties.Resources.ok, 3000, (eToastGlowColor.Green), (eToastPosition.TopRight));
                    SqlCon.Close();
                    return true;
                }
                else
                {
                    ToastNotification.Show(form, "La factura no pudo ser Editado", global::facturacion.Properties.Resources.error, 3000, (eToastGlowColor.Red), (eToastPosition.TopRight));
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
                MySqlCommand command = new MySqlCommand(String.Format("UPDATE " + table + " SET estado='anulado' where id='" + id + "';"), SqlCon);
                if (command.ExecuteNonQuery() == 1)
                {
                    ToastNotification.Show(form, " La factura se elimino correctamente", global::facturacion.Properties.Resources.ok, 3000, (eToastGlowColor.Green), (eToastPosition.TopRight));
                    SqlCon.Close();
                    return true;
                }
                else
                {
                    ToastNotification.Show(form, "La factura no se pudo eliminar", global::facturacion.Properties.Resources.error, 3000, (eToastGlowColor.Red), (eToastPosition.TopRight));
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
            DataTable DtResultado = new DataTable("factura");
            MySqlConnection SqlCon = new MySqlConnection(Conexion.Cn);
            MySqlCommand SqlDat = new MySqlCommand(String.Format("SELECT * FROM " + table + " where  ORDER BY nombre DESC;"), SqlCon);
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
            DataTable DtResultado = new DataTable("factura");
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
        public static DataTable ultimo()
        {
            DataTable DtResultado = new DataTable("factura");
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

        internal static DataTable MostrarID(long id_venta)
        {
            DataTable DtResultado = new DataTable("factura");
            MySqlConnection SqlCon = new MySqlConnection(Conexion.Cn);
            MySqlCommand SqlDat = new MySqlCommand(String.Format("SELECT * FROM " + table + " where idVenta="+id_venta+" ORDER BY id DESC limit 1"), SqlCon);
            SqlCon.Open();
            MySqlDataReader dr = SqlDat.ExecuteReader(CommandBehavior.CloseConnection);
            DtResultado.Load(dr);
            dr.Close();
            SqlDat.Dispose();
            SqlCon.Close();
            return DtResultado;
        }

        internal static bool Insertar(MFactura objeto, facturacion.Vistas.VListaVentas form)
        {
            MySqlConnection SqlCon = new MySqlConnection(Conexion.Cn);
            try
            {
                SqlCon.Open();
                string query001 = "INSERT INTO " + table + "(idVenta,idCodigo,codControl,QR,numFactura,fecEmision) Values(@idVenta,@idCodigo,@codControl,@QR,@numFactura,@fecEmision)";
                MySqlCommand command = new MySqlCommand(query001, SqlCon);
                command.Parameters.AddWithValue("@idVenta", objeto.idVenta);
                command.Parameters.AddWithValue("@idCodigo", objeto.idCodigo);
                command.Parameters.AddWithValue("@codControl", objeto.codControl);
                command.Parameters.AddWithValue("@QR", objeto.QR);
                command.Parameters.AddWithValue("@numFactura", objeto.numFactura);
                command.Parameters.AddWithValue("@fecEmision", objeto.fecEmision);


                if (command.ExecuteNonQuery() == 1)
                {
                    ToastNotification.Show(form, "Factura Creada Correctamente", global::facturacion.Properties.Resources.ok, 3000, (eToastGlowColor.Green), (eToastPosition.TopRight));
                    SqlCon.Close();
                    return true;
                }
                else
                {
                    ToastNotification.Show(form, "La factura no pudo ser Creada", global::facturacion.Properties.Resources.error, 3000, (eToastGlowColor.Red), (eToastPosition.TopRight));
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
    }
}
