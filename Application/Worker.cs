using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence;
using Persistence.Repositories;
using prmToolkit.NotificationPattern;
using Services;
using System.IO;

namespace Application
{
    public class Worker : Notifiable
    {
        protected IConfiguration _config;
        private Contexto _contexto;
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
            _contexto = new Contexto(_config);

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
                    .AddSingleton<IAlunoRepository, AlunoRepository>((ctx) =>
                    {
                        return new AlunoRepository(_config);
                    })
                    .AddSingleton<IAlunoTelefoneRepository, AlunoTelefoneRepository>((ctx) =>
                     {
                         return new AlunoTelefoneRepository(_config);
                     })
                     .AddSingleton<IEstadoRepository, EstadoRepository>((ctx) =>
                     {
                         return new EstadoRepository(_config);
                     })
                      .AddSingleton<IEscolaRepository, EscolaRepository>((ctx) =>
                      {
                          return new EscolaRepository(_config);
                      })

                   .AddDbContext<Contexto>()
                   .BuildServiceProvider();
            }

            InicializaDb.Inicialize(_contexto);




        }

    }
}
