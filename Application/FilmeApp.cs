using Domain.Args;
using Domain.Interfaces.Application;
using Domain.Interfaces.Services;

namespace Application
{
    public class FilmeApp : App<IFilmeSvc>, IFilmeApp
    {
        public FilmeResponse RetornaFilme(string titulo)
        {
            var obj = _svc.RetornaFilme(titulo);
            AddNotifications(_svc.Notifications);
            return obj;
        }
    }
}
