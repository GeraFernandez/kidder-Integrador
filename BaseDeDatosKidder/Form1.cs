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
    public partial class frmCargaClientes : Form
    {
        public frmCargaClientes()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            var ds = new DataSet();
            var dt = new DataTable();
            var cl = new ClientesMetodos();
            dt = cl.Consultar();
            if (dt.Rows.Count != 0)
            {
                  dataGridView1.DataSource = dt; 

            }
            else
            {
                MessageBox.Show("No hay registros en la seleccion");
            }
        }

           private void Form1_Load(object sender, EventArgs e)
           {
               var dt = new DataTable();
               var al = new ClientesMetodos ();
           }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            //var resp = 0;
            DialogResult resp = MessageBox.Show("Confirma la Grabación...", "Grabar", MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question);
            var cl = new clientes();

            if ((resp == DialogResult.Yes))
            {
                if (txtID != null)
                {
              
                    cl.ID = txtID.Text;
                    cl.CUIT = txtCuit.Text;
                    cl.Nombre = txtnombre.Text;
                    cl.Apellido = txtapellido.Text;
                    cl.Iva = cboiva.Text;

                    cl.Telefono = txtTelefono.Text;
                    cl.Email = txtemail.Text;
                    cl.Calle = txtcalle.Text;
                    cl.Numero = txtnumero.Text;
                    cl.Departamento = txtdepartamento.Text;
                    cl.Provincia = txtprovincia.Text;
                    cl.Ciudad = txtciudad.Text;
                    cl.Postal = txtpostal.Text;

                    // cl.FechaAlta = Convert.ToDateTime(dtpfechaAlta.Text);
                    // cl.FechaBaja = Convert.ToDateTime(dtpfechaBaja.Text);
                }
                else
                {
                    MessageBox.Show(" Completar todos los campos ");
                }



                var clMetodo = new ClientesMetodos();
                clMetodo.GrabarClientes(cl);
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Confirma la Modificacion", "Modificar", MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question);
            var cl = new clientes();
            if ((resp == DialogResult.Yes))
            {
                cl.ID = txtID.Text;
                cl.CUIT = txtCuit.Text;
                cl.Nombre = txtnombre.Text;
                cl.Apellido = txtapellido.Text;
                cl.Iva = cboiva.Text;

                cl.Telefono = txtTelefono.Text;
                cl.Email = txtemail.Text;
                cl.Calle = txtcalle.Text;
                cl.Numero = txtnumero.Text;
                cl.Departamento = txtdepartamento.Text;
                cl.Provincia = txtprovincia.Text;
                cl.Ciudad = txtciudad.Text;
                cl.Postal = txtpostal.Text;

                //   cl.FechaAlta = Convert.ToDateTime(dtpfechaAlta.Text);
                //  cl.FechaBaja = Convert.ToDateTime(dtpfechaBaja.Text);

                var clMetodo = new ClientesMetodos();
                clMetodo.ModificarClientes(cl);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

            DialogResult resp = MessageBox.Show("Confirma la Eliminacion...", "Eliminar", MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question);

            if ((resp == DialogResult.Yes))
            {
                var clMetodo = new ClientesMetodos();
                bool borro = clMetodo.BorrarClientes(txtID.Text);
                if (borro == false)
                {
                    MessageBox.Show("Error en eliminacion", "Verifique");
                }
            }
        }

        private void dgvlista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
  //          txtID.Text = dgvlista.Rows[e.RowIndex].Cells[0].Value.ToString();
 //          var cl = new clientes();
 //          var clMetodo = new ClientesMetodos();
 //          DataRow dr;
 //          dr = clMetodo.CargaCampos(txtID.Text);
 //          if (dr["legajo"] != null)
 //          {
 //              txtID.Text = Convert.ToString(dr["legajo"]);
 //              txtapellido.Text = Convert.ToString(dr["Apellido"]);
 //              txtnombre.Text = Convert.ToString(dr["Nombre"]);


            }

    
    }
    }


