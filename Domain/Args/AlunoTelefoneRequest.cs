using System.ComponentModel.DataAnnotations;

namespace Domain.Args
{
    public class AlunoTelefoneRequest
    {
        [Required]
        public string Telefone { get; set; }
        [Required]
        public int Tipo { get; set; }
    }
}
