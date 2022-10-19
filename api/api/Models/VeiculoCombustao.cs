using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
    [Table("Veiculos_combustao")]
    public class VeiculoCombustao
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Modelo { get; set; }
        [Required]
        public int Motor { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Media_consumo { get; set; }
        [Required]
        public string Imagem { get; set; }
    }
}
