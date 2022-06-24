using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_entidad
{
    public class E_DetallesVentas
    {
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public decimal Gravadas { get; set; }
        public decimal Totales { get; set; }
        public int IdVentas { get; set; }

    }
}
