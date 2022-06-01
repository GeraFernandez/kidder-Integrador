using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BaseDeDatosKidder
{
    class ClientesMetodos : Conexion
    {
        #region Consultas

        public DataTable Consultar()
        {

            string sqlStr = "Select * from Clientes";

            var da = new SqlDataAdapter(sqlStr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            return dt;
        }
             public DataRow CargaCampos(string ID)
        {
            DataTable dt = new DataTable();
            var ds = new DataSet();
            DataRow dr;

            string sqlStr = "select * from Clientes where ID = '" + ID + "'";

            var da = new SqlDataAdapter(sqlStr, conectar());
            ds = new DataSet();
            da.Fill(ds);

            dr = ds.Tables[0].Rows[0];

            return dr;
            #endregion
        }




        #region Datos
        public void GrabarClientes(clientes cl)
        {
            try
            {

                var sel = "set dateformat dmy INSERT INTO Clientes(ID, CUIT, Nombre, Apellido, IVA, Telefono, Email, Calle, Numero, Departamento, Provincia, Ciudad, Postal) VALUES ('"
                      + cl.ID + "','" + cl.CUIT + "','" + cl.Nombre + "','" + cl.Apellido + "','" + cl.Iva + "','" + cl.Telefono + "','" + cl.Email + 
                      "','" + cl.Calle + "','" + cl.Numero + "','" + cl.Departamento + "','" + cl.Provincia + "','" + cl.Ciudad + "','" + cl.Postal + "')";
                SqlCommand com = new SqlCommand(sel, conectar());


                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);

            }

        }
        public void ModificarClientes(clientes cl)
        {
            try
            {

                var sel = "set dateformat dmy UPDATE Clientes set ID = '" + cl.ID + "', CUIT = '" +
                     cl.CUIT + "', Nombre = '" + cl.Nombre + "', Apellido = '" +  cl.Apellido + "', IVA = '" + cl.Iva
                     + "', Telefono = " + cl.Telefono + ", Email= " + cl.Email + "', Calle = '" +
                     cl.Calle + "', Numero = '" +  cl.Numero + "', Departamento = '" +  cl.Departamento + 
                     "', Provincia = '" + cl.Provincia
                     + "', Ciudad = " + cl.Ciudad + ", Postal= " + cl.Postal
                     + " WHERE ID = '" + cl.ID + "'";

                SqlCommand com = new SqlCommand(sel, conectar());

                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);

            }

        }
        public Boolean BorrarClientes(string ID)
        {
            try
            {
             
                var sel = "delete from Clientes where ID = '" + ID + "'";

                SqlCommand com = new SqlCommand(sel, conectar());

                var i = com.ExecuteNonQuery();
                if (i == 0) return false;

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }

        }
        #endregion
    }
}









