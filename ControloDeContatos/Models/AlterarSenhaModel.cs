using System.ComponentModel.DataAnnotations;

namespace ControloDeContatos.Models
{
    public class AlterarSenhaModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Escreva a password atual")]
        public string SenhaAtual { get; set; }

        [Required(ErrorMessage = "Escreva a nova password")]
        public string NovaSenha { get; set; }

        [Required(ErrorMessage = "Confirme a nova password")]
        [Compare("NovaSenha", ErrorMessage = "As passwords não são iguais")]
        public string ConfirmarNovaSenha { get; set; }

    }
}
