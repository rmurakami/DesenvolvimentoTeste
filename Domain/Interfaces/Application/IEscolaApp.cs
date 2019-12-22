using Domain.Models;
using prmToolkit.NotificationPattern;
using System.Collections.Generic;

namespace Domain.Interfaces.Application
{
    public interface IEscolaApp : INotifiable
    {
        IList<Escola> Listar();
        Escola Carregar(string id);
    }
}
