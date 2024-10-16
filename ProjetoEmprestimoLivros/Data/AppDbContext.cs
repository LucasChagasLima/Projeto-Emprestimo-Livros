using Microsoft.EntityFrameworkCore;
using ProjetoEmprestimoLivros.Models;

namespace ProjetoEmprestimoLivros.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
            

        }

        public DbSet<LivrosModel> Livros { get; set; }
 
    }
}
