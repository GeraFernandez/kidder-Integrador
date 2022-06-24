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
    public class N_Ventas
    {
        readonly D_Ventas ObjVentas = new D_Ventas();   
        

        public static DataTable MostrarRegistros()
        {
            return new D_Ventas().MostrarRegistros();
        }


        public static DataTable BuscarRegistros(string fechainicial, string fechafinal)
        {
            return new D_Ventas().BuscarRegistros(fechainicial, fechafinal);
        }

        public static string InsertarVentas(E_Ventas ventas, DataTable DTDestallesVentas)
        {
            D_Ventas ObjVentas = new D_Ventas();
            List<E_DetallesVentas> detalles = new List<E_DetallesVentas>();
            foreach (DataRow row in DTDestallesVentas.Rows)
            {
                E_DetallesVentas detallesVentas = new E_DetallesVentas
                {
                    Cantidad = Convert.ToInt32(row["cantidad"].ToString()),
                    Descripcion = row["descripcion"].ToString(),
                    Precio = Convert.ToDecimal(row["precio"].ToString()),
                    Gravadas = Convert.ToDecimal(row["gravadas"].ToString()),
                    Totales = Convert.ToDecimal(row["totales"].ToString()),
                };
                detalles.Add(detallesVentas);
            }
            return ObjVentas.InsertarVentas(ventas, detalles);
        }

        public void AnularComprobante (E_Ventas idventas)
        {
            ObjVentas.AnularComprobante(idventas);
        }



    }
}
