using ProjetoEmprestimoLivros.Models;

namespace ProjetoEmprestimoLivros.Services.LivroService
{
    public interface ILivroInterface
    {
        Task<List<LivrosModel>> BuscarLivros();
    }
}
