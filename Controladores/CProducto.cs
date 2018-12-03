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
    class CProducto
    {
        internal static String table = "productos";
        public static bool Insertar(MProducto objeto, facturacion.Vistas.VProducto form)
        {

            MySqlConnection SqlCon = new MySqlConnection(Conexion.Cn);
            try
            {
                SqlCon.Open();
                string query001 = "INSERT INTO " + table + "(nombre,codigo,unidad,precio,descripcion,imagen) Values(@nombre,@codigo,@unidad,@precio,@descripcion,@imagen)";
                MySqlCommand command = new MySqlCommand(query001, SqlCon);
                command.Parameters.AddWithValue("@nombre",objeto.nombre);
                command.Parameters.AddWithValue("@codigo", objeto.codigo);
                command.Parameters.AddWithValue("@unidad", objeto.unidad);
                command.Parameters.AddWithValue("@precio", objeto.precio);
                command.Parameters.AddWithValue("@descripcion", objeto.descripcion);
                command.Parameters.AddWithValue("@imagen", objeto.imagen);

                
                if (command.ExecuteNonQuery() == 1)
                {
                    ToastNotification.Show(form, "Producto Creada Correctamente", global::facturacion.Properties.Resources.ok, 3000, (eToastGlowColor.Green), (eToastPosition.TopRight));
                    SqlCon.Close();
                    return true;
                }
                else
                {
                    ToastNotification.Show(form, "El producto no pudo ser Creada", global::facturacion.Properties.Resources.error, 3000, (eToastGlowColor.Red), (eToastPosition.TopRight));
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
        public static bool Editar(int id, MProducto objeto, facturacion.Vistas.VProducto form)
        {

            MySqlConnection SqlCon = new MySqlConnection(Conexion.Cn);
            try
            {
                SqlCon.Open();
                string query001 = "UPDATE " + table + " SET nombre=@nombre,codigo=@codigo,unidad=@unidad,precio=@precio,descripcion=@descripcion,imagen=@imagen where id=@id;";
                Console.WriteLine(query001);
                MySqlCommand command = new MySqlCommand(query001, SqlCon);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@nombre", objeto.nombre);
                command.Parameters.AddWithValue("@codigo", objeto.codigo);
                command.Parameters.AddWithValue("@unidad", objeto.unidad);
                command.Parameters.AddWithValue("@precio", objeto.precio);
                command.Parameters.AddWithValue("@descripcion", objeto.descripcion);
                command.Parameters.AddWithValue("@imagen", objeto.imagen);
                if (command.ExecuteNonQuery() == 1)
                {
                    ToastNotification.Show(form, "Producto Editada Correctamente", global::facturacion.Properties.Resources.ok, 3000, (eToastGlowColor.Green), (eToastPosition.TopRight));
                    SqlCon.Close();
                    return true;
                }
                else
                {
                    ToastNotification.Show(form, "El producto no pudo ser Editado", global::facturacion.Properties.Resources.error, 3000, (eToastGlowColor.Red), (eToastPosition.TopRight));
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
        public static bool Eliminar(int id, facturacion.Vistas.VProducto form)
        {
            MySqlConnection SqlCon = new MySqlConnection(Conexion.Cn);
            try
            {
                SqlCon.Open();
                MySqlCommand command = new MySqlCommand(String.Format("UPDATE " + table + " SET estado='disable' where id='" + id + "';"), SqlCon);
                if (command.ExecuteNonQuery() == 1)
                {
                    ToastNotification.Show(form, " El producto se elimino correctamente", global::facturacion.Properties.Resources.ok, 3000, (eToastGlowColor.Green), (eToastPosition.TopRight));
                    SqlCon.Close();
                    return true;
                }
                else
                {
                    ToastNotification.Show(form, "El producto no se pudo eliminar", global::facturacion.Properties.Resources.error, 3000, (eToastGlowColor.Red), (eToastPosition.TopRight));
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
            DataTable DtResultado = new DataTable("producto");
            MySqlConnection SqlCon = new MySqlConnection(Conexion.Cn);
            MySqlCommand SqlDat = new MySqlCommand(String.Format("SELECT * FROM "+table+" where estado='enable' ORDER BY nombre DESC;"), SqlCon);
            SqlCon.Open();
            MySqlDataReader dr = SqlDat.ExecuteReader(CommandBehavior.CloseConnection);
            DtResultado.Load(dr);
            dr.Close();
            SqlDat.Dispose();
            SqlCon.Close();
            return DtResultado;
        }
        public static DataTable Buscar( String buscarPor, String variableAbuscar )
        {
            DataTable DtResultado = new DataTable("producto");
            MySqlConnection SqlCon = new MySqlConnection(Conexion.Cn);
            MySqlCommand SqlDat = new MySqlCommand(String.Format("SELECT  * FROM "+table+" where estado='enable' AND "+buscarPor+" like '%"+variableAbuscar+"%' ORDER BY  nombre DESC;"), SqlCon);
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
