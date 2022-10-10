using System.ComponentModel.DataAnnotations;

namespace ControloDeContatos.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Escreva o login")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Escreva a sua senha")]
        public string Senha { get; set; }
    }
}
