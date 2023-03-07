using System;
using System.Collections.Generic;

namespace Descargas_NET.Models
{
    public partial class Peticionesalmp
    {
        public int PeticionesAlmpId { get; set; }
        public int PeticionesAlmpReferenciaSap { get; set; }
        public DateTime PeticionesAlmpFechaPeticion { get; set; }
        public DateTime? PeticionesAlmpFechaInicio { get; set; }
        public DateTime? PeticionesAlmpFechaFin { get; set; }
        public int? PeticionesAlmpContenedorEnviado { get; set; }
        public string PeticionesAlmpCliente { get; set; }
        public bool? PeticionesAlmpManual { get; set; }
        public bool? PeticionesAlmpGeneroAlerta { get; set; }
        public string PeticionesAlmpClienteCierra { get; set; }
        public int? PeticionesAlmpIdReposicion { get; set; }
    }
}
