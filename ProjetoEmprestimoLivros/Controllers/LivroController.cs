using Microsoft.AspNetCore.Mvc;

namespace ProjetoEmprestimoLivros.Controllers
{
    public class LivroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
