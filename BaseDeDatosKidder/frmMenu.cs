using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace BaseDeDatosKidder
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }



        private void cargaDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargaClientes ofrmCargaClientes = new frmCargaClientes();
            ofrmCargaClientes.Show();
        }

   

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void productosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmProductos ofrmProductos = new frmProductos();
            ofrmProductos.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCargaClientes ofrmCargaClientes = new frmCargaClientes();
            ofrmCargaClientes.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmProductos ofrmProductos = new frmProductos();
            ofrmProductos.Show();
        }

  

        private void ibtnCargaclientes_Click_1(object sender, EventArgs e)
        {
            frmCargaClientes ofrmCargaClientes = new frmCargaClientes();
            ofrmCargaClientes.Show();
        }

        private void ibtnCargaproductos_Click_1(object sender, EventArgs e)
        {
            frmProductos ofrmProductos = new frmProductos();
            ofrmProductos.Show();
        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblfecha.Text = DateTime.Now.ToLongDateString();
                }

        private void ibtnNotapedido_Click(object sender, EventArgs e)
        {
            frmnotapedido ofrmnotapedido = new frmnotapedido();
            ofrmnotapedido.Show();
        }

        private void ibtnFacturacion_Click(object sender, EventArgs e)
        {
            frmfacturador ofrmfacturador = new frmfacturador();
            ofrmfacturador.Show();
        }

        private void listadoClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoClientes listadoClientes = new ListadoClientes();
            listadoClientes.Show();
        }

        private void listadoDeFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListadoventas frmListadoventas = new FrmListadoventas();
            frmListadoventas.Show();
        }

        private void listadoProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmlistadoproductos frmlistadoproductos = new frmlistadoproductos();
            frmlistadoproductos.Show(); 
        }
    }
}
