using System.ComponentModel.DataAnnotations;

namespace EstoqueMaster.Models
{
    public class Produto
    {
        public int Id { get; set; }
        
        [Required]
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        
        [Required]
        public string Categoria { get; set; } = string.Empty;
        
        [Required]
        public decimal Custo { get; set; }
        
        public string CodigoUnico { get; set; } = Guid.NewGuid().ToString();
        public int QuantidadeEstoque { get; set; } = 0;
        public int EstoqueMinimo { get; set; } = 5;
        public int EstoqueMaximo { get; set; } = 100;
    }
}
