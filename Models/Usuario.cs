using System.ComponentModel.DataAnnotations;

namespace EstoqueMaster.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        
        [Required]
        public string Nome { get; set; } = string.Empty;
        
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        
        [Required]
        public string SenhaHash { get; set; } = string.Empty;
        
        public TipoUsuario Tipo { get; set; } = TipoUsuario.Operador;
    }

    public enum TipoUsuario
    {
        Administrador,
        Operador
    }
}
