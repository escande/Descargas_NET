using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descargas_NET.Services
{
    public interface IMemoData
    {
        string NombreFichero { get; set; }
        void EliminarFichero();
        void EscribirEnFichero(string msg);
        string LeerEnFichero();
    }
}
