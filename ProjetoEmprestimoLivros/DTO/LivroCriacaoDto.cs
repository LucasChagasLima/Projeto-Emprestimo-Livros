using System.ComponentModel.DataAnnotations;

namespace ProjetoEmprestimoLivros.DTO
{
    public class LivroCriacaoDto
    {
        [Required(ErrorMessage = "Insira um título")]
        public string Titulo { get; set; } = string.Empty;
        [Required(ErrorMessage = "Insira um descrição")]
        public string Descricao { get; set; } = string.Empty;
        [Required(ErrorMessage = "Insira um capa")]
        public string Capa { get; set; } = string.Empty;
        [Required(ErrorMessage = "Insira um ISPB")]
        public string ISPB { get; set; } = string.Empty;
        [Required(ErrorMessage = "Insira um autor")]
        public string Autor { get; set; } = string.Empty;
        [Required(ErrorMessage = "Insira um genero")]
        public string Genero { get; set; } = string.Empty;
        [Required(ErrorMessage = "Insira o ano de publicação")]
        public int AnoPublicacao { get; set; }
        [Required(ErrorMessage = "Insira uma quantidade em estoque")]    
        public int QuantidadeEmEstoque { get; set; }

    }
}
