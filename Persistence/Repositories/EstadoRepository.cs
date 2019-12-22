using Domain.Interfaces.Repositories;
using Domain.Models;
using Microsoft.Extensions.Configuration;
using prmToolkit.NotificationPattern;

namespace Persistence.Repositories
{
    public class EstadoRepository : Repository<Estado>, IEstadoRepository
    {
        public EstadoRepository(IConfiguration config) : base(config) { }
    }
}
