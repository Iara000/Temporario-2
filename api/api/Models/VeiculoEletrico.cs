using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
    [Table("Veiculos_eletricos")]
    public class VeiculoEletrico
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
        public decimal Capacidade_bateria { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Autonomia { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Eficiencia { get; set; }
        [Required]
        public string Imagem { get; set; }
    }
}
