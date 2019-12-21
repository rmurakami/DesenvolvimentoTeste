﻿using System;
using System.Collections.Generic;
using System.Text;

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
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Cep { get; set; }
        public string NomePai { get; set; }
        public string NomeMae { get; set; }
        
    }
}
