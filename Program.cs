using Descargas_NET.Forms;
using Descargas_NET.Helpers;
using Descargas_NET.Services;
using Descargas_NET.Services.Hub;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Descargas_NET
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Generamos la coleccion de servicios
            IServiceCollection serviceCollection = new ServiceCollection();
            //Registramos el DbContext
            //serviceCollection.AddDbContext<PostDbContext>(options =>
            //    options.UseMySql("Server=localhost;Database=postefcore;Uid=root;Pwd=root;"));
            //Registramos el EmailSender
            serviceCollection.AddSingleton<IRepositorio, Repositorio>();
            serviceCollection.AddTransient<IWaitFunction, WaitFunction>();
            serviceCollection.AddTransient<IMemoData, MemoData>();
            serviceCollection.AddSingleton<IHubClient,HubClient>();

            //Construimos el contendor IoC
            //var services = serviceCollection.BuildServiceProvider();
            Injector.GenerarProveedor(serviceCollection);

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_Principal(Injector.GetService<IRepositorio>()));
        }
    }
}
