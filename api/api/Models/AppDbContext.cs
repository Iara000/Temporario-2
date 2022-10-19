using Microsoft.EntityFrameworkCore;

namespace api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<VeiculoCombustao> Veiculos_combustao { get; set; }
        public DbSet<VeiculoEletrico> Veiculos_eletricos { get; set; }
    }
}
