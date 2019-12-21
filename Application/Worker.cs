
using Domain.Interfaces;
using Domain.Interfaces.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using prmToolkit.NotificationPattern;
using Services;
using System.IO;

namespace Application
{
    public class Worker : Notifiable
    {
        protected IConfiguration _config;
        protected readonly ServiceProvider _serviceProvider;
        public Worker(IConfiguration config = null, IServiceCollection services = null)
        {

            //carrega arquivo de configuração   
            if (config != null)
            {
                _config = config;
            }
            else
            {
                _config = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
               .Build();
            }
            if (services == null)
            {
                //configura dependency injection
                _serviceProvider = new ServiceCollection()
                    .AddSingleton<ICorreiosSvc, CorreiosSvc>((ctx) =>
                    {
                        return new CorreiosSvc(_config);
                    })
                    .AddSingleton<IFilmeSvc, FilmeSvc>((ctx) =>
                    {
                        return new FilmeSvc(_config);
                    })
                   .BuildServiceProvider();
            }


        }

    }
}
