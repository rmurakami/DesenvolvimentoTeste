using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public class Aluno
    {
        public Guid AlunoId { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public DateTime DtNascimento { get; set; }
        public string Email { get; set; }
        public string Nacionalidade { get; set; }
        public string Endereco { get; set; }
        public string Complemento { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        public string NomePai { get; set; }
        public string NomeMae { get; set; }
        public virtual Escola Escola { get; set; }
        public virtual IList<AlunoTelefone> AlunoTelefones { get; set; }
        public virtual Estado Estado { get; set; }
    }
}
