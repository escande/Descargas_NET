using Descargas_NET.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Descargas_NET.Services
{
    public class Repositorio : IRepositorio, IDisposable
    {
        private readonly HttpClient Client;
        //public string Token { get; set; }
        public Repositorio()
        {
            Client = new HttpClient();
        }

        public async Task<HttpResponseWrapper<T>> Get<T>(string url)
        {
            var httpResponse = await Client.GetAsync(url);

            if (httpResponse.IsSuccessStatusCode)
            {
                var response = await Deserializarrespuesta<T>(httpResponse);
                return new HttpResponseWrapper<T>(response, false, httpResponse);
            }
            else
            {
                return new HttpResponseWrapper<T>(default, true, httpResponse);
            }
        }

        public async Task<HttpResponseWrapper<Z>> Login<T, Z>(string url, T content)
        {
            var jsonContent = JsonConvert.SerializeObject(content);
            var httpContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            var httpResponse = await Client.PostAsync(url, httpContent);

            if (httpResponse.IsSuccessStatusCode)
            {
                var response = await Deserializarrespuesta<Z>(httpResponse);
                return new HttpResponseWrapper<Z>(response, false, httpResponse);
            }
            else
            {
                return new HttpResponseWrapper<Z>(default, true, httpResponse);
            }
        }

        public async Task<HttpResponseWrapper<object>> Post<T>(string url, T content)
        {
            var jsonContent = JsonConvert.SerializeObject(content);
            var httpContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            var httpResponse = await Client.PostAsync(url, httpContent);

            return new HttpResponseWrapper<object>(default, !httpResponse.IsSuccessStatusCode, httpResponse);
        }


        public async Task<HttpResponseWrapper<TResponse>> Post<T, TResponse>(string url, T data)
        {
                var dataJson = JsonConvert.SerializeObject(data);
                var httpContent = new StringContent(dataJson, Encoding.UTF8, "application/json");
                
                var response = await Client.PostAsync(url, httpContent);

                var dataResponse = JsonConvert.DeserializeObject<TResponse>(await response.Content.ReadAsStringAsync());
                return new HttpResponseWrapper<TResponse>(dataResponse, !response.IsSuccessStatusCode, response);
        }

        public async Task<HttpResponseWrapper<object>> Put<T>(string url, T content)
        {
            var jsonContent = JsonConvert.SerializeObject(content);
            var httpContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            var httpResponse = await Client.PutAsync(url, httpContent);

            return new HttpResponseWrapper<object>(default, !httpResponse.IsSuccessStatusCode, httpResponse);
        }

        public async Task<HttpResponseWrapper<object>> Delete(string url)
        {
            var httpResponse = await Client.DeleteAsync(url);

            return new HttpResponseWrapper<object>(default, !httpResponse.IsSuccessStatusCode, httpResponse);
        }

        private async Task<T> Deserializarrespuesta<T>(HttpResponseMessage httpResponse)
        {
            var responseJson = await httpResponse.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(responseJson);//, options);
        }

        public void AddBasicAuthenticationHeader(string token)
        {
            if (Client == null)
                return;

            if (string.IsNullOrWhiteSpace(token))
                return;

            Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }

        public void Dispose()
        {
            if(Client != null)
            {
                Client.Dispose();
            }
        }
    }
}
