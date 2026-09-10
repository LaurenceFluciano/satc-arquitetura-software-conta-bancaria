using Entidade;
using Microsoft.EntityFrameworkCore;

namespace Repositorio.Infra
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options) 
        { 
        
        }

        public DbSet<ContaBancaria> ContasBancaria { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContaBancaria>().HasKey(p => p.Id);

            base.OnModelCreating(modelBuilder);
        }
    }
}
