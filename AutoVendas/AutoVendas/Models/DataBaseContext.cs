using Microsoft.EntityFrameworkCore;

namespace AutoVendas.Models
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Carro> Carros { get; set; }
    }
}
