namespace facturacion.Vistas
{
    partial class StartControl
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
            this.itemPanel1 = new DevComponents.DotNetBar.ItemPanel();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.empresaItem = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.codigoItem = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.reporteItem = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.producto = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.ventasItem = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.facturaItem = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.usuarioItem = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.listaventaItem = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.clienteItem = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.lb_user = new DevComponents.DotNetBar.LabelX();
            this.chartUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // itemPanel1
            // 
            this.itemPanel1.AutoScroll = true;
            // 
            // 
            // 
            this.itemPanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemPanel1.ContainerControlProcessDialogKey = true;
            this.itemPanel1.DragDropSupport = true;
            this.itemPanel1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer1});
            this.itemPanel1.Location = new System.Drawing.Point(3, 61);
            this.itemPanel1.Name = "itemPanel1";
            this.itemPanel1.Size = new System.Drawing.Size(572, 295);
            this.itemPanel1.TabIndex = 3;
            this.itemPanel1.Text = "itemPanel1";
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.ItemSpacing = 6;
            this.itemContainer1.MinimumSize = new System.Drawing.Size(560, 290);
            this.itemContainer1.MultiLine = true;
            this.itemContainer1.Name = "itemContainer1";
            this.itemContainer1.ResizeItemsToFit = false;
            this.itemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.empresaItem,
            this.codigoItem,
            this.reporteItem,
            this.producto,
            this.ventasItem,
            this.facturaItem,
            this.usuarioItem,
            this.listaventaItem,
            this.clienteItem});
            // 
            // 
            // 
            this.itemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // empresaItem
            // 
            this.empresaItem.Image = global::facturacion.Properties.Resources.Home;
            this.empresaItem.Name = "empresaItem";
            this.empresaItem.SymbolColor = System.Drawing.Color.Empty;
            this.empresaItem.Text = "<font size=\"+4\">Empresa<br/>Informacion</font>";
            this.empresaItem.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            // 
            // 
            // 
            this.empresaItem.TileStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.empresaItem.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(103)))), ((int)(((byte)(155)))));
            this.empresaItem.TileStyle.BackColorGradientAngle = 45;
            this.empresaItem.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.empresaItem.TileStyle.PaddingBottom = 4;
            this.empresaItem.TileStyle.PaddingLeft = 4;
            this.empresaItem.TileStyle.PaddingRight = 4;
            this.empresaItem.TileStyle.PaddingTop = 4;
            this.empresaItem.TileStyle.TextColor = System.Drawing.Color.White;
            this.empresaItem.TitleText = "empresa";
            // 
            // codigoItem
            // 
            this.codigoItem.Image = global::facturacion.Properties.Resources.Key;
            this.codigoItem.Name = "codigoItem";
            this.codigoItem.SymbolColor = System.Drawing.Color.Empty;
            this.codigoItem.Text = "<font size=\"+4\">Llave de<br/>Dosificación</font>";
            this.codigoItem.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Green;
            // 
            // 
            // 
            this.codigoItem.TileStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(151)))), ((int)(((byte)(42)))));
            this.codigoItem.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(177)))), ((int)(((byte)(51)))));
            this.codigoItem.TileStyle.BackColorGradientAngle = 45;
            this.codigoItem.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.codigoItem.TileStyle.PaddingBottom = 4;
            this.codigoItem.TileStyle.PaddingLeft = 4;
            this.codigoItem.TileStyle.PaddingRight = 4;
            this.codigoItem.TileStyle.PaddingTop = 4;
            this.codigoItem.TileStyle.TextColor = System.Drawing.Color.White;
            this.codigoItem.TitleText = "Codigo";
            // 
            // reporteItem
            // 
            this.reporteItem.Name = "reporteItem";
            this.reporteItem.SymbolColor = System.Drawing.Color.Empty;
            this.reporteItem.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Coffee;
            // 
            // 
            // 
            this.reporteItem.TileStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(76)))), ((int)(((byte)(41)))));
            this.reporteItem.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(67)))), ((int)(((byte)(37)))));
            this.reporteItem.TileStyle.BackColorGradientAngle = 45;
            this.reporteItem.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reporteItem.TileStyle.PaddingBottom = 4;
            this.reporteItem.TileStyle.PaddingLeft = 4;
            this.reporteItem.TileStyle.PaddingRight = 4;
            this.reporteItem.TileStyle.PaddingTop = 4;
            this.reporteItem.TileStyle.TextColor = System.Drawing.Color.White;
            this.reporteItem.TitleText = "Reportes";
            // 
            // producto
            // 
            this.producto.Image = global::facturacion.Properties.Resources.recipe_pizza_icon__1_;
            this.producto.Name = "producto";
            this.producto.SymbolColor = System.Drawing.Color.Empty;
            this.producto.Text = "<font size=\"+4\">Productos<br/></font>";
            this.producto.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Orange;
            // 
            // 
            // 
            this.producto.TileStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.producto.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(136)))), ((int)(((byte)(0)))));
            this.producto.TileStyle.BackColorGradientAngle = 45;
            this.producto.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.producto.TileStyle.PaddingBottom = 4;
            this.producto.TileStyle.PaddingLeft = 4;
            this.producto.TileStyle.PaddingRight = 4;
            this.producto.TileStyle.PaddingTop = 4;
            this.producto.TileStyle.TextColor = System.Drawing.Color.White;
            this.producto.TitleText = "Producto";
            // 
            // ventasItem
            // 
            this.ventasItem.Image = global::facturacion.Properties.Resources.Occupations_Pizza_Deliveryman_Female_Light_icon;
            this.ventasItem.Name = "ventasItem";
            this.ventasItem.SymbolColor = System.Drawing.Color.Empty;
            this.ventasItem.Text = "<font size=\"+4\">Registrar<br/>Pedido</font>";
            this.ventasItem.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.RedOrange;
            // 
            // 
            // 
            this.ventasItem.TileStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.ventasItem.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(57)))), ((int)(((byte)(0)))));
            this.ventasItem.TileStyle.BackColorGradientAngle = 45;
            this.ventasItem.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ventasItem.TileStyle.PaddingBottom = 4;
            this.ventasItem.TileStyle.PaddingLeft = 4;
            this.ventasItem.TileStyle.PaddingRight = 4;
            this.ventasItem.TileStyle.PaddingTop = 4;
            this.ventasItem.TileStyle.TextColor = System.Drawing.Color.White;
            this.ventasItem.TitleText = "Pedidos";
            // 
            // facturaItem
            // 
            this.facturaItem.Image = global::facturacion.Properties.Resources.Visa;
            this.facturaItem.Name = "facturaItem";
            this.facturaItem.SymbolColor = System.Drawing.Color.Empty;
            this.facturaItem.Text = "<font size=\"+4\">Lista de<br/>facturas</font>";
            this.facturaItem.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Magenta;
            // 
            // 
            // 
            this.facturaItem.TileStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(85)))), ((int)(((byte)(148)))));
            this.facturaItem.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(98)))), ((int)(((byte)(185)))));
            this.facturaItem.TileStyle.BackColorGradientAngle = 45;
            this.facturaItem.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.facturaItem.TileStyle.PaddingBottom = 4;
            this.facturaItem.TileStyle.PaddingLeft = 4;
            this.facturaItem.TileStyle.PaddingRight = 4;
            this.facturaItem.TileStyle.PaddingTop = 4;
            this.facturaItem.TileStyle.TextColor = System.Drawing.Color.White;
            this.facturaItem.TitleText = "facturas";
            // 
            // usuarioItem
            // 
            this.usuarioItem.Image = global::facturacion.Properties.Resources.User_black;
            this.usuarioItem.Name = "usuarioItem";
            this.usuarioItem.SymbolColor = System.Drawing.Color.Empty;
            this.usuarioItem.Text = "<font size=\"+4\">Usuario</font><br/><br/>";
            this.usuarioItem.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Blue;
            // 
            // 
            // 
            this.usuarioItem.TileStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(102)))), ((int)(((byte)(168)))));
            this.usuarioItem.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(120)))), ((int)(((byte)(190)))));
            this.usuarioItem.TileStyle.BackColorGradientAngle = 45;
            this.usuarioItem.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.usuarioItem.TileStyle.PaddingBottom = 4;
            this.usuarioItem.TileStyle.PaddingLeft = 4;
            this.usuarioItem.TileStyle.PaddingRight = 4;
            this.usuarioItem.TileStyle.PaddingTop = 4;
            this.usuarioItem.TileStyle.TextColor = System.Drawing.Color.White;
            this.usuarioItem.TitleText = "Usuario";
            // 
            // listaventaItem
            // 
            this.listaventaItem.Image = global::facturacion.Properties.Resources.Cart;
            this.listaventaItem.Name = "listaventaItem";
            this.listaventaItem.SymbolColor = System.Drawing.Color.Empty;
            this.listaventaItem.Text = "<font size=\"+4\">Ventas<br/>Registradas</font>";
            this.listaventaItem.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.RedViolet;
            // 
            // 
            // 
            this.listaventaItem.TileStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.listaventaItem.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
            this.listaventaItem.TileStyle.BackColorGradientAngle = 45;
            this.listaventaItem.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.listaventaItem.TileStyle.PaddingBottom = 4;
            this.listaventaItem.TileStyle.PaddingLeft = 4;
            this.listaventaItem.TileStyle.PaddingRight = 4;
            this.listaventaItem.TileStyle.PaddingTop = 4;
            this.listaventaItem.TileStyle.TextColor = System.Drawing.Color.White;
            this.listaventaItem.TitleText = "Ventas";
            // 
            // clienteItem
            // 
            this.clienteItem.Image = global::facturacion.Properties.Resources.User_male;
            this.clienteItem.Name = "clienteItem";
            this.clienteItem.SymbolColor = System.Drawing.Color.Empty;
            this.clienteItem.Text = "<font size=\"+4\">Clientes<br/></font>";
            this.clienteItem.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.PlumWashed;
            // 
            // 
            // 
            this.clienteItem.TileStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(55)))), ((int)(((byte)(76)))));
            this.clienteItem.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.clienteItem.TileStyle.BackColorGradientAngle = 45;
            this.clienteItem.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.clienteItem.TileStyle.PaddingBottom = 4;
            this.clienteItem.TileStyle.PaddingLeft = 4;
            this.clienteItem.TileStyle.PaddingRight = 4;
            this.clienteItem.TileStyle.PaddingTop = 4;
            this.clienteItem.TileStyle.TextColor = System.Drawing.Color.White;
            this.clienteItem.TitleText = "Cliente";
            // 
            // lb_user
            // 
            this.lb_user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lb_user.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_user.Location = new System.Drawing.Point(465, 7);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(88, 47);
            this.lb_user.TabIndex = 4;
            this.lb_user.Text = "<div align=\"right\"><font size=\"+4\">Wile</font><br/>E. Coyote</div>";
            // 
            // chartUpdateTimer
            // 
            this.chartUpdateTimer.Enabled = true;
            this.chartUpdateTimer.Interval = 5000;
            this.chartUpdateTimer.Tick += new System.EventHandler(this.chartUpdateTimer_Tick);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(3, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(289, 40);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "ACME Inc. Billing";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::facturacion.Properties.Resources.letras;
            this.pictureBox2.Location = new System.Drawing.Point(3, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(305, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Image = global::facturacion.Properties.Resources.User_black;
            this.buttonX1.Location = new System.Drawing.Point(606, 3);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(58, 59);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 7;
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // StartControl
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.lb_user);
            this.Controls.Add(this.itemPanel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "StartControl";
            this.Size = new System.Drawing.Size(667, 361);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Metro.MetroTileItem usuarioItem;
        private DevComponents.DotNetBar.Metro.MetroTileItem listaventaItem;
        private DevComponents.DotNetBar.Metro.MetroTileItem clienteItem;
        private DevComponents.DotNetBar.Metro.MetroTileItem codigoItem;
        private DevComponents.DotNetBar.Metro.MetroTileItem facturaItem;
        private DevComponents.DotNetBar.Metro.MetroTileItem ventasItem;
        private DevComponents.DotNetBar.ItemPanel itemPanel1;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.Metro.MetroTileItem empresaItem;
        private DevComponents.DotNetBar.Metro.MetroTileItem reporteItem;
        private DevComponents.DotNetBar.Metro.MetroTileItem producto;
        private DevComponents.DotNetBar.LabelX lb_user;
        private System.Windows.Forms.Timer chartUpdateTimer;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DevComponents.DotNetBar.ButtonX buttonX1;
    }
}
