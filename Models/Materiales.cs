using System;
using System.Collections.Generic;

namespace Descargas_NET.Models
{
    public partial class Materiales
    {
        public int MaterialesReferenciaSap { get; set; }
        public string MaterialesDescripcion { get; set; }
        public string MaterialesPartNumber { get; set; }
        public string MaterialesProveedor { get; set; }
        public bool? MaterialesNObligatorio { get; set; }
        public bool? MaterialesPObligatorio { get; set; }
        public bool? MaterialesQObligatorio { get; set; }
        public bool? MaterialesVObligatorio { get; set; }
        public bool? MaterialesSObligatorio { get; set; }
        public bool? Materiales30sObligatorio { get; set; }
        public bool? MaterialesDObligatorio { get; set; }
        public bool? MaterialesBObligatorio { get; set; }
        public bool? MaterialesHObligatorio { get; set; }
        public short? MaterialesApilabilidad { get; set; }
        public string MaterialesEmbalaje { get; set; }
        public short? MaterialesCantidadPorEmbalaje { get; set; }
        public short? MaterialesZona { get; set; }
        public int? MaterialesSapAsociado { get; set; }
        public bool? MaterialesActivo { get; set; }
        public bool? MaterialesObsoleto { get; set; }
        public short? MaterialesMinimoAlertas { get; set; }
        public string MaterialesTipoReposicion { get; set; }
        public bool? MaterialesImprimeAlerta { get; set; }
        public bool? MaterialesEscanearRl { get; set; }

        //public List<Ptoconsumo> Ptoconsumos { get; set; }

        //public List<Ubicacionalmp> Ubicacionalmp { get; set; }

        //public List<Ubicacionalmp2> Ubicacionalmp2 { get; set; }
    }
}
