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
    class CUsuarios
    {
        internal static String table = "usuarios";

        public static bool Editar(int id, MUsuario objeto, facturacion.Vistas.VUsuario form)
        {

            MySqlConnection SqlCon = new MySqlConnection(Conexion.Cn);
            try
            {
                SqlCon.Open();
                string query001 = "UPDATE " + table + " SET nombre=@nombre,ci=@ci,direccion=@direccion,telefono=@telefono,tipo=@tipo,estado=@estado,cuenta=@cuenta,password=@password where id=@id;";
                Console.WriteLine(query001);
                MySqlCommand command = new MySqlCommand(query001, SqlCon);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@nombre", objeto.nombre);
                command.Parameters.AddWithValue("@ci", objeto.ci);
                command.Parameters.AddWithValue("@direccion", objeto.direccion);
                command.Parameters.AddWithValue("@telefono", objeto.telefono);
                command.Parameters.AddWithValue("@tipo", objeto.tipo);
                command.Parameters.AddWithValue("@estado", objeto.estado);
                command.Parameters.AddWithValue("@cuenta", objeto.cuenta);
                command.Parameters.AddWithValue("@password", objeto.contraseña);
                if (command.ExecuteNonQuery() == 1)
                {
                    ToastNotification.Show(form, "Usuario Editada Correctamente", global::facturacion.Properties.Resources.ok, 3000, (eToastGlowColor.Green), (eToastPosition.TopRight));
                    SqlCon.Close();
                    return true;
                }
                else
                {
                    ToastNotification.Show(form, "El Usuario no pudo ser Editado", global::facturacion.Properties.Resources.error, 3000, (eToastGlowColor.Red), (eToastPosition.TopRight));
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
        public static bool Eliminar(int id, facturacion.Vistas.VUsuario form)
        {
            MySqlConnection SqlCon = new MySqlConnection(Conexion.Cn);
            try
            {
                SqlCon.Open();
                MySqlCommand command = new MySqlCommand(String.Format("UPDATE " + table + " SET estado='disable' where id='" + id + "';"), SqlCon);
                if (command.ExecuteNonQuery() == 1)
                {
                    ToastNotification.Show(form, " El usuario se dio de baja correctamente", global::facturacion.Properties.Resources.ok, 3000, (eToastGlowColor.Green), (eToastPosition.TopRight));
                    SqlCon.Close();
                    return true;
                }
                else
                {
                    ToastNotification.Show(form, "El usuario no se pudo dar de baja", global::facturacion.Properties.Resources.error, 3000, (eToastGlowColor.Red), (eToastPosition.TopRight));
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
            DataTable DtResultado = new DataTable("usuario");
            MySqlConnection SqlCon = new MySqlConnection(Conexion.Cn);
            MySqlCommand SqlDat = new MySqlCommand(String.Format("SELECT * FROM " + table + " ORDER BY nombre DESC;"), SqlCon);
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
            DataTable DtResultado = new DataTable("usuario");
            MySqlConnection SqlCon = new MySqlConnection(Conexion.Cn);
            MySqlCommand SqlDat = new MySqlCommand(String.Format("SELECT  * FROM " + table + " where estado='enable' AND " + buscarPor + " like '%" + variableAbuscar + "%' ORDER BY  nombre DESC;"), SqlCon);
            SqlCon.Open();
            MySqlDataReader dr = SqlDat.ExecuteReader(CommandBehavior.CloseConnection);
            DtResultado.Load(dr);
            dr.Close();
            SqlDat.Dispose();
            SqlCon.Close();
            return DtResultado;
        }

        internal static bool Insertar(MUsuario objeto, facturacion.Vistas.VUsuario form)
        {
            MySqlConnection SqlCon = new MySqlConnection(Conexion.Cn);
            try
            {
                SqlCon.Open();
                string query001 = "INSERT INTO " + table + "(nombre,ci,direccion,telefono,tipo,estado,cuenta,password) Values(@nombre,@ci,@direccion,@telefono,@tipo,@estado,@cuenta,@password)";
                MySqlCommand command = new MySqlCommand(query001, SqlCon);
                command.Parameters.AddWithValue("@nombre", objeto.nombre);
                command.Parameters.AddWithValue("@ci", objeto.ci);
                command.Parameters.AddWithValue("@direccion", objeto.direccion);
                command.Parameters.AddWithValue("@telefono", objeto.telefono);
                command.Parameters.AddWithValue("@tipo", objeto.tipo);
                command.Parameters.AddWithValue("@estado", objeto.estado);
                command.Parameters.AddWithValue("@cuenta", objeto.cuenta);
                command.Parameters.AddWithValue("@password", objeto.contraseña);


                if (command.ExecuteNonQuery() == 1)
                {
                    ToastNotification.Show(form, "Usuario Creada Correctamente", global::facturacion.Properties.Resources.ok, 3000, (eToastGlowColor.Green), (eToastPosition.TopRight));
                    SqlCon.Close();
                    return true;
                }
                else
                {
                    ToastNotification.Show(form, "Usuario no pudo ser Creada", global::facturacion.Properties.Resources.error, 3000, (eToastGlowColor.Red), (eToastPosition.TopRight));
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



        internal static DataTable LogindeUsuario(string p, string pasengript)
        {

            String cad = "SELECT usuarios.id,usuarios.nombre,usuarios.tipo,usuarios.ci, usuarios.password, usuarios.cuenta FROM usuarios where usuarios.estado='enable' AND usuarios.cuenta='" + p + "' AND usuarios.password='" + pasengript + "' ORDER BY usuarios.id DESC LIMIT 1;";
            DataTable DtResultado = new DataTable("usuario");
            MySqlConnection SqlCon = new MySqlConnection(Conexion.Cn);
            MySqlCommand SqlDat = new MySqlCommand((cad), SqlCon);
            SqlCon.Open();
            MySqlDataReader dr = SqlDat.ExecuteReader(CommandBehavior.CloseConnection);
            DtResultado.Load(dr);
            dr.Close();
            SqlDat.Dispose();
            SqlCon.Close();
            return DtResultado;
        }

        internal static void Actualizar(MUsuario mu, facturacion.Vistas.FormPerfil form)
        {
            MySqlConnection SqlCon = new MySqlConnection(Conexion.Cn);
            try
            {
                SqlCon.Open();
                string query001 = "UPDATE " + table + " SET cuenta=@cuenta,password=@password where id=@id;";
                Console.WriteLine(query001);
                MySqlCommand command = new MySqlCommand(query001, SqlCon);
                command.Parameters.AddWithValue("@id", mu.id);
                command.Parameters.AddWithValue("@cuenta", mu.cuenta);
                command.Parameters.AddWithValue("@password", mu.contraseña);
                if (command.ExecuteNonQuery() == 1)
                {
                    ToastNotification.Show(form, "Actualizacion Correcta", global::facturacion.Properties.Resources.ok, 3000, (eToastGlowColor.Green), (eToastPosition.TopRight));
                    SqlCon.Close();
                }
                else
                {
                    ToastNotification.Show(form, "Error en la actulizacion", global::facturacion.Properties.Resources.error, 3000, (eToastGlowColor.Red), (eToastPosition.TopRight));
                    SqlCon.Close();
                }
            }
            catch (MySqlException e)
            {
                ToastNotification.Show(form, e.Message, global::facturacion.Properties.Resources.error, 3000, (eToastGlowColor.Red), (eToastPosition.TopLeft));
            }
        }
    }
}
