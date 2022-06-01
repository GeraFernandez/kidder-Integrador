using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BaseDeDatosKidder
{
    internal class Conexion
    {
        private SqlConnection sCon = new SqlConnection();
        private string con = "Data Source=LAPTOP-1P6UFP3F\\SQLEXPRESS01;Initial Catalog = KIDDER A; Integrated Security = True";


        public SqlConnection conectar()
        {
            try
            {
                sCon = new SqlConnection(con);
                if (sCon.State.Equals(ConnectionState.Open))
                {
                    sCon.Close();
                }
                else
                {
                    sCon.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            return sCon;

        }
    }
}
