namespace BaseDeDatosKidder
{
    partial class frmMenu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargaDeClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notaDePedidoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emitirFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.lblhora = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.ibtnCargaproductos = new FontAwesome.Sharp.IconButton();
            this.ibtnFacturacion = new FontAwesome.Sharp.IconButton();
            this.ibtnNotapedido = new FontAwesome.Sharp.IconButton();
            this.ibtnCargaclientes = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.horafecha = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.facturaciónToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1299, 31);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargaDeClienteToolStripMenuItem,
            this.listadoClientesToolStripMenuItem,
            this.notaDePedidoToolStripMenuItem1});
            this.clientesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(84, 27);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // cargaDeClienteToolStripMenuItem
            // 
            this.cargaDeClienteToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.cargaDeClienteToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cargaDeClienteToolStripMenuItem.Name = "cargaDeClienteToolStripMenuItem";
            this.cargaDeClienteToolStripMenuItem.Size = new System.Drawing.Size(237, 28);
            this.cargaDeClienteToolStripMenuItem.Text = "Carga de Clientes";
            this.cargaDeClienteToolStripMenuItem.Click += new System.EventHandler(this.cargaDeClienteToolStripMenuItem_Click);
            // 
            // listadoClientesToolStripMenuItem
            // 
            this.listadoClientesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listadoClientesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listadoClientesToolStripMenuItem.Name = "listadoClientesToolStripMenuItem";
            this.listadoClientesToolStripMenuItem.Size = new System.Drawing.Size(237, 28);
            this.listadoClientesToolStripMenuItem.Text = "Listado de Clientes";
            this.listadoClientesToolStripMenuItem.Click += new System.EventHandler(this.listadoClientesToolStripMenuItem_Click);
            // 
            // notaDePedidoToolStripMenuItem1
            // 
            this.notaDePedidoToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.notaDePedidoToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.notaDePedidoToolStripMenuItem1.Name = "notaDePedidoToolStripMenuItem1";
            this.notaDePedidoToolStripMenuItem1.Size = new System.Drawing.Size(237, 28);
            this.notaDePedidoToolStripMenuItem1.Text = "Nota de Pedido";
            // 
            // facturaciónToolStripMenuItem
            // 
            this.facturaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emitirFacturaToolStripMenuItem,
            this.listadoDeFacturasToolStripMenuItem});
            this.facturaciónToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.facturaciónToolStripMenuItem.Name = "facturaciónToolStripMenuItem";
            this.facturaciónToolStripMenuItem.Size = new System.Drawing.Size(111, 27);
            this.facturaciónToolStripMenuItem.Text = "Facturación";
            // 
            // emitirFacturaToolStripMenuItem
            // 
            this.emitirFacturaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.emitirFacturaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.emitirFacturaToolStripMenuItem.Name = "emitirFacturaToolStripMenuItem";
            this.emitirFacturaToolStripMenuItem.Size = new System.Drawing.Size(239, 28);
            this.emitirFacturaToolStripMenuItem.Text = "Emitir Factura";
            // 
            // listadoDeFacturasToolStripMenuItem
            // 
            this.listadoDeFacturasToolStripMenuItem.Name = "listadoDeFacturasToolStripMenuItem";
            this.listadoDeFacturasToolStripMenuItem.Size = new System.Drawing.Size(239, 28);
            this.listadoDeFacturasToolStripMenuItem.Text = "Listado de Facturas";
            this.listadoDeFacturasToolStripMenuItem.Click += new System.EventHandler(this.listadoDeFacturasToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.listadoProductosToolStripMenuItem});
            this.stockToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(64, 27);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(230, 28);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click_1);
            // 
            // listadoProductosToolStripMenuItem
            // 
            this.listadoProductosToolStripMenuItem.Name = "listadoProductosToolStripMenuItem";
            this.listadoProductosToolStripMenuItem.Size = new System.Drawing.Size(230, 28);
            this.listadoProductosToolStripMenuItem.Text = "Listado Productos";
            this.listadoProductosToolStripMenuItem.Click += new System.EventHandler(this.listadoProductosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(56, 27);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click_1);
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.PanelMenu.Controls.Add(this.lblhora);
            this.PanelMenu.Controls.Add(this.lblfecha);
            this.PanelMenu.Controls.Add(this.ibtnCargaproductos);
            this.PanelMenu.Controls.Add(this.ibtnFacturacion);
            this.PanelMenu.Controls.Add(this.ibtnNotapedido);
            this.PanelMenu.Controls.Add(this.ibtnCargaclientes);
            this.PanelMenu.Controls.Add(this.pictureBox1);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 31);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(400, 551);
            this.PanelMenu.TabIndex = 10;
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblhora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.Location = new System.Drawing.Point(0, 494);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(71, 32);
            this.lblhora.TabIndex = 17;
            this.lblhora.Text = "hora";
            this.lblhora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblfecha.Location = new System.Drawing.Point(0, 526);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(60, 25);
            this.lblfecha.TabIndex = 18;
            this.lblfecha.Text = "fecha";
            // 
            // ibtnCargaproductos
            // 
            this.ibtnCargaproductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnCargaproductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnCargaproductos.FlatAppearance.BorderSize = 0;
            this.ibtnCargaproductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnCargaproductos.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnCargaproductos.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnCargaproductos.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.ibtnCargaproductos.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnCargaproductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnCargaproductos.IconSize = 50;
            this.ibtnCargaproductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnCargaproductos.Location = new System.Drawing.Point(0, 308);
            this.ibtnCargaproductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ibtnCargaproductos.Name = "ibtnCargaproductos";
            this.ibtnCargaproductos.Size = new System.Drawing.Size(400, 70);
            this.ibtnCargaproductos.TabIndex = 19;
            this.ibtnCargaproductos.Text = "Carga de productos";
            this.ibtnCargaproductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnCargaproductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnCargaproductos.UseVisualStyleBackColor = true;
            this.ibtnCargaproductos.Click += new System.EventHandler(this.ibtnCargaproductos_Click_1);
            // 
            // ibtnFacturacion
            // 
            this.ibtnFacturacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnFacturacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnFacturacion.FlatAppearance.BorderSize = 0;
            this.ibtnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnFacturacion.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnFacturacion.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnFacturacion.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.ibtnFacturacion.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnFacturacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnFacturacion.IconSize = 50;
            this.ibtnFacturacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnFacturacion.Location = new System.Drawing.Point(0, 238);
            this.ibtnFacturacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ibtnFacturacion.Name = "ibtnFacturacion";
            this.ibtnFacturacion.Size = new System.Drawing.Size(400, 70);
            this.ibtnFacturacion.TabIndex = 18;
            this.ibtnFacturacion.Text = "Facturacion";
            this.ibtnFacturacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnFacturacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnFacturacion.UseVisualStyleBackColor = true;
            this.ibtnFacturacion.Click += new System.EventHandler(this.ibtnFacturacion_Click);
            // 
            // ibtnNotapedido
            // 
            this.ibtnNotapedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnNotapedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnNotapedido.FlatAppearance.BorderSize = 0;
            this.ibtnNotapedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnNotapedido.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnNotapedido.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnNotapedido.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.ibtnNotapedido.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnNotapedido.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnNotapedido.IconSize = 50;
            this.ibtnNotapedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnNotapedido.Location = new System.Drawing.Point(0, 168);
            this.ibtnNotapedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ibtnNotapedido.Name = "ibtnNotapedido";
            this.ibtnNotapedido.Size = new System.Drawing.Size(400, 70);
            this.ibtnNotapedido.TabIndex = 17;
            this.ibtnNotapedido.Text = "Nota de pedido";
            this.ibtnNotapedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnNotapedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnNotapedido.UseVisualStyleBackColor = true;
            this.ibtnNotapedido.Click += new System.EventHandler(this.ibtnNotapedido_Click);
            // 
            // ibtnCargaclientes
            // 
            this.ibtnCargaclientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnCargaclientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnCargaclientes.FlatAppearance.BorderSize = 0;
            this.ibtnCargaclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnCargaclientes.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnCargaclientes.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnCargaclientes.IconChar = FontAwesome.Sharp.IconChar.Portrait;
            this.ibtnCargaclientes.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnCargaclientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnCargaclientes.IconSize = 50;
            this.ibtnCargaclientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnCargaclientes.Location = new System.Drawing.Point(0, 98);
            this.ibtnCargaclientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ibtnCargaclientes.Name = "ibtnCargaclientes";
            this.ibtnCargaclientes.Size = new System.Drawing.Size(400, 70);
            this.ibtnCargaclientes.TabIndex = 16;
            this.ibtnCargaclientes.Text = "Carga de clientes";
            this.ibtnCargaclientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnCargaclientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnCargaclientes.UseVisualStyleBackColor = true;
            this.ibtnCargaclientes.Click += new System.EventHandler(this.ibtnCargaclientes_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::BaseDeDatosKidder.Properties.Resources.kidder;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.iconButton5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(400, 31);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(899, 98);
            this.panel3.TabIndex = 11;
            // 
            // iconButton5
            // 
            this.iconButton5.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton5.Enabled = false;
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton5.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.HouseUser;
            this.iconButton5.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 50;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(0, 0);
            this.iconButton5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(899, 98);
            this.iconButton5.TabIndex = 12;
            this.iconButton5.Text = "Menu Pincipal";
            this.iconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Image = global::BaseDeDatosKidder.Properties.Resources._24222;
            this.pictureBox4.Location = new System.Drawing.Point(400, 129);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(899, 453);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // horafecha
            // 
            this.horafecha.Enabled = true;
            this.horafecha.Tick += new System.EventHandler(this.horafecha_Tick);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 582);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PanelMenu.ResumeLayout(false);
            this.PanelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem facturaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emitirFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargaDeClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notaDePedidoToolStripMenuItem1;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton ibtnCargaproductos;
        private FontAwesome.Sharp.IconButton ibtnFacturacion;
        private FontAwesome.Sharp.IconButton ibtnNotapedido;
        private FontAwesome.Sharp.IconButton ibtnCargaclientes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer horafecha;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.ToolStripMenuItem listadoDeFacturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoProductosToolStripMenuItem;
    }
}