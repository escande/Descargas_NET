using System;
using System.Collections.Generic;
using System.Text;

namespace Descargas_NET.Models
{
    public class TrazabilidadMaterial
    {
        public int TrazabilidadMaterialesId { get; set; }
        public int TrazabilidadMaterialesDescargaId { get; set; }
        public string TrazabilidadMaterialesNAlbaran { get; set; }
        public string TrazabilidadMaterialesPPartNumber { get; set; }
        public int? TrazabilidadMaterialesQCantidad { get; set; }
        public string TrazabilidadMaterialesVProveedor { get; set; }
        public string TrazabilidadMateriales30sReferenciaP { get; set; }
        public string TrazabilidadMaterialesSSerial { get; set; }
        public string TrazabilidadMaterialesDFecha { get; set; }
        public string TrazabilidadMaterialesHLote { get; set; }
        public string TrazabilidadMaterialesBEmbalaje { get; set; }
        public int TrazabilidadMaterialesReferenciaSap { get; set; }
        public string TrazabilidadMaterialesProveedor { get; set; }
        public bool? TrazabilidadMaterialesFinalizado { get; set; }
        public string TrazabilidadMaterialesTipoContenedor { get; set; }
        public string TrazabilidadMaterialesCliente { get; set; }
        public int? AvisoCDMId { get; set; }
        public string AvisoCDMTexto { get; set; }
        public int? AvisoCarretilleroCDMId { get; set; }

        public virtual List<TrazabilidadMaterialDetalle> Detalles { get; set; }
    }
}
