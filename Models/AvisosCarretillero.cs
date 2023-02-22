using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descargas_NET.Models
{
    public class AvisosCarretillero
    {
        public int Id { get; set; }
        public int Sap { get; set; }
        public string Albaran { get; set; }
        public string Comentario { get; set; }
        public bool? Activo { get; set; }
        public DateTime? Fechaapertura { get; set; }
        public DateTime? Fechacierre { get; set; }
    }
}
