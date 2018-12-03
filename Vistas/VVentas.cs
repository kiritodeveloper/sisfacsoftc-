using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladores;
using Modelos;
using System.Drawing.Imaging;
using DevComponents.DotNetBar;
using Microsoft.Reporting.WinForms;

namespace facturacion.Vistas
{
    public partial class VVentas : UserControl
    {
        DataTable aux;
        int posiscion;
        int numero_next;
        public VVentas()
        {
            InitializeComponent();
            DataTable info = CEmpresa.Mostrar();
            if (info.Rows.Count > 0)
            {
                lb_nombreEmpresa.Text = info.Rows[0]["nombre"].ToString();
                //lb_autorizacion.Text = info.Rows[0]["numAutorizacion"].ToString();
                lb_nit.Text = info.Rows[0]["nit"].ToString();
                Image c = Image.FromFile(@"" + Application.StartupPath + info.Rows[0]["logo"].ToString());
                pb_imagen_empresa.Image = newImagen(c, 350, 350);
            }
            DataTable nro = CVenta.Mostrar();
            if (nro.Rows.Count > 0)
            {
                lb_numero.Text = nro.Rows[0]["id"].ToString();
            }
            else {
                lb_numero.Text = "0";
            }
            DataTable product=CProducto.Mostrar();
            mClientesBindingSource.DataSource = CCliente.mostrar();
            mProductoBindingSource.DataSource = product;
            if (product.Rows.Count > 0)
            {
                MessageBox.Show(product.Rows[0]["nombre"].ToString());
                tb_extra.Text = product.Rows[0]["nombre"].ToString();
            }
            else {
                btn_añadir.Enabled = false;
            }
            tb_nombreAp.Enabled = false;
            btn_guardar.Enabled = false;
            lista.MouseClick += new MouseEventHandler(lista_productos_mouseclick);
            

        }

        public VVentas(DataTable Datos)
        {
            InitializeComponent();
            DataTable info = CEmpresa.Mostrar();
            if (info.Rows.Count > 0)
            {
                lb_nombreEmpresa.Text = info.Rows[0]["nombre"].ToString();
                //lb_autorizacion.Text = info.Rows[0]["numAutorizacion"].ToString();
                lb_nit.Text = info.Rows[0]["nit"].ToString();
                Image c = Image.FromFile(@"" + Application.StartupPath + info.Rows[0]["logo"].ToString());
                pb_imagen_empresa.Image = newImagen(c, 350, 350);
            }
            DataTable nro = CVenta.Mostrar();
            if (nro.Rows.Count > 0)
            {
                lb_numero.Text = nro.Rows[0]["id"].ToString();
            }
            else
            {
                lb_numero.Text = "0";
            }
            DataTable product = CProducto.Mostrar();
            mClientesBindingSource.DataSource = CCliente.mostrar();
            mProductoBindingSource.DataSource = product;
            if (product.Rows.Count > 0)
            {
                tb_extra.Text = product.Rows[0]["nombre"].ToString();
            }
            else
            {
                btn_añadir.Enabled = false;
            }
            tb_nombreAp.Enabled = false;
            btn_guardar.Enabled = false;
            lista.MouseClick += new MouseEventHandler(lista_productos_mouseclick);
            DataTable ult = CVenta.ultimofecha();
            if (ult.Rows.Count == 0)
            {
                numero_next = 1;
            }
            else {
                numero_next = Int32.Parse(ult.Rows[0]["numero"].ToString());
                numero_next++;
            }
            this.Datos = Datos;
        }

        private void lista_productos_mouseclick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                ContextMenuStrip menu = new ContextMenuStrip();
                this.posiscion = lista.HitTest(e.X, e.Y).RowIndex;
                if (posiscion >= 0)
                {
                    menu.Items.Add("ELIMINAR").Name = "eliminar";
                }
                menu.Show(lista.PointToScreen(e.Location));
                menu.ItemClicked += new ToolStripItemClickedEventHandler(menu_ItemClicked);

            }
        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            lista.Rows.RemoveAt(this.posiscion);
            calcluar_total();
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

        private void labelX10_Click(object sender, EventArgs e)
        {

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
                btn_cancelar.Command = newValue.VentaCommands.Cancel;
            }
            else
            {
                btn_cancelar.Command = null;
            }
        }

        private void cb_ci_nit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_ci_nit.SelectedItem != null)
            {
                DataRowView row = (DataRowView)cb_ci_nit.SelectedItem;
                tb_nombreAp.Text = row.Row.ItemArray[1].ToString();
                btn_guardar.BackColor = System.Drawing.Color.Transparent;
                btn_guardar.Enabled = false;
            }
        }

        private void cb_ci_nit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string cad=cb_ci_nit.Text.ToString();
                if (cad == "-" || cad == "." || cad == "*") {
                    tb_nombreAp.Text = "?";
                    return;
                }

                aux = CCliente.BuscarCI(cb_ci_nit.Text.ToString());

                if (aux.Rows.Count == 0)
                {
                    MessageBox.Show("El CI/Nit no esta registrado.\n Registre el Nombre y guardelo.");
                    btn_guardar.BackColor = System.Drawing.Color.Blue;
                    btn_guardar.Enabled = true;
                    tb_nombreAp.Text = "";
                    tb_nombreAp.Enabled = true;
                    tb_nombreAp.Focus();
                }
            }
        }

        private void cb_producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_producto.SelectedItem != null)
            {
                DataRowView row = (DataRowView)cb_producto.SelectedItem;
                db_precio.Text = row.Row.ItemArray[4].ToString() ;
                tb_descripcion.Text = row.Row.ItemArray[5].ToString();
                tb_extra.Text = row.Row.ItemArray[1].ToString();
                Image c = Image.FromFile(@"" + Application.StartupPath + row.Row.ItemArray[6].ToString());
                pb_imagen_producto.Image = newImagen(c, 250, 250);
            }
        }

        string[] new_row = null;
        private DataTable Datos;
        private void btn_añadir_Click(object sender, EventArgs e)
        {
            aux = CCliente.BuscarCI(cb_ci_nit.Text.ToString());

            if (aux.Rows.Count == 1)
            {
                DataRow row_cliente = aux.Rows[0];
            }
            if (cb_producto.SelectedItem != null)
            {
                DataRowView row_producto = (DataRowView)cb_producto.SelectedItem;
                Double total = Double.Parse(db_precio.Text) * Double.Parse(this.tb_cantidad.Text);
                string descripcion = tb_extra.Text;
                
                new_row = new string[] { row_producto.Row.ItemArray[0].ToString(), row_producto.Row.ItemArray[2].ToString(), this.tb_cantidad.Text, descripcion, db_precio.Text, total.ToString() };
                lista.Rows.Insert(0, new_row);
                calcluar_total();
            }
        }

        private void calcluar_total()
        {
            double sum = 0.0;
            foreach (System.Windows.Forms.DataGridViewRow row in lista.Rows)
            {
                string[] cad = row.Cells["total"].Value.ToString().Split(' ');
                sum += (Double.Parse(cad[0]));
            }
            this.lb_total_importe.Text = sum.ToString();
        }

        private void VVentas_Load(object sender, EventArgs e)
        {
            if (cb_producto.SelectedItem != null)
            {
                DataRowView row = (DataRowView)cb_producto.SelectedItem;
                db_precio.Text = row.Row.ItemArray[4].ToString();
                
                tb_descripcion.Text = row.Row.ItemArray[5].ToString();
                Image c = Image.FromFile(@"" + Application.StartupPath + row.Row.ItemArray[6].ToString());
                pb_imagen_producto.Image = newImagen(c, 250, 250);
                
            }
            lb_fecActual.Text = DateTime.Now.ToString("yyyy/MM/dd");

        }

        private void btn_cobrar_Click(object sender, EventArgs e)
        {
            
            if (lista.Rows.Count == 0) {
                ToastNotification.Show(this, "Añade un producto antes de cobrar.", global::facturacion.Properties.Resources.error, 3000, (eToastGlowColor.Red), (eToastPosition.TopRight));
                return;
            }
            if(MessageBox.Show("Esta Apunto de Cobrar el monto de " + lb_total_importe.Text + ".", "COBRAR PEDIDO", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes){
                    aux = CCliente.BuscarCI(cb_ci_nit.Text.ToString());
                    if (aux.Rows.Count >= 1 && lista.Rows.Count > 0)
                    {
                        DataRow row_cliente = aux.Rows[0];
                        Numeracion num = new Numeracion();
                        MVentas venta = new MVentas(0, int.Parse(row_cliente["id"].ToString()),int.Parse(Datos.Rows[0]["id"].ToString()), DateTime.Now, Double.Parse(lb_total_importe.Text), num.Convertir(lb_total_importe.Text, true), "pedido", "cancelado",numero_next);
                        long id_now = CVenta.Insertar(venta, this);
                        if (id_now != (-1))
                        {

                            foreach (DataGridViewRow r in lista.Rows)
                            {
                                string precio_total = r.Cells["total"].Value.ToString();
                                string cantidad = r.Cells["cantidad"].Value.ToString();
                                string unitario = r.Cells["precio"].Value.ToString();
                                string descripcion = r.Cells["descripcion"].Value.ToString();
                                int id = Convert.ToInt32(r.Cells["id"].Value);
                                MDetalleVenta det = new MDetalleVenta(0, id, double.Parse(cantidad), (int)id_now, Double.Parse(precio_total), descripcion, Double.Parse(unitario));
                                if (CDetalleVenta.Insertar(det, this))
                                {

                                }
                            }

                            try
                            {
                                LocalReport rdlc = new LocalReport();
                                rdlc.ReportPath = @"..\..\Vistas\Report1.rdlc";
                                rdlc.ReportEmbeddedResource = "facturacion.Vistas.Report1.rdlc";
                                DataTable customer = CDetalleVenta.Mostrar((int)id_now);
                                rdlc.DataSources.Add(new ReportDataSource("DataSet1", customer));
                                DataTable venta2 = CVenta.MostrarID(id_now);
                                DataTable infomacion = CEmpresa.Mostrar();
                                DataTable cliente = CCliente.MostrarID(venta2.Rows[0]["idCliente"].ToString());
                                ReportParameter nombre = new ReportParameter("nombre_cliente", cliente.Rows[0]["nombre"].ToString());
                                ReportParameter fecha = new ReportParameter("fecha", venta2.Rows[0]["fecVenta"].ToString());
                                ReportParameter numero = new ReportParameter("numero", numero_next.ToString());
                                rdlc.SetParameters(new ReportParameter[] { nombre, fecha, numero });
                                Impresor imp = new Impresor();
                                imp.Imprime(rdlc);
                                limpiar();
                            }
                            catch (Exception exp)
                            {
                                ToastNotification.Show(this, exp.Message, global::facturacion.Properties.Resources.Warning_sign, 3000, (eToastGlowColor.Red), (eToastPosition.TopRight));
                                if (MessageBox.Show("Ha ocurrido un error al imprimir, Desea volver a imprimir el pedido??", "ERROR AL FACTURAR!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    LocalReport rdlc = new LocalReport();
                                    rdlc.ReportPath = @"..\..\Vistas\Report1.rdlc";
                                    rdlc.ReportEmbeddedResource = "facturacion.Vistas.Report1.rdlc";
                                    DataTable customer = CDetalleVenta.Mostrar((int)id_now);
                                    rdlc.DataSources.Add(new ReportDataSource("DataSet1", customer));
                                    DataTable venta2 = CVenta.MostrarID(id_now);
                                    DataTable infomacion = CEmpresa.Mostrar();
                                    DataTable cliente = CCliente.MostrarID(venta2.Rows[0]["idCliente"].ToString());
                                    ReportParameter nombre = new ReportParameter("nombre_cliente", cliente.Rows[0]["nombre"].ToString());
                                    ReportParameter fecha = new ReportParameter("fecha", venta2.Rows[0]["fecVenta"].ToString());
                                    ReportParameter numero = new ReportParameter("numero", numero_next.ToString());
                                    rdlc.SetParameters(new ReportParameter[] { nombre, fecha, numero });
                                    Impresor imp = new Impresor();
                                    imp.Imprime(rdlc);
                                    limpiar();
                                }
                            }
                            numero_next++;
                        }
                    }
                    else {
                        MessageBox.Show("El CI/Nit no esta registrado.\n Registre el Nombre y guardelo.");
                        btn_guardar.BackColor = System.Drawing.Color.Blue;
                        btn_guardar.Enabled = true;
                        tb_nombreAp.Text = "";
                        tb_nombreAp.Enabled = true;
                        tb_nombreAp.Focus();
                    }
            }
        }

        


        private void limpiar()
        {
            lista.Rows.Clear();
            lb_total_importe.Text = "0";
            cb_ci_nit.SelectedItem = cb_ci_nit.Items[0];
            /*mClientesBindingSource.DataSource = CCliente.mostrar();
            this.cb_ci_nit.DataSource = this.mClientesBindingSource;
            cb_ci_nit.SelectedItem = 0;*/
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            String ci = cb_ci_nit.Text;
            if (ci == string.Empty) {
                cb_ci_nit.Focus();
                MessageBox.Show("El ci no debe esta vacia");
                return;
            }

            String nombre = tb_nombreAp.Text;
            if (nombre == string.Empty) {
                tb_nombreAp.Focus();
                MessageBox.Show("El nombre no debe esta vacia");
                return;
            }

            MClientes cliente = new MClientes(0, nombre, ci, "", "", DateTime.Now);
            if (CCliente.Insertar(cliente,this)) {
                btn_guardar.Enabled=false;
                mClientesBindingSource.DataSource = CCliente.mostrar();
                this.cb_ci_nit.DataSource = CCliente.mostrar(); ;
                cb_ci_nit.Text = ci;
                tb_nombreAp.Enabled = false;
            }
        }

        private void btn_facturar_Click(object sender, EventArgs e)
        {
            if (lista.Rows.Count == 0) {
                ToastNotification.Show(this, "Añade un producto antes de cobrar.", global::facturacion.Properties.Resources.error, 3000, (eToastGlowColor.Red), (eToastPosition.TopRight));
                return;
            }
            
            if (MessageBox.Show("Esta Apunto de Facturar el monto de " + lb_total_importe.Text + ".", "COBRAR PEDIDO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                aux = CCliente.BuscarCI(cb_ci_nit.Text.ToString());
                string ccodigo;
                if (aux.Rows.Count >= 1 && lista.Rows.Count > 0)
                {
                    DataRow row_cliente = aux.Rows[0];
                    Numeracion num = new Numeracion();
                    MVentas venta = new MVentas(0, int.Parse(row_cliente["id"].ToString()), int.Parse(Datos.Rows[0]["id"].ToString()), DateTime.Now, Double.Parse(lb_total_importe.Text), num.Convertir(lb_total_importe.Text, true), "factura", "cancelado",numero_next);
                    long id_now = CVenta.Insertar(venta, this);
                    if (id_now != -1)
                    {
                        
                        DataTable cla = CCodigo.ultimo();

                        DataTable fa = CFactura.ultimo();
                        int id_fac_last = 0;
                        if (fa.Rows.Count != 0)
                        {
                            id_fac_last = int.Parse(fa.Rows[0]["id"].ToString());
                        }
                        id_fac_last++;
                        string clave = cla.Rows[0]["clave"].ToString();
                        Hashid.Hashid hashid = new Hashid.Hashid();
                        string[] f = lb_fecActual.Text.Split('/');
                        ccodigo = (String)hashid.calcular(cla.Rows[0]["autorizacion"].ToString(), id_fac_last.ToString(), cb_ci_nit.Text.ToString(), f[2] + f[1] + f[0], lb_total_importe.Text, clave);
                        qr_image.Text = lb_nit.Text + "|" + id_fac_last.ToString() + "|" + cla.Rows[0]["autorizacion"].ToString() + "|" + lb_fecActual.Text + "|" + lb_total_importe.Text + "|" + lb_total_importe.Text + "|" + ccodigo + "|" + cb_ci_nit.Text.ToString() + "|0|0|0|0|";
                        string dir = "/img/qrs/" + ccodigo + ".jpg";
                        qr_image.Image.Save(@"" + Application.StartupPath + dir, ImageFormat.Jpeg);
                        
                        MFactura fact = new MFactura(0, (int)id_now,int.Parse(cla.Rows[0]["id"].ToString()) ,ccodigo, dir, id_fac_last.ToString(), DateTime.Now);
                        if (!CFactura.Insertar(fact, this)) {
                            MessageBox.Show("no se pudo crear al factura");
                        }

                        foreach (DataGridViewRow r in lista.Rows)
                        {
                            string precio_total = r.Cells["total"].Value.ToString();
                            string cantidad = r.Cells["cantidad"].Value.ToString();
                            string unitario = r.Cells["precio"].Value.ToString();
                            string descripcion = r.Cells["descripcion"].Value.ToString();
                            int id = Convert.ToInt32(r.Cells["id"].Value);

                            MDetalleVenta det = new MDetalleVenta(0, id, double.Parse(cantidad), (int)id_now, Double.Parse(precio_total), descripcion, Double.Parse(unitario));

                            CDetalleVenta.Insertar(det, this);
                        }


                        try
                        {
                            LocalReport rdlc = new LocalReport();
                            rdlc.ReportPath = @"..\..\Vistas\Report3.rdlc";
                            rdlc.ReportEmbeddedResource = "facturacion.Vistas.Report3.rdlc";
                            rdlc.EnableExternalImages = true;
                            DataTable factura = CFactura.MostrarID(id_now);
                            DataTable venta2 = CVenta.MostrarID(id_now);
                            DataTable infomacion = CEmpresa.Mostrar();
                            DataTable codigo = CCodigo.ultimoID(int.Parse(factura.Rows[0]["idCodigo"].ToString()));
                            DataTable cliente = CCliente.MostrarID(venta2.Rows[0]["idCliente"].ToString());
                            DataTable customer = CDetalleVenta.Mostrar((int)id_now);
                            rdlc.DataSources.Add(new ReportDataSource("DataSet1", customer));
                            ReportParameter[] parameters = new ReportParameter[16];
                            string path = "file:\\" + Application.StartupPath + infomacion.Rows[0]["logo"];
                            string pathqr = "file:\\" + Application.StartupPath + factura.Rows[0]["QR"].ToString();
                            parameters[15] = new ReportParameter("Path", @path, true);
                            parameters[0] = new ReportParameter("PathQr", @pathqr, true);
                            parameters[1] = new ReportParameter("empresa", infomacion.Rows[0]["nombre"].ToString());
                            parameters[2] = new ReportParameter("propietario", infomacion.Rows[0]["nomPropietario"].ToString());
                            parameters[3] = new ReportParameter("direccion", infomacion.Rows[0]["direccion"].ToString());
                            parameters[4] = new ReportParameter("nit", infomacion.Rows[0]["nit"].ToString());
                            parameters[5] = new ReportParameter("nro", factura.Rows[0]["numFactura"].ToString());
                            parameters[6] = new ReportParameter("autorizacion", codigo.Rows[0]["autorizacion"].ToString());
                            parameters[7] = new ReportParameter("telefono", infomacion.Rows[0]["telefono"].ToString());
                            parameters[8] = new ReportParameter("literal", "Son: " + venta2.Rows[0]["montoLiteral"].ToString());
                            parameters[9] = new ReportParameter("nombre_cliente", cliente.Rows[0]["nombre"].ToString());
                            parameters[10] = new ReportParameter("ci", cliente.Rows[0]["ci"].ToString());
                            parameters[11] = new ReportParameter("fecha", venta2.Rows[0]["fecVenta"].ToString());
                            parameters[12] = new ReportParameter("total", venta2.Rows[0]["montoTotal"].ToString());
                            parameters[13] = new ReportParameter("codigo_control", factura.Rows[0]["codControl"].ToString());
                            parameters[14] = new ReportParameter("fecha_limite", codigo.Rows[0]["fecFinal"].ToString());
                            rdlc.SetParameters(parameters);
                            Impresor imp = new Impresor();
                            imp.Imprime(rdlc);
                            LocalReport rdlc2 = new LocalReport();
                            rdlc2.ReportPath = @"..\..\Vistas\Report1.rdlc";
                            rdlc2.ReportEmbeddedResource = "facturacion.Vistas.Report1.rdlc";
                            rdlc2.DataSources.Add(new ReportDataSource("DataSet1", customer));
                            ReportParameter nombre = new ReportParameter("nombre_cliente", cliente.Rows[0]["nombre"].ToString());
                            ReportParameter fecha = new ReportParameter("fecha", venta2.Rows[0]["fecVenta"].ToString());
                            ReportParameter numero = new ReportParameter("numero", numero_next.ToString());
                            rdlc2.SetParameters(new ReportParameter[] { nombre, fecha, numero });
                            imp.Imprime(rdlc2);
                            limpiar();
                        }
                        catch (Exception exp)
                        {
                            ToastNotification.Show(this, exp.Message, global::facturacion.Properties.Resources.Warning_sign, 3000, (eToastGlowColor.Red), (eToastPosition.TopRight));
                            if (MessageBox.Show("Ha ocurrido un error al imprimir, Desea Volver a imprimir el pedido/factura??", "ERROR AL FACTURAR!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                                LocalReport rdlc = new LocalReport();
                                rdlc.ReportPath = @"..\..\Vistas\Report3.rdlc";
                                rdlc.ReportEmbeddedResource = "facturacion.Vistas.Report3.rdlc";
                                rdlc.EnableExternalImages = true;
                                DataTable factura = CFactura.MostrarID(id_now);
                                DataTable venta2 = CVenta.MostrarID(id_now);
                                DataTable infomacion = CEmpresa.Mostrar();
                                DataTable codigo = CCodigo.ultimoID(int.Parse(factura.Rows[0]["idCodigo"].ToString()));
                                DataTable cliente = CCliente.MostrarID(venta2.Rows[0]["idCliente"].ToString());
                                DataTable customer = CDetalleVenta.Mostrar((int)id_now);
                                rdlc.DataSources.Add(new ReportDataSource("DataSet1", customer));
                                ReportParameter[] parameters = new ReportParameter[16];
                                string path = "file:\\" + Application.StartupPath + infomacion.Rows[0]["logo"];
                                string pathqr = "file:\\" + Application.StartupPath + factura.Rows[0]["QR"].ToString();
                                parameters[15] = new ReportParameter("Path", @path, true);
                                parameters[0] = new ReportParameter("PathQr", @pathqr, true);
                                parameters[1] = new ReportParameter("empresa", infomacion.Rows[0]["nombre"].ToString());
                                parameters[2] = new ReportParameter("propietario", infomacion.Rows[0]["nomPropietario"].ToString());
                                parameters[3] = new ReportParameter("direccion", infomacion.Rows[0]["direccion"].ToString());
                                parameters[4] = new ReportParameter("nit", infomacion.Rows[0]["nit"].ToString());
                                parameters[5] = new ReportParameter("nro", factura.Rows[0]["numFactura"].ToString());
                                parameters[6] = new ReportParameter("autorizacion", codigo.Rows[0]["autorizacion"].ToString());
                                parameters[7] = new ReportParameter("telefono", infomacion.Rows[0]["telefono"].ToString());
                                parameters[8] = new ReportParameter("literal", "Son: " + venta2.Rows[0]["montoLiteral"].ToString());
                                parameters[9] = new ReportParameter("nombre_cliente", cliente.Rows[0]["nombre"].ToString());
                                parameters[10] = new ReportParameter("ci", cliente.Rows[0]["ci"].ToString());
                                parameters[11] = new ReportParameter("fecha", venta2.Rows[0]["fecVenta"].ToString());
                                parameters[12] = new ReportParameter("total", venta2.Rows[0]["montoTotal"].ToString());
                                parameters[13] = new ReportParameter("codigo_control", factura.Rows[0]["codControl"].ToString());
                                parameters[14] = new ReportParameter("fecha_limite", codigo.Rows[0]["fecFinal"].ToString());
                                rdlc.SetParameters(parameters);
                                Impresor imp = new Impresor();
                                imp.Imprime(rdlc);
                                LocalReport rdlc2 = new LocalReport();
                                rdlc2.ReportPath = @"..\..\Vistas\Report1.rdlc";
                                rdlc2.ReportEmbeddedResource = "facturacion.Vistas.Report1.rdlc";
                                rdlc2.DataSources.Add(new ReportDataSource("DataSet1", customer));
                                ReportParameter nombre = new ReportParameter("nombre_cliente", cliente.Rows[0]["nombre"].ToString());
                                ReportParameter fecha = new ReportParameter("fecha", venta2.Rows[0]["fecVenta"].ToString());
                                ReportParameter numero = new ReportParameter("numero", numero_next.ToString());
                                rdlc2.SetParameters(new ReportParameter[] { nombre, fecha, numero });
                                imp.Imprime(rdlc2);
                                limpiar();
                            }
                            limpiar();
                        }
                        numero_next++;
                        //retornar el reporte
                    }
                }
                else
                {
                    MessageBox.Show("El CI/Nit no esta registrado.\n Registre el Nombre y guardelo.");
                    btn_guardar.BackColor = System.Drawing.Color.Blue;
                    btn_guardar.Enabled = true;
                    tb_nombreAp.Text = "";
                    tb_nombreAp.Enabled = true;
                    tb_nombreAp.Focus();
                }
            }
        }

        private void tb_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tb_cantidad.Text.Contains(','))
                 {
                          if(!char.IsDigit(e.KeyChar))
                          {
                                   e.Handled = true;
                          }
                          if ( e.KeyChar == '\b')
                          {
                              e.Handled = false;
                          }
                  }
                  else
                  {
                            if(!char.IsDigit(e.KeyChar))
                            {
                                     e.Handled = true;
                             }

                          if(e.KeyChar==',' || e.KeyChar=='\b')
                          {
                                   e.Handled = false;
                          }
                 }
        }

        private void db_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (db_precio.Text.Contains(','))
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

    }
}
