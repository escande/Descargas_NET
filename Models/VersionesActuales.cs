using System;
using System.Collections.Generic;

namespace Descargas_NET.Models
{
    public partial class VersionesActuales
    {
        public int Id { get; set; }
        public string Bdd { get; set; }
        public int Version { get; set; }
        public string Ubicacion { get; set; }
    }
}
