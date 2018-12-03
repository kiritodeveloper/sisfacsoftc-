namespace facturacion.Vistas
{
    partial class VCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VCliente));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_buscar = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.lista_clientes = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_cancelar = new DevComponents.DotNetBar.ButtonX();
            this.btn_guardar = new DevComponents.DotNetBar.ButtonX();
            this.btn_eliminar = new DevComponents.DotNetBar.ButtonX();
            this.btn_editar = new DevComponents.DotNetBar.ButtonX();
            this.btn_nuevo = new DevComponents.DotNetBar.ButtonX();
            this.tb_telefono = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_direccion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_ci = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_nombre = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.panelEx1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista_clientes)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.panelEx1.Size = new System.Drawing.Size(359, 467);
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
            this.groupBox2.Controls.Add(this.labelX5);
            this.groupBox2.Controls.Add(this.lista_clientes);
            this.groupBox2.Location = new System.Drawing.Point(3, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 256);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LISTA CLIENTES";
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
            this.tb_buscar.Location = new System.Drawing.Point(197, 14);
            this.tb_buscar.Name = "tb_buscar";
            this.tb_buscar.PreventEnterBeep = true;
            this.tb_buscar.Size = new System.Drawing.Size(142, 20);
            this.tb_buscar.TabIndex = 2;
            this.tb_buscar.TextChanged += new System.EventHandler(this.tb_buscar_TextChanged);
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(116, 15);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 15);
            this.labelX5.TabIndex = 1;
            this.labelX5.Text = "Buscar:";
            this.labelX5.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lista_clientes
            // 
            this.lista_clientes.AllowUserToAddRows = false;
            this.lista_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lista_clientes.BackgroundColor = System.Drawing.Color.White;
            this.lista_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lista_clientes.DefaultCellStyle = dataGridViewCellStyle1;
            this.lista_clientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.lista_clientes.Location = new System.Drawing.Point(6, 36);
            this.lista_clientes.Name = "lista_clientes";
            this.lista_clientes.RowHeadersVisible = false;
            this.lista_clientes.Size = new System.Drawing.Size(339, 214);
            this.lista_clientes.TabIndex = 0;
            this.lista_clientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lista_clientes_CellClick);
            this.lista_clientes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lista_clientes_KeyUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_cancelar);
            this.groupBox1.Controls.Add(this.btn_guardar);
            this.groupBox1.Controls.Add(this.btn_eliminar);
            this.groupBox1.Controls.Add(this.btn_editar);
            this.groupBox1.Controls.Add(this.btn_nuevo);
            this.groupBox1.Controls.Add(this.tb_telefono);
            this.groupBox1.Controls.Add(this.tb_direccion);
            this.groupBox1.Controls.Add(this.tb_ci);
            this.groupBox1.Controls.Add(this.tb_nombre);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REGISTRO CLIENTES";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_cancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_cancelar.Location = new System.Drawing.Point(210, 163);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_cancelar.TabIndex = 14;
            this.btn_cancelar.Text = "CANCELAR";
            // 
            // btn_guardar
            // 
            this.btn_guardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_guardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_guardar.Location = new System.Drawing.Point(91, 163);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 25);
            this.btn_guardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_guardar.TabIndex = 13;
            this.btn_guardar.Text = "GUARDAR";
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_eliminar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_eliminar.Location = new System.Drawing.Point(264, 134);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_eliminar.TabIndex = 12;
            this.btn_eliminar.Text = "ELIMINAR";
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_editar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_editar.Location = new System.Drawing.Point(152, 134);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 23);
            this.btn_editar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_editar.TabIndex = 11;
            this.btn_editar.Text = "EDITAR";
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_nuevo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_nuevo.Location = new System.Drawing.Point(38, 134);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(75, 23);
            this.btn_nuevo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_nuevo.TabIndex = 10;
            this.btn_nuevo.Text = "NUEVO";
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // tb_telefono
            // 
            this.tb_telefono.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_telefono.Border.Class = "TextBoxBorder";
            this.tb_telefono.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_telefono.DisabledBackColor = System.Drawing.Color.White;
            this.tb_telefono.ForeColor = System.Drawing.Color.Black;
            this.tb_telefono.Location = new System.Drawing.Point(128, 108);
            this.tb_telefono.Name = "tb_telefono";
            this.tb_telefono.PreventEnterBeep = true;
            this.tb_telefono.Size = new System.Drawing.Size(196, 20);
            this.tb_telefono.TabIndex = 8;
            // 
            // tb_direccion
            // 
            this.tb_direccion.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_direccion.Border.Class = "TextBoxBorder";
            this.tb_direccion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_direccion.DisabledBackColor = System.Drawing.Color.White;
            this.tb_direccion.ForeColor = System.Drawing.Color.Black;
            this.tb_direccion.Location = new System.Drawing.Point(128, 79);
            this.tb_direccion.Name = "tb_direccion";
            this.tb_direccion.PreventEnterBeep = true;
            this.tb_direccion.Size = new System.Drawing.Size(196, 20);
            this.tb_direccion.TabIndex = 7;
            // 
            // tb_ci
            // 
            this.tb_ci.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_ci.Border.Class = "TextBoxBorder";
            this.tb_ci.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_ci.DisabledBackColor = System.Drawing.Color.White;
            this.tb_ci.ForeColor = System.Drawing.Color.Black;
            this.tb_ci.Location = new System.Drawing.Point(128, 50);
            this.tb_ci.Name = "tb_ci";
            this.tb_ci.PreventEnterBeep = true;
            this.tb_ci.Size = new System.Drawing.Size(196, 20);
            this.tb_ci.TabIndex = 6;
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
            this.tb_nombre.Location = new System.Drawing.Point(128, 21);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.PreventEnterBeep = true;
            this.tb_nombre.Size = new System.Drawing.Size(196, 20);
            this.tb_nombre.TabIndex = 5;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(21, 105);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(101, 23);
            this.labelX4.TabIndex = 3;
            this.labelX4.Text = "Telefono:";
            this.labelX4.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(21, 76);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(101, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "Direccion:";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(21, 47);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(101, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "CI:";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(21, 18);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(101, 23);
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
            // VCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelEx1);
            this.Name = "VCliente";
            this.Size = new System.Drawing.Size(359, 467);
            this.panelEx1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lista_clientes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btn_cancelar;
        private DevComponents.DotNetBar.ButtonX btn_guardar;
        private DevComponents.DotNetBar.ButtonX btn_eliminar;
        private DevComponents.DotNetBar.ButtonX btn_editar;
        private DevComponents.DotNetBar.ButtonX btn_nuevo;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_telefono;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_direccion;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_ci;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_nombre;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.Controls.DataGridViewX lista_clientes;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_buscar;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
    }
}
