using Domain.Interfaces.Repositories;
using Domain.Models;
using Microsoft.Extensions.Configuration;

namespace Persistence.Repositories
{
    public class AlunoRepository : Repository<Aluno>, IAlunoRepository
    {
        public AlunoRepository(IConfiguration config):base(config){}
    }
}
