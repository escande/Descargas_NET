using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descargas_NET.Models
{
    public class PanelAlertas
    {
        public int PanelAlertasId { get; set; }
        public int PanelAlertasSap { get; set; }
        public string PanelAlertasReferencia { get; set; }
        public bool? PanelAlertasTipo { get; set; }
        public string PanelAlertasCliente { get; set; }
        public DateTime PanelAlertasFechaEntrada { get; set; }
        public DateTime? PanelAlertasFechaFin { get; set; }
        public string PanelAlertasObservaciones { get; set; }
    }
}
