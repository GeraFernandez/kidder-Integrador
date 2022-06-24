using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_entidad
{
    public class E_Ventas
    {
        public int IdVentas { get; set; }
        public string NumeroVentas { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
        public string IdClientes { get; set; }
      
    }
}
