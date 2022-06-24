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
using System.Configuration;
using Capa_entidad;
using Capa_datos;
using Capa_negocios;
using System.Drawing.Printing;




namespace BaseDeDatosKidder
{
    public partial class frmnotapedido : Form
    {
        static string conexionstring = "Data Source=LAPTOP-1P6UFP3F\\SQLEXPRESS01;Initial Catalog = KIDDER; Integrated Security = True";
        SqlConnection conexion = new SqlConnection(conexionstring);


        public frmnotapedido()
        {
            InitializeComponent();
        }



       
        private void ibtnbuscarcl_Click(object sender, EventArgs e)
        {
            frmCargaClientes ofrmCargaClientes = new frmCargaClientes();
            ofrmCargaClientes.Show();
        }

        private void ibtnagrcl_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM CLIENTES WHERE CUIT = @CUIT", conexion);
            cmd.Parameters.AddWithValue("@CUIT", txtcuitbusq.Text);
            conexion.Open();
            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.Read())
            {
                txtcuit.Text = registro["CUIT"].ToString();
                txtnom.Text = registro["Nombre"].ToString();

                txtape.Text = registro["Apellido"].ToString();
                txtape.Text = registro["Telefono"].ToString();
            }
            conexion.Close();
        }

        private void ibtnbuspr_Click_1(object sender, EventArgs e)
        {
            frmProductos ofrmProductos = new frmProductos();
            ofrmProductos.Show();
        }

        private void ibtnagrpr_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Productos WHERE ID = @ID", conexion);
            cmd.Parameters.AddWithValue("@ID", txtidprod.Text);
            conexion.Open();
            SqlDataReader registro = cmd.ExecuteReader();


            {
                if (registro.Read())
                {
                    txtidpr.Text = registro["ID"].ToString();
                    txtdescrpr.Text = registro["Descripcion"].ToString();
                }
                txtcantfin.Text = txtcant.Text;
                conexion.Close();
            }




            // printDocument1 = new PrintDocument();
            // PrinterSettings ps = new PrinterSettings();
            //
            //  printDocument1.PrinterSettings = ps;
            //  printDocument1.PrintPage += imprimir;
            //  printDocument1.Print();


            //    PrintDocument doc = new PrintDocument();
            //    printDocument1.DefaultPageSettings.Landscape = true;
            //    printDocument1.PrinterSettings.PrinterName = "to PDF";
            //
            //    PrintPreviewDialog ppd = new PrintPreviewDialog { Document = printDocument1 };
            //    ((Form)ppd).WindowState = FormWindowState.Maximized;



            //}

            //  private void imprimir(object sender, PrintPageEventArgs e)
            //  {
            //  Font font = new Font("Arial", 14);
            //  int ancho = 300;
            //  int y = 20;
            //
            //  e.Graphics.DrawString("--- Nota de pedido ---", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            //  e.Graphics.DrawString("Cliente" + txtcuit.Text + txtnom.Text + txtape.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            //  e.Graphics.DrawString("--- Productos ---", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            //
            //  printDocument1.PrintPage += delegate (object ev, PrintPageEventArgs ep)
            //  {
            //      const int dgv_alto = 35;
            //      int left = ep.MarginBounds.Left; Top = ep.MarginBounds.Top;
            //
            //  foreach (DataGridViewColumn col in dgvnotadepedido.Columns)
            //  {
            //      ep.Graphics.DrawString(col.HeaderText, new Font("Segoe UI", 16, FontStyle.Bold), Brushes.DeepSkyBlue, left, Top);
            //      left += col.Width;
            //
            //  }
            //  left = ep.MarginBounds.Left;
            //  ep.Graphics.FillRectangle(Brushes.Black, left, Top + 40, ep.MarginBounds.Right - left, 3);
            //  Top += 43;
            //
            //      foreach (DataGridViewRow row in dgvnotadepedido.Rows)
            //      {
            //          if (row.Index == dgvnotadepedido.RowCount - 1) break;
            //          left = ep.MarginBounds.Left;
            //
            //          foreach (DataGridViewCell cell in row.Cells)
            //          {
            //              ep.Graphics.DrawString(Convert.ToString(cell.Value), new Font("Segoe UI", 13), Brushes.Black, left, Top + 4);
            //              left += cell.OwningColumn.Width;
            //          }
            //          Top += dgv_alto;
            //
            //      }
            //  };
            //  //.ShowDialog();
        }

        private void ibtnagrped_Click(object sender, EventArgs e)
        {
            DataGridViewRow file = new DataGridViewRow();
            file.CreateCells(dgvnotadepedido);

            file.Cells[0].Value = txtidpr.Text;
            file.Cells[1].Value = txtdescrpr.Text;
            file.Cells[2].Value = txtcant.Text;

            dgvnotadepedido.Rows.Add(file);


        }

        private void ibtncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fechahora_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblfecha.Text = DateTime.Now.ToLongDateString();
        }

        private void ibtnimprimir_Click(object sender, EventArgs e)
        {

            printDocument1.Print();
        }
        private void printDocument1_PrintPage(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            PaintEventArgs myPaintArgs = new PaintEventArgs(e.Graphics, new Rectangle(new Point(0, 0), this.Size));
            this.InvokePaint(dgvnotadepedido, myPaintArgs);
        }

    }
}

   








