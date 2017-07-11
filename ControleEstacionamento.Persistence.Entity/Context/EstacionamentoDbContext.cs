using System.Data.Entity;

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
          
        }
    }
}
