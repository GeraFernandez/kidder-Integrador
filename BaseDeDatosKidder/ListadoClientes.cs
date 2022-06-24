using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_datos;
using Capa_entidad;
using Capa_negocios;


namespace BaseDeDatosKidder
{
    public partial class ListadoClientes : Form
    {
        readonly clase_entidad ObjEntidad = new clase_entidad();
        readonly  clase_negocios ObjNegocio = new clase_negocios();

        public ListadoClientes()
        {
            InitializeComponent();
        }

        private void ibtnnuevo_Click(object sender, EventArgs e)
        {
            frmCargaClientes frmCargaClientes = new frmCargaClientes();
            frmCargaClientes.ShowDialog();  
        }

        public void ListadoClientes_Load(object sender, EventArgs e)
        {
            
        }

        public void MensajeConfirmacion(string mensaje)
        {
            MessageBox.Show(mensaje, "KIDDER SA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "KIDDER SA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void BuscarRegistros()
        {
            dgvlistadoclientes.DataSource = clase_negocios.BuscarRegistros(txtbuscar.Text);
        }



        public void btncerrar_Click(object sender, EventArgs e)
        {
           //frmfacturador frmfacturador = new frmfacturador();
            //frmfacturador.s
            Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            BuscarRegistros();
        }

        public void dgvlistadoclientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            frmfacturador datosclientes = Owner as frmfacturador;
            datosclientes.txtcuitbusq.Text = dgvlistadoclientes.CurrentRow.Cells[1].Value.ToString();
            datosclientes.txtIdCliente.Text = dgvlistadoclientes.CurrentRow.Cells[0].Value.ToString();
            datosclientes.txtcuit.Text = dgvlistadoclientes.CurrentRow.Cells[1].Value.ToString();
            datosclientes.txtnom.Text = dgvlistadoclientes.CurrentRow.Cells[3].Value.ToString();
            datosclientes.txtape.Text = dgvlistadoclientes.CurrentRow.Cells[4].Value.ToString();
            datosclientes.txttelefono.Text = dgvlistadoclientes.CurrentRow.Cells[5].Value.ToString();
            Close();


        }

        
      
    }
}
