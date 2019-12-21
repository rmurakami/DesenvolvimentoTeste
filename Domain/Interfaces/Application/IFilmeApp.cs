using Domain.Args;
using prmToolkit.NotificationPattern;

namespace Domain.Interfaces.Application
{
    public interface IFilmeApp : INotifiable
    {
        FilmeResponse RetornaFilme(string titulo);
    }
}
