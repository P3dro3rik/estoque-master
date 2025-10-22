using System.ComponentModel.DataAnnotations;

namespace EstoqueMaster.Models
{
    public class Movimentacao
    {
        public int Id { get; set; }
        
        [Required]
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; } = null!;
        
        public TipoMovimentacao Tipo { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal? Desconto { get; set; }
        public DateTime DataMovimentacao { get; set; } = DateTime.UtcNow;
    }

    public enum TipoMovimentacao
    {
        Entrada,
        Saida
    }
}
