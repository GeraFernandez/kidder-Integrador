using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;



namespace Capa_entidad
{
    public class clase_entidad
    {
        public string ID { get; set; }
        public string CUIT { get; set; }
        public string Nombre { get; set; }
        public String Apellido { get; set; }
        public String Iva { get; set; }
        public String Telefono { get; set; }
        public String Email { get; set; }
        public String Calle { get; set; }
        public String Numero { get; set; }
        public String Departamento { get; set; }

        public String Provincia { get; set; }
        public String Ciudad { get; set; }
        public String Postal { get; set; }
        public String accion { get; set; }
    }
}
