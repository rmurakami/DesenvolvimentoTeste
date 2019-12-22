using Domain.Models;
using prmToolkit.NotificationPattern;
using System.Collections.Generic;

namespace Domain.Interfaces.Application
{
    public interface IEstadoApp : INotifiable
    {
        IList<Estado> Listar();
        Estado Carregar(string uf);
    }
}
