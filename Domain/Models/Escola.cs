using System;

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
        public string Uf { get; set; }
        public string Cep { get; set; }

    }
}
