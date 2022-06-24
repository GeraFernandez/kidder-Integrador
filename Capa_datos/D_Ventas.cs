using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Capa_entidad;


namespace Capa_datos
{
    public class D_Ventas
    {
        readonly D_DetallesVentas d_DetallesVentas = new D_DetallesVentas();
        SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["BaseDeDatosKidder.Properties.Settings.Valor"].ConnectionString);

        public DataTable MostrarRegistros()
        {
            DataTable DtResultado = new DataTable();
            SqlCommand command = new SqlCommand("spmostrar_ventas", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };
            SqlDataAdapter dataAdapter= new SqlDataAdapter(command);
            dataAdapter.Fill(DtResultado);
            dataAdapter.Dispose();
            return DtResultado;
        }
        public DataTable BuscarRegistros(string fechainicial, string fechafinal)
        {
            DataTable DtResultado = new DataTable();
            SqlCommand command = new SqlCommand("spbuscar_ventas", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            command.Parameters.AddWithValue("@fechainicial", fechainicial);
            command.Parameters.AddWithValue("@fechafinal", fechafinal);


            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(DtResultado);
            dataAdapter.Dispose();
            return DtResultado;
        }

        public string InsertarVentas(E_Ventas ventas, List<E_DetallesVentas> detallesVentas)
        {
            string respuesta;
            try
            {
                conectar.Open();
                SqlTransaction transaction = conectar.BeginTransaction();
                SqlCommand command = new SqlCommand()
                {
                    Connection = conectar,
                    Transaction = transaction,
                    CommandText = "spinsertar_ventas",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter ParIdVentas = new SqlParameter
                {
                    ParameterName = "@idventas",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(ParIdVentas);
                command.Parameters.AddWithValue("@numeroventas", ventas.NumeroVentas);
                command.Parameters.AddWithValue("@fecha", ventas.Fecha);
                command.Parameters.AddWithValue("@estado", ventas.Estado);
                command.Parameters.AddWithValue("@idclientes", ventas.IdClientes);


                respuesta = command.ExecuteNonQuery() == 1 ? "OK" : "No se pudo insertar el registro";

                if (respuesta.Equals("OK"))
                {
                    ventas.IdVentas = Convert.ToInt32(command.Parameters["@idventas"].Value);
                    foreach (E_DetallesVentas det in detallesVentas)
                    {
                        det.IdVentas = ventas.IdVentas;
                        respuesta = d_DetallesVentas.InsertarDetallesVentas(det, ref conectar, ref transaction);

                        if (!respuesta.Equals("OK"))
                        {
                            break;
                        }
                    }
                }


                if (respuesta.Equals("OK"))
                {
                    transaction.Commit();
                }else
                {
                    transaction.Rollback();
                }
            }
            catch (Exception ex)
            {
               respuesta=ex.Message;
            }
            finally
            {
                if(conectar.State==ConnectionState.Open)
                {
                    conectar.Close();   
                }
            }
            return respuesta;
        }

        public void AnularComprobante(E_Ventas idventas)
        {
            SqlCommand command = new SqlCommand("spanular_ventas", conectar)
            {
                CommandType = CommandType.StoredProcedure
        };
        conectar.Open();
            command.Parameters.AddWithValue("@idventas", idventas.IdVentas);
            command.ExecuteNonQuery();
            conectar.Close();

        }

    }
}
