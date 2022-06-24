namespace BaseDeDatosKidder
{
    partial class frmProductos
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.zz = new System.Windows.Forms.Label();
            this.cboTalle = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboColor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboModelo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ibtnborrar = new FontAwesome.Sharp.IconButton();
            this.ibtncancelar = new FontAwesome.Sharp.IconButton();
            this.ibtnmodificar = new FontAwesome.Sharp.IconButton();
            this.ibtngrabar = new FontAwesome.Sharp.IconButton();
            this.ibtnconsultar = new FontAwesome.Sharp.IconButton();
            this.lblmod = new System.Windows.Forms.Label();
            this.lblcol = new System.Windows.Forms.Label();
            this.lbltall = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.lblmoddesc = new System.Windows.Forms.Label();
            this.lblcoldesc = new System.Windows.Forms.Label();
            this.lbltaldesc = new System.Windows.Forms.Label();
            this.lbldesc = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.dgvproductos = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(562, 89);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(99, 34);
            this.txtID.TabIndex = 99;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(397, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 29);
            this.label5.TabIndex = 98;
            this.label5.Text = "ID";
            // 
            // zz
            // 
            this.zz.AutoSize = true;
            this.zz.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zz.Location = new System.Drawing.Point(393, 329);
            this.zz.Name = "zz";
            this.zz.Size = new System.Drawing.Size(141, 29);
            this.zz.TabIndex = 96;
            this.zz.Text = "Descripcion";
            // 
            // cboTalle
            // 
            this.cboTalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTalle.FormattingEnabled = true;
            this.cboTalle.Items.AddRange(new object[] {
            "-Seleccionar-",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45"});
            this.cboTalle.Location = new System.Drawing.Point(562, 247);
            this.cboTalle.Name = "cboTalle";
            this.cboTalle.Size = new System.Drawing.Size(212, 37);
            this.cboTalle.TabIndex = 95;
            this.cboTalle.SelectedIndexChanged += new System.EventHandler(this.cboTalle_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(397, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 29);
            this.label3.TabIndex = 94;
            this.label3.Text = "Talle";
            // 
            // cboColor
            // 
            this.cboColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboColor.FormattingEnabled = true;
            this.cboColor.Items.AddRange(new object[] {
            "-Seleccionar-",
            "Negro",
            "Marron"});
            this.cboColor.Location = new System.Drawing.Point(562, 204);
            this.cboColor.Name = "cboColor";
            this.cboColor.Size = new System.Drawing.Size(212, 37);
            this.cboColor.TabIndex = 93;
            this.cboColor.SelectedIndexChanged += new System.EventHandler(this.cboColor_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(397, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 29);
            this.label2.TabIndex = 92;
            this.label2.Text = "Color";
            // 
            // cboModelo
            // 
            this.cboModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboModelo.FormattingEnabled = true;
            this.cboModelo.Items.AddRange(new object[] {
            "-Seleccionar-",
            "Zapato",
            "Bota",
            "Borcego"});
            this.cboModelo.Location = new System.Drawing.Point(562, 161);
            this.cboModelo.Name = "cboModelo";
            this.cboModelo.Size = new System.Drawing.Size(212, 37);
            this.cboModelo.TabIndex = 91;
            this.cboModelo.SelectedIndexChanged += new System.EventHandler(this.cboModelo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(397, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 29);
            this.label1.TabIndex = 90;
            this.label1.Text = "Modelo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.ibtnborrar);
            this.panel1.Controls.Add(this.ibtncancelar);
            this.panel1.Controls.Add(this.ibtnmodificar);
            this.panel1.Controls.Add(this.ibtngrabar);
            this.panel1.Controls.Add(this.ibtnconsultar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 727);
            this.panel1.TabIndex = 106;
            // 
            // ibtnborrar
            // 
            this.ibtnborrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ibtnborrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnborrar.FlatAppearance.BorderSize = 0;
            this.ibtnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnborrar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnborrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ibtnborrar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.ibtnborrar.IconColor = System.Drawing.Color.Red;
            this.ibtnborrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnborrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnborrar.Location = new System.Drawing.Point(0, 234);
            this.ibtnborrar.Name = "ibtnborrar";
            this.ibtnborrar.Size = new System.Drawing.Size(311, 78);
            this.ibtnborrar.TabIndex = 6;
            this.ibtnborrar.Text = "BORRAR";
            this.ibtnborrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnborrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnborrar.UseVisualStyleBackColor = false;
            this.ibtnborrar.Click += new System.EventHandler(this.ibtnborrar_Click_1);
            // 
            // ibtncancelar
            // 
            this.ibtncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ibtncancelar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ibtncancelar.FlatAppearance.BorderSize = 0;
            this.ibtncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtncancelar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtncancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ibtncancelar.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.ibtncancelar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ibtncancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtncancelar.Location = new System.Drawing.Point(0, 649);
            this.ibtncancelar.Name = "ibtncancelar";
            this.ibtncancelar.Size = new System.Drawing.Size(311, 78);
            this.ibtncancelar.TabIndex = 5;
            this.ibtncancelar.Text = "CANCELAR";
            this.ibtncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtncancelar.UseVisualStyleBackColor = false;
            this.ibtncancelar.Click += new System.EventHandler(this.ibtncancelar_Click);
            // 
            // ibtnmodificar
            // 
            this.ibtnmodificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ibtnmodificar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnmodificar.FlatAppearance.BorderSize = 0;
            this.ibtnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnmodificar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnmodificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ibtnmodificar.IconChar = FontAwesome.Sharp.IconChar.Retweet;
            this.ibtnmodificar.IconColor = System.Drawing.Color.DodgerBlue;
            this.ibtnmodificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnmodificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnmodificar.Location = new System.Drawing.Point(0, 156);
            this.ibtnmodificar.Name = "ibtnmodificar";
            this.ibtnmodificar.Size = new System.Drawing.Size(311, 78);
            this.ibtnmodificar.TabIndex = 4;
            this.ibtnmodificar.Text = "MODIFICAR";
            this.ibtnmodificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnmodificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnmodificar.UseVisualStyleBackColor = false;
            this.ibtnmodificar.Click += new System.EventHandler(this.ibtnmodificar_Click);
            // 
            // ibtngrabar
            // 
            this.ibtngrabar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ibtngrabar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtngrabar.FlatAppearance.BorderSize = 0;
            this.ibtngrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtngrabar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtngrabar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ibtngrabar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.ibtngrabar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ibtngrabar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtngrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtngrabar.Location = new System.Drawing.Point(0, 78);
            this.ibtngrabar.Name = "ibtngrabar";
            this.ibtngrabar.Size = new System.Drawing.Size(311, 78);
            this.ibtngrabar.TabIndex = 2;
            this.ibtngrabar.Text = "GRABAR";
            this.ibtngrabar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtngrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtngrabar.UseVisualStyleBackColor = false;
            this.ibtngrabar.Click += new System.EventHandler(this.ibtngrabar_Click);
            // 
            // ibtnconsultar
            // 
            this.ibtnconsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ibtnconsultar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnconsultar.FlatAppearance.BorderSize = 0;
            this.ibtnconsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnconsultar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnconsultar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ibtnconsultar.IconChar = FontAwesome.Sharp.IconChar.List;
            this.ibtnconsultar.IconColor = System.Drawing.Color.Gold;
            this.ibtnconsultar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnconsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnconsultar.Location = new System.Drawing.Point(0, 0);
            this.ibtnconsultar.Name = "ibtnconsultar";
            this.ibtnconsultar.Size = new System.Drawing.Size(311, 78);
            this.ibtnconsultar.TabIndex = 1;
            this.ibtnconsultar.Text = "CONSULTAR";
            this.ibtnconsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnconsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnconsultar.UseVisualStyleBackColor = false;
            this.ibtnconsultar.Click += new System.EventHandler(this.ibtnconsultar_Click_1);
            // 
            // lblmod
            // 
            this.lblmod.AutoSize = true;
            this.lblmod.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmod.ForeColor = System.Drawing.Color.Silver;
            this.lblmod.Location = new System.Drawing.Point(865, 117);
            this.lblmod.Name = "lblmod";
            this.lblmod.Size = new System.Drawing.Size(0, 29);
            this.lblmod.TabIndex = 110;
            // 
            // lblcol
            // 
            this.lblcol.AutoSize = true;
            this.lblcol.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcol.ForeColor = System.Drawing.Color.Silver;
            this.lblcol.Location = new System.Drawing.Point(865, 157);
            this.lblcol.Name = "lblcol";
            this.lblcol.Size = new System.Drawing.Size(0, 29);
            this.lblcol.TabIndex = 111;
            // 
            // lbltall
            // 
            this.lbltall.AutoSize = true;
            this.lbltall.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltall.ForeColor = System.Drawing.Color.Silver;
            this.lbltall.Location = new System.Drawing.Point(865, 191);
            this.lbltall.Name = "lbltall";
            this.lbltall.Size = new System.Drawing.Size(0, 29);
            this.lbltall.TabIndex = 112;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.ForeColor = System.Drawing.Color.Silver;
            this.lblid.Location = new System.Drawing.Point(865, 84);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 29);
            this.lblid.TabIndex = 113;
            // 
            // lblmoddesc
            // 
            this.lblmoddesc.AutoSize = true;
            this.lblmoddesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmoddesc.ForeColor = System.Drawing.Color.Silver;
            this.lblmoddesc.Location = new System.Drawing.Point(959, 124);
            this.lblmoddesc.Name = "lblmoddesc";
            this.lblmoddesc.Size = new System.Drawing.Size(0, 29);
            this.lblmoddesc.TabIndex = 114;
            // 
            // lblcoldesc
            // 
            this.lblcoldesc.AutoSize = true;
            this.lblcoldesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcoldesc.ForeColor = System.Drawing.Color.Silver;
            this.lblcoldesc.Location = new System.Drawing.Point(959, 157);
            this.lblcoldesc.Name = "lblcoldesc";
            this.lblcoldesc.Size = new System.Drawing.Size(0, 29);
            this.lblcoldesc.TabIndex = 115;
            // 
            // lbltaldesc
            // 
            this.lbltaldesc.AutoSize = true;
            this.lbltaldesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltaldesc.ForeColor = System.Drawing.Color.Silver;
            this.lbltaldesc.Location = new System.Drawing.Point(959, 190);
            this.lbltaldesc.Name = "lbltaldesc";
            this.lbltaldesc.Size = new System.Drawing.Size(0, 29);
            this.lbltaldesc.TabIndex = 116;
            // 
            // lbldesc
            // 
            this.lbldesc.AutoSize = true;
            this.lbldesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldesc.ForeColor = System.Drawing.Color.Silver;
            this.lbldesc.Location = new System.Drawing.Point(1083, 247);
            this.lbldesc.Name = "lbldesc";
            this.lbldesc.Size = new System.Drawing.Size(0, 29);
            this.lbldesc.TabIndex = 117;
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(562, 329);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(688, 34);
            this.txtnombre.TabIndex = 118;
            // 
            // dgvproductos
            // 
            this.dgvproductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvproductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvproductos.ColumnHeadersHeight = 50;
            this.dgvproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvproductos.Location = new System.Drawing.Point(398, 386);
            this.dgvproductos.Name = "dgvproductos";
            this.dgvproductos.RowHeadersWidth = 51;
            this.dgvproductos.RowTemplate.Height = 24;
            this.dgvproductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvproductos.Size = new System.Drawing.Size(852, 294);
            this.dgvproductos.TabIndex = 119;
            this.dgvproductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproductos_CellContentClick);
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1501, 727);
            this.Controls.Add(this.dgvproductos);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lbldesc);
            this.Controls.Add(this.lbltaldesc);
            this.Controls.Add(this.lblcoldesc);
            this.Controls.Add(this.lblmoddesc);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lbltall);
            this.Controls.Add(this.lblcol);
            this.Controls.Add(this.lblmod);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.zz);
            this.Controls.Add(this.cboTalle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboModelo);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MinimizeBox = false;
            this.Name = "frmProductos";
            this.Text = "Carga de productos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label zz;
        private System.Windows.Forms.ComboBox cboTalle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboModelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton ibtnconsultar;
        private FontAwesome.Sharp.IconButton ibtngrabar;
        private FontAwesome.Sharp.IconButton ibtncancelar;
        private System.Windows.Forms.Label lblmod;
        private System.Windows.Forms.Label lblcol;
        private System.Windows.Forms.Label lbltall;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblmoddesc;
        private System.Windows.Forms.Label lblcoldesc;
        private System.Windows.Forms.Label lbltaldesc;
        private System.Windows.Forms.Label lbldesc;
        private FontAwesome.Sharp.IconButton ibtnborrar;
        private FontAwesome.Sharp.IconButton ibtnmodificar;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.DataGridView dgvproductos;
    }
}