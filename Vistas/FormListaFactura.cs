using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using Microsoft.Reporting.WinForms;

namespace facturacion.Vistas
{
    public partial class FormListaFactura : MetroForm
    {
        private DataTable ta;

        public FormListaFactura()
        {
            InitializeComponent();
        }

        public FormListaFactura(DataTable ta)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.ta = ta;
        }

        private void FormListaFactura_Load(object sender, EventArgs e)
        {

            MListaFacturaBindingSource.DataSource = ta;
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            
            this.reportViewer1.RefreshReport();
        }
    }
}
