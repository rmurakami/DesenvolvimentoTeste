using Crosscutting.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Args
{
    public class AlunoRequest
    {
        public string AlunoId { get; set; }
        [CPF]
        [Required(ErrorMessage = "Preencha o CPF.", AllowEmptyStrings = false)]
        public string Cpf { get; set; }
        [Required(ErrorMessage = "Preencha o Nome.", AllowEmptyStrings = false)]
        [StringLength(80, ErrorMessage = "O tamanho máximo é de 80 caracteres.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Selecione o sexo.", AllowEmptyStrings = false)]
        public string Sexo { get; set; }
        [Required(ErrorMessage = "Preencha a data de nascimento.", AllowEmptyStrings = false)]
        public DateTime DtNascimento { get; set; }
        [Required(ErrorMessage = "Preencha o campo e-mail.", AllowEmptyStrings = false)]
        [EmailAddress(ErrorMessage = "E-mail inválido.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Preencha a nacionalidade.", AllowEmptyStrings = false)]
        public string Nacionalidade { get; set; }
        [Required(ErrorMessage = "Preencha o endereço", AllowEmptyStrings = false)]
        public string Endereco { get; set; }
        public string Complemento { get; set; }
        public string Numero { get; set; }
        [Required(ErrorMessage = "Preencha o bairro.", AllowEmptyStrings = false)]
        public string Bairro { get; set; }
        [Required(ErrorMessage = "Preencha a cidade", AllowEmptyStrings = false)]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "Preencha o cep", AllowEmptyStrings = false)]
        public string Cep { get; set; }
        [Required(ErrorMessage = "Preencha o nome do pai", AllowEmptyStrings = false)]
        public string NomePai { get; set; }
        [Required(ErrorMessage = "Preencha o nome da mãe", AllowEmptyStrings = false)]
        public string NomeMae { get; set; }
        [Required(ErrorMessage = "Preencha a escola", AllowEmptyStrings = false)]
        public string EscolaId { get; set; }
        [Required(ErrorMessage = "Selecione o estado.", AllowEmptyStrings = false)]
        public string EstadoId { get; set; }


    }
}
