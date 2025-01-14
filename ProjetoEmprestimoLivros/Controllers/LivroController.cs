using Microsoft.AspNetCore.Mvc;
using ProjetoEmprestimoLivros.Models;
using ProjetoEmprestimoLivros.Services.LivroService;

namespace ProjetoEmprestimoLivros.Controllers
{
    public class LivroController : Controller
    {
        private readonly ILivroInterface _livroInterface;
        public LivroController(ILivroInterface livroInterface)
        {
            _livroInterface = livroInterface;
        }
        public async Task<ActionResult<List<LivrosModel>>> Index()
        {
            var livros = await _livroInterface.BuscarLivros();

            return View(livros);
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

    }
}
