using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
namespace facturacion.Vistas
{
    public partial class StartControl : DevComponents.DotNetBar.Controls.SlidePanel
    {
        public StartControl()
        {
            InitializeComponent();

            // Add self-updating chart to the sales tile
            MicroChartItem chart = new MicroChartItem();
            chart.ChartType = eMicroChartType.Column;
            chart.ChartWidth = reporteItem.TileSize.Width - 26;
            chart.ChartHeight = reporteItem.TileSize.Height - 30;
            chart.DataPoints = GetRandomDataPoints(false, 12);
            chart.TooltipValueFormatString = "C"; // Currency format for tooltips
            chart.ColumnChartStyle.PositiveBarColor = Color.White;
            reporteItem.SubItems.Add(chart);
        }

        public StartControl(DataTable Datos)
        {
            this.Datos = Datos;
            InitializeComponent();

            // Add self-updating chart to the sales tile
            MicroChartItem chart = new MicroChartItem();
            chart.ChartType = eMicroChartType.Column;
            chart.ChartWidth = reporteItem.TileSize.Width - 26;
            chart.ChartHeight = reporteItem.TileSize.Height - 30;
            chart.DataPoints = GetRandomDataPoints(false, 12);
            chart.TooltipValueFormatString = "C"; // Currency format for tooltips
            chart.ColumnChartStyle.PositiveBarColor = Color.White;
            reporteItem.SubItems.Add(chart);
            lb_user.Text = "<div align='right'><font size='+4'>"+Datos.Rows[0]["nombre"]+"</font><br/>"+Datos.Rows[0]["tipo"]+"</div>";
        }

        protected override void OnResize(EventArgs e)
        {
            // Center the panel
            itemPanel1.Location = new Point((this.Width - itemPanel1.Width) / 2 + 16, ((this.Height - labelX1.Height - 16) - itemPanel1.Height) / 2 + labelX1.Height + 16);
            base.OnResize(e);
        }

        private MetroBillCommands _Commands;
        private DataTable Datos;
        /// <summary>
        /// Gets or sets the commands associated with the control.
        /// </summary>
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
        /// <summary>
        /// Called when Commands property has changed.
        /// </summary>
        /// <param name="oldValue">Old property value</param>
        /// <param name="newValue">New property value</param>
        protected virtual void OnCommandsChanged(MetroBillCommands oldValue, MetroBillCommands newValue)
        {
            if (newValue != null)
            {
                if (Datos.Rows[0]["tipo"].ToString() == "Administrador")
                {
                    codigoItem.Command = newValue.CodigoCommands.New;
                    empresaItem.Command = newValue.EmpresaCommands.New;
                    clienteItem.Command = newValue.ClienteCommands.New;
                    listaventaItem.Command = newValue.ListaVentaCommands.New;
                    producto.Command = newValue.ProductoCommands.New;
                    ventasItem.Command = newValue.VentaCommands.New;
                    facturaItem.Command = newValue.FacturaCommands.New;
                    usuarioItem.Command = newValue.UsuarioCommands.New;
                    reporteItem.Command = newValue.ReporteCommands.New;
                }
                else {
                    codigoItem.Command = newValue.NotImplemented;
                    empresaItem.Command = newValue.NotImplemented;
                    clienteItem.Command = newValue.ClienteCommands.New;
                    listaventaItem.Command = newValue.ListaVentaCommands.New;
                    producto.Command = newValue.ProductoCommands.New;
                    ventasItem.Command = newValue.VentaCommands.New;
                    facturaItem.Command = newValue.NotImplemented;
                    usuarioItem.Command = newValue.NotImplemented;
                    reporteItem.Command = newValue.ReporteCommands.New;
                }
            }
            else
            {
                codigoItem.Command = null;
                empresaItem.Command = null;
                clienteItem.Command = null;
                listaventaItem.Command = null;
                producto.Command = null;
                ventasItem.Command = null;
                facturaItem.Command = null;
                usuarioItem.Command = null;
                reporteItem.Command = null;
            }
        }

        private void chartUpdateTimer_Tick(object sender, EventArgs e)
        {
            ((MicroChartItem)reporteItem.SubItems[0]).DataPoints = GetRandomDataPoints(false, 12);
        }

        private List<double> GetRandomDataPoints(bool allowNegative, int pointsToCreate)
        {
            List<double> points = new List<double>();
            Random rnd = new Random((int)DateTime.Now.Ticks);
            Random rnd2 = new Random();

            for (int i = 0; i < pointsToCreate; i++)
            {
                points.Add(allowNegative ? ((rnd2.Next(500) > 250 ? 1 : -1) * rnd.Next(1000)) : rnd.Next(1000));
            }

            return points;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            facturacion.Vistas.FormPerfil form = new FormPerfil(Datos);
            form.Visible = true;
        }
    }
}

