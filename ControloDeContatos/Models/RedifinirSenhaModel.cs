using System.ComponentModel.DataAnnotations;

namespace ControloDeContatos.Models
{
    public class RedifinirSenhaModel
    {
        [Required(ErrorMessage = "Escreva o login")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Escreva o seu email")]
        public string Email { get; set; }
    }
}
