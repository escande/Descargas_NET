using System;
using System.Collections.Generic;
using System.Text;

namespace Descargas_NET.Models
{
    public class TrazabilidadMaterialDetalle
    {
        //public int TrazabilidadMaterialesDetallesId { get; set; }
        //public int TrazabilidadMaterialesDetallesTrazabilidadMaterialesId { get; set; }
        public int? TrazabilidadMaterialesDetallesCContenedorId { get; set; }
        public int TrazabilidadMaterialesDetallesQCantidad { get; set; }
        public int? TrazabilidadMaterialesDetallesCantidadConsumida { get; set; }
        public int? TrazabilidadMaterialesDetallesCantidadCalculada { get; set; }
        public string TrazabilidadMaterialesDetallesCliente { get; set; }
        public string TrazabilidadMaterialesDetallesOrigen { get; set; }
        public string TrazabilidadMaterialesDetallesDestino { get; set; }
        public string TrazabilidadMaterialesDetallesVininicio { get; set; }
        public string TrazabilidadMaterialesDetallesVinfinal { get; set; }
        public DateTime TrazabilidadMaterialesDetallesFechaEntrada { get; set; }
        public DateTime? TrazabilidadMaterialesDetallesFechaReposicion { get; set; }
        public DateTime? TrazabilidadMaterialesDetallesFechaInicioConsumo { get; set; }
        public DateTime? TrazabilidadMaterialesDetallesFechaFinConsumo { get; set; }
        public bool? TrazabilidadMaterialesDetallesFinalizado { get; set; }
        public TrazabilidadMaterial TrazabilidadMaterial { get; set; }
    }
}
