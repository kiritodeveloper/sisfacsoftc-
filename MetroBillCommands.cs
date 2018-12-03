using System;
using System.Collections.Generic;
using System.Text;
using DevComponents.DotNetBar;

namespace facturacion
{
    /// <summary>
    /// Represents all application commands.
    /// </summary>
    public class MetroBillCommands
    {
        private DocumentCommands _ClientCommands = new DocumentCommands();
        /// <summary>
        /// Gets the client related commands.
        /// </summary>
        public DocumentCommands ClientCommands
        {
            get { return _ClientCommands; }
            set { _ClientCommands = value; }
        }

        private DocumentCommands _InvoiceCommands = new DocumentCommands();
        /// <summary>
        /// Gets document related commands.
        /// </summary>
        public DocumentCommands InvoiceCommands
        {
            get { return _InvoiceCommands; }
            set { _InvoiceCommands = value; }
        }


        //desde aqui

        private DocumentCommands _EmpresaCommands = new DocumentCommands();
        public DocumentCommands EmpresaCommands
        {
            get { return _EmpresaCommands; }
            set { _EmpresaCommands = value; }
        }

        //desde aqui

        private DocumentCommands _VentaCommands = new DocumentCommands();
        public DocumentCommands VentaCommands
        {
            get { return _VentaCommands; }
            set { _VentaCommands = value; }
        }
        //desde aqui

        private DocumentCommands _ProductoCommands = new DocumentCommands();
        public DocumentCommands ProductoCommands
        {
            get { return _ProductoCommands; }
            set { _ProductoCommands = value; }
        }

        //desde aqui

        private DocumentCommands _CodigoCommands = new DocumentCommands();
        public DocumentCommands CodigoCommands
        {
            get { return _CodigoCommands; }
            set { _CodigoCommands = value; }
        }
        //desde aqui

        private DocumentCommands _ClienteCommands = new DocumentCommands();
        public DocumentCommands ClienteCommands
        {
            get { return _ClienteCommands; }
            set { _ClienteCommands = value; }
        }

        //desde aqui

        private DocumentCommands _UsuarioCommands = new DocumentCommands();
        public DocumentCommands UsuarioCommands
        {
            get { return _UsuarioCommands; }
            set { _UsuarioCommands = value; }
        }

        //desde aqui

        private DocumentCommands _ListaVentaCommands = new DocumentCommands();
        public DocumentCommands ListaVentaCommands
        {
            get { return _ListaVentaCommands; }
            set { _ListaVentaCommands = value; }
        }
        //desde aqui

        private DocumentCommands _ReporteCommands = new DocumentCommands();
        public DocumentCommands ReporteCommands
        {
            get { return _ReporteCommands; }
            set { _ReporteCommands = value; }
        }
        //desde aqui

        private DocumentCommands _FacturaCommands = new DocumentCommands();
        public DocumentCommands FacturaCommands
        {
            get { return _FacturaCommands; }
            set { _FacturaCommands = value; }
        }

        private Command _SlideStartControl;
        public Command ToggleStartControl
        {
            get { return _SlideStartControl; }
            set { _SlideStartControl = value; }
        }

        private Command _ChangeMetroTheme;
        public Command ChangeMetroTheme
        {
            get { return _ChangeMetroTheme; }
            set { _ChangeMetroTheme = value; }
        }

        private Command _GettingStartedCommand;
        public Command GettingStartedCommand
        {
            get { return _GettingStartedCommand; }
            set { _GettingStartedCommand = value; }
        }

        private Command _NotImplemented;
        public Command NotImplemented
        {
            get { return _NotImplemented; }
            set { _NotImplemented = value; }
        }

        private Command _DevComponents;
        public Command DevComponents
        {
            get { return _DevComponents; }
            set { _DevComponents = value; }
        }
    }

    public class DocumentCommands
    {
        private Command _New;
        public Command New
        {
            get { return _New; }
            set { _New = value; }
        }

        private Command _Save;
        public Command Save
        {
            get { return _Save; }
            set { _Save = value; }
        }

        private Command _Cancel;
        public Command Cancel
        {
            get { return _Cancel; }
            set { _Cancel = value; }
        }
    }
}
