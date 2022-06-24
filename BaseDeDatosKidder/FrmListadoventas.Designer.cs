namespace BaseDeDatosKidder
{
    partial class FrmListadoventas
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
            FontAwesome.Sharp.IconButton ibtnfiltrar;
            this.label1 = new System.Windows.Forms.Label();
            this.DTFechainicial = new System.Windows.Forms.DateTimePicker();
            this.DTFechafinal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvlistadoventas = new System.Windows.Forms.DataGridView();
            this.btncerrar = new FontAwesome.Sharp.IconButton();
            ibtnfiltrar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistadoventas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha incial";
            // 
            // DTFechainicial
            // 
            this.DTFechainicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTFechainicial.Location = new System.Drawing.Point(161, 68);
            this.DTFechainicial.Margin = new System.Windows.Forms.Padding(4);
            this.DTFechainicial.Name = "DTFechainicial";
            this.DTFechainicial.Size = new System.Drawing.Size(386, 27);
            this.DTFechainicial.TabIndex = 1;
            // 
            // DTFechafinal
            // 
            this.DTFechafinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTFechafinal.Location = new System.Drawing.Point(158, 104);
            this.DTFechafinal.Margin = new System.Windows.Forms.Padding(4);
            this.DTFechafinal.Name = "DTFechafinal";
            this.DTFechafinal.Size = new System.Drawing.Size(389, 27);
            this.DTFechafinal.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha Final";
            // 
            // dgvlistadoventas
            // 
            this.dgvlistadoventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlistadoventas.Location = new System.Drawing.Point(-8, 217);
            this.dgvlistadoventas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvlistadoventas.Name = "dgvlistadoventas";
            this.dgvlistadoventas.RowHeadersWidth = 51;
            this.dgvlistadoventas.Size = new System.Drawing.Size(871, 387);
            this.dgvlistadoventas.TabIndex = 9;
            this.dgvlistadoventas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlistadoventas_CellContentClick);
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
            this.btncerrar.Location = new System.Drawing.Point(0, 610);
            this.btncerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(863, 58);
            this.btncerrar.TabIndex = 48;
            this.btncerrar.Text = "CERRAR";
            this.btncerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncerrar.UseVisualStyleBackColor = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // ibtnfiltrar
            // 
            ibtnfiltrar.BackColor = System.Drawing.Color.DimGray;
            ibtnfiltrar.FlatAppearance.BorderSize = 0;
            ibtnfiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            ibtnfiltrar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ibtnfiltrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            ibtnfiltrar.IconChar = FontAwesome.Sharp.IconChar.Filter;
            ibtnfiltrar.IconColor = System.Drawing.Color.LightSteelBlue;
            ibtnfiltrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnfiltrar.IconSize = 35;
            ibtnfiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            ibtnfiltrar.Location = new System.Drawing.Point(565, 68);
            ibtnfiltrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            ibtnfiltrar.Name = "ibtnfiltrar";
            ibtnfiltrar.Size = new System.Drawing.Size(48, 41);
            ibtnfiltrar.TabIndex = 69;
            ibtnfiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            ibtnfiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ibtnfiltrar.UseVisualStyleBackColor = false;
            ibtnfiltrar.Click += new System.EventHandler(this.ibtnfiltrar_Click);
            // 
            // FrmListadoventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(863, 668);
            this.Controls.Add(ibtnfiltrar);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.dgvlistadoventas);
            this.Controls.Add(this.DTFechafinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DTFechainicial);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmListadoventas";
            this.Text = "FrmListadoventas";
            this.Load += new System.EventHandler(this.FrmListadoventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistadoventas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DTFechainicial;
        private System.Windows.Forms.DateTimePicker DTFechafinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvlistadoventas;
        private FontAwesome.Sharp.IconButton btncerrar;
    }
}