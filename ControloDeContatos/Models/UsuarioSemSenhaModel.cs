using ControloDeContatos.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace ControloDeContatos.Models
{
    public class UsuarioSemSenhaModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Escreva o nome do usuário")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Escreva o login do usuário")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Escreva o email do usuário")]
        [EmailAddress(ErrorMessage = "O email informado não é válido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Escreva o perfil do usuário")]
        public PerfilEnum? Perfil { get; set; }

    }
}
