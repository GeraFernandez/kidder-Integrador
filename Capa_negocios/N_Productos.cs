using System.Data;
using System.Data.SqlClient;
using Capa_entidad;
using Capa_datos;
using System;
using System.IO;
using System.Drawing;
using System.Configuration;


namespace Capa_negocios
{
    public  class N_Productos
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["BaseDeDatosKidder.Properties.Settings.Valor"].ConnectionString);
        readonly D_Productos ObjProductos = new D_Productos();

        public static DataTable BuscarRegistros(string textobuscar)
        {
            return new D_Productos().BuscarRegistros(textobuscar);


        }


    }
}
