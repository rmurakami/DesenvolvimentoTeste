using Domain.Args;
using Domain.Models;
using prmToolkit.NotificationPattern;
using System.Collections.Generic;

namespace Domain.Interfaces.Application
{
    public interface IAlunoApp : INotifiable
    {
        Aluno Carregar(string cpf);
        List<Aluno> Listar(string escolaId);
        void Excluir(string alunoId);
        void Gravar(AlunoRequest obj);
    }
}
