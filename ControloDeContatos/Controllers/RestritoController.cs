using ControloDeContatos.Filters;
using Microsoft.AspNetCore.Mvc;

namespace ControloDeContatos.Controllers
{
    [PaginaParaUsuarioLogado]

    public class RestritoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
