using System;
using System.Collections.Generic;

namespace Descargas_NET.Models
{
    public partial class Ubicacionalmp2
    {
        public string UbicacionAlmp2Id { get; set; }
        public string UbicacionAlmp2Tipo { get; set; }
        public string UbicacionAlmp2Descripcion { get; set; }
        public bool? UbicacionAlmp2Disponible { get; set; }
        public bool? UbicacionAlmp2Bloqueado { get; set; }
        public int? UbicacionAlmp2ReferenciaSap { get; set; }
        public int UbicacionAlmp2ContenedorId { get; set; }
        public DateTime? UbicacionAlmp2Fecha { get; set; }
        public string UbicacionAlmp2Bloque { get; set; }
        public string UbicacionAlmp2Posicion { get; set; }
        public string UbicacionAlmp2Altura { get; set; }
        public string UbicacionAlmp2Almacen { get; set; }
        public bool? UbicacionAlmp2Imprimir { get; set; }
    }
}
