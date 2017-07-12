using System.Data.Entity;
using ControleEstacionamento.Persistence.Entity.Configurations;


namespace ControleEstacionamento.Persistence.Entity.Context
{
    public class EstacionamentoDbContext : DbContext
    {
        public EstacionamentoDbContext()
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Properties<string>()
                 .Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>()
                 .Configure(p => p.HasMaxLength(500));

            modelBuilder.Configurations.Add(new VeiculoConfiguration());
            modelBuilder.Configurations.Add(new ValoresConfiguration());

        }
    }
}
