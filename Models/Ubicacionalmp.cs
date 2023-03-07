using System;
using System.Collections.Generic;

namespace Descargas_NET.Models
{
    public partial class Ubicacionalmp
    {
        public string UbicacionAlmpId { get; set; }
        public string UbicacionAlmpTipo { get; set; }
        public string UbicacionAlmpDescripcion { get; set; }
        public bool? UbicacionAlmpDisponible { get; set; }
        public bool? UbicacionAlmpBloqueado { get; set; }
        public int? UbicacionAlmpReferenciaSap { get; set; }
        public int UbicacionAlmpContenedorId { get; set; }
        public DateTime? UbicacionAlmpFecha { get; set; }
    }
}
