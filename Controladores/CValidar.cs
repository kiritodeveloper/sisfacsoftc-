using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.RegularExpressions;
using System.Security.Cryptography;

using System.IO;
using System.Data;
namespace Controladores
{
    class CValidar
    {
        public static string Encrypt(string inputText)
        {
            string password = "abcdeghijklmnopqrstuvwxyz1234567890=()[]{}.,!#%$&/?¿";
            string encryptedData = string.Empty;
            using (RijndaelManaged rij = new RijndaelManaged())
            {
                byte[] inputBytes = Encoding.Unicode.GetBytes(inputText);
                byte[] salt = Encoding.UTF8.GetBytes(password.Length.ToString());
                PasswordDeriveBytes secretKey = new PasswordDeriveBytes(password, salt);
                ICryptoTransform encryptor = rij.CreateEncryptor(secretKey.GetBytes(32), secretKey.GetBytes(16));
                using (MemoryStream ms = new MemoryStream())
                {
                    CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write);
                    cs.Write(inputBytes, 0, inputBytes.Length);
                    cs.FlushFinalBlock();
                    byte[] cipherBytes = ms.ToArray();
                    encryptedData = Convert.ToBase64String(cipherBytes);
                }
            }
            return encryptedData;
        }
        public static bool ValidarLogin(TextBox txtuser, TextBox txtpassword, ErrorProvider errorIcono)
        {
            if (txtuser.Text == string.Empty)
            {
                errorIcono.SetError(txtuser, "Ingrese su usuario");
                return false;
            }
            else
            {
                errorIcono.Clear();
            }
            if (txtpassword.Text == string.Empty)
            {
                errorIcono.SetError(txtpassword, "Ingrese su contraseña");
                return false;
            }
            else
            {
                errorIcono.Clear();
            }
            return true;
        }
        
        internal static bool ValidarEmpresa(DevComponents.DotNetBar.Controls.TextBoxX tb_nombre, DevComponents.DotNetBar.Controls.TextBoxX tb_nit, DevComponents.DotNetBar.Controls.TextBoxX tb_propietario, ErrorProvider errorIcono, facturacion.Vistas.Empresa empresa)
        {
            if (tb_nombre.Text == string.Empty)
            {
                errorIcono.SetError(tb_nombre, "El nombre de la empresa es necesario");
                ToastNotification.Show(empresa, "El nombre de la empresa es necesario", global::facturacion.Properties.Resources.Warning_sign, 3000, (eToastGlowColor.Red), (eToastPosition.TopRight));
                return false;
            }
            else
            {
                errorIcono.Clear();
            }
            if (tb_nit.Text == string.Empty)
            {
                errorIcono.SetError(tb_nit, "Nro. de Identificacion tributaria es necesario");
                ToastNotification.Show(empresa, "Nro. de Identificacion tributaria es necesario", global::facturacion.Properties.Resources.Warning_sign, 3000, (eToastGlowColor.Red), (eToastPosition.TopRight));
                return false;
            }
            else
            {
                errorIcono.Clear();
            }
            if (tb_nit.Text == string.Empty)
            {
                errorIcono.SetError(tb_nit, "Nro. de Identificacion tributaria es necesario");
                ToastNotification.Show(empresa, "Nro. de Identificacion tributaria es necesario", global::facturacion.Properties.Resources.Warning_sign, 3000, (eToastGlowColor.Red), (eToastPosition.TopRight));
                return false;
            }
            else
            {
                errorIcono.Clear();
            }
            if (tb_propietario.Text == string.Empty)
            {
                errorIcono.SetError(tb_propietario, "Nombre del propietario es necesario");
                ToastNotification.Show(empresa, "Nombre del propietario es necesario", global::facturacion.Properties.Resources.Warning_sign, 3000, (eToastGlowColor.Red), (eToastPosition.TopRight));
                return false;
            }
            else
            {
                errorIcono.Clear();
            }
            return true;
        }



        internal static bool ValidarProducto(DevComponents.DotNetBar.Controls.TextBoxX tb_nombre, DevComponents.DotNetBar.Controls.TextBoxX tb_codigo, DevComponents.DotNetBar.Controls.TextBoxX tb_precio, ErrorProvider errorIcono, facturacion.Vistas.VProducto vProducto)
        {
            if (tb_nombre.Text == string.Empty)
            {
                errorIcono.SetError(tb_nombre, "El nombre del producto es necesario");
                ToastNotification.Show(vProducto, "El nombre del producto es necesario", global::facturacion.Properties.Resources.Warning_sign, 3000, (eToastGlowColor.Red), (eToastPosition.TopRight));
                return false;
            }
            else
            {
                errorIcono.Clear();
            }
            if (tb_codigo.Text == string.Empty)
            {
                errorIcono.SetError(tb_codigo, "El codigo es necesario");
                ToastNotification.Show(vProducto, "El codigo es necesario", global::facturacion.Properties.Resources.Warning_sign, 3000, (eToastGlowColor.Red), (eToastPosition.TopRight));
                return false;
            }
            else
            {
                errorIcono.Clear();
            }
            if (tb_precio.Text == string.Empty)
            {
                errorIcono.SetError(tb_precio, "El precio es necesario");
                ToastNotification.Show(vProducto, "El precio es necesario", global::facturacion.Properties.Resources.Warning_sign, 3000, (eToastGlowColor.Red), (eToastPosition.TopRight));
                return false;
            }
            else
            {
                errorIcono.Clear();
            }
            return true;
        }

        internal static bool ValidarUsuario(DevComponents.DotNetBar.Controls.TextBoxX tb_nombre, DevComponents.DotNetBar.Controls.TextBoxX tb_ci, DevComponents.DotNetBar.Controls.ComboBoxEx cb_tipo, DevComponents.DotNetBar.Controls.TextBoxX tb_usuario, ErrorProvider errorIcono, facturacion.Vistas.VUsuario vUsuario)
        {
            if (tb_nombre.Text == string.Empty)
            {
                errorIcono.SetError(tb_nombre, "El nombre del usuario es necesario");
                ToastNotification.Show(vUsuario, "El nombre del usuario es necesario", global::facturacion.Properties.Resources.Warning_sign, 3000, (eToastGlowColor.Red), (eToastPosition.TopRight));
                return false;
            }
            else
            {
                errorIcono.Clear();
            }
            if (tb_ci.Text == string.Empty)
            {
                errorIcono.SetError(tb_nombre, "El ci del usuario es necesario");
                ToastNotification.Show(vUsuario, "El ci del usuario es necesario", global::facturacion.Properties.Resources.Warning_sign, 3000, (eToastGlowColor.Red), (eToastPosition.TopRight));
                return false;
            }
            else
            {
                errorIcono.Clear();
            }
            if (cb_tipo.Text == string.Empty)
            {
                errorIcono.SetError(tb_nombre, "El tipo de usuario es necesario");
                ToastNotification.Show(vUsuario, "El tipo de usuario es necesario", global::facturacion.Properties.Resources.Warning_sign, 3000, (eToastGlowColor.Red), (eToastPosition.TopRight));
                return false;
            }
            else
            {
                errorIcono.Clear();
            }
            if (tb_usuario.Text == string.Empty)
            {
                errorIcono.SetError(tb_nombre, "El usuario es necesario");
                ToastNotification.Show(vUsuario, "El usuario es necesario", global::facturacion.Properties.Resources.Warning_sign, 3000, (eToastGlowColor.Red), (eToastPosition.TopRight));
                return false;
            }
            else
            {
                errorIcono.Clear();
            }
            return true;
        }

        internal static bool ValidarCliente(DevComponents.DotNetBar.Controls.TextBoxX tb_nombre, DevComponents.DotNetBar.Controls.TextBoxX tb_ci, System.Windows.Forms.ErrorProvider errorIcono, facturacion.Vistas.VCliente vCliente)
        {
            if (tb_nombre.Text == string.Empty)
            {
                errorIcono.SetError(tb_nombre, "El nombre del usuario es necesario");
                ToastNotification.Show(vCliente, "El nombre del usuario es necesario", global::facturacion.Properties.Resources.Warning_sign, 3000, (eToastGlowColor.Red), (eToastPosition.TopRight));
                return false;
            }
            else
            {
                errorIcono.Clear();
            }
            if (tb_ci.Text == string.Empty)
            {
                errorIcono.SetError(tb_nombre, "El ci del usuario es necesario");
                ToastNotification.Show(vCliente, "El ci del usuario es necesario", global::facturacion.Properties.Resources.Warning_sign, 3000, (eToastGlowColor.Red), (eToastPosition.TopRight));
                return false;
            }
            else
            {
                errorIcono.Clear();
            }
            return true;
        }

        
    }
}
