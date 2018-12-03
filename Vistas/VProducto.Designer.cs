namespace facturacion.Vistas
{
    partial class VProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VProducto));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_buscar = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.lista_productos = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_cancelar = new DevComponents.DotNetBar.ButtonX();
            this.btn_guardar = new DevComponents.DotNetBar.ButtonX();
            this.btn_editar = new DevComponents.DotNetBar.ButtonX();
            this.btn_eliminar = new DevComponents.DotNetBar.ButtonX();
            this.btn_subir = new DevComponents.DotNetBar.ButtonX();
            this.btn_nuevo = new DevComponents.DotNetBar.ButtonX();
            this.tb_unidad = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_precio = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_codigo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_nombre = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_descripcion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.pb_imagen = new System.Windows.Forms.PictureBox();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.panelEx1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista_productos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.groupBox2);
            this.panelEx1.Controls.Add(this.groupBox1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(532, 343);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_buscar);
            this.groupBox2.Controls.Add(this.labelX6);
            this.groupBox2.Controls.Add(this.lista_productos);
            this.groupBox2.Location = new System.Drawing.Point(270, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 337);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LISTA DE PRODUCTOS";
            // 
            // tb_buscar
            // 
            this.tb_buscar.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_buscar.Border.Class = "TextBoxBorder";
            this.tb_buscar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_buscar.DisabledBackColor = System.Drawing.Color.White;
            this.tb_buscar.ForeColor = System.Drawing.Color.Black;
            this.tb_buscar.Location = new System.Drawing.Point(128, 32);
            this.tb_buscar.Name = "tb_buscar";
            this.tb_buscar.PreventEnterBeep = true;
            this.tb_buscar.Size = new System.Drawing.Size(125, 20);
            this.tb_buscar.TabIndex = 2;
            this.tb_buscar.TextChanged += new System.EventHandler(this.tb_buscar_TextChanged);
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(73, 29);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(49, 23);
            this.labelX6.TabIndex = 1;
            this.labelX6.Text = "Buscar:";
            // 
            // lista_productos
            // 
            this.lista_productos.AllowUserToAddRows = false;
            this.lista_productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lista_productos.BackgroundColor = System.Drawing.Color.White;
            this.lista_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lista_productos.DefaultCellStyle = dataGridViewCellStyle1;
            this.lista_productos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.lista_productos.Location = new System.Drawing.Point(6, 61);
            this.lista_productos.Name = "lista_productos";
            this.lista_productos.RowHeadersVisible = false;
            this.lista_productos.Size = new System.Drawing.Size(247, 258);
            this.lista_productos.TabIndex = 0;
            this.lista_productos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lista_productos_CellClick);
            this.lista_productos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lista_productos_KeyUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_cancelar);
            this.groupBox1.Controls.Add(this.btn_guardar);
            this.groupBox1.Controls.Add(this.btn_editar);
            this.groupBox1.Controls.Add(this.btn_eliminar);
            this.groupBox1.Controls.Add(this.btn_subir);
            this.groupBox1.Controls.Add(this.btn_nuevo);
            this.groupBox1.Controls.Add(this.tb_unidad);
            this.groupBox1.Controls.Add(this.tb_precio);
            this.groupBox1.Controls.Add(this.tb_codigo);
            this.groupBox1.Controls.Add(this.tb_nombre);
            this.groupBox1.Controls.Add(this.tb_descripcion);
            this.groupBox1.Controls.Add(this.pb_imagen);
            this.groupBox1.Controls.Add(this.labelX5);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 337);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REGISTRO DE PRODUCTOS";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_cancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_cancelar.Location = new System.Drawing.Point(148, 296);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(61, 23);
            this.btn_cancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_cancelar.TabIndex = 16;
            this.btn_cancelar.Text = "CANCELAR";
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_guardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_guardar.Location = new System.Drawing.Point(61, 296);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(61, 23);
            this.btn_guardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_guardar.TabIndex = 15;
            this.btn_guardar.Text = "GUARDAR";
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_editar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_editar.Location = new System.Drawing.Point(102, 267);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(61, 23);
            this.btn_editar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_editar.TabIndex = 14;
            this.btn_editar.Text = "EDITAR";
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_eliminar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_eliminar.Location = new System.Drawing.Point(194, 267);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(61, 23);
            this.btn_eliminar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_eliminar.TabIndex = 13;
            this.btn_eliminar.Text = "ELIMINAR";
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_subir
            // 
            this.btn_subir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_subir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_subir.Location = new System.Drawing.Point(171, 131);
            this.btn_subir.Name = "btn_subir";
            this.btn_subir.Size = new System.Drawing.Size(84, 23);
            this.btn_subir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_subir.TabIndex = 12;
            this.btn_subir.Text = "SUBIR IMAGEN";
            this.btn_subir.Click += new System.EventHandler(this.btn_subir_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_nuevo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_nuevo.Location = new System.Drawing.Point(14, 267);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(61, 23);
            this.btn_nuevo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_nuevo.TabIndex = 11;
            this.btn_nuevo.Text = "NUEVO";
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // tb_unidad
            // 
            this.tb_unidad.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_unidad.Border.Class = "TextBoxBorder";
            this.tb_unidad.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_unidad.DisabledBackColor = System.Drawing.Color.White;
            this.tb_unidad.ForeColor = System.Drawing.Color.Black;
            this.tb_unidad.Location = new System.Drawing.Point(61, 119);
            this.tb_unidad.Name = "tb_unidad";
            this.tb_unidad.PreventEnterBeep = true;
            this.tb_unidad.Size = new System.Drawing.Size(102, 20);
            this.tb_unidad.TabIndex = 10;
            // 
            // tb_precio
            // 
            this.tb_precio.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_precio.Border.Class = "TextBoxBorder";
            this.tb_precio.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_precio.DisabledBackColor = System.Drawing.Color.White;
            this.tb_precio.ForeColor = System.Drawing.Color.Black;
            this.tb_precio.Location = new System.Drawing.Point(61, 93);
            this.tb_precio.Name = "tb_precio";
            this.tb_precio.PreventEnterBeep = true;
            this.tb_precio.Size = new System.Drawing.Size(102, 20);
            this.tb_precio.TabIndex = 9;
            this.tb_precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_precio_KeyPress);
            // 
            // tb_codigo
            // 
            this.tb_codigo.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_codigo.Border.Class = "TextBoxBorder";
            this.tb_codigo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_codigo.DisabledBackColor = System.Drawing.Color.White;
            this.tb_codigo.ForeColor = System.Drawing.Color.Black;
            this.tb_codigo.Location = new System.Drawing.Point(61, 61);
            this.tb_codigo.Name = "tb_codigo";
            this.tb_codigo.PreventEnterBeep = true;
            this.tb_codigo.Size = new System.Drawing.Size(102, 20);
            this.tb_codigo.TabIndex = 8;
            // 
            // tb_nombre
            // 
            this.tb_nombre.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_nombre.Border.Class = "TextBoxBorder";
            this.tb_nombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_nombre.DisabledBackColor = System.Drawing.Color.White;
            this.tb_nombre.ForeColor = System.Drawing.Color.Black;
            this.tb_nombre.Location = new System.Drawing.Point(61, 35);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.PreventEnterBeep = true;
            this.tb_nombre.Size = new System.Drawing.Size(102, 20);
            this.tb_nombre.TabIndex = 7;
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
            this.tb_descripcion.ForeColor = System.Drawing.Color.Black;
            this.tb_descripcion.Location = new System.Drawing.Point(70, 169);
            this.tb_descripcion.Multiline = true;
            this.tb_descripcion.Name = "tb_descripcion";
            this.tb_descripcion.PreventEnterBeep = true;
            this.tb_descripcion.Size = new System.Drawing.Size(155, 81);
            this.tb_descripcion.TabIndex = 6;
            // 
            // pb_imagen
            // 
            this.pb_imagen.Image = global::facturacion.Properties.Resources.Warning_sign;
            this.pb_imagen.Location = new System.Drawing.Point(171, 35);
            this.pb_imagen.Name = "pb_imagen";
            this.pb_imagen.Size = new System.Drawing.Size(84, 90);
            this.pb_imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_imagen.TabIndex = 5;
            this.pb_imagen.TabStop = false;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(6, 166);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(69, 23);
            this.labelX5.TabIndex = 4;
            this.labelX5.Text = "Descripcion:";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(14, 119);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(45, 23);
            this.labelX4.TabIndex = 3;
            this.labelX4.Text = "Unidad:";
            this.labelX4.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(14, 90);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(43, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "Precio:";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(14, 61);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(43, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Codigo:";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(14, 32);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(45, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Nombre:";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // superValidator1
            // 
            this.superValidator1.ContainerControl = this;
            this.superValidator1.ErrorProvider = this.errorIcono;
            this.superValidator1.Highlighter = this.highlighter1;
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            this.errorIcono.Icon = ((System.Drawing.Icon)(resources.GetObject("errorIcono.Icon")));
            // 
            // highlighter1
            // 
            this.highlighter1.ContainerControl = this;
            // 
            // VProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelEx1);
            this.Name = "VProducto";
            this.Size = new System.Drawing.Size(532, 343);
            this.panelEx1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lista_productos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_buscar;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.DataGridViewX lista_productos;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btn_cancelar;
        private DevComponents.DotNetBar.ButtonX btn_guardar;
        private DevComponents.DotNetBar.ButtonX btn_editar;
        private DevComponents.DotNetBar.ButtonX btn_eliminar;
        private DevComponents.DotNetBar.ButtonX btn_subir;
        private DevComponents.DotNetBar.ButtonX btn_nuevo;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_unidad;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_precio;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_codigo;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_nombre;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_descripcion;
        private System.Windows.Forms.PictureBox pb_imagen;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
    }
}
