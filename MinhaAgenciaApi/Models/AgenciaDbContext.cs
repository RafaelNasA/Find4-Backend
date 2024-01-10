using Microsoft.EntityFrameworkCore;

namespace MinhaAgenciaApi.Models
{
    public class AgenciaDbContext : DbContext
    {
        public AgenciaDbContext(DbContextOptions<AgenciaDbContext> options) : base(options)
        {
        }

    
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Destino> Destinos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
