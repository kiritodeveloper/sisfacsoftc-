namespace facturacion.Vistas
{
    partial class VVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VVentas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_facturar = new DevComponents.DotNetBar.ButtonX();
            this.btn_cobrar = new DevComponents.DotNetBar.ButtonX();
            this.qr_image = new Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl();
            this.lb_total_importe = new DevComponents.DotNetBar.LabelX();
            this.labelX20 = new DevComponents.DotNetBar.LabelX();
            this.lb_nombreEmpresa = new DevComponents.DotNetBar.LabelX();
            this.lb_numero = new DevComponents.DotNetBar.LabelX();
            this.lb_nit = new DevComponents.DotNetBar.LabelX();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.btn_cancelar = new DevComponents.DotNetBar.ButtonX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.lb_fecActual = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.lista = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pb_imagen_empresa = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pb_imagen_producto = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.db_precio = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_descripcion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.btn_añadir = new DevComponents.DotNetBar.ButtonX();
            this.tb_cantidad = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cb_producto = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.mProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.tb_extra = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_nombreAp = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cb_ci_nit = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.mClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_guardar = new DevComponents.DotNetBar.ButtonX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.mDetalleVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelEx1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qr_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagen_empresa)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagen_producto)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mProductoBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDetalleVentaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.groupBox1);
            this.panelEx1.Controls.Add(this.qr_image);
            this.panelEx1.Controls.Add(this.lb_total_importe);
            this.panelEx1.Controls.Add(this.labelX20);
            this.panelEx1.Controls.Add(this.lb_nombreEmpresa);
            this.panelEx1.Controls.Add(this.lb_numero);
            this.panelEx1.Controls.Add(this.lb_nit);
            this.panelEx1.Controls.Add(this.labelX14);
            this.panelEx1.Controls.Add(this.labelX13);
            this.panelEx1.Controls.Add(this.btn_cancelar);
            this.panelEx1.Controls.Add(this.labelX10);
            this.panelEx1.Controls.Add(this.lb_fecActual);
            this.panelEx1.Controls.Add(this.labelX8);
            this.panelEx1.Controls.Add(this.lista);
            this.panelEx1.Controls.Add(this.pb_imagen_empresa);
            this.panelEx1.Controls.Add(this.groupBox4);
            this.panelEx1.Controls.Add(this.groupBox3);
            this.panelEx1.Controls.Add(this.groupBox2);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(507, 481);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.groupBox1.Controls.Add(this.btn_facturar);
            this.groupBox1.Controls.Add(this.btn_cobrar);
            this.groupBox1.Location = new System.Drawing.Point(3, 409);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 69);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COBRAR";
            // 
            // btn_facturar
            // 
            this.btn_facturar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_facturar.BackColor = System.Drawing.Color.Turquoise;
            this.btn_facturar.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btn_facturar.Image = global::facturacion.Properties.Resources.money;
            this.btn_facturar.Location = new System.Drawing.Point(144, 13);
            this.btn_facturar.Name = "btn_facturar";
            this.btn_facturar.Size = new System.Drawing.Size(115, 49);
            this.btn_facturar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_facturar.TabIndex = 24;
            this.btn_facturar.Text = "FACTURAR";
            this.btn_facturar.Click += new System.EventHandler(this.btn_facturar_Click);
            // 
            // btn_cobrar
            // 
            this.btn_cobrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_cobrar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_cobrar.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btn_cobrar.Image = global::facturacion.Properties.Resources.Cash;
            this.btn_cobrar.Location = new System.Drawing.Point(6, 14);
            this.btn_cobrar.Name = "btn_cobrar";
            this.btn_cobrar.Size = new System.Drawing.Size(119, 49);
            this.btn_cobrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_cobrar.TabIndex = 11;
            this.btn_cobrar.Text = "PEDIDO";
            this.btn_cobrar.Click += new System.EventHandler(this.btn_cobrar_Click);
            // 
            // qr_image
            // 
            this.qr_image.ErrorCorrectLevel = Gma.QrCodeNet.Encoding.ErrorCorrectionLevel.M;
            this.qr_image.Image = ((System.Drawing.Image)(resources.GetObject("qr_image.Image")));
            this.qr_image.Location = new System.Drawing.Point(396, 383);
            this.qr_image.Name = "qr_image";
            this.qr_image.QuietZoneModule = Gma.QrCodeNet.Encoding.Windows.Render.QuietZoneModules.Two;
            this.qr_image.Size = new System.Drawing.Size(108, 95);
            this.qr_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.qr_image.TabIndex = 23;
            this.qr_image.TabStop = false;
            this.qr_image.Text = "sistema pizza mania";
            // 
            // lb_total_importe
            // 
            // 
            // 
            // 
            this.lb_total_importe.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_total_importe.Location = new System.Drawing.Point(335, 383);
            this.lb_total_importe.Name = "lb_total_importe";
            this.lb_total_importe.Size = new System.Drawing.Size(55, 23);
            this.lb_total_importe.TabIndex = 22;
            this.lb_total_importe.Text = "0,0";
            this.lb_total_importe.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX20
            // 
            // 
            // 
            // 
            this.labelX20.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX20.Location = new System.Drawing.Point(100, 38);
            this.labelX20.Name = "labelX20";
            this.labelX20.Size = new System.Drawing.Size(219, 34);
            this.labelX20.TabIndex = 21;
            this.labelX20.Text = "PEDIDO";
            this.labelX20.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lb_nombreEmpresa
            // 
            // 
            // 
            // 
            this.lb_nombreEmpresa.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_nombreEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nombreEmpresa.Location = new System.Drawing.Point(90, 9);
            this.lb_nombreEmpresa.Name = "lb_nombreEmpresa";
            this.lb_nombreEmpresa.Size = new System.Drawing.Size(219, 22);
            this.lb_nombreEmpresa.TabIndex = 20;
            this.lb_nombreEmpresa.Text = "labelX19";
            this.lb_nombreEmpresa.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lb_numero
            // 
            // 
            // 
            // 
            this.lb_numero.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_numero.Location = new System.Drawing.Point(396, 27);
            this.lb_numero.Name = "lb_numero";
            this.lb_numero.Size = new System.Drawing.Size(111, 23);
            this.lb_numero.TabIndex = 18;
            this.lb_numero.Text = "labelX17";
            // 
            // lb_nit
            // 
            // 
            // 
            // 
            this.lb_nit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_nit.Location = new System.Drawing.Point(396, 8);
            this.lb_nit.Name = "lb_nit";
            this.lb_nit.Size = new System.Drawing.Size(111, 23);
            this.lb_nit.TabIndex = 17;
            this.lb_nit.Text = "labelX16";
            // 
            // labelX14
            // 
            // 
            // 
            // 
            this.labelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX14.Location = new System.Drawing.Point(315, 28);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(75, 23);
            this.labelX14.TabIndex = 15;
            this.labelX14.Text = "Nro.:";
            this.labelX14.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX13
            // 
            // 
            // 
            // 
            this.labelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX13.Location = new System.Drawing.Point(315, 9);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(75, 23);
            this.labelX13.TabIndex = 14;
            this.labelX13.Text = "Nit:";
            this.labelX13.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_cancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_cancelar.Image = global::facturacion.Properties.Resources.error;
            this.btn_cancelar.Location = new System.Drawing.Point(274, 422);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(116, 49);
            this.btn_cancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_cancelar.TabIndex = 12;
            this.btn_cancelar.Text = "CANCELAR";
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(254, 383);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(75, 23);
            this.labelX10.TabIndex = 8;
            this.labelX10.Text = "Importe Total:";
            this.labelX10.TextAlignment = System.Drawing.StringAlignment.Far;
            this.labelX10.Click += new System.EventHandler(this.labelX10_Click);
            // 
            // lb_fecActual
            // 
            // 
            // 
            // 
            this.lb_fecActual.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_fecActual.Location = new System.Drawing.Point(81, 383);
            this.lb_fecActual.Name = "lb_fecActual";
            this.lb_fecActual.Size = new System.Drawing.Size(158, 23);
            this.lb_fecActual.TabIndex = 7;
            this.lb_fecActual.Text = "labelX9";
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(9, 383);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(75, 23);
            this.labelX8.TabIndex = 6;
            this.labelX8.Text = "Fecha actual";
            // 
            // lista
            // 
            this.lista.AllowUserToAddRows = false;
            this.lista.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(205)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.codigo,
            this.cantidad,
            this.descripcion,
            this.precio,
            this.total});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(205)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lista.DefaultCellStyle = dataGridViewCellStyle2;
            this.lista.EnableHeadersVisualStyles = false;
            this.lista.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.lista.Location = new System.Drawing.Point(3, 255);
            this.lista.Name = "lista";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lista.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.lista.RowHeadersVisible = false;
            this.lista.Size = new System.Drawing.Size(387, 126);
            this.lista.TabIndex = 5;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "COD";
            this.codigo.Name = "codigo";
            this.codigo.Width = 45;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "CANT";
            this.cantidad.Name = "cantidad";
            this.cantidad.Width = 45;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "DESCRIPCION";
            this.descripcion.Name = "descripcion";
            this.descripcion.Width = 194;
            // 
            // precio
            // 
            this.precio.HeaderText = "P/U";
            this.precio.Name = "precio";
            this.precio.Width = 50;
            // 
            // total
            // 
            this.total.HeaderText = "TOTAL";
            this.total.Name = "total";
            this.total.Width = 50;
            // 
            // pb_imagen_empresa
            // 
            this.pb_imagen_empresa.Location = new System.Drawing.Point(3, 3);
            this.pb_imagen_empresa.Name = "pb_imagen_empresa";
            this.pb_imagen_empresa.Size = new System.Drawing.Size(71, 69);
            this.pb_imagen_empresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_imagen_empresa.TabIndex = 4;
            this.pb_imagen_empresa.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pb_imagen_producto);
            this.groupBox4.Location = new System.Drawing.Point(396, 255);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(108, 126);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Img. Producto";
            // 
            // pb_imagen_producto
            // 
            this.pb_imagen_producto.Location = new System.Drawing.Point(0, 19);
            this.pb_imagen_producto.Name = "pb_imagen_producto";
            this.pb_imagen_producto.Size = new System.Drawing.Size(108, 107);
            this.pb_imagen_producto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_imagen_producto.TabIndex = 0;
            this.pb_imagen_producto.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.db_precio);
            this.groupBox3.Controls.Add(this.tb_descripcion);
            this.groupBox3.Controls.Add(this.labelX9);
            this.groupBox3.Controls.Add(this.btn_añadir);
            this.groupBox3.Controls.Add(this.tb_cantidad);
            this.groupBox3.Controls.Add(this.cb_producto);
            this.groupBox3.Controls.Add(this.labelX7);
            this.groupBox3.Controls.Add(this.tb_extra);
            this.groupBox3.Controls.Add(this.labelX5);
            this.groupBox3.Controls.Add(this.labelX2);
            this.groupBox3.Controls.Add(this.labelX1);
            this.groupBox3.Location = new System.Drawing.Point(3, 78);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(501, 121);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos De Pedido";
            // 
            // db_precio
            // 
            // 
            // 
            // 
            this.db_precio.Border.Class = "TextBoxBorder";
            this.db_precio.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.db_precio.Location = new System.Drawing.Point(361, 16);
            this.db_precio.Name = "db_precio";
            this.db_precio.PreventEnterBeep = true;
            this.db_precio.Size = new System.Drawing.Size(58, 20);
            this.db_precio.TabIndex = 15;
            this.db_precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.db_precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.db_precio_KeyPress);
            // 
            // tb_descripcion
            // 
            this.tb_descripcion.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_descripcion.Border.Class = "TextBoxBorder";
            this.tb_descripcion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_descripcion.DisabledBackColor = System.Drawing.Color.White;
            this.tb_descripcion.Enabled = false;
            this.tb_descripcion.ForeColor = System.Drawing.Color.Black;
            this.tb_descripcion.Location = new System.Drawing.Point(60, 44);
            this.tb_descripcion.Multiline = true;
            this.tb_descripcion.Name = "tb_descripcion";
            this.tb_descripcion.PreventEnterBeep = true;
            this.tb_descripcion.Size = new System.Drawing.Size(359, 41);
            this.tb_descripcion.TabIndex = 14;
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(6, 39);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(56, 23);
            this.labelX9.TabIndex = 13;
            this.labelX9.Text = "Descrip.:";
            // 
            // btn_añadir
            // 
            this.btn_añadir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_añadir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_añadir.Image = global::facturacion.Properties.Resources.Plus;
            this.btn_añadir.Location = new System.Drawing.Point(426, 9);
            this.btn_añadir.Name = "btn_añadir";
            this.btn_añadir.Size = new System.Drawing.Size(69, 76);
            this.btn_añadir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_añadir.TabIndex = 5;
            this.btn_añadir.Click += new System.EventHandler(this.btn_añadir_Click);
            // 
            // tb_cantidad
            // 
            this.tb_cantidad.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_cantidad.Border.Class = "TextBoxBorder";
            this.tb_cantidad.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_cantidad.DisabledBackColor = System.Drawing.Color.White;
            this.tb_cantidad.ForeColor = System.Drawing.Color.Black;
            this.tb_cantidad.Location = new System.Drawing.Point(271, 15);
            this.tb_cantidad.Name = "tb_cantidad";
            this.tb_cantidad.PreventEnterBeep = true;
            this.tb_cantidad.Size = new System.Drawing.Size(34, 20);
            this.tb_cantidad.TabIndex = 10;
            this.tb_cantidad.Text = "1";
            this.tb_cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_cantidad_KeyPress);
            // 
            // cb_producto
            // 
            this.cb_producto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_producto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_producto.DataSource = this.mProductoBindingSource;
            this.cb_producto.DisplayMember = "codigo";
            this.cb_producto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_producto.DropDownColumns = "nombre,codigo,precio";
            this.cb_producto.ForeColor = System.Drawing.Color.Black;
            this.cb_producto.FormattingEnabled = true;
            this.cb_producto.ItemHeight = 14;
            this.cb_producto.Location = new System.Drawing.Point(60, 15);
            this.cb_producto.Name = "cb_producto";
            this.cb_producto.Size = new System.Drawing.Size(142, 20);
            this.cb_producto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_producto.TabIndex = 6;
            this.cb_producto.SelectedIndexChanged += new System.EventHandler(this.cb_producto_SelectedIndexChanged);
            // 
            // mProductoBindingSource
            // 
            this.mProductoBindingSource.DataSource = typeof(Modelos.MProducto);
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(208, 15);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(57, 23);
            this.labelX7.TabIndex = 4;
            this.labelX7.Text = "Cantidad:";
            // 
            // tb_extra
            // 
            this.tb_extra.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_extra.Border.Class = "TextBoxBorder";
            this.tb_extra.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_extra.DisabledBackColor = System.Drawing.Color.White;
            this.tb_extra.ForeColor = System.Drawing.Color.Black;
            this.tb_extra.Location = new System.Drawing.Point(60, 91);
            this.tb_extra.Name = "tb_extra";
            this.tb_extra.PreventEnterBeep = true;
            this.tb_extra.Size = new System.Drawing.Size(359, 20);
            this.tb_extra.TabIndex = 7;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(312, 15);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(43, 23);
            this.labelX5.TabIndex = 2;
            this.labelX5.Text = "Precio:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(6, 91);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(48, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Pedido:";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(6, 15);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(56, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Producto:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_nombreAp);
            this.groupBox2.Controls.Add(this.cb_ci_nit);
            this.groupBox2.Controls.Add(this.btn_guardar);
            this.groupBox2.Controls.Add(this.labelX3);
            this.groupBox2.Controls.Add(this.labelX4);
            this.groupBox2.Location = new System.Drawing.Point(3, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(501, 44);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del cliente";
            // 
            // tb_nombreAp
            // 
            this.tb_nombreAp.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_nombreAp.Border.Class = "TextBoxBorder";
            this.tb_nombreAp.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_nombreAp.DisabledBackColor = System.Drawing.Color.White;
            this.tb_nombreAp.ForeColor = System.Drawing.Color.Black;
            this.tb_nombreAp.Location = new System.Drawing.Point(251, 18);
            this.tb_nombreAp.Name = "tb_nombreAp";
            this.tb_nombreAp.PreventEnterBeep = true;
            this.tb_nombreAp.Size = new System.Drawing.Size(168, 20);
            this.tb_nombreAp.TabIndex = 9;
            // 
            // cb_ci_nit
            // 
            this.cb_ci_nit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_ci_nit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_ci_nit.DataSource = this.mClientesBindingSource;
            this.cb_ci_nit.DisplayMember = "ci";
            this.cb_ci_nit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_ci_nit.DropDownColumns = "nombre,ci";
            this.cb_ci_nit.ForeColor = System.Drawing.Color.Black;
            this.cb_ci_nit.FormattingEnabled = true;
            this.cb_ci_nit.ItemHeight = 14;
            this.cb_ci_nit.Location = new System.Drawing.Point(51, 18);
            this.cb_ci_nit.Name = "cb_ci_nit";
            this.cb_ci_nit.Size = new System.Drawing.Size(102, 20);
            this.cb_ci_nit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_ci_nit.TabIndex = 8;
            this.cb_ci_nit.SelectedIndexChanged += new System.EventHandler(this.cb_ci_nit_SelectedIndexChanged);
            this.cb_ci_nit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_ci_nit_KeyDown);
            // 
            // mClientesBindingSource
            // 
            this.mClientesBindingSource.DataSource = typeof(Modelos.MClientes);
            // 
            // btn_guardar
            // 
            this.btn_guardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_guardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_guardar.Location = new System.Drawing.Point(426, 15);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(69, 23);
            this.btn_guardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_guardar.TabIndex = 7;
            this.btn_guardar.Text = "GUARDAR";
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(170, 18);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 20);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "Nombre y Ap.:";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(6, 18);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(39, 20);
            this.labelX4.TabIndex = 6;
            this.labelX4.Text = "CI/NIT:";
            // 
            // mDetalleVentaBindingSource
            // 
            this.mDetalleVentaBindingSource.DataSource = typeof(Modelos.MDetalleVenta);
            // 
            // VVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelEx1);
            this.Name = "VVentas";
            this.Size = new System.Drawing.Size(507, 482);
            this.Load += new System.EventHandler(this.VVentas_Load);
            this.panelEx1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qr_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagen_empresa)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagen_producto)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mProductoBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDetalleVentaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX lb_fecActual;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.DataGridViewX lista;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.PictureBox pb_imagen_empresa;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX20;
        private DevComponents.DotNetBar.LabelX lb_nombreEmpresa;
        private DevComponents.DotNetBar.LabelX lb_numero;
        private DevComponents.DotNetBar.LabelX lb_nit;
        private DevComponents.DotNetBar.LabelX labelX14;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.ButtonX btn_cancelar;
        private DevComponents.DotNetBar.ButtonX btn_cobrar;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_cantidad;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_extra;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_producto;
        private DevComponents.DotNetBar.ButtonX btn_añadir;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_nombreAp;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_ci_nit;
        private DevComponents.DotNetBar.ButtonX btn_guardar;
        private System.Windows.Forms.PictureBox pb_imagen_producto;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_descripcion;
        private System.Windows.Forms.BindingSource mProductoBindingSource;
        private System.Windows.Forms.BindingSource mClientesBindingSource;
        private DevComponents.DotNetBar.LabelX lb_total_importe;
        private Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl qr_image;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btn_facturar;
        private System.Windows.Forms.BindingSource mDetalleVentaBindingSource;
        private DevComponents.DotNetBar.Controls.TextBoxX db_precio;
    }
}
