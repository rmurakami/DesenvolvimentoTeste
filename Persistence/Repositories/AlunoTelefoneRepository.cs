using Domain.Interfaces.Repositories;
using Domain.Models;
using Microsoft.Extensions.Configuration;

namespace Persistence.Repositories
{
    public class AlunoTelefoneRepository : Repository<AlunoTelefone>, IAlunoTelefoneRepository
    {
        public AlunoTelefoneRepository(IConfiguration config) : base(config) { }
    }
  
}
