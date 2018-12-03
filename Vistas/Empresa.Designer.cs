namespace facturacion.Vistas
{
    partial class Empresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empresa));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_propietario = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_sigla = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_direccion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_telefono = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.btn_subir = new DevComponents.DotNetBar.ButtonX();
            this.btn_editar = new DevComponents.DotNetBar.ButtonX();
            this.btn_guardar = new DevComponents.DotNetBar.ButtonX();
            this.btn_cancelar = new DevComponents.DotNetBar.ButtonX();
            this.tb_nit = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_nombre = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.pb_empresa = new System.Windows.Forms.PictureBox();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.panelEx1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_empresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.groupBox1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(445, 301);
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
            this.groupBox1.Controls.Add(this.tb_propietario);
            this.groupBox1.Controls.Add(this.tb_sigla);
            this.groupBox1.Controls.Add(this.tb_direccion);
            this.groupBox1.Controls.Add(this.tb_telefono);
            this.groupBox1.Controls.Add(this.labelX7);
            this.groupBox1.Controls.Add(this.labelX6);
            this.groupBox1.Controls.Add(this.labelX5);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.btn_subir);
            this.groupBox1.Controls.Add(this.btn_editar);
            this.groupBox1.Controls.Add(this.btn_guardar);
            this.groupBox1.Controls.Add(this.btn_cancelar);
            this.groupBox1.Controls.Add(this.tb_nit);
            this.groupBox1.Controls.Add(this.tb_nombre);
            this.groupBox1.Controls.Add(this.pb_empresa);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 275);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REGISTRO DE EMPRESA";
            // 
            // tb_propietario
            // 
            this.tb_propietario.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_propietario.Border.Class = "TextBoxBorder";
            this.tb_propietario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_propietario.DisabledBackColor = System.Drawing.Color.White;
            this.tb_propietario.ForeColor = System.Drawing.Color.Black;
            this.tb_propietario.Location = new System.Drawing.Point(163, 89);
            this.tb_propietario.Name = "tb_propietario";
            this.tb_propietario.PreventEnterBeep = true;
            this.tb_propietario.Size = new System.Drawing.Size(144, 20);
            this.tb_propietario.TabIndex = 19;
            // 
            // tb_sigla
            // 
            this.tb_sigla.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_sigla.Border.Class = "TextBoxBorder";
            this.tb_sigla.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_sigla.DisabledBackColor = System.Drawing.Color.White;
            this.tb_sigla.ForeColor = System.Drawing.Color.Black;
            this.tb_sigla.Location = new System.Drawing.Point(103, 192);
            this.tb_sigla.Name = "tb_sigla";
            this.tb_sigla.PreventEnterBeep = true;
            this.tb_sigla.Size = new System.Drawing.Size(88, 20);
            this.tb_sigla.TabIndex = 18;
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
            this.tb_direccion.Location = new System.Drawing.Point(163, 115);
            this.tb_direccion.Name = "tb_direccion";
            this.tb_direccion.PreventEnterBeep = true;
            this.tb_direccion.Size = new System.Drawing.Size(144, 20);
            this.tb_direccion.TabIndex = 17;
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
            this.tb_telefono.Location = new System.Drawing.Point(283, 192);
            this.tb_telefono.Name = "tb_telefono";
            this.tb_telefono.PreventEnterBeep = true;
            this.tb_telefono.Size = new System.Drawing.Size(88, 20);
            this.tb_telefono.TabIndex = 16;
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(223, 189);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(55, 23);
            this.labelX7.TabIndex = 15;
            this.labelX7.Text = "Telefono:";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(103, 112);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(55, 23);
            this.labelX6.TabIndex = 14;
            this.labelX6.Text = "Direccion:";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(73, 189);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(34, 23);
            this.labelX5.TabIndex = 13;
            this.labelX5.Text = "Sigla:";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(48, 87);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(109, 25);
            this.labelX4.TabIndex = 11;
            this.labelX4.Text = "Propietario:";
            this.labelX4.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // btn_subir
            // 
            this.btn_subir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_subir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_subir.Location = new System.Drawing.Point(315, 156);
            this.btn_subir.Name = "btn_subir";
            this.btn_subir.Size = new System.Drawing.Size(109, 25);
            this.btn_subir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_subir.TabIndex = 10;
            this.btn_subir.Text = "SUBIR IMAGEN";
            this.btn_subir.Click += new System.EventHandler(this.btn_subir_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_editar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_editar.Location = new System.Drawing.Point(265, 230);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(85, 31);
            this.btn_editar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_editar.TabIndex = 9;
            this.btn_editar.Text = "EDITAR";
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_guardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_guardar.Location = new System.Drawing.Point(164, 230);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(85, 31);
            this.btn_guardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_guardar.TabIndex = 8;
            this.btn_guardar.Text = "GUARDAR";
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_cancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_cancelar.Location = new System.Drawing.Point(20, 230);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(44, 31);
            this.btn_cancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_cancelar.TabIndex = 7;
            this.btn_cancelar.Text = "ATRAS";
            // 
            // tb_nit
            // 
            this.tb_nit.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_nit.Border.Class = "TextBoxBorder";
            this.tb_nit.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_nit.DisabledBackColor = System.Drawing.Color.White;
            this.tb_nit.ForeColor = System.Drawing.Color.Black;
            this.tb_nit.Location = new System.Drawing.Point(164, 63);
            this.tb_nit.Name = "tb_nit";
            this.tb_nit.PreventEnterBeep = true;
            this.tb_nit.Size = new System.Drawing.Size(144, 20);
            this.tb_nit.TabIndex = 6;
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
            this.tb_nombre.Location = new System.Drawing.Point(164, 37);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.PreventEnterBeep = true;
            this.tb_nombre.Size = new System.Drawing.Size(145, 20);
            this.tb_nombre.TabIndex = 4;
            // 
            // pb_empresa
            // 
            this.pb_empresa.Image = global::facturacion.Properties.Resources.Gears;
            this.pb_empresa.Location = new System.Drawing.Point(315, 37);
            this.pb_empresa.Name = "pb_empresa";
            this.pb_empresa.Size = new System.Drawing.Size(109, 113);
            this.pb_empresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_empresa.TabIndex = 3;
            this.pb_empresa.TabStop = false;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(9, 60);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(148, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "Nro. Iden. Tributaria:";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(45, 37);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(113, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Nombre de Empresa:";
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
            // Empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelEx1);
            this.Name = "Empresa";
            this.Size = new System.Drawing.Size(445, 301);
            this.panelEx1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_empresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btn_subir;
        private DevComponents.DotNetBar.ButtonX btn_editar;
        private DevComponents.DotNetBar.ButtonX btn_guardar;
        private DevComponents.DotNetBar.ButtonX btn_cancelar;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_nit;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_nombre;
        private System.Windows.Forms.PictureBox pb_empresa;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_sigla;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_direccion;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_telefono;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_propietario;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
    }
}
