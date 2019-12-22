using Domain.Models;
using System.Collections.Generic;

namespace Domain.Interfaces.Repositories
{
    public interface IAlunoRepository : IRepository<Aluno>
    {
        Aluno Carregar(string cpf);
        List<Aluno> Listar(string escolaId);
        void Adicionar(Aluno obj);
    }
}
