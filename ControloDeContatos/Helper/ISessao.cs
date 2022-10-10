using ControloDeContatos.Models;

namespace ControloDeContatos.Helper
{
    public interface ISessao
    {
        void CriarSessaoDoUsuario(UsuarioModel usuario);
        void RemoveSessaoUsuario();
        UsuarioModel BuscarSessaoDoUsuario();
    }
}
