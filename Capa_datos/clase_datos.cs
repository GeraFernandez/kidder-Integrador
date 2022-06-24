using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Capa_entidad;
using System.IO;
using System.Drawing; 
using System;

namespace Capa_datos
{
     public class clase_datos 
    {
        public SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["BaseDeDatosKidder.Properties.Settings.Valor"].ConnectionString);
        //clase_datos Con = new clase_datos();
        //SqlCommand Cmd;
        //SqlDataReader Dr;
        //DataTable dt;
        public DataTable D_listar_clientes()
        {
            SqlCommand cmd = new SqlCommand("sp_listar_clientes", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

            public DataTable D_consultar_clientes(clase_entidad obje)
            {

                SqlCommand cmd = new SqlCommand("sp_consultar_clientes", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cuit", obje.CUIT);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
      

        public String D_mantenimiento_clientes(clase_entidad obje)
        {
            String accion = "";
            SqlCommand cmd = new SqlCommand("sp_mantenimiento_clientes", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", obje.ID);
            cmd.Parameters.AddWithValue("@cuit", obje.CUIT);
            cmd.Parameters.AddWithValue("@IVA", obje.Iva);
            cmd.Parameters.AddWithValue("@nombre", obje.Nombre);
            cmd.Parameters.AddWithValue("@apellido", obje.Apellido);
            cmd.Parameters.AddWithValue("@telefono", obje.Telefono);
            cmd.Parameters.AddWithValue("@email", obje.Email);
            cmd.Parameters.AddWithValue("@calle", obje.Calle);
            cmd.Parameters.AddWithValue("@numero", obje.Numero);
            cmd.Parameters.AddWithValue("@departamento", obje.Departamento);
            cmd.Parameters.AddWithValue("@provincia", obje.Provincia);
            cmd.Parameters.AddWithValue("@ciudad", obje.Ciudad);
            cmd.Parameters.AddWithValue("@cp", obje.Postal);
            cmd.Parameters.Add("@accion",SqlDbType.VarChar,50).Value = obje.accion;
            cmd.Parameters["@accion"].Direction = ParameterDirection.InputOutput;

            if (cn.State==ConnectionState.Open)cn.Close();
            cn.Open();

            cmd.ExecuteNonQuery();
            accion = cmd.Parameters["@accion"].Value.ToString();
            cn.Close();
            return accion;
        }


        public DataTable BuscarRegistros(string textobuscar)
        {
            DataTable DtResultado = new DataTable();
            SqlCommand SqlCmd = new SqlCommand("spbuscar_clientes", cn)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlCmd.Parameters.AddWithValue("@textobuscar", textobuscar);

            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);

            return DtResultado;
        }

       
    }
}
