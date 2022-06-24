using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BaseDeDatosKidder
{
    class ProductosMetodos : Conexion
    {
        #region Consultas

        public DataTable Consultar()
        {

            string sqlStr = "SELECT * FROM Productos ";

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

            string sqlStr = "select * from Productos where ID = '" + ID + "'";

            var da = new SqlDataAdapter(sqlStr, conectar());
            ds = new DataSet();
            da.Fill(ds);

            dr = ds.Tables[0].Rows[0];

            return dr;
            #endregion
        }




        #region Datos
        public void GrabarProductos(Productos pr)
        {
            try
            {

                var sel = "set dateformat dmy INSERT INTO Productos(ID, Modelo, Color, Talle, Descripcion) VALUES ('"
                      + pr.ID + "','" + pr.Modelo + "','" + pr.Color + "','" + pr.Talle + "','" + pr.Descripcion + "')";
                SqlCommand com = new SqlCommand(sel, conectar());


                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);

            }

        }
        public void ModificarProductos(Productos pr)
        {

            try
            {

                var sel = "set dateformat dmy UPDATE Productos set ID = '" + pr.ID + "', Modelo = '" +
                     pr.Modelo + "', Color = '" + pr.Color + "', Talle = '" + pr.Talle + "', Descripcion = '" + pr.Descripcion + "'";

                SqlCommand com = new SqlCommand(sel, conectar());

                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);

            }

        }
        public Boolean BorrarProductos(string ID)
        {
            try
            {

                var sel = "delete from Productos where ID = '" + ID + "'";

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








