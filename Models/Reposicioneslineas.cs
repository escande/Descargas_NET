using System;
using System.Collections.Generic;

namespace Descargas_NET.Models
{
    public partial class Reposicioneslineas
    {
        public int ReposicionesLineasId { get; set; }
        public int ReposicionesLineasPtoConsumo { get; set; }
        public string ReposicionesLineasUbicacionAlmpId { get; set; }
        public string ReposicionesLineasUbicacionAlmpTipo { get; set; }
        public string ReposicionesLineasUbicacionAlmpDescripcion { get; set; }
        public int ReposicionesLineasContenedorId { get; set; }
        public int ReposicionesLineasReferenciaSap { get; set; }
        public DateTime? ReposicionesLineasFechaPeticion { get; set; }
        public DateTime? ReposicionesLineasFechaInicio { get; set; }
        public DateTime? ReposicionesLineasFechaFin { get; set; }
        public bool? ReposicionesLineasManual { get; set; }
        public string ReposicionesLineasCliente { get; set; }
        public string ReposicionesLineasSector { get; set; }
        public string ReposicionesLineasIdKanban { get; set; }
        public string ReposicionesLineasObservaciones { get; set; }
        public string ReposicionesLineasClientePeticion { get; set; }

        public  ReposicionesMaterial ReposicionMaterial { get; set; }
    }
}
