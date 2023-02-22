using Descargas_NET.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Descargas_NET.Services
{
    public interface IRepositorio
    {
        Task<HttpResponseWrapper<T>> Get<T>(string url);

        Task<HttpResponseWrapper<object>> Post<T>(string url, T content);

        Task<HttpResponseWrapper<object>> Put<T>(string url, T content);

        Task<HttpResponseWrapper<object>> Delete(string url);

        Task<HttpResponseWrapper<Z>> Login<T, Z>(string url, T content);
        void AddBasicAuthenticationHeader(string token);
        Task<HttpResponseWrapper<TResponse>> Post<T, TResponse>(string url, T data);
    }
}
