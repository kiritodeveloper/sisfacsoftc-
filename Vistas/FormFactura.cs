using DevComponents.DotNetBar.Metro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladores;
using Modelos;
using Microsoft.Reporting.WinForms;
namespace facturacion.Vistas
{
    public partial class form_imprimir : MetroForm
    {
        long id_venta;
        string tipo;
        public form_imprimir(long id,string tipo)
        {
            InitializeComponent();
            id_venta = id;
            this.tipo = tipo;
        }

        private void FormFactura_Load(object sender, EventArgs e)
        {

            if (tipo.CompareTo("factura") == 0)
            {
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "facturacion.Vistas.Report3.rdlc";
                DataTable factura = CFactura.MostrarID(id_venta);
                DataTable venta = CVenta.MostrarID(id_venta);
                DataTable infomacion = CEmpresa.Mostrar();
                DataTable codigo = CCodigo.ultimoID(int.Parse(factura.Rows[0]["idCodigo"].ToString()));
                DataTable cliente = CCliente.MostrarID(venta.Rows[0]["idCliente"].ToString());
                DataTable customer = CDetalleVenta.Mostrar((int)id_venta);
                this.MDetalleVentaBindingSource.DataSource = customer;
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
                parameters[8] = new ReportParameter("literal","Son: "+ venta.Rows[0]["montoLiteral"].ToString());
                parameters[9] = new ReportParameter("nombre_cliente", cliente.Rows[0]["nombre"].ToString());
                parameters[10] = new ReportParameter("ci", cliente.Rows[0]["ci"].ToString());
                parameters[11] = new ReportParameter("fecha", venta.Rows[0]["fecVenta"].ToString());
                parameters[12] = new ReportParameter("total", venta.Rows[0]["montoTotal"].ToString());
                parameters[13] = new ReportParameter("codigo_control", factura.Rows[0]["codControl"].ToString());
                parameters[14] = new ReportParameter("fecha_limite", codigo.Rows[0]["fecFinal"].ToString());
                this.reportViewer1.LocalReport.SetParameters(parameters);
                this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                this.reportViewer1.RefreshReport();
            }
            else {
                if (tipo.CompareTo("pedido") == 0)
                {
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "facturacion.Vistas.Report1.rdlc";
                    DataTable venta = CVenta.MostrarID(id_venta);
                    DataTable infomacion = CEmpresa.Mostrar();
                    DataTable cliente = CCliente.MostrarID(venta.Rows[0]["idCliente"].ToString());
                    DataTable customer = CDetalleVenta.Mostrar((int)id_venta);
                    this.MDetalleVentaBindingSource.DataSource = customer;
                    ReportParameter[] parameters = new ReportParameter[2];
                    string path = "file:\\" + Application.StartupPath + infomacion.Rows[0]["logo"];
                    parameters[0] = new ReportParameter("nombre_cliente", cliente.Rows[0]["nombre"].ToString());
                    parameters[1] = new ReportParameter("fecha", venta.Rows[0]["fecVenta"].ToString());
                    this.reportViewer1.LocalReport.SetParameters(parameters);
                    this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                    this.reportViewer1.RefreshReport();
                }
                else {
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "facturacion.Vistas.Report2.rdlc";
                    DataTable venta = CVenta.MostrarID(id_venta);
                    DataTable infomacion = CEmpresa.Mostrar();
                    DataTable cliente = CCliente.MostrarID(venta.Rows[0]["idCliente"].ToString());
                    DataTable customer = CDetalleVenta.Mostrar((int)id_venta);
                    this.MDetalleVentaBindingSource.DataSource = customer;
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
                    this.reportViewer1.LocalReport.SetParameters(parameters);
                    this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                    this.reportViewer1.RefreshReport();
                    
                }
            }
        }
    }
}
