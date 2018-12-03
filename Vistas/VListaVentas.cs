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
using Microsoft.Reporting.WinForms;
using System.Drawing.Imaging;
namespace facturacion.Vistas
{
    public partial class VListaVentas : UserControl
    {
        long id_now = 0;
        public VListaVentas()
        {
            InitializeComponent();
            empresa_cargar();
            lb_numero.Text = "-";
            lb_ciNit.Text = "";
            lb_nombreAp.Text = "";
            dt_inicio.Value = DateTime.Now;
            dt_final.Value = DateTime.Now;
            Mostrar(string.Empty);
        }

        public VListaVentas(DataTable Datos)
        {
            // TODO: Complete member initialization
            this.Datos = Datos;
            InitializeComponent();
            empresa_cargar();
            lb_numero.Text = "-";
            lb_ciNit.Text = "";
            lb_nombreAp.Text = "";
            dt_inicio.Value = DateTime.Now;
            dt_final.Value = DateTime.Now;
            Mostrar(string.Empty);
            if (Datos.Rows[0]["tipo"].ToString() == "Empleado") {
                btn_cancelar_venta.Visible = false;
            }
        }

        private void Mostrar(string ci)
        {
            lista_ventas.DataSource = CVenta.Ventas(dt_inicio.Value.ToString("yyyy-MM-dd"), dt_final.Value.ToString("yyyy-MM-dd"), ci);
            lista_ventas.Columns["id"].Visible = false;
            lista_ventas.Columns["tipo"].Visible = false;
            calcluar_total_fecha();
        }

        private void empresa_cargar()
        {
            DataTable info = CEmpresa.Mostrar();
            if (info.Rows.Count > 0)
            {
                lb_nombreEmpresa.Text = info.Rows[0]["nombre"].ToString();
                //lb_autorizacion.Text = info.Rows[0]["numAutorizacion"].ToString();
                lb_nit.Text = info.Rows[0]["nit"].ToString();
                Image c = Image.FromFile(@"" + Application.StartupPath + info.Rows[0]["logo"].ToString());
                pictureBox1.Image = newImagen(c, 350, 350);
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
                btn_cancelar.Command = newValue.ListaVentaCommands.Cancel;
            }
            else
            {
                btn_cancelar.Command = null;
            }
        }

        private void tb_cliente_TextChanged(object sender, EventArgs e)
        {
            Mostrar(tb_cliente.Text);
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            Mostrar(tb_cliente.Text);
        }
        private void calcluar_total_fecha()
        {
            double sum = 0.0;
            foreach (System.Windows.Forms.DataGridViewRow row in lista_ventas.Rows)
            {
                if (row.Cells["Importe"].Value != null)
                {
                    string cad = row.Cells["Importe"].Value.ToString();
                    sum += (Double.Parse(cad));
                }
            }
            this.lb_total.Text = sum.ToString();
            lb_tc.Text = lista_ventas.Rows.Count.ToString()+" Registros";
        }

        private void lista_ventas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cargar();
        }

        private void lista_ventas_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                case Keys.Up:
                    if (this.lista_ventas.CurrentRow != null)
                    {
                        cargar();
                    }
                    break;
            }
        }
        string[] new_row = null;
        private DataTable Datos;
        private void cargar()
        {
            lista_detalle.Rows.Clear();
            lb_ciNit.Text = this.lista_ventas.CurrentRow.Cells["ci"].Value.ToString();
            lb_nombreAp.Text = this.lista_ventas.CurrentRow.Cells["nombre"].Value.ToString();
            lb_numero.Text = this.lista_ventas.CurrentRow.Cells["id"].Value.ToString();
            id_now = long.Parse(this.lista_ventas.CurrentRow.Cells["id"].Value.ToString());
            lb_fecVenta.Text = this.lista_ventas.CurrentRow.Cells["fecha"].Value.ToString();
            if (this.lista_ventas.CurrentRow.Cells["tipo"].Value.ToString() == "factura")
            {
                lb_con_sin.Text = "Con Factura";
                btn_facturar.Text="IMPRIMIR FACTURA";
            }
            else {
                lb_con_sin.Text = "";
                btn_facturar.Text = "FACTURAR";
            }
            DataTable table = CDetalleVenta.Mostrar(int.Parse(this.lista_ventas.CurrentRow.Cells["id"].Value.ToString()));
            foreach(DataRow row in table.Rows){
                new_row = new string[] {row["id"].ToString(), row["cantidad"].ToString(), row["descripcion"].ToString(), row["preUnitario"].ToString(),row["totalVenta"].ToString()};
                lista_detalle.Rows.Add(new_row);
            }
            calcluar_total();

        }
        private void calcluar_total()
        {
            double sum = 0.0;
            foreach (System.Windows.Forms.DataGridViewRow row in lista_detalle.Rows)
            {
                if (row.Cells["total"].Value != null)
                {
                    string cad = row.Cells["total"].Value.ToString();
                    sum += (Double.Parse(cad));
                }
            }
            this.lb_importeTotal.Text = sum.ToString();
        }

        private void btn_pedido_Click(object sender, EventArgs e)
        {
            if (id_now!=0)
            {
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
                    ReportParameter numero = new ReportParameter("numero", venta2.Rows[0]["numero"].ToString());
                    rdlc.SetParameters(new ReportParameter[] { nombre, fecha, numero });
                    Impresor imp = new Impresor();
                    imp.Imprime(rdlc);
                }catch(Exception err){
                    Mostrar(string.Empty);
                    MessageBox.Show("Upp!, algo ha salido mal, por favor vuelva a seleccionar la venta e intentelo de nuevo");
                }

            }
        }

        private void btn_facturar_Click(object sender, EventArgs e)
        {
            if (id_now != 0)
            {
                try
                {
                    if (this.lista_ventas.CurrentRow.Cells["tipo"].Value.ToString() == "factura")
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
                    }
                    else
                    {
                        if (MessageBox.Show("Esta Apunto de Facturar el monto de " + lb_importeTotal.Text + ".", "FACTURAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            DataTable aux = CCliente.Buscar("ci", lb_ciNit.Text.ToString());
                            string ccodigo;
                            if (aux.Rows.Count == 1)
                            {
                                DataRow row_cliente = aux.Rows[0];
                                Numeracion num = new Numeracion();
                                MVentas venta = new MVentas(0, int.Parse(row_cliente["id"].ToString()), 1, DateTime.Now, Double.Parse(lb_importeTotal.Text), num.Convertir(lb_importeTotal.Text, true), "factura", "cancelado",0);
                                CVenta.Editar(int.Parse(id_now.ToString()), venta, this);
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
                                string[] ff = lb_fecVenta.Text.Split(' ');
                                string[] f = ff[0].Split('/');
                                ccodigo = (String)hashid.calcular(cla.Rows[0]["autorizacion"].ToString(), id_fac_last.ToString(), lb_ciNit.Text.ToString(), f[2] + f[1] + f[0], lb_importeTotal.Text, clave);
                                qr_image = new Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl();
                                qr_image.QuietZoneModule = Gma.QrCodeNet.Encoding.Windows.Render.QuietZoneModules.Two;
                                qr_image.Size = new System.Drawing.Size(108, 95);
                                qr_image.Text = lb_nit.Text + "|" + id_fac_last.ToString() + "|" + cla.Rows[0]["autorizacion"].ToString() + "|" + ff[0] + "|" + lb_importeTotal.Text + "|" + lb_importeTotal.Text + "|" + ccodigo + "|" + lb_ciNit.Text.ToString() + "|0|0|0|0|";
                                string dir = "/img/qrs/" + ccodigo + ".jpg";
                                qr_image.Image.Save(@"" + Application.StartupPath + dir, ImageFormat.Jpeg);

                                MFactura fact = new MFactura(0, (int)id_now, int.Parse(cla.Rows[0]["id"].ToString()), ccodigo, dir, id_fac_last.ToString(), DateTime.Now);
                                CFactura.Insertar(fact, this);
                                Mostrar(tb_cliente.Text.ToString());

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


                            }
                            else
                            {
                                MessageBox.Show("El CI/Nit no esta registrado.\n Registre el Nombre y guardelo.");
                            }
                        }
                    }
                }catch(Exception err){
                    Mostrar(string.Empty);
                    MessageBox.Show("Upp!, algo ha salido mal, por favor vuelva a seleccionar la venta e intentelo de nuevo");
                }
            }
            else {
                MessageBox.Show("Seleccione una venta");
            }
        }

        private void btn_nota_Click(object sender, EventArgs e)
        {
            if (id_now != 0)
            {
                    try{
                    LocalReport rdlc = new LocalReport();
                    rdlc.ReportPath = @"..\..\Vistas\Report2.rdlc";
                    rdlc.ReportEmbeddedResource = "facturacion.Vistas.Report2.rdlc";
                    rdlc.EnableExternalImages = true;
                    DataTable venta = CVenta.MostrarID(id_now);
                    DataTable infomacion = CEmpresa.Mostrar();
                    DataTable cliente = CCliente.MostrarID(venta.Rows[0]["idCliente"].ToString());
                    DataTable customer = CDetalleVenta.Mostrar((int)id_now);
                    rdlc.DataSources.Add(new ReportDataSource("DataSet1", customer));
                    ReportParameter[] parameters = new ReportParameter[10];
                    string path = "file:\\" + Application.StartupPath + infomacion.Rows[0]["logo"];
                    parameters[0] = new ReportParameter("Path", @path, true);
                    parameters[1] = new ReportParameter("empresa", infomacion.Rows[0]["nombre"].ToString());
                    parameters[2] = new ReportParameter("propietario", infomacion.Rows[0]["nomPropietario"].ToString());
                    parameters[3] = new ReportParameter("direccion", infomacion.Rows[0]["direccion"].ToString());
                    parameters[4] = new ReportParameter("telefono", infomacion.Rows[0]["telefono"].ToString());
                    parameters[5] = new ReportParameter("nombre_cliente", cliente.Rows[0]["nombre"].ToString());
                    parameters[6] = new ReportParameter("ci", cliente.Rows[0]["ci"].ToString());
                    parameters[7] = new ReportParameter("fecha", venta.Rows[0]["fecVenta"].ToString());
                    parameters[8] = new ReportParameter("total", venta.Rows[0]["montoTotal"].ToString());
                    parameters[9] = new ReportParameter("literal", "Son: " + venta.Rows[0]["montoLiteral"].ToString());
                    rdlc.SetParameters(parameters);
                    Impresor imp = new Impresor();
                    imp.Imprime(rdlc);
                }
                catch (Exception err)
                {
                    Mostrar(string.Empty);
                    MessageBox.Show("Upp!, algo ha salido mal, por favor vuelva a seleccionar la venta e intentelo de nuevo");
                }
            }
        }

        public Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl qr_image { get; set; }

        private void btn_cancelar_venta_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar la venta/factura de este registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (CVenta.Eliminar(id_now, this))
                {
                    Mostrar(tb_cliente.Text);
                }
            }
        }
    }
}

