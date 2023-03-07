using System;
using System.Collections.Generic;

namespace Descargas_NET.Models
{
    public partial class TblEtiquetas
    {
        public int Id { get; set; }
        public string IdLote { get; set; }
        public int IdProductoFinal { get; set; }
        public int IdContenedor { get; set; }
        public DateTime FechaHora { get; set; }
        public bool? Imprimir { get; set; }
        public bool? Liberado { get; set; }
        public bool? BloqueadoCalidad { get; set; }
        public int? AlbaranSalida { get; set; }
        public int? NserieSalida { get; set; }
        public DateTime? FechaSalida { get; set; }
        public string PlantaDestino { get; set; }
        public string Observaciones { get; set; }
        public int? Ordenimprimir { get; set; }
        public int? UserLibera { get; set; }
        public int? UserBloquea { get; set; }
        public int? UserDesBloquea { get; set; }
        public DateTime? FechaLibera { get; set; }
        public DateTime? FechaBloquea { get; set; }
        public DateTime? FechaDesbloquea { get; set; }
        public int? UserCrea { get; set; }
        public DateTime? FechaHoraFabricado { get; set; }
    }
}
