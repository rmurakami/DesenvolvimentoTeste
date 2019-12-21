using Domain.Args;
using prmToolkit.NotificationPattern;

namespace Domain.Interfaces.Services
{
    public interface IFilmeSvc : INotifiable
    {
        FilmeResponse RetornaFilme(string titulo);
    }
}
