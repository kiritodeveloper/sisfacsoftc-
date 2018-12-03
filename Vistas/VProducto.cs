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
    public partial class VProducto : UserControl
    {
        int id;
        public VProducto()
        {
            InitializeComponent();
            id = 0;
            botones(true,false,false,false,true);
            mostrar();
            habilitar(false);
        }

        public VProducto(DataTable Datos)
        {
            InitializeComponent();
            id = 0;
            botones(true, false, false, false, true);
            mostrar();
            habilitar(false);
            this.Datos = Datos;
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
                    pb_imagen.Image = newImagen(img, 250, 250);
                }
                catch (Exception er)
                {
                    ToastNotification.Show(this, "Al Parecer el formato cargado no es soportado", global::facturacion.Properties.Resources.Warning_sign, 3000, (eToastGlowColor.Red), (eToastPosition.TopCenter));
                }
            }
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
        private void botones(bool p1,bool p2,bool p3,bool p4,bool p5){
            btn_nuevo.Enabled = p1;
            btn_editar.Enabled = p2;
            btn_eliminar.Enabled = p3;
            btn_guardar.Enabled = p4;
            btn_cancelar.Enabled = p5;
        }
        private void habilitar(bool p) {
            tb_nombre.Enabled = p;
            tb_codigo.Enabled = p;
            tb_precio.Enabled = p;
            tb_unidad.Enabled = p;
            tb_descripcion.Enabled = p;
            btn_subir.Enabled = p;
        }
        private void limpiar()
        {
            tb_nombre.Text = string.Empty;
            tb_codigo.Text = string.Empty;
            tb_precio.Text = string.Empty;
            tb_unidad.Text = string.Empty;
            tb_descripcion.Text = string.Empty;
            this.pb_imagen.Image = global::facturacion.Properties.Resources.Gears;
        }
        private void mostrar() {
            DataTable dat = CProducto.Mostrar();
            lista_productos.DataSource = dat;
            lista_productos.Columns["id"].Visible = false;
            lista_productos.Columns["imagen"].Visible = false;
            lista_productos.Columns["unidad"].Visible = false;
            lista_productos.Columns["estado"].Visible = false;
            lista_productos.Columns["descripcion"].Visible = false;
            lista_productos.Columns["codigo"].Visible = false;
        }
        private void cargar() {
            id = Convert.ToInt32(this.lista_productos.CurrentRow.Cells["id"].Value);
            this.tb_nombre.Text = Convert.ToString(this.lista_productos.CurrentRow.Cells["nombre"].Value);
            this.tb_codigo.Text = Convert.ToString(this.lista_productos.CurrentRow.Cells["codigo"].Value);
            this.tb_precio.Text = Convert.ToString(this.lista_productos.CurrentRow.Cells["precio"].Value);
            this.tb_unidad.Text = Convert.ToString(this.lista_productos.CurrentRow.Cells["unidad"].Value);
            this.tb_descripcion.Text = Convert.ToString(this.lista_productos.CurrentRow.Cells["descripcion"].Value);
            try
            {
                if (this.lista_productos.CurrentRow.Cells["imagen"].Value != null)
                {
                    Image c = Image.FromFile(@"" + Application.StartupPath + this.lista_productos.CurrentRow.Cells["imagen"].Value.ToString());
                    pb_imagen.Image = newImagen(c, 150, 150);
                    
                }
                else
                {
                    this.pb_imagen.Image = global::facturacion.Properties.Resources.Gears;
                }
            }
            catch (Exception ee)
            {
                this.pb_imagen.Image = global::facturacion.Properties.Resources.Gears;
            }
        }
        private MetroBillCommands _Commands;
        private DataTable Datos;
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
                btn_cancelar.Command = newValue.ProductoCommands.Cancel;
            }
            else
            {
                btn_cancelar.Command = null;
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            habilitar(true);
            botones(true, false, false, true, true);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (id != 0) {
                if (MessageBox.Show("Estas seguro de eliminar este registro?", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                    if (CProducto.Eliminar(id, this)) {
                        botones(true,false,false,false,true);
                        habilitar(false);
                        mostrar();
                        id = 0;
                    }
                }
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            id = 0;
            botones(false,false,false,true,true);
            habilitar(true);
            limpiar();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (CValidar.ValidarProducto(tb_nombre, tb_codigo, tb_precio, errorIcono, this))
            {
                string time = DateTime.Now.ToString("yyyy_mm_dd hh_mm_ss");
                
                time = time.Replace(" ", "P");
                string dir =  "/img/producto/" + tb_nombre.Text + time + ".jpg";
                
                pb_imagen.Image.Save(@"" + Application.StartupPath + dir, ImageFormat.Jpeg);
                MProducto pro = new MProducto(0, tb_nombre.Text, tb_codigo.Text, tb_unidad.Text, Double.Parse(tb_precio.Text), tb_descripcion.Text, dir, "enable");
                if (id == 0)
                {
                    if (CProducto.Insertar(pro, this))
                    {
                        botones(false, false, false, true, true);
                        mostrar();
                        habilitar(true);
                        limpiar();
                        id = 0;
                    }
                }
                else
                {
                    if (CProducto.Editar(id, pro, this))
                    {
                        botones(true, false, false, false, true);
                        mostrar();
                        habilitar(true);
                        limpiar();
                        id = 0;
                    }
                }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            habilitar(false);
            botones(true,false,false,false,true);
        }

        private void lista_productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cargar();
            habilitar(false);
            botones(true,true,true,false,true);
        }

        private void lista_productos_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                case Keys.Up:
                    if (this.lista_productos.CurrentRow != null)
                    {
                        cargar();
                        habilitar(false);
                        botones(true, true, true, false,true);
                    }
                    break;
            }
        }

        private void tb_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tb_precio.Text.Contains(','))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == ',' || e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
        }

        private void tb_buscar_TextChanged(object sender, EventArgs e)
        {
            lista_productos.DataSource = CProducto.Buscar("nombre", tb_buscar.Text);
        }

        
    }
}
