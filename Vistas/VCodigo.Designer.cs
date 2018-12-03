namespace facturacion.Vistas
{
    partial class VCodigo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.lb_codigo = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lista_codigo = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dt_fech_final = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dt_fec_inicio = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btn_cancelar = new DevComponents.DotNetBar.ButtonX();
            this.btn_guardar = new DevComponents.DotNetBar.ButtonX();
            this.tb_clave = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.tb_autorizacion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panelEx1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista_codigo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_fech_final)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_fec_inicio)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.lb_codigo);
            this.panelEx1.Controls.Add(this.labelX4);
            this.panelEx1.Controls.Add(this.groupBox2);
            this.panelEx1.Controls.Add(this.groupBox1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(437, 311);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // lb_codigo
            // 
            // 
            // 
            // 
            this.lb_codigo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_codigo.Location = new System.Drawing.Point(63, 288);
            this.lb_codigo.Name = "lb_codigo";
            this.lb_codigo.Size = new System.Drawing.Size(374, 23);
            this.lb_codigo.TabIndex = 3;
            this.lb_codigo.Text = "--";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(9, 291);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(48, 17);
            this.labelX4.TabIndex = 2;
            this.labelX4.Text = "Codigo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lista_codigo);
            this.groupBox2.Location = new System.Drawing.Point(226, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 275);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LISTA";
            // 
            // lista_codigo
            // 
            this.lista_codigo.AllowUserToAddRows = false;
            this.lista_codigo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lista_codigo.BackgroundColor = System.Drawing.Color.White;
            this.lista_codigo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lista_codigo.DefaultCellStyle = dataGridViewCellStyle1;
            this.lista_codigo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.lista_codigo.Location = new System.Drawing.Point(6, 19);
            this.lista_codigo.Name = "lista_codigo";
            this.lista_codigo.RowHeadersVisible = false;
            this.lista_codigo.Size = new System.Drawing.Size(196, 250);
            this.lista_codigo.TabIndex = 0;
            this.lista_codigo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lista_codigo_CellClick);
            this.lista_codigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lista_codigo_KeyUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_autorizacion);
            this.groupBox1.Controls.Add(this.labelX5);
            this.groupBox1.Controls.Add(this.dt_fech_final);
            this.groupBox1.Controls.Add(this.dt_fec_inicio);
            this.groupBox1.Controls.Add(this.btn_cancelar);
            this.groupBox1.Controls.Add(this.btn_guardar);
            this.groupBox1.Controls.Add(this.tb_clave);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Location = new System.Drawing.Point(3, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 275);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REGISTRO DE CODIGO";
            // 
            // dt_fech_final
            // 
            // 
            // 
            // 
            this.dt_fech_final.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dt_fech_final.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dt_fech_final.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dt_fech_final.ButtonDropDown.Visible = true;
            this.dt_fech_final.IsPopupCalendarOpen = false;
            this.dt_fech_final.Location = new System.Drawing.Point(99, 76);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dt_fech_final.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dt_fech_final.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dt_fech_final.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dt_fech_final.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dt_fech_final.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dt_fech_final.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dt_fech_final.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dt_fech_final.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dt_fech_final.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dt_fech_final.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dt_fech_final.MonthCalendar.DisplayMonth = new System.DateTime(2018, 6, 1, 0, 0, 0, 0);
            this.dt_fech_final.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dt_fech_final.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dt_fech_final.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dt_fech_final.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dt_fech_final.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dt_fech_final.MonthCalendar.TodayButtonVisible = true;
            this.dt_fech_final.Name = "dt_fech_final";
            this.dt_fech_final.Size = new System.Drawing.Size(112, 20);
            this.dt_fech_final.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dt_fech_final.TabIndex = 9;
            // 
            // dt_fec_inicio
            // 
            // 
            // 
            // 
            this.dt_fec_inicio.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dt_fec_inicio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dt_fec_inicio.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dt_fec_inicio.ButtonDropDown.Visible = true;
            this.dt_fec_inicio.IsPopupCalendarOpen = false;
            this.dt_fec_inicio.Location = new System.Drawing.Point(99, 40);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dt_fec_inicio.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dt_fec_inicio.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dt_fec_inicio.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dt_fec_inicio.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dt_fec_inicio.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dt_fec_inicio.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dt_fec_inicio.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dt_fec_inicio.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dt_fec_inicio.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dt_fec_inicio.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dt_fec_inicio.MonthCalendar.DisplayMonth = new System.DateTime(2018, 6, 1, 0, 0, 0, 0);
            this.dt_fec_inicio.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dt_fec_inicio.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dt_fec_inicio.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dt_fec_inicio.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dt_fec_inicio.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dt_fec_inicio.MonthCalendar.TodayButtonVisible = true;
            this.dt_fec_inicio.Name = "dt_fec_inicio";
            this.dt_fec_inicio.Size = new System.Drawing.Size(112, 20);
            this.dt_fec_inicio.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dt_fec_inicio.TabIndex = 8;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_cancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_cancelar.Location = new System.Drawing.Point(112, 215);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_cancelar.TabIndex = 7;
            this.btn_cancelar.Text = "CANCELAR";
            // 
            // btn_guardar
            // 
            this.btn_guardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_guardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_guardar.Location = new System.Drawing.Point(18, 215);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_guardar.TabIndex = 6;
            this.btn_guardar.Text = "GUARDAR";
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // tb_clave
            // 
            this.tb_clave.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_clave.Border.Class = "TextBoxBorder";
            this.tb_clave.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_clave.DisabledBackColor = System.Drawing.Color.White;
            this.tb_clave.ForeColor = System.Drawing.Color.Black;
            this.tb_clave.Location = new System.Drawing.Point(47, 134);
            this.tb_clave.Multiline = true;
            this.tb_clave.Name = "tb_clave";
            this.tb_clave.PreventEnterBeep = true;
            this.tb_clave.Size = new System.Drawing.Size(164, 75);
            this.tb_clave.TabIndex = 5;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(6, 134);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(35, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "Clave:";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(12, 76);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(81, 20);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Fecha Final:";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 40);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(81, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Fecha de Inicio:";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(18, 105);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 10;
            this.labelX5.Text = "Autorizacion:";
            this.labelX5.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // tb_autorizacion
            // 
            // 
            // 
            // 
            this.tb_autorizacion.Border.Class = "TextBoxBorder";
            this.tb_autorizacion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_autorizacion.Location = new System.Drawing.Point(99, 105);
            this.tb_autorizacion.Name = "tb_autorizacion";
            this.tb_autorizacion.PreventEnterBeep = true;
            this.tb_autorizacion.Size = new System.Drawing.Size(112, 20);
            this.tb_autorizacion.TabIndex = 11;
            // 
            // VCodigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelEx1);
            this.Name = "VCodigo";
            this.Size = new System.Drawing.Size(437, 311);
            this.panelEx1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lista_codigo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dt_fech_final)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_fec_inicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.LabelX lb_codigo;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.Controls.DataGridViewX lista_codigo;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btn_cancelar;
        private DevComponents.DotNetBar.ButtonX btn_guardar;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_clave;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dt_fech_final;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dt_fec_inicio;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_autorizacion;
        private DevComponents.DotNetBar.LabelX labelX5;
    }
}
