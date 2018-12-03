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
    public partial class VFacturas : UserControl
    {
        public VFacturas()
        {
            InitializeComponent();
            dt_inicio.Value = DateTime.Now;
            dt_fin.Value = DateTime.Now;
        }

        private void btn_Ver_Click(object sender, EventArgs e)
        {
            string di = dt_inicio.Value.ToString("yyyy-MM-dd");
            string df = dt_fin.Value.ToString("yyyy-MM-dd");
            lista.DataSource = CReporte.Reporte5(di,df);
            calcular_total();
        }

        private void cb_iva_CheckedChanged(object sender, EventArgs e)
        {
            if(lista.Rows.Count!=0)
                calcularImpuesto();   
        }
        private void calcular_total()
        {
            double sum = 0.0;
            foreach (System.Windows.Forms.DataGridViewRow row in lista.Rows)
            {
                if (row.Cells["Importe"].Value != null)
                {
                    string cad = row.Cells["Importe"].Value.ToString();
                    sum += (Double.Parse(cad));
                }
            }
            this.lb_total_importe.Text = sum.ToString();
            lb_importe_neto.Text = sum.ToString();
        }

        private void calcularImpuesto()
        {
            double iva = 0.0;
            double it = 0.0;
            double neto = double.Parse(lb_total_importe.Text);
            if (cb_iva.Checked == true)
            {
                iva = neto * 0.13;
            }
            if (cb_it.Checked == true)
            {
                it = neto * 0.03;
            }
            lb_it.Text = it.ToString();
            lb_iva.Text = iva.ToString();
            lb_importe_neto.Text = (neto - it - iva).ToString();
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
                btn_cancelar.Command = newValue.FacturaCommands.Cancel;
            }
            else
            {
                btn_cancelar.Command = null;
            }
        }

        private void cb_it_CheckedChanged(object sender, EventArgs e)
        {
            if (lista.Rows.Count != 0)
                calcularImpuesto();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            string di = dt_inicio.Value.ToString("yyyy-MM-dd");
            string df = dt_fin.Value.ToString("yyyy-MM-dd");
            DataTable ta = CReporte.Reporte5(di, df);
            facturacion.Vistas.FormListaFactura form = new FormListaFactura(ta);
            form.Visible = true;
        }
    }
}
