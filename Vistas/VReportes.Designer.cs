namespace facturacion.Vistas
{
    partial class VReportes
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lista = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_usuario = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.mUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.ntb_no_vendidos = new DevComponents.DotNetBar.ButtonX();
            this.btn_x_cliente = new DevComponents.DotNetBar.ButtonX();
            this.btn_x_cantidad = new DevComponents.DotNetBar.ButtonX();
            this.btn_generar = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.dt_final = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dt_inicio = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cb_pedidos = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.Todos = new DevComponents.Editors.ComboItem();
            this.Pedidos = new DevComponents.Editors.ComboItem();
            this.Factura = new DevComponents.Editors.ComboItem();
            this.cb_cliente = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.mClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.mProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lb_empresa = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.btn_cancelar = new DevComponents.DotNetBar.ButtonX();
            this.lb_ventas = new DevComponents.DotNetBar.LabelX();
            this.lb_importe = new DevComponents.DotNetBar.LabelX();
            this.lb_producto = new DevComponents.DotNetBar.LabelX();
            this.lb_facturas = new DevComponents.DotNetBar.LabelX();
            this.lb_sin_factura = new DevComponents.DotNetBar.LabelX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_anulados = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_final)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_inicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mProductoBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lista
            // 
            this.lista.AllowUserToAddRows = false;
            this.lista.BackgroundColor = System.Drawing.Color.White;
            this.lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lista.DefaultCellStyle = dataGridViewCellStyle1;
            this.lista.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(73)))), ((int)(((byte)(42)))));
            this.lista.Location = new System.Drawing.Point(7, 224);
            this.lista.Name = "lista";
            this.lista.RowHeadersVisible = false;
            this.lista.Size = new System.Drawing.Size(513, 224);
            this.lista.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_usuario);
            this.groupBox1.Controls.Add(this.labelX11);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.ntb_no_vendidos);
            this.groupBox1.Controls.Add(this.btn_x_cliente);
            this.groupBox1.Controls.Add(this.btn_x_cantidad);
            this.groupBox1.Controls.Add(this.btn_generar);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.dt_final);
            this.groupBox1.Controls.Add(this.dt_inicio);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this.cb_pedidos);
            this.groupBox1.Controls.Add(this.cb_cliente);
            this.groupBox1.Controls.Add(this.shapeContainer1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 98);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos para reporte";
            // 
            // cb_usuario
            // 
            this.cb_usuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_usuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_usuario.DataSource = this.mUsuarioBindingSource;
            this.cb_usuario.DisplayMember = "nombre";
            this.cb_usuario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_usuario.DropDownColumns = "nombre,ci,tipo";
            this.cb_usuario.ForeColor = System.Drawing.Color.Black;
            this.cb_usuario.FormattingEnabled = true;
            this.cb_usuario.ItemHeight = 14;
            this.cb_usuario.Location = new System.Drawing.Point(60, 72);
            this.cb_usuario.Name = "cb_usuario";
            this.cb_usuario.Size = new System.Drawing.Size(106, 20);
            this.cb_usuario.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_usuario.TabIndex = 13;
            // 
            // mUsuarioBindingSource
            // 
            this.mUsuarioBindingSource.DataSource = typeof(Modelos.MUsuario);
            // 
            // labelX11
            // 
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Location = new System.Drawing.Point(4, 72);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(50, 23);
            this.labelX11.TabIndex = 12;
            this.labelX11.Text = "Usuario:";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(335, 42);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 11;
            this.labelX4.Text = "Fecha Final:";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(335, 19);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(87, 20);
            this.labelX3.TabIndex = 10;
            this.labelX3.Text = "Fecha Inicial:";
            // 
            // ntb_no_vendidos
            // 
            this.ntb_no_vendidos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ntb_no_vendidos.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ntb_no_vendidos.Location = new System.Drawing.Point(182, 72);
            this.ntb_no_vendidos.Name = "ntb_no_vendidos";
            this.ntb_no_vendidos.Size = new System.Drawing.Size(131, 20);
            this.ntb_no_vendidos.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ntb_no_vendidos.TabIndex = 8;
            this.ntb_no_vendidos.Text = "Productos No Vendidos";
            this.ntb_no_vendidos.Click += new System.EventHandler(this.ntb_no_vendidos_Click);
            // 
            // btn_x_cliente
            // 
            this.btn_x_cliente.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_x_cliente.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_x_cliente.Location = new System.Drawing.Point(182, 19);
            this.btn_x_cliente.Name = "btn_x_cliente";
            this.btn_x_cliente.Size = new System.Drawing.Size(131, 20);
            this.btn_x_cliente.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_x_cliente.TabIndex = 7;
            this.btn_x_cliente.Text = "Compras de Cliente";
            this.btn_x_cliente.Click += new System.EventHandler(this.btn_x_cliente_Click);
            // 
            // btn_x_cantidad
            // 
            this.btn_x_cantidad.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_x_cantidad.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_x_cantidad.Location = new System.Drawing.Point(182, 45);
            this.btn_x_cantidad.Name = "btn_x_cantidad";
            this.btn_x_cantidad.Size = new System.Drawing.Size(131, 20);
            this.btn_x_cantidad.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_x_cantidad.TabIndex = 6;
            this.btn_x_cantidad.Text = "Productos Por Cantidad";
            this.btn_x_cantidad.Click += new System.EventHandler(this.btn_x_cantidad_Click);
            // 
            // btn_generar
            // 
            this.btn_generar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_generar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_generar.Location = new System.Drawing.Point(374, 72);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(106, 20);
            this.btn_generar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_generar.TabIndex = 5;
            this.btn_generar.Text = "Generar";
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(4, 48);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(50, 17);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "Ventas:";
            // 
            // dt_final
            // 
            // 
            // 
            // 
            this.dt_final.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dt_final.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dt_final.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dt_final.ButtonDropDown.Visible = true;
            this.dt_final.IsPopupCalendarOpen = false;
            this.dt_final.Location = new System.Drawing.Point(428, 42);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dt_final.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dt_final.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dt_final.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dt_final.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dt_final.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dt_final.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dt_final.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dt_final.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dt_final.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dt_final.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dt_final.MonthCalendar.DisplayMonth = new System.DateTime(2018, 6, 1, 0, 0, 0, 0);
            this.dt_final.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dt_final.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dt_final.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dt_final.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dt_final.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dt_final.MonthCalendar.TodayButtonVisible = true;
            this.dt_final.Name = "dt_final";
            this.dt_final.Size = new System.Drawing.Size(89, 20);
            this.dt_final.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dt_final.TabIndex = 4;
            this.dt_final.Value = new System.DateTime(2018, 6, 18, 0, 14, 21, 0);
            // 
            // dt_inicio
            // 
            // 
            // 
            // 
            this.dt_inicio.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dt_inicio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dt_inicio.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dt_inicio.ButtonDropDown.Visible = true;
            this.dt_inicio.IsPopupCalendarOpen = false;
            this.dt_inicio.Location = new System.Drawing.Point(428, 19);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dt_inicio.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dt_inicio.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dt_inicio.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dt_inicio.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dt_inicio.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dt_inicio.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dt_inicio.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dt_inicio.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dt_inicio.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dt_inicio.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dt_inicio.MonthCalendar.DisplayMonth = new System.DateTime(2018, 6, 1, 0, 0, 0, 0);
            this.dt_inicio.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dt_inicio.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dt_inicio.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dt_inicio.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dt_inicio.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dt_inicio.MonthCalendar.TodayButtonVisible = true;
            this.dt_inicio.Name = "dt_inicio";
            this.dt_inicio.Size = new System.Drawing.Size(89, 20);
            this.dt_inicio.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dt_inicio.TabIndex = 3;
            this.dt_inicio.Value = new System.DateTime(2018, 6, 18, 0, 13, 59, 0);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(4, 22);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(50, 17);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "Cliente:";
            // 
            // cb_pedidos
            // 
            this.cb_pedidos.DisplayMember = "Text";
            this.cb_pedidos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_pedidos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_pedidos.ForeColor = System.Drawing.Color.Black;
            this.cb_pedidos.FormattingEnabled = true;
            this.cb_pedidos.ItemHeight = 14;
            this.cb_pedidos.Items.AddRange(new object[] {
            this.Todos,
            this.Pedidos,
            this.Factura});
            this.cb_pedidos.Location = new System.Drawing.Point(60, 45);
            this.cb_pedidos.Name = "cb_pedidos";
            this.cb_pedidos.Size = new System.Drawing.Size(106, 20);
            this.cb_pedidos.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_pedidos.TabIndex = 1;
            // 
            // Todos
            // 
            this.Todos.Text = "Todos";
            this.Todos.Value = "Todos";
            // 
            // Pedidos
            // 
            this.Pedidos.Text = "Pedidos";
            this.Pedidos.Value = "Pedidos";
            // 
            // Factura
            // 
            this.Factura.Text = "Factura";
            this.Factura.Value = "Factura";
            // 
            // cb_cliente
            // 
            this.cb_cliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_cliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_cliente.DataSource = this.mClientesBindingSource;
            this.cb_cliente.DisplayMember = "ci";
            this.cb_cliente.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_cliente.DropDownColumns = "nombre,ci";
            this.cb_cliente.ForeColor = System.Drawing.Color.Black;
            this.cb_cliente.FormattingEnabled = true;
            this.cb_cliente.ItemHeight = 14;
            this.cb_cliente.Location = new System.Drawing.Point(60, 19);
            this.cb_cliente.Name = "cb_cliente";
            this.cb_cliente.Size = new System.Drawing.Size(106, 20);
            this.cb_cliente.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_cliente.TabIndex = 0;
            // 
            // mClientesBindingSource
            // 
            this.mClientesBindingSource.DataSource = typeof(Modelos.MClientes);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 16);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(517, 79);
            this.shapeContainer1.TabIndex = 9;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 171;
            this.lineShape1.X2 = 171;
            this.lineShape1.Y1 = -7;
            this.lineShape1.Y2 = 78;
            // 
            // mProductoBindingSource
            // 
            this.mProductoBindingSource.DataSource = typeof(Modelos.MProducto);
            // 
            // lb_empresa
            // 
            // 
            // 
            // 
            this.lb_empresa.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_empresa.Location = new System.Drawing.Point(7, 107);
            this.lb_empresa.Name = "lb_empresa";
            this.lb_empresa.Size = new System.Drawing.Size(519, 17);
            this.lb_empresa.TabIndex = 6;
            this.lb_empresa.Text = "REPORTES";
            this.lb_empresa.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(7, 19);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 17);
            this.labelX5.TabIndex = 7;
            this.labelX5.Text = "Total Ventas:";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(7, 42);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 17);
            this.labelX6.TabIndex = 8;
            this.labelX6.Text = "Total Importe:";
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(7, 65);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(75, 17);
            this.labelX7.TabIndex = 9;
            this.labelX7.Text = "Total Prod.:";
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(287, 19);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(75, 17);
            this.labelX8.TabIndex = 10;
            this.labelX8.Text = "Con Factura:";
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(287, 42);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(75, 17);
            this.labelX9.TabIndex = 11;
            this.labelX9.Text = "Sin Factura:";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_cancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_cancelar.Location = new System.Drawing.Point(7, 456);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(92, 21);
            this.btn_cancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_cancelar.TabIndex = 12;
            this.btn_cancelar.Text = "Atras";
            // 
            // lb_ventas
            // 
            // 
            // 
            // 
            this.lb_ventas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_ventas.Location = new System.Drawing.Point(88, 19);
            this.lb_ventas.Name = "lb_ventas";
            this.lb_ventas.Size = new System.Drawing.Size(133, 17);
            this.lb_ventas.TabIndex = 13;
            // 
            // lb_importe
            // 
            // 
            // 
            // 
            this.lb_importe.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_importe.Location = new System.Drawing.Point(88, 42);
            this.lb_importe.Name = "lb_importe";
            this.lb_importe.Size = new System.Drawing.Size(133, 17);
            this.lb_importe.TabIndex = 14;
            // 
            // lb_producto
            // 
            // 
            // 
            // 
            this.lb_producto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_producto.Location = new System.Drawing.Point(88, 65);
            this.lb_producto.Name = "lb_producto";
            this.lb_producto.Size = new System.Drawing.Size(133, 17);
            this.lb_producto.TabIndex = 15;
            // 
            // lb_facturas
            // 
            // 
            // 
            // 
            this.lb_facturas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_facturas.Location = new System.Drawing.Point(355, 19);
            this.lb_facturas.Name = "lb_facturas";
            this.lb_facturas.Size = new System.Drawing.Size(158, 17);
            this.lb_facturas.TabIndex = 16;
            // 
            // lb_sin_factura
            // 
            // 
            // 
            // 
            this.lb_sin_factura.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_sin_factura.Location = new System.Drawing.Point(355, 42);
            this.lb_sin_factura.Name = "lb_sin_factura";
            this.lb_sin_factura.Size = new System.Drawing.Size(158, 17);
            this.lb_sin_factura.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_anulados);
            this.groupBox2.Controls.Add(this.labelX10);
            this.groupBox2.Controls.Add(this.lb_importe);
            this.groupBox2.Controls.Add(this.lb_sin_factura);
            this.groupBox2.Controls.Add(this.labelX5);
            this.groupBox2.Controls.Add(this.lb_facturas);
            this.groupBox2.Controls.Add(this.labelX6);
            this.groupBox2.Controls.Add(this.lb_producto);
            this.groupBox2.Controls.Add(this.labelX7);
            this.groupBox2.Controls.Add(this.labelX8);
            this.groupBox2.Controls.Add(this.lb_ventas);
            this.groupBox2.Controls.Add(this.labelX9);
            this.groupBox2.Location = new System.Drawing.Point(4, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(519, 88);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion";
            // 
            // lb_anulados
            // 
            // 
            // 
            // 
            this.lb_anulados.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_anulados.Location = new System.Drawing.Point(355, 65);
            this.lb_anulados.Name = "lb_anulados";
            this.lb_anulados.Size = new System.Drawing.Size(161, 17);
            this.lb_anulados.TabIndex = 19;
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(287, 64);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(75, 18);
            this.labelX10.TabIndex = 18;
            this.labelX10.Text = "Anulados:";
            // 
            // VReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.lb_empresa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lista);
            this.Name = "VReportes";
            this.Size = new System.Drawing.Size(529, 480);
            ((System.ComponentModel.ISupportInitialize)(this.lista)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_final)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_inicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mProductoBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX lista;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btn_generar;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dt_final;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dt_inicio;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_pedidos;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_cliente;
        private System.Windows.Forms.BindingSource mClientesBindingSource;
        private System.Windows.Forms.BindingSource mProductoBindingSource;
        private DevComponents.Editors.ComboItem Todos;
        private DevComponents.Editors.ComboItem Pedidos;
        private DevComponents.Editors.ComboItem Factura;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX lb_empresa;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.ButtonX btn_x_cantidad;
        private DevComponents.DotNetBar.ButtonX btn_x_cliente;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.ButtonX btn_cancelar;
        private DevComponents.DotNetBar.LabelX lb_ventas;
        private DevComponents.DotNetBar.LabelX lb_importe;
        private DevComponents.DotNetBar.LabelX lb_producto;
        private DevComponents.DotNetBar.LabelX lb_facturas;
        private DevComponents.DotNetBar.LabelX lb_sin_factura;
        private DevComponents.DotNetBar.ButtonX ntb_no_vendidos;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.LabelX lb_anulados;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_usuario;
        private System.Windows.Forms.BindingSource mUsuarioBindingSource;
        private DevComponents.DotNetBar.LabelX labelX11;
    }
}
