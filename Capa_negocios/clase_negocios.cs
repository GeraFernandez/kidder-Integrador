using System.Data;
using System.Data.SqlClient;
using  Capa_entidad;
using Capa_datos;
using System;
using System.IO;
using System.Drawing;
using System.Configuration;

namespace Capa_negocios
{

   

    public class clase_negocios
    {
        clase_datos objeto = new clase_datos();

        public DataTable N_listar_clientes()
        {
            return objeto.D_listar_clientes();
        }
        public DataTable N_consultar_clientes(clase_entidad obje)
        {
            return objeto.D_consultar_clientes(obje);
        }

        public String N_mantenimiento_clientes(clase_entidad obje)
        {
            return objeto.D_mantenimiento_clientes(obje);
        }

        public static DataTable BuscarRegistros(string textobuscar)
        {
            return new clase_datos().BuscarRegistros(textobuscar);


        }
    }
}
