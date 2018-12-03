using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using DevComponents.DotNetBar;
using System.Diagnostics;
using DevComponents.AdvTree;
using DevComponents.DotNetBar.Metro.ColorTables;
using facturacion.Vistas;
using Controladores;

namespace facturacion
{
    public partial class MainForm : MetroAppForm
    {
        StartControl _StartControl = null; // Start control displayed on startup
        MetroBillCommands _Commands = null; // All application commands
        public MainForm()
        {
            InitializeComponent();

            DataTable info = CEmpresa.Mostrar();
            if (info.Rows.Count > 0)
            {
                Image c = Image.FromFile(@"" + Application.StartupPath + info.Rows[0]["logo"].ToString());
                pictureBox1.Image = c;
            }


            
            // Prepare commands
            _Commands = new MetroBillCommands();

            _Commands.ToggleStartControl = new Command(components);
            _Commands.ToggleStartControl.Executed += new EventHandler(ToggleStartControlExecuted);


            // Initialize Client related commands
            _Commands.EmpresaCommands.New = new Command(components); // We pass in components from Form so the command gets disposed automatically when form is disposed
            _Commands.EmpresaCommands.New.Executed += NewEmpresaExecuted;
            _Commands.EmpresaCommands.Cancel = new Command(components);
            _Commands.EmpresaCommands.Cancel.Executed += CancelEmpresaExecuted;

            // Initialize Client related commands
            _Commands.VentaCommands.New = new Command(components); // We pass in components from Form so the command gets disposed automatically when form is disposed
            _Commands.VentaCommands.New.Executed += NewVentaExecuted;
            _Commands.VentaCommands.Cancel = new Command(components);
            _Commands.VentaCommands.Cancel.Executed += CancelVentaExecuted;

            // Initialize Client related commands
            _Commands.ProductoCommands.New = new Command(components); // We pass in components from Form so the command gets disposed automatically when form is disposed
            _Commands.ProductoCommands.New.Executed += NewProductoExecuted;
            _Commands.ProductoCommands.Cancel = new Command(components);
            _Commands.ProductoCommands.Cancel.Executed += CancelProductoExecuted;


            // Initialize Codigo related commands
            _Commands.CodigoCommands.New = new Command(components); // We pass in components from Form so the command gets disposed automatically when form is disposed
            _Commands.CodigoCommands.New.Executed += NewCodigoExecuted;
            _Commands.CodigoCommands.Cancel = new Command(components);
            _Commands.CodigoCommands.Cancel.Executed += CancelCodigoExecuted;


            // Initialize Codigo related commands
            _Commands.ClienteCommands.New = new Command(components); // We pass in components from Form so the command gets disposed automatically when form is disposed
            _Commands.ClienteCommands.New.Executed += NewClienteExecuted;
            _Commands.ClienteCommands.Cancel = new Command(components);
            _Commands.ClienteCommands.Cancel.Executed += CancelClienteExecuted;

            // Initialize Codigo related commands
            _Commands.UsuarioCommands.New = new Command(components); // We pass in components from Form so the command gets disposed automatically when form is disposed
            _Commands.UsuarioCommands.New.Executed += NewUsuarioExecuted;
            _Commands.UsuarioCommands.Cancel = new Command(components);
            _Commands.UsuarioCommands.Cancel.Executed += CancelUsuarioExecuted;

            // Initialize Codigo related commands
            _Commands.ListaVentaCommands.New = new Command(components); // We pass in components from Form so the command gets disposed automatically when form is disposed
            _Commands.ListaVentaCommands.New.Executed += NewListaVentaExecuted;
            _Commands.ListaVentaCommands.Cancel = new Command(components);
            _Commands.ListaVentaCommands.Cancel.Executed += CancelListaVentaExecuted;

            // Initialize Codigo related commands
            _Commands.ReporteCommands.New = new Command(components); // We pass in components from Form so the command gets disposed automatically when form is disposed
            _Commands.ReporteCommands.New.Executed += NewReporteExecuted;
            _Commands.ReporteCommands.Cancel = new Command(components);
            _Commands.ReporteCommands.Cancel.Executed += CancelReporteExecuted;


            // Initialize Codigo related commands
            _Commands.FacturaCommands.New = new Command(components); // We pass in components from Form so the command gets disposed automatically when form is disposed
            _Commands.FacturaCommands.New.Executed += NewfacturaExecuted;
            _Commands.FacturaCommands.Cancel = new Command(components);
            _Commands.FacturaCommands.Cancel.Executed += CancelFacturaExecuted;


            // General commands
            _Commands.ChangeMetroTheme = new Command(components, new EventHandler(ChangeMetroThemeExecuted));
            _Commands.NotImplemented = new Command(components, new EventHandler(NotImplementedExecuted));
            _Commands.DevComponents = new Command(components, new EventHandler(DevComponentsExecuted));
            _Commands.GettingStartedCommand = new Command(components, new EventHandler(GettingStartedExecuted));

            this.SuspendLayout();
            _StartControl = new StartControl();
            _StartControl.Commands = _Commands;
            this.Controls.Add(_StartControl);
            _StartControl.BringToFront();
            _StartControl.SlideSide = DevComponents.DotNetBar.Controls.eSlideSide.Right;
            _StartControl.Click += new EventHandler(StartControl_Click);
            this.ResumeLayout(false);

            // Assign commands to toolbar buttons

            // Add metro color themes
            MetroColorGeneratorParameters[] metroThemes = MetroColorGeneratorParameters.GetAllPredefinedThemes();
            foreach (MetroColorGeneratorParameters mt in metroThemes)
            {
                ButtonItem theme = new ButtonItem(mt.ThemeName, mt.ThemeName);
                theme.Command = _Commands.ChangeMetroTheme;
                theme.CommandParameter = mt;
                colorThemeButton.SubItems.Add(theme);
            }

            

        }

        public MainForm(Form1 form1, DataTable Datos)
        {
            // TODO: Complete member initialization
            this.form1 = form1;
            this.Datos = Datos;

            InitializeComponent();


            DataTable info = CEmpresa.Mostrar();
            if (info.Rows.Count > 0)
            {
                Image c = Image.FromFile(@"" + Application.StartupPath + info.Rows[0]["logo"].ToString());
                pictureBox1.Image = c;
            }
            // Prepare commands
            _Commands = new MetroBillCommands();

            _Commands.ToggleStartControl = new Command(components);
            _Commands.ToggleStartControl.Executed += new EventHandler(ToggleStartControlExecuted);


            // Initialize Client related commands
            _Commands.EmpresaCommands.New = new Command(components); // We pass in components from Form so the command gets disposed automatically when form is disposed
            _Commands.EmpresaCommands.New.Executed += NewEmpresaExecuted;
            _Commands.EmpresaCommands.Cancel = new Command(components);
            _Commands.EmpresaCommands.Cancel.Executed += CancelEmpresaExecuted;

            // Initialize Client related commands
            _Commands.VentaCommands.New = new Command(components); // We pass in components from Form so the command gets disposed automatically when form is disposed
            _Commands.VentaCommands.New.Executed += NewVentaExecuted;
            _Commands.VentaCommands.Cancel = new Command(components);
            _Commands.VentaCommands.Cancel.Executed += CancelVentaExecuted;

            // Initialize Client related commands
            _Commands.ProductoCommands.New = new Command(components); // We pass in components from Form so the command gets disposed automatically when form is disposed
            _Commands.ProductoCommands.New.Executed += NewProductoExecuted;
            _Commands.ProductoCommands.Cancel = new Command(components);
            _Commands.ProductoCommands.Cancel.Executed += CancelProductoExecuted;


            // Initialize Codigo related commands
            _Commands.CodigoCommands.New = new Command(components); // We pass in components from Form so the command gets disposed automatically when form is disposed
            _Commands.CodigoCommands.New.Executed += NewCodigoExecuted;
            _Commands.CodigoCommands.Cancel = new Command(components);
            _Commands.CodigoCommands.Cancel.Executed += CancelCodigoExecuted;


            // Initialize Codigo related commands
            _Commands.ClienteCommands.New = new Command(components); // We pass in components from Form so the command gets disposed automatically when form is disposed
            _Commands.ClienteCommands.New.Executed += NewClienteExecuted;
            _Commands.ClienteCommands.Cancel = new Command(components);
            _Commands.ClienteCommands.Cancel.Executed += CancelClienteExecuted;

            // Initialize Codigo related commands
            _Commands.UsuarioCommands.New = new Command(components); // We pass in components from Form so the command gets disposed automatically when form is disposed
            _Commands.UsuarioCommands.New.Executed += NewUsuarioExecuted;
            _Commands.UsuarioCommands.Cancel = new Command(components);
            _Commands.UsuarioCommands.Cancel.Executed += CancelUsuarioExecuted;

            // Initialize Codigo related commands
            _Commands.ListaVentaCommands.New = new Command(components); // We pass in components from Form so the command gets disposed automatically when form is disposed
            _Commands.ListaVentaCommands.New.Executed += NewListaVentaExecuted;
            _Commands.ListaVentaCommands.Cancel = new Command(components);
            _Commands.ListaVentaCommands.Cancel.Executed += CancelListaVentaExecuted;

            // Initialize Codigo related commands
            _Commands.ReporteCommands.New = new Command(components); // We pass in components from Form so the command gets disposed automatically when form is disposed
            _Commands.ReporteCommands.New.Executed += NewReporteExecuted;
            _Commands.ReporteCommands.Cancel = new Command(components);
            _Commands.ReporteCommands.Cancel.Executed += CancelReporteExecuted;


            // Initialize Codigo related commands
            _Commands.FacturaCommands.New = new Command(components); // We pass in components from Form so the command gets disposed automatically when form is disposed
            _Commands.FacturaCommands.New.Executed += NewfacturaExecuted;
            _Commands.FacturaCommands.Cancel = new Command(components);
            _Commands.FacturaCommands.Cancel.Executed += CancelFacturaExecuted;


            // General commands
            _Commands.ChangeMetroTheme = new Command(components, new EventHandler(ChangeMetroThemeExecuted));
            _Commands.NotImplemented = new Command(components, new EventHandler(NotImplementedExecuted));
            _Commands.DevComponents = new Command(components, new EventHandler(DevComponentsExecuted));
            _Commands.GettingStartedCommand = new Command(components, new EventHandler(GettingStartedExecuted));

            this.SuspendLayout();
            _StartControl = new StartControl(Datos);
            _StartControl.Commands = _Commands;
            this.Controls.Add(_StartControl);
            _StartControl.BringToFront();
            _StartControl.SlideSide = DevComponents.DotNetBar.Controls.eSlideSide.Right;
            _StartControl.Click += new EventHandler(StartControl_Click);
            this.ResumeLayout(false);

            // Assign commands to toolbar buttons

            // Add metro color themes
            MetroColorGeneratorParameters[] metroThemes = MetroColorGeneratorParameters.GetAllPredefinedThemes();
            foreach (MetroColorGeneratorParameters mt in metroThemes)
            {
                ButtonItem theme = new ButtonItem(mt.ThemeName, mt.ThemeName);
                theme.Command = _Commands.ChangeMetroTheme;
                theme.CommandParameter = mt;
                colorThemeButton.SubItems.Add(theme);
            }
        }
        VFacturas factura = null;
        private void CancelFacturaExecuted(object sender, EventArgs e)
        {
            Debug.Assert(factura != null);
            CloseFacturaDialog();
        }

        private void CloseFacturaDialog()
        {
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = true;

            _Commands.FacturaCommands.New.Enabled = true; // Enable new client command

            this.CloseModalPanel(factura, DevComponents.DotNetBar.Controls.eSlideSide.Right);
            factura.Commands = null;
            factura.Dispose();
            factura = null;
        }

        private void NewfacturaExecuted(object sender, EventArgs e)
        {
            Debug.Assert(factura == null);
            _Commands.FacturaCommands.New.Enabled = false; // Disable new client command to prevent re-entrancy
            factura = new VFacturas();
            factura.Commands = _Commands;
            this.ShowModalPanel(factura, DevComponents.DotNetBar.Controls.eSlideSide.Right);
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = false;
        }
        VReportes reporte = null;
        private void CancelReporteExecuted(object sender, EventArgs e)
        {
            Debug.Assert(reporte != null);
            CloseReporteDialog();
        }

        private void CloseReporteDialog()
        {
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = true;

            _Commands.ReporteCommands.New.Enabled = true; // Enable new client command

            this.CloseModalPanel(reporte, DevComponents.DotNetBar.Controls.eSlideSide.Right);
            reporte.Commands = null;
            reporte.Dispose();
            reporte = null;
        }

        private void NewReporteExecuted(object sender, EventArgs e)
        {
            Debug.Assert(reporte == null);
            _Commands.ReporteCommands.New.Enabled = false; // Disable new client command to prevent re-entrancy
            reporte = new VReportes();
            reporte.Commands = _Commands;
            this.ShowModalPanel(reporte, DevComponents.DotNetBar.Controls.eSlideSide.Right);
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = false;
        }

        VListaVentas lista = null;
        private void CancelListaVentaExecuted(object sender, EventArgs e)
        {
            Debug.Assert(lista != null);
            CloseListaDialog();
        }

        private void CloseListaDialog()
        {
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = true;

            _Commands.ListaVentaCommands.New.Enabled = true; // Enable new client command

            this.CloseModalPanel(lista, DevComponents.DotNetBar.Controls.eSlideSide.Bottom);
            lista.Commands = null;
            lista.Dispose();
            lista = null;
        }

        private void NewListaVentaExecuted(object sender, EventArgs e)
        {
            Debug.Assert(lista == null);
            _Commands.ListaVentaCommands.New.Enabled = false; // Disable new client command to prevent re-entrancy
            lista = new VListaVentas(Datos);
            lista.Commands = _Commands;
            this.ShowModalPanel(lista, DevComponents.DotNetBar.Controls.eSlideSide.Bottom);
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = false;
        }

        VUsuario usuario = null;
        private void CancelUsuarioExecuted(object sender, EventArgs e)
        {
            Debug.Assert(usuario != null);
            CloseUsuarioDialog();
        }

        private void CloseUsuarioDialog()
        {
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = true;

            _Commands.UsuarioCommands.New.Enabled = true; // Enable new client command

            this.CloseModalPanel(usuario, DevComponents.DotNetBar.Controls.eSlideSide.Bottom);
            usuario.Commands = null;
            usuario.Dispose();
            usuario = null;
        }

        private void NewUsuarioExecuted(object sender, EventArgs e)
        {
            Debug.Assert(usuario == null);
            _Commands.UsuarioCommands.New.Enabled = false; // Disable new client command to prevent re-entrancy
            usuario = new VUsuario();
            usuario.Commands = _Commands;
            this.ShowModalPanel(usuario, DevComponents.DotNetBar.Controls.eSlideSide.Left);
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = false;
        }

        VCliente cliente = null;
        private void CancelClienteExecuted(object sender, EventArgs e)
        {
            Debug.Assert(cliente != null);
            CloseClienteDialog();
        }

        private void CloseClienteDialog()
        {
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = true;

            _Commands.ClienteCommands.New.Enabled = true; // Enable new client command

            this.CloseModalPanel(cliente, DevComponents.DotNetBar.Controls.eSlideSide.Right);
            cliente.Commands = null;
            cliente.Dispose();
            cliente = null;
        }

        private void NewClienteExecuted(object sender, EventArgs e)
        {
            Debug.Assert(cliente == null);
            _Commands.ClienteCommands.New.Enabled = false; // Disable new client command to prevent re-entrancy
            cliente = new VCliente();
            cliente.Commands = _Commands;
            this.ShowModalPanel(cliente, DevComponents.DotNetBar.Controls.eSlideSide.Bottom);
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = false;
        }

        VCodigo codigo = null;
        private void CancelCodigoExecuted(object sender, EventArgs e)
        {
            Debug.Assert(codigo != null);
            CloseCodigoDialog();
        }

        private void CloseCodigoDialog()
        {
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = true;

            _Commands.CodigoCommands.New.Enabled = true; // Enable new client command

            this.CloseModalPanel(codigo, DevComponents.DotNetBar.Controls.eSlideSide.Top);
            codigo.Commands = null;
            codigo.Dispose();
            codigo = null;
        }

        private void NewCodigoExecuted(object sender, EventArgs e)
        {
            Debug.Assert(codigo == null);
            _Commands.CodigoCommands.New.Enabled = false; // Disable new client command to prevent re-entrancy
            codigo = new VCodigo();
            codigo.Commands = _Commands;
            this.ShowModalPanel(codigo, DevComponents.DotNetBar.Controls.eSlideSide.Top);
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = false;
        }
        VProducto producto = null;
        private void NewProductoExecuted(object sender, EventArgs e)
        {
            Debug.Assert(producto == null);
            _Commands.ProductoCommands.New.Enabled = false; // Disable new client command to prevent re-entrancy
            producto = new VProducto(Datos);
            producto.Commands = _Commands;
            this.ShowModalPanel(producto, DevComponents.DotNetBar.Controls.eSlideSide.Left);
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = false;
        }

        private void CancelProductoExecuted(object sender, EventArgs e)
        {
            Debug.Assert(producto != null);
            CloseProuctoDialog();
        }

        private void CloseProuctoDialog()
        {
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = true;

            _Commands.ProductoCommands.New.Enabled = true; // Enable new client command

            this.CloseModalPanel(producto, DevComponents.DotNetBar.Controls.eSlideSide.Left);
            producto.Commands = null;
            producto.Dispose();
            producto = null;
        }

        VVentas venta = null;
        private void CancelVentaExecuted(object sender, EventArgs e)
        {
            Debug.Assert(venta != null);
            CloseVentaDialog();
        }

        private void CloseVentaDialog()
        {
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = true;

            _Commands.VentaCommands.New.Enabled = true; // Enable new client command

            this.CloseModalPanel(venta, DevComponents.DotNetBar.Controls.eSlideSide.Bottom);
            venta.Commands = null;
            venta.Dispose();
            venta = null;
        }

        private void NewVentaExecuted(object sender, EventArgs e)
        {
            DataTable empresa = CEmpresa.Mostrar();
            if (empresa.Rows.Count == 0)
            {
                MessageBox.Show("No existe Empresa Registrada, Primero registre una empresa");
                return;
            }
            DataTable cla = CCodigo.ultimo();
            if (cla.Rows.Count == 0)
            {
                MessageBox.Show("Ingrese una llave de dosificacion");
                return;
            }
            Debug.Assert(venta == null);
            _Commands.VentaCommands.New.Enabled = false; // Disable new client command to prevent re-entrancy
            venta = new VVentas(Datos);
            venta.Commands = _Commands;
            this.ShowModalPanel(venta, DevComponents.DotNetBar.Controls.eSlideSide.Top);
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = false;
        }

        //desde aqui
        Empresa empresa = null;
        private void CancelEmpresaExecuted(object sender, EventArgs e)
        {
            Debug.Assert(empresa != null);
            CloseEmpresaDialog();
        }

        private void CloseEmpresaDialog()
        {
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = true;

            _Commands.EmpresaCommands.New.Enabled = true; // Enable new client command

            this.CloseModalPanel(empresa, DevComponents.DotNetBar.Controls.eSlideSide.Top);
            empresa.Commands = null;
            empresa.Dispose();
            empresa = null;
        }

        private void NewEmpresaExecuted(object sender, EventArgs e)
        {
            Debug.Assert(empresa == null);
            _Commands.EmpresaCommands.New.Enabled = false; // Disable new client command to prevent re-entrancy
            empresa = new Empresa();
            empresa.Commands = _Commands;
            this.ShowModalPanel(empresa, DevComponents.DotNetBar.Controls.eSlideSide.Left);
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = false;
        }
        //hasta aqui




        #region Command Execution

        private void GettingStartedExecuted(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.devcomponents.com/kb2/?p=1160");
        }
        private void NotImplementedExecuted(object sender, EventArgs e)
        {
            MessageBoxEx.Show(this, "No tiene permisos para ver esto", "Permiso denegado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void DevComponentsExecuted(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.devcomponents.com/dotnetbar/");
        }

        private void ChangeMetroThemeExecuted(object sender, EventArgs e)
        {
            ICommandSource source = (ICommandSource)sender;
            MetroColorGeneratorParameters theme = (MetroColorGeneratorParameters)source.CommandParameter;
            StyleManager.MetroColorGeneratorParameters = theme;
        }

        private void ToggleStartControlExecuted(object sender, EventArgs e)
        {
            _StartControl.IsOpen = !_StartControl.IsOpen;
        }

        
        
        void SaveClientExecuted(object sender, EventArgs e)
        {
            // Here we would save new client to the storage of choice then close the "dialog"
            
        }

       /* InvoiceControl _InvoiceControl = null;
        void NewInvoiceExecuted(object sender, EventArgs e)
        {
            Debug.Assert(_InvoiceControl == null);
            _Commands.InvoiceCommands.New.Enabled = false; // Disable new invoice command to prevent re-entrancy
            _InvoiceControl = new InvoiceControl();
            _InvoiceControl.Commands = _Commands;
            this.ShowModalPanel(_InvoiceControl, DevComponents.DotNetBar.Controls.eSlideSide.Left);
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = false;
        }
        private void CancelInvoiceExecuted(object sender, EventArgs e)
        {
            // Simply close invoice entry form "dialog"
            Debug.Assert(_InvoiceControl != null);
            CloseInvoiceDialog();
        }
        private void CloseInvoiceDialog()
        {
            if (!_StartControl.Visible)
                _StartControl.SlideOutButtonVisible = true;

            _Commands.InvoiceCommands.New.Enabled = true; // Enable new invoice command

            this.CloseModalPanel(_InvoiceControl, DevComponents.DotNetBar.Controls.eSlideSide.Left);
            _InvoiceControl.Commands = null;
            _InvoiceControl.Dispose();
            _InvoiceControl = null;
        }
        void SaveInvoiceExecuted(object sender, EventArgs e)
        {
            // Here we would save new invoice to the storage of choice then close the "dialog"
            CloseInvoiceDialog();
        }*/
        #endregion

        #region Sample Data Handling

        private Node CreateClientRow(string clientName, string location, double totalInvoiced)
        {
            Node node = new Node(clientName);
            node.Cells.Add(new Cell(location));
            node.Cells.Add(new Cell(totalInvoiced.ToString("C")));
            return node;
        }
        private Node CreateInvoiceRow(DateTime date, string clientName, double invoiceAmount, string invoiceFileName)
        {
            Node node = new Node(date.ToShortDateString());
            node.Cells.Add(new Cell(clientName));
            node.Cells.Add(new Cell(invoiceAmount.ToString("C")));
            node.Tag = invoiceFileName;
            return node;
        }

        private static global::System.Resources.ResourceManager resourceMan;
        private Form1 form1;
        private DataTable Datos;
        internal static global::System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceMan, null))
                {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MetroBill.Properties.Resources", typeof(facturacion.Properties.Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        #endregion

        #region UI Code
        void StartControl_Click(object sender, EventArgs e)
        {
            _StartControl.IsOpen = false;
        }

        protected override void OnLoad(EventArgs e)
        {
            UpdateControlsSizeAndLocation();
            base.OnLoad(e);
        }

        private Rectangle GetStartControlBounds()
        {
            int captionHeight = metroShell1.MetroTabStrip.GetCaptionHeight() + 2;
            Thickness borderThickness = this.GetBorderThickness();
            return new Rectangle((int)borderThickness.Left, captionHeight, this.Width - (int)borderThickness.Horizontal, this.Height - captionHeight - 1);
        }
        private void UpdateControlsSizeAndLocation()
        {
            if (_StartControl != null)
            {
                if (!_StartControl.IsOpen)
                    _StartControl.OpenBounds = GetStartControlBounds();
                else
                    _StartControl.Bounds = GetStartControlBounds();
                if (!IsModalPanelDisplayed)
                    _StartControl.BringToFront();
            }
        }
        protected override void OnResize(EventArgs e)
        {
            UpdateControlsSizeAndLocation();
            base.OnResize(e);
        }



        private void metroShell1_SettingsButtonClick(object sender, EventArgs e)
        {
            MessageBoxEx.Show(this, "MetroShell Settings Button Clicked", "Metro Bill", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void metroShell1_HelpButtonClick(object sender, EventArgs e)
        {
            MessageBoxEx.Show(this, "MetroShell Help Button Clicked", "Metro Bill", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void metroShell1_SelectedTabChanged(object sender, EventArgs e)
        {
            UpdateControlsSizeAndLocation();
        }
        #endregion

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            form1.Close();
        }

    }
}