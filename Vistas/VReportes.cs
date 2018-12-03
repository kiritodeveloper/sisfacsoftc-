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

namespace facturacion.Vistas
{
    public partial class VReportes : UserControl
    {
        public VReportes()
        {
            InitializeComponent();
            DataTable dtTest = CCliente.mostrar();
            dtTest.Rows.Add("0","Todos","Todos","Todos","Todos",DateTime.Now);
            DataTable dtTest2 = CProducto.Mostrar();
            dtTest2.Rows.Add("0", "Todos", "Todos", "Todos", 0.0 ,"Todos","","");
            DataTable dtTest3 = CUsuarios.Mostrar();
            dtTest3.Rows.Add(0, "Todos", "Todos", "Todos", "Todos", "Todos", "Todos", "Todos", "Todos");
            dt_inicio.Value = DateTime.Now;
            dt_final.Value = DateTime.Now;
            mClientesBindingSource.DataSource = dtTest;
            mProductoBindingSource.DataSource = dtTest2;
            mUsuarioBindingSource.DataSource = dtTest3;
            //cb_producto.SelectedItem = cb_producto.Items[dtTest2.Rows.Count-1];
            cb_cliente.SelectedItem = cb_cliente.Items[dtTest.Rows.Count - 1];
            cb_usuario.SelectedItem = cb_usuario.Items[dtTest3.Rows.Count - 1];
            cb_pedidos.SelectedItem = cb_pedidos.Items[0];
            
            
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
                btn_cancelar.Command = newValue.ReporteCommands.Cancel;
            }
            else
            {
                btn_cancelar.Command = null;
            }
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void Mostrar()
        {
            int id_cliente = 0;
            string pedidos = "";
            int id_usuario = 0;
            if (int.Parse(((DataRowView)cb_usuario.SelectedValue)[0].ToString()) == 0)
            {
                id_usuario = -1;
            }
            else
            {
                id_usuario = int.Parse(((DataRowView)cb_usuario.SelectedValue)[0].ToString());
            }

            if (int.Parse(((DataRowView)cb_cliente.SelectedValue)[0].ToString()) == 0)
            {
                id_cliente = -1;
            }
            else
            {
                id_cliente = int.Parse(((DataRowView)cb_cliente.SelectedValue)[0].ToString());
            }
            switch (cb_pedidos.SelectedItem.ToString())
            {
                case "Pedidos":
                    pedidos = "pedido";
                    break;
                case "Factura":
                    pedidos = "factura";
                    break;
                case "Todos":
                    pedidos = "Todos";
                    break;
            }
         /*   if (int.Parse(((DataRowView)cb_producto.SelectedValue)[0].ToString()) == 0)
            {
                id_productos = -1;
            }
            else
            {
                id_productos = int.Parse(((DataRowView)cb_producto.SelectedValue)[0].ToString());
            }*/
            string fecha_inicio = dt_inicio.Value.ToString("yyyy-MM-dd");
            string fecha_final = dt_final.Value.ToString("yyyy-MM-dd");
            lista.DataSource = CReporte.Reporte1(id_usuario,id_cliente, pedidos, fecha_inicio, fecha_final);
            
            lista.Columns["cliente_id"].Visible = false;
            lista.Columns["venta_id"].Visible = false;

            lb_ventas.Text = lista.Rows.Count + " Ventas Registradas";

            double sum = 0.0;
            int cv = 0;
            int cf = 0;
            int anu = 0;
            foreach (System.Windows.Forms.DataGridViewRow row in lista.Rows)
            {
                string cad = row.Cells["importe"].Value.ToString();
                sum += (Double.Parse(cad));
                if (row.Cells["tipo"].Value.ToString() == "pedido")
                {
                    cv++;
                }
                else {
                    cf++;
                }
                if (row.Cells["estado"].Value.ToString() == "anulado") {
                    anu++;
                }
            }
            this.lb_importe.Text = sum.ToString();
            lb_facturas.Text = cf+" ventas con facturas";
            lb_sin_factura.Text = cv + " ventas sin facturas";
            lb_producto.Text = "_";
            lb_empresa.Text = "REPORTE GENEREAL";
            lb_anulados.Text = anu + " Ventas Anuladas";
        }

        private void btn_x_cliente_Click(object sender, EventArgs e)
        {
            int id_cliente = 0;
            string pedidos = "";
            if (int.Parse(((DataRowView)cb_cliente.SelectedValue)[0].ToString()) == 0)
            {
                id_cliente = -1;
            }
            else
            {
                id_cliente = int.Parse(((DataRowView)cb_cliente.SelectedValue)[0].ToString());
            }
            switch (cb_pedidos.SelectedItem.ToString())
            {
                case "Pedidos":
                    pedidos = "pedido";
                    break;
                case "Factura":
                    pedidos = "factura";
                    break;
                case "Todos":
                    pedidos = "Todos";
                    break;
            }
            string fecha_inicio = dt_inicio.Value.ToString("yyyy-MM-dd");
            string fecha_final = dt_final.Value.ToString("yyyy-MM-dd");
            lista.DataSource = CReporte.Reporte2(id_cliente, pedidos, fecha_inicio, fecha_final);

            lista.Columns["id"].Visible = false;
            double sum = 0.0;
            int cv = 0;
            int cf = 0;
            int cant = 0;
            foreach (System.Windows.Forms.DataGridViewRow row in lista.Rows)
            {
                string cad = row.Cells["importe"].Value.ToString();
                sum += (Double.Parse(cad));
                cad = row.Cells["cantidad"].Value.ToString();
                cant += (int.Parse(cad));
                if (row.Cells["tipo"].Value.ToString() == "pedido")
                {
                    cv++;
                }
                else
                {
                    cf++;
                }
            }
            this.lb_importe.Text = sum.ToString();
            lb_ventas.Text = cant + " Ventas Registradas";
            if (cb_pedidos.SelectedItem.ToString() == "Todos")
            {
                lb_facturas.Text = "_";
                lb_sin_factura.Text = "_";
            }
            else {
                if (cb_pedidos.SelectedItem.ToString() == "Pedidos")
                {
                    lb_facturas.Text = " _ ";
                    lb_sin_factura.Text = lista.Rows.Count + " ventas sin facturas";
                }
                else {
                    lb_facturas.Text = lista.Rows.Count + " ventas con facturas";
                    lb_sin_factura.Text =  " _ ";
                }
            }
            lb_empresa.Text = "REPORTE POR CLIENTE";
            lb_anulados.Text = "_";
        }

        private void btn_x_cantidad_Click(object sender, EventArgs e)
        {
            //SELECT p.id, p.nombre, SUM(dv.cantidad) as cantidad, SUM(totalVenta) as total FROM productos p, detalleventas dv, ventas v where p.id=dv.idProducto and dv.idVenta=v.id and date(v.fecVenta) BETWEEN '2018-06-17' and '2018-06-18' GROUP by p.id ORDER by cantidad DESC
            int id_cliente = 0;
            string pedidos = "";
            if (int.Parse(((DataRowView)cb_cliente.SelectedValue)[0].ToString()) == 0)
            {
                id_cliente = -1;
            }
            else
            {
                id_cliente = int.Parse(((DataRowView)cb_cliente.SelectedValue)[0].ToString());
            }
            switch (cb_pedidos.SelectedItem.ToString())
            {
                case "Pedidos":
                    pedidos = "pedido";
                    break;
                case "Factura":
                    pedidos = "factura";
                    break;
                case "Todos":
                    pedidos = "Todos";
                    break;
            }
            string fecha_inicio = dt_inicio.Value.ToString("yyyy-MM-dd");
            string fecha_final = dt_final.Value.ToString("yyyy-MM-dd");
            lista.DataSource = CReporte.Reporte3(id_cliente, pedidos, fecha_inicio, fecha_final);
            lista.Columns["id"].Visible = false;
            lb_producto.Text = lista.Rows.Count + " Productos Diferentes";
            double sum = 0.0;
            int cv = 0;
            int cf = 0;
            int cant = 0;
            foreach (System.Windows.Forms.DataGridViewRow row in lista.Rows)
            {
                string cad = row.Cells["importe"].Value.ToString();
                sum += (Double.Parse(cad));
                cad = row.Cells["cantidad"].Value.ToString();
                cant += (int.Parse(cad));
            }
            this.lb_importe.Text = sum.ToString();
            lb_ventas.Text = cant + " Productos Vendidos";
            lb_facturas.Text = "_";
            lb_sin_factura.Text = "_";
            lb_empresa.Text = "REPORTE POR CANTIDAD DE PRODUCTO VENDIDO";
            lb_anulados.Text = "_";
        }

        private void ntb_no_vendidos_Click(object sender, EventArgs e)
        {
            //SELECT p.* from productos p LEFT JOIN detalleventas v on p.id=v.idProducto where v.idProducto is null
            
            string fecha_inicio = dt_inicio.Value.ToString("yyyy-MM-dd");
            string fecha_final = dt_final.Value.ToString("yyyy-MM-dd");
            lista.DataSource = CReporte.Reporte4(fecha_inicio, fecha_final);
            lista.Columns["id"].Visible = false;
            
            
            this.lb_importe.Text = "0";
            lb_ventas.Text ="Los productos no han sido vendidos";
            lb_producto.Text = lista.Rows.Count + " Productos Diferentes";
            lb_facturas.Text = "_";
            lb_sin_factura.Text = "_";
            lb_empresa.Text = "REPORTE DE PRODUCTOS NO VENDIDOS";
            lb_anulados.Text = "_";
        }
    }
}
