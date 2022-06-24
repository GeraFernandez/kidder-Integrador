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
    public partial class FrmListadoventas : Form
    {
        readonly E_Ventas ObjEntidad = new E_Ventas();
        readonly N_Ventas ObjNegocio = new N_Ventas();

        public FrmListadoventas()
        {
            InitializeComponent();
        }

        private void MensajeConfirmacion (string mensaje)
        {
            MessageBox.Show(mensaje, "KIDDER SA", MessageBoxButtons.OK, MessageBoxIcon.Information);    
        } 
        
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "KIDDER SA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void MostrarRegistro()
        {
            dgvlistadoventas.DataSource = N_Ventas.MostrarRegistros();

        }


        public void BuscarRegistro()
        {
            dgvlistadoventas.DataSource = N_Ventas.BuscarRegistros(DTFechainicial.Value.ToString("dd/MM/yyyy"), DTFechafinal.Value.ToString("dd/MM/yyyy"));
        }
        public void ActualizarDatos(object sender, FormClosedEventArgs e)
        {
            MostrarRegistro();
           
        }

        private void FrmListadoventas_Load(object sender, EventArgs e)
        {

            MostrarRegistro();

           

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {

            Close();

        }

        private void ibtnfiltrar_Click(object sender, EventArgs e)
        {
            BuscarRegistro();
        }

        private void ibtnactualizar_Click(object sender, EventArgs e)
        {
            MostrarRegistro();
        }

        private void ibtnnuevo_Click(object sender, EventArgs e)
        {
            frmfacturador ventas = new frmfacturador();
            ventas.FormClosed += new FormClosedEventHandler(ActualizarDatos);
            ventas.ShowDialog();
        }

        private void ibtnanular_Click(object sender, EventArgs e)
        {
            if(dgvlistadoventas.Rows.Count > 0)
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Realmente desea anular el comprobante? ", "KIDDER SA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(opcion == DialogResult.OK)
                {
                    ObjEntidad.IdVentas = Convert.ToInt32(dgvlistadoventas.CurrentRow.Cells[0].Value.ToString());
                    ObjNegocio.AnularComprobante(ObjEntidad);
                    MensajeConfirmacion("Se anulo correctamente");
                    MostrarRegistro();
                }
            }
            else
            {
                MensajeError("Seleccione el comprobante a eliminar");
            }
        }

        private void dgvlistadoventas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    
      
    }
}
