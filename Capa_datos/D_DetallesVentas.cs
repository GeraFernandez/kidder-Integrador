using Capa_entidad;
using System;
using System.Data;
using System.Data.SqlClient;


namespace Capa_datos
{
    public class D_DetallesVentas
    {

        public string InsertarDetallesVentas(E_DetallesVentas detallesVentas, ref SqlConnection connection, ref SqlTransaction transaction)
        {
            string respuesta;
            try
            {
                SqlCommand command = new SqlCommand("spinsertar_detallesventas", connection)
                {
                    CommandType = CommandType.StoredProcedure,
                    Transaction = transaction
                };
                command.Parameters.AddWithValue("@cantidad", detallesVentas.Cantidad);
                command.Parameters.AddWithValue("@descripcion", detallesVentas.Descripcion);
                command.Parameters.AddWithValue("@precio", detallesVentas.Precio);
                command.Parameters.AddWithValue("@gravadas", detallesVentas.Gravadas);
                command.Parameters.AddWithValue("@totales", detallesVentas.Totales);
                command.Parameters.AddWithValue("@idventas", detallesVentas.IdVentas);

                respuesta = command.ExecuteNonQuery() == 1 ? "OK" : "No se pudo insertar el detalle de la venta";

            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            return respuesta;
        }
    }
}
