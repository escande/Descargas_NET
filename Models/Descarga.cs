using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Descargas_NET.Models
{
    public class Descarga
    {
        public int DescargaId { get; set; }
        public DateTime? DescargaFecha { get; set; }
        public string DescargaTurno { get; set; }
        public string DescargaRuta { get; set; }
        public string DescargaNumeroAlbaran { get; set; }
        public string DescargaAgencia { get; set; }
        public string DescargaTransportista { get; set; }
        public string DescargaMuelle { get; set; }
        public string DescargaMatricula { get; set; }
        public string DescargaObservaciones { get; set; }
        public DateTime? DescargaFechaInicio { get; set; }
        public DateTime? DescargaFechaFin { get; set; }
        public DateTime? DescargaFechaUbicacion { get; set; }
        public int? DescargaTipoTarea { get; set; }
        public DateTime? DescargaTwEntrada { get; set; }
        public int? DescargaTwsn { get; set; }
        public DateTime? DescargaSalida { get; set; }
        public DateTime? DescargaTwSalida { get; set; }
        public int? DescargaOrigen { get; set; }
        public string DescargaTipoVehiculo { get; set; }
        public string DescargaNave { get; set; }
        public DateTime? DescargaEnviadoStm { get; set; }
        public int? DescargaGrabar { get; set; }
        public string DescargaUsuario { get; set; }
        public DateTime? DescargaCierreManual { get; set; }
        public int? DescargaBultosManual { get; set; }
        public int? DescargaTime { get; set; }
        public int? DescargaSlot { get; set; }
        public int? DescargaAlerta { get; set; }
    }
}
