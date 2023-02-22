using Descargas_NET.Models;
using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace Descargas_NET.Services.Hub
{
    public enum EstadoConexion
    {
        conectado, desconectado
    }
    public class HubClient : IHubClient, IDisposable
    {
        HubConnection connection;

        public EstadoConexion Conexion { get; set; }
        public List<string> Usuarios { get; set; }

        //Eventos
        public event EventHandler<bool> Hub_ConexionChange;
        public event EventHandler<string> Hub_DataReceive;

        string usuario = "";

        public HubClient()
        {
            //HubConnection = new HubConnectionBuilder()
            //.WithUrl($"https://10.0.2.2:5001/chatHub", (opts) =>
            //{
            //    opts.Headers.Add("Authorization", new AuthenticationHeaderValue(
            //            "Basic", Convert.ToBase64String(
            //                Encoding.Default.GetBytes(
            //                    "Username" + ":" + "Password"
            //                    ))).ToString());
            //})
            //.Build();

            Usuarios = new();
        }

        public async Task Conectar(string user, string token, string puesto)
        {
            try
            {
                usuario = user;

                connection = new HubConnectionBuilder()
                       .WithUrl($"{GlobalSettings.BASE_SERVER_URL}/{GlobalSettings.VirtualHost}serverchat?usuario={user}&token={token}&puesto={puesto}", (opt) =>
                       {
                           //opt.Headers.Add("Authorization", new AuthenticationHeaderValue(
                           //    "Bearer", token).ToString());

                       })
                       .WithAutomaticReconnect()
                       //.ConfigureLogging(signalR.LogLevel.Information)
                       .Build();

                await connection.StartAsync();

                Hub_ConexionChange?.Invoke(this,true);

                Conexion = EstadoConexion.conectado;

                GestionarConexion();

                //await connection.InvokeAsync("PutUser",
                //   user, "");


            }
            catch (Exception ex)
            {

            }
        }

        public async Task Desconectar()
        {
            try
            {
                if (connection == null)
                {
                    return;
                }
                await connection.StopAsync();
            }
            catch (Exception ex)
            {

            }
        }

        private void GestionarConexion()
        {
            connection.On<string, string>("ReceiveMessage", (user, message) =>
            {

                var newMessage = $"{user}: {message}";

                Hub_DataReceive?.Invoke(this, newMessage);
                //writeToLog(newMessage);
            });

            connection.On<string, string>("GetUsers", (user, message) =>
            {

                var newMessage = $"{user}: Usuarios actualizados";
                ActualizarUsuarios(message);
                //writeToLog(newMessage);
            });

            connection.Reconnecting += error =>
            {
                //Debug.Assert(connection.State == HubConnectionState.Reconnecting);

                // Notify users the connection was lost and the client is reconnecting.
                // Start queuing or dropping messages.
                if (error == null)
                {
                    if (connection.State == HubConnectionState.Connected)
                    {
                        Hub_ConexionChange?.Invoke(this, true);
                    }
                }

                return Task.CompletedTask;
            };

            connection.Closed += error =>
            {

                Conexion = EstadoConexion.desconectado;

                Hub_ConexionChange?.Invoke(this, false);

                return Task.CompletedTask;
            };
        }

        private void ActualizarUsuarios(String json)
        {
            try
            {
                List<UsuariosConectados> usuariosTemp = JsonConvert.DeserializeObject<List<UsuariosConectados>>(json);

                Usuarios = usuariosTemp.Select(x => x.User).Where(x => x != usuario).ToList();

            }
            catch (Exception ex)
            {
                //writeToLog($"Error actualizando usuario {ex.Message}");
            }
        }

        public void Dispose()
        {
            connection.DisposeAsync();
        }
    }
}
