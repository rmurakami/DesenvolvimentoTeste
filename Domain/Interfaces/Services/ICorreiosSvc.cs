using Domain.Args;
using prmToolkit.NotificationPattern;

namespace Domain.Interfaces.Services
{
    public interface ICorreiosSvc: INotifiable
    {
        CorreioResponse RetornaEndereco(string cep);
    }
}
