using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class AlunoTelefone
    {
        public Guid TelefoneId { get; set; }
        public string Telefone { get; set; }
        public int Tipo { get; set; }
        public virtual Aluno Aluno{get;set;}
    }
}
