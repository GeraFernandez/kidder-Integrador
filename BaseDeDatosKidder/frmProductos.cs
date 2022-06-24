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


namespace BaseDeDatosKidder
{
    public partial class frmProductos : Form
    {
        static string conexionstring = "Data Source=LAPTOP-1P6UFP3F\\SQLEXPRESS01;Initial Catalog = KIDDER; Integrated Security = True";
        SqlConnection conexion = new SqlConnection(conexionstring);
        // conexion.open();


        public frmProductos()
        {
            InitializeComponent();
            Limpiar();
        }

        private void ibtnconsultar_Click_1(object sender, EventArgs e)
        {


            if (txtID.Text == "")
            {
                string query = "select * from Productos";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dgvproductos.DataSource = tabla;

            }
            else
            {
                string query = "select * from Productos where ID = '" + txtID.Text + "'";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dgvproductos.DataSource = tabla;
            }
        }




        private void ibtnborrar_Click_1(object sender, EventArgs e)
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
            Limpiar();
        }



        private void ibtnmodificar_Click(object sender, EventArgs e)
        {
            lblid.Text = "" + lblmod.Text + "" + lblcol.Text + "" + lbltall.Text;
            lbldesc.Text = "" + lblmoddesc.Text + "" + lblcoldesc.Text + "" + lbltaldesc.Text;
            txtnombre.Text = lbldesc.Text;

            DialogResult resp = MessageBox.Show("Confirma la Modificacion...", "Modificar", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            var pr = new Productos();
            if ((resp == DialogResult.Yes))
            {
                pr.ID = txtID.Text;
                pr.Modelo = cboModelo.Text;
                pr.Color = cboColor.Text;
                pr.Talle = cboTalle.Text;
                pr.Descripcion = lbldesc.Text;




                var prMetodo = new ProductosMetodos();
                prMetodo.ModificarProductos(pr);
            }
            Limpiar();

        }

        private void ibtnborrar_Click(object sender, EventArgs e)
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
            Limpiar();
        }
        private void Limpiar()
        {

            cboModelo.SelectedIndex = 0;
            cboColor.SelectedIndex = 0;
            cboTalle.SelectedIndex = 0;
            txtnombre.Clear();

            txtID.Focus();

            string query = "select * from Productos";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            dgvproductos.DataSource = tabla;


        }

        public void cboModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int codmod;
            int descmod;

            codmod = cboModelo.SelectedIndex;

            switch (codmod)
            {
                case 0: lblmod.Text = "00"; break;
                case 1: lblmod.Text = "01"; break;
                case 2: lblmod.Text = "02"; break;
                case 3: lblmod.Text = "03"; break;
            }

            descmod = cboModelo.SelectedIndex;

            switch (descmod)
            {
                case 0: lblmoddesc.Text = "00"; break;
                case 1: lblmoddesc.Text = "Zapato "; break;
                case 2: lblmoddesc.Text = "Bota "; break;
                case 3: lblmoddesc.Text = "Borcego "; break;
            }



        }

        public void cboColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int codcol;
            int desccol;

            codcol = cboColor.SelectedIndex;

            switch (codcol)
            {
                case 0: lblcol.Text = "00"; break;
                case 1: lblcol.Text = "01"; break;
                case 2: lblcol.Text = "02"; break;

            }
            desccol = cboColor.SelectedIndex;

            switch (desccol)
            {
                case 0: lblcoldesc.Text = "00"; break;
                case 1: lblcoldesc.Text = "color Negro "; break;
                case 2: lblcoldesc.Text = "color Marron "; break;

            }
        }

        public void cboTalle_SelectedIndexChanged(object sender, EventArgs e)
        {
            int codtall;
            int desctall;
            codtall = cboTalle.SelectedIndex;


            switch (codtall)
            {
                case 0: lbltall.Text = "00"; break;
                case 1: lbltall.Text = "36"; break;
                case 2: lbltall.Text = "37"; break;
                case 3: lbltall.Text = "38"; break;
                case 4: lbltall.Text = "39"; break;
                case 5: lbltall.Text = "40"; break;
                case 6: lbltall.Text = "41"; break;
                case 7: lbltall.Text = "42"; break;
                case 8: lbltall.Text = "43"; break;
                case 9: lbltall.Text = "44"; break;
                case 10: lbltall.Text = "45"; break;

            }
            desctall = cboTalle.SelectedIndex;

            switch (desctall)
            {
                case 0: lbltaldesc.Text = "00"; break;
                case 1: lbltaldesc.Text = "Talle 36"; break;
                case 2: lbltaldesc.Text = "Talle 37"; break;
                case 3: lbltaldesc.Text = "Talle 38"; break;
                case 4: lbltaldesc.Text = "Talle 39"; break;
                case 5: lbltaldesc.Text = "Talle 40"; break;
                case 6: lbltaldesc.Text = "Talle 41"; break;
                case 7: lbltaldesc.Text = "Talle 42"; break;
                case 8: lbltaldesc.Text = "Talle 43"; break;
                case 9: lbltaldesc.Text = "Talle 44"; break;
                case 10: lbltaldesc.Text = "Talle 45"; break;

            }
        }




        private void ibtngrabar_Click(object sender, EventArgs e)
        {


            lblid.Text = "" + lblmod.Text + "" + lblcol.Text + "" + lbltall.Text;
            lbldesc.Text = "" + lblmoddesc.Text + "" + lblcoldesc.Text + "" + lbltaldesc.Text;
            txtnombre.Text = lbldesc.Text;

            DialogResult resp = MessageBox.Show("Confirma la Grabación", "Grabar", MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question);
            var pr = new Productos();

            if ((resp == DialogResult.Yes))
            {
                pr.ID = lblid.Text;
                pr.Modelo = cboModelo.Text;
                pr.Color = cboColor.Text;
                pr.Talle = cboTalle.Text;
                pr.Descripcion = lbldesc.Text;
            }



            else
            {
                MessageBox.Show(" Completar correctamente todos los campos ");
            }


            var prMetodo = new ProductosMetodos();
            prMetodo.GrabarProductos(pr);




            Limpiar();

        }

        private void ibtncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvproductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //  this.dgvproductos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //  this.dgvproductos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //  this.dgvproductos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //  this.dgvproductos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //  this.dgvproductos.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvproductos.Columns[0].Width = 200;
            dgvproductos.Columns[1].Width = 200;
        }
    }
}





