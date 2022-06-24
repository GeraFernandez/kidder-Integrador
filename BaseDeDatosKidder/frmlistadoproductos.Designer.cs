namespace BaseDeDatosKidder
{
    partial class frmlistadoproductos
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
            FontAwesome.Sharp.IconButton ibtnbuscar;
            FontAwesome.Sharp.IconButton ibtnnuevo;
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.dgvlistadoproductos = new System.Windows.Forms.DataGridView();
            this.btncerrar = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            ibtnbuscar = new FontAwesome.Sharp.IconButton();
            ibtnnuevo = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistadoproductos)).BeginInit();
            this.SuspendLayout();
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
            ibtnbuscar.Location = new System.Drawing.Point(521, 50);
            ibtnbuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            ibtnbuscar.Name = "ibtnbuscar";
            ibtnbuscar.Size = new System.Drawing.Size(49, 39);
            ibtnbuscar.TabIndex = 68;
            ibtnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            ibtnbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ibtnbuscar.UseVisualStyleBackColor = false;
            ibtnbuscar.Click += new System.EventHandler(this.ibtnbuscar_Click);
            // 
            // ibtnnuevo
            // 
            ibtnnuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            ibtnnuevo.FlatAppearance.BorderSize = 0;
            ibtnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            ibtnnuevo.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            ibtnnuevo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ibtnnuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            ibtnnuevo.IconChar = FontAwesome.Sharp.IconChar.Plus;
            ibtnnuevo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            ibtnnuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnnuevo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            ibtnnuevo.Location = new System.Drawing.Point(623, 50);
            ibtnnuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            ibtnnuevo.Name = "ibtnnuevo";
            ibtnnuevo.Size = new System.Drawing.Size(241, 59);
            ibtnnuevo.TabIndex = 70;
            ibtnnuevo.Text = "NUEVO";
            ibtnnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            ibtnnuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ibtnnuevo.UseVisualStyleBackColor = false;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.Location = new System.Drawing.Point(12, 59);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(503, 30);
            this.txtbuscar.TabIndex = 66;
            // 
            // dgvlistadoproductos
            // 
            this.dgvlistadoproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlistadoproductos.Location = new System.Drawing.Point(0, 269);
            this.dgvlistadoproductos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvlistadoproductos.Name = "dgvlistadoproductos";
            this.dgvlistadoproductos.RowHeadersWidth = 51;
            this.dgvlistadoproductos.Size = new System.Drawing.Size(864, 298);
            this.dgvlistadoproductos.TabIndex = 64;
            this.dgvlistadoproductos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlistadoproductos_CellContentDoubleClick);
            // 
            // btncerrar
            // 
            this.btncerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btncerrar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btncerrar.FlatAppearance.BorderSize = 0;
            this.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncerrar.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btncerrar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btncerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncerrar.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btncerrar.Location = new System.Drawing.Point(0, 573);
            this.btncerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(869, 58);
            this.btncerrar.TabIndex = 65;
            this.btncerrar.Text = "CERRAR";
            this.btncerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncerrar.UseVisualStyleBackColor = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 22);
            this.label2.TabIndex = 69;
            this.label2.Text = "Ingrese su producto";
            // 
            // frmlistadoproductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 631);
            this.Controls.Add(ibtnnuevo);
            this.Controls.Add(this.label2);
            this.Controls.Add(ibtnbuscar);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.dgvlistadoproductos);
            this.Name = "frmlistadoproductos";
            this.Text = "frmlistadoproductos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistadoproductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtbuscar;
        private FontAwesome.Sharp.IconButton btncerrar;
        private System.Windows.Forms.DataGridView dgvlistadoproductos;
        private System.Windows.Forms.Label label2;
    }
}