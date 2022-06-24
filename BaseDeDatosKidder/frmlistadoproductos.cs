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
    public partial class frmlistadoproductos : Form
    {
        public frmlistadoproductos()
        {
            InitializeComponent();
        }

        private void ibtnnuevo_Click(object sender, EventArgs e)
        {
            frmProductos ofrmproductos = new frmProductos();
            ofrmproductos.Show();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {

            //frmfacturador frmfacturador = new frmfacturador();
            //frmfacturador.Show();
            Close();
        }

        private void ibtnbuscar_Click(object sender, EventArgs e)
        {
            BuscarRegistros();
        }


        public void BuscarRegistros()
        {
            dgvlistadoproductos.DataSource = N_Productos.BuscarRegistros(txtbuscar.Text);
        }

        private void dgvlistadoproductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmfacturador datosclientes = Owner as frmfacturador;
            datosclientes.txtidprod.Text = dgvlistadoproductos.CurrentRow.Cells[0].Value.ToString();
            
            datosclientes.txtdescripcion.Text = dgvlistadoproductos.CurrentRow.Cells[1].Value.ToString();
            Close();
        }

      
     
    }
}
