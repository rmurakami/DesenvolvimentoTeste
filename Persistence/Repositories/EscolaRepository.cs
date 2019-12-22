using Domain.Interfaces.Repositories;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace Persistence.Repositories
{
    public class EscolaRepository : Repository<Escola>, IEscolaRepository
    {
        public EscolaRepository(IConfiguration config) : base(config) { 
        }
        public IList<Escola> Listar()
        {
            var lista = Context.Escolas.Include(m => m.Estado).ToList();
            return lista;
        }
    }

}
