using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descargas_NET.Services.Hub
{
    public interface IHubClient
    {
        EstadoConexion Conexion { get; set; }
        List<string> Usuarios { get; set; }

        Task Conectar(string user, string token, string puesto);
        Task Desconectar();

        event EventHandler<bool> Hub_ConexionChange;

        event EventHandler<string> Hub_DataReceive;
    }
}
