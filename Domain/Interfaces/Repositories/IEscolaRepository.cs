using Domain.Models;
using System.Collections.Generic;

namespace Domain.Interfaces.Repositories
{
    public interface IEscolaRepository: IRepository<Escola>
    {
        IList<Escola> Listar();
    }
}
