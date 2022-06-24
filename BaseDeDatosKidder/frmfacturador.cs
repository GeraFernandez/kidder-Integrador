using Capa_entidad;
using Capa_negocios;
using System;
using System.Data;
using System.Windows.Forms;


namespace BaseDeDatosKidder
{
    public partial class frmfacturador : Form
    {
        readonly E_Ventas ObjEntidad = new E_Ventas();
        readonly N_Ventas ObjNegocio = new N_Ventas();




        private DataTable DTDetalles;
        private double Gravadas;
        private double Totalapagar;
        public frmfacturador()
        {
            InitializeComponent();
        }

        private void MensajeConfirmacion(string mensaje)
        {
            MessageBox.Show(mensaje, "KIDDER SA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "KIDDER SA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        public void CrearTabla()
        {
            DTDetalles = new DataTable();
            DTDetalles.Columns.Add("cantidad", Type.GetType("System.Int32"));
            DTDetalles.Columns.Add("descripcion", Type.GetType("System.String"));
            DTDetalles.Columns.Add("precio", Type.GetType("System.Decimal"));
            DTDetalles.Columns.Add("gravadas", Type.GetType("System.Decimal"));
            DTDetalles.Columns.Add("totales", Type.GetType("System.Decimal"));

            dgvfacturacion.DataSource = DTDetalles;
        }

        public void LimpiarDatosCarga()
        {

            txtidprod.Text = "";

            txtdescripcion.Text = "";
            txtidpr.Text = "";
            txtcant.Text = "";

            txttotalapagar.Text = "0";
            txtgravadas.Text = "0";
            txtprecio.Text = "0";

        }

        public void frmfacturador_Load(object sender, EventArgs e)
        {
            CrearTabla();
        }

        public void ibtnbuscl_Click(object sender, EventArgs e)
        {
            ListadoClientes listadoclientes = new ListadoClientes();
            AddOwnedForm(listadoclientes);
            listadoclientes.ShowDialog();

        }

        public void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtcant.Text != "" | txtidpr.Text != "")
                {

                    bool agregar = true;
                    if (agregar)
                    {
                        DataRow row = DTDetalles.NewRow();
                        row["cantidad"] = Convert.ToInt32(txtcant.Text);
                        row["descripcion"] = txtdescripcion.Text;
                        row["precio"] = Convert.ToDecimal(txtprecio.Text);
                        row["gravadas"] = Convert.ToDecimal(txtgravadas.Text);
                        row["totales"] = Convert.ToDecimal(txttotalapagar.Text);


                        Gravadas += Convert.ToDouble(row["gravadas"].ToString());
                        txtgravadas.Text = Gravadas.ToString("#0,0#");

                        Totalapagar += Convert.ToDouble(row["totales"].ToString());
                        txttotalapagar.Text = Totalapagar.ToString("#0,0#");

                        DTDetalles.Rows.Add(row);
                        LimpiarDatosCarga();
                    }
                }

                else
                {
                    MensajeError("Cargue los datos bien");
                }
            }
            catch (FormatException ex)
            {
                MensajeError(ex.Message + ex.StackTrace);
            }
        }

        private void btnquitar_Click(object sender, EventArgs e)
        {
            try
            {
                int IndiceFila = dgvfacturacion.CurrentCell.RowIndex;
                DataRow row = DTDetalles.Rows[IndiceFila];

                Gravadas -= Convert.ToDouble(row["gravadas"].ToString());
                txtgravadas.Text = Gravadas.ToString("#0,00");

                Totalapagar -= Convert.ToDouble(row["totales"].ToString());
                txttotalapagar.Text = Totalapagar.ToString("#0,00");

                DTDetalles.Rows.Remove(row);
                MensajeConfirmacion("Se ha eliminado lo seleccionado");
            }
            catch (Exception)
            {
                MensajeError("No hay fila para remover");

            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcuit.Text != "" | txtnroventa.Text != "")
                {
                    if (MessageBox.Show("Estas seguro de realizar la operacion? ", "KIDDER SA", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ObjEntidad.NumeroVentas = txtnroventa.Text.Trim();
                        ObjEntidad.Fecha = dtpfecha.Value;
                        ObjEntidad.Estado = "ACTIVO";
                        ObjEntidad.IdClientes = txtIdCliente.Text;

                        N_Ventas.InsertarVentas(ObjEntidad, DTDetalles);
                        MensajeConfirmacion("Se guardo correctamente");

                    }

                }
                else
                {
                    MensajeError("Seleccione el cliente");
                }
            }
            catch (Exception ex)
            {
                MensajeError(ex.Message + ex.StackTrace);
            }
        }


        private void ibtnbuspr_Click(object sender, EventArgs e)
        {
            frmlistadoproductos listadoproductos = new frmlistadoproductos();
            AddOwnedForm(listadoproductos);
            listadoproductos.ShowDialog();
        }

        private void ibtncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtprecio_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double gravada = Convert.ToDouble(txtcant.Text) * Convert.ToDouble(txtprecio.Text) * 0.21;
                txtgravadas.Text = gravada.ToString();

                double total = Convert.ToDouble(txtcant.Text) * Convert.ToDouble(txtprecio.Text) + Convert.ToDouble(txtgravadas.Text);
                txttotalapagar.Text = total.ToString();

            }
            catch (Exception)
            {

            }

        }


    }
}




