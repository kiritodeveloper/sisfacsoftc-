namespace facturacion.Vistas
{
    partial class VFacturas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Ver = new DevComponents.DotNetBar.ButtonX();
            this.dt_fin = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dt_inicio = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_it = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cb_iva = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.lista = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btn_cancelar = new DevComponents.DotNetBar.ButtonX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.lb_total_importe = new DevComponents.DotNetBar.LabelX();
            this.lb_importe_neto = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.lb_iva = new DevComponents.DotNetBar.LabelX();
            this.lb_it = new DevComponents.DotNetBar.LabelX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_fin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_inicio)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Ver);
            this.groupBox1.Controls.Add(this.dt_fin);
            this.groupBox1.Controls.Add(this.dt_inicio);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos para Reporte";
            // 
            // btn_Ver
            // 
            this.btn_Ver.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Ver.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Ver.Image = global::facturacion.Properties.Resources.Arrow_down;
            this.btn_Ver.Location = new System.Drawing.Point(202, 22);
            this.btn_Ver.Name = "btn_Ver";
            this.btn_Ver.Size = new System.Drawing.Size(149, 60);
            this.btn_Ver.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Ver.TabIndex = 4;
            this.btn_Ver.Text = "Ver Facturas";
            this.btn_Ver.Click += new System.EventHandler(this.btn_Ver_Click);
            // 
            // dt_fin
            // 
            // 
            // 
            // 
            this.dt_fin.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dt_fin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dt_fin.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dt_fin.ButtonDropDown.Visible = true;
            this.dt_fin.IsPopupCalendarOpen = false;
            this.dt_fin.Location = new System.Drawing.Point(83, 62);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dt_fin.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dt_fin.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dt_fin.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dt_fin.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dt_fin.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dt_fin.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dt_fin.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dt_fin.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dt_fin.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dt_fin.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dt_fin.MonthCalendar.DisplayMonth = new System.DateTime(2018, 6, 1, 0, 0, 0, 0);
            this.dt_fin.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dt_fin.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dt_fin.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dt_fin.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dt_fin.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dt_fin.MonthCalendar.TodayButtonVisible = true;
            this.dt_fin.Name = "dt_fin";
            this.dt_fin.Size = new System.Drawing.Size(97, 20);
            this.dt_fin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dt_fin.TabIndex = 3;
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
            this.dt_inicio.Location = new System.Drawing.Point(83, 22);
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
            this.dt_inicio.Size = new System.Drawing.Size(97, 20);
            this.dt_inicio.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dt_inicio.TabIndex = 2;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(6, 59);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(71, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Fecha Final:";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(6, 19);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(71, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Fecha Inicio:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_it);
            this.groupBox2.Controls.Add(this.cb_iva);
            this.groupBox2.Location = new System.Drawing.Point(366, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(127, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Descuentos";
            // 
            // cb_it
            // 
            // 
            // 
            // 
            this.cb_it.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cb_it.Location = new System.Drawing.Point(6, 51);
            this.cb_it.Name = "cb_it";
            this.cb_it.Size = new System.Drawing.Size(115, 23);
            this.cb_it.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_it.TabIndex = 1;
            this.cb_it.Text = "IT (3%)";
            this.cb_it.CheckedChanged += new System.EventHandler(this.cb_it_CheckedChanged);
            // 
            // cb_iva
            // 
            // 
            // 
            // 
            this.cb_iva.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cb_iva.Location = new System.Drawing.Point(6, 22);
            this.cb_iva.Name = "cb_iva";
            this.cb_iva.Size = new System.Drawing.Size(115, 23);
            this.cb_iva.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_iva.TabIndex = 0;
            this.cb_iva.Text = "IVA (13%)";
            this.cb_iva.CheckedChanged += new System.EventHandler(this.cb_iva_CheckedChanged);
            // 
            // lista
            // 
            this.lista.AllowUserToAddRows = false;
            this.lista.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(205)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lista.DefaultCellStyle = dataGridViewCellStyle2;
            this.lista.EnableHeadersVisualStyles = false;
            this.lista.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.lista.Location = new System.Drawing.Point(3, 109);
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
            this.lista.Size = new System.Drawing.Size(490, 316);
            this.lista.TabIndex = 2;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_cancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_cancelar.Location = new System.Drawing.Point(399, 460);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(94, 23);
            this.btn_cancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_cancelar.TabIndex = 3;
            this.btn_cancelar.Text = "<<< ATRAS";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(5, 431);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(94, 23);
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = "Total Importe:";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(3, 455);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(103, 23);
            this.labelX4.TabIndex = 5;
            this.labelX4.Text = "Ganancia Neta:";
            // 
            // lb_total_importe
            // 
            // 
            // 
            // 
            this.lb_total_importe.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_total_importe.Location = new System.Drawing.Point(112, 431);
            this.lb_total_importe.Name = "lb_total_importe";
            this.lb_total_importe.Size = new System.Drawing.Size(85, 23);
            this.lb_total_importe.TabIndex = 6;
            this.lb_total_importe.Text = "-";
            // 
            // lb_importe_neto
            // 
            // 
            // 
            // 
            this.lb_importe_neto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_importe_neto.Location = new System.Drawing.Point(112, 455);
            this.lb_importe_neto.Name = "lb_importe_neto";
            this.lb_importe_neto.Size = new System.Drawing.Size(71, 23);
            this.lb_importe_neto.TabIndex = 7;
            this.lb_importe_neto.Text = "-";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(217, 431);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(86, 23);
            this.labelX5.TabIndex = 8;
            this.labelX5.Text = "Descuento IVA:";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(217, 460);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 23);
            this.labelX6.TabIndex = 9;
            this.labelX6.Text = "Descuento IT:";
            // 
            // lb_iva
            // 
            // 
            // 
            // 
            this.lb_iva.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_iva.Location = new System.Drawing.Point(312, 433);
            this.lb_iva.Name = "lb_iva";
            this.lb_iva.Size = new System.Drawing.Size(81, 23);
            this.lb_iva.TabIndex = 10;
            this.lb_iva.Text = "-";
            // 
            // lb_it
            // 
            // 
            // 
            // 
            this.lb_it.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_it.Location = new System.Drawing.Point(312, 460);
            this.lb_it.Name = "lb_it";
            this.lb_it.Size = new System.Drawing.Size(81, 23);
            this.lb_it.TabIndex = 11;
            this.lb_it.Text = "-";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(399, 431);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(94, 23);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 12;
            this.buttonX1.Text = "Imprimir";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // VFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.lb_it);
            this.Controls.Add(this.lb_iva);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.lb_importe_neto);
            this.Controls.Add(this.lb_total_importe);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "VFacturas";
            this.Size = new System.Drawing.Size(496, 490);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dt_fin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_inicio)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dt_fin;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dt_inicio;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.ButtonX btn_Ver;
        private DevComponents.DotNetBar.Controls.CheckBoxX cb_it;
        private DevComponents.DotNetBar.Controls.CheckBoxX cb_iva;
        private DevComponents.DotNetBar.Controls.DataGridViewX lista;
        private DevComponents.DotNetBar.ButtonX btn_cancelar;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX lb_total_importe;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX lb_importe_neto;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX lb_iva;
        private DevComponents.DotNetBar.LabelX lb_it;
        private DevComponents.DotNetBar.ButtonX buttonX1;
    }
}
