using System;
using System.Collections.Generic;

namespace Descargas_NET.Models
{
    public partial class MensajesIncidenciasOut
    {
        public int Id { get; set; }
        public string Sap { get; set; }
        public string Usuario { get; set; }
        public string Formulario { get; set; }
        public string Incidencia { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime? FechaAnalisis { get; set; }
        public string Resultado { get; set; }
    }
}
