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
    class CCliente
    {
        internal static String table = "clientes";
        public static bool Insertar(MClientes objeto, facturacion.Vistas.VCliente form)
        {

            MySqlConnection SqlCon = new MySqlConnection(Conexion.Cn);
            try
            {
                SqlCon.Open();
                string query001 = "INSERT INTO " + table + "(nombre,ci,direccion,telefono,created_at) Values(@nombre,@ci,@direccion,@telefono,@created_at)";
                MySqlCommand command = new MySqlCommand(query001, SqlCon);
                command.Parameters.AddWithValue("@nombre", objeto.nombre);
                command.Parameters.AddWithValue("@ci", objeto.ci);
                command.Parameters.AddWithValue("@direccion", objeto.direccion);
                command.Parameters.AddWithValue("@telefono", objeto.telefono);
                command.Parameters.AddWithValue("@created_at", objeto.created_at);

                if (command.ExecuteNonQuery() == 1)
                {
                    ToastNotification.Show(form, "Cliente Creada Correctamente", global::facturacion.Properties.Resources.ok, 3000, (eToastGlowColor.Green), (eToastPosition.TopRight));
                    SqlCon.Close();
                    return true;
                }
                else
                {
                    ToastNotification.Show(form, "Cliente no pudo ser Creada", global::facturacion.Properties.Resources.error, 3000, (eToastGlowColor.Red), (eToastPosition.TopRight));
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
        public static bool Editar(int id, MClientes objeto, facturacion.Vistas.VCliente form)
        {

            MySqlConnection SqlCon = new MySqlConnection(Conexion.Cn);
            try
            {
                SqlCon.Open();
                string query001 = "UPDATE " + table + " SET nombre=@nombre,ci=@ci,direccion=@direccion,telefono=@telefono,created_at=@created_at where id=@id;";
                Console.WriteLine(query001);
                MySqlCommand command = new MySqlCommand(query001, SqlCon);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@nombre", objeto.nombre);
                command.Parameters.AddWithValue("@ci", objeto.ci);
                command.Parameters.AddWithValue("@direccion", objeto.direccion);
                command.Parameters.AddWithValue("@telefono", objeto.telefono);
                command.Parameters.AddWithValue("@created_at", objeto.created_at);
                if (command.ExecuteNonQuery() == 1)
                {
                    ToastNotification.Show(form, "El cliente fue Editada Correctamente", global::facturacion.Properties.Resources.ok, 3000, (eToastGlowColor.Green), (eToastPosition.TopRight));
                    SqlCon.Close();
                    return true;
                }
                else
                {
                    ToastNotification.Show(form, "El cliente no pudo ser Editado", global::facturacion.Properties.Resources.error, 3000, (eToastGlowColor.Red), (eToastPosition.TopRight));
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
        public static bool Eliminar(int id, facturacion.Vistas.VCliente form)
        {
            MySqlConnection SqlCon = new MySqlConnection(Conexion.Cn);
            try
            {
                SqlCon.Open();
                MySqlCommand command = new MySqlCommand(String.Format("delete from " + table + " where id='" + id + "';"), SqlCon);
                if (command.ExecuteNonQuery() == 1)
                {
                    ToastNotification.Show(form, " Cliente eliminado correctamente", global::facturacion.Properties.Resources.ok, 3000, (eToastGlowColor.Green), (eToastPosition.TopRight));
                    SqlCon.Close();
                    return true;
                }
                else
                {
                    ToastNotification.Show(form, "Cliente no se pudo eliminar", global::facturacion.Properties.Resources.error, 3000, (eToastGlowColor.Red), (eToastPosition.TopRight));
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


        public static DataTable mostrar()
        {
            DataTable DtResultado = new DataTable("cliente");
            MySqlConnection SqlCon = new MySqlConnection(Conexion.Cn);
            MySqlCommand SqlDat = new MySqlCommand(String.Format("SELECT * FROM " + table + "  ORDER BY id;"), SqlCon);
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
            DataTable DtResultado = new DataTable("cliente");
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
        public static DataTable BuscarCI(String buscar)
        {
            DataTable DtResultado = new DataTable("cliente");
            MySqlConnection SqlCon = new MySqlConnection(Conexion.Cn);
            MySqlCommand SqlDat = new MySqlCommand(String.Format("SELECT  * FROM " + table + " where ci='" + buscar+ "' ORDER BY  nombre DESC;"), SqlCon);
            SqlCon.Open();
            MySqlDataReader dr = SqlDat.ExecuteReader(CommandBehavior.CloseConnection);
            DtResultado.Load(dr);
            dr.Close();
            SqlDat.Dispose();
            SqlCon.Close();
            return DtResultado;
        }


        internal static DataTable MostrarID(string p)
        {
            DataTable DtResultado = new DataTable("cliente");
            MySqlConnection SqlCon = new MySqlConnection(Conexion.Cn);
            MySqlCommand SqlDat = new MySqlCommand(String.Format("SELECT * FROM " + table + " where id=" + p + " ORDER BY id DESC limit 1"), SqlCon);
            SqlCon.Open();
            MySqlDataReader dr = SqlDat.ExecuteReader(CommandBehavior.CloseConnection);
            DtResultado.Load(dr);
            dr.Close();
            SqlDat.Dispose();
            SqlCon.Close();
            return DtResultado;
        }



        internal static bool Insertar(MClientes objeto, facturacion.Vistas.VVentas form)
        {
            MySqlConnection SqlCon = new MySqlConnection(Conexion.Cn);
            try
            {
                SqlCon.Open();
                string query001 = "INSERT INTO " + table + "(nombre,ci,direccion,telefono,created_at) Values(@nombre,@ci,@direccion,@telefono,@created_at)";
                MySqlCommand command = new MySqlCommand(query001, SqlCon);
                command.Parameters.AddWithValue("@nombre", objeto.nombre);
                command.Parameters.AddWithValue("@ci", objeto.ci);
                command.Parameters.AddWithValue("@direccion", objeto.direccion);
                command.Parameters.AddWithValue("@telefono", objeto.telefono);
                command.Parameters.AddWithValue("@created_at", objeto.created_at);

                if (command.ExecuteNonQuery() == 1)
                {
                    ToastNotification.Show(form, "Cliente Creada Correctamente", global::facturacion.Properties.Resources.ok, 3000, (eToastGlowColor.Green), (eToastPosition.TopRight));
                    SqlCon.Close();
                    return true;
                }
                else
                {
                    ToastNotification.Show(form, "Cliente no pudo ser Creada", global::facturacion.Properties.Resources.error, 3000, (eToastGlowColor.Red), (eToastPosition.TopRight));
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
