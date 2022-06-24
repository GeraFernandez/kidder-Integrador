using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Capa_entidad;
using Capa_datos;


namespace Capa_negocios
{
    public class N_DetallesVentas
    {

        //readonly D_DetallesVentas ObjDetalleventas = new D_DetallesVentas();

        //public static string InsertarDetallesVentas(E_DetallesVentas detallesVentas, ref SqlConnection connection, ref SqlTransaction transaction)
        //{
        //    D_DetallesVentas ObjDetalleventas = new D_DetallesVentas();
        //    List<E_DetallesVentas> detalles = new List<E_DetallesVentas>();
        //    foreach (DataRow row in detallesVentas.Rows)
        //    {
        //        E_DetallesVentas detallesVentas = new E_DetallesVentas
        //        {
        //            Cantidad = Convert.ToInt32(row["cantidad"].ToString()),
        //            Descripcion = row["Descripcion"].ToString(),
        //            Precio = Convert.ToDouble(row["Precio"].ToString()),
        //            Gravadas = Convert.ToDouble(row["Gravadas"].ToString()),
        //            Totales = Convert.ToDouble(row["Totales"].ToString()),
        //        };
        //        detalles.Add(detallesVentas);
        //    }
        //    return ObjDetalleventas.InsertarVentas(ventas, detalles);
        //}

    }
}
