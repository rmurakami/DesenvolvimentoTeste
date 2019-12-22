using Domain.Interfaces.Repositories;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace Persistence.Repositories
{
    public class AlunoRepository : Repository<Aluno>, IAlunoRepository
    {
        public AlunoRepository(IConfiguration config) : base(config) { }

        public Aluno Carregar(string cpf)
        {
            var obj = Context.Alunos
                .Include(m => m.AlunoTelefones)
                .Include(m => m.Estado)
                .Include(m => m.Escola).Where(m => m.Cpf == cpf).FirstOrDefault();
            return obj;
        }

        public List<Aluno> Listar(string escolaId)
        {
            var lista = Context.Alunos
                .Include(m => m.AlunoTelefones)
                .Include(m => m.Estado)
                .Include(m => m.Escola).Where(m => m.Escola.EscolaId.ToString() == escolaId);
            return lista.ToList();
        }


        public void Adicionar(Aluno obj)
        {
            obj.Estado = Context.Estados.Where(m => m.Uf == obj.Estado.Uf).FirstOrDefault();
            obj.Escola = Context.Escolas.Where(m => m.EscolaId == obj.Escola.EscolaId).FirstOrDefault();
            Context.Set<Aluno>().Add(obj);
        }
    }
}
