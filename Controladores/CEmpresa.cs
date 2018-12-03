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
    class CEmpresa
    {
        internal static String table = "empresas";
        public static bool Insertar(MEmpresa objeto, facturacion.Vistas.Empresa form)
        {

            MySqlConnection SqlCon = new MySqlConnection(Conexion.Cn);
            try
            {
                SqlCon.Open();
                string query001 = "INSERT INTO " + table + "(nombre,nit,logo,direccion,telefono,sigla,nomPropietario) Values(@nombre,@nit,@logo,@direccion,@telefono,@sigla,@nomPropietario)";
                MySqlCommand command = new MySqlCommand(query001, SqlCon);
                command.Parameters.AddWithValue("@nombre", objeto.nombre);
                command.Parameters.AddWithValue("@nit", objeto.nit);
                command.Parameters.AddWithValue("@logo", objeto.logo);
                command.Parameters.AddWithValue("@direccion", objeto.direccion);
                command.Parameters.AddWithValue("@telefono", objeto.telefono);
                command.Parameters.AddWithValue("@sigla", objeto.sigla);
                command.Parameters.AddWithValue("@nomPropietario", objeto.nomPropietario);


                if (command.ExecuteNonQuery() == 1)
                {
                    ToastNotification.Show(form, "Empresa Creada Correctamente", global::facturacion.Properties.Resources.ok, 3000, (eToastGlowColor.Green), (eToastPosition.TopRight));
                    SqlCon.Close();
                    return true;
                }
                else
                {
                    ToastNotification.Show(form, "La empresa no pudo ser Creada", global::facturacion.Properties.Resources.error, 3000, (eToastGlowColor.Red), (eToastPosition.TopRight));
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
        public static bool Editar(int id, MEmpresa objeto, facturacion.Vistas.Empresa form)
        {

            MySqlConnection SqlCon = new MySqlConnection(Conexion.Cn);
            try
            {
                SqlCon.Open();
                string query001 = "UPDATE " + table + " SET nombre=@nombre,nit=@nit,logo=@logo,direccion=@direccion,telefono=@telefono,sigla=@sigla,nomPropietario=@nomPropietario where id=@id;";
                Console.WriteLine(query001);
                MySqlCommand command = new MySqlCommand(query001, SqlCon);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@nombre", objeto.nombre);
                
                command.Parameters.AddWithValue("@nit", objeto.nit);
                command.Parameters.AddWithValue("@logo", objeto.logo);
                command.Parameters.AddWithValue("@direccion", objeto.direccion);
                command.Parameters.AddWithValue("@telefono", objeto.telefono);
                command.Parameters.AddWithValue("@sigla", objeto.sigla);
                command.Parameters.AddWithValue("@nomPropietario", objeto.nomPropietario);
                if (command.ExecuteNonQuery() == 1)
                {
                    ToastNotification.Show(form, "Empresa Editada Correctamente", global::facturacion.Properties.Resources.ok, 3000, (eToastGlowColor.Green), (eToastPosition.TopRight));
                    SqlCon.Close();
                    return true;
                }
                else
                {
                    ToastNotification.Show(form, "La empresa no pudo ser Editado", global::facturacion.Properties.Resources.error, 3000, (eToastGlowColor.Red), (eToastPosition.TopRight));
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
        public static bool Eliminar(int id, facturacion.Vistas.Empresa form)
        {
            MySqlConnection SqlCon = new MySqlConnection(Conexion.Cn);
            try
            {
                SqlCon.Open();
                MySqlCommand command = new MySqlCommand(String.Format("UPDATE " + table + " SET estado='disable' where id='" + id + "';"), SqlCon);
                if (command.ExecuteNonQuery() == 1)
                {
                    ToastNotification.Show(form, " La empresa se elimino correctamente", global::facturacion.Properties.Resources.ok, 3000, (eToastGlowColor.Green), (eToastPosition.TopRight));
                    SqlCon.Close();
                    return true;
                }
                else
                {
                    ToastNotification.Show(form, "La empresa no se pudo eliminar", global::facturacion.Properties.Resources.error, 3000, (eToastGlowColor.Red), (eToastPosition.TopRight));
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
            DataTable DtResultado = new DataTable("empresa");
            MySqlConnection SqlCon = new MySqlConnection(Conexion.Cn);
            MySqlCommand SqlDat = new MySqlCommand(String.Format("SELECT * FROM " + table + ";"), SqlCon);
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
            DataTable DtResultado = new DataTable("empresa");
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
