using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Controladores;
using Modelos;
using System.Drawing.Imaging;
namespace facturacion.Vistas
{
    public partial class Empresa : UserControl
    {
        int id;
        public Empresa()
        {
            InitializeComponent();
            btn_editar.Enabled = false;
            id = 0;
            Mostrar();
            
        }

        private void Mostrar()
        {
            DataTable info = CEmpresa.Mostrar();
            if (info.Rows.Count > 0)
            {
                tb_nombre.Text = info.Rows[0]["nombre"].ToString();
                tb_nit.Text = info.Rows[0]["nit"].ToString();
                tb_propietario.Text = info.Rows[0]["nomPropietario"].ToString();
                tb_sigla.Text = info.Rows[0]["sigla"].ToString();
                tb_direccion.Text = info.Rows[0]["direccion"].ToString();
                tb_telefono.Text = info.Rows[0]["telefono"].ToString();
                id = int.Parse(info.Rows[0]["id"].ToString());
                Image c = Image.FromFile(@"" + Application.StartupPath + info.Rows[0]["logo"].ToString());
                pb_empresa.Image = newImagen(c, 250, 250);
                btn_editar.Enabled = true;
                btn_guardar.Enabled = false;
                habilitar(false);
            }
            else
            {
                btn_guardar.Enabled = true;
                btn_editar.Enabled = false;
                habilitar(true);
            }
        }

        

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (CValidar.ValidarEmpresa(tb_nombre, tb_nit, tb_propietario, errorIcono, this))
            {
                string time = DateTime.Now.ToString("yyyy_mm_dd hh_mm_ss");

                time = time.Replace(" ", "P");
                string dir = "/img/empresa/empresa"+time+".jpg";
                pb_empresa.Image.Save(@"" + Application.StartupPath + dir, ImageFormat.Jpeg);
                MEmpresa empresa = new MEmpresa(tb_nombre.Text,tb_nit.Text,dir,tb_direccion.Text,tb_telefono.Text,tb_sigla.Text,tb_propietario.Text);
                if (id != 0)
                {
                    if (CEmpresa.Editar(id,empresa, this))
                    {
                        btn_editar.Enabled = true;
                        btn_guardar.Enabled = false;
                        habilitar(false);
                    }
                }
                else {
                    if (CEmpresa.Insertar(empresa, this))
                    {
                        btn_editar.Enabled = true;
                        btn_guardar.Enabled = false;
                        habilitar(false);
                    }
                }
                
            }
        }

        private void habilitar(bool p)
        {
            tb_nombre.Enabled = p;
            tb_nit.Enabled = p;
            tb_propietario.Enabled = p;
            tb_sigla.Enabled = p;
            tb_direccion.Enabled = p;
            tb_telefono.Enabled = p;
            btn_subir.Enabled = p;
        }
        public static Image newImagen(Image pImagen, int pAncho, int pAlto)
        {
            Bitmap vBitmap = new Bitmap(pAncho, pAlto);
            using (Graphics vGraphics = Graphics.FromImage((Image)vBitmap))
            {
                vGraphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                vGraphics.DrawImage(pImagen, 0, 0, pAncho, pAlto);
            }
            return (Image)vBitmap;
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            habilitar(true);
            btn_guardar.Enabled = true;
        }

        

        private void btn_subir_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    Image img = Image.FromFile(dialog.FileName);
                    pb_empresa.Image = newImagen(img, 150, 150);
                }
                catch (Exception er)
                {
                    ToastNotification.Show(this, "Al Parecer el formato cargado no es soportado", global::facturacion.Properties.Resources.Warning_sign, 3000, (eToastGlowColor.Red), (eToastPosition.TopCenter));
                }
            }
        }

        private MetroBillCommands _Commands;
        public MetroBillCommands Commands
        {
            get { return _Commands; }
            set
            {
                if (value != _Commands)
                {
                    MetroBillCommands oldValue = _Commands;
                    _Commands = value;
                    OnCommandsChanged(oldValue, value);
                }
            }
        }
        protected virtual void OnCommandsChanged(MetroBillCommands oldValue, MetroBillCommands newValue)
        {
            if (newValue != null)
            {
                btn_cancelar.Command = newValue.EmpresaCommands.Cancel;
            }
            else
            {
                btn_cancelar.Command = null;
            }
        }
    }
}
