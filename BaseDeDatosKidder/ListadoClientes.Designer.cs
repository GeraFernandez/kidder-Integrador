namespace BaseDeDatosKidder
{
    partial class ListadoClientes
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
            FontAwesome.Sharp.IconButton btncerrar;
            FontAwesome.Sharp.IconButton ibtnnuevo;
            FontAwesome.Sharp.IconButton ibtnanular;
            FontAwesome.Sharp.IconButton ibtnbuscar;
            this.dgvlistadoclientes = new System.Windows.Forms.DataGridView();
            this.btnfiltrar = new System.Windows.Forms.Button();
            this.DTFechafinal = new System.Windows.Forms.DateTimePicker();
            this.DTFechainicial = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            btncerrar = new FontAwesome.Sharp.IconButton();
            ibtnnuevo = new FontAwesome.Sharp.IconButton();
            ibtnanular = new FontAwesome.Sharp.IconButton();
            ibtnbuscar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistadoclientes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncerrar
            // 
            btncerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            btncerrar.Dock = System.Windows.Forms.DockStyle.Bottom;
            btncerrar.FlatAppearance.BorderSize = 0;
            btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btncerrar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btncerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btncerrar.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            btncerrar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            btncerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btncerrar.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            btncerrar.Location = new System.Drawing.Point(0, 612);
            btncerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new System.Drawing.Size(1241, 58);
            btncerrar.TabIndex = 59;
            btncerrar.Text = "CERRAR";
            btncerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btncerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btncerrar.UseVisualStyleBackColor = false;
            btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // ibtnnuevo
            // 
            ibtnnuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            ibtnnuevo.Dock = System.Windows.Forms.DockStyle.Bottom;
            ibtnnuevo.FlatAppearance.BorderSize = 0;
            ibtnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            ibtnnuevo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ibtnnuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            ibtnnuevo.IconChar = FontAwesome.Sharp.IconChar.Plus;
            ibtnnuevo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            ibtnnuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            ibtnnuevo.Location = new System.Drawing.Point(0, 0);
            ibtnnuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            ibtnnuevo.Name = "ibtnnuevo";
            ibtnnuevo.Size = new System.Drawing.Size(241, 59);
            ibtnnuevo.TabIndex = 63;
            ibtnnuevo.Text = "NUEVO";
            ibtnnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            ibtnnuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ibtnnuevo.UseVisualStyleBackColor = false;
            ibtnnuevo.Click += new System.EventHandler(this.ibtnnuevo_Click);
            // 
            // ibtnanular
            // 
            ibtnanular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            ibtnanular.Dock = System.Windows.Forms.DockStyle.Bottom;
            ibtnanular.FlatAppearance.BorderSize = 0;
            ibtnanular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            ibtnanular.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ibtnanular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            ibtnanular.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            ibtnanular.IconColor = System.Drawing.Color.Red;
            ibtnanular.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnanular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            ibtnanular.Location = new System.Drawing.Point(0, 59);
            ibtnanular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            ibtnanular.Name = "ibtnanular";
            ibtnanular.Size = new System.Drawing.Size(241, 59);
            ibtnanular.TabIndex = 64;
            ibtnanular.Text = "ANULAR";
            ibtnanular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            ibtnanular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ibtnanular.UseVisualStyleBackColor = false;
            // 
            // ibtnbuscar
            // 
            ibtnbuscar.BackColor = System.Drawing.Color.DarkGray;
            ibtnbuscar.FlatAppearance.BorderSize = 0;
            ibtnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ibtnbuscar.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ibtnbuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            ibtnbuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            ibtnbuscar.IconColor = System.Drawing.Color.Yellow;
            ibtnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnbuscar.IconSize = 34;
            ibtnbuscar.Location = new System.Drawing.Point(919, 72);
            ibtnbuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            ibtnbuscar.Name = "ibtnbuscar";
            ibtnbuscar.Size = new System.Drawing.Size(38, 38);
            ibtnbuscar.TabIndex = 65;
            ibtnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            ibtnbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ibtnbuscar.UseVisualStyleBackColor = false;
            ibtnbuscar.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // dgvlistadoclientes
            // 
            this.dgvlistadoclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlistadoclientes.Location = new System.Drawing.Point(13, 117);
            this.dgvlistadoclientes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvlistadoclientes.Name = "dgvlistadoclientes";
            this.dgvlistadoclientes.RowHeadersWidth = 51;
            this.dgvlistadoclientes.Size = new System.Drawing.Size(1215, 448);
            this.dgvlistadoclientes.TabIndex = 58;
            this.dgvlistadoclientes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlistadoclientes_CellContentDoubleClick);
            // 
            // btnfiltrar
            // 
            this.btnfiltrar.Location = new System.Drawing.Point(390, -65);
            this.btnfiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnfiltrar.Name = "btnfiltrar";
            this.btnfiltrar.Size = new System.Drawing.Size(100, 28);
            this.btnfiltrar.TabIndex = 57;
            this.btnfiltrar.Text = "Filtrar";
            this.btnfiltrar.UseVisualStyleBackColor = true;
            // 
            // DTFechafinal
            // 
            this.DTFechafinal.Location = new System.Drawing.Point(82, -25);
            this.DTFechafinal.Margin = new System.Windows.Forms.Padding(4);
            this.DTFechafinal.Name = "DTFechafinal";
            this.DTFechafinal.Size = new System.Drawing.Size(265, 22);
            this.DTFechafinal.TabIndex = 52;
            // 
            // DTFechainicial
            // 
            this.DTFechainicial.Location = new System.Drawing.Point(82, -75);
            this.DTFechainicial.Margin = new System.Windows.Forms.Padding(4);
            this.DTFechainicial.Name = "DTFechainicial";
            this.DTFechainicial.Size = new System.Drawing.Size(265, 22);
            this.DTFechainicial.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-4, -65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "Fecha incial";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.Location = new System.Drawing.Point(12, 72);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(901, 38);
            this.txtbuscar.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(535, 22);
            this.label2.TabIndex = 62;
            this.label2.Text = "Ingrese NOMBRE/RAZON SOCIAL, APELLIDO o CUIT del cliente";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(ibtnnuevo);
            this.panel1.Controls.Add(ibtnanular);
            this.panel1.Location = new System.Drawing.Point(987, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 118);
            this.panel1.TabIndex = 66;
            // 
            // ListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 670);
            this.Controls.Add(this.panel1);
            this.Controls.Add(ibtnbuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(btncerrar);
            this.Controls.Add(this.dgvlistadoclientes);
            this.Controls.Add(this.btnfiltrar);
            this.Controls.Add(this.DTFechafinal);
            this.Controls.Add(this.DTFechainicial);
            this.Controls.Add(this.label1);
            this.Name = "ListadoClientes";
            this.Text = "ListadoClientes";
            this.Load += new System.EventHandler(this.ListadoClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistadoclientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvlistadoclientes;
        private System.Windows.Forms.Button btnfiltrar;
        private System.Windows.Forms.DateTimePicker DTFechafinal;
        private System.Windows.Forms.DateTimePicker DTFechainicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}