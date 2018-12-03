using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Controladores;
using Modelos;

namespace facturacion.Vistas
{
    public partial class FormPerfil : DevComponents.DotNetBar.Metro.MetroForm
    {
        private DataTable Datos;

        public FormPerfil()
        {
            InitializeComponent();
            tb_user.Text = Datos.Rows[0]["cuenta"].ToString();
            tb_user.Enabled = false;
        }

        public FormPerfil(DataTable Datos)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.Datos = Datos;
            lb_nombre.Text = Datos.Rows[0]["nombre"].ToString();
            lb_ci.Text = Datos.Rows[0]["ci"].ToString();
            lb_tipo.Text = Datos.Rows[0]["tipo"].ToString();
            lb_cuenta.Text = Datos.Rows[0]["cuenta"].ToString();
            lb_password.Text = Datos.Rows[0]["password"].ToString();
            tb_user.Text = Datos.Rows[0]["cuenta"].ToString();
            tb_user.Enabled = false;
        }


        private void lb_password_MouseMove(object sender, MouseEventArgs e)
        {
            lb_password.Text = "Solo tú lo sabes";
        }

        private void lb_password_MouseLeave(object sender, EventArgs e)
        {
            lb_password.Text = Datos.Rows[0]["password"].ToString();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (Datos.Rows[0]["password"].ToString().CompareTo(CValidar.Encrypt(this.tb_p1.Text)) != 0)
            {
                ToastNotification.Show(this, "La contraseña actual no es correcta", global::facturacion.Properties.Resources.Warning_sign, 3000, (eToastGlowColor.Red), (eToastPosition.TopRight));
                return;
            }
            if (tb_p2.Text.CompareTo(tb_p3.Text) != 0)
            {
                ToastNotification.Show(this, "Error en la nueva contraseña, no coinciden.", global::facturacion.Properties.Resources.Warning_sign, 3000, (eToastGlowColor.Red), (eToastPosition.TopRight));
                return;
            }
            else {
                MUsuario mu = new MUsuario(int.Parse(Datos.Rows[0]["id"].ToString()),"","","","","","",tb_user.Text,CValidar.Encrypt(tb_p2.Text));
                CUsuarios.Actualizar(mu,this);
                tb_p1.Text = "";
                tb_p2.Text = "";
                tb_p3.Text = "";
            }
        }

        private void tb_p1_TextChanged(object sender, EventArgs e)
        {
            if (Datos.Rows[0]["password"].ToString().CompareTo(CValidar.Encrypt(this.tb_p1.Text)) == 0)
            {
                errorIcono.SetError(tb_p1, "Correcto");
            }
            else {
                errorIcono.Clear();
            }
        }
    }
}