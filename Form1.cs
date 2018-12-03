using Controladores;
using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace facturacion
{
    public partial class Form1 : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        

        public Form1()
        {
            InitializeComponent();
        }


        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxX2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Enter))
            {
                login();
            }
        }

        private void login()
        {
            try
            {
                if (!CValidar.ValidarLogin(this.tb_user, this.tb_password, errorIcono))
                {
                    return;
                }

                if (this.tb_password.Text != string.Empty && this.tb_user.Text != string.Empty)
                {

                    string pasengript = CValidar.Encrypt(this.tb_password.Text);
                    DataTable Datos = CUsuarios.LogindeUsuario(this.tb_user.Text, pasengript);
                    if (Datos.Rows.Count != 0)
                    {
                        this.Hide();
                        MainForm form = new MainForm(this, Datos);
                        form.Visible = true;
                    }
                    else
                    {
                        ToastNotification.Show(this, "NO TIENE ACCESO AL SISTEMA", global::facturacion.Properties.Resources.error, 2000, (eToastGlowColor.Red), (eToastPosition.TopCenter));
                    }
                }
            }
            catch (Exception exp)
            {
                ToastNotification.Show(this, exp.Message, global::facturacion.Properties.Resources.error, 3000, (eToastGlowColor.Red), (eToastPosition.TopCenter));
            }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            login();
        }
    }
}
