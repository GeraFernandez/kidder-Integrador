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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-1P6UFP3F\\SQLEXPRESS01;Initial Catalog=KIDDER; Integrated Security = True");


        public void Logear(string usuario, string contrasena)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Nombre, Tipo_Usuario FROM Usuarios  WHERE Usuario = @usuario AND Password =@pas", con);
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("pas", contrasena);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    if (dt.Rows[0][1].ToString() == "Admin")
                    {
                        frmMenu ofrmMenu = new frmMenu();
                        ofrmMenu.Show();

                    }
                    else if (dt.Rows[0][1].ToString() == "Usuario")
                    {
                        frmMenu ofrmMenu = new frmMenu();
                        ofrmMenu.Show();
                    }


                }
                else
                {
                    MessageBox.Show("Usuario y/o contrasena incorrecta");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally

            {
                con.Close();
            }

        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASENA")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.LightGray;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "CONTRASENA";
                txtPass.ForeColor = Color.DimGray;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Logear(this.txtUsuario.Text, this.txtPass.Text);
        }
    }
}
