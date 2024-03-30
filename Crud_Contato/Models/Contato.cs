using System.ComponentModel.DataAnnotations;

namespace Crud_Contato.Models
{
    public class Contato
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "O campo Nome deve ter entre 3 e 100 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [StringLength(9, MinimumLength = 9, ErrorMessage = "O campo Telefone deve conter exatamente 9 dígitos.")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [EmailAddress(ErrorMessage = "O campo Email não está em um formato válido.")]
        public string Email { get; set; }
    }
}
