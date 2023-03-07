using System;
using System.Collections.Generic;

namespace Descargas_NET.Models
{
    public partial class Logreposicionesanuladas
    {
        public int LogReposicionesAnuladasId { get; set; }
        public int LogReposicionesAnuladasIdReposicion { get; set; }
        public int LogReposicionesAnuladasSap { get; set; }
        public string LogReposicionesAnuladasMotivo { get; set; }
        public string LogReposicionesAnuladasCliente { get; set; }
        public DateTime LogReposicionesAnuladasFecha { get; set; }
    }
}
