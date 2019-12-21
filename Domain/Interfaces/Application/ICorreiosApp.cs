using Domain.Args;
using prmToolkit.NotificationPattern;

namespace Domain.Interfaces.Application
{
    public interface ICorreiosApp: INotifiable
    {
        CorreioResponse RetornaEndereco(string cep);
    }
}
