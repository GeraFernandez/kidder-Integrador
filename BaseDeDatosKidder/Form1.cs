using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Capa_datos;
using Capa_entidad;
using Capa_negocios;

namespace BaseDeDatosKidder
{
    public partial class frmCargaClientes : Form
    {
        clase_entidad objetent = new clase_entidad();
        clase_negocios objetneg = new clase_negocios();

        public frmCargaClientes()
        {
            InitializeComponent();
            cboinicial.Visible = true;
            cbociudadbsas.Visible = false;
            cbobsas.Visible = false;
            cbocatamarca.Visible = false;
            cbochaco.Visible = false;
            cbochubut.Visible = false;
            cbocordoba.Visible = false;
            cbocorrientes.Visible = false;
            cboentrerios.Visible = false;
            cboformosa.Visible = false;
            cbojujuy.Visible = false;
            cbolapampa.Visible = false;
            cbolarioja.Visible = false;
            cbomendoza.Visible = false;
            cbomisiones.Visible = false;
            cboneuquen.Visible = false;
            cborionegro.Visible = false;
            cbosalta.Visible = false;
            cbosanjuan.Visible = false;
            cbosanluis.Visible = false;
            cbosantacruz.Visible = false;
            cbosantafe.Visible = false;
            cbosantiago.Visible = false;
            cbotierradelfuego.Visible = false;
            cbotucuman.Visible = false;

            cbobsas.Text = txtciudad.Text;




        }
        void mantenimiento(String accion)
        {
            objetent.ID = txtID.Text;
            objetent.CUIT = txtCuit.Text;
            objetent.Iva = cboiva.Text;
            objetent.Nombre = txtnombre.Text;
            objetent.Apellido = txtapellido.Text;
            objetent.Telefono = txtTelefono.Text;
            objetent.Email = txtemail.Text;
            objetent.Calle = txtcalle.Text;
            objetent.Numero = txtnombre.Text;
            objetent.Departamento = txtdepartamento.Text;
            objetent.Provincia = cboprov.Text;
            objetent.Ciudad = txtciudad.Text;
            objetent.Postal = txtpostal.Text;
            objetent.accion = accion;
            String men = objetneg.N_mantenimiento_clientes(objetent);
            MessageBox.Show(men, "Mensajes", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }


        public void Limpiar()
        {
            txtID.Text = "";
            txtapellido.Text = "";
            txtnombre.Text = "";
            txtCuit.Text = "";
            cboiva.Text = "";

            txtdepartamento.Text = "";
            txtcalle.Text = "";
            txtTelefono.Text = "";
            txtemail.Text = "";
            txtnumero.Text = "";
            cboprov.Text = "";
            txtciudad.Text = "";
            txtpostal.Text = "";



            dgvlista.DataSource = objetneg.N_listar_clientes();


        }
        private void frmCargaClientes_Load(object sender, EventArgs e)
        {

            dgvlista.DataSource = objetneg.N_listar_clientes();
        }

        private void ibtnconsultar_Click(object sender, EventArgs e)
        {


            if (txtCuit.Text != "")
            {
                objetent.CUIT = txtCuit.Text;
                DataTable dt = new DataTable();
                dt = objetneg.N_consultar_clientes(objetent);
                dgvlista.DataSource = dt;


                //   Limpiar();

            }
            else dgvlista.DataSource = objetneg.N_listar_clientes();
        }

        private void ibtngrabar_Click(object sender, EventArgs e)
        {
            borrarmensajes();
            validarcampos();

            if (string.IsNullOrEmpty(txtCuit.Text) || string.IsNullOrEmpty(txtnombre.Text) || string.IsNullOrEmpty(txtapellido.Text) || string.IsNullOrEmpty(cboiva.Text))
            {
                MessageBox.Show("Por favor, complete los campos obligatorios");


            }




            else if (MessageBox.Show("Desea registrar A " + txtnombre.Text + " " + txtapellido.Text + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                if (cboinicial.Visible == true)
                {
                    txtciudad.Text = cboinicial.Text;
                }
                else if (cbociudadbsas.Visible == true)
                {
                    txtciudad.Text = cbociudadbsas.Text;
                }
                else if (cbobsas.Visible == true)
                {
                    txtciudad.Text = cbobsas.Text;
                }
                else if (cbocatamarca.Visible == true)
                {
                    txtciudad.Text = cbocatamarca.Text;
                }
                else if (cbochaco.Visible == true)
                {
                    txtciudad.Text = cbochaco.Text;
                }
                else if (cbochubut.Visible == true)
                {
                    txtciudad.Text = cbochubut.Text;
                }
                else if (cbocordoba.Visible == true)
                {
                    txtciudad.Text = cbocordoba.Text;
                }
                else if (cbocorrientes.Visible == true)
                {
                    txtciudad.Text = cbocorrientes.Text;
                }
                else if (cboentrerios.Visible == true)
                {
                    txtciudad.Text = cboentrerios.Text;
                }
                else if (cboformosa.Visible == true)
                {
                    cbojujuy.Text = cboformosa.Text;
                }
                else if (cbojujuy.Visible == true)
                {
                    txtciudad.Text = cbojujuy.Text;
                }
                else if (cbolapampa.Visible == true)
                {
                    txtciudad.Text = cbolapampa.Text;
                }
                else if (cbolarioja.Visible == true)
                {
                    txtciudad.Text = cbolarioja.Text;
                }
                else if (cbomendoza.Visible == true)
                {
                    txtciudad.Text = cbomendoza.Text;
                }
                else if (cbomisiones.Visible == true)
                {
                    txtciudad.Text = cbomisiones.Text;
                }
                else if (cboneuquen.Visible == true)
                {
                    txtciudad.Text = cboneuquen.Text;
                }
                else if (cborionegro.Visible == true)
                {
                    txtciudad.Text = cborionegro.Text;
                }
                else if (cbosalta.Visible == true)
                {
                    txtciudad.Text = cbosalta.Text;
                }
                else if (cbosanjuan.Visible == true)
                {
                    txtciudad.Text = cbosanjuan.Text;
                }
                else if (cbosanluis.Visible == true)
                {
                    txtciudad.Text = cbosanluis.Text;
                }
                else if (cbosantacruz.Visible == true)
                {
                    txtciudad.Text = cbosantacruz.Text;
                }
                else if (cbosantafe.Visible == true)
                {
                    txtciudad.Text = cbosantafe.Text;
                }
                else if (cbosantiago.Visible == true)
                {
                    txtciudad.Text = cbosantiago.Text;
                }
                else if (cbotierradelfuego.Visible == true)
                {
                    txtciudad.Text = cbotierradelfuego.Text;
                }
                else if (cbotucuman.Visible == true)
                {
                    txtciudad.Text = cbotucuman.Text;
                }

                mantenimiento("1");
                Limpiar();

            }


        }
        // borrarmensajes();
        // validarcampos();
        //if (validarcampos())
        //{
        //    MessageBox.Show("Datos cargados correctamente");
        //        }






        private bool validarcampos()
        {
            bool ok = true;



            if (txtCuit.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtCuit, "Ingresar CUIT");
            }
            // return ok;

            if (txtnombre.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtnombre, "Ingresar nombre");
            }
            //  return ok;

            if (txtapellido.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtapellido, "Ingresar apellido");
            }
            // return ok;

            if (cboiva.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cboiva, "Ingresar Condicion fiscal");
            }
            return ok;

        }

        private void borrarmensajes()

        {
            errorProvider1.SetError(txtCuit, "");
            errorProvider1.SetError(txtnombre, "");
            errorProvider1.SetError(txtapellido, "");
            errorProvider1.SetError(cboiva, "");
        }



        private void ibtnmodificar_Click(object sender, EventArgs e)
        {
            borrarmensajes();
            validarcampos();

            if (string.IsNullOrEmpty(txtCuit.Text) || string.IsNullOrEmpty(txtnombre.Text) || string.IsNullOrEmpty(txtapellido.Text) || string.IsNullOrEmpty(cboiva.Text))
            {
                MessageBox.Show("Por favor, complete los campos obligatorios");
                if (cboiva.SelectedIndex == 0) 
                {
                    MessageBox.Show("Por favor, complete los campos obligatorios");
                }



            }


            else if (MessageBox.Show("Desea Modificar a " + txtnombre.Text + " ?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (cboinicial.Visible == true)
                {
                    txtciudad.Text = cboinicial.Text;
                }
                else if (cbociudadbsas.Visible == true)
                {
                    txtciudad.Text = cbociudadbsas.Text;
                }
                else if (cbobsas.Visible == true)
                {
                    txtciudad.Text = cbobsas.Text;
                }
                else if (cbocatamarca.Visible == true)
                {
                    txtciudad.Text = cbocatamarca.Text;
                }
                else if (cbochaco.Visible == true)
                {
                    txtciudad.Text = cbochaco.Text;
                }
                else if (cbochubut.Visible == true)
                {
                    txtciudad.Text = cbochubut.Text;
                }
                else if (cbocordoba.Visible == true)
                {
                    txtciudad.Text = cbocordoba.Text;
                }
                else if (cbocorrientes.Visible == true)
                {
                    txtciudad.Text = cbocorrientes.Text;
                }
                else if (cboentrerios.Visible == true)
                {
                    txtciudad.Text = cboentrerios.Text;
                }
                else if (cboformosa.Visible == true)
                {
                    cbojujuy.Text = cboformosa.Text;
                }
                else if (cbojujuy.Visible == true)
                {
                    txtciudad.Text = cbojujuy.Text;
                }
                else if (cbolapampa.Visible == true)
                {
                    txtciudad.Text = cbolapampa.Text;
                }
                else if (cbolarioja.Visible == true)
                {
                    txtciudad.Text = cbolarioja.Text;
                }
                else if (cbomendoza.Visible == true)
                {
                    txtciudad.Text = cbomendoza.Text;
                }
                else if (cbomisiones.Visible == true)
                {
                    txtciudad.Text = cbomisiones.Text;
                }
                else if (cboneuquen.Visible == true)
                {
                    txtciudad.Text = cboneuquen.Text;
                }
                else if (cborionegro.Visible == true)
                {
                    txtciudad.Text = cborionegro.Text;
                }
                else if (cbosalta.Visible == true)
                {
                    txtciudad.Text = cbosalta.Text;
                }
                else if (cbosanjuan.Visible == true)
                {
                    txtciudad.Text = cbosanjuan.Text;
                }
                else if (cbosanluis.Visible == true)
                {
                    txtciudad.Text = cbosanluis.Text;
                }
                else if (cbosantacruz.Visible == true)
                {
                    txtciudad.Text = cbosantacruz.Text;
                }
                else if (cbosantafe.Visible == true)
                {
                    txtciudad.Text = cbosantafe.Text;
                }
                else if (cbosantiago.Visible == true)
                {
                    txtciudad.Text = cbosantiago.Text;
                }
                else if (cbotierradelfuego.Visible == true)
                {
                    txtciudad.Text = cbotierradelfuego.Text;
                }
                else if (cbotucuman.Visible == true)
                {
                    txtciudad.Text = cbotucuman.Text;
                }

                mantenimiento("2");
                Limpiar();
            }
        }
        
   


        private void ibtnborrar_Click(object sender, EventArgs e)
        {




            if (string.IsNullOrEmpty(txtCuit.Text))
            {
                MessageBox.Show("Por favor, complete los campos obligatorios");

                bool ok = true;

                errorProvider1.SetError(txtCuit, "");

                if (txtCuit.Text == "")
                {
                    ok = false;
                    errorProvider1.SetError(txtCuit, "Ingresar CUIT");
                }
                   
                
                
            }

            else if (MessageBox.Show("Desea borrar a " + txtnombre.Text + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                mantenimiento("3");
                Limpiar();
            }
            
        }
    

        private void ibtncancelar_Click(object sender, EventArgs e)
        {
            frmMenu ofrmMenu = new frmMenu();
            ofrmMenu.Show();
        }

        //   private void txtCuit_TextChanged(object sender, EventArgs e)
        //   {
        //       if (txtCuit.Text != "")
        //       {
        //           objetent.CUIT = txtCuit.Text;
        //           DataTable dt = new DataTable();
        //           dt = objetneg.N_consultar_clientes(objetent);
        //           dgvlista.DataSource = dt;
        //
        //
        //           //  Limpiar();
        //
        //       }
        //       else dgvlista.DataSource = objetneg.N_listar_clientes();
        //   }

        private void dgvlista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dgvlista.CurrentCell.RowIndex;
            txtID.Text = dgvlista[0, fila].Value.ToString();
            txtCuit.Text = dgvlista[1, fila].Value.ToString();
            txtnombre.Text = dgvlista[3, fila].Value.ToString();
            txtapellido.Text = dgvlista[4, fila].Value.ToString();
            cboiva.Text = dgvlista[2, fila].Value.ToString();
            txtTelefono.Text = dgvlista[5, fila].Value.ToString();
            txtemail.Text = dgvlista[6, fila].Value.ToString();
            txtcalle.Text = dgvlista[7, fila].Value.ToString();
            txtnumero.Text = dgvlista[8, fila].Value.ToString();
            txtdepartamento.Text = dgvlista[9, fila].Value.ToString();
            cboprov.Text = dgvlista[10, fila].Value.ToString();
            //cboinicial.Text = dgvlista[11, fila].Value.ToString();
            txtpostal.Text = dgvlista[12, fila].Value.ToString();

        }

        private void cboprov_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboprov.SelectedIndex == 1)
            {
                cboinicial.Visible = false;
                cbociudadbsas.Visible = true;
                cbobsas.Visible = false;
                cbocatamarca.Visible = false;
                cbochaco.Visible = false;
                cbochubut.Visible = false;
                cbocordoba.Visible = false;
                cbocorrientes.Visible = false;
                cboentrerios.Visible = false;
                cboformosa.Visible = false;
                cbojujuy.Visible = false;
                cbolapampa.Visible = false;
                cbolarioja.Visible = false;
                cbomendoza.Visible = false;
                cbomisiones.Visible = false;
                cboneuquen.Visible = false;
                cborionegro.Visible = false;
                cbosalta.Visible = false;
                cbosanjuan.Visible = false;
                cbosanluis.Visible = false;
                cbosantacruz.Visible = false;
                cbosantafe.Visible = false;
                cbosantiago.Visible = false;
                cbotierradelfuego.Visible = false;
                cbotucuman.Visible = false;
            }
            else if (cboprov.SelectedIndex == 2)
            {
                cboinicial.Visible = false;
                cbociudadbsas.Visible = false;
                cbobsas.Visible = true;
                cbocatamarca.Visible = false;
                cbochaco.Visible = false;
                cbochubut.Visible = false;
                cbocordoba.Visible = false;
                cbocorrientes.Visible = false;
                cboentrerios.Visible = false;
                cboformosa.Visible = false;
                cbojujuy.Visible = false;
                cbolapampa.Visible = false;
                cbolarioja.Visible = false;
                cbomendoza.Visible = false;
                cbomisiones.Visible = false;
                cboneuquen.Visible = false;
                cborionegro.Visible = false;
                cbosalta.Visible = false;
                cbosanjuan.Visible = false;
                cbosanluis.Visible = false;
                cbosantacruz.Visible = false;
                cbosantafe.Visible = false;
                cbosantiago.Visible = false;
                cbotierradelfuego.Visible = false;
                cbotucuman.Visible = false;
            }
            else if (cboprov.SelectedIndex == 2)
            {
                cboinicial.Visible = true;
                cbociudadbsas.Visible = false;
                cbobsas.Visible = false;
                cbocatamarca.Visible = false;
                cbochaco.Visible = false;
                cbochubut.Visible = false;
                cbocordoba.Visible = false;
                cbocorrientes.Visible = false;
                cboentrerios.Visible = false;
                cboformosa.Visible = false;
                cbojujuy.Visible = false;
                cbolapampa.Visible = false;
                cbolarioja.Visible = false;
                cbomendoza.Visible = false;
                cbomisiones.Visible = false;
                cboneuquen.Visible = false;
                cborionegro.Visible = false;
                cbosalta.Visible = false;
                cbosanjuan.Visible = false;
                cbosanluis.Visible = false;
                cbosantacruz.Visible = false;
                cbosantafe.Visible = false;
                cbosantiago.Visible = false;
                cbotierradelfuego.Visible = false;
                cbotucuman.Visible = false;
            }
            else if (cboprov.SelectedIndex == 3)
            {
                cboinicial.Visible = false;
                cbociudadbsas.Visible = false;
                cbobsas.Visible = false;
                cbocatamarca.Visible = true;
                cbochaco.Visible = false;
                cbochubut.Visible = false;
                cbocordoba.Visible = false;
                cbocorrientes.Visible = false;
                cboentrerios.Visible = false;
                cboformosa.Visible = false;
                cbojujuy.Visible = false;
                cbolapampa.Visible = false;
                cbolarioja.Visible = false;
                cbomendoza.Visible = false;
                cbomisiones.Visible = false;
                cboneuquen.Visible = false;
                cborionegro.Visible = false;
                cbosalta.Visible = false;
                cbosanjuan.Visible = false;
                cbosanluis.Visible = false;
                cbosantacruz.Visible = false;
                cbosantafe.Visible = false;
                cbosantiago.Visible = false;
                cbotierradelfuego.Visible = false;
                cbotucuman.Visible = false;
            }
            else if (cboprov.SelectedIndex == 4)
            {
                cboinicial.Visible = false;
                cbociudadbsas.Visible = false;
                cbobsas.Visible = false;
                cbocatamarca.Visible = false;
                cbochaco.Visible = true;
                cbochubut.Visible = false;
                cbocordoba.Visible = false;
                cbocorrientes.Visible = false;
                cboentrerios.Visible = false;
                cboformosa.Visible = false;
                cbojujuy.Visible = false;
                cbolapampa.Visible = false;
                cbolarioja.Visible = false;
                cbomendoza.Visible = false;
                cbomisiones.Visible = false;
                cboneuquen.Visible = false;
                cborionegro.Visible = false;
                cbosalta.Visible = false;
                cbosanjuan.Visible = false;
                cbosanluis.Visible = false;
                cbosantacruz.Visible = false;
                cbosantafe.Visible = false;
                cbosantiago.Visible = false;
                cbotierradelfuego.Visible = false;
                cbotucuman.Visible = false;
            }
            else if (cboprov.SelectedIndex == 5)
            {
                cboinicial.Visible = false;
                cbociudadbsas.Visible = false;
                cbobsas.Visible = false;
                cbocatamarca.Visible = false;
                cbochaco.Visible = false;
                cbochubut.Visible = true;
                cbocordoba.Visible = false;
                cbocorrientes.Visible = false;
                cboentrerios.Visible = false;
                cboformosa.Visible = false;
                cbojujuy.Visible = false;
                cbolapampa.Visible = false;
                cbolarioja.Visible = false;
                cbomendoza.Visible = false;
                cbomisiones.Visible = false;
                cboneuquen.Visible = false;
                cborionegro.Visible = false;
                cbosalta.Visible = false;
                cbosanjuan.Visible = false;
                cbosanluis.Visible = false;
                cbosantacruz.Visible = false;
                cbosantafe.Visible = false;
                cbosantiago.Visible = false;
                cbotierradelfuego.Visible = false;
                cbotucuman.Visible = false;
            }
            else if (cboprov.SelectedIndex == 6)
            {
                cboinicial.Visible = false;
                cbociudadbsas.Visible = false;
                cbobsas.Visible = false;
                cbocatamarca.Visible = false;
                cbochaco.Visible = false;
                cbochubut.Visible = false;
                cbocordoba.Visible = true;
                cbocorrientes.Visible = false;
                cboentrerios.Visible = false;
                cboformosa.Visible = false;
                cbojujuy.Visible = false;
                cbolapampa.Visible = false;
                cbolarioja.Visible = false;
                cbomendoza.Visible = false;
                cbomisiones.Visible = false;
                cboneuquen.Visible = false;
                cborionegro.Visible = false;
                cbosalta.Visible = false;
                cbosanjuan.Visible = false;
                cbosanluis.Visible = false;
                cbosantacruz.Visible = false;
                cbosantafe.Visible = false;
                cbosantiago.Visible = false;
                cbotierradelfuego.Visible = false;
                cbotucuman.Visible = false;
            }
            else if (cboprov.SelectedIndex == 7)
            {
                cboinicial.Visible = false;
                cbociudadbsas.Visible = false;
                cbobsas.Visible = false;
                cbocatamarca.Visible = false;
                cbochaco.Visible = false;
                cbochubut.Visible = false;
                cbocordoba.Visible = false;
                cbocorrientes.Visible = true;
                cboentrerios.Visible = false;
                cboformosa.Visible = false;
                cbojujuy.Visible = false;
                cbolapampa.Visible = false;
                cbolarioja.Visible = false;
                cbomendoza.Visible = false;
                cbomisiones.Visible = false;
                cboneuquen.Visible = false;
                cborionegro.Visible = false;
                cbosalta.Visible = false;
                cbosanjuan.Visible = false;
                cbosanluis.Visible = false;
                cbosantacruz.Visible = false;
                cbosantafe.Visible = false;
                cbosantiago.Visible = false;
                cbotierradelfuego.Visible = false;
                cbotucuman.Visible = false;
            }
            else if (cboprov.SelectedIndex == 8)
            {
                cboinicial.Visible = false;
                cbociudadbsas.Visible = false;
                cbobsas.Visible = false;
                cbocatamarca.Visible = false;
                cbochaco.Visible = false;
                cbochubut.Visible = false;
                cbocordoba.Visible = false;
                cbocorrientes.Visible = false;
                cboentrerios.Visible = true;
                cboformosa.Visible = false;
                cbojujuy.Visible = false;
                cbolapampa.Visible = false;
                cbolarioja.Visible = false;
                cbomendoza.Visible = false;
                cbomisiones.Visible = false;
                cboneuquen.Visible = false;
                cborionegro.Visible = false;
                cbosalta.Visible = false;
                cbosanjuan.Visible = false;
                cbosanluis.Visible = false;
                cbosantacruz.Visible = false;
                cbosantafe.Visible = false;
                cbosantiago.Visible = false;
                cbotierradelfuego.Visible = false;
                cbotucuman.Visible = false;
            }
            else if (cboprov.SelectedIndex == 9)
            {
                cboinicial.Visible = false;
                cbociudadbsas.Visible = false;
                cbobsas.Visible = false;
                cbocatamarca.Visible = false;
                cbochaco.Visible = false;
                cbochubut.Visible = false;
                cbocordoba.Visible = false;
                cbocorrientes.Visible = false;
                cboentrerios.Visible = false;
                cboformosa.Visible = true;
                cbojujuy.Visible = false;
                cbolapampa.Visible = false;
                cbolarioja.Visible = false;
                cbomendoza.Visible = false;
                cbomisiones.Visible = false;
                cboneuquen.Visible = false;
                cborionegro.Visible = false;
                cbosalta.Visible = false;
                cbosanjuan.Visible = false;
                cbosanluis.Visible = false;
                cbosantacruz.Visible = false;
                cbosantafe.Visible = false;
                cbosantiago.Visible = false;
                cbotierradelfuego.Visible = false;
                cbotucuman.Visible = false;
            }
            else if (cboprov.SelectedIndex == 10)
            {
                cboinicial.Visible = false;
                cbociudadbsas.Visible = false;
                cbobsas.Visible = false;
                cbocatamarca.Visible = false;
                cbochaco.Visible = false;
                cbochubut.Visible = false;
                cbocordoba.Visible = false;
                cbocorrientes.Visible = false;
                cboentrerios.Visible = false;
                cboformosa.Visible = false;
                cbojujuy.Visible = true;
                cbolapampa.Visible = false;
                cbolarioja.Visible = false;
                cbomendoza.Visible = false;
                cbomisiones.Visible = false;
                cboneuquen.Visible = false;
                cborionegro.Visible = false;
                cbosalta.Visible = false;
                cbosanjuan.Visible = false;
                cbosanluis.Visible = false;
                cbosantacruz.Visible = false;
                cbosantafe.Visible = false;
                cbosantiago.Visible = false;
                cbotierradelfuego.Visible = false;
                cbotucuman.Visible = false;
            }
            else if (cboprov.SelectedIndex == 11)
            {
                cboinicial.Visible = false;
                cbociudadbsas.Visible = false;
                cbobsas.Visible = false;
                cbocatamarca.Visible = false;
                cbochaco.Visible = false;
                cbochubut.Visible = false;
                cbocordoba.Visible = false;
                cbocorrientes.Visible = false;
                cboentrerios.Visible = false;
                cboformosa.Visible = false;
                cbojujuy.Visible = false;
                cbolapampa.Visible = true;
                cbolarioja.Visible = false;
                cbomendoza.Visible = false;
                cbomisiones.Visible = false;
                cboneuquen.Visible = false;
                cborionegro.Visible = false;
                cbosalta.Visible = false;
                cbosanjuan.Visible = false;
                cbosanluis.Visible = false;
                cbosantacruz.Visible = false;
                cbosantafe.Visible = false;
                cbosantiago.Visible = false;
                cbotierradelfuego.Visible = false;
                cbotucuman.Visible = false;
            }
            else if (cboprov.SelectedIndex == 12)
            {
                cboinicial.Visible = false;
                cbociudadbsas.Visible = false;
                cbobsas.Visible = false;
                cbocatamarca.Visible = false;
                cbochaco.Visible = false;
                cbochubut.Visible = false;
                cbocordoba.Visible = false;
                cbocorrientes.Visible = false;
                cboentrerios.Visible = false;
                cboformosa.Visible = false;
                cbojujuy.Visible = false;
                cbolapampa.Visible = false;
                cbolarioja.Visible = true;
                cbomendoza.Visible = false;
                cbomisiones.Visible = false;
                cboneuquen.Visible = false;
                cborionegro.Visible = false;
                cbosalta.Visible = false;
                cbosanjuan.Visible = false;
                cbosanluis.Visible = false;
                cbosantacruz.Visible = false;
                cbosantafe.Visible = false;
                cbosantiago.Visible = false;
                cbotierradelfuego.Visible = false;
                cbotucuman.Visible = false;
            }
            else if (cboprov.SelectedIndex == 13)
            {
                cboinicial.Visible = false;
                cbociudadbsas.Visible = false;
                cbobsas.Visible = false;
                cbocatamarca.Visible = false;
                cbochaco.Visible = false;
                cbochubut.Visible = false;
                cbocordoba.Visible = false;
                cbocorrientes.Visible = false;
                cboentrerios.Visible = false;
                cboformosa.Visible = false;
                cbojujuy.Visible = false;
                cbolapampa.Visible = false;
                cbolarioja.Visible = false;
                cbomendoza.Visible = true;
                cbomisiones.Visible = false;
                cboneuquen.Visible = false;
                cborionegro.Visible = false;
                cbosalta.Visible = false;
                cbosanjuan.Visible = false;
                cbosanluis.Visible = false;
                cbosantacruz.Visible = false;
                cbosantafe.Visible = false;
                cbosantiago.Visible = false;
                cbotierradelfuego.Visible = false;
                cbotucuman.Visible = false;
            }
            else if (cboprov.SelectedIndex == 14)
            {
                cboinicial.Visible = false;
                cbociudadbsas.Visible = false;
                cbobsas.Visible = false;
                cbocatamarca.Visible = false;
                cbochaco.Visible = false;
                cbochubut.Visible = false;
                cbocordoba.Visible = false;
                cbocorrientes.Visible = false;
                cboentrerios.Visible = false;
                cboformosa.Visible = false;
                cbojujuy.Visible = false;
                cbolapampa.Visible = false;
                cbolarioja.Visible = false;
                cbomendoza.Visible = false;
                cbomisiones.Visible = true;
                cboneuquen.Visible = false;
                cborionegro.Visible = false;
                cbosalta.Visible = false;
                cbosanjuan.Visible = false;
                cbosanluis.Visible = false;
                cbosantacruz.Visible = false;
                cbosantafe.Visible = false;
                cbosantiago.Visible = false;
                cbotierradelfuego.Visible = false;
                cbotucuman.Visible = false;
            }
            else if (cboprov.SelectedIndex == 15)
            {
                cboinicial.Visible = false;
                cbociudadbsas.Visible = false;
                cbobsas.Visible = false;
                cbocatamarca.Visible = false;
                cbochaco.Visible = false;
                cbochubut.Visible = false;
                cbocordoba.Visible = false;
                cbocorrientes.Visible = false;
                cboentrerios.Visible = false;
                cboformosa.Visible = false;
                cbojujuy.Visible = false;
                cbolapampa.Visible = false;
                cbolarioja.Visible = false;
                cbomendoza.Visible = false;
                cbomisiones.Visible = false;
                cboneuquen.Visible = true;
                cborionegro.Visible = false;
                cbosalta.Visible = false;
                cbosanjuan.Visible = false;
                cbosanluis.Visible = false;
                cbosantacruz.Visible = false;
                cbosantafe.Visible = false;
                cbosantiago.Visible = false;
                cbotierradelfuego.Visible = false;
                cbotucuman.Visible = false;
            }
            else if (cboprov.SelectedIndex == 16)
            {
                cboinicial.Visible = false;
                cbociudadbsas.Visible = false;
                cbobsas.Visible = false;
                cbocatamarca.Visible = false;
                cbochaco.Visible = false;
                cbochubut.Visible = false;
                cbocordoba.Visible = false;
                cbocorrientes.Visible = false;
                cboentrerios.Visible = false;
                cboformosa.Visible = false;
                cbojujuy.Visible = false;
                cbolapampa.Visible = false;
                cbolarioja.Visible = false;
                cbomendoza.Visible = false;
                cbomisiones.Visible = false;
                cboneuquen.Visible = false;
                cborionegro.Visible = true;
                cbosalta.Visible = false;
                cbosanjuan.Visible = false;
                cbosanluis.Visible = false;
                cbosantacruz.Visible = false;
                cbosantafe.Visible = false;
                cbosantiago.Visible = false;
                cbotierradelfuego.Visible = false;
                cbotucuman.Visible = false;
            }
            else if (cboprov.SelectedIndex == 17)
            {
                cboinicial.Visible = false;
                cbociudadbsas.Visible = false;
                cbobsas.Visible = false;
                cbocatamarca.Visible = false;
                cbochaco.Visible = false;
                cbochubut.Visible = false;
                cbocordoba.Visible = false;
                cbocorrientes.Visible = false;
                cboentrerios.Visible = false;
                cboformosa.Visible = false;
                cbojujuy.Visible = false;
                cbolapampa.Visible = false;
                cbolarioja.Visible = false;
                cbomendoza.Visible = false;
                cbomisiones.Visible = false;
                cboneuquen.Visible = false;
                cborionegro.Visible = false;
                cbosalta.Visible = true;
                cbosanjuan.Visible = false;
                cbosanluis.Visible = false;
                cbosantacruz.Visible = false;
                cbosantafe.Visible = false;
                cbosantiago.Visible = false;
                cbotierradelfuego.Visible = false;
                cbotucuman.Visible = false;
            }
            else if (cboprov.SelectedIndex == 18)
            {
                cboinicial.Visible = false;
                cbociudadbsas.Visible = false;
                cbobsas.Visible = false;
                cbocatamarca.Visible = false;
                cbochaco.Visible = false;
                cbochubut.Visible = false;
                cbocordoba.Visible = false;
                cbocorrientes.Visible = false;
                cboentrerios.Visible = false;
                cboformosa.Visible = false;
                cbojujuy.Visible = false;
                cbolapampa.Visible = false;
                cbolarioja.Visible = false;
                cbomendoza.Visible = false;
                cbomisiones.Visible = false;
                cboneuquen.Visible = false;
                cborionegro.Visible = false;
                cbosalta.Visible = false;
                cbosanjuan.Visible = true;
                cbosanluis.Visible = false;
                cbosantacruz.Visible = false;
                cbosantafe.Visible = false;
                cbosantiago.Visible = false;
                cbotierradelfuego.Visible = false;
                cbotucuman.Visible = false;
            }
            else if (cboprov.SelectedIndex == 19)
            {
                cboinicial.Visible = false;
                cbociudadbsas.Visible = false;
                cbobsas.Visible = false;
                cbocatamarca.Visible = false;
                cbochaco.Visible = false;
                cbochubut.Visible = false;
                cbocordoba.Visible = false;
                cbocorrientes.Visible = false;
                cboentrerios.Visible = false;
                cboformosa.Visible = false;
                cbojujuy.Visible = false;
                cbolapampa.Visible = false;
                cbolarioja.Visible = false;
                cbomendoza.Visible = false;
                cbomisiones.Visible = false;
                cboneuquen.Visible = false;
                cborionegro.Visible = false;
                cbosalta.Visible = false;
                cbosanjuan.Visible = false;
                cbosanluis.Visible = true;
                cbosantacruz.Visible = false;
                cbosantafe.Visible = false;
                cbosantiago.Visible = false;
                cbotierradelfuego.Visible = false;
                cbotucuman.Visible = false;
            }
            else if (cboprov.SelectedIndex == 20)
            {
                cboinicial.Visible = false;
                cbociudadbsas.Visible = false;
                cbobsas.Visible = false;
                cbocatamarca.Visible = false;
                cbochaco.Visible = false;
                cbochubut.Visible = false;
                cbocordoba.Visible = false;
                cbocorrientes.Visible = false;
                cboentrerios.Visible = false;
                cboformosa.Visible = false;
                cbojujuy.Visible = false;
                cbolapampa.Visible = false;
                cbolarioja.Visible = false;
                cbomendoza.Visible = false;
                cbomisiones.Visible = false;
                cboneuquen.Visible = false;
                cborionegro.Visible = false;
                cbosalta.Visible = false;
                cbosanjuan.Visible = false;
                cbosanluis.Visible = false;
                cbosantacruz.Visible = true;
                cbosantafe.Visible = false;
                cbosantiago.Visible = false;
                cbotierradelfuego.Visible = false;
                cbotucuman.Visible = false;
            }
            else if (cboprov.SelectedIndex == 21)
            {
                cboinicial.Visible = false;
                cbociudadbsas.Visible = false;
                cbobsas.Visible = false;
                cbocatamarca.Visible = false;
                cbochaco.Visible = false;
                cbochubut.Visible = false;
                cbocordoba.Visible = false;
                cbocorrientes.Visible = false;
                cboentrerios.Visible = false;
                cboformosa.Visible = false;
                cbojujuy.Visible = false;
                cbolapampa.Visible = false;
                cbolarioja.Visible = false;
                cbomendoza.Visible = false;
                cbomisiones.Visible = false;
                cboneuquen.Visible = false;
                cborionegro.Visible = false;
                cbosalta.Visible = false;
                cbosanjuan.Visible = false;
                cbosanluis.Visible = false;
                cbosantacruz.Visible = false;
                cbosantafe.Visible = true;
                cbosantiago.Visible = false;
                cbotierradelfuego.Visible = false;
                cbotucuman.Visible = false;
            }
            else if (cboprov.SelectedIndex == 22)
            {
                cboinicial.Visible = false;
                cbociudadbsas.Visible = false;
                cbobsas.Visible = false;
                cbocatamarca.Visible = false;
                cbochaco.Visible = false;
                cbochubut.Visible = false;
                cbocordoba.Visible = false;
                cbocorrientes.Visible = false;
                cboentrerios.Visible = false;
                cboformosa.Visible = false;
                cbojujuy.Visible = false;
                cbolapampa.Visible = false;
                cbolarioja.Visible = false;
                cbomendoza.Visible = false;
                cbomisiones.Visible = false;
                cboneuquen.Visible = false;
                cborionegro.Visible = false;
                cbosalta.Visible = false;
                cbosanjuan.Visible = false;
                cbosanluis.Visible = false;
                cbosantacruz.Visible = false;
                cbosantafe.Visible = false;
                cbosantiago.Visible = true;
                cbotierradelfuego.Visible = false;
                cbotucuman.Visible = false;
            }
            else if (cboprov.SelectedIndex == 23)
            {
                cboinicial.Visible = false;
                cbociudadbsas.Visible = false;
                cbobsas.Visible = false;
                cbocatamarca.Visible = false;
                cbochaco.Visible = false;
                cbochubut.Visible = false;
                cbocordoba.Visible = false;
                cbocorrientes.Visible = false;
                cboentrerios.Visible = false;
                cboformosa.Visible = false;
                cbojujuy.Visible = false;
                cbolapampa.Visible = false;
                cbolarioja.Visible = false;
                cbomendoza.Visible = false;
                cbomisiones.Visible = false;
                cboneuquen.Visible = false;
                cborionegro.Visible = false;
                cbosalta.Visible = false;
                cbosanjuan.Visible = false;
                cbosanluis.Visible = false;
                cbosantacruz.Visible = false;
                cbosantafe.Visible = false;
                cbosantiago.Visible = false;
                cbotierradelfuego.Visible = true;
                if (cbotierradelfuego.Visible == true)
                {
                    txtciudad.Text = cbotierradelfuego.Text;
                }
                cbotucuman.Visible = false;


            }
            else if (cboprov.SelectedIndex == 24)
            {
                cboinicial.Visible = false;
                cbociudadbsas.Visible = false;
                cbobsas.Visible = false;
                cbocatamarca.Visible = false;
                cbochaco.Visible = false;
                cbochubut.Visible = false;
                cbocordoba.Visible = false;
                cbocorrientes.Visible = false;
                cboentrerios.Visible = false;
                cboformosa.Visible = false;
                cbojujuy.Visible = false;
                cbolapampa.Visible = false;
                cbolarioja.Visible = false;
                cbomendoza.Visible = false;
                cbomisiones.Visible = false;
                cboneuquen.Visible = false;
                cborionegro.Visible = false;
                cbosalta.Visible = false;
                cbosanjuan.Visible = false;
                cbosanluis.Visible = false;
                cbosantacruz.Visible = false;
                cbosantafe.Visible = false;
                cbosantiago.Visible = false;
                cbotierradelfuego.Visible = false;
                cbotucuman.Visible = true;
            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.correoargentino.com.ar/formularios/cpa");
        }

       
    }
  //  public bool agregarcliente (frmCargaClientes)

}


