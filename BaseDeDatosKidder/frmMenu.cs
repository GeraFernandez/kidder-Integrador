using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void productosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmProductos ofrmProductos = new frmProductos();
            ofrmProductos.Show();
        }

 
    }
}
