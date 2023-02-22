using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Descargas_NET.Helpers
{
    public static class Injector
    {
        static IServiceProvider _proveedor;

        public static void GenerarProveedor(IServiceCollection serviceCollection)
        {
            _proveedor = serviceCollection.BuildServiceProvider();
        }

        public static T GetService<T>()
        {
            return _proveedor.GetService<T>();
        }
    }
}
