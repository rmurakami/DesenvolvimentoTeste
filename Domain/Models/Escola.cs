using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public class Escola
    {
        public Guid EscolaId { get; set; }
        public string NomeEscola { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        public virtual IList<Aluno> Alunos { get; set; }
        public virtual Estado Estado { get; set; }
    }
}
