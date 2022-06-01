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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            var ds = new DataSet();
            var dt = new DataTable();
            var pr = new ProductosMetodos();
            dt = pr.Consultar();
            if (dt.Rows.Count != 0)
            {
                dgvproductos.DataSource = dt;

            }
            else
            {
                MessageBox.Show("No hay registros en la seleccion");
            }
        }




        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

            DialogResult resp = MessageBox.Show("Confirma la Grabación...", "Grabar", MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question);
            var pr = new Productos();

            if ((resp == DialogResult.Yes))
            {
                pr.ID = txtID.Text;
                pr.Modelo = cboModelo.Text;
                pr.Color = cboColor.Text;
                pr.Talle = cboTalle.Text;
                pr.Descripcion = txtDescripcion.Text;
            }
            else
            {
                MessageBox.Show(" Completar todos los campos ");
            }



            var prMetodo = new ProductosMetodos();
            prMetodo.GrabarProductos(pr);

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Confirma la Modificacion...", "Modificar", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            var pr = new Productos();
            if ((resp == DialogResult.Yes))
            {
                pr.ID = txtID.Text;
                pr.Modelo = cboModelo.Text;
                pr.Color = cboColor.Text;
                pr.Talle = cboTalle.Text;
                pr.Descripcion = txtDescripcion.Text;

                var prMetodo = new ProductosMetodos();
                prMetodo.ModificarProductos(pr);
            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Confirma la Eliminacion...", "Eliminar", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);

            if ((resp == DialogResult.Yes))
            {
                var prMetodo = new ProductosMetodos();
                bool borro = prMetodo.BorrarProductos(txtID.Text);
                if (borro == false)
                {
                    MessageBox.Show("Error en eliminacion", "Verifique");
                }

            }
        }


    } }


    

