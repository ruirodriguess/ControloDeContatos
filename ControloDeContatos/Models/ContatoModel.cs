using System.ComponentModel.DataAnnotations;

namespace ControloDeContatos.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Escreva o nome do contato")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Escreva o email do contato")]
        [EmailAddress(ErrorMessage = "O email informado não é válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Escreva o telemóvel do contato")]
        [Phone(ErrorMessage = "O número de telemóvel informado não é válido")]
        public string Celular { get; set; }
        public int? UsuarioId { get; set; }
        public UsuarioModel Usuario { get; set; }
    }
}
