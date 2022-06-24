using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BaseDeDatosKidder
{
    class LoginMetodos : Conexion

    {
        //    public DataTable ConsultarLogin(string usu, string pas)
        //    {
        //        string sqlStr = "select usuario, contrasenia from Usuarios where usuario = '" + usu + "' and contrasenia = '" +
        //                        pas + "'";

        //        //var c = AbrirConexion();


        //        //********************************************************
        //        var da = new SqlDataAdapter(sqlStr, conectar());
        //        var ds = new DataSet();
        //        da.Fill(ds);
        //        DataTable dt = ds.Tables[0];

        //        return dt;
        //        //*****************************************************
        //    }
        //    public int ultimoId()
        //    {
        //        var selMax = "select max(Id_Usuario) + 1 from Usuarios";
        //        //********************************************************
        //        SqlCommand com = new SqlCommand(selMax, conectar());
        //        return (int)com.ExecuteScalar();
        //    }

        //    public Boolean grabarUsuario(LoginEn usu)
        //    {
        //        try
        //        {
        //            var idMax = ultimoId();

        //            var sel = "set dateformat dmy INSERT INTO Usuarios(Id_Usuario,Usuario, contrasenia, permisos)" +
        //                " VALUES (" + idMax + ",'" + usu.usuario + "','" + usu.contrasenia + "'," + usu.permisos + ")";
        //            SqlCommand com = new SqlCommand(sel, conectar());

        //            com.ExecuteNonQuery();

        //            return true;
        //        }
        //        catch (Exception ex)
        //        {
        //            return false;
        //        }

        //    }


        //}
    }
}
